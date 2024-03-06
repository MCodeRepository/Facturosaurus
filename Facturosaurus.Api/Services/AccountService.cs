using AutoMapper;
using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Exceptions;
using Facturosaurus.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Facturosaurus.Api.Services
{
    public interface IAccountService
    {
        List<UserDto> GetAll();
        UserDto GetUser(Guid userId);
        UserDto GetUser(string email);
        void ModifyUser(UserModifyDto userDto);
        User RegisterUser(UserRegisterDto newUserDto);
        bool SetNewPasswordForUser(UserNewPasswordDto userDto);
        bool DeleteUser(Guid userId);
        List<RoleDto> GetRoles();
        UserDto CheckEmailUniqueness(Guid userId, string email);
        string GenereteJwt(LoginDto loginDto);
    }

    public class AccountService : IAccountService
    {
        private readonly FacturosaurusDbContext _dbContext;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IMapper _mapper;
        private readonly AuthenticationSettings _authenticationSettings;

        public AccountService(FacturosaurusDbContext dbContext, IPasswordHasher<User> passwordHasher, IMapper mapper, AuthenticationSettings authenticationSettings)
        {
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
            _authenticationSettings = authenticationSettings;
        }

        public List<UserDto> GetAll() //D
        {
            var users = _dbContext.Users
                .Include(u => u.Role)
                .ToList();

            var usersListDto = _mapper.Map<List<UserDto>>(users);

            return usersListDto;
        }

        public UserDto GetUser(Guid userId) //D
        {
            var user = _dbContext.Users
                .Where(u => u.Id == userId)
                .Include(u => u.Role)
                .FirstOrDefault();


            if (user != null)
            {
                var userDto = _mapper.Map<UserDto>(user);

                return userDto;
            }
            return null;
        }

        public UserDto GetUser(string email)
        {
            var user = _dbContext.Users
                .Where(u => u.Email.Trim() == email.Trim())
                .Include(u => u.Role)
                .FirstOrDefault();


            if (user != null)
            {
                var userDto = _mapper.Map<UserDto>(user);

                return userDto;
            }
            return null;
        }

        public UserDto CheckEmailUniqueness(Guid userId, string email)
        {
            var user = _dbContext.Users.Where(x => x.Email == email && x.Id != userId).FirstOrDefault();

            if (user != null)
            {
                var userDto = _mapper.Map<UserDto>(user);

                return userDto;
            }
            return null;
        }

        public User RegisterUser(UserRegisterDto newUserDto) //D
        {
            var newUserId = Guid.NewGuid();

            var newUser = _mapper.Map<User>(newUserDto);
            newUser.Id = newUserId;
            newUser.CreatedDate = DateTime.Now;

            var hashedPassword = _passwordHasher.HashPassword(newUser, newUserDto.Password);

            newUser.PasswordHash = hashedPassword;

            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();

            return newUser;
        }

        public void ModifyUser(UserModifyDto userDto) //D
        {
            var user = _dbContext.Users.Where(u => u.Id == userDto.Id).FirstOrDefault();

            if (user != null)
            {
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;
                user.Email = userDto.Email;
                user.PhoneNumber = userDto.PhoneNumber;
                user.Active = userDto.Active;
                user.RoleId = userDto.RoleId;

                _dbContext.SaveChanges();
            }
            else
                throw new NotFoundException("User not found.");

        }

        public bool SetNewPasswordForUser(UserNewPasswordDto userDto) //D
        {
            var user = _dbContext.Users.Where(u => u.Id == userDto.Id).FirstOrDefault();

            if (user != null)
            {
                var hashedPassword = _passwordHasher.HashPassword(user, userDto.Password);
                user.PasswordHash = hashedPassword;

                _dbContext.SaveChanges();
                return true;
            };
            return false;
        }

        public List<RoleDto> GetRoles()
        {
            var roles = _dbContext.Roles.ToList();
            var rolesDto = _mapper.Map<List<RoleDto>>(roles);

            if (rolesDto != null)
            {
                return rolesDto;
            };
            return null;
        }

        public bool DeleteUser(Guid userId)
        {
            var user = _dbContext.Users
                .Where(u => u.Id == userId)
                .FirstOrDefault();

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        public string GenereteJwt(LoginDto loginDto)
        {
            var user = _dbContext.Users
                .Include(r => r.Role)
                .FirstOrDefault(u => u.Email == loginDto.Email);

            if (user is null)
                throw new IncorrectPasswordOrEmailException("Email lub hasło jest niepoprawne.");

            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, loginDto.Password);

            if (result == PasswordVerificationResult.Failed)
            {
                throw new IncorrectPasswordOrEmailException("Email lub hasło jest niepoprawne.");
            }

            var clames = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
                new Claim(ClaimTypes.Role, $"{user.Role.Name}"),
                //new Claim("Nationality", user.Nationality)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

            var token = new JwtSecurityToken(
                _authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                clames,
                expires: expires,
                signingCredentials: cred);

            var tokenHendler = new JwtSecurityTokenHandler();

            return tokenHendler.WriteToken(token);
        }
    }
}
