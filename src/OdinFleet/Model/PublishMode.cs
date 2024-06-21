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
    /// Defines PublishMode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublishMode
    {
        /// <summary>
        /// Enum Host for value: host
        /// </summary>
        [EnumMember(Value = "host")]
        Host = 1,

        /// <summary>
        /// Enum Ingress for value: ingress
        /// </summary>
        [EnumMember(Value = "ingress")]
        Ingress = 2
    }

}
