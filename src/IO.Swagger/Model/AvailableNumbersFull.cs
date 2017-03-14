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
    /// The Full Available Phone Number Object includes the properties in the Summary Object, along with the following:
    /// </summary>
    [DataContract]
    public partial class AvailableNumbersFull :  IEquatable<AvailableNumbersFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableNumbersFull" /> class.
        /// </summary>
        /// <param name="PhoneNumber">Phone number, in E.164 format.</param>
        /// <param name="Formatted">Human-readable formatted version of the phone number.</param>
        /// <param name="Price">The one-time initial price for this number, in USD. Some numbers show REQUEST_QUOTE here. Please contact our sales department if you are interested in these numbers..</param>
        /// <param name="IsTollFree">Whether the number is toll-free.</param>
        /// <param name="CountryCode">The international dialing prefix for this number. For US and Canadian numbers, for example, this will be \&quot;1\&quot;..</param>
        /// <param name="Npa">Area code (a.k.a. NPA). Included for North American numbers only..</param>
        /// <param name="Nxx">Second 3 digits (a.k.a. NXX). Included for North American numbers only..</param>
        /// <param name="Xxxx">Last 4 digits (a.k.a. XXXX). Included for North American numbers only..</param>
        /// <param name="City">City with which this number is associated, if known. Otherwise NULL..</param>
        /// <param name="Province">State or Province with which this number is associated, if known. Postal Code. Otherwise NULL..</param>
        /// <param name="Country">Country with which this number is associated, if known. Otherwise NULL..</param>
        public AvailableNumbersFull(string PhoneNumber = default(string), string Formatted = default(string), int? Price = default(int?), bool? IsTollFree = default(bool?), string CountryCode = default(string), string Npa = default(string), string Nxx = default(string), string Xxxx = default(string), string City = default(string), string Province = default(string), string Country = default(string))
        {
            this.PhoneNumber = PhoneNumber;
            this.Formatted = Formatted;
            this.Price = Price;
            this.IsTollFree = IsTollFree;
            this.CountryCode = CountryCode;
            this.Npa = Npa;
            this.Nxx = Nxx;
            this.Xxxx = Xxxx;
            this.City = City;
            this.Province = Province;
            this.Country = Country;
        }
        
        /// <summary>
        /// Phone number, in E.164 format
        /// </summary>
        /// <value>Phone number, in E.164 format</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Human-readable formatted version of the phone number
        /// </summary>
        /// <value>Human-readable formatted version of the phone number</value>
        [DataMember(Name="formatted", EmitDefaultValue=false)]
        public string Formatted { get; set; }
        /// <summary>
        /// The one-time initial price for this number, in USD. Some numbers show REQUEST_QUOTE here. Please contact our sales department if you are interested in these numbers.
        /// </summary>
        /// <value>The one-time initial price for this number, in USD. Some numbers show REQUEST_QUOTE here. Please contact our sales department if you are interested in these numbers.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public int? Price { get; set; }
        /// <summary>
        /// Whether the number is toll-free
        /// </summary>
        /// <value>Whether the number is toll-free</value>
        [DataMember(Name="is_toll_free", EmitDefaultValue=false)]
        public bool? IsTollFree { get; set; }
        /// <summary>
        /// The international dialing prefix for this number. For US and Canadian numbers, for example, this will be \&quot;1\&quot;.
        /// </summary>
        /// <value>The international dialing prefix for this number. For US and Canadian numbers, for example, this will be \&quot;1\&quot;.</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// Area code (a.k.a. NPA). Included for North American numbers only.
        /// </summary>
        /// <value>Area code (a.k.a. NPA). Included for North American numbers only.</value>
        [DataMember(Name="npa", EmitDefaultValue=false)]
        public string Npa { get; set; }
        /// <summary>
        /// Second 3 digits (a.k.a. NXX). Included for North American numbers only.
        /// </summary>
        /// <value>Second 3 digits (a.k.a. NXX). Included for North American numbers only.</value>
        [DataMember(Name="nxx", EmitDefaultValue=false)]
        public string Nxx { get; set; }
        /// <summary>
        /// Last 4 digits (a.k.a. XXXX). Included for North American numbers only.
        /// </summary>
        /// <value>Last 4 digits (a.k.a. XXXX). Included for North American numbers only.</value>
        [DataMember(Name="xxxx", EmitDefaultValue=false)]
        public string Xxxx { get; set; }
        /// <summary>
        /// City with which this number is associated, if known. Otherwise NULL.
        /// </summary>
        /// <value>City with which this number is associated, if known. Otherwise NULL.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// State or Province with which this number is associated, if known. Postal Code. Otherwise NULL.
        /// </summary>
        /// <value>State or Province with which this number is associated, if known. Postal Code. Otherwise NULL.</value>
        [DataMember(Name="province", EmitDefaultValue=false)]
        public string Province { get; set; }
        /// <summary>
        /// Country with which this number is associated, if known. Otherwise NULL.
        /// </summary>
        /// <value>Country with which this number is associated, if known. Otherwise NULL.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableNumbersFull {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Formatted: ").Append(Formatted).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  IsTollFree: ").Append(IsTollFree).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Npa: ").Append(Npa).Append("\n");
            sb.Append("  Nxx: ").Append(Nxx).Append("\n");
            sb.Append("  Xxxx: ").Append(Xxxx).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as AvailableNumbersFull);
        }

        /// <summary>
        /// Returns true if AvailableNumbersFull instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableNumbersFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableNumbersFull other)
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
                    this.Formatted == other.Formatted ||
                    this.Formatted != null &&
                    this.Formatted.Equals(other.Formatted)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.IsTollFree == other.IsTollFree ||
                    this.IsTollFree != null &&
                    this.IsTollFree.Equals(other.IsTollFree)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.Npa == other.Npa ||
                    this.Npa != null &&
                    this.Npa.Equals(other.Npa)
                ) && 
                (
                    this.Nxx == other.Nxx ||
                    this.Nxx != null &&
                    this.Nxx.Equals(other.Nxx)
                ) && 
                (
                    this.Xxxx == other.Xxxx ||
                    this.Xxxx != null &&
                    this.Xxxx.Equals(other.Xxxx)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Province == other.Province ||
                    this.Province != null &&
                    this.Province.Equals(other.Province)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.Formatted != null)
                    hash = hash * 59 + this.Formatted.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.IsTollFree != null)
                    hash = hash * 59 + this.IsTollFree.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.Npa != null)
                    hash = hash * 59 + this.Npa.GetHashCode();
                if (this.Nxx != null)
                    hash = hash * 59 + this.Nxx.GetHashCode();
                if (this.Xxxx != null)
                    hash = hash * 59 + this.Xxxx.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Province != null)
                    hash = hash * 59 + this.Province.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
