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
    /// The Payment Method Full Object contains the same properties as the Payment Method Summary Object, along with the following:
    /// </summary>
    [DataContract]
    public partial class PaymentFull :  IEquatable<PaymentFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentFull" /> class.
        /// </summary>
        /// <param name="Id">Payment Method ID.</param>
        /// <param name="VoipId">API Account ID.</param>
        /// <param name="Status">&#39;primary&#39; &#x3D; primary card used for billing; &#39;onfile&#39; &#x3D; card on file; &#39;hidden&#39; &#x3D; deleted card;.</param>
        /// <param name="Nickname">Name of Card.</param>
        /// <param name="Type">&#39;cc&#39; for credit card.</param>
        /// <param name="CreatedAt">Time payment record is created.</param>
        /// <param name="Contact">Detail of contact person.</param>
        /// <param name="DeclineCount">Number of times the payment method was declined.</param>
        /// <param name="NextChargeDate">Next billing date.</param>
        /// <param name="UpdatedAt">Last time the payment method was updated.</param>
        /// <param name="CcToken">Encrypted credit card token to be used for billing.</param>
        /// <param name="CcNumber">Credit card number partially masked with xxxxxxxx.</param>
        /// <param name="CcExp">Credit card expiration date.</param>
        public PaymentFull(int? Id = default(int?), int? VoipId = default(int?), string Status = default(string), string Nickname = default(string), string Type = default(string), int? CreatedAt = default(int?), ContactResponse Contact = default(ContactResponse), int? DeclineCount = default(int?), int? NextChargeDate = default(int?), int? UpdatedAt = default(int?), string CcToken = default(string), string CcNumber = default(string), string CcExp = default(string))
        {
            this.Id = Id;
            this.VoipId = VoipId;
            this.Status = Status;
            this.Nickname = Nickname;
            this.Type = Type;
            this.CreatedAt = CreatedAt;
            this.Contact = Contact;
            this.DeclineCount = DeclineCount;
            this.NextChargeDate = NextChargeDate;
            this.UpdatedAt = UpdatedAt;
            this.CcToken = CcToken;
            this.CcNumber = CcNumber;
            this.CcExp = CcExp;
        }
        
        /// <summary>
        /// Payment Method ID
        /// </summary>
        /// <value>Payment Method ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// API Account ID
        /// </summary>
        /// <value>API Account ID</value>
        [DataMember(Name="voip_id", EmitDefaultValue=false)]
        public int? VoipId { get; set; }

        /// <summary>
        /// &#39;primary&#39; &#x3D; primary card used for billing; &#39;onfile&#39; &#x3D; card on file; &#39;hidden&#39; &#x3D; deleted card;
        /// </summary>
        /// <value>&#39;primary&#39; &#x3D; primary card used for billing; &#39;onfile&#39; &#x3D; card on file; &#39;hidden&#39; &#x3D; deleted card;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Name of Card
        /// </summary>
        /// <value>Name of Card</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// &#39;cc&#39; for credit card
        /// </summary>
        /// <value>&#39;cc&#39; for credit card</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Time payment record is created
        /// </summary>
        /// <value>Time payment record is created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// Detail of contact person
        /// </summary>
        /// <value>Detail of contact person</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ContactResponse Contact { get; set; }

        /// <summary>
        /// Number of times the payment method was declined
        /// </summary>
        /// <value>Number of times the payment method was declined</value>
        [DataMember(Name="decline_count", EmitDefaultValue=false)]
        public int? DeclineCount { get; set; }

        /// <summary>
        /// Next billing date
        /// </summary>
        /// <value>Next billing date</value>
        [DataMember(Name="next_charge_date", EmitDefaultValue=false)]
        public int? NextChargeDate { get; set; }

        /// <summary>
        /// Last time the payment method was updated
        /// </summary>
        /// <value>Last time the payment method was updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public int? UpdatedAt { get; set; }

        /// <summary>
        /// Encrypted credit card token to be used for billing
        /// </summary>
        /// <value>Encrypted credit card token to be used for billing</value>
        [DataMember(Name="cc_token", EmitDefaultValue=false)]
        public string CcToken { get; set; }

        /// <summary>
        /// Credit card number partially masked with xxxxxxxx
        /// </summary>
        /// <value>Credit card number partially masked with xxxxxxxx</value>
        [DataMember(Name="cc_number", EmitDefaultValue=false)]
        public string CcNumber { get; set; }

        /// <summary>
        /// Credit card expiration date
        /// </summary>
        /// <value>Credit card expiration date</value>
        [DataMember(Name="cc_exp", EmitDefaultValue=false)]
        public string CcExp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentFull {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VoipId: ").Append(VoipId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  DeclineCount: ").Append(DeclineCount).Append("\n");
            sb.Append("  NextChargeDate: ").Append(NextChargeDate).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CcToken: ").Append(CcToken).Append("\n");
            sb.Append("  CcNumber: ").Append(CcNumber).Append("\n");
            sb.Append("  CcExp: ").Append(CcExp).Append("\n");
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
            return this.Equals(obj as PaymentFull);
        }

        /// <summary>
        /// Returns true if PaymentFull instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentFull other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.VoipId == other.VoipId ||
                    this.VoipId != null &&
                    this.VoipId.Equals(other.VoipId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Nickname == other.Nickname ||
                    this.Nickname != null &&
                    this.Nickname.Equals(other.Nickname)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.DeclineCount == other.DeclineCount ||
                    this.DeclineCount != null &&
                    this.DeclineCount.Equals(other.DeclineCount)
                ) && 
                (
                    this.NextChargeDate == other.NextChargeDate ||
                    this.NextChargeDate != null &&
                    this.NextChargeDate.Equals(other.NextChargeDate)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.CcToken == other.CcToken ||
                    this.CcToken != null &&
                    this.CcToken.Equals(other.CcToken)
                ) && 
                (
                    this.CcNumber == other.CcNumber ||
                    this.CcNumber != null &&
                    this.CcNumber.Equals(other.CcNumber)
                ) && 
                (
                    this.CcExp == other.CcExp ||
                    this.CcExp != null &&
                    this.CcExp.Equals(other.CcExp)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.VoipId != null)
                    hash = hash * 59 + this.VoipId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Nickname != null)
                    hash = hash * 59 + this.Nickname.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                if (this.DeclineCount != null)
                    hash = hash * 59 + this.DeclineCount.GetHashCode();
                if (this.NextChargeDate != null)
                    hash = hash * 59 + this.NextChargeDate.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.CcToken != null)
                    hash = hash * 59 + this.CcToken.GetHashCode();
                if (this.CcNumber != null)
                    hash = hash * 59 + this.CcNumber.GetHashCode();
                if (this.CcExp != null)
                    hash = hash * 59 + this.CcExp.GetHashCode();
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
