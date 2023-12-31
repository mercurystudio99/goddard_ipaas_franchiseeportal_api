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
    /// ScheduleItemDto
    /// </summary>
    [DataContract(Name = "ScheduleItemDto")]
    public partial class ScheduleItemDto : IEquatable<ScheduleItemDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleItemDto" /> class.
        /// </summary>
        /// <param name="startDateTime">Start date and time of tour.</param>
        /// <param name="endDateTime">Ending date and time of tour.</param>
        /// <param name="tourTypes">An aggregation over Goddard.ToursWebApi.Dtos.ScheduleItemTourTypeDto.SlotsAvailable   and Goddard.ToursWebApi.Dtos.ScheduleItemTourTypeDto.AttendeeCount, per TourType.</param>
        public ScheduleItemDto(DateTime startDateTime = default(DateTime), DateTime endDateTime = default(DateTime), List<ScheduleItemTourTypeDto> tourTypes = default(List<ScheduleItemTourTypeDto>))
        {
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.TourTypes = tourTypes;
        }

        /// <summary>
        /// Start date and time of tour
        /// </summary>
        /// <value>Start date and time of tour</value>
        [DataMember(Name = "startDateTime", EmitDefaultValue = false)]
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Ending date and time of tour
        /// </summary>
        /// <value>Ending date and time of tour</value>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// An aggregation over Goddard.ToursWebApi.Dtos.ScheduleItemTourTypeDto.SlotsAvailable   and Goddard.ToursWebApi.Dtos.ScheduleItemTourTypeDto.AttendeeCount, per TourType
        /// </summary>
        /// <value>An aggregation over Goddard.ToursWebApi.Dtos.ScheduleItemTourTypeDto.SlotsAvailable   and Goddard.ToursWebApi.Dtos.ScheduleItemTourTypeDto.AttendeeCount, per TourType</value>
        [DataMember(Name = "tourTypes", EmitDefaultValue = true)]
        public List<ScheduleItemTourTypeDto> TourTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleItemDto {\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
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
            return this.Equals(input as ScheduleItemDto);
        }

        /// <summary>
        /// Returns true if ScheduleItemDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleItemDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleItemDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.TourTypes == input.TourTypes ||
                    this.TourTypes != null &&
                    input.TourTypes != null &&
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
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.EndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDateTime.GetHashCode();
                }
                if (this.TourTypes != null)
                {
                    hashCode = (hashCode * 59) + this.TourTypes.GetHashCode();
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
