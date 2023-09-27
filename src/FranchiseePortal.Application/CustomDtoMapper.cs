﻿using FranchiseePortal.ResourceLinks.Dtos;
using FranchiseePortal.ResourceLinks;
using FranchiseePortal.Insights.Dtos;
using FranchiseePortal.Insights;
using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.DynamicEntityProperties;
using Abp.EntityHistory;
using Abp.Localization;
using Abp.Notifications;
using Abp.Organizations;
using Abp.UI.Inputs;
using Abp.Webhooks;
using AutoMapper;
using IdentityServer4.Extensions;
using FranchiseePortal.Auditing.Dto;
using FranchiseePortal.Authorization.Accounts.Dto;
using FranchiseePortal.Authorization.Delegation;
using FranchiseePortal.Authorization.Permissions.Dto;
using FranchiseePortal.Authorization.Roles;
using FranchiseePortal.Authorization.Roles.Dto;
using FranchiseePortal.Authorization.Users;
using FranchiseePortal.Authorization.Users.Delegation.Dto;
using FranchiseePortal.Authorization.Users.Dto;
using FranchiseePortal.Authorization.Users.Importing.Dto;
using FranchiseePortal.Authorization.Users.Profile.Dto;
using FranchiseePortal.Chat;
using FranchiseePortal.Chat.Dto;
using FranchiseePortal.DynamicEntityProperties.Dto;
using FranchiseePortal.Editions;
using FranchiseePortal.Editions.Dto;
using FranchiseePortal.Friendships;
using FranchiseePortal.Friendships.Cache;
using FranchiseePortal.Friendships.Dto;
using FranchiseePortal.Localization.Dto;
using FranchiseePortal.MultiTenancy;
using FranchiseePortal.MultiTenancy.Dto;
using FranchiseePortal.MultiTenancy.HostDashboard.Dto;
using FranchiseePortal.MultiTenancy.Payments;
using FranchiseePortal.MultiTenancy.Payments.Dto;
using FranchiseePortal.Notifications.Dto;
using FranchiseePortal.Organizations.Dto;
using FranchiseePortal.Sessions.Dto;
using FranchiseePortal.WebHooks.Dto;
using FranchiseePortal.SchoolsWebApiClient.Model;
using FranchiseePortal.FacultiesWebApiClient.Model;
using FranchiseePortal.LeadsWebApiClient.Model;
using FranchiseePortal.ToursEditor.Dtos;
using FranchiseePortal.ToursWebApiClient.Model;
using FranchiseePortal.LeadsEditor.Dtos;
using FranchiseePortal.ToursSettingsEditor.Dtos;
using FranchiseePortal.Application.Shared.LeadsEditor.Models;

