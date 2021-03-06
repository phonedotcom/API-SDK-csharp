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
    /// The Full QueueObject has the same properties as the Queue Summary Object, along with the following:
    /// </summary>
    [DataContract]
    public partial class QueueFull :  IEquatable<QueueFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueFull" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueueFull() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueFull" /> class.
        /// </summary>
        /// <param name="Id">Integer ID. Read-only. (required).</param>
        /// <param name="Name">Name. Required. (required).</param>
        /// <param name="Greeting">Greeting to be played when caller first connects. Output is a Media Summary Object. Input must be a Media Lookup Object. Must refer to a media recording that has is_hold_music set to FALSE. Can be set to NULL to disable the greeting..</param>
        /// <param name="HoldMusic">HoldMusic.</param>
        /// <param name="MaxHoldTime">Maximum hold time in seconds. If provided, must equal one of: 60, 120, 180, 240, 300, 600, 900, 1200, 1800, 2700, 3600. Default is 300..</param>
        /// <param name="CallerIdType">Caller id type to show members. If provided, must equal one of: &#39;called_number&#39;, &#39;calling_number&#39;. Default is &#39;calling_number&#39;..</param>
        /// <param name="RingTime">Number of seconds to ring a member before cycling to the next member. If provided, must equal one of: 5, 10, 15, 20, 25, 30. Default is 5..</param>
        /// <param name="Members">Array of Member Objects. Non-virtual account extensions or phone numbers. See below for details..</param>
        public QueueFull(int? Id = default(int?), string Name = default(string), MediaSummary Greeting = default(MediaSummary), HoldMusic HoldMusic = default(HoldMusic), int? MaxHoldTime = default(int?), string CallerIdType = default(string), int? RingTime = default(int?), List<Member> Members = default(List<Member>))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for QueueFull and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for QueueFull and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Greeting = Greeting;
            this.HoldMusic = HoldMusic;
            this.MaxHoldTime = MaxHoldTime;
            this.CallerIdType = CallerIdType;
            this.RingTime = RingTime;
            this.Members = Members;
        }
        
        /// <summary>
        /// Integer ID. Read-only.
        /// </summary>
        /// <value>Integer ID. Read-only.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name. Required.
        /// </summary>
        /// <value>Name. Required.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Greeting to be played when caller first connects. Output is a Media Summary Object. Input must be a Media Lookup Object. Must refer to a media recording that has is_hold_music set to FALSE. Can be set to NULL to disable the greeting.
        /// </summary>
        /// <value>Greeting to be played when caller first connects. Output is a Media Summary Object. Input must be a Media Lookup Object. Must refer to a media recording that has is_hold_music set to FALSE. Can be set to NULL to disable the greeting.</value>
        [DataMember(Name="greeting", EmitDefaultValue=false)]
        public MediaSummary Greeting { get; set; }

        /// <summary>
        /// Gets or Sets HoldMusic
        /// </summary>
        [DataMember(Name="hold_music", EmitDefaultValue=false)]
        public HoldMusic HoldMusic { get; set; }

        /// <summary>
        /// Maximum hold time in seconds. If provided, must equal one of: 60, 120, 180, 240, 300, 600, 900, 1200, 1800, 2700, 3600. Default is 300.
        /// </summary>
        /// <value>Maximum hold time in seconds. If provided, must equal one of: 60, 120, 180, 240, 300, 600, 900, 1200, 1800, 2700, 3600. Default is 300.</value>
        [DataMember(Name="max_hold_time", EmitDefaultValue=false)]
        public int? MaxHoldTime { get; set; }

        /// <summary>
        /// Caller id type to show members. If provided, must equal one of: &#39;called_number&#39;, &#39;calling_number&#39;. Default is &#39;calling_number&#39;.
        /// </summary>
        /// <value>Caller id type to show members. If provided, must equal one of: &#39;called_number&#39;, &#39;calling_number&#39;. Default is &#39;calling_number&#39;.</value>
        [DataMember(Name="caller_id_type", EmitDefaultValue=false)]
        public string CallerIdType { get; set; }

        /// <summary>
        /// Number of seconds to ring a member before cycling to the next member. If provided, must equal one of: 5, 10, 15, 20, 25, 30. Default is 5.
        /// </summary>
        /// <value>Number of seconds to ring a member before cycling to the next member. If provided, must equal one of: 5, 10, 15, 20, 25, 30. Default is 5.</value>
        [DataMember(Name="ring_time", EmitDefaultValue=false)]
        public int? RingTime { get; set; }

        /// <summary>
        /// Array of Member Objects. Non-virtual account extensions or phone numbers. See below for details.
        /// </summary>
        /// <value>Array of Member Objects. Non-virtual account extensions or phone numbers. See below for details.</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<Member> Members { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueFull {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Greeting: ").Append(Greeting).Append("\n");
            sb.Append("  HoldMusic: ").Append(HoldMusic).Append("\n");
            sb.Append("  MaxHoldTime: ").Append(MaxHoldTime).Append("\n");
            sb.Append("  CallerIdType: ").Append(CallerIdType).Append("\n");
            sb.Append("  RingTime: ").Append(RingTime).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
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
            return this.Equals(obj as QueueFull);
        }

        /// <summary>
        /// Returns true if QueueFull instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueFull other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Greeting == other.Greeting ||
                    this.Greeting != null &&
                    this.Greeting.Equals(other.Greeting)
                ) && 
                (
                    this.HoldMusic == other.HoldMusic ||
                    this.HoldMusic != null &&
                    this.HoldMusic.Equals(other.HoldMusic)
                ) && 
                (
                    this.MaxHoldTime == other.MaxHoldTime ||
                    this.MaxHoldTime != null &&
                    this.MaxHoldTime.Equals(other.MaxHoldTime)
                ) && 
                (
                    this.CallerIdType == other.CallerIdType ||
                    this.CallerIdType != null &&
                    this.CallerIdType.Equals(other.CallerIdType)
                ) && 
                (
                    this.RingTime == other.RingTime ||
                    this.RingTime != null &&
                    this.RingTime.Equals(other.RingTime)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Greeting != null)
                    hash = hash * 59 + this.Greeting.GetHashCode();
                if (this.HoldMusic != null)
                    hash = hash * 59 + this.HoldMusic.GetHashCode();
                if (this.MaxHoldTime != null)
                    hash = hash * 59 + this.MaxHoldTime.GetHashCode();
                if (this.CallerIdType != null)
                    hash = hash * 59 + this.CallerIdType.GetHashCode();
                if (this.RingTime != null)
                    hash = hash * 59 + this.RingTime.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
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
