using Abp.Dependency;
using Abp.Reflection.Extensions;
using FranchiseePortal.Configuration;
using Microsoft.Extensions.Configuration;
using System.Collections.Concurrent;

namespace FranchiseePortal.Test.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 20230915RBP - Added <see cref="InMemoryCollection"/> so that we could specify
    /// configuration per test if needed.  I could not figure out a way to make the in-memory 
    /// collection injectable so the static collection is cleared in the <see cref="AppTestBase{T}"/> constructor
    /// </remarks>
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        private IConfigurationRoot _configuration;

        /// <summary>
        /// Any additional in-memory configuration to override in tests
        /// </summary>
        public static ConcurrentDictionary<string, string> InMemoryCollection
        {
            get;
        }

        public IConfigurationRoot Configuration {
            get
            {
                var result = _configuration;
                
                if(InMemoryCollection.Count > 0)
                {
                    // In-memory collection specified

                    // Add to base configuration
                    result = new ConfigurationBuilder()
                        .AddConfiguration(result)
                        .AddInMemoryCollection(InMemoryCollection)
                        .Build();
                }

                return result;
            } 
        }

        static TestAppConfigurationAccessor()
        {
            InMemoryCollection = new ConcurrentDictionary<string, string>();
        }

        public TestAppConfigurationAccessor()
        {
            _configuration = AppConfigurations.Get(
                typeof(FranchiseePortalTestBaseModule).GetAssembly().GetDirectoryPathOrNull(),
                addUserSecrets: true
            );
        }

    }
}
