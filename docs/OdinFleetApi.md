# OdinFleet.Api.OdinFleetApi

All URIs are relative to *https://fleet.4players.io/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApp**](OdinFleetApi.md#createapp) | **POST** /v1/apps | Create an app |
| [**CreateAppLocationSetting**](OdinFleetApi.md#createapplocationsetting) | **POST** /v1/apps/{app}/location-settings | Create a new location setting |
| [**CreateBackup**](OdinFleetApi.md#createbackup) | **POST** /v1/services/{service}/backup | Creates a backup of the service |
| [**CreateBinary**](OdinFleetApi.md#createbinary) | **POST** /v1/apps/{app}/binaries | Create a binary and the related file |
| [**CreateDockerRegistry**](OdinFleetApi.md#createdockerregistry) | **POST** /v1/docker-registries | Create a new docker registry |
| [**CreateServerConfig**](OdinFleetApi.md#createserverconfig) | **POST** /v1/apps/{app}/configs | Create a new server config |
| [**DeleteApp**](OdinFleetApi.md#deleteapp) | **DELETE** /v1/apps/{app} | Delete a specific app |
| [**DeleteAppLocationSetting**](OdinFleetApi.md#deleteapplocationsetting) | **DELETE** /v1/app-location-settings/{appLocationSetting} | Delete a location setting |
| [**DeleteAuthToken**](OdinFleetApi.md#deleteauthtoken) | **DELETE** /v1/auth/token | Handles the deletion of a user&#39;s authentication tokens |
| [**DeleteBinary**](OdinFleetApi.md#deletebinary) | **DELETE** /v1/binaries/{binary} | Delete a specified binary |
| [**DeleteDockerRegistry**](OdinFleetApi.md#deletedockerregistry) | **DELETE** /v1/docker-registries/{dockerRegistry} | Delete a specific docker registry |
| [**DeleteServerConfig**](OdinFleetApi.md#deleteserverconfig) | **DELETE** /v1/server-configs/{serverConfig} | Delete a specific server config |
| [**GetAppById**](OdinFleetApi.md#getappbyid) | **GET** /v1/apps/{app} | Show a specific app |
| [**GetAppLocationSettings**](OdinFleetApi.md#getapplocationsettings) | **GET** /v1/apps/{app}/location-settings | Show all location settings |
| [**GetApps**](OdinFleetApi.md#getapps) | **GET** /v1/apps | Show all apps |
| [**GetAuthToken**](OdinFleetApi.md#getauthtoken) | **POST** /v1/auth/token | Handles user authentication |
| [**GetBackups**](OdinFleetApi.md#getbackups) | **GET** /v1/services/{service}/backups | List all backups for the specified Docker service |
| [**GetBinaries**](OdinFleetApi.md#getbinaries) | **GET** /v1/apps/{app}/binaries | Show all binaries |
| [**GetBinaryById**](OdinFleetApi.md#getbinarybyid) | **GET** /v1/binaries/{binary} | Show a specific binary |
| [**GetDockerRegistries**](OdinFleetApi.md#getdockerregistries) | **GET** /v1/docker-registries | Show all docker registries |
| [**GetDockerRegistryById**](OdinFleetApi.md#getdockerregistrybyid) | **GET** /v1/docker-registries/{dockerRegistry} | Display a specific docker registry |
| [**GetLocations**](OdinFleetApi.md#getlocations) | **GET** /v1/nodes/locations | Show a unique listing of locations based on active and ready worker nodes |
| [**GetMostRecentBackup**](OdinFleetApi.md#getmostrecentbackup) | **GET** /v1/services/{service}/backup | Display the most recent backup for the specified Docker service |
| [**GetServerBackupDownloadUrl**](OdinFleetApi.md#getserverbackupdownloadurl) | **GET** /v1/services/{service}/backup/download | Generates a presigned URL for downloading a backup from AWS S3 if the backup method is &#39;archive&#39; |
| [**GetServerById**](OdinFleetApi.md#getserverbyid) | **GET** /v1/apps/{app}/services/{service} | Display a specific DockerService associated with the given App |
| [**GetServerConfigById**](OdinFleetApi.md#getserverconfigbyid) | **GET** /v1/server-configs/{serverConfig} | Show a specific server config |
| [**GetServerConfigs**](OdinFleetApi.md#getserverconfigs) | **GET** /v1/apps/{app}/configs | Show all server configs |
| [**GetServerLogs**](OdinFleetApi.md#getserverlogs) | **GET** /v1/services/{service}/logs | Get stdout and stderr logs from a service or task |
| [**GetServers**](OdinFleetApi.md#getservers) | **GET** /v1/apps/{app}/services | Show all services for a given app |
| [**RestartServer**](OdinFleetApi.md#restartserver) | **POST** /v1/services/{service}/restart | Restarts a specific Docker service |
| [**RestoreBackup**](OdinFleetApi.md#restorebackup) | **POST** /v1/services/{service}/restore | Restore a backup for a specified Docker service |
| [**UpdateAppLocationSetting**](OdinFleetApi.md#updateapplocationsetting) | **PUT** /v1/app-location-settings/{appLocationSetting} | Update a location setting |
| [**UpdateBinary**](OdinFleetApi.md#updatebinary) | **PUT** /v1/binaries/{binary} | Update a binary and the related file |
| [**UpdateDockerRegistry**](OdinFleetApi.md#updatedockerregistry) | **PUT** /v1/docker-registries/{dockerRegistry} | Update a specific docker registry |
| [**UpdateServerConfig**](OdinFleetApi.md#updateserverconfig) | **PUT** /v1/server-configs/{serverConfig} | Update a server config |

<a id="createapp"></a>
# **CreateApp**
> App CreateApp (CreateAppRequest createAppRequest = null)

Create an app

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class CreateAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var createAppRequest = new CreateAppRequest(); // CreateAppRequest |  (optional) 

            try
            {
                // Create an app
                App result = apiInstance.CreateApp(createAppRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.CreateApp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAppWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an app
    ApiResponse<App> response = apiInstance.CreateAppWithHttpInfo(createAppRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.CreateAppWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createAppRequest** | [**CreateAppRequest**](CreateAppRequest.md) |  | [optional]  |

### Return type

[**App**](App.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;App&#x60; |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createapplocationsetting"></a>
# **CreateAppLocationSetting**
> AppLocationSetting CreateAppLocationSetting (int app, CreateAppLocationSettingRequest createAppLocationSettingRequest = null)

Create a new location setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class CreateAppLocationSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | The app ID
            var createAppLocationSettingRequest = new CreateAppLocationSettingRequest(); // CreateAppLocationSettingRequest |  (optional) 

            try
            {
                // Create a new location setting
                AppLocationSetting result = apiInstance.CreateAppLocationSetting(app, createAppLocationSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.CreateAppLocationSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAppLocationSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new location setting
    ApiResponse<AppLocationSetting> response = apiInstance.CreateAppLocationSettingWithHttpInfo(app, createAppLocationSettingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.CreateAppLocationSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | The app ID |  |
| **createAppLocationSettingRequest** | [**CreateAppLocationSettingRequest**](CreateAppLocationSettingRequest.md) |  | [optional]  |

### Return type

[**AppLocationSetting**](AppLocationSetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;AppLocationSetting&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbackup"></a>
# **CreateBackup**
> Object CreateBackup (int service, CreateBackupRequest createBackupRequest = null)

Creates a backup of the service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class CreateBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var service = 56;  // int | The service ID
            var createBackupRequest = new CreateBackupRequest(); // CreateBackupRequest |  (optional) 

            try
            {
                // Creates a backup of the service
                Object result = apiInstance.CreateBackup(service, createBackupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.CreateBackup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBackupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a backup of the service
    ApiResponse<Object> response = apiInstance.CreateBackupWithHttpInfo(service, createBackupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.CreateBackupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **int** | The service ID |  |
| **createBackupRequest** | [**CreateBackupRequest**](CreateBackupRequest.md) |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbinary"></a>
# **CreateBinary**
> Binary CreateBinary (int app, CreateBinaryRequest createBinaryRequest = null)

Create a binary and the related file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class CreateBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | The app ID
            var createBinaryRequest = new CreateBinaryRequest(); // CreateBinaryRequest |  (optional) 

            try
            {
                // Create a binary and the related file
                Binary result = apiInstance.CreateBinary(app, createBinaryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.CreateBinary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBinaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a binary and the related file
    ApiResponse<Binary> response = apiInstance.CreateBinaryWithHttpInfo(app, createBinaryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.CreateBinaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | The app ID |  |
| **createBinaryRequest** | [**CreateBinaryRequest**](CreateBinaryRequest.md) |  | [optional]  |

### Return type

[**Binary**](Binary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;Binary&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createdockerregistry"></a>
# **CreateDockerRegistry**
> DockerRegistry CreateDockerRegistry (CreateDockerRegistryRequest createDockerRegistryRequest = null)

Create a new docker registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class CreateDockerRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var createDockerRegistryRequest = new CreateDockerRegistryRequest(); // CreateDockerRegistryRequest |  (optional) 

            try
            {
                // Create a new docker registry
                DockerRegistry result = apiInstance.CreateDockerRegistry(createDockerRegistryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.CreateDockerRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDockerRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new docker registry
    ApiResponse<DockerRegistry> response = apiInstance.CreateDockerRegistryWithHttpInfo(createDockerRegistryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.CreateDockerRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDockerRegistryRequest** | [**CreateDockerRegistryRequest**](CreateDockerRegistryRequest.md) |  | [optional]  |

### Return type

[**DockerRegistry**](DockerRegistry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;DockerRegistry&#x60; |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createserverconfig"></a>
# **CreateServerConfig**
> ServerConfig CreateServerConfig (int app, CreateServerConfigRequest createServerConfigRequest = null)

Create a new server config

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class CreateServerConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | The app ID
            var createServerConfigRequest = new CreateServerConfigRequest(); // CreateServerConfigRequest |  (optional) 

            try
            {
                // Create a new server config
                ServerConfig result = apiInstance.CreateServerConfig(app, createServerConfigRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.CreateServerConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateServerConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new server config
    ApiResponse<ServerConfig> response = apiInstance.CreateServerConfigWithHttpInfo(app, createServerConfigRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.CreateServerConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | The app ID |  |
| **createServerConfigRequest** | [**CreateServerConfigRequest**](CreateServerConfigRequest.md) |  | [optional]  |

### Return type

[**ServerConfig**](ServerConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;ServerConfig&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteapp"></a>
# **DeleteApp**
> Object DeleteApp (int app)

Delete a specific app

This method is responsible for deleting an App record from the database. It locates the App instance using the provided ID, and if found, proceeds to delete it. Upon successful deletion, an HTTP 204 No Content response is returned, indicating that the action was successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class DeleteAppExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | The app ID

            try
            {
                // Delete a specific app
                Object result = apiInstance.DeleteApp(app);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.DeleteApp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAppWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific app
    ApiResponse<Object> response = apiInstance.DeleteAppWithHttpInfo(app);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.DeleteAppWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | The app ID |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteapplocationsetting"></a>
# **DeleteAppLocationSetting**
> Object DeleteAppLocationSetting (int appLocationSetting)

Delete a location setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class DeleteAppLocationSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var appLocationSetting = 56;  // int | The app location setting ID

            try
            {
                // Delete a location setting
                Object result = apiInstance.DeleteAppLocationSetting(appLocationSetting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.DeleteAppLocationSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAppLocationSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a location setting
    ApiResponse<Object> response = apiInstance.DeleteAppLocationSettingWithHttpInfo(appLocationSetting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.DeleteAppLocationSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appLocationSetting** | **int** | The app location setting ID |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteauthtoken"></a>
# **DeleteAuthToken**
> Object DeleteAuthToken (string sid)

Handles the deletion of a user's authentication tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class DeleteAuthTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var sid = 1234567890ABCDEFG;  // string | The session id of the user

            try
            {
                // Handles the deletion of a user's authentication tokens
                Object result = apiInstance.DeleteAuthToken(sid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.DeleteAuthToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAuthTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Handles the deletion of a user's authentication tokens
    ApiResponse<Object> response = apiInstance.DeleteAuthTokenWithHttpInfo(sid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.DeleteAuthTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sid** | **string** | The session id of the user |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletebinary"></a>
# **DeleteBinary**
> Object DeleteBinary (int binary)

Delete a specified binary

It first finds the Binary instance by its ID. If the instance is found, it is deleted. The method then returns an HTTP 204 No Content response to indicate successful deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class DeleteBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var binary = 56;  // int | The binary ID

            try
            {
                // Delete a specified binary
                Object result = apiInstance.DeleteBinary(binary);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.DeleteBinary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBinaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specified binary
    ApiResponse<Object> response = apiInstance.DeleteBinaryWithHttpInfo(binary);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.DeleteBinaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **binary** | **int** | The binary ID |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletedockerregistry"></a>
# **DeleteDockerRegistry**
> Object DeleteDockerRegistry (int dockerRegistry)

Delete a specific docker registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class DeleteDockerRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var dockerRegistry = 56;  // int | The docker registry ID

            try
            {
                // Delete a specific docker registry
                Object result = apiInstance.DeleteDockerRegistry(dockerRegistry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.DeleteDockerRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDockerRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific docker registry
    ApiResponse<Object> response = apiInstance.DeleteDockerRegistryWithHttpInfo(dockerRegistry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.DeleteDockerRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dockerRegistry** | **int** | The docker registry ID |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteserverconfig"></a>
# **DeleteServerConfig**
> Object DeleteServerConfig (int serverConfig)

Delete a specific server config

This method handles the deletion of a ServerConfig record from the database. It first finds the ServerConfig instance by its ID, and if found, deletes it. Returns an HTTP 204 No Content response upon successful deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class DeleteServerConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var serverConfig = 56;  // int | The server config ID

            try
            {
                // Delete a specific server config
                Object result = apiInstance.DeleteServerConfig(serverConfig);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.DeleteServerConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteServerConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific server config
    ApiResponse<Object> response = apiInstance.DeleteServerConfigWithHttpInfo(serverConfig);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.DeleteServerConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverConfig** | **int** | The server config ID |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getappbyid"></a>
# **GetAppById**
> App GetAppById (int app)

Show a specific app

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetAppByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | The app ID

            try
            {
                // Show a specific app
                App result = apiInstance.GetAppById(app);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetAppById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAppByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show a specific app
    ApiResponse<App> response = apiInstance.GetAppByIdWithHttpInfo(app);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetAppByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | The app ID |  |

### Return type

[**App**](App.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;App&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapplocationsettings"></a>
# **GetAppLocationSettings**
> List&lt;AppLocationSetting&gt; GetAppLocationSettings (int app)

Show all location settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetAppLocationSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | The app ID

            try
            {
                // Show all location settings
                List<AppLocationSetting> result = apiInstance.GetAppLocationSettings(app);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetAppLocationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAppLocationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show all location settings
    ApiResponse<List<AppLocationSetting>> response = apiInstance.GetAppLocationSettingsWithHttpInfo(app);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetAppLocationSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | The app ID |  |

### Return type

[**List&lt;AppLocationSetting&gt;**](AppLocationSetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;AppLocationSettingCollection&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getapps"></a>
# **GetApps**
> List&lt;App&gt; GetApps ()

Show all apps

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetAppsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);

            try
            {
                // Show all apps
                List<App> result = apiInstance.GetApps();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetApps: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAppsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show all apps
    ApiResponse<List<App>> response = apiInstance.GetAppsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetAppsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;App&gt;**](App.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;AppCollection&#x60; |  -  |
| **401** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauthtoken"></a>
# **GetAuthToken**
> Auth GetAuthToken (GetAuthTokenRequest getAuthTokenRequest = null)

Handles user authentication

Validates the incoming request and attempts to authenticate the user based on the provided session ID. If the user is authenticated successfully, it returns an AuthResource containing the user's bearer token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetAuthTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var getAuthTokenRequest = new GetAuthTokenRequest(); // GetAuthTokenRequest |  (optional) 

            try
            {
                // Handles user authentication
                Auth result = apiInstance.GetAuthToken(getAuthTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetAuthToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Handles user authentication
    ApiResponse<Auth> response = apiInstance.GetAuthTokenWithHttpInfo(getAuthTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetAuthTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getAuthTokenRequest** | [**GetAuthTokenRequest**](GetAuthTokenRequest.md) |  | [optional]  |

### Return type

[**Auth**](Auth.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;Auth&#x60; |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbackups"></a>
# **GetBackups**
> List&lt;Backup&gt; GetBackups (int service)

List all backups for the specified Docker service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetBackupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var service = 56;  // int | The service ID

            try
            {
                // List all backups for the specified Docker service
                List<Backup> result = apiInstance.GetBackups(service);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetBackups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBackupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all backups for the specified Docker service
    ApiResponse<List<Backup>> response = apiInstance.GetBackupsWithHttpInfo(service);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetBackupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **int** | The service ID |  |

### Return type

[**List&lt;Backup&gt;**](Backup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;DockerBackupCollection&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbinaries"></a>
# **GetBinaries**
> List&lt;Binary&gt; GetBinaries (int app)

Show all binaries

Eager load file types and config templates to reduce the number of queries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetBinariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | The app ID

            try
            {
                // Show all binaries
                List<Binary> result = apiInstance.GetBinaries(app);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetBinaries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBinariesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show all binaries
    ApiResponse<List<Binary>> response = apiInstance.GetBinariesWithHttpInfo(app);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetBinariesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | The app ID |  |

### Return type

[**List&lt;Binary&gt;**](Binary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;BinaryCollection&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbinarybyid"></a>
# **GetBinaryById**
> Binary GetBinaryById (int binary)

Show a specific binary

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetBinaryByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var binary = 56;  // int | The binary ID

            try
            {
                // Show a specific binary
                Binary result = apiInstance.GetBinaryById(binary);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetBinaryById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBinaryByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show a specific binary
    ApiResponse<Binary> response = apiInstance.GetBinaryByIdWithHttpInfo(binary);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetBinaryByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **binary** | **int** | The binary ID |  |

### Return type

[**Binary**](Binary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;Binary&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdockerregistries"></a>
# **GetDockerRegistries**
> List&lt;DockerRegistry&gt; GetDockerRegistries ()

Show all docker registries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetDockerRegistriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);

            try
            {
                // Show all docker registries
                List<DockerRegistry> result = apiInstance.GetDockerRegistries();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetDockerRegistries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDockerRegistriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show all docker registries
    ApiResponse<List<DockerRegistry>> response = apiInstance.GetDockerRegistriesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetDockerRegistriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;DockerRegistry&gt;**](DockerRegistry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;DockerRegistryCollection&#x60; |  -  |
| **401** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdockerregistrybyid"></a>
# **GetDockerRegistryById**
> DockerRegistry GetDockerRegistryById (int dockerRegistry)

Display a specific docker registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetDockerRegistryByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var dockerRegistry = 56;  // int | The docker registry ID

            try
            {
                // Display a specific docker registry
                DockerRegistry result = apiInstance.GetDockerRegistryById(dockerRegistry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetDockerRegistryById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDockerRegistryByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Display a specific docker registry
    ApiResponse<DockerRegistry> response = apiInstance.GetDockerRegistryByIdWithHttpInfo(dockerRegistry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetDockerRegistryByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dockerRegistry** | **int** | The docker registry ID |  |

### Return type

[**DockerRegistry**](DockerRegistry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;DockerRegistry&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlocations"></a>
# **GetLocations**
> List&lt;Location&gt; GetLocations ()

Show a unique listing of locations based on active and ready worker nodes

Synchronizes the local database with the state of Docker nodes, then filters for active, ready worker nodes to create a unique listing of their location labels. These nodes are suitable for deployment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);

            try
            {
                // Show a unique listing of locations based on active and ready worker nodes
                List<Location> result = apiInstance.GetLocations();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetLocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show a unique listing of locations based on active and ready worker nodes
    ApiResponse<List<Location>> response = apiInstance.GetLocationsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetLocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Location&gt;**](Location.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;LocationCollection&#x60; |  -  |
| **401** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmostrecentbackup"></a>
# **GetMostRecentBackup**
> Backup GetMostRecentBackup (int service)

Display the most recent backup for the specified Docker service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetMostRecentBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var service = 56;  // int | The service ID

            try
            {
                // Display the most recent backup for the specified Docker service
                Backup result = apiInstance.GetMostRecentBackup(service);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetMostRecentBackup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMostRecentBackupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Display the most recent backup for the specified Docker service
    ApiResponse<Backup> response = apiInstance.GetMostRecentBackupWithHttpInfo(service);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetMostRecentBackupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **int** | The service ID |  |

### Return type

[**Backup**](Backup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;Backup&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getserverbackupdownloadurl"></a>
# **GetServerBackupDownloadUrl**
> BackupDownload GetServerBackupDownloadUrl (int service)

Generates a presigned URL for downloading a backup from AWS S3 if the backup method is 'archive'

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetServerBackupDownloadUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var service = 56;  // int | The service ID

            try
            {
                // Generates a presigned URL for downloading a backup from AWS S3 if the backup method is 'archive'
                BackupDownload result = apiInstance.GetServerBackupDownloadUrl(service);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetServerBackupDownloadUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerBackupDownloadUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generates a presigned URL for downloading a backup from AWS S3 if the backup method is 'archive'
    ApiResponse<BackupDownload> response = apiInstance.GetServerBackupDownloadUrlWithHttpInfo(service);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetServerBackupDownloadUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **int** | The service ID |  |

### Return type

[**BackupDownload**](BackupDownload.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;BackupDownload&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getserverbyid"></a>
# **GetServerById**
> Server GetServerById (int app, int service)

Display a specific DockerService associated with the given App

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetServerByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | The app ID
            var service = 56;  // int | The service ID

            try
            {
                // Display a specific DockerService associated with the given App
                Server result = apiInstance.GetServerById(app, service);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetServerById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Display a specific DockerService associated with the given App
    ApiResponse<Server> response = apiInstance.GetServerByIdWithHttpInfo(app, service);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetServerByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | The app ID |  |
| **service** | **int** | The service ID |  |

### Return type

[**Server**](Server.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;Server&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getserverconfigbyid"></a>
# **GetServerConfigById**
> ServerConfig GetServerConfigById (int serverConfig)

Show a specific server config

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetServerConfigByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var serverConfig = 56;  // int | The server config ID

            try
            {
                // Show a specific server config
                ServerConfig result = apiInstance.GetServerConfigById(serverConfig);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetServerConfigById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerConfigByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show a specific server config
    ApiResponse<ServerConfig> response = apiInstance.GetServerConfigByIdWithHttpInfo(serverConfig);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetServerConfigByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverConfig** | **int** | The server config ID |  |

### Return type

[**ServerConfig**](ServerConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;ServerConfig&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getserverconfigs"></a>
# **GetServerConfigs**
> List&lt;ServerConfig&gt; GetServerConfigs (int app)

Show all server configs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetServerConfigsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | The app ID

            try
            {
                // Show all server configs
                List<ServerConfig> result = apiInstance.GetServerConfigs(app);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetServerConfigs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerConfigsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show all server configs
    ApiResponse<List<ServerConfig>> response = apiInstance.GetServerConfigsWithHttpInfo(app);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetServerConfigsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | The app ID |  |

### Return type

[**List&lt;ServerConfig&gt;**](ServerConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;ServerConfigCollection&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getserverlogs"></a>
# **GetServerLogs**
> ServiceLogs GetServerLogs (int service, bool? details = null, bool? follow = null, bool? stdout = null, bool? stderr = null, int? since = null, bool? timestamps = null, string tail = null)

Get stdout and stderr logs from a service or task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetServerLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var service = 56;  // int | The service ID
            var details = true;  // bool? | details Flag (optional) 
            var follow = true;  // bool? | follow Flag (optional) 
            var stdout = true;  // bool? | stdout Flag (optional) 
            var stderr = true;  // bool? | stderr Flag (optional) 
            var since = 56;  // int? | since Flag (optional) 
            var timestamps = true;  // bool? | timestamps Flag (optional) 
            var tail = "tail_example";  // string | tail options (optional) 

            try
            {
                // Get stdout and stderr logs from a service or task
                ServiceLogs result = apiInstance.GetServerLogs(service, details, follow, stdout, stderr, since, timestamps, tail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetServerLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get stdout and stderr logs from a service or task
    ApiResponse<ServiceLogs> response = apiInstance.GetServerLogsWithHttpInfo(service, details, follow, stdout, stderr, since, timestamps, tail);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetServerLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **int** | The service ID |  |
| **details** | **bool?** | details Flag | [optional]  |
| **follow** | **bool?** | follow Flag | [optional]  |
| **stdout** | **bool?** | stdout Flag | [optional]  |
| **stderr** | **bool?** | stderr Flag | [optional]  |
| **since** | **int?** | since Flag | [optional]  |
| **timestamps** | **bool?** | timestamps Flag | [optional]  |
| **tail** | **string** | tail options | [optional]  |

### Return type

[**ServiceLogs**](ServiceLogs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;ServiceLogs&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getservers"></a>
# **GetServers**
> List&lt;Server&gt; GetServers (int app)

Show all services for a given app

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class GetServersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var app = 56;  // int | Instance of the app to filter services by.

            try
            {
                // Show all services for a given app
                List<Server> result = apiInstance.GetServers(app);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.GetServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Show all services for a given app
    ApiResponse<List<Server>> response = apiInstance.GetServersWithHttpInfo(app);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.GetServersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **int** | Instance of the app to filter services by. |  |

### Return type

[**List&lt;Server&gt;**](Server.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;ServerCollection&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="restartserver"></a>
# **RestartServer**
> Object RestartServer (int service, Object body = null)

Restarts a specific Docker service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class RestartServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var service = 56;  // int | The service ID
            var body = null;  // Object |  (optional) 

            try
            {
                // Restarts a specific Docker service
                Object result = apiInstance.RestartServer(service, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.RestartServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestartServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restarts a specific Docker service
    ApiResponse<Object> response = apiInstance.RestartServerWithHttpInfo(service, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.RestartServerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **int** | The service ID |  |
| **body** | **Object** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="restorebackup"></a>
# **RestoreBackup**
> Object RestoreBackup (int service, Object body = null)

Restore a backup for a specified Docker service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class RestoreBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var service = 56;  // int | The service ID
            var body = null;  // Object |  (optional) 

            try
            {
                // Restore a backup for a specified Docker service
                Object result = apiInstance.RestoreBackup(service, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.RestoreBackup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestoreBackupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore a backup for a specified Docker service
    ApiResponse<Object> response = apiInstance.RestoreBackupWithHttpInfo(service, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.RestoreBackupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **int** | The service ID |  |
| **body** | **Object** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateapplocationsetting"></a>
# **UpdateAppLocationSetting**
> AppLocationSetting UpdateAppLocationSetting (int appLocationSetting, UpdateAppLocationSettingRequest updateAppLocationSettingRequest = null)

Update a location setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class UpdateAppLocationSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var appLocationSetting = 56;  // int | The app location setting ID
            var updateAppLocationSettingRequest = new UpdateAppLocationSettingRequest(); // UpdateAppLocationSettingRequest |  (optional) 

            try
            {
                // Update a location setting
                AppLocationSetting result = apiInstance.UpdateAppLocationSetting(appLocationSetting, updateAppLocationSettingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.UpdateAppLocationSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAppLocationSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a location setting
    ApiResponse<AppLocationSetting> response = apiInstance.UpdateAppLocationSettingWithHttpInfo(appLocationSetting, updateAppLocationSettingRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.UpdateAppLocationSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appLocationSetting** | **int** | The app location setting ID |  |
| **updateAppLocationSettingRequest** | [**UpdateAppLocationSettingRequest**](UpdateAppLocationSettingRequest.md) |  | [optional]  |

### Return type

[**AppLocationSetting**](AppLocationSetting.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;AppLocationSetting&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatebinary"></a>
# **UpdateBinary**
> Binary UpdateBinary (int binary, CreateBinaryRequest createBinaryRequest = null)

Update a binary and the related file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class UpdateBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var binary = 56;  // int | The binary ID
            var createBinaryRequest = new CreateBinaryRequest(); // CreateBinaryRequest |  (optional) 

            try
            {
                // Update a binary and the related file
                Binary result = apiInstance.UpdateBinary(binary, createBinaryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.UpdateBinary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBinaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a binary and the related file
    ApiResponse<Binary> response = apiInstance.UpdateBinaryWithHttpInfo(binary, createBinaryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.UpdateBinaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **binary** | **int** | The binary ID |  |
| **createBinaryRequest** | [**CreateBinaryRequest**](CreateBinaryRequest.md) |  | [optional]  |

### Return type

[**Binary**](Binary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;Binary&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedockerregistry"></a>
# **UpdateDockerRegistry**
> DockerRegistry UpdateDockerRegistry (int dockerRegistry, UpdateDockerRegistryRequest updateDockerRegistryRequest = null)

Update a specific docker registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class UpdateDockerRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var dockerRegistry = 56;  // int | The docker registry ID
            var updateDockerRegistryRequest = new UpdateDockerRegistryRequest(); // UpdateDockerRegistryRequest |  (optional) 

            try
            {
                // Update a specific docker registry
                DockerRegistry result = apiInstance.UpdateDockerRegistry(dockerRegistry, updateDockerRegistryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.UpdateDockerRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDockerRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a specific docker registry
    ApiResponse<DockerRegistry> response = apiInstance.UpdateDockerRegistryWithHttpInfo(dockerRegistry, updateDockerRegistryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.UpdateDockerRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dockerRegistry** | **int** | The docker registry ID |  |
| **updateDockerRegistryRequest** | [**UpdateDockerRegistryRequest**](UpdateDockerRegistryRequest.md) |  | [optional]  |

### Return type

[**DockerRegistry**](DockerRegistry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;DockerRegistry&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateserverconfig"></a>
# **UpdateServerConfig**
> ServerConfig UpdateServerConfig (int serverConfig, CreateServerConfigRequest createServerConfigRequest = null)

Update a server config

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace Example
{
    public class UpdateServerConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fleet.4players.io/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OdinFleetApi(httpClient, config, httpClientHandler);
            var serverConfig = 56;  // int | The server config ID
            var createServerConfigRequest = new CreateServerConfigRequest(); // CreateServerConfigRequest |  (optional) 

            try
            {
                // Update a server config
                ServerConfig result = apiInstance.UpdateServerConfig(serverConfig, createServerConfigRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OdinFleetApi.UpdateServerConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateServerConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a server config
    ApiResponse<ServerConfig> response = apiInstance.UpdateServerConfigWithHttpInfo(serverConfig, createServerConfigRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OdinFleetApi.UpdateServerConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverConfig** | **int** | The server config ID |  |
| **createServerConfigRequest** | [**CreateServerConfigRequest**](CreateServerConfigRequest.md) |  | [optional]  |

### Return type

[**ServerConfig**](ServerConfig.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | &#x60;ServerConfig&#x60; |  -  |
| **404** |  |  -  |
| **401** |  |  -  |
| **422** |  |  -  |
| **403** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

