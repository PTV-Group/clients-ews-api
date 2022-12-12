/*
 * EWS Road Distance
 *
 * With the EWS Road Distance service you can query pre-calculated distances and additional information for relations between reference locations in Europe.
 *
 * The version of the OpenAPI document: 1.2
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
    /// Defines ResultsType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultsType
    {
        /// <summary>
        /// Enum COORDINATES for value: COORDINATES
        /// </summary>
        [EnumMember(Value = "COORDINATES")]
        COORDINATES = 1,

        /// <summary>
        /// Enum TOLL_DISTANCE for value: TOLL_DISTANCE
        /// </summary>
        [EnumMember(Value = "TOLL_DISTANCE")]
        TOLL_DISTANCE = 2

    }

}
