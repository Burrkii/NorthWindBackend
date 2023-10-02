using Core.Entities.Concrete;
using Core.Utilities.Security.Encypiton;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public class JwtHelper //:// ITokenHelper
    {
        public IConfiguration Configration { get; }
        private TokenOptions _tokenOptions;
       // private DateTime _AccessTokenExpirations;    
        public JwtHelper(IConfiguration configration)
        {

            Configration = configration;
            _tokenOptions = Configration.GetSection(key: "TokenOptions").Get<TokenOptions>();
           // _AccessTokenExpirations = DateTime.Now.AddMinutes(_tokenOptions.AccesTokenExpiration);

        }

        //public AccessToken CreateToken(UserAssertion user, List<OperationClaim> operationClaims)
        //{
        //    var securitykey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
        //    var signingCredentials = SigningCrendentialsHelper.CreateSigningCredentials(securitykey);
        //}
        //public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions,User user,
        //    SigningCredentials signingCredentials,List<OperationClaim> operationClaims)
        //{
        //    var jwt = new JwtSecurityToken(
        //        issuer: tokenOptions.Issuer,
        //        audience: tokenOptions.Audience,
        //        expires:_AccessTokenExpirations,
        //        notBefore: DateTime.Now
        //        //claims:operationClaims,
        //        //signingCredentials:signingCredentials

        //        ) ;
        //}
        //////private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        //////{
        //////    var claims = new List<Claim>();
        //////    claims.Add(new Claim(type:"email", value: user.Email));
        //////}
    }
}
