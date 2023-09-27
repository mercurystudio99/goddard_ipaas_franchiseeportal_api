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
    /// Defines TourTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TourTypes
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
        Online = 2,

        /// <summary>
        /// Enum Virtual for value: Virtual
        /// </summary>
        [EnumMember(Value = "Virtual")]
        Virtual = 3

    }

}
