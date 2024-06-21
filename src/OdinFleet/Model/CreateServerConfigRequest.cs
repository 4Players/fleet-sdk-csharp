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
    /// CreateServerConfigRequest
    /// </summary>
    [DataContract(Name = "createServerConfig_request")]
    public partial class CreateServerConfigRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServerConfigRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateServerConfigRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServerConfigRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the server configuration (required).</param>
        /// <param name="args">The arguments to pass to the command (overrides CMD of the Dockerfile).</param>
        /// <param name="command">The command to run in the container (overrides ENTRYPOINT of the Dockerfile).</param>
        /// <param name="notes">The notes of the server config - to keep track of things and to inform colleagues.</param>
        /// <param name="binaryId">The binary id of the server configuration (required).</param>
        /// <param name="configFiles">The config files used in this server configuration.</param>
        /// <param name="resources">The resources used in this server configuration.</param>
        /// <param name="restartPolicy">The restart policy of the server configuration.</param>
        /// <param name="env">The environment variables used in this server configuration.</param>
        /// <param name="mounts">The mounts used in this server configuration.</param>
        /// <param name="ports">The port definitions.</param>
        public CreateServerConfigRequest(string name = default(string), string args = default(string), string command = default(string), string notes = default(string), int binaryId = default(int), List<ConfigFile> configFiles = default(List<ConfigFile>), ResourceAllocations resources = default(ResourceAllocations), RestartPolicy restartPolicy = default(RestartPolicy), List<EnvironmentVariableDefinition> env = default(List<EnvironmentVariableDefinition>), List<Mount> mounts = default(List<Mount>), List<PortDefinition> ports = default(List<PortDefinition>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateServerConfigRequest and cannot be null");
            }
            this.Name = name;
            this.BinaryId = binaryId;
            this.Args = args;
            this.Command = command;
            this.Notes = notes;
            this.ConfigFiles = configFiles;
            this.Resources = resources;
            this.RestartPolicy = restartPolicy;
            this.Env = env;
            this.Mounts = mounts;
            this.Ports = ports;
        }

        /// <summary>
        /// The name of the server configuration
        /// </summary>
        /// <value>The name of the server configuration</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The arguments to pass to the command (overrides CMD of the Dockerfile)
        /// </summary>
        /// <value>The arguments to pass to the command (overrides CMD of the Dockerfile)</value>
        /// <example>/usr/local/etc/enshrouded/bootstrap</example>
        [DataMember(Name = "args", EmitDefaultValue = true)]
        public string Args { get; set; }

        /// <summary>
        /// The command to run in the container (overrides ENTRYPOINT of the Dockerfile)
        /// </summary>
        /// <value>The command to run in the container (overrides ENTRYPOINT of the Dockerfile)</value>
        [DataMember(Name = "command", EmitDefaultValue = true)]
        public string Command { get; set; }

        /// <summary>
        /// The notes of the server config - to keep track of things and to inform colleagues
        /// </summary>
        /// <value>The notes of the server config - to keep track of things and to inform colleagues</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// The binary id of the server configuration
        /// </summary>
        /// <value>The binary id of the server configuration</value>
        [DataMember(Name = "binaryId", IsRequired = true, EmitDefaultValue = true)]
        public int BinaryId { get; set; }

        /// <summary>
        /// The config files used in this server configuration
        /// </summary>
        /// <value>The config files used in this server configuration</value>
        [DataMember(Name = "configFiles", EmitDefaultValue = false)]
        public List<ConfigFile> ConfigFiles { get; set; }

        /// <summary>
        /// The resources used in this server configuration
        /// </summary>
        /// <value>The resources used in this server configuration</value>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        public ResourceAllocations Resources { get; set; }

        /// <summary>
        /// The restart policy of the server configuration
        /// </summary>
        /// <value>The restart policy of the server configuration</value>
        [DataMember(Name = "restartPolicy", EmitDefaultValue = false)]
        public RestartPolicy RestartPolicy { get; set; }

        /// <summary>
        /// The environment variables used in this server configuration
        /// </summary>
        /// <value>The environment variables used in this server configuration</value>
        [DataMember(Name = "env", EmitDefaultValue = false)]
        public List<EnvironmentVariableDefinition> Env { get; set; }

        /// <summary>
        /// The mounts used in this server configuration
        /// </summary>
        /// <value>The mounts used in this server configuration</value>
        [DataMember(Name = "mounts", EmitDefaultValue = false)]
        public List<Mount> Mounts { get; set; }

        /// <summary>
        /// The port definitions
        /// </summary>
        /// <value>The port definitions</value>
        [DataMember(Name = "ports", EmitDefaultValue = false)]
        public List<PortDefinition> Ports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateServerConfigRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  BinaryId: ").Append(BinaryId).Append("\n");
            sb.Append("  ConfigFiles: ").Append(ConfigFiles).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  RestartPolicy: ").Append(RestartPolicy).Append("\n");
            sb.Append("  Env: ").Append(Env).Append("\n");
            sb.Append("  Mounts: ").Append(Mounts).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
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
