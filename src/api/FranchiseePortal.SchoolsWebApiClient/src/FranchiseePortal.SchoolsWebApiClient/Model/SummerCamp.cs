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
    /// SummerCamp
    /// </summary>
    [DataContract(Name = "SummerCamp")]
    public partial class SummerCamp : IEquatable<SummerCamp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummerCamp" /> class.
        /// </summary>
        /// <param name="ageRange">ageRange.</param>
        /// <param name="dateRange">dateRange.</param>
        /// <param name="description">description.</param>
        /// <param name="image">image.</param>
        /// <param name="pricing">pricing.</param>
        /// <param name="title">title.</param>
        public SummerCamp(string ageRange = default(string), string dateRange = default(string), string description = default(string), string image = default(string), string pricing = default(string), string title = default(string))
        {
            this.AgeRange = ageRange;
            this.DateRange = dateRange;
            this.Description = description;
            this.Image = image;
            this.Pricing = pricing;
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets AgeRange
        /// </summary>
        [DataMember(Name = "ageRange", EmitDefaultValue = true)]
        public string AgeRange { get; set; }

        /// <summary>
        /// Gets or Sets DateRange
        /// </summary>
        [DataMember(Name = "dateRange", EmitDefaultValue = true)]
        public string DateRange { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Pricing
        /// </summary>
        [DataMember(Name = "pricing", EmitDefaultValue = true)]
        public string Pricing { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SummerCamp {\n");
            sb.Append("  AgeRange: ").Append(AgeRange).Append("\n");
            sb.Append("  DateRange: ").Append(DateRange).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Pricing: ").Append(Pricing).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as SummerCamp);
        }

        /// <summary>
        /// Returns true if SummerCamp instances are equal
        /// </summary>
        /// <param name="input">Instance of SummerCamp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummerCamp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgeRange == input.AgeRange ||
                    (this.AgeRange != null &&
                    this.AgeRange.Equals(input.AgeRange))
                ) && 
                (
                    this.DateRange == input.DateRange ||
                    (this.DateRange != null &&
                    this.DateRange.Equals(input.DateRange))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Pricing == input.Pricing ||
                    (this.Pricing != null &&
                    this.Pricing.Equals(input.Pricing))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.AgeRange != null)
                {
                    hashCode = (hashCode * 59) + this.AgeRange.GetHashCode();
                }
                if (this.DateRange != null)
                {
                    hashCode = (hashCode * 59) + this.DateRange.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Pricing != null)
                {
                    hashCode = (hashCode * 59) + this.Pricing.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
