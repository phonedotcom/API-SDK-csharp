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
    /// Voicemail Greeting Object. See below for details. Can be set to NULL to reset greeting options.
    /// </summary>
    [DataContract]
    public partial class Greeting :  IEquatable<Greeting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Greeting" /> class.
        /// </summary>
        /// <param name="Type">The greeting to play. Can be \&quot;name\&quot; for the name_greeting as described above, \&quot;standard\&quot; for the standard greeting, or \&quot;alternate\&quot; for an alternate greeting. See below for details..</param>
        /// <param name="Alternate">Greeting to be played when type&#x3D;\&quot;alternate\&quot;. Output is a Greeting Summary Object. Input must be a Greeting Lookup Object..</param>
        /// <param name="Standard">Greeting to be played when type&#x3D;\&quot;standard\&quot;. Output is a Greeting Summary Object. Input must be a Greeting Lookup Object..</param>
        /// <param name="EnableLeaveMessagePrompt">Whether to prompt the caller with the following words after the voicemail greeting has been played: \&quot;Please leave your message after the tone. When finished, hang up or press the pound key.\&quot; Boolean..</param>
        public Greeting(string Type = default(string), MediaSummary Alternate = default(MediaSummary), MediaSummary Standard = default(MediaSummary), bool? EnableLeaveMessagePrompt = default(bool?))
        {
            this.Type = Type;
            this.Alternate = Alternate;
            this.Standard = Standard;
            this.EnableLeaveMessagePrompt = EnableLeaveMessagePrompt;
        }
        
        /// <summary>
        /// The greeting to play. Can be \&quot;name\&quot; for the name_greeting as described above, \&quot;standard\&quot; for the standard greeting, or \&quot;alternate\&quot; for an alternate greeting. See below for details.
        /// </summary>
        /// <value>The greeting to play. Can be \&quot;name\&quot; for the name_greeting as described above, \&quot;standard\&quot; for the standard greeting, or \&quot;alternate\&quot; for an alternate greeting. See below for details.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Greeting to be played when type&#x3D;\&quot;alternate\&quot;. Output is a Greeting Summary Object. Input must be a Greeting Lookup Object.
        /// </summary>
        /// <value>Greeting to be played when type&#x3D;\&quot;alternate\&quot;. Output is a Greeting Summary Object. Input must be a Greeting Lookup Object.</value>
        [DataMember(Name="alternate", EmitDefaultValue=false)]
        public MediaSummary Alternate { get; set; }

        /// <summary>
        /// Greeting to be played when type&#x3D;\&quot;standard\&quot;. Output is a Greeting Summary Object. Input must be a Greeting Lookup Object.
        /// </summary>
        /// <value>Greeting to be played when type&#x3D;\&quot;standard\&quot;. Output is a Greeting Summary Object. Input must be a Greeting Lookup Object.</value>
        [DataMember(Name="standard", EmitDefaultValue=false)]
        public MediaSummary Standard { get; set; }

        /// <summary>
        /// Whether to prompt the caller with the following words after the voicemail greeting has been played: \&quot;Please leave your message after the tone. When finished, hang up or press the pound key.\&quot; Boolean.
        /// </summary>
        /// <value>Whether to prompt the caller with the following words after the voicemail greeting has been played: \&quot;Please leave your message after the tone. When finished, hang up or press the pound key.\&quot; Boolean.</value>
        [DataMember(Name="enable_leave_message_prompt", EmitDefaultValue=false)]
        public bool? EnableLeaveMessagePrompt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Greeting {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Alternate: ").Append(Alternate).Append("\n");
            sb.Append("  Standard: ").Append(Standard).Append("\n");
            sb.Append("  EnableLeaveMessagePrompt: ").Append(EnableLeaveMessagePrompt).Append("\n");
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
            return this.Equals(obj as Greeting);
        }

        /// <summary>
        /// Returns true if Greeting instances are equal
        /// </summary>
        /// <param name="other">Instance of Greeting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Greeting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Alternate == other.Alternate ||
                    this.Alternate != null &&
                    this.Alternate.Equals(other.Alternate)
                ) && 
                (
                    this.Standard == other.Standard ||
                    this.Standard != null &&
                    this.Standard.Equals(other.Standard)
                ) && 
                (
                    this.EnableLeaveMessagePrompt == other.EnableLeaveMessagePrompt ||
                    this.EnableLeaveMessagePrompt != null &&
                    this.EnableLeaveMessagePrompt.Equals(other.EnableLeaveMessagePrompt)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Alternate != null)
                    hash = hash * 59 + this.Alternate.GetHashCode();
                if (this.Standard != null)
                    hash = hash * 59 + this.Standard.GetHashCode();
                if (this.EnableLeaveMessagePrompt != null)
                    hash = hash * 59 + this.EnableLeaveMessagePrompt.GetHashCode();
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
