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
    /// Port
    /// </summary>
    [DataContract(Name = "Port")]
    public partial class Port : IValidatableObject
    {

        /// <summary>
        /// The exposed protocol
        /// </summary>
        /// <value>The exposed protocol</value>
        [DataMember(Name = "protocol", IsRequired = true, EmitDefaultValue = true)]
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Defines whether the port uses the hosts network or the ingress network
        /// </summary>
        /// <value>Defines whether the port uses the hosts network or the ingress network</value>
        [DataMember(Name = "publishMode", IsRequired = true, EmitDefaultValue = true)]
        public PublishMode PublishMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Port" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Port() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Port" /> class.
        /// </summary>
        /// <param name="name">The name of the port (required).</param>
        /// <param name="protocol">The exposed protocol (required).</param>
        /// <param name="targetPort">The port to expose (required).</param>
        /// <param name="publishedPort">Published Port Where the port is mapped to (required).</param>
        /// <param name="publishMode">Defines whether the port uses the hosts network or the ingress network (required).</param>
        public Port(string name = default(string), Protocol protocol = default(Protocol), int targetPort = default(int), int publishedPort = default(int), PublishMode publishMode = default(PublishMode))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Port and cannot be null");
            }
            this.Name = name;
            this.Protocol = protocol;
            this.TargetPort = targetPort;
            this.PublishedPort = publishedPort;
            this.PublishMode = publishMode;
        }

        /// <summary>
        /// The name of the port
        /// </summary>
        /// <value>The name of the port</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The port to expose
        /// </summary>
        /// <value>The port to expose</value>
        [DataMember(Name = "targetPort", IsRequired = true, EmitDefaultValue = true)]
        public int TargetPort { get; set; }

        /// <summary>
        /// Published Port Where the port is mapped to
        /// </summary>
        /// <value>Published Port Where the port is mapped to</value>
        [DataMember(Name = "publishedPort", IsRequired = true, EmitDefaultValue = true)]
        public int PublishedPort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Port {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  TargetPort: ").Append(TargetPort).Append("\n");
            sb.Append("  PublishedPort: ").Append(PublishedPort).Append("\n");
            sb.Append("  PublishMode: ").Append(PublishMode).Append("\n");
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
