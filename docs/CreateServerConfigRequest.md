# OdinFleet.Model.CreateServerConfigRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the server configuration | 
**Args** | **string** | The arguments to pass to the command (overrides CMD of the Dockerfile) | [optional] 
**Command** | **string** | The command to run in the container (overrides ENTRYPOINT of the Dockerfile) | [optional] 
**Notes** | **string** | The notes of the server config - to keep track of things and to inform colleagues | [optional] 
**BinaryId** | **int** | The binary id of the server configuration | 
**ConfigFiles** | [**List&lt;ConfigFile&gt;**](ConfigFile.md) | The config files used in this server configuration | [optional] 
**Resources** | [**ResourceAllocations**](ResourceAllocations.md) | The resources used in this server configuration | [optional] 
**RestartPolicy** | [**RestartPolicy**](RestartPolicy.md) | The restart policy of the server configuration | [optional] 
**Env** | [**List&lt;EnvironmentVariableDefinition&gt;**](EnvironmentVariableDefinition.md) | The environment variables used in this server configuration | [optional] 
**Mounts** | [**List&lt;Mount&gt;**](Mount.md) | The mounts used in this server configuration | [optional] 
**Ports** | [**List&lt;PortDefinition&gt;**](PortDefinition.md) | The port definitions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

