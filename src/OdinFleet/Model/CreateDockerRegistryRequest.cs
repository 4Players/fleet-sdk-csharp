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
    /// CreateDockerRegistryRequest
    /// </summary>
    [DataContract(Name = "createDockerRegistry_request")]
    public partial class CreateDockerRegistryRequest : IValidatableObject
    {

        /// <summary>
        /// The type of the docker registry
        /// </summary>
        /// <value>The type of the docker registry</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public DockerRegistryType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDockerRegistryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDockerRegistryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDockerRegistryRequest" /> class.
        /// </summary>
        /// <param name="type">The type of the docker registry (required).</param>
        /// <param name="name">The name of the docker registry (required).</param>
        /// <param name="url">The URL of the docker registry.</param>
        /// <param name="instanceUrl">The URL of the gitlab instance.</param>
        /// <param name="username">The username to use for authentication.</param>
        /// <param name="accessToken">The access token to use for authentication.</param>
        /// <param name="password">The password to use for authentication.</param>
        public CreateDockerRegistryRequest(DockerRegistryType type = default(DockerRegistryType), string name = default(string), string url = default(string), string instanceUrl = default(string), string username = default(string), string accessToken = default(string), string password = default(string))
        {
            this.Type = type;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateDockerRegistryRequest and cannot be null");
            }
            this.Name = name;
            this.Url = url;
            this.InstanceUrl = instanceUrl;
            this.Username = username;
            this.AccessToken = accessToken;
            this.Password = password;
        }

        /// <summary>
        /// The name of the docker registry
        /// </summary>
        /// <value>The name of the docker registry</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The URL of the docker registry
        /// </summary>
        /// <value>The URL of the docker registry</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The URL of the gitlab instance
        /// </summary>
        /// <value>The URL of the gitlab instance</value>
        [DataMember(Name = "instanceUrl", EmitDefaultValue = true)]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// The username to use for authentication
        /// </summary>
        /// <value>The username to use for authentication</value>
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// The access token to use for authentication
        /// </summary>
        /// <value>The access token to use for authentication</value>
        [DataMember(Name = "accessToken", EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The password to use for authentication
        /// </summary>
        /// <value>The password to use for authentication</value>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDockerRegistryRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  InstanceUrl: ").Append(InstanceUrl).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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