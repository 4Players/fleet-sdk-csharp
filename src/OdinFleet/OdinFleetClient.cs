using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using OdinFleet.Api;
using OdinFleet.Client;
using OdinFleet.Model;

namespace OdinFleet
{
    /// <summary>
    /// Represents a client for interacting with the OdinFleet API.
    /// </summary>
    public class OdinFleetClient
    {
        private readonly IOdinFleetApiSync _apiClientSync;
        private readonly IOdinFleetApiAsync _apiClientAsync;
        private int _appId = 0;

        /// <summary>
        /// This is the constructor for the OdinFleetClient class. Provide an access token to authenticate with the API.
        /// </summary>
        /// <param name="accessToken">The access token to authenticate with the API.</param>
        public OdinFleetClient(string accessToken)
        {
            var configuration = new Configuration
            {
                BasePath = "https://fleet.4players.io/api"
            };

            configuration.AddApiKey("Authorization", accessToken);
            configuration.AddApiKeyPrefix("Authorization", "Bearer");
            configuration.DefaultHeaders.Add("Authorization", "Bearer " + accessToken);

            // Creating ApiClient instance
            _apiClientSync = new OdinFleetApi(configuration);
            _apiClientAsync = new OdinFleetApi(configuration);
        }
        
        #region Apps
        
        /// <summary>
        /// Creates an app with the given name.
        /// </summary>
        /// <param name="name">The name of the app.</param>
        /// <returns>The created <see cref="App"/>.</returns>
        public App CreateApp(string name)
        {
            var createAppRequest = new CreateAppRequest(name);
            return _apiClientSync.CreateApp(createAppRequest);
        }
        
        /// <summary>
        /// Creates an app asynchronously with the given name.
        /// </summary>
        /// <param name="name">The name of the app.</param>
        /// <returns>The created <see cref="App"/>.</returns>
        public async Task<App> CreateAppAsync(string name)
        {
            var createAppRequest = new CreateAppRequest(name);
            return await _apiClientAsync.CreateAppAsync(createAppRequest);
        }
        
        /// <summary>
        /// Retrieves a list of apps.
        /// </summary>
        /// <returns>A collection of <see cref="App"/> objects representing the apps.</returns>
        public List<App> GetApps()
        {
            return _apiClientSync.GetApps();
        }
        
        /// <summary>
        /// Retrieves a list of apps asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a collection of <see cref="App"/> objects representing the apps.</returns>
        public async Task<List<App>> GetAppsAsync()
        {
            return await _apiClientAsync.GetAppsAsync();
        }
        
        /// <summary>
        /// Retrieves an app with the specified ID.
        /// </summary>
        /// <param name="appId">The ID of the app.</param>
        /// <returns>The <see cref="App"/> object representing the app with the specified ID, or null if not found.</returns>
        public App GetAppById(int appId)
        {
            return _apiClientSync.GetAppById(appId);
        }
        
        /// <summary>
        /// Retrieves an app with the given ID asynchronously.
        /// </summary>
        /// <param name="appId">The ID of the app to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="App"/> object representing the app.</returns>
        public async Task<App> GetAppByIdAsync(int appId)
        {
            return await _apiClientAsync.GetAppByIdAsync(appId);
        }

