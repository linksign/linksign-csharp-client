using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISealApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <remarks>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>SealSummary</returns>
        SealSummary CreateSeal (string clientId, Seal body = null);
  
        /// <summary>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <remarks>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SealSummary</returns>
        ApiResponse<SealSummary> CreateSealWithHttpInfo (string clientId, Seal body = null);
        
        /// <summary>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="sealId">\u5370\u7AE0\u7F16\u53F7</param>
        /// <returns>SealFile</returns>
        SealFile GetSeal (string clientId, string sealId);
  
        /// <summary>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="sealId">\u5370\u7AE0\u7F16\u53F7</param>
        /// <returns>ApiResponse of SealFile</returns>
        ApiResponse<SealFile> GetSealWithHttpInfo (string clientId, string sealId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <remarks>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SealSummary</returns>
        System.Threading.Tasks.Task<SealSummary> CreateSealAsync (string clientId, Seal body = null);

        /// <summary>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <remarks>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SealSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<SealSummary>> CreateSealAsyncWithHttpInfo (string clientId, Seal body = null);
        
        /// <summary>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="sealId">\u5370\u7AE0\u7F16\u53F7</param>
        /// <returns>Task of SealFile</returns>
        System.Threading.Tasks.Task<SealFile> GetSealAsync (string clientId, string sealId);

        /// <summary>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="sealId">\u5370\u7AE0\u7F16\u53F7</param>
        /// <returns>Task of ApiResponse (SealFile)</returns>
        System.Threading.Tasks.Task<ApiResponse<SealFile>> GetSealAsyncWithHttpInfo (string clientId, string sealId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SealApi : ISealApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SealApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SealApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SealApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SealApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0 \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>SealSummary</returns>
        public SealSummary CreateSeal (string clientId, Seal body = null)
        {
             ApiResponse<SealSummary> localVarResponse = CreateSealWithHttpInfo(clientId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0 \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of SealSummary</returns>
        public ApiResponse< SealSummary > CreateSealWithHttpInfo (string clientId, Seal body = null)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling SealApi->CreateSeal");
            
    
            var localVarPath = "/clients/{clientId}/seals";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateSeal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateSeal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SealSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SealSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SealSummary)));
            
        }

        
        /// <summary>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0 \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SealSummary</returns>
        public async System.Threading.Tasks.Task<SealSummary> CreateSealAsync (string clientId, Seal body = null)
        {
             ApiResponse<SealSummary> localVarResponse = await CreateSealAsyncWithHttpInfo(clientId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0 \u521B\u5EFA\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SealSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SealSummary>> CreateSealAsyncWithHttpInfo (string clientId, Seal body = null)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling CreateSeal");
            
    
            var localVarPath = "/clients/{clientId}/seals";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateSeal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateSeal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SealSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SealSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SealSummary)));
            
        }
        
        /// <summary>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0 \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u7CFB\u7EDF\u7F16\u53F7</param> 
        /// <param name="sealId">\u5370\u7AE0\u7F16\u53F7</param> 
        /// <returns>SealFile</returns>
        public SealFile GetSeal (string clientId, string sealId)
        {
             ApiResponse<SealFile> localVarResponse = GetSealWithHttpInfo(clientId, sealId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0 \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u7CFB\u7EDF\u7F16\u53F7</param> 
        /// <param name="sealId">\u5370\u7AE0\u7F16\u53F7</param> 
        /// <returns>ApiResponse of SealFile</returns>
        public ApiResponse< SealFile > GetSealWithHttpInfo (string clientId, string sealId)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling SealApi->GetSeal");
            
            // verify the required parameter 'sealId' is set
            if (sealId == null)
                throw new ApiException(400, "Missing required parameter 'sealId' when calling SealApi->GetSeal");
            
    
            var localVarPath = "/clients/{clientId}/seals/{sealId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (sealId != null) localVarPathParams.Add("sealId", Configuration.ApiClient.ParameterToString(sealId)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSeal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSeal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SealFile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SealFile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SealFile)));
            
        }

        
        /// <summary>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0 \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="sealId">\u5370\u7AE0\u7F16\u53F7</param>
        /// <returns>Task of SealFile</returns>
        public async System.Threading.Tasks.Task<SealFile> GetSealAsync (string clientId, string sealId)
        {
             ApiResponse<SealFile> localVarResponse = await GetSealAsyncWithHttpInfo(clientId, sealId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0 \u83B7\u53D6\u4E00\u4E2A\u5370\u7AE0
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="sealId">\u5370\u7AE0\u7F16\u53F7</param>
        /// <returns>Task of ApiResponse (SealFile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SealFile>> GetSealAsyncWithHttpInfo (string clientId, string sealId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling GetSeal");
            // verify the required parameter 'sealId' is set
            if (sealId == null) throw new ApiException(400, "Missing required parameter 'sealId' when calling GetSeal");
            
    
            var localVarPath = "/clients/{clientId}/seals/{sealId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (sealId != null) localVarPathParams.Add("sealId", Configuration.ApiClient.ParameterToString(sealId)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSeal: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSeal: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SealFile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SealFile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SealFile)));
            
        }
        
    }
    
}
