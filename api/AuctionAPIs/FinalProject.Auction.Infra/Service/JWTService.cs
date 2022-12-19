using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FinalProject.Auction.Infra.Service
{
   public  class JWTService:IJWTService
    {
        private readonly IJWTRepository jWTRepository;
        public JWTService(IJWTRepository _jWTRepository)
        {
            jWTRepository = _jWTRepository;

        }
        public string Auth(Login login)
        {
            var result = jWTRepository.Authentication(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                //1- token handler : generate token
                //2- token key :to encode data to token ( secure value)
                //3-token descriptor :  username, rolename +expire == session timeout +
                //signcredintia== (to assin which encoding method to used ) Hacsha256signtre(method used to encode data ) 
                var tokenhandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                   {
                    new Claim (ClaimTypes.Email , result.Email),
                    new Claim(ClaimTypes.Role,result.RoleId.ToString())

                }),
                    //expire == session timeout
                    Expires = DateTime.UtcNow.AddHours(1),
                    //signcredintia== (to assin which encoding method to used ) Hacsha256signtre(method used to encode data ) 
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256)
                };
                var token = tokenhandler.CreateToken(tokenDescriptor);
                return tokenhandler.WriteToken(token); // return token 
            }
        }

    }
}