namespace FranchiseePortal
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CreateOrEditResourceLinkDto, ResourceLink>().ReverseMap();
            configuration.CreateMap<ResourceLinkDto, ResourceLink>().ReverseMap();
            configuration.CreateMap<CreateOrEditInsightDto, Insight>().ReverseMap();
            configuration.CreateMap<InsightDto, Insight>().ReverseMap();
            //Inputs
            configuration.CreateMap<CheckboxInputType, FeatureInputTypeDto>();
            configuration.CreateMap<SingleLineStringInputType, FeatureInputTypeDto>();
            configuration.CreateMap<ComboboxInputType, FeatureInputTypeDto>();
            configuration.CreateMap<IInputType, FeatureInputTypeDto>()
                .Include<CheckboxInputType, FeatureInputTypeDto>()
                .Include<SingleLineStringInputType, FeatureInputTypeDto>()
                .Include<ComboboxInputType, FeatureInputTypeDto>();
            configuration.CreateMap<StaticLocalizableComboboxItemSource, LocalizableComboboxItemSourceDto>();
            configuration.CreateMap<ILocalizableComboboxItemSource, LocalizableComboboxItemSourceDto>()
                .Include<StaticLocalizableComboboxItemSource, LocalizableComboboxItemSourceDto>();
            configuration.CreateMap<LocalizableComboboxItem, LocalizableComboboxItemDto>();
            configuration.CreateMap<ILocalizableComboboxItem, LocalizableComboboxItemDto>()
                .Include<LocalizableComboboxItem, LocalizableComboboxItemDto>();

            //Chat
            configuration.CreateMap<ChatMessage, ChatMessageDto>();
            configuration.CreateMap<ChatMessage, ChatMessageExportDto>();

            //Feature
            configuration.CreateMap<FlatFeatureSelectDto, Feature>().ReverseMap();
            configuration.CreateMap<Feature, FlatFeatureDto>();

            //Role
            configuration.CreateMap<RoleEditDto, Role>().ReverseMap();
            configuration.CreateMap<Role, RoleListDto>();
            configuration.CreateMap<UserRole, UserListRoleDto>();

            //Edition
            configuration.CreateMap<EditionEditDto, SubscribableEdition>().ReverseMap();
            configuration.CreateMap<EditionCreateDto, SubscribableEdition>();
            configuration.CreateMap<EditionSelectDto, SubscribableEdition>().ReverseMap();
            configuration.CreateMap<SubscribableEdition, EditionInfoDto>();

            configuration.CreateMap<Edition, EditionInfoDto>().Include<SubscribableEdition, EditionInfoDto>();

            configuration.CreateMap<SubscribableEdition, EditionListDto>();
            configuration.CreateMap<Edition, EditionEditDto>();
            configuration.CreateMap<Edition, SubscribableEdition>();
            configuration.CreateMap<Edition, EditionSelectDto>();

            //Payment
            configuration.CreateMap<SubscriptionPaymentDto, SubscriptionPayment>().ReverseMap();
            configuration.CreateMap<SubscriptionPaymentListDto, SubscriptionPayment>().ReverseMap();
            configuration.CreateMap<SubscriptionPayment, SubscriptionPaymentInfoDto>();

            //Permission
            configuration.CreateMap<Permission, FlatPermissionDto>();
            configuration.CreateMap<Permission, FlatPermissionWithLevelDto>();

            //Language
            configuration.CreateMap<ApplicationLanguage, ApplicationLanguageListDto>();
            configuration.CreateMap<NotificationDefinition, NotificationSubscriptionWithDisplayNameDto>();
            configuration.CreateMap<ApplicationLanguage, ApplicationLanguageEditDto>()
                .ForMember(ldto => ldto.IsEnabled, options => options.MapFrom(l => !l.IsDisabled));

            //Tenant
            configuration.CreateMap<Tenant, RecentTenant>();
            configuration.CreateMap<Tenant, TenantLoginInfoDto>();
            configuration.CreateMap<Tenant, TenantListDto>();
            configuration.CreateMap<TenantEditDto, Tenant>().ReverseMap();
            configuration.CreateMap<CurrentTenantInfoDto, Tenant>().ReverseMap();

            //User
            configuration.CreateMap<User, UserEditDto>()
                .ForMember(dto => dto.Password, options => options.Ignore())
                .ReverseMap()
                .ForMember(user => user.Password, options => options.Ignore());
            configuration.CreateMap<User, UserLoginInfoDto>();
            configuration.CreateMap<User, UserListDto>();
            configuration.CreateMap<User, ChatUserDto>();
            configuration.CreateMap<User, OrganizationUnitUserListDto>();
            configuration.CreateMap<Role, OrganizationUnitRoleListDto>();
            configuration.CreateMap<CurrentUserProfileEditDto, User>().ReverseMap();
            configuration.CreateMap<UserLoginAttemptDto, UserLoginAttempt>().ReverseMap();
            configuration.CreateMap<ImportUserDto, User>();

            //AuditLog
            configuration.CreateMap<AuditLog, AuditLogListDto>();
            configuration.CreateMap<EntityChange, EntityChangeListDto>();
            configuration.CreateMap<EntityPropertyChange, EntityPropertyChangeDto>();

            //Friendship
            configuration.CreateMap<Friendship, FriendDto>();
            configuration.CreateMap<FriendCacheItem, FriendDto>();

            //OrganizationUnit
            configuration.CreateMap<OrganizationUnit, OrganizationUnitDto>();

            //Webhooks
            configuration.CreateMap<WebhookSubscription, GetAllSubscriptionsOutput>();
            configuration.CreateMap<WebhookSendAttempt, GetAllSendAttemptsOutput>()
                .ForMember(webhookSendAttemptListDto => webhookSendAttemptListDto.WebhookName,
                    options => options.MapFrom(l => l.WebhookEvent.WebhookName))
                .ForMember(webhookSendAttemptListDto => webhookSendAttemptListDto.Data,
                    options => options.MapFrom(l => l.WebhookEvent.Data));

            configuration.CreateMap<WebhookSendAttempt, GetAllSendAttemptsOfWebhookEventOutput>();

            configuration.CreateMap<DynamicProperty, DynamicPropertyDto>().ReverseMap();
            configuration.CreateMap<DynamicPropertyValue, DynamicPropertyValueDto>().ReverseMap();
            configuration.CreateMap<DynamicEntityProperty, DynamicEntityPropertyDto>()
                .ForMember(dto => dto.DynamicPropertyName,
                    options => options.MapFrom(entity => entity.DynamicProperty.DisplayName.IsNullOrEmpty() ? entity.DynamicProperty.PropertyName : entity.DynamicProperty.DisplayName));
            configuration.CreateMap<DynamicEntityPropertyDto, DynamicEntityProperty>();

            configuration.CreateMap<DynamicEntityPropertyValue, DynamicEntityPropertyValueDto>().ReverseMap();

            //User Delegations
            configuration.CreateMap<CreateUserDelegationDto, UserDelegation>();

            /* ADD YOUR OWN CUSTOM AUTOMAPPER MAPPINGS HERE */

            //School address
            configuration.CreateMap<Address, AddressDto>();

            //School
            configuration.CreateMap<School, SchoolInfoDto>()
                .ForMember(d => d.Address, opt => opt.MapFrom(s => s.Address1));

            //Faculties
            configuration.CreateMap<FacultyBios, PostFacultyBiosRequest>();

            // Tours
            CreateToursMappings(configuration);
        }

        internal static void CreateToursMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<ChildLead, TourItemLeadChildDto>();
            configuration.CreateMap<LeadDto, TourItemLeadDto>()
                .ForMember(x => x.LevelOfInterest, opt => opt.Ignore());
            configuration.CreateMap<LeadFindResult, LeadFindDto>()
                .IncludeMembers(x => x.LeadFindResultDto);
            configuration.CreateMap<LeadDto, LeadFindDto>()
                .ForMember(x => x.HasUpcomingTour, opt => opt.Ignore());

            configuration.CreateMap<TourDto, TourItemDto>()
                // Leads get mapped from Leads API
                .ForMember(x => x.Lead, opt => opt.Ignore());

            configuration.CreateMap<TourDto, TourInputDto>();

            configuration.CreateMap<TourSettingsDto, AppTourSettingsDto>()
                // Retrieved from app settings
                .ForMember(x => x.AllowedTourDurationOptionsInMinutes, opt => opt.Ignore())
                .ForMember(x => x.OnlineOptions, opt => opt.Ignore());

            configuration.CreateMap<TourSettingsDto, TourSettingsInputDto>();

            // Only need source properties because our code maps to pre-populated target DTO
            configuration.CreateMap<SaveOnlineTourSettingsInput, TourSettingsInputDto>(
                MemberList.Source);
        }
    }
}
