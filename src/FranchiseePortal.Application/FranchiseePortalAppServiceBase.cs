using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.MultiTenancy;
using Abp.Runtime.Session;
using Abp.Threading;
using Microsoft.AspNetCore.Identity;
using FranchiseePortal.Authorization.Users;
using FranchiseePortal.MultiTenancy;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using FranchiseePortal.Authorization.Schools;
using System.Threading;

namespace FranchiseePortal
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class FranchiseePortalAppServiceBase : ApplicationService
    {
        /// <summary>
        /// .NET Core Authorization service (property-injected)
        /// </summary>
        public IAuthorizationService AuthorizationService {
            get;
            set;
        }

        /// <summary>
        /// .NET Core HTTP context accessor to gain access to current ClaimsPrincipal
        /// (property-injected)
        /// </summary>
        public IHttpContextAccessor HttpContextAccessor {
            get;
            set;
        }

        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected FranchiseePortalAppServiceBase()
        {
            LocalizationSourceName = FranchiseePortalConsts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual User GetCurrentUser()
        {
            return AsyncHelper.RunSync(GetCurrentUserAsync);
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            using (CurrentUnitOfWork.SetTenantId(null))
            {
                return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
            }
        }

        protected virtual Tenant GetCurrentTenant()
        {
            using (CurrentUnitOfWork.SetTenantId(null))
            {
                return TenantManager.GetById(AbpSession.GetTenantId());
            }
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        /// <summary>
        /// Authorize current user to access school
        /// </summary>
        /// <param name="schoolId"></param>
        /// <returns></returns>
        protected async virtual Task<bool> AuthorizeForSchoolAsync(string schoolId) 
        {
            if(AuthorizationService == null)
            {
                // AuthorizationService will not be property injected in tests
                // because the service is registered in the Host startup code
                // which is not a dependent module of the tests module and I'm not sure
                // we want to do that 
                return true;
            }

            var result = await AuthorizationService.AuthorizeAsync(
                    HttpContextAccessor.HttpContext.User,
                    schoolId, 
                    new[] {
                        SchoolOperations.Read
                    });

            return result.Succeeded;
        }
        
    }
}
