/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.7.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollNz;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;
using RestSharp;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollNz
{
    /// <summary>
    ///  Class for testing CalendarType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CalendarTypeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CalendarType
        //private CalendarType instance;

        public CalendarTypeTests()
        {
            // TODO uncomment below to create an instance of CalendarType
            //instance = new CalendarType();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CalendarType
        /// </summary>
        [Theory]
        [InlineData("Annual", CalendarType.Annual)]
        [InlineData("Fortnightly", CalendarType.Fortnightly)]
        [InlineData("FourWeekly", CalendarType.FourWeekly)]
        [InlineData("Monthly", CalendarType.Monthly)]
        [InlineData("Quarterly", CalendarType.Quarterly)]
        [InlineData("TwiceMonthly", CalendarType.TwiceMonthly)]
        [InlineData("Weekly", CalendarType.Weekly)]
        public void CalendarType_ValidInput_Deserialises(string input, CalendarType expected)
        {
            var response = new RestResponse();
            response.Content = $@"""{input}""";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<CalendarType>(response);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalendarType_NullInput_Deserialises(){
            var response = new RestResponse();
            response.Content = "null";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<CalendarType>(response);

            Assert.Equal(0, (int)actual);
        }

    }

}