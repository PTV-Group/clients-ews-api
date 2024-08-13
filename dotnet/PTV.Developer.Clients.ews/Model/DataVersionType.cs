/*
 * EWS Road Distance
 *
 * With the EWS Road Distance service you can query pre-calculated distances and additional information for relations between reference locations in Europe.
 *
 * The version of the OpenAPI document: 1.4
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
    /// The version of the data by year. 
    /// </summary>
    /// <value>The version of the data by year. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataVersionType
    {
        /// <summary>
        /// Enum V2016 for value: V2016
        /// </summary>
        [EnumMember(Value = "V2016")]
        V2016 = 1,

        /// <summary>
        /// Enum V2017 for value: V2017
        /// </summary>
        [EnumMember(Value = "V2017")]
        V2017 = 2,

        /// <summary>
        /// Enum V2018 for value: V2018
        /// </summary>
        [EnumMember(Value = "V2018")]
        V2018 = 3,

        /// <summary>
        /// Enum V2019 for value: V2019
        /// </summary>
        [EnumMember(Value = "V2019")]
        V2019 = 4,

        /// <summary>
        /// Enum V2020 for value: V2020
        /// </summary>
        [EnumMember(Value = "V2020")]
        V2020 = 5,

        /// <summary>
        /// Enum V2021 for value: V2021
        /// </summary>
        [EnumMember(Value = "V2021")]
        V2021 = 6,

        /// <summary>
        /// Enum V2022 for value: V2022
        /// </summary>
        [EnumMember(Value = "V2022")]
        V2022 = 7,

        /// <summary>
        /// Enum V2023 for value: V2023
        /// </summary>
        [EnumMember(Value = "V2023")]
        V2023 = 8,

        /// <summary>
        /// Enum V2024 for value: V2024
        /// </summary>
        [EnumMember(Value = "V2024")]
        V2024 = 9,

        /// <summary>
        /// Enum LATEST for value: LATEST
        /// </summary>
        [EnumMember(Value = "LATEST")]
        LATEST = 10
    }

}
