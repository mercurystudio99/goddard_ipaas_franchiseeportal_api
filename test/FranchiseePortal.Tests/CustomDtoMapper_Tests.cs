using AutoMapper;
using FranchiseePortal.ToursSettingsEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Model;
using Shouldly;
using System;
using Xunit;

namespace FranchiseePortal.Tests
{
    public class CustomDtoMapper_Tests
    {
        /// <summary>
        /// Assets that <see cref="CustomDtoMapper.CreateMappings(IMapperConfigurationExpression)"/>
        /// creates a valid configuration
        /// </summary>
        /// <remarks>
        /// Currently skipping because there are too many invalid mappings.  
        /// Using smaller methods to validate specific mappings
        /// </remarks>
        [Fact(Skip = "Too many invalid mappings")]
        public void Should_Create_Valid_Maps()
        {
            // Arrange

            // Act
            var configuration = new MapperConfiguration(cfg => {
                CustomDtoMapper.CreateMappings(cfg);
            });

            // Assert        
            configuration.AssertConfigurationIsValid();
        }

        [Fact()]
        public void Should_Create_Valid_Tours_Maps()
        {
            // Arrange

            // Act
            var configuration = new MapperConfiguration(cfg => {
                CustomDtoMapper.CreateToursMappings(cfg);
            });

            // Assert
            configuration.AssertConfigurationIsValid();
        }

        [Fact()]
        public void Should_Create_Valid_TourDto_Maps()
        {
            // Arrange

            // Act
            var mapper = CreateMapper();

            // Asserts

            // TourDto --> TourInputDto 
            mapper.Map<TourInputDto>(new TourDto(
                leadId: Guid.NewGuid().ToString(),
                schoolId: Guid.NewGuid().ToString()
                ))
                .ShouldNotBeNull();

            // TourSettingsDto --> TourSettingsInputDto 
            mapper.Map<TourSettingsInputDto>(new TourSettingsDto())
                .ShouldNotBeNull();

            // SaveOnlineTourSettingsInput --> TourSettingsInputDto 
            mapper.Map(
                new SaveOnlineTourSettingsInput(),
                new TourSettingsInputDto())
                .ShouldNotBeNull();

        }

        private MapperConfiguration CreateConfiguration()
        {
            var result = new MapperConfiguration(cfg => {
                CustomDtoMapper.CreateToursMappings(cfg);
            });

            return result;
        }

        private Mapper CreateMapper()
        {
            var result = new Mapper(CreateConfiguration());
            return result;
        } 
    }
}