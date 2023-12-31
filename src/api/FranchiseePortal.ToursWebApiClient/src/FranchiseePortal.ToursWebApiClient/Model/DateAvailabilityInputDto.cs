/*
 * Goddard.ToursWebApi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
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
using OpenAPIDateConverter = FranchiseePortal.ToursWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.ToursWebApiClient.Model
{
    /// <summary>
    /// Date availability input DTO
    /// </summary>
    [DataContract(Name = "DateAvailabilityInputDto")]
    public partial class DateAvailabilityInputDto : IEquatable<DateAvailabilityInputDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateAvailabilityInputDto" /> class.
        /// </summary>
        /// <param name="blocks">blocks.</param>
        /// <param name="isAllDayBlocked">isAllDayBlocked.</param>
        public DateAvailabilityInputDto(List<DateAvailabilityBlockDto> blocks = default(List<DateAvailabilityBlockDto>), bool isAllDayBlocked = default(bool))
        {
            this.Blocks = blocks;
            this.IsAllDayBlocked = isAllDayBlocked;
        }

        /// <summary>
        /// Gets or Sets Blocks
        /// </summary>
        [DataMember(Name = "blocks", EmitDefaultValue = true)]
        public List<DateAvailabilityBlockDto> Blocks { get; set; }

        /// <summary>
        /// Gets or Sets IsAllDayBlocked
        /// </summary>
        [DataMember(Name = "isAllDayBlocked", EmitDefaultValue = true)]
        public bool IsAllDayBlocked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DateAvailabilityInputDto {\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  IsAllDayBlocked: ").Append(IsAllDayBlocked).Append("\n");
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
            return this.Equals(input as DateAvailabilityInputDto);
        }

        /// <summary>
        /// Returns true if DateAvailabilityInputDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DateAvailabilityInputDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateAvailabilityInputDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Blocks == input.Blocks ||
                    this.Blocks != null &&
                    input.Blocks != null &&
                    this.Blocks.SequenceEqual(input.Blocks)
                ) && 
                (
                    this.IsAllDayBlocked == input.IsAllDayBlocked ||
                    this.IsAllDayBlocked.Equals(input.IsAllDayBlocked)
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
                if (this.Blocks != null)
                {
                    hashCode = (hashCode * 59) + this.Blocks.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsAllDayBlocked.GetHashCode();
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
