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
    /// CreateContactParams
    /// </summary>
    [DataContract]
    public partial class CreateContactParams :  IEquatable<CreateContactParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactParams" /> class.
        /// </summary>
        /// <param name="FirstName">First Name.</param>
        /// <param name="MiddleName">Middle Name.</param>
        /// <param name="LastName">Last Name.</param>
        /// <param name="Prefix">Prefix.</param>
        /// <param name="PhoneticFirstName">Phonetic First Name.</param>
        /// <param name="PhoneticMiddleName">Phonetic Middle Name.</param>
        /// <param name="PhoneticLastName">Phonetic Last Name.</param>
        /// <param name="Suffix">Suffix.</param>
        /// <param name="Nickname">Nickname.</param>
        /// <param name="Company">Company Name.</param>
        /// <param name="Department">Department Name.</param>
        /// <param name="JobTitle">Job Title.</param>
        /// <param name="Emails">Email Addresses.</param>
        /// <param name="PhoneNumbers">Phone Numbers.</param>
        /// <param name="Addresses">Addresses.</param>
        /// <param name="Group">Contact Group.</param>
        public CreateContactParams(string FirstName = default(string), string MiddleName = default(string), string LastName = default(string), string Prefix = default(string), string PhoneticFirstName = default(string), string PhoneticMiddleName = default(string), string PhoneticLastName = default(string), string Suffix = default(string), string Nickname = default(string), string Company = default(string), string Department = default(string), string JobTitle = default(string), List<Email> Emails = default(List<Email>), List<PhoneNumberContact> PhoneNumbers = default(List<PhoneNumberContact>), List<AddressListContacts> Addresses = default(List<AddressListContacts>), Object Group = default(Object))
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Prefix = Prefix;
            this.PhoneticFirstName = PhoneticFirstName;
            this.PhoneticMiddleName = PhoneticMiddleName;
            this.PhoneticLastName = PhoneticLastName;
            this.Suffix = Suffix;
            this.Nickname = Nickname;
            this.Company = Company;
            this.Department = Department;
            this.JobTitle = JobTitle;
            this.Emails = Emails;
            this.PhoneNumbers = PhoneNumbers;
            this.Addresses = Addresses;
            this.Group = Group;
        }
        
        /// <summary>
        /// First Name
        /// </summary>
        /// <value>First Name</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Middle Name
        /// </summary>
        /// <value>Middle Name</value>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        /// <value>Last Name</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Prefix
        /// </summary>
        /// <value>Prefix</value>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Phonetic First Name
        /// </summary>
        /// <value>Phonetic First Name</value>
        [DataMember(Name="phonetic_first_name", EmitDefaultValue=false)]
        public string PhoneticFirstName { get; set; }

        /// <summary>
        /// Phonetic Middle Name
        /// </summary>
        /// <value>Phonetic Middle Name</value>
        [DataMember(Name="phonetic_middle_name", EmitDefaultValue=false)]
        public string PhoneticMiddleName { get; set; }

        /// <summary>
        /// Phonetic Last Name
        /// </summary>
        /// <value>Phonetic Last Name</value>
        [DataMember(Name="phonetic_last_name", EmitDefaultValue=false)]
        public string PhoneticLastName { get; set; }

        /// <summary>
        /// Suffix
        /// </summary>
        /// <value>Suffix</value>
        [DataMember(Name="suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        /// <value>Nickname</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        /// <value>Company Name</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Department Name
        /// </summary>
        /// <value>Department Name</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Job Title
        /// </summary>
        /// <value>Job Title</value>
        [DataMember(Name="job_title", EmitDefaultValue=false)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Email Addresses
        /// </summary>
        /// <value>Email Addresses</value>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<Email> Emails { get; set; }

        /// <summary>
        /// Phone Numbers
        /// </summary>
        /// <value>Phone Numbers</value>
        [DataMember(Name="phone_numbers", EmitDefaultValue=false)]
        public List<PhoneNumberContact> PhoneNumbers { get; set; }

        /// <summary>
        /// Addresses
        /// </summary>
        /// <value>Addresses</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<AddressListContacts> Addresses { get; set; }

        /// <summary>
        /// Contact Group
        /// </summary>
        /// <value>Contact Group</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Object Group { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateContactParams {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  PhoneticFirstName: ").Append(PhoneticFirstName).Append("\n");
            sb.Append("  PhoneticMiddleName: ").Append(PhoneticMiddleName).Append("\n");
            sb.Append("  PhoneticLastName: ").Append(PhoneticLastName).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
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
            return this.Equals(obj as CreateContactParams);
        }

        /// <summary>
        /// Returns true if CreateContactParams instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateContactParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateContactParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Prefix == other.Prefix ||
                    this.Prefix != null &&
                    this.Prefix.Equals(other.Prefix)
                ) && 
                (
                    this.PhoneticFirstName == other.PhoneticFirstName ||
                    this.PhoneticFirstName != null &&
                    this.PhoneticFirstName.Equals(other.PhoneticFirstName)
                ) && 
                (
                    this.PhoneticMiddleName == other.PhoneticMiddleName ||
                    this.PhoneticMiddleName != null &&
                    this.PhoneticMiddleName.Equals(other.PhoneticMiddleName)
                ) && 
                (
                    this.PhoneticLastName == other.PhoneticLastName ||
                    this.PhoneticLastName != null &&
                    this.PhoneticLastName.Equals(other.PhoneticLastName)
                ) && 
                (
                    this.Suffix == other.Suffix ||
                    this.Suffix != null &&
                    this.Suffix.Equals(other.Suffix)
                ) && 
                (
                    this.Nickname == other.Nickname ||
                    this.Nickname != null &&
                    this.Nickname.Equals(other.Nickname)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) && 
                (
                    this.JobTitle == other.JobTitle ||
                    this.JobTitle != null &&
                    this.JobTitle.Equals(other.JobTitle)
                ) && 
                (
                    this.Emails == other.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(other.Emails)
                ) && 
                (
                    this.PhoneNumbers == other.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(other.PhoneNumbers)
                ) && 
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
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
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Prefix != null)
                    hash = hash * 59 + this.Prefix.GetHashCode();
                if (this.PhoneticFirstName != null)
                    hash = hash * 59 + this.PhoneticFirstName.GetHashCode();
                if (this.PhoneticMiddleName != null)
                    hash = hash * 59 + this.PhoneticMiddleName.GetHashCode();
                if (this.PhoneticLastName != null)
                    hash = hash * 59 + this.PhoneticLastName.GetHashCode();
                if (this.Suffix != null)
                    hash = hash * 59 + this.Suffix.GetHashCode();
                if (this.Nickname != null)
                    hash = hash * 59 + this.Nickname.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.JobTitle != null)
                    hash = hash * 59 + this.JobTitle.GetHashCode();
                if (this.Emails != null)
                    hash = hash * 59 + this.Emails.GetHashCode();
                if (this.PhoneNumbers != null)
                    hash = hash * 59 + this.PhoneNumbers.GetHashCode();
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
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
