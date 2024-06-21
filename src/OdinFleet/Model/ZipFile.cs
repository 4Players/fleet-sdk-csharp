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
    /// ZipFile
    /// </summary>
    [DataContract(Name = "ZipFile")]
    public partial class ZipFile : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipFile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ZipFile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZipFile" /> class.
        /// </summary>
        /// <param name="zipFileUrl">The URL to the ZIP file (required).</param>
        /// <param name="commandLine">The command line to use (required).</param>
        public ZipFile(string zipFileUrl = default(string), string commandLine = default(string))
        {
            // to ensure "zipFileUrl" is required (not null)
            if (zipFileUrl == null)
            {
                throw new ArgumentNullException("zipFileUrl is a required property for ZipFile and cannot be null");
            }
            this.ZipFileUrl = zipFileUrl;
            // to ensure "commandLine" is required (not null)
            if (commandLine == null)
            {
                throw new ArgumentNullException("commandLine is a required property for ZipFile and cannot be null");
            }
            this.CommandLine = commandLine;
        }

        /// <summary>
        /// The URL to the ZIP file
        /// </summary>
        /// <value>The URL to the ZIP file</value>
        [DataMember(Name = "zipFileUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ZipFileUrl { get; set; }

        /// <summary>
        /// The command line to use
        /// </summary>
        /// <value>The command line to use</value>
        [DataMember(Name = "commandLine", IsRequired = true, EmitDefaultValue = true)]
        public string CommandLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZipFile {\n");
            sb.Append("  ZipFileUrl: ").Append(ZipFileUrl).Append("\n");
            sb.Append("  CommandLine: ").Append(CommandLine).Append("\n");
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
