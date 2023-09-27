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
    /// ApiV1ValidationPhonePostRequest
    /// </summary>
    [DataContract(Name = "_api_v1_validation_phone_post_request")]
    public partial class ApiV1ValidationPhonePostRequest : IEquatable<ApiV1ValidationPhonePostRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1ValidationPhonePostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV1ValidationPhonePostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1ValidationPhonePostRequest" /> class.
        /// </summary>
        /// <param name="number">number (required).</param>
        public ApiV1ValidationPhonePostRequest(string number = default(string))
        {
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new ArgumentNullException("number is a required property for ApiV1ValidationPhonePostRequest and cannot be null");
            }
            this.Number = number;
        }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiV1ValidationPhonePostRequest {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as ApiV1ValidationPhonePostRequest);
        }

        /// <summary>
        /// Returns true if ApiV1ValidationPhonePostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV1ValidationPhonePostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV1ValidationPhonePostRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
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