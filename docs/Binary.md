# OdinFleet.Model.Binary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The id of the binary | 
**AppId** | **int** | The app id of the binary | 
**Name** | **string** | The app id of the binary | 
**VarVersion** | **string** | The version of the binary | 
**Type** | **BinaryType** | The type of the binary | 
**Os** | **ModelOperatingSystem** | The operating system of the binary | 
**Ready** | **bool** | Indicates whether the binary is ready for use. | 
**ConfigTemplates** | [**List&lt;ConfigTemplate&gt;**](ConfigTemplate.md) | The config templates of the binary | [optional] 
**DockerImage** | [**DockerImage**](DockerImage.md) | The docker image of the binary | [optional] 
**DockerCompose** | [**DockerCompose**](DockerCompose.md) | The docker compose file of the binary | [optional] 
**ZipFile** | [**ZipFile**](ZipFile.md) | The ZIP file of the binary | [optional] 
**Steam** | [**Steam**](Steam.md) | The steam of the binary | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

