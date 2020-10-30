/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.4.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Phone
    /// </summary>
    [DataContract]
    public partial class Phone :  IEquatable<Phone>, IValidatableObject
    {
        /// <summary>
        /// Defines PhoneType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhoneTypeEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            [EnumMember(Value = "DEFAULT")]
            DEFAULT = 1,

            /// <summary>
            /// Enum DDI for value: DDI
            /// </summary>
            [EnumMember(Value = "DDI")]
            DDI = 2,

            /// <summary>
            /// Enum MOBILE for value: MOBILE
            /// </summary>
            [EnumMember(Value = "MOBILE")]
            MOBILE = 3,

            /// <summary>
            /// Enum FAX for value: FAX
            /// </summary>
            [EnumMember(Value = "FAX")]
            FAX = 4,

            /// <summary>
            /// Enum OFFICE for value: OFFICE
            /// </summary>
            [EnumMember(Value = "OFFICE")]
            OFFICE = 5

        }

        /// <summary>
        /// Gets or Sets PhoneType
        /// </summary>
        [DataMember(Name="PhoneType", EmitDefaultValue=false)]
        public PhoneTypeEnum PhoneType { get; set; }
        
        /// <summary>
        /// max length &#x3D; 50
        /// </summary>
        /// <value>max length &#x3D; 50</value>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// max length &#x3D; 10
        /// </summary>
        /// <value>max length &#x3D; 10</value>
        [DataMember(Name="PhoneAreaCode", EmitDefaultValue=false)]
        public string PhoneAreaCode { get; set; }

        /// <summary>
        /// max length &#x3D; 20
        /// </summary>
        /// <value>max length &#x3D; 20</value>
        [DataMember(Name="PhoneCountryCode", EmitDefaultValue=false)]
        public string PhoneCountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Phone {\n");
            sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneAreaCode: ").Append(PhoneAreaCode).Append("\n");
            sb.Append("  PhoneCountryCode: ").Append(PhoneCountryCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Phone);
        }

        /// <summary>
        /// Returns true if Phone instances are equal
        /// </summary>
        /// <param name="input">Instance of Phone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Phone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneType == input.PhoneType ||
                    this.PhoneType.Equals(input.PhoneType)
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PhoneAreaCode == input.PhoneAreaCode ||
                    (this.PhoneAreaCode != null &&
                    this.PhoneAreaCode.Equals(input.PhoneAreaCode))
                ) && 
                (
                    this.PhoneCountryCode == input.PhoneCountryCode ||
                    (this.PhoneCountryCode != null &&
                    this.PhoneCountryCode.Equals(input.PhoneCountryCode))
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
                hashCode = hashCode * 59 + this.PhoneType.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PhoneAreaCode != null)
                    hashCode = hashCode * 59 + this.PhoneAreaCode.GetHashCode();
                if (this.PhoneCountryCode != null)
                    hashCode = hashCode * 59 + this.PhoneCountryCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // PhoneNumber (string) maxLength
            if(this.PhoneNumber != null && this.PhoneNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, length must be less than 50.", new [] { "PhoneNumber" });
            }

            // PhoneAreaCode (string) maxLength
            if(this.PhoneAreaCode != null && this.PhoneAreaCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneAreaCode, length must be less than 10.", new [] { "PhoneAreaCode" });
            }

            // PhoneCountryCode (string) maxLength
            if(this.PhoneCountryCode != null && this.PhoneCountryCode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneCountryCode, length must be less than 20.", new [] { "PhoneCountryCode" });
            }

            yield break;
        }
    }

}
