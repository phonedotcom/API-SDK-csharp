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

namespace IO.Swagger.Model
{
    /// <summary>
    /// CreatePhoneNumberParams
    /// </summary>
    [DataContract]
    public partial class CreatePhoneNumberParams :  IEquatable<CreatePhoneNumberParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePhoneNumberParams" /> class.
        /// </summary>
        /// <param name="PhoneNumber">Phone number.</param>
        /// <param name="Route">Route lookup object.</param>
        /// <param name="Name">Phone Name.</param>
        /// <param name="BlockIncoming">Block incoming calls.</param>
        /// <param name="BlockAnonymous">Block anonymous calls.</param>
        /// <param name="CallerIdName">Caller ID name.</param>
        /// <param name="CallerIdType">Caller ID type.</param>
        /// <param name="SmsForwardingType">&#39;application&#39; or &#39;extension&#39;.</param>
        /// <param name="SmsForwardingApplication">Application lookup object.</param>
        /// <param name="SmsForwardingExtension">Extension lookup object.</param>
        /// <param name="CallNotificationsEmails">Call notifications for emails. Can be a single email or an array of emails.</param>
        /// <param name="CallNotificationsSms">Call notification for SMS.</param>
        public CreatePhoneNumberParams(Object PhoneNumber = default(Object), Object Route = default(Object), string Name = default(string), bool? BlockIncoming = default(bool?), bool? BlockAnonymous = default(bool?), string CallerIdName = default(string), string CallerIdType = default(string), string SmsForwardingType = default(string), Object SmsForwardingApplication = default(Object), Object SmsForwardingExtension = default(Object), List<string> CallNotificationsEmails = default(List<string>), string CallNotificationsSms = default(string))
        {
            this.PhoneNumber = PhoneNumber;
            this.Route = Route;
            this.Name = Name;
            this.BlockIncoming = BlockIncoming;
            this.BlockAnonymous = BlockAnonymous;
            this.CallerIdName = CallerIdName;
            this.CallerIdType = CallerIdType;
            this.SmsForwardingType = SmsForwardingType;
            this.SmsForwardingApplication = SmsForwardingApplication;
            this.SmsForwardingExtension = SmsForwardingExtension;
            this.CallNotificationsEmails = CallNotificationsEmails;
            this.CallNotificationsSms = CallNotificationsSms;
        }
        
        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public Object PhoneNumber { get; set; }
        /// <summary>
        /// Route lookup object
        /// </summary>
        /// <value>Route lookup object</value>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public Object Route { get; set; }
        /// <summary>
        /// Phone Name
        /// </summary>
        /// <value>Phone Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Block incoming calls
        /// </summary>
        /// <value>Block incoming calls</value>
        [DataMember(Name="block_incoming", EmitDefaultValue=false)]
        public bool? BlockIncoming { get; set; }
        /// <summary>
        /// Block anonymous calls
        /// </summary>
        /// <value>Block anonymous calls</value>
        [DataMember(Name="block_anonymous", EmitDefaultValue=false)]
        public bool? BlockAnonymous { get; set; }
        /// <summary>
        /// Caller ID name
        /// </summary>
        /// <value>Caller ID name</value>
        [DataMember(Name="caller_id[name]", EmitDefaultValue=false)]
        public string CallerIdName { get; set; }
        /// <summary>
        /// Caller ID type
        /// </summary>
        /// <value>Caller ID type</value>
        [DataMember(Name="caller_id[type]", EmitDefaultValue=false)]
        public string CallerIdType { get; set; }
        /// <summary>
        /// &#39;application&#39; or &#39;extension&#39;
        /// </summary>
        /// <value>&#39;application&#39; or &#39;extension&#39;</value>
        [DataMember(Name="sms_forwarding[type]", EmitDefaultValue=false)]
        public string SmsForwardingType { get; set; }
        /// <summary>
        /// Application lookup object
        /// </summary>
        /// <value>Application lookup object</value>
        [DataMember(Name="sms_forwarding[application]", EmitDefaultValue=false)]
        public Object SmsForwardingApplication { get; set; }
        /// <summary>
        /// Extension lookup object
        /// </summary>
        /// <value>Extension lookup object</value>
        [DataMember(Name="sms_forwarding[extension]", EmitDefaultValue=false)]
        public Object SmsForwardingExtension { get; set; }
        /// <summary>
        /// Call notifications for emails. Can be a single email or an array of emails
        /// </summary>
        /// <value>Call notifications for emails. Can be a single email or an array of emails</value>
        [DataMember(Name="call_notifications[emails]", EmitDefaultValue=false)]
        public List<string> CallNotificationsEmails { get; set; }
        /// <summary>
        /// Call notification for SMS
        /// </summary>
        /// <value>Call notification for SMS</value>
        [DataMember(Name="call_notifications[sms]", EmitDefaultValue=false)]
        public string CallNotificationsSms { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePhoneNumberParams {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BlockIncoming: ").Append(BlockIncoming).Append("\n");
            sb.Append("  BlockAnonymous: ").Append(BlockAnonymous).Append("\n");
            sb.Append("  CallerIdName: ").Append(CallerIdName).Append("\n");
            sb.Append("  CallerIdType: ").Append(CallerIdType).Append("\n");
            sb.Append("  SmsForwardingType: ").Append(SmsForwardingType).Append("\n");
            sb.Append("  SmsForwardingApplication: ").Append(SmsForwardingApplication).Append("\n");
            sb.Append("  SmsForwardingExtension: ").Append(SmsForwardingExtension).Append("\n");
            sb.Append("  CallNotificationsEmails: ").Append(CallNotificationsEmails).Append("\n");
            sb.Append("  CallNotificationsSms: ").Append(CallNotificationsSms).Append("\n");
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
            return this.Equals(obj as CreatePhoneNumberParams);
        }

        /// <summary>
        /// Returns true if CreatePhoneNumberParams instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePhoneNumberParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePhoneNumberParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Route == other.Route ||
                    this.Route != null &&
                    this.Route.Equals(other.Route)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.BlockIncoming == other.BlockIncoming ||
                    this.BlockIncoming != null &&
                    this.BlockIncoming.Equals(other.BlockIncoming)
                ) && 
                (
                    this.BlockAnonymous == other.BlockAnonymous ||
                    this.BlockAnonymous != null &&
                    this.BlockAnonymous.Equals(other.BlockAnonymous)
                ) && 
                (
                    this.CallerIdName == other.CallerIdName ||
                    this.CallerIdName != null &&
                    this.CallerIdName.Equals(other.CallerIdName)
                ) && 
                (
                    this.CallerIdType == other.CallerIdType ||
                    this.CallerIdType != null &&
                    this.CallerIdType.Equals(other.CallerIdType)
                ) && 
                (
                    this.SmsForwardingType == other.SmsForwardingType ||
                    this.SmsForwardingType != null &&
                    this.SmsForwardingType.Equals(other.SmsForwardingType)
                ) && 
                (
                    this.SmsForwardingApplication == other.SmsForwardingApplication ||
                    this.SmsForwardingApplication != null &&
                    this.SmsForwardingApplication.Equals(other.SmsForwardingApplication)
                ) && 
                (
                    this.SmsForwardingExtension == other.SmsForwardingExtension ||
                    this.SmsForwardingExtension != null &&
                    this.SmsForwardingExtension.Equals(other.SmsForwardingExtension)
                ) && 
                (
                    this.CallNotificationsEmails == other.CallNotificationsEmails ||
                    this.CallNotificationsEmails != null &&
                    this.CallNotificationsEmails.SequenceEqual(other.CallNotificationsEmails)
                ) && 
                (
                    this.CallNotificationsSms == other.CallNotificationsSms ||
                    this.CallNotificationsSms != null &&
                    this.CallNotificationsSms.Equals(other.CallNotificationsSms)
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
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.Route != null)
                    hash = hash * 59 + this.Route.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.BlockIncoming != null)
                    hash = hash * 59 + this.BlockIncoming.GetHashCode();
                if (this.BlockAnonymous != null)
                    hash = hash * 59 + this.BlockAnonymous.GetHashCode();
                if (this.CallerIdName != null)
                    hash = hash * 59 + this.CallerIdName.GetHashCode();
                if (this.CallerIdType != null)
                    hash = hash * 59 + this.CallerIdType.GetHashCode();
                if (this.SmsForwardingType != null)
                    hash = hash * 59 + this.SmsForwardingType.GetHashCode();
                if (this.SmsForwardingApplication != null)
                    hash = hash * 59 + this.SmsForwardingApplication.GetHashCode();
                if (this.SmsForwardingExtension != null)
                    hash = hash * 59 + this.SmsForwardingExtension.GetHashCode();
                if (this.CallNotificationsEmails != null)
                    hash = hash * 59 + this.CallNotificationsEmails.GetHashCode();
                if (this.CallNotificationsSms != null)
                    hash = hash * 59 + this.CallNotificationsSms.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
