/* 
 * Phone.com API
 *
 * This is a Phone.com api Swagger definition
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apisupport@phone.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// CreateCallParams
    /// </summary>
    [DataContract]
    public partial class CreateCallParams :  IEquatable<CreateCallParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCallParams" /> class.
        /// </summary>
        /// <param name="CallerPhoneNumber">Caller phone number in E.164 format.</param>
        /// <param name="CallerExtension">Caller Extension ID.</param>
        /// <param name="CallerCallerId">Caller caller ID in E.164 format.</param>
        /// <param name="CallerPrivate">Flag to set caller ID to private.</param>
        /// <param name="CalleePhoneNumber">Callee phone number in E.164 format.</param>
        /// <param name="CalleeExtension">Callee Extension ID.</param>
        /// <param name="CalleeCallerId">Callee caller ID in E.164 format.</param>
        /// <param name="CalleePrivate">Flag to set callee ID to private.</param>
        public CreateCallParams(string CallerPhoneNumber = default(string), int? CallerExtension = default(int?), string CallerCallerId = default(string), string CallerPrivate = default(string), string CalleePhoneNumber = default(string), int? CalleeExtension = default(int?), string CalleeCallerId = default(string), string CalleePrivate = default(string))
        {
            this.CallerPhoneNumber = CallerPhoneNumber;
            this.CallerExtension = CallerExtension;
            this.CallerCallerId = CallerCallerId;
            this.CallerPrivate = CallerPrivate;
            this.CalleePhoneNumber = CalleePhoneNumber;
            this.CalleeExtension = CalleeExtension;
            this.CalleeCallerId = CalleeCallerId;
            this.CalleePrivate = CalleePrivate;
        }
        
        /// <summary>
        /// Caller phone number in E.164 format
        /// </summary>
        /// <value>Caller phone number in E.164 format</value>
        [DataMember(Name="caller_phone_number", EmitDefaultValue=false)]
        public string CallerPhoneNumber { get; set; }

        /// <summary>
        /// Caller Extension ID
        /// </summary>
        /// <value>Caller Extension ID</value>
        [DataMember(Name="caller_extension", EmitDefaultValue=false)]
        public int? CallerExtension { get; set; }

        /// <summary>
        /// Caller caller ID in E.164 format
        /// </summary>
        /// <value>Caller caller ID in E.164 format</value>
        [DataMember(Name="caller_caller_id", EmitDefaultValue=false)]
        public string CallerCallerId { get; set; }

        /// <summary>
        /// Flag to set caller ID to private
        /// </summary>
        /// <value>Flag to set caller ID to private</value>
        [DataMember(Name="caller_private", EmitDefaultValue=false)]
        public string CallerPrivate { get; set; }

        /// <summary>
        /// Callee phone number in E.164 format
        /// </summary>
        /// <value>Callee phone number in E.164 format</value>
        [DataMember(Name="callee_phone_number", EmitDefaultValue=false)]
        public string CalleePhoneNumber { get; set; }

        /// <summary>
        /// Callee Extension ID
        /// </summary>
        /// <value>Callee Extension ID</value>
        [DataMember(Name="callee_extension", EmitDefaultValue=false)]
        public int? CalleeExtension { get; set; }

        /// <summary>
        /// Callee caller ID in E.164 format
        /// </summary>
        /// <value>Callee caller ID in E.164 format</value>
        [DataMember(Name="callee_caller_id", EmitDefaultValue=false)]
        public string CalleeCallerId { get; set; }

        /// <summary>
        /// Flag to set callee ID to private
        /// </summary>
        /// <value>Flag to set callee ID to private</value>
        [DataMember(Name="callee_private", EmitDefaultValue=false)]
        public string CalleePrivate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCallParams {\n");
            sb.Append("  CallerPhoneNumber: ").Append(CallerPhoneNumber).Append("\n");
            sb.Append("  CallerExtension: ").Append(CallerExtension).Append("\n");
            sb.Append("  CallerCallerId: ").Append(CallerCallerId).Append("\n");
            sb.Append("  CallerPrivate: ").Append(CallerPrivate).Append("\n");
            sb.Append("  CalleePhoneNumber: ").Append(CalleePhoneNumber).Append("\n");
            sb.Append("  CalleeExtension: ").Append(CalleeExtension).Append("\n");
            sb.Append("  CalleeCallerId: ").Append(CalleeCallerId).Append("\n");
            sb.Append("  CalleePrivate: ").Append(CalleePrivate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateCallParams);
        }

        /// <summary>
        /// Returns true if CreateCallParams instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCallParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCallParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CallerPhoneNumber == other.CallerPhoneNumber ||
                    this.CallerPhoneNumber != null &&
                    this.CallerPhoneNumber.Equals(other.CallerPhoneNumber)
                ) && 
                (
                    this.CallerExtension == other.CallerExtension ||
                    this.CallerExtension != null &&
                    this.CallerExtension.Equals(other.CallerExtension)
                ) && 
                (
                    this.CallerCallerId == other.CallerCallerId ||
                    this.CallerCallerId != null &&
                    this.CallerCallerId.Equals(other.CallerCallerId)
                ) && 
                (
                    this.CallerPrivate == other.CallerPrivate ||
                    this.CallerPrivate != null &&
                    this.CallerPrivate.Equals(other.CallerPrivate)
                ) && 
                (
                    this.CalleePhoneNumber == other.CalleePhoneNumber ||
                    this.CalleePhoneNumber != null &&
                    this.CalleePhoneNumber.Equals(other.CalleePhoneNumber)
                ) && 
                (
                    this.CalleeExtension == other.CalleeExtension ||
                    this.CalleeExtension != null &&
                    this.CalleeExtension.Equals(other.CalleeExtension)
                ) && 
                (
                    this.CalleeCallerId == other.CalleeCallerId ||
                    this.CalleeCallerId != null &&
                    this.CalleeCallerId.Equals(other.CalleeCallerId)
                ) && 
                (
                    this.CalleePrivate == other.CalleePrivate ||
                    this.CalleePrivate != null &&
                    this.CalleePrivate.Equals(other.CalleePrivate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CallerPhoneNumber != null)
                    hash = hash * 59 + this.CallerPhoneNumber.GetHashCode();
                if (this.CallerExtension != null)
                    hash = hash * 59 + this.CallerExtension.GetHashCode();
                if (this.CallerCallerId != null)
                    hash = hash * 59 + this.CallerCallerId.GetHashCode();
                if (this.CallerPrivate != null)
                    hash = hash * 59 + this.CallerPrivate.GetHashCode();
                if (this.CalleePhoneNumber != null)
                    hash = hash * 59 + this.CalleePhoneNumber.GetHashCode();
                if (this.CalleeExtension != null)
                    hash = hash * 59 + this.CalleeExtension.GetHashCode();
                if (this.CalleeCallerId != null)
                    hash = hash * 59 + this.CalleeCallerId.GetHashCode();
                if (this.CalleePrivate != null)
                    hash = hash * 59 + this.CalleePrivate.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
