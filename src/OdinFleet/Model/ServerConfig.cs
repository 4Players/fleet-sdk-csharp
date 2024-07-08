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
    /// ServerConfig
    /// </summary>
    [DataContract(Name = "ServerConfig")]
    public partial class ServerConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServerConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerConfig" /> class.
        /// </summary>
        /// <param name="id">The id of the server configuration (required).</param>
        /// <param name="binaryId">The binary id of the server configuration (required).</param>
        /// <param name="appId">The app id of the server configuration (required).</param>
        /// <param name="name">The name of the server config (required).</param>
        /// <param name="command">The command to run in the container (overrides ENTRYPOINT of the Dockerfile) (required).</param>
        /// <param name="args">The arguments to pass to the command (overrides CMD of the Dockerfile) (required).</param>
        /// <param name="notes">The notes of the server config - to keep track of things and to inform colleagues (required).</param>
        /// <param name="restartPolicy">The policy used to restart this server (required).</param>
        /// <param name="resources">The resources to be used in this config (required).</param>
        /// <param name="env">The environment variable definitions to be used in this config (required).</param>
        /// <param name="mounts">The mounts to use (required).</param>
        /// <param name="ports">The ports to expose (required).</param>
        /// <param name="configFiles">The config files to use (required).</param>
        /// <param name="secretFiles">The secret files to use (required).</param>
        /// <param name="binary">The image that is used in this server config.</param>
        public ServerConfig(int id = default(int), int binaryId = default(int), int appId = default(int), string name = default(string), string command = default(string), string args = default(string), string notes = default(string), RestartPolicy restartPolicy = default(RestartPolicy), ResourceAllocations resources = default(ResourceAllocations), List<EnvironmentVariableDefinition> env = default(List<EnvironmentVariableDefinition>), List<Mount> mounts = default(List<Mount>), List<PortDefinition> ports = default(List<PortDefinition>), List<ConfigFile> configFiles = default(List<ConfigFile>), List<SecretFile> secretFiles = default(List<SecretFile>), Binary binary = default(Binary))
        {
            this.Id = id;
            this.BinaryId = binaryId;
            this.AppId = appId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ServerConfig and cannot be null");
            }
            this.Name = name;
            // to ensure "command" is required (not null)
            if (command == null)
            {
                throw new ArgumentNullException("command is a required property for ServerConfig and cannot be null");
            }
            this.Command = command;
            // to ensure "args" is required (not null)
            if (args == null)
            {
                throw new ArgumentNullException("args is a required property for ServerConfig and cannot be null");
            }
            this.Args = args;
            // to ensure "notes" is required (not null)
            if (notes == null)
            {
                throw new ArgumentNullException("notes is a required property for ServerConfig and cannot be null");
            }
            this.Notes = notes;
            // to ensure "restartPolicy" is required (not null)
            if (restartPolicy == null)
            {
                throw new ArgumentNullException("restartPolicy is a required property for ServerConfig and cannot be null");
            }
            this.RestartPolicy = restartPolicy;
            // to ensure "resources" is required (not null)
            if (resources == null)
            {
                throw new ArgumentNullException("resources is a required property for ServerConfig and cannot be null");
            }
            this.Resources = resources;
            // to ensure "env" is required (not null)
            if (env == null)
            {
                throw new ArgumentNullException("env is a required property for ServerConfig and cannot be null");
            }
            this.Env = env;
            // to ensure "mounts" is required (not null)
            if (mounts == null)
            {
                throw new ArgumentNullException("mounts is a required property for ServerConfig and cannot be null");
            }
            this.Mounts = mounts;
            // to ensure "ports" is required (not null)
            if (ports == null)
            {
                throw new ArgumentNullException("ports is a required property for ServerConfig and cannot be null");
            }
            this.Ports = ports;
            // to ensure "configFiles" is required (not null)
            if (configFiles == null)
            {
                throw new ArgumentNullException("configFiles is a required property for ServerConfig and cannot be null");
            }
            this.ConfigFiles = configFiles;
            // to ensure "secretFiles" is required (not null)
            if (secretFiles == null)
            {
                throw new ArgumentNullException("secretFiles is a required property for ServerConfig and cannot be null");
            }
            this.SecretFiles = secretFiles;
            this.Binary = binary;
        }

        /// <summary>
        /// The id of the server configuration
        /// </summary>
        /// <value>The id of the server configuration</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The binary id of the server configuration
        /// </summary>
        /// <value>The binary id of the server configuration</value>
        [DataMember(Name = "binaryId", IsRequired = true, EmitDefaultValue = true)]
        public int BinaryId { get; set; }

        /// <summary>
        /// The app id of the server configuration
        /// </summary>
        /// <value>The app id of the server configuration</value>
        [DataMember(Name = "appId", IsRequired = true, EmitDefaultValue = true)]
        public int AppId { get; set; }

        /// <summary>
        /// The name of the server config
        /// </summary>
        /// <value>The name of the server config</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The command to run in the container (overrides ENTRYPOINT of the Dockerfile)
        /// </summary>
        /// <value>The command to run in the container (overrides ENTRYPOINT of the Dockerfile)</value>
        [DataMember(Name = "command", IsRequired = true, EmitDefaultValue = true)]
        public string Command { get; set; }

        /// <summary>
        /// The arguments to pass to the command (overrides CMD of the Dockerfile)
        /// </summary>
        /// <value>The arguments to pass to the command (overrides CMD of the Dockerfile)</value>
        [DataMember(Name = "args", IsRequired = true, EmitDefaultValue = true)]
        public string Args { get; set; }

        /// <summary>
        /// The notes of the server config - to keep track of things and to inform colleagues
        /// </summary>
        /// <value>The notes of the server config - to keep track of things and to inform colleagues</value>
        [DataMember(Name = "notes", IsRequired = true, EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// The policy used to restart this server
        /// </summary>
        /// <value>The policy used to restart this server</value>
        [DataMember(Name = "restartPolicy", IsRequired = true, EmitDefaultValue = true)]
        public RestartPolicy RestartPolicy { get; set; }

        /// <summary>
        /// The resources to be used in this config
        /// </summary>
        /// <value>The resources to be used in this config</value>
        [DataMember(Name = "resources", IsRequired = true, EmitDefaultValue = true)]
        public ResourceAllocations Resources { get; set; }

        /// <summary>
        /// The environment variable definitions to be used in this config
        /// </summary>
        /// <value>The environment variable definitions to be used in this config</value>
        [DataMember(Name = "env", IsRequired = true, EmitDefaultValue = true)]
        public List<EnvironmentVariableDefinition> Env { get; set; }

        /// <summary>
        /// The mounts to use
        /// </summary>
        /// <value>The mounts to use</value>
        [DataMember(Name = "mounts", IsRequired = true, EmitDefaultValue = true)]
        public List<Mount> Mounts { get; set; }

        /// <summary>
        /// The ports to expose
        /// </summary>
        /// <value>The ports to expose</value>
        [DataMember(Name = "ports", IsRequired = true, EmitDefaultValue = true)]
        public List<PortDefinition> Ports { get; set; }

        /// <summary>
        /// The config files to use
        /// </summary>
        /// <value>The config files to use</value>
        [DataMember(Name = "configFiles", IsRequired = true, EmitDefaultValue = true)]
        public List<ConfigFile> ConfigFiles { get; set; }

        /// <summary>
        /// The secret files to use
        /// </summary>
        /// <value>The secret files to use</value>
        [DataMember(Name = "secretFiles", IsRequired = true, EmitDefaultValue = true)]
        public List<SecretFile> SecretFiles { get; set; }

        /// <summary>
        /// The image that is used in this server config
        /// </summary>
        /// <value>The image that is used in this server config</value>
        [DataMember(Name = "binary", EmitDefaultValue = false)]
        public Binary Binary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServerConfig {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BinaryId: ").Append(BinaryId).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  RestartPolicy: ").Append(RestartPolicy).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  Env: ").Append(Env).Append("\n");
            sb.Append("  Mounts: ").Append(Mounts).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
            sb.Append("  ConfigFiles: ").Append(ConfigFiles).Append("\n");
            sb.Append("  SecretFiles: ").Append(SecretFiles).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
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
