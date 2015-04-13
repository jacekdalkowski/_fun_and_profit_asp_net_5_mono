using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace hello_web_app.Infrastructure.Security
{
    public class SingleMockApplicationUserStore : IUserStore<ApplicationUser>
    {

        public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
        	return Task.FromResult("1");
        }

        public Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
        	return Task.FromResult("Jacek");
        }

        public Task SetUserNameAsync(ApplicationUser user, string userName,
            CancellationToken cancellationToken)
        {
        	throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
        	return Task.FromResult("Jacek");
        }

        public Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName,
            CancellationToken cancellationToken)
        {
        	throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
        	throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
        	throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
        	throw new NotImplementedException();
        }

        public Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
        	return Task.FromResult(new ApplicationUser(){
        		Id = "1",
        		UserName = "Jacek"
        		});
        }

        public Task<ApplicationUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
        	return Task.FromResult(new ApplicationUser(){
        		Id = "1",
        		UserName = "Jacek"
        		});
        }

        public void Dispose()
        {

        }
    }
}