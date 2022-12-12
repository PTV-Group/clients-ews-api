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
    /// The complete location used for start or destination of the relation.
    /// </summary>
    [DataContract(Name = "ResponseLocation")]
    public partial class ResponseLocation : IEquatable<ResponseLocation>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public LocationType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseLocation" /> class.
        /// </summary>
        /// <param name="country">The country represented by its code according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). (required).</param>
        /// <param name="postalCode">The postal code, or zip-code, which is used by a postal authority of a country..</param>
        /// <param name="locality">The name of the city or district in the language spoken in that country or region, always transliterated to Latin. (required).</param>
        /// <param name="latitude">The latitude in degrees (WGS84/EPSG:4326) from south to north, if requested..</param>
        /// <param name="longitude">The longitude in degrees (WGS84/EPSG:4326) from west to east, if requested..</param>
        /// <param name="type">type (required).</param>
        public ResponseLocation(string country = default(string), string postalCode = default(string), string locality = default(string), double latitude = default(double), double longitude = default(double), LocationType type = default(LocationType))
        {
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for ResponseLocation and cannot be null");
            }
            this.Country = country;
            // to ensure "locality" is required (not null)
            if (locality == null)
            {
                throw new ArgumentNullException("locality is a required property for ResponseLocation and cannot be null");
            }
            this.Locality = locality;
            this.Type = type;
            this.PostalCode = postalCode;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// The country represented by its code according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).
        /// </summary>
        /// <value>The country represented by its code according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).</value>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// The postal code, or zip-code, which is used by a postal authority of a country.
        /// </summary>
        /// <value>The postal code, or zip-code, which is used by a postal authority of a country.</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The name of the city or district in the language spoken in that country or region, always transliterated to Latin.
        /// </summary>
        /// <value>The name of the city or district in the language spoken in that country or region, always transliterated to Latin.</value>
        [DataMember(Name = "locality", IsRequired = true, EmitDefaultValue = true)]
        public string Locality { get; set; }

        /// <summary>
        /// The latitude in degrees (WGS84/EPSG:4326) from south to north, if requested.
        /// </summary>
        /// <value>The latitude in degrees (WGS84/EPSG:4326) from south to north, if requested.</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude in degrees (WGS84/EPSG:4326) from west to east, if requested.
        /// </summary>
        /// <value>The longitude in degrees (WGS84/EPSG:4326) from west to east, if requested.</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseLocation {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ResponseLocation);
        }

        /// <summary>
        /// Returns true if ResponseLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseLocation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.Locality != null)
                {
                    hashCode = (hashCode * 59) + this.Locality.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
            // Latitude (double) maximum
            if (this.Latitude > (double)90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Latitude, must be a value less than or equal to 90.", new [] { "Latitude" });
            }

            // Latitude (double) minimum
            if (this.Latitude < (double)-90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Latitude, must be a value greater than or equal to -90.", new [] { "Latitude" });
            }

            // Longitude (double) maximum
            if (this.Longitude > (double)180)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Longitude, must be a value less than or equal to 180.", new [] { "Longitude" });
            }

            // Longitude (double) minimum
            if (this.Longitude < (double)-180)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Longitude, must be a value greater than or equal to -180.", new [] { "Longitude" });
            }

            yield break;
        }
    }

}
