using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace LearnAuthBlazor.Client.AuthProviders
{
    public class FakeAuthStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(2000);


            var anonymous = new ClaimsIdentity();   // Anonymous User (UnAuthorized)


            var user = new ClaimsIdentity(new List<Claim>()     //Authenticated User
            {
                new Claim(ClaimTypes.Name,"John Doe"),
                new Claim(ClaimTypes.Role,"Admin")

            }, "Test And Fake");


            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(user)));
        }
    }
}