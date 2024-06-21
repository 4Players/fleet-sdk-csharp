/*
 * ODIN Fleet API
 *
 * API to access Odin Fleet, empowering developers to deploy gameservers all around the world in just a few lines of code.
 *
 * The version of the OpenAPI document: 0.8.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = OdinFleet.Client.FileParameter;
using OpenAPIDateConverter = OdinFleet.Client.OpenAPIDateConverter;

namespace OdinFleet.Model
{
    /// <summary>
    /// Constraints
    /// </summary>
    [DataContract(Name = "Constraints")]
    public partial class Constraints : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Constraints" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Constraints() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Constraints" /> class.
        /// </summary>
        /// <param name="country">The country where the server should be placed - it defines a region as a fallback if no free resources are available in the city (required).</param>
        /// <param name="city">The city where the server should be placed (required).</param>
        public Constraints(string country = default(string), string city = default(string))
        {
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for Constraints and cannot be null");
            }
            this.Country = country;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for Constraints and cannot be null");
            }
            this.City = city;
        }

        /// <summary>
        /// The country where the server should be placed - it defines a region as a fallback if no free resources are available in the city
        /// </summary>
        /// <value>The country where the server should be placed - it defines a region as a fallback if no free resources are available in the city</value>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// The city where the server should be placed
        /// </summary>
        /// <value>The city where the server should be placed</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Constraints {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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