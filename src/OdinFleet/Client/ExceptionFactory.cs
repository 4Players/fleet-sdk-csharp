/*
 * ODIN Fleet API
 *
 * API to access Odin Fleet, empowering developers to deploy gameservers all around the world in just a few lines of code.
 *
 * The version of the OpenAPI document: 0.8.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;

namespace OdinFleet.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IApiResponse response);
}
