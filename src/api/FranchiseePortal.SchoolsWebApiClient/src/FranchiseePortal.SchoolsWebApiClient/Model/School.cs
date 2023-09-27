/*
 * Goddard iPaaS Schools API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FranchiseePortal.SchoolsWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.SchoolsWebApiClient.Model
{
    /// <summary>
    /// School
    /// </summary>
    [DataContract(Name = "School")]
    public partial class School : IEquatable<School>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="School" /> class.
        /// </summary>
        /// <param name="acceptingChildrenDate">acceptingChildrenDate.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="actualBuildingPermitDate">actualBuildingPermitDate.</param>
        /// <param name="addressConfirmedDate">addressConfirmedDate.</param>
        /// <param name="address1">address1.</param>
        /// <param name="advertisingName">advertisingName.</param>
        /// <param name="crmId">crmId.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="features">features.</param>
        /// <param name="fmsId">fmsId.</param>
        /// <param name="hours">hours.</param>
        /// <param name="scheduledDate">scheduledDate.</param>
        /// <param name="socialMediaId">socialMediaId.</param>
        /// <param name="telephone">telephone.</param>
        /// <param name="timeZone">timeZone.</param>
        public School(DateTime? acceptingChildrenDate = default(DateTime?), int? accountType = default(int?), DateTime? actualBuildingPermitDate = default(DateTime?), DateTime? addressConfirmedDate = default(DateTime?), Address address1 = default(Address), string advertisingName = default(string), string crmId = default(string), string emailAddress = default(string), List<SchoolFeature> features = default(List<SchoolFeature>), string fmsId = default(string), string hours = default(string), DateTime? scheduledDate = default(DateTime?), string socialMediaId = default(string), string telephone = default(string), string timeZone = default(string))
        {
            this.AcceptingChildrenDate = acceptingChildrenDate;
            this.AccountType = accountType;
            this.ActualBuildingPermitDate = actualBuildingPermitDate;
            this.AddressConfirmedDate = addressConfirmedDate;
            this.Address1 = address1;
            this.AdvertisingName = advertisingName;
            this.CrmId = crmId;
            this.EmailAddress = emailAddress;
            this.Features = features;
            this.FmsId = fmsId;
            this.Hours = hours;
            this.ScheduledDate = scheduledDate;
            this.SocialMediaId = socialMediaId;
            this.Telephone = telephone;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// Gets or Sets AcceptingChildrenDate
        /// </summary>
        [DataMember(Name = "acceptingChildrenDate", EmitDefaultValue = true)]
        public DateTime? AcceptingChildrenDate { get; set; }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "accountType", EmitDefaultValue = true)]
        public int? AccountType { get; set; }

        /// <summary>
        /// Gets or Sets ActualBuildingPermitDate
        /// </summary>
        [DataMember(Name = "actualBuildingPermitDate", EmitDefaultValue = true)]
        public DateTime? ActualBuildingPermitDate { get; set; }

        /// <summary>
        /// Gets or Sets AddressConfirmedDate
        /// </summary>
        [DataMember(Name = "addressConfirmedDate", EmitDefaultValue = true)]
        public DateTime? AddressConfirmedDate { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name = "address1", EmitDefaultValue = false)]
        public Address Address1 { get; set; }

        /// <summary>
        /// Gets or Sets AdvertisingName
        /// </summary>
        [DataMember(Name = "advertisingName", EmitDefaultValue = true)]
        public string AdvertisingName { get; set; }

        /// <summary>
        /// Gets or Sets CrmId
        /// </summary>
        [DataMember(Name = "crmId", EmitDefaultValue = true)]
        public string CrmId { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name = "emailAddress", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", EmitDefaultValue = true)]
        public List<SchoolFeature> Features { get; set; }

        /// <summary>
        /// Gets or Sets FmsId
        /// </summary>
        [DataMember(Name = "fmsId", EmitDefaultValue = true)]
        public string FmsId { get; set; }

        /// <summary>
        /// Gets or Sets HasGeolocation
        /// </summary>
        [DataMember(Name = "hasGeolocation", EmitDefaultValue = true)]
        public bool HasGeolocation { get; private set; }

        /// <summary>
        /// Returns false as HasGeolocation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasGeolocation()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; private set; }

        /// <summary>
        /// Returns false as IsActive should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsActive()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsClosed
        /// </summary>
        [DataMember(Name = "isClosed", EmitDefaultValue = true)]
        public bool IsClosed { get; private set; }

        /// <summary>
        /// Returns false as IsClosed should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsClosed()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsComingSoon
        /// </summary>
        [DataMember(Name = "isComingSoon", EmitDefaultValue = true)]
        public bool IsComingSoon { get; private set; }

        /// <summary>
        /// Returns false as IsComingSoon should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsComingSoon()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsInTraining
        /// </summary>
        [DataMember(Name = "isInTraining", EmitDefaultValue = true)]
        public bool IsInTraining { get; private set; }

        /// <summary>
        /// Returns false as IsInTraining should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsInTraining()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name = "hours", EmitDefaultValue = true)]
        public string Hours { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledDate
        /// </summary>
        [DataMember(Name = "scheduledDate", EmitDefaultValue = true)]
        public DateTime? ScheduledDate { get; set; }

        /// <summary>
        /// Gets or Sets ShowOnPublicWebsite
        /// </summary>
        [DataMember(Name = "showOnPublicWebsite", EmitDefaultValue = true)]
        public bool ShowOnPublicWebsite { get; private set; }

        /// <summary>
        /// Returns false as ShowOnPublicWebsite should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeShowOnPublicWebsite()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SocialMediaId
        /// </summary>
        [DataMember(Name = "socialMediaId", EmitDefaultValue = true)]
        public string SocialMediaId { get; set; }

        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        [DataMember(Name = "telephone", EmitDefaultValue = true)]
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class School {\n");
            sb.Append("  AcceptingChildrenDate: ").Append(AcceptingChildrenDate).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  ActualBuildingPermitDate: ").Append(ActualBuildingPermitDate).Append("\n");
            sb.Append("  AddressConfirmedDate: ").Append(AddressConfirmedDate).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  AdvertisingName: ").Append(AdvertisingName).Append("\n");
            sb.Append("  CrmId: ").Append(CrmId).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  FmsId: ").Append(FmsId).Append("\n");
            sb.Append("  HasGeolocation: ").Append(HasGeolocation).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsClosed: ").Append(IsClosed).Append("\n");
            sb.Append("  IsComingSoon: ").Append(IsComingSoon).Append("\n");
            sb.Append("  IsInTraining: ").Append(IsInTraining).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  ScheduledDate: ").Append(ScheduledDate).Append("\n");
            sb.Append("  ShowOnPublicWebsite: ").Append(ShowOnPublicWebsite).Append("\n");
            sb.Append("  SocialMediaId: ").Append(SocialMediaId).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as School);
        }

        /// <summary>
        /// Returns true if School instances are equal
        /// </summary>
        /// <param name="input">Instance of School to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(School input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptingChildrenDate == input.AcceptingChildrenDate ||
                    (this.AcceptingChildrenDate != null &&
                    this.AcceptingChildrenDate.Equals(input.AcceptingChildrenDate))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.ActualBuildingPermitDate == input.ActualBuildingPermitDate ||
                    (this.ActualBuildingPermitDate != null &&
                    this.ActualBuildingPermitDate.Equals(input.ActualBuildingPermitDate))
                ) && 
                (
                    this.AddressConfirmedDate == input.AddressConfirmedDate ||
                    (this.AddressConfirmedDate != null &&
                    this.AddressConfirmedDate.Equals(input.AddressConfirmedDate))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.AdvertisingName == input.AdvertisingName ||
                    (this.AdvertisingName != null &&
                    this.AdvertisingName.Equals(input.AdvertisingName))
                ) && 
                (
                    this.CrmId == input.CrmId ||
                    (this.CrmId != null &&
                    this.CrmId.Equals(input.CrmId))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.FmsId == input.FmsId ||
                    (this.FmsId != null &&
                    this.FmsId.Equals(input.FmsId))
                ) && 
                (
                    this.HasGeolocation == input.HasGeolocation ||
                    this.HasGeolocation.Equals(input.HasGeolocation)
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.IsClosed == input.IsClosed ||
                    this.IsClosed.Equals(input.IsClosed)
                ) && 
                (
                    this.IsComingSoon == input.IsComingSoon ||
                    this.IsComingSoon.Equals(input.IsComingSoon)
                ) && 
                (
                    this.IsInTraining == input.IsInTraining ||
                    this.IsInTraining.Equals(input.IsInTraining)
                ) && 
                (
                    this.Hours == input.Hours ||
                    (this.Hours != null &&
                    this.Hours.Equals(input.Hours))
                ) && 
                (
                    this.ScheduledDate == input.ScheduledDate ||
                    (this.ScheduledDate != null &&
                    this.ScheduledDate.Equals(input.ScheduledDate))
                ) && 
                (
                    this.ShowOnPublicWebsite == input.ShowOnPublicWebsite ||
                    this.ShowOnPublicWebsite.Equals(input.ShowOnPublicWebsite)
                ) && 
                (
                    this.SocialMediaId == input.SocialMediaId ||
                    (this.SocialMediaId != null &&
                    this.SocialMediaId.Equals(input.SocialMediaId))
                ) && 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AcceptingChildrenDate != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptingChildrenDate.GetHashCode();
                }
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                }
                if (this.ActualBuildingPermitDate != null)
                {
                    hashCode = (hashCode * 59) + this.ActualBuildingPermitDate.GetHashCode();
                }
                if (this.AddressConfirmedDate != null)
                {
                    hashCode = (hashCode * 59) + this.AddressConfirmedDate.GetHashCode();
                }
                if (this.Address1 != null)
                {
                    hashCode = (hashCode * 59) + this.Address1.GetHashCode();
                }
                if (this.AdvertisingName != null)
                {
                    hashCode = (hashCode * 59) + this.AdvertisingName.GetHashCode();
                }
                if (this.CrmId != null)
                {
                    hashCode = (hashCode * 59) + this.CrmId.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                if (this.Features != null)
                {
                    hashCode = (hashCode * 59) + this.Features.GetHashCode();
                }
                if (this.FmsId != null)
                {
                    hashCode = (hashCode * 59) + this.FmsId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasGeolocation.GetHashCode();
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                hashCode = (hashCode * 59) + this.IsClosed.GetHashCode();
                hashCode = (hashCode * 59) + this.IsComingSoon.GetHashCode();
                hashCode = (hashCode * 59) + this.IsInTraining.GetHashCode();
                if (this.Hours != null)
                {
                    hashCode = (hashCode * 59) + this.Hours.GetHashCode();
                }
                if (this.ScheduledDate != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowOnPublicWebsite.GetHashCode();
                if (this.SocialMediaId != null)
                {
                    hashCode = (hashCode * 59) + this.SocialMediaId.GetHashCode();
                }
                if (this.Telephone != null)
                {
                    hashCode = (hashCode * 59) + this.Telephone.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZone.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}