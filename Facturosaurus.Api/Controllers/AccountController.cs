using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Models;
using Facturosaurus.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Facturosaurus.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;


        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        [Route("connection")]
        [AllowAnonymous]
        public ActionResult Test()
        {
            return Ok();
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult<List<UserDto>> GetAll()
        {
            var users = _accountService.GetAll();

            return Ok(users);
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "Administrator")]
        public ActionResult<UserDto> GetUser(Guid id)
        {
            var user = _accountService.GetUser(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
        [HttpGet]
        [Route("email/{email}")]
        [Authorize(Roles = "Administrator,Użytkownik")]
        public ActionResult<UserDto> GetUser(string email)
        {
            var user = _accountService.GetUser(email);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("checkemail/{id},{email}")]
        [Authorize(Roles = "Administrator")]
        public ActionResult<UserDto> CheckEmail(Guid id, string email)
        {
            var userWithTheSameEmail = _accountService.CheckEmailUniqueness(id, email);
            if (userWithTheSameEmail != null)
                return Ok(userWithTheSameEmail);
            return NotFound();
        }

        [HttpPost("register")]
        [Authorize(Roles = "Administrator")]
        public ActionResult RegisterUser([FromBody] UserRegisterDto newUserDto)
        {
            User result = _accountService.RegisterUser(newUserDto);

            if (result != null)
                return Created($"api/user/{result.Id}", null);
            return BadRequest();
        }

        [HttpPut]
        [Route("modify")]
        [Authorize(Roles = "Administrator")]
        public ActionResult ModifyUser([FromBody] UserModifyDto userDto)
        {
            _accountService.ModifyUser(userDto);
            return Ok();
        }

        [HttpPut]
        [Route("password")]
        [Authorize(Roles = "Administrator")]
        public ActionResult SetNewPasswordForUser([FromBody] UserNewPasswordDto userDto)
        {
            var result = _accountService.SetNewPasswordForUser(userDto);

            if (result)
                return Ok();
            return NotFound();
        }

        [HttpGet]
        [Route("Roles")]
        [AllowAnonymous]
        public ActionResult<List<RoleDto>> GetRoles()
        {
            var roles = _accountService.GetRoles();

            if (roles != null)
                return Ok(roles);
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteUser(Guid id)
        {
            var user = _accountService.DeleteUser(id);
            if (user)
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult Login([FromBody] LoginDto loginDto)
        {
            string token = _accountService.GenereteJwt(loginDto);

            return Ok(token);
        }
    }
}
