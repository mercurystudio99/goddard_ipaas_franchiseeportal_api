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
    /// Date specific availability block DTO
    /// </summary>
    [DataContract(Name = "DateAvailabilityBlockDto")]
    public partial class DateAvailabilityBlockDto : IEquatable<DateAvailabilityBlockDto>, IValidatableObject
    {
        /// <summary>
        /// Defines TourTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TourTypesEnum
        {
            /// <summary>
            /// Enum InPerson for value: InPerson
            /// </summary>
            [EnumMember(Value = "InPerson")]
            InPerson = 1,

            /// <summary>
            /// Enum Online for value: Online
            /// </summary>
            [EnumMember(Value = "Online")]
            Online = 2

        }



        /// <summary>
        /// Tour types
        /// </summary>
        /// <value>Tour types</value>
        [DataMember(Name = "tourTypes", EmitDefaultValue = false)]
        public List<TourTypesEnum> TourTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DateAvailabilityBlockDto" /> class.
        /// </summary>
        /// <param name="startTime">Gets or sets start time of availability block.</param>
        /// <param name="endTime">Gets or sets end time of availability block.</param>
        /// <param name="tourTypes">Tour types.</param>
        public DateAvailabilityBlockDto(DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), List<TourTypesEnum> tourTypes = default(List<TourTypesEnum>))
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TourTypes = tourTypes;
        }

        /// <summary>
        /// Gets or sets start time of availability block
        /// </summary>
        /// <value>Gets or sets start time of availability block</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time of availability block
        /// </summary>
        /// <value>Gets or sets end time of availability block</value>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DateAvailabilityBlockDto {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  TourTypes: ").Append(TourTypes).Append("\n");
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
            return this.Equals(input as DateAvailabilityBlockDto);
        }

        /// <summary>
        /// Returns true if DateAvailabilityBlockDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DateAvailabilityBlockDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateAvailabilityBlockDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.TourTypes == input.TourTypes ||
                    this.TourTypes.SequenceEqual(input.TourTypes)
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
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TourTypes.GetHashCode();
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
