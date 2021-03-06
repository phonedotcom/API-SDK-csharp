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
    /// CreatePricingParams
    /// </summary>
    [DataContract]
    public partial class CreatePricingParams :  IEquatable<CreatePricingParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePricingParams" /> class.
        /// </summary>
        /// <param name="PricingId">Pricing plan code.</param>
        /// <param name="Reason">Reason this pricing plan is added to the subaccount.</param>
        /// <param name="ExpireDate">Pricing plan expiration time in UNIX format. Disregard or set it to null for plan which never expires.</param>
        public CreatePricingParams(int? PricingId = default(int?), string Reason = default(string), int? ExpireDate = default(int?))
        {
            this.PricingId = PricingId;
            this.Reason = Reason;
            this.ExpireDate = ExpireDate;
        }
        
        /// <summary>
        /// Pricing plan code
        /// </summary>
        /// <value>Pricing plan code</value>
        [DataMember(Name="pricing_id", EmitDefaultValue=false)]
        public int? PricingId { get; set; }

        /// <summary>
        /// Reason this pricing plan is added to the subaccount
        /// </summary>
        /// <value>Reason this pricing plan is added to the subaccount</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Pricing plan expiration time in UNIX format. Disregard or set it to null for plan which never expires
        /// </summary>
        /// <value>Pricing plan expiration time in UNIX format. Disregard or set it to null for plan which never expires</value>
        [DataMember(Name="expire_date", EmitDefaultValue=false)]
        public int? ExpireDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePricingParams {\n");
            sb.Append("  PricingId: ").Append(PricingId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ExpireDate: ").Append(ExpireDate).Append("\n");
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
            return this.Equals(obj as CreatePricingParams);
        }

        /// <summary>
        /// Returns true if CreatePricingParams instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePricingParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePricingParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PricingId == other.PricingId ||
                    this.PricingId != null &&
                    this.PricingId.Equals(other.PricingId)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.ExpireDate == other.ExpireDate ||
                    this.ExpireDate != null &&
                    this.ExpireDate.Equals(other.ExpireDate)
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
                if (this.PricingId != null)
                    hash = hash * 59 + this.PricingId.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.ExpireDate != null)
                    hash = hash * 59 + this.ExpireDate.GetHashCode();
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
