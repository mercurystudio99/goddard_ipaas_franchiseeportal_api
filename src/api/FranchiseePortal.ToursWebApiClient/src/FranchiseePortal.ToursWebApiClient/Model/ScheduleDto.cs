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
    /// ScheduleDto
    /// </summary>
    [DataContract(Name = "ScheduleDto")]
    public partial class ScheduleDto : IEquatable<ScheduleDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDto" /> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="date">date.</param>
        /// <param name="isAllDayBlocked">isAllDayBlocked.</param>
        public ScheduleDto(List<ScheduleItemDto> items = default(List<ScheduleItemDto>), DateTime date = default(DateTime), bool isAllDayBlocked = default(bool))
        {
            this.Items = items;
            this.Date = date;
            this.IsAllDayBlocked = isAllDayBlocked;
        }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<ScheduleItemDto> Items { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

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
            sb.Append("class ScheduleDto {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as ScheduleDto);
        }

        /// <summary>
        /// Returns true if ScheduleDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
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
