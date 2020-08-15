/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.2.12
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Defines TFNExemptionType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TFNExemptionType
    {
        /// <summary>
        /// Enum NOTQUOTED for value: NOTQUOTED
        /// </summary>
        [EnumMember(Value = "NOTQUOTED")]
        NOTQUOTED = 1,

        /// <summary>
        /// Enum PENDING for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING = 2,

        /// <summary>
        /// Enum PENSIONER for value: PENSIONER
        /// </summary>
        [EnumMember(Value = "PENSIONER")]
        PENSIONER = 3,

        /// <summary>
        /// Enum UNDER18 for value: UNDER18
        /// </summary>
        [EnumMember(Value = "UNDER18")]
        UNDER18 = 4

    }

}