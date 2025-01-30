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
    /// SuggestionsResponse
    /// </summary>
    [DataContract(Name = "SuggestionsResponse")]
    public partial class SuggestionsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionsResponse" /> class.
        /// </summary>
        /// <param name="suggestions">The list of suggested locations sorted by **country**, **postalCode** and **locality**. Input localities matching a city name will be returned before those matching a subdistrict name..</param>
        public SuggestionsResponse(List<SuggestedLocation> suggestions = default(List<SuggestedLocation>))
        {
            this.Suggestions = suggestions;
        }

        /// <summary>
        /// The list of suggested locations sorted by **country**, **postalCode** and **locality**. Input localities matching a city name will be returned before those matching a subdistrict name.
        /// </summary>
        /// <value>The list of suggested locations sorted by **country**, **postalCode** and **locality**. Input localities matching a city name will be returned before those matching a subdistrict name.</value>
        [DataMember(Name = "suggestions", EmitDefaultValue = false)]
        public List<SuggestedLocation> Suggestions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SuggestionsResponse {\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
