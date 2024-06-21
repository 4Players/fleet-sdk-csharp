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
    /// EnvironmentVariableDefinition
    /// </summary>
    [DataContract(Name = "EnvironmentVariableDefinition")]
    public partial class EnvironmentVariableDefinition : IValidatableObject
    {

        /// <summary>
        /// The type of the environment variable
        /// </summary>
        /// <value>The type of the environment variable</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public EnvironmentVariableType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariableDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnvironmentVariableDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariableDefinition" /> class.
        /// </summary>
        /// <param name="type">The type of the environment variable (required).</param>
        /// <param name="key">The key of the variable (required).</param>
        /// <param name="value">The value of the variable.</param>
        /// <param name="variable">The variable definition of the environment variable.</param>
        public EnvironmentVariableDefinition(EnvironmentVariableType type = default(EnvironmentVariableType), string key = default(string), string value = default(string), string variable = default(string))
        {
            this.Type = type;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for EnvironmentVariableDefinition and cannot be null");
            }
            this.Key = key;
            this.Value = value;
            this.Variable = variable;
        }

        /// <summary>
        /// The key of the variable
        /// </summary>
        /// <value>The key of the variable</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The value of the variable
        /// </summary>
        /// <value>The value of the variable</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// The variable definition of the environment variable
        /// </summary>
        /// <value>The variable definition of the environment variable</value>
        [DataMember(Name = "variable", EmitDefaultValue = false)]
        public string Variable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnvironmentVariableDefinition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
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
