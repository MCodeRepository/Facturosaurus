using Facturosaurus.Forms.dtos;
using Facturosaurus.Forms.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;


namespace Facturosaurus.Forms.Api.Services
{
    internal class AccountService
    {

        private readonly HttpClient _httpClient;

        public AccountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Result<bool> Connected()
        {
            if (_httpClient.BaseAddress != null)
            {
                try
                {
                    HttpResponseMessage response = _httpClient.GetAsync("/api/user/connection").Result;

                    if (response.StatusCode == HttpStatusCode.OK)
                        return new Result<bool> { Value = true, Status = (int)response.StatusCode };
                    return new Result<bool> { Value = false, Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<bool> { Status = 1114 };
                }
            }
            else
                return new Result<bool> { Status = 1001 };
        }

        public Result<List<UserDto>> GetUsersList()
        {
            if (_httpClient.BaseAddress != null)
            {
                List<UserDto> userList;

                try
                {
                    HttpResponseMessage response = _httpClient.GetAsync("/api/user").Result;
                    userList = response.Content.ReadAsAsync<List<UserDto>>().Result;

                    return new Result<List<UserDto>> { Value = userList, Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<List<UserDto>> { Status = 1100 };
                }
            }
            else
                return new Result<List<UserDto>> { Status = 1001 };
        }

        public Result<UserDto> GetUser(Guid id)
        {
            if (_httpClient.BaseAddress != null)
            {
                UserDto userDto;
                try
                {
                    HttpResponseMessage response = _httpClient.GetAsync($"/api/user/{id}").Result;
                    userDto = response.Content.ReadAsAsync<UserDto>().Result;

                    return new Result<UserDto> { Value = userDto, Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<UserDto> { Status = 1101 };
                }
            }
            else
                return new Result<UserDto> { Status = 1001 };
        }

        public Result<UserDto> GetUser(string email)
        {
            if (_httpClient.BaseAddress != null)
            {
                UserDto userDto;
                try
                {
                    HttpResponseMessage response = _httpClient.GetAsync($"/api/user/email/{email}").Result;
                    userDto = response.Content.ReadAsAsync<UserDto>().Result;

                    return new Result<UserDto> { Value = userDto, Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<UserDto> { Status = 1101 };
                }
            }
            else
                return new Result<UserDto> { Status = 1001 };
        }

        public Result<List<RoleDto>> GetRolesList()
        {
            if (_httpClient.BaseAddress != null)
            {
                List<RoleDto> rolesList;
                try
                {
                    HttpResponseMessage response = _httpClient.GetAsync("/api/user/Roles").Result;
                    rolesList = response.Content.ReadAsAsync<List<RoleDto>>().Result;

                    return new Result<List<RoleDto>> { Value = rolesList, Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<List<RoleDto>> { Status = 1102 };
                }
            }
            else
                return new Result<List<RoleDto>> { Status = 1001 };
        }

        public Result<UserDto> DeleteUser(Guid id)
        {
            if (_httpClient.BaseAddress != null)
            {
                try
                {
                    HttpResponseMessage response = _httpClient.DeleteAsync($"/api/user/{id}").Result;

                    return new Result<UserDto> { Status = (int)response.StatusCode };
                }
                catch (Exception)
                {
                    return new Result<UserDto> { Status = 1103 };
                }
            }
            else
                return new Result<UserDto> { Status = 1001 };
        }

        public Result<UserDto> RegisterUser(UserRegisterDto userRegisterDto)
        {
            if (_httpClient.BaseAddress != null)
            {
                if (userRegisterDto != null)
                {
                    try
                    {
                        var response = _httpClient.PostAsJsonAsync<UserRegisterDto>("/api/user/register", userRegisterDto).Result;

                        return new Result<UserDto> { Status = (int)response.StatusCode };
                    }
                    catch (Exception)
                    {
                        return new Result<UserDto> { Status = 1104 };
                    }
                }
                else
                    return new Result<UserDto> { Status = 1105 };
            }
            else
                return new Result<UserDto> { Status = 1001 };
        }

        public Result<UserDto> ModifyUser(UserModifyDto userModifyDto)
        {
            if (_httpClient.BaseAddress != null)
            {
                if (userModifyDto != null)
                {
                    try
                    {
                        var adressEmailUsed = _httpClient.GetAsync($"/api/user/checkemail/{userModifyDto.Id},{userModifyDto.Email}").Result;

                        if (!adressEmailUsed.IsSuccessStatusCode)
                        {
                            var request = _httpClient.PutAsJsonAsync<UserModifyDto>("/api/user/modify", userModifyDto).Result;

                            switch (request.StatusCode)
                            {
                                case HttpStatusCode.OK:
                                    return new Result<UserDto>() { Status = (int)request.StatusCode };
                                case HttpStatusCode.Conflict:
                                    return new Result<UserDto>() { Status = 1106 };
                                default:
                                    return new Result<UserDto>() { Status = 1107 };
                            }
                        }
                        else
                        {
                            return new Result<UserDto>() { Status = 1111 };
                        }
                    }
                    catch (Exception)
                    {
                        return new Result<UserDto>() { Status = 1107 };
                    }
                }
                else
                    return new Result<UserDto>() { Status = 1108 };
            }
            else
                return new Result<UserDto>() { Status = 1101 };
        }

        public Result<UserDto> ChangePassword(UserNewPasswordDto userNewPasswordDto)
        {

            if (_httpClient.BaseAddress != null)
            {
                if (userNewPasswordDto != null)
                {
                    try
                    {
                        var request = _httpClient.PutAsJsonAsync<UserNewPasswordDto>("/api/user/password", userNewPasswordDto).Result;

                        return new Result<UserDto>() { Status = (int)request.StatusCode };
                    }
                    catch (Exception)
                    {
                        return new Result<UserDto>() { Status = 1109 };
                    }
                }
                else
                    return new Result<UserDto>() { Status = 1110 };
            }
            else
                return new Result<UserDto>() { Status = 1101 };

        }

        public Result<string> Login(LoginDto loginDto)
        {
            if (_httpClient.BaseAddress != null)
            {
                if (loginDto != null)
                {
                    try
                    {
                        var response = _httpClient.PostAsJsonAsync<LoginDto>("/api/user/login", loginDto).Result;

                        var responseBody = response.Content.ReadAsStringAsync().Result;

                        return new Result<string>() { Value = responseBody, Status = (int)response.StatusCode };
                    }
                    catch (Exception)
                    {
                        return new Result<string>() { Status = 1112 };
                    }
                }
                else
                    return new Result<string>() { Status = 1113 };
            }
            else
                return new Result<string>() { Status = 1101 };
        }
    }
}
