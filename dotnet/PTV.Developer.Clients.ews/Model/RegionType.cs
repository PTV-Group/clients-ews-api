/*
 * EWS Road Distance
 *
 * With the EWS Road Distance service you can query pre-calculated distances and additional information for relations between reference locations in Europe.
 *
 * The version of the OpenAPI document: 1.5
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
using OpenAPIDateConverter = PTV.Developer.Clients.ews.Client.OpenAPIDateConverter;

namespace PTV.Developer.Clients.ews.Model
{
    /// <summary>
    /// The region to search for the reference locations. See the concept on [EWS](./concepts/ews) for more information. 
    /// </summary>
    /// <value>The region to search for the reference locations. See the concept on [EWS](./concepts/ews) for more information. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RegionType
    {
        /// <summary>
        /// Enum BEST_QUALITY for value: BEST_QUALITY
        /// </summary>
        [EnumMember(Value = "BEST_QUALITY")]
        BEST_QUALITY = 1,

        /// <summary>
        /// Enum EUROPE for value: EUROPE
        /// </summary>
        [EnumMember(Value = "EUROPE")]
        EUROPE = 2,

        /// <summary>
        /// Enum GERMANY for value: GERMANY
        /// </summary>
        [EnumMember(Value = "GERMANY")]
        GERMANY = 3
    }

}
