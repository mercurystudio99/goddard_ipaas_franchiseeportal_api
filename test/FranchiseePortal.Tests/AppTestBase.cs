using FranchiseePortal.Test.Base;
using System.Collections.Generic;

namespace FranchiseePortal.Tests
{
    public class AppTestBase : AppTestBase<FranchiseePortalTestModule>
    {
        /// <summary>
        /// Additional configuration on top of default configuration providers
        /// </summary>
        public IDictionary<string, string> Configuration
        {
            get
            {
                return TestAppConfigurationAccessor.InMemoryCollection;
            } 
        }
    }
}