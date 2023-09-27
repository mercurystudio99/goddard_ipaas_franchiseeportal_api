using FranchiseePortal.Tests.Common;
using FranchiseePortal.ToursSettingsEditor;
using System.Threading.Tasks;
using Xunit;

namespace FranchiseePortal.Tests.TourSettingsEditor
{
    public class TourSettingsEditorService_Tests : AppTestBase
    {
        private readonly ITourSettingsEditorService _sut;

        public TourSettingsEditorService_Tests()
        {
            _sut = Resolve<ITourSettingsEditorService>();
        }

        protected override void PreInitialize()
        {
            Configuration["App:Tours:Enabled"] = true.ToString();
            base.PreInitialize();            
        }

        [Fact]
        public async Task Test_GetDefaultAvailability()
        {
            // Arrange

            //Act
            var actual = await _sut.GetDefaultAvailability(KnownSchoolIds.PA_Weatherly, 30);

            //Assert
            Assert.NotNull(actual);
            Assert.True(actual.IsSystemDefault);
            Assert.NotEmpty(actual.Blocks);
        }
    }
}