        /// <summary>
        /// Deletes the app with the specified ID.
        /// </summary>
        /// <param name="appId">The ID of the app to delete.</param>
        public bool DeleteApp(int appId)
        {
            try
            {
                _apiClientSync.DeleteApp(appId);
                return true;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes an app asynchronously with the given app ID.
        /// </summary>
        /// <param name="appId">The ID of the app to delete.</param>
        /// <returns>Returns a task representing the asynchronous operation. The task result is a boolean indicating whether the app was successfully deleted (true) or not (false).</returns>
        public Task<bool> DeleteAppAsync(int appId)
        {
            try
            {
                _apiClientAsync.DeleteBinaryAsync(appId);
                return Task.FromResult(true);
            }
            catch (HttpRequestException)
            {
                return Task.FromResult(false);
            }
        }

        /// <summary>
        /// Selects an app with the given app ID. This app will be used for subsequent API calls.
        /// </summary>
        /// <param name="appId">The ID of the app to select.</param>
        public void SelectApp(int appId)
        {
            this._appId = appId;
        }

        /// <summary>
        /// Selects an app with the given ID. This app will be used for subsequent API calls.
        /// </summary>
        /// <param name="app">The app to select.</param>
        public void SelectApp(App app)
        {
            this._appId = app.Id;
        }
        
        #endregion
        
        #region Images/Binaries

        /// <summary>
        /// Retrieves the list of binaries for the selected app.
        /// </summary>
        /// <see cref="SelectApp(int)"/>
        /// <returns>The list of binaries for the specified app.</returns>
        public List<Binary> GetBinaries()
        {
            return _apiClientSync.GetBinaries(_appId);
        }

        // Asynchronous method for getting a list of binaries
        /// <summary>
        /// Asynchronous method for getting a list of binaries of the selected app
        /// </summary>
        /// <see cref="SelectApp(int)"/>
        /// <returns>A task representing the asynchronous operation. The task result contains a list of Binary objects.</returns>
        public async Task<List<Binary>> GetBinariesAsync()
        {
            return await _apiClientAsync.GetBinariesAsync(_appId);
        }
        
        /// <summary>
        /// Get the Binary object with the specified binary ID.
        /// </summary>
        /// <param name="binaryId">The ID of the binary to retrieve.</param>
        /// <returns>The Binary object.</returns>
        public Binary GetBinaryById(int binaryId)
        {
            return _apiClientSync.GetBinaryById(binaryId);
        }

        // Asynchronous method for getting a binary by ID
        /// <summary>
        /// Asynchronous method for getting a binary by ID.
        /// </summary>
        /// <param name="binaryId">The ID of the binary to retrieve.</param>
        /// <returns>The binary with the specified ID.</returns>
        public async Task<Binary> GetBinaryByIdAsync(int binaryId)
        {
            return await _apiClientAsync.GetBinaryByIdAsync(binaryId);
        }

        /// <summary>
        /// Retrieves a list of Docker registries that are associated with your account.
        /// </summary>
        /// <remarks>Every account has a list of docker registries and can also create their own
        /// reference to docker registries (i.e. for private registries). </remarks>
        /// <returns>A list of DockerRegistry objects.</returns>
        public List<DockerRegistry> GetDockerRegistries()
        {
            return _apiClientSync.GetDockerRegistries();
        }

        // Synchronous method for creating a binary
        /// <summary>
        /// Creates a binary with the given name and version in the selected app
        /// </summary>
        /// <remarks>You need to provide the id of the docker registry. Please use the `GetDockerRegistries`
        /// method to retrieve the list of docker registries. You can also find the registries (and IDs) in
        /// the Dashboard under Settings</remarks>
        /// <see cref="SelectApp(int)"/>
        /// <param name="name">The name of the binary.</param>
        /// <param name="version">The version of the binary.</param>
        /// <param name="imageName">The name of the image (i.e. itzg/minecraft-server)</param>
        /// <param name="registryId">The id of the registry where the image is available</param>
        /// <see cref="GetDockerRegistries"/>
        /// <returns>The created binary object.</returns>
        public Binary CreateDockerImageBinary(string name, string version, string imageName, int registryId)
        {
            var dockerImage = new DockerImage(imageName, registryId);
            var createBinaryRequest = new CreateBinaryRequest(name, version, BinaryType.DockerImage, dockerImage: dockerImage);
            return _apiClientSync.CreateBinary(_appId, createBinaryRequest);
        }

        // Asynchronous method for creating a binary
        /// <summary>
        /// Asynchronous method for creating a binary int the selected app.
        /// </summary>
        /// <see cref="SelectApp(int)"/>
        /// <param name="name">The name of the binary.</param>
        /// <param name="version">The version of the binary.</param>
        /// <param name="imageName">The name of the image (i.e. itzg/minecraft-server)</param>
        /// <param name="registryId">The id of the registry where the image is available</param>
        /// /// <see cref="GetDockerRegistries"/>
        /// <returns>The created binary.</returns>
        public async Task<Binary> CreateDockerImageBinaryAsync(string name, string version, string imageName, int registryId)
        {
            var dockerImage = new DockerImage(imageName, registryId);
            var createBinaryRequest = new CreateBinaryRequest(name, version, BinaryType.DockerImage, dockerImage: dockerImage);
            return await _apiClientAsync.CreateBinaryAsync(_appId, createBinaryRequest);
        }

        /// <summary>
        /// Create a Steamworks binary for the specified app.
        /// </summary>
        /// <param name="name">The name of the binary.</param>
        /// <param name="version">The version of the binary.</param>
        /// <param name="steamAppId">The Steam App ID.</param>
        /// <param name="branch">The branch of the Steamworks binary (optional, default is null).</param>
        /// <param name="password">The password for the Steamworks binary (optional, default is null).</param>
        /// <returns>A Binary object representing the created Steamworks binary.</returns>
        public Binary CreateSteamworksBinary(string name, string version, string steamAppId, string branch = default(string),
            string password = default(string))
        {
            var createBinaryRequest = new CreateBinaryRequest(name, version, BinaryType.Steam, steam: new SteamWorks(steamAppId, branch, password));
            return _apiClientSync.CreateBinary(_appId, createBinaryRequest);
        }

        /// <summary>
        /// Creates a Steamworks binary asynchronously.
        /// </summary>
        /// <param name="name">The name of the binary.</param>
        /// <param name="version">The version number of the binary.</param>
        /// <param name="steamAppId">The Steam App ID of the binary.</param>
        /// <param name="branch">The branch name of the binary. Optional, default is null.</param>
        /// <param name="password">The password of the binary. Optional, default is null.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the created Steamworks binary.</returns>
        public async Task<Binary> CreateSteamworksBinaryAsync(string name, string version, string steamAppId, string branch = default(string),
            string password = default(string))
        {
            var createBinaryRequest = new CreateBinaryRequest(name, version, BinaryType.Steam, steam: new SteamWorks(steamAppId, branch, password));
            return await _apiClientAsync.CreateBinaryAsync(_appId, createBinaryRequest);
        }

        /// <summary>
        /// Delete a specified binary.
        /// </summary>
        /// <param name="binaryId">The binary ID</param>
        public bool DeleteBinary(int binaryId)
        {
            try
            {
                _apiClientSync.DeleteBinary(binaryId);
                return true;
            } 
            catch (HttpRequestException)
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes a specified binary asynchronously.
        /// </summary>
        /// <param name="binaryId">The ID of the binary to delete.</param>
        /// <returns>Returns a task representing the asynchronous operation. The task result is a boolean indicating whether the image was successfully deleted (true) or not (false).</returns>
        public Task<bool> DeleteBinaryAsync(int binaryId)
        {
            try
            {
                _apiClientAsync.DeleteBinaryAsync(binaryId);
                return Task.FromResult(true);
            }
            catch (HttpRequestException)
            {
                return Task.FromResult(false);
            }
        }

        /// <summary>
        /// Updates a binary specified by binary ID with name, and version.
        /// </summary>
        /// <param name="binaryId">The ID of the binary to update.</param>
        /// <param name="name">The new name of the binary.</param>
        /// <param name="version">The new version of the binary.</param>
        /// <returns>The updated Binary object</returns>
        public Binary UpdateBinary(int binaryId, string name, string version)
        {
            var updateBinaryRequest = new CreateBinaryRequest(name, version);
            return _apiClientSync.UpdateBinary(binaryId, updateBinaryRequest);
        }

        /// <summary>
        /// Updates a binary with the specified ID, name, and version.
        /// </summary>
        /// <param name="binaryId">The ID of the binary to update.</param>
        /// <param name="name">The new name of the binary.</param>
        /// <param name="version">The new version of the binary.</param>
        /// <returns>The updated binary.</returns>
        public Task<Binary> UpdateBinaryAsync(int binaryId, string name, string version)
        {
            var updateBinaryRequest = new CreateBinaryRequest(name, version);
            return _apiClientAsync.UpdateBinaryAsync(binaryId, updateBinaryRequest);
        }
        
        #endregion
        
        #region Server Configs

        /// <summary>
        /// Retrieves the server configurations for the selected app.
        /// </summary>
        /// <returns>An array of ServerConfig objects representing the server configurations for the selected app.</returns>
        public List<ServerConfig> GetServerConfigs()
        {
            return _apiClientSync.GetServerConfigs(_appId);
        }

        /// <summary>
        /// Retrieves a list of server configurations asynchronously for the selected app.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains a list of ServerConfig objects.
        /// </returns>
        public async Task<List<ServerConfig>> GetServerConfigsAsync()
        {
            return await _apiClientAsync.GetServerConfigsAsync(_appId);
        }

        /// <summary>
        /// Get the server configuration by its id.
        /// </summary>
        /// <param name="serverConfigId">The id of the server config.</param>
        /// <returns>The server configuration.</returns>
        public ServerConfig GetServerConfigById(int serverConfigId)
        {
            return _apiClientSync.GetServerConfigById(serverConfigId);
        }

        /// <summary>
        /// Retrieves a server configuration by its ID asynchronously.
        /// </summary>
        /// <param name="serverConfigId">The ID of the server configuration to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the server configuration.</returns>
        public async Task<ServerConfig> GetServerConfigByIdAsync(int serverConfigId)
        {
            return await _apiClientAsync.GetServerConfigByIdAsync(serverConfigId);
        }

        /// <summary>
        /// Creates a new server configuration for the selected application
        /// </summary>
        /// <param name="createServerConfigRequest">The object containing the details of the server configuration to create.</param>
        /// <returns>The newly created server configuration object.</returns>
        public ServerConfig CreateServerConfig(CreateServerConfigRequest createServerConfigRequest)
        {
            return _apiClientSync.CreateServerConfig(_appId, createServerConfigRequest);
        }

        /// <summary>
        /// Creates a new server configuration asynchronously.
        /// </summary>
        /// <param name="createServerConfigRequest">The object containing the details of the server configuration to be created.</param>
        /// <returns>A task representing the asynchronous operation with the server configuration that was created.</returns>
        public async Task<ServerConfig> CreateServerConfigAsync(CreateServerConfigRequest createServerConfigRequest)
        {
            return await _apiClientAsync.CreateServerConfigAsync(_appId, createServerConfigRequest);
        }

        /// <summary>
        /// Updates the server configuration with the specified ID.
        /// </summary>
        /// <param name="serverConfigId">The ID of the server configuration to update.</param>
        /// <param name="createServerConfigRequest">The request object containing the updated server configuration information.</param>
        /// <returns>The updated server configuration.</returns>
        public ServerConfig UpdateServerConfig(int serverConfigId, CreateServerConfigRequest createServerConfigRequest)
        {
            return _apiClientSync.UpdateServerConfig(serverConfigId, createServerConfigRequest);
        }

        /// <summary>
        /// Updates a server configuration with the specified ID.
        /// </summary>
        /// <param name="serverConfigId">The ID of the server configuration to update.</param>
        /// <param name="createServerConfigRequest">The updated server configuration data.</param>
        /// <returns>The updated server configuration.</returns>
        public async Task<ServerConfig> UpdateServerConfigAsync(int serverConfigId, CreateServerConfigRequest createServerConfigRequest)
        {
            return await _apiClientAsync.UpdateServerConfigAsync(serverConfigId, createServerConfigRequest);
        }

        /// <summary>
        /// Deletes a server configuration by its ID.
        /// </summary>
        /// <param name="serverConfigId">The ID of the server configuration to delete.</param>
        /// <returns>Returns true if the server configuration was successfully deleted,
        /// otherwise returns false.</returns>
        public bool DeleteServerConfig(int serverConfigId)
        {
            try
            {
                _apiClientSync.DeleteServerConfig(serverConfigId);
                return true;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        /// <summary>
        /// Asynchronously deletes a server configuration.
        /// </summary>
        /// <param name="serverConfigId">The ID of the server configuration to delete.</param>
        /// <returns>Returns a task representing the asynchronous operation. The task result is a boolean indicating whether the server configuration was successfully deleted (true) or not (false).</returns>
        public Task<bool> DeleteServerConfigAsync(int serverConfigId)
        {
            try
            {
                _apiClientAsync.DeleteServerConfigAsync(serverConfigId);
                return Task.FromResult(true);
            }
            catch (HttpRequestException)
            {
                return Task.FromResult(false);
            }
        }
        
        #endregion
        
        #region Deployments (App Location Settings)

        /// <summary>
        /// Retrieves a list of deployments for the selected app.
        /// </summary>
        /// <returns>
        /// The list of app location settings representing the deployments.
        /// </returns>
        public List<AppLocationSetting> GetDeployments()
        {
            return _apiClientSync.GetAppLocationSettings(_appId);
        }

        /// <summary>
        /// Retrieves a list of app location settings for a specific app asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.
        /// The task result contains the list of app location settings for the specified app.</returns>
        public async Task<List<AppLocationSetting>> GetDeploymentsAsync()
        {
            return await _apiClientAsync.GetAppLocationSettingsAsync(_appId);
        }

        /// <summary>
        /// Retrieves a list of locations from the OdinFleet API. The locations are used for creating deployments.
        /// </summary>
        /// <returns>A list of locations.</returns>
        public List<Location> GetLocations()
        {
            return _apiClientSync.GetLocations();
        }

        /// <summary>
        /// Gets a list of locations from the OdinFleet API asynchronously.
        /// </summary>
        /// <returns>The list of locations.</returns>
        /// <remarks>
        /// This method calls the GetLocationsAsync method from the IOdinFleetApiAsync interface.
        /// </remarks>
        public async Task<List<Location>> GetLocationsAsync()
        {
            return await _apiClientAsync.GetLocationsAsync();
        }

        /// <summary>
        /// Creates a deployment for the selected app. The location is specified by the country and city. City takes preference
        /// but if the city is not available, the country is used to find a suitable location.
        /// </summary>
        /// <param name="name">The name of the deployment.</param>
        /// <param name="serverConfigId">The ID of the server configuration.</param>
        /// <param name="location">The location where the deployment should be created.</param>
        /// <param name="numInstances">The number of instances to be created for the deployment.</param>
        /// <returns>
        /// The created AppLocationSetting object.
        /// </returns>
        public AppLocationSetting CreateDeployment(string name, int serverConfigId, Location location, int numInstances)
        {
            var placement = new Placement();
            placement.Constraints = new Constraints(location.Country, location.City);
            
            var createAppLocationSettingRequest = new CreateAppLocationSettingRequest();
            createAppLocationSettingRequest.Name = name;
            createAppLocationSettingRequest.ServerConfigId = serverConfigId;
            createAppLocationSettingRequest.Placement = placement;
            createAppLocationSettingRequest.NumInstances = numInstances;
            createAppLocationSettingRequest.AutoScalerEnabled = false;
            
            return _apiClientSync.CreateAppLocationSetting(_appId, createAppLocationSettingRequest);
        }

        /// <summary>
        /// Creates a deployment for the selected app asynchronously. The location is specified by the country and city. City takes preference
        /// but if the city is not available, the country is used to find a suitable location.
        /// </summary>
        /// <param name="name">The name of the deployment.</param>
        /// <param name="serverConfigId">The ID of the server configuration.</param>
        /// <param name="location">The location where the deployment should be created.</param>
        /// <param name="numInstances">The number of instances for the deployment.</param>
        /// <returns>The task representing the asynchronous operation. The task result is an instance of <see cref="AppLocationSetting"/>.</returns>
        public Task<AppLocationSetting> CreateDeploymentAsync(string name, int serverConfigId, Location location, int numInstances)
        {
            var placement = new Placement();
            placement.Constraints = new Constraints(location.Country, location.City);
            
            var createAppLocationSettingRequest = new CreateAppLocationSettingRequest();
            createAppLocationSettingRequest.Name = name;
            createAppLocationSettingRequest.ServerConfigId = serverConfigId;
            createAppLocationSettingRequest.Placement = placement;
            createAppLocationSettingRequest.NumInstances = numInstances;
            createAppLocationSettingRequest.AutoScalerEnabled = false;
            
            return _apiClientAsync.CreateAppLocationSettingAsync(_appId, createAppLocationSettingRequest);
        }

        /// <summary>
        /// Deletes a deployment with the specified deployment ID. All servers running on this deployment will be stopped
        /// and deleted
        /// </summary>
        /// <param name="deploymentId">The ID of the deployment to delete.</param>
        /// <returns>True if the deployment was successfully deleted; otherwise, false.</returns>
        public bool DeleteDeployment(int deploymentId)
        {
            try
            {
                _apiClientSync.DeleteAppLocationSetting(deploymentId);
                return true;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes a deployment with the specified deployment ID asynchronously. All servers running on this deployment will be stopped
        /// and deleted
        /// </summary>
        /// <param name="deploymentId">The ID of the deployment to be deleted.</param>
        /// <returns>A task representing the asynchronous operation. The task will return true if the deployment is successfully deleted, false otherwise.</returns>
        public Task<bool> DeleteDeploymentAsync(int deploymentId)
        {
            try
            {
                _apiClientAsync.DeleteAppLocationSettingAsync(deploymentId);
                return Task.FromResult(true);
            }
            catch (HttpRequestException)
            {
                return Task.FromResult(false);
            }
        }
        
        #endregion
        
        #region Server Instances

        /// <summary>
        /// Retrieves a list of servers of all deployments associated with the selected app.
        /// </summary>
        /// <returns>A list of servers.</returns>
        public List<Server> GetServers()
        {
            return _apiClientSync.GetServers(_appId);
        }

        /// <summary>
        /// Asynchronously retrieves the list of servers for the selected app.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The task result contains a List of Server objects.</returns>
        public async Task<List<Server>> GetServersAsync()
        {
            return await _apiClientAsync.GetServersAsync(_appId);
        }

        /// <summary>
        /// Gets a server by its ID.
        /// </summary>
        /// <param name="serverId">The ID of the server to retrieve.</param>
        /// <returns>The server with the specified ID.</returns>
        public Server GetServerById(int serverId)
        {
            return _apiClientSync.GetServerById(_appId, serverId);
        }

        /// <summary>
        /// Get a server by its ID asynchronously.
        /// </summary>
        /// <param name="serverId">The ID of the server.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the server information.</returns>
        public Task<Server> GetServerByIdAsync(int serverId)
        {
            return _apiClientAsync.GetServerByIdAsync(_appId, serverId);
        }

        /// <summary>
        /// Retrieves the logs for a specified server.
        /// </summary>
        /// <param name="serverId">The ID of the server.</param>
        /// <param name="details">Specifies whether to include detailed logs or not. Default is false.</param>
        /// <param name="stdout">Specifies whether to include standard output logs. Default is true.</param>
        /// <param name="stderr">Specifies whether to include standard error logs. Default is true.</param>
        /// <param name="since">Specifies the start time in seconds since the Unix epoch. Default is 0.</param>
        /// <param name="timestamps">Specifies whether to include timestamps in the logs. Default is false.</param>
        /// <param name="tail">Specifies the number of log lines to retrieve from the end of the log. Default is "100" but can also be "all" to retrieve all logs.</param>
        /// <returns>
        /// The logs for the specified server as a ServiceLogs object.
        /// </returns>
        public ServiceLogs GetServerLogs(int serverId, bool details = false, bool stdout = true, bool stderr = true, int since=0, bool timestamps = false, string tail = "100")
        {
            var response = _apiClientSync.GetServerLogs(serverId, details, false, stdout, stderr, since, timestamps, tail);
            return response;
        }

        /// <summary>
        /// Retrieves the server logs asynchronously.
        /// </summary>
        /// <param name="serverId">The ID of the server.</param>
        /// <param name="details">Determines if the log details should be included. Default value is false.</param>
        /// <param name="stdout">Determines if the standard output logs should be included. Default value is true.</param>
        /// <param name="stderr">Determines if the standard error logs should be included. Default value is true.</param>
        /// <param name="since">Filters out log entries before this timestamp. Default value is 0.</param>
        /// <param name="timestamps">Determines if timestamps should be included in the log entries. Default value is false.</param>
        /// <param name="tail">Determines the number of recent log entries to include. Default value is "100".</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the service logs.</returns>
        public Task<ServiceLogs> GetServerLogsAsync(int serverId, bool details = false, bool stdout = true, bool stderr = true, int since=0, bool timestamps = false, string tail = "100")
        {
            var response = _apiClientAsync.GetServerLogsAsync(serverId, details, false, stdout, stderr, since, timestamps, tail);
            return response;
        }

        /// <summary>
        /// Initiates a server restart. This will stop the server, create the backup of persistent folders, and start the server again.
        /// </summary>
        /// <remarks>This only works if the server has a config that includes a persistent folder</remarks>
        /// <param name="serverId">The ID of the server to create a backup for.</param>
        /// <param name="name">The name of the backup.</param>
        /// <returns>True if the backup was created successfully, false otherwise.</returns>
        public bool CreateServerBackup(int serverId, string name)
        {
            try
            {
                var createBackupRequest = new CreateBackupRequest
                {
                    Name = name
                };
                _apiClientSync.CreateBackup(serverId, createBackupRequest);
                return true;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        /// <summary>
        /// Initiates a server restart asynchronously. This will stop the server, create the backup of persistent folders, and start the server again.
        /// </summary>
        /// <param name="serverId">The ID of the server to create a backup for.</param>
        /// <param name="name">The name of the backup.</param>
        /// <returns>A task representing the asynchronous operation. The task will return true if the backup was created successfully, false otherwise.</returns>
        public Task<bool> CreateServerBackupAsync(int serverId, string name)
        {
            try
            {
                var createBackupRequest = new CreateBackupRequest
                {
                    Name = name
                };
                _apiClientAsync.CreateBackupAsync(serverId, createBackupRequest);
                return Task.FromResult(true);
            }
            catch (HttpRequestException)
            {
                return Task.FromResult(false);
            }
        }

        /// <summary>
        /// Retrieves a list of backups for a specific server.
        /// </summary>
        /// <remarks>We only support one backup at a time right now. If you need more, please get in touch</remarks>
        /// <param name="serverId">The ID of the server.</param>
        /// <returns>A list of <see cref="Backup"/> objects representing the backups.</returns>
        public List<Backup> GetServerBackups(int serverId)
        {
            return _apiClientSync.GetBackups(serverId);
        }

        /// <summary>
        /// Retrieves a list of server backups asynchronously.
        /// </summary>
        /// <remarks>We only support one backup at a time right now. If you need more, please get in touch</remarks>
        /// <param name="serverId">The ID of the server for which to retrieve backups.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of backup objects.</returns>
        public Task<List<Backup>> GetServerBackupsAsync(int serverId)
        {
            return _apiClientAsync.GetBackupsAsync(serverId);
        }

        /// <summary>
        /// Retrieves the download URL for a backup of a server. Use it to download the backup file to your local machine.
        /// </summary>
        /// <param name="serverId">The ID of the server.</param>
        /// <returns>The backup download information.</returns>
        public BackupDownload GetBackupDownloadUrl(int serverId)
        {
            return _apiClientSync.GetServerBackupDownloadUrl(serverId);
        }

        /// <summary>
        /// Gets the download URL for a server's backup asynchronously.
        /// </summary>
        /// <param name="serverId">The ID of the server for which to get the backup download URL.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the download URL for the server's backup.</returns>
        public Task<BackupDownload> GetBackupDownloadUrlAsync(int serverId)
        {
            return _apiClientAsync.GetServerBackupDownloadUrlAsync(serverId);
        }

        /// <summary>
        /// Restores the last backup for a specific server. This also initiates a restore procedure that will stop the server, restore the backup, and start the server again.
        /// It fails if no backup has been created before.
        /// </summary>
        /// <remarks>We only support one backup right now. If you need more, please get in touch.</remarks>
        /// <param name="serverId">The ID of the server for which to restore the backup.</param>
        /// <returns>True if the backup was successfully restored, false otherwise.</returns>
        public bool RestoreServerBackup(int serverId)
        {
            try
            {
                _apiClientSync.RestoreBackup(serverId, null);
                return true;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        /// <summary>
        /// Restores the last backup for a specific server. This also initiates a restore procedure that will stop the server, restore the backup, and start the server again.
        /// It fails if no backup has been created before.
        /// </summary>
        /// <param name="serverId">The ID of the server to restore the backup for.</param>
        /// <returns>A task representing the asynchronous operation. The task will return true if the backup was restored successfully, or false otherwise.</returns>
        public Task<bool> RestoreServerBackupAsync(int serverId)
        {
            try
            {
                _apiClientAsync.RestoreBackupAsync(serverId, null);
                return Task.FromResult(true);
            }
            catch (HttpRequestException)
            {
                return Task.FromResult(false);
            }
        }

        /// <summary>
        /// Restarts the server with the specified server ID.
        /// </summary>
        /// <param name="serverId">The ID of the server to restart.</param>
        /// <returns>True if the server is successfully restarted; otherwise, false.</returns>
        public bool RestartServer(int serverId)
        {
            try
            {
                _apiClientSync.RestartServer(serverId);
                return true;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        /// <summary>
        /// Restarts the specified server asynchronously.
        /// </summary>
        /// <param name="serverId">The ID of the server to restart.</param>
        /// <returns>Returns a task representing the asynchronous operation. The task will complete with a boolean value indicating whether the server restart was successful or not.</returns>
        public Task<bool> RestartServerAsync(int serverId)
        {
            try
            {
                _apiClientAsync.RestartServerAsync(serverId);
                return Task.FromResult(true);
            }
            catch (HttpRequestException)
            {
                return Task.FromResult(false);
            }
        }
        
        #endregion
    }
}