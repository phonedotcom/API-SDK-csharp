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
    /// FilterListAvailableNumbers
    /// </summary>
    [DataContract]
    public partial class FilterListAvailableNumbers :  IEquatable<FilterListAvailableNumbers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterListAvailableNumbers" /> class.
        /// </summary>
        /// <param name="PhoneNumber">PhoneNumber.</param>
        /// <param name="CountryCode">CountryCode.</param>
        /// <param name="Npa">Npa.</param>
        /// <param name="Nxx">Nxx.</param>
        /// <param name="Xxxx">Xxxx.</param>
        /// <param name="City">City.</param>
        /// <param name="Province">Province.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Price">Price.</param>
        /// <param name="Category">Category.</param>
        public FilterListAvailableNumbers(string PhoneNumber = default(string), string CountryCode = default(string), string Npa = default(string), string Nxx = default(string), string Xxxx = default(string), string City = default(string), string Province = default(string), string Country = default(string), string Price = default(string), string Category = default(string))
        {
            this.PhoneNumber = PhoneNumber;
            this.CountryCode = CountryCode;
            this.Npa = Npa;
            this.Nxx = Nxx;
            this.Xxxx = Xxxx;
            this.City = City;
            this.Province = Province;
            this.Country = Country;
            this.Price = Price;
            this.Category = Category;
        }
        
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Npa
        /// </summary>
        [DataMember(Name="npa", EmitDefaultValue=false)]
        public string Npa { get; set; }

        /// <summary>
        /// Gets or Sets Nxx
        /// </summary>
        [DataMember(Name="nxx", EmitDefaultValue=false)]
        public string Nxx { get; set; }

        /// <summary>
        /// Gets or Sets Xxxx
        /// </summary>
        [DataMember(Name="xxxx", EmitDefaultValue=false)]
        public string Xxxx { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=false)]
        public string Province { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterListAvailableNumbers {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Npa: ").Append(Npa).Append("\n");
            sb.Append("  Nxx: ").Append(Nxx).Append("\n");
            sb.Append("  Xxxx: ").Append(Xxxx).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as FilterListAvailableNumbers);
        }

        /// <summary>
        /// Returns true if FilterListAvailableNumbers instances are equal
        /// </summary>
        /// <param name="other">Instance of FilterListAvailableNumbers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterListAvailableNumbers other)
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
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
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
