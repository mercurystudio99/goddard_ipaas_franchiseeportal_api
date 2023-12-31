/*
 * Goddard iPaaS Leads API
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
using OpenAPIDateConverter = FranchiseePortal.LeadsWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.LeadsWebApiClient.Model
{
    /// <summary>
    /// ApiV1SchoolLeadsGetRequest
    /// </summary>
    [DataContract(Name = "_api_v1_school_leads_get_request")]
    public partial class ApiV1SchoolLeadsGetRequest : IEquatable<ApiV1SchoolLeadsGetRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReferredBy
        /// </summary>
        [DataMember(Name = "referredBy", IsRequired = true, EmitDefaultValue = true)]
        public ReferredBy ReferredBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1SchoolLeadsGetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV1SchoolLeadsGetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1SchoolLeadsGetRequest" /> class.
        /// </summary>
        /// <param name="homePhone">homePhone.</param>
        /// <param name="workPhone">workPhone.</param>
        /// <param name="schoolParentLeadId">Id of the School Parent Lead.</param>
        /// <param name="schoolId">schoolId (required).</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="streetLine1">streetLine1.</param>
        /// <param name="city">city.</param>
        /// <param name="zipCode">zipCode (required).</param>
        /// <param name="mobilePhone">mobilePhone (required).</param>
        /// <param name="emailAddress">emailAddress (required).</param>
        /// <param name="referredBy">referredBy (required).</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="contactPreference">contactPreference (required).</param>
        /// <param name="schoolChildLeads">schoolChildLeads (required).</param>
        /// <param name="additionalRemarks">additionalRemarks.</param>
        /// <param name="programsOfInterest">programsOfInterest.</param>
        /// <param name="daysOfInterest">daysOfInterest.</param>
        /// <param name="reCaptchaResponse">reCaptchaResponse (required).</param>
        public ApiV1SchoolLeadsGetRequest(string homePhone = default(string), string workPhone = default(string), long? schoolParentLeadId = default(long?), long schoolId = default(long), string firstName = default(string), string lastName = default(string), string streetLine1 = default(string), string city = default(string), string zipCode = default(string), string mobilePhone = default(string), string emailAddress = default(string), ReferredBy referredBy = default(ReferredBy), DateTime startDate = default(DateTime), int contactPreference = default(int), List<ChildLead> schoolChildLeads = default(List<ChildLead>), string additionalRemarks = default(string), List<string> programsOfInterest = default(List<string>), List<DaysOfInterest> daysOfInterest = default(List<DaysOfInterest>), string reCaptchaResponse = default(string))
        {
            this.SchoolId = schoolId;
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for ApiV1SchoolLeadsGetRequest and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for ApiV1SchoolLeadsGetRequest and cannot be null");
            }
            this.LastName = lastName;
            // to ensure "zipCode" is required (not null)
            if (zipCode == null)
            {
                throw new ArgumentNullException("zipCode is a required property for ApiV1SchoolLeadsGetRequest and cannot be null");
            }
            this.ZipCode = zipCode;
            // to ensure "mobilePhone" is required (not null)
            if (mobilePhone == null)
            {
                throw new ArgumentNullException("mobilePhone is a required property for ApiV1SchoolLeadsGetRequest and cannot be null");
            }
            this.MobilePhone = mobilePhone;
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new ArgumentNullException("emailAddress is a required property for ApiV1SchoolLeadsGetRequest and cannot be null");
            }
            this.EmailAddress = emailAddress;
            this.ReferredBy = referredBy;
            this.StartDate = startDate;
            this.ContactPreference = contactPreference;
            // to ensure "schoolChildLeads" is required (not null)
            if (schoolChildLeads == null)
            {
                throw new ArgumentNullException("schoolChildLeads is a required property for ApiV1SchoolLeadsGetRequest and cannot be null");
            }
            this.SchoolChildLeads = schoolChildLeads;
            // to ensure "reCaptchaResponse" is required (not null)
            if (reCaptchaResponse == null)
            {
                throw new ArgumentNullException("reCaptchaResponse is a required property for ApiV1SchoolLeadsGetRequest and cannot be null");
            }
            this.ReCaptchaResponse = reCaptchaResponse;
            this.HomePhone = homePhone;
            this.WorkPhone = workPhone;
            this.SchoolParentLeadId = schoolParentLeadId;
            this.StreetLine1 = streetLine1;
            this.City = city;
            this.AdditionalRemarks = additionalRemarks;
            this.ProgramsOfInterest = programsOfInterest;
            this.DaysOfInterest = daysOfInterest;
        }

        /// <summary>
        /// Gets or Sets HomePhone
        /// </summary>
        [DataMember(Name = "homePhone", EmitDefaultValue = true)]
        public string HomePhone { get; set; }

        /// <summary>
        /// Gets or Sets WorkPhone
        /// </summary>
        [DataMember(Name = "workPhone", EmitDefaultValue = true)]
        public string WorkPhone { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryPhone
        /// </summary>
        [DataMember(Name = "primaryPhone", EmitDefaultValue = true)]
        public string PrimaryPhone { get; private set; }

        /// <summary>
        /// Returns false as PrimaryPhone should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePrimaryPhone()
        {
            return false;
        }
        /// <summary>
        /// Id of the School Parent Lead
        /// </summary>
        /// <value>Id of the School Parent Lead</value>
        [DataMember(Name = "schoolParentLeadId", EmitDefaultValue = true)]
        [Obsolete]
        public long? SchoolParentLeadId { get; set; }

        /// <summary>
        /// Gets or Sets SchoolId
        /// </summary>
        [DataMember(Name = "schoolId", IsRequired = true, EmitDefaultValue = false)]
        public long SchoolId { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets StreetLine1
        /// </summary>
        [DataMember(Name = "streetLine1", EmitDefaultValue = true)]
        public string StreetLine1 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [DataMember(Name = "zipCode", IsRequired = true, EmitDefaultValue = false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets MobilePhone
        /// </summary>
        [DataMember(Name = "mobilePhone", IsRequired = true, EmitDefaultValue = false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets ContactPreference
        /// </summary>
        [DataMember(Name = "contactPreference", IsRequired = true, EmitDefaultValue = false)]
        public int ContactPreference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolChildLeads
        /// </summary>
        [DataMember(Name = "schoolChildLeads", IsRequired = true, EmitDefaultValue = false)]
        public List<ChildLead> SchoolChildLeads { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalRemarks
        /// </summary>
        [DataMember(Name = "additionalRemarks", EmitDefaultValue = true)]
        public string AdditionalRemarks { get; set; }

        /// <summary>
        /// Gets or Sets ProgramsOfInterest
        /// </summary>
        [DataMember(Name = "programsOfInterest", EmitDefaultValue = true)]
        public List<string> ProgramsOfInterest { get; set; }

        /// <summary>
        /// Gets or Sets DaysOfInterest
        /// </summary>
        [DataMember(Name = "daysOfInterest", EmitDefaultValue = true)]
        public List<DaysOfInterest> DaysOfInterest { get; set; }

        /// <summary>
        /// Gets or Sets ReCaptchaResponse
        /// </summary>
        [DataMember(Name = "reCaptchaResponse", IsRequired = true, EmitDefaultValue = false)]
        public string ReCaptchaResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV1SchoolLeadsGetRequest {\n");
            sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
            sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
            sb.Append("  PrimaryPhone: ").Append(PrimaryPhone).Append("\n");
            sb.Append("  SchoolParentLeadId: ").Append(SchoolParentLeadId).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  StreetLine1: ").Append(StreetLine1).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  ReferredBy: ").Append(ReferredBy).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ContactPreference: ").Append(ContactPreference).Append("\n");
            sb.Append("  SchoolChildLeads: ").Append(SchoolChildLeads).Append("\n");
            sb.Append("  AdditionalRemarks: ").Append(AdditionalRemarks).Append("\n");
            sb.Append("  ProgramsOfInterest: ").Append(ProgramsOfInterest).Append("\n");
            sb.Append("  DaysOfInterest: ").Append(DaysOfInterest).Append("\n");
            sb.Append("  ReCaptchaResponse: ").Append(ReCaptchaResponse).Append("\n");
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
            return this.Equals(input as ApiV1SchoolLeadsGetRequest);
        }

        /// <summary>
        /// Returns true if ApiV1SchoolLeadsGetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV1SchoolLeadsGetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV1SchoolLeadsGetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HomePhone == input.HomePhone ||
                    (this.HomePhone != null &&
                    this.HomePhone.Equals(input.HomePhone))
                ) && 
                (
                    this.WorkPhone == input.WorkPhone ||
                    (this.WorkPhone != null &&
                    this.WorkPhone.Equals(input.WorkPhone))
                ) && 
                (
                    this.PrimaryPhone == input.PrimaryPhone ||
                    (this.PrimaryPhone != null &&
                    this.PrimaryPhone.Equals(input.PrimaryPhone))
                ) && 
                (
                    this.SchoolParentLeadId == input.SchoolParentLeadId ||
                    (this.SchoolParentLeadId != null &&
                    this.SchoolParentLeadId.Equals(input.SchoolParentLeadId))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    this.SchoolId.Equals(input.SchoolId)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.StreetLine1 == input.StreetLine1 ||
                    (this.StreetLine1 != null &&
                    this.StreetLine1.Equals(input.StreetLine1))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.MobilePhone == input.MobilePhone ||
                    (this.MobilePhone != null &&
                    this.MobilePhone.Equals(input.MobilePhone))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.ReferredBy == input.ReferredBy ||
                    this.ReferredBy.Equals(input.ReferredBy)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ContactPreference == input.ContactPreference ||
                    this.ContactPreference.Equals(input.ContactPreference)
                ) && 
                (
                    this.SchoolChildLeads == input.SchoolChildLeads ||
                    this.SchoolChildLeads != null &&
                    input.SchoolChildLeads != null &&
                    this.SchoolChildLeads.SequenceEqual(input.SchoolChildLeads)
                ) && 
                (
                    this.AdditionalRemarks == input.AdditionalRemarks ||
                    (this.AdditionalRemarks != null &&
                    this.AdditionalRemarks.Equals(input.AdditionalRemarks))
                ) && 
                (
                    this.ProgramsOfInterest == input.ProgramsOfInterest ||
                    this.ProgramsOfInterest != null &&
                    input.ProgramsOfInterest != null &&
                    this.ProgramsOfInterest.SequenceEqual(input.ProgramsOfInterest)
                ) && 
                (
                    this.DaysOfInterest == input.DaysOfInterest ||
                    this.DaysOfInterest != null &&
                    input.DaysOfInterest != null &&
                    this.DaysOfInterest.SequenceEqual(input.DaysOfInterest)
                ) && 
                (
                    this.ReCaptchaResponse == input.ReCaptchaResponse ||
                    (this.ReCaptchaResponse != null &&
                    this.ReCaptchaResponse.Equals(input.ReCaptchaResponse))
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
                if (this.HomePhone != null)
                {
                    hashCode = (hashCode * 59) + this.HomePhone.GetHashCode();
                }
                if (this.WorkPhone != null)
                {
                    hashCode = (hashCode * 59) + this.WorkPhone.GetHashCode();
                }
                if (this.PrimaryPhone != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryPhone.GetHashCode();
                }
                if (this.SchoolParentLeadId != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolParentLeadId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchoolId.GetHashCode();
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.StreetLine1 != null)
                {
                    hashCode = (hashCode * 59) + this.StreetLine1.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.ZipCode != null)
                {
                    hashCode = (hashCode * 59) + this.ZipCode.GetHashCode();
                }
                if (this.MobilePhone != null)
                {
                    hashCode = (hashCode * 59) + this.MobilePhone.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReferredBy.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ContactPreference.GetHashCode();
                if (this.SchoolChildLeads != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolChildLeads.GetHashCode();
                }
                if (this.AdditionalRemarks != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalRemarks.GetHashCode();
                }
                if (this.ProgramsOfInterest != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramsOfInterest.GetHashCode();
                }
                if (this.DaysOfInterest != null)
                {
                    hashCode = (hashCode * 59) + this.DaysOfInterest.GetHashCode();
                }
                if (this.ReCaptchaResponse != null)
                {
                    hashCode = (hashCode * 59) + this.ReCaptchaResponse.GetHashCode();
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
            // SchoolId (long) minimum
            if (this.SchoolId < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SchoolId, must be a value greater than or equal to 1.", new [] { "SchoolId" });
            }

            // FirstName (string) maxLength
            if (this.FirstName != null && this.FirstName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 50.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if (this.FirstName != null && this.FirstName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 0.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if (this.LastName != null && this.LastName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 50.", new [] { "LastName" });
            }

            // LastName (string) minLength
            if (this.LastName != null && this.LastName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be greater than 0.", new [] { "LastName" });
            }

            // StreetLine1 (string) maxLength
            if (this.StreetLine1 != null && this.StreetLine1.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetLine1, length must be less than 50.", new [] { "StreetLine1" });
            }

            // StreetLine1 (string) minLength
            if (this.StreetLine1 != null && this.StreetLine1.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetLine1, length must be greater than 0.", new [] { "StreetLine1" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 50.", new [] { "City" });
            }

            // City (string) minLength
            if (this.City != null && this.City.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be greater than 0.", new [] { "City" });
            }

            // ZipCode (string) maxLength
            if (this.ZipCode != null && this.ZipCode.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ZipCode, length must be less than 50.", new [] { "ZipCode" });
            }

            // ZipCode (string) minLength
            if (this.ZipCode != null && this.ZipCode.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ZipCode, length must be greater than 0.", new [] { "ZipCode" });
            }

            // MobilePhone (string) maxLength
            if (this.MobilePhone != null && this.MobilePhone.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MobilePhone, length must be less than 50.", new [] { "MobilePhone" });
            }

            // MobilePhone (string) minLength
            if (this.MobilePhone != null && this.MobilePhone.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MobilePhone, length must be greater than 0.", new [] { "MobilePhone" });
            }

            // EmailAddress (string) maxLength
            if (this.EmailAddress != null && this.EmailAddress.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be less than 50.", new [] { "EmailAddress" });
            }

            // EmailAddress (string) minLength
            if (this.EmailAddress != null && this.EmailAddress.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be greater than 0.", new [] { "EmailAddress" });
            }

            // ContactPreference (int) maximum
            if (this.ContactPreference > (int)7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactPreference, must be a value less than or equal to 7.", new [] { "ContactPreference" });
            }

            // ContactPreference (int) minimum
            if (this.ContactPreference < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactPreference, must be a value greater than or equal to 1.", new [] { "ContactPreference" });
            }

            yield break;
        }
    }

}
