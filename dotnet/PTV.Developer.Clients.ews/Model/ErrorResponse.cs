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
    /// ErrorResponse
    /// </summary>
    [DataContract(Name = "ErrorResponse")]
    public partial class ErrorResponse : IEquatable<ErrorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="description">A human readable message that describes the error. (required).</param>
        /// <param name="errorCode">A constant string that can be used to identify this error class programmatically. An errorCode can have **details** to provide information in additional properties which are described with the code they apply to. They are of type string unless otherwise specified. Note that additional errorCodes as well as the **details** of existing errorCodes may be added at any time. Furthermore, the **description** may change at any time.    **HTTP status code: 400**   * &#x60;GENERAL_VALIDATION_ERROR&#x60; - The validation of the request failed. Details can be found in **causes**. * &#x60;GENERAL_PARSING_ERROR&#x60; - The JSON syntax is invalid. * &#x60;EWS_ERROR&#x60; - The relation could not be found.  **HTTP status code: 401**   * &#x60;GENERAL_UNAUTHENTICATED&#x60; - Invalid or missing authentication credentials.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 403**   * &#x60;GENERAL_FORBIDDEN&#x60; - Insufficient access rights. * &#x60;GENERAL_QUOTA_EXCEEDED&#x60; - The transaction limit is exceeded.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 404**   * &#x60;GENERAL_RESOURCE_NOT_FOUND&#x60; - A requested resource does not exist.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 429**   * &#x60;GENERAL_RATE_LIMIT_EXCEEDED&#x60; - The rate limit is exceeded.  **HTTP status code: 500**   * &#x60;GENERAL_INTERNAL_SERVER_ERROR&#x60; - The request could not be processed due to an internal error.   * &#x60;message&#x60; - An additional error message.   * &#x60;hint&#x60; - A hint how to solve the problem.  **HTTP status code: 503**   * &#x60;GENERAL_SERVICE_UNAVAILABLE&#x60; - The service is temporarily unavailable.  **HTTP status code: 4xx-5xx**   * &#x60;GENERAL_INTERNAL_GATEWAY_ERROR&#x60; - The request could not be processed due to an internal gateway error.   * &#x60;hint&#x60; - A hint how to solve the problem. (required).</param>
        /// <param name="traceId">A unique identifier of the corresponding trace forest. It can be used to trace errors by the support. (required).</param>
        /// <param name="errorId">A unique identifier specific to this error instance. It can be used to trace errors by the support..</param>
        /// <param name="causes">A list of affected parameters and/or properties that caused this error..</param>
        /// <param name="details">Additional properties specific to this error class..</param>
        public ErrorResponse(string description = default(string), string errorCode = default(string), string traceId = default(string), string errorId = default(string), List<CausingError> causes = default(List<CausingError>), Dictionary<string, Object> details = default(Dictionary<string, Object>))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ErrorResponse and cannot be null");
            }
            this.Description = description;
            // to ensure "errorCode" is required (not null)
            if (errorCode == null)
            {
                throw new ArgumentNullException("errorCode is a required property for ErrorResponse and cannot be null");
            }
            this.ErrorCode = errorCode;
            // to ensure "traceId" is required (not null)
            if (traceId == null)
            {
                throw new ArgumentNullException("traceId is a required property for ErrorResponse and cannot be null");
            }
            this.TraceId = traceId;
            this.ErrorId = errorId;
            this.Causes = causes;
            this.Details = details;
        }

        /// <summary>
        /// A human readable message that describes the error.
        /// </summary>
        /// <value>A human readable message that describes the error.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// A constant string that can be used to identify this error class programmatically. An errorCode can have **details** to provide information in additional properties which are described with the code they apply to. They are of type string unless otherwise specified. Note that additional errorCodes as well as the **details** of existing errorCodes may be added at any time. Furthermore, the **description** may change at any time.    **HTTP status code: 400**   * &#x60;GENERAL_VALIDATION_ERROR&#x60; - The validation of the request failed. Details can be found in **causes**. * &#x60;GENERAL_PARSING_ERROR&#x60; - The JSON syntax is invalid. * &#x60;EWS_ERROR&#x60; - The relation could not be found.  **HTTP status code: 401**   * &#x60;GENERAL_UNAUTHENTICATED&#x60; - Invalid or missing authentication credentials.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 403**   * &#x60;GENERAL_FORBIDDEN&#x60; - Insufficient access rights. * &#x60;GENERAL_QUOTA_EXCEEDED&#x60; - The transaction limit is exceeded.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 404**   * &#x60;GENERAL_RESOURCE_NOT_FOUND&#x60; - A requested resource does not exist.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 429**   * &#x60;GENERAL_RATE_LIMIT_EXCEEDED&#x60; - The rate limit is exceeded.  **HTTP status code: 500**   * &#x60;GENERAL_INTERNAL_SERVER_ERROR&#x60; - The request could not be processed due to an internal error.   * &#x60;message&#x60; - An additional error message.   * &#x60;hint&#x60; - A hint how to solve the problem.  **HTTP status code: 503**   * &#x60;GENERAL_SERVICE_UNAVAILABLE&#x60; - The service is temporarily unavailable.  **HTTP status code: 4xx-5xx**   * &#x60;GENERAL_INTERNAL_GATEWAY_ERROR&#x60; - The request could not be processed due to an internal gateway error.   * &#x60;hint&#x60; - A hint how to solve the problem.
        /// </summary>
        /// <value>A constant string that can be used to identify this error class programmatically. An errorCode can have **details** to provide information in additional properties which are described with the code they apply to. They are of type string unless otherwise specified. Note that additional errorCodes as well as the **details** of existing errorCodes may be added at any time. Furthermore, the **description** may change at any time.    **HTTP status code: 400**   * &#x60;GENERAL_VALIDATION_ERROR&#x60; - The validation of the request failed. Details can be found in **causes**. * &#x60;GENERAL_PARSING_ERROR&#x60; - The JSON syntax is invalid. * &#x60;EWS_ERROR&#x60; - The relation could not be found.  **HTTP status code: 401**   * &#x60;GENERAL_UNAUTHENTICATED&#x60; - Invalid or missing authentication credentials.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 403**   * &#x60;GENERAL_FORBIDDEN&#x60; - Insufficient access rights. * &#x60;GENERAL_QUOTA_EXCEEDED&#x60; - The transaction limit is exceeded.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 404**   * &#x60;GENERAL_RESOURCE_NOT_FOUND&#x60; - A requested resource does not exist.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 429**   * &#x60;GENERAL_RATE_LIMIT_EXCEEDED&#x60; - The rate limit is exceeded.  **HTTP status code: 500**   * &#x60;GENERAL_INTERNAL_SERVER_ERROR&#x60; - The request could not be processed due to an internal error.   * &#x60;message&#x60; - An additional error message.   * &#x60;hint&#x60; - A hint how to solve the problem.  **HTTP status code: 503**   * &#x60;GENERAL_SERVICE_UNAVAILABLE&#x60; - The service is temporarily unavailable.  **HTTP status code: 4xx-5xx**   * &#x60;GENERAL_INTERNAL_GATEWAY_ERROR&#x60; - The request could not be processed due to an internal gateway error.   * &#x60;hint&#x60; - A hint how to solve the problem.</value>
        [DataMember(Name = "errorCode", IsRequired = true, EmitDefaultValue = true)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// A unique identifier of the corresponding trace forest. It can be used to trace errors by the support.
        /// </summary>
        /// <value>A unique identifier of the corresponding trace forest. It can be used to trace errors by the support.</value>
        [DataMember(Name = "traceId", IsRequired = true, EmitDefaultValue = true)]
        public string TraceId { get; set; }

        /// <summary>
        /// A unique identifier specific to this error instance. It can be used to trace errors by the support.
        /// </summary>
        /// <value>A unique identifier specific to this error instance. It can be used to trace errors by the support.</value>
        [DataMember(Name = "errorId", EmitDefaultValue = false)]
        public string ErrorId { get; set; }

        /// <summary>
        /// A list of affected parameters and/or properties that caused this error.
        /// </summary>
        /// <value>A list of affected parameters and/or properties that caused this error.</value>
        [DataMember(Name = "causes", EmitDefaultValue = false)]
        public List<CausingError> Causes { get; set; }

        /// <summary>
        /// Additional properties specific to this error class.
        /// </summary>
        /// <value>Additional properties specific to this error class.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public Dictionary<string, Object> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorResponse {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  TraceId: ").Append(TraceId).Append("\n");
            sb.Append("  ErrorId: ").Append(ErrorId).Append("\n");
            sb.Append("  Causes: ").Append(Causes).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as ErrorResponse);
        }

        /// <summary>
        /// Returns true if ErrorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.TraceId == input.TraceId ||
                    (this.TraceId != null &&
                    this.TraceId.Equals(input.TraceId))
                ) && 
                (
                    this.ErrorId == input.ErrorId ||
                    (this.ErrorId != null &&
                    this.ErrorId.Equals(input.ErrorId))
                ) && 
                (
                    this.Causes == input.Causes ||
                    this.Causes != null &&
                    input.Causes != null &&
                    this.Causes.SequenceEqual(input.Causes)
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.TraceId != null)
                {
                    hashCode = (hashCode * 59) + this.TraceId.GetHashCode();
                }
                if (this.ErrorId != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorId.GetHashCode();
                }
                if (this.Causes != null)
                {
                    hashCode = (hashCode * 59) + this.Causes.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
