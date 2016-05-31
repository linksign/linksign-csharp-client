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
    public interface ISignatureApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </summary>
        /// <remarks>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5BA2\u6237\u7F16\u53F7</param>
        /// <param name="body"> (optional)</param>
        /// <returns>SignatureSummary</returns>
        SignatureSummary CreateSignature (string clientId, Signature body = null);
  
        /// <summary>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </summary>
        /// <remarks>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5BA2\u6237\u7F16\u53F7</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SignatureSummary</returns>
        ApiResponse<SignatureSummary> CreateSignatureWithHttpInfo (string clientId, Signature body = null);
        
        /// <summary>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5E94\u7528\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="signatureId">\u7B7E\u540D\u7F16\u53F7</param>
        /// <returns>SignatureFile</returns>
        SignatureFile GetSignature (string clientId, string signatureId);
  
        /// <summary>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5E94\u7528\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="signatureId">\u7B7E\u540D\u7F16\u53F7</param>
        /// <returns>ApiResponse of SignatureFile</returns>
        ApiResponse<SignatureFile> GetSignatureWithHttpInfo (string clientId, string signatureId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </summary>
        /// <remarks>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5BA2\u6237\u7F16\u53F7</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SignatureSummary</returns>
        System.Threading.Tasks.Task<SignatureSummary> CreateSignatureAsync (string clientId, Signature body = null);

        /// <summary>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </summary>
        /// <remarks>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5BA2\u6237\u7F16\u53F7</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SignatureSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<SignatureSummary>> CreateSignatureAsyncWithHttpInfo (string clientId, Signature body = null);
        
        /// <summary>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5E94\u7528\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="signatureId">\u7B7E\u540D\u7F16\u53F7</param>
        /// <returns>Task of SignatureFile</returns>
        System.Threading.Tasks.Task<SignatureFile> GetSignatureAsync (string clientId, string signatureId);

        /// <summary>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5E94\u7528\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="signatureId">\u7B7E\u540D\u7F16\u53F7</param>
        /// <returns>Task of ApiResponse (SignatureFile)</returns>
        System.Threading.Tasks.Task<ApiResponse<SignatureFile>> GetSignatureAsyncWithHttpInfo (string clientId, string signatureId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SignatureApi : ISignatureApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SignatureApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SignatureApi(Configuration configuration = null)
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
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42 \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5BA2\u6237\u7F16\u53F7</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>SignatureSummary</returns>
        public SignatureSummary CreateSignature (string clientId, Signature body = null)
        {
             ApiResponse<SignatureSummary> localVarResponse = CreateSignatureWithHttpInfo(clientId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42 \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5BA2\u6237\u7F16\u53F7</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of SignatureSummary</returns>
        public ApiResponse< SignatureSummary > CreateSignatureWithHttpInfo (string clientId, Signature body = null)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling SignatureApi->CreateSignature");
            
    
            var localVarPath = "/clients/{clientId}/signatures";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateSignature: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateSignature: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SignatureSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SignatureSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignatureSummary)));
            
        }

        
        /// <summary>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42 \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5BA2\u6237\u7F16\u53F7</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SignatureSummary</returns>
        public async System.Threading.Tasks.Task<SignatureSummary> CreateSignatureAsync (string clientId, Signature body = null)
        {
             ApiResponse<SignatureSummary> localVarResponse = await CreateSignatureAsyncWithHttpInfo(clientId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42 \u65B0\u5EFA\u4E00\u4E2A\u7B7E\u540D\u6536\u96C6\u8BF7\u6C42
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5BA2\u6237\u7F16\u53F7</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SignatureSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SignatureSummary>> CreateSignatureAsyncWithHttpInfo (string clientId, Signature body = null)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling CreateSignature");
            
    
            var localVarPath = "/clients/{clientId}/signatures";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateSignature: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateSignature: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SignatureSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SignatureSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignatureSummary)));
            
        }
        
        /// <summary>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247 \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5E94\u7528\u7CFB\u7EDF\u7F16\u53F7</param> 
        /// <param name="signatureId">\u7B7E\u540D\u7F16\u53F7</param> 
        /// <returns>SignatureFile</returns>
        public SignatureFile GetSignature (string clientId, string signatureId)
        {
             ApiResponse<SignatureFile> localVarResponse = GetSignatureWithHttpInfo(clientId, signatureId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247 \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5E94\u7528\u7CFB\u7EDF\u7F16\u53F7</param> 
        /// <param name="signatureId">\u7B7E\u540D\u7F16\u53F7</param> 
        /// <returns>ApiResponse of SignatureFile</returns>
        public ApiResponse< SignatureFile > GetSignatureWithHttpInfo (string clientId, string signatureId)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling SignatureApi->GetSignature");
            
            // verify the required parameter 'signatureId' is set
            if (signatureId == null)
                throw new ApiException(400, "Missing required parameter 'signatureId' when calling SignatureApi->GetSignature");
            
    
            var localVarPath = "/clients/{clientId}/signatures/{signatureId}";
    
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
            if (signatureId != null) localVarPathParams.Add("signatureId", Configuration.ApiClient.ParameterToString(signatureId)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSignature: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSignature: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SignatureFile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SignatureFile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignatureFile)));
            
        }

        
        /// <summary>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247 \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5E94\u7528\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="signatureId">\u7B7E\u540D\u7F16\u53F7</param>
        /// <returns>Task of SignatureFile</returns>
        public async System.Threading.Tasks.Task<SignatureFile> GetSignatureAsync (string clientId, string signatureId)
        {
             ApiResponse<SignatureFile> localVarResponse = await GetSignatureAsyncWithHttpInfo(clientId, signatureId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247 \u83B7\u53D6\u7B7E\u7F72\u56FE\u7247
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">\u5E94\u7528\u7CFB\u7EDF\u7F16\u53F7</param>
        /// <param name="signatureId">\u7B7E\u540D\u7F16\u53F7</param>
        /// <returns>Task of ApiResponse (SignatureFile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SignatureFile>> GetSignatureAsyncWithHttpInfo (string clientId, string signatureId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling GetSignature");
            // verify the required parameter 'signatureId' is set
            if (signatureId == null) throw new ApiException(400, "Missing required parameter 'signatureId' when calling GetSignature");
            
    
            var localVarPath = "/clients/{clientId}/signatures/{signatureId}";
    
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
            if (signatureId != null) localVarPathParams.Add("signatureId", Configuration.ApiClient.ParameterToString(signatureId)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetSignature: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSignature: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SignatureFile>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SignatureFile) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignatureFile)));
            
        }
        
    }
    
}
