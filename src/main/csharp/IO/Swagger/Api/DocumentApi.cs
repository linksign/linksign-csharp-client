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
    public interface IDocumentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6\u7B7E\u7F72\u72B6\u6001\u3001URI
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>DocumentStatus</returns>
        DocumentStatus ClientsClientIdDocumentsDocumentIdStatusGet (string clientId, string documentId);
  
        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6\u7B7E\u7F72\u72B6\u6001\u3001URI
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>ApiResponse of DocumentStatus</returns>
        ApiResponse<DocumentStatus> ClientsClientIdDocumentsDocumentIdStatusGetWithHttpInfo (string clientId, string documentId);
        
        /// <summary>
        /// \u7B7E\u7F72\u6587\u4EF6
        /// </summary>
        /// <remarks>
        /// \u7B7E\u7F72\u6587\u4EF6
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>DocumentSummary</returns>
        DocumentSummary CreateDocument (string clientId, DocumentDefinition body = null);
  
        /// <summary>
        /// \u7B7E\u7F72\u6587\u4EF6
        /// </summary>
        /// <remarks>
        /// \u7B7E\u7F72\u6587\u4EF6
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of DocumentSummary</returns>
        ApiResponse<DocumentSummary> CreateDocumentWithHttpInfo (string clientId, DocumentDefinition body = null);
        
        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u6587\u4EF6
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>ByteArray</returns>
        ByteArray GetDocument (string clientId, string documentId);
  
        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u6587\u4EF6
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>ApiResponse of ByteArray</returns>
        ApiResponse<ByteArray> GetDocumentWithHttpInfo (string clientId, string documentId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6\u7B7E\u7F72\u72B6\u6001\u3001URI
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>Task of DocumentStatus</returns>
        System.Threading.Tasks.Task<DocumentStatus> ClientsClientIdDocumentsDocumentIdStatusGetAsync (string clientId, string documentId);

        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6\u7B7E\u7F72\u72B6\u6001\u3001URI
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>Task of ApiResponse (DocumentStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentStatus>> ClientsClientIdDocumentsDocumentIdStatusGetAsyncWithHttpInfo (string clientId, string documentId);
        
        /// <summary>
        /// \u7B7E\u7F72\u6587\u4EF6
        /// </summary>
        /// <remarks>
        /// \u7B7E\u7F72\u6587\u4EF6
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DocumentSummary</returns>
        System.Threading.Tasks.Task<DocumentSummary> CreateDocumentAsync (string clientId, DocumentDefinition body = null);

        /// <summary>
        /// \u7B7E\u7F72\u6587\u4EF6
        /// </summary>
        /// <remarks>
        /// \u7B7E\u7F72\u6587\u4EF6
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentSummary>> CreateDocumentAsyncWithHttpInfo (string clientId, DocumentDefinition body = null);
        
        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u6587\u4EF6
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>Task of ByteArray</returns>
        System.Threading.Tasks.Task<ByteArray> GetDocumentAsync (string clientId, string documentId);

        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6
        /// </summary>
        /// <remarks>
        /// \u83B7\u53D6\u6587\u4EF6
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>Task of ApiResponse (ByteArray)</returns>
        System.Threading.Tasks.Task<ApiResponse<ByteArray>> GetDocumentAsyncWithHttpInfo (string clientId, string documentId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DocumentApi : IDocumentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocumentApi(Configuration configuration = null)
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
        /// \u83B7\u53D6\u6587\u4EF6\u7B7E\u7F72\u72B6\u6001\u3001URI 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param> 
        /// <param name="documentId"></param> 
        /// <returns>DocumentStatus</returns>
        public DocumentStatus ClientsClientIdDocumentsDocumentIdStatusGet (string clientId, string documentId)
        {
             ApiResponse<DocumentStatus> localVarResponse = ClientsClientIdDocumentsDocumentIdStatusGetWithHttpInfo(clientId, documentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6\u7B7E\u7F72\u72B6\u6001\u3001URI 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param> 
        /// <param name="documentId"></param> 
        /// <returns>ApiResponse of DocumentStatus</returns>
        public ApiResponse< DocumentStatus > ClientsClientIdDocumentsDocumentIdStatusGetWithHttpInfo (string clientId, string documentId)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling DocumentApi->ClientsClientIdDocumentsDocumentIdStatusGet");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling DocumentApi->ClientsClientIdDocumentsDocumentIdStatusGet");
            
    
            var localVarPath = "/clients/{clientId}/documents/{documentId}/status";
    
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
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ClientsClientIdDocumentsDocumentIdStatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ClientsClientIdDocumentsDocumentIdStatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentStatus)));
            
        }

        
        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6\u7B7E\u7F72\u72B6\u6001\u3001URI 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>Task of DocumentStatus</returns>
        public async System.Threading.Tasks.Task<DocumentStatus> ClientsClientIdDocumentsDocumentIdStatusGetAsync (string clientId, string documentId)
        {
             ApiResponse<DocumentStatus> localVarResponse = await ClientsClientIdDocumentsDocumentIdStatusGetAsyncWithHttpInfo(clientId, documentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6\u7B7E\u7F72\u72B6\u6001\u3001URI 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>Task of ApiResponse (DocumentStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentStatus>> ClientsClientIdDocumentsDocumentIdStatusGetAsyncWithHttpInfo (string clientId, string documentId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling ClientsClientIdDocumentsDocumentIdStatusGet");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ClientsClientIdDocumentsDocumentIdStatusGet");
            
    
            var localVarPath = "/clients/{clientId}/documents/{documentId}/status";
    
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
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ClientsClientIdDocumentsDocumentIdStatusGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ClientsClientIdDocumentsDocumentIdStatusGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentStatus)));
            
        }
        
        /// <summary>
        /// \u7B7E\u7F72\u6587\u4EF6 \u7B7E\u7F72\u6587\u4EF6
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>DocumentSummary</returns>
        public DocumentSummary CreateDocument (string clientId, DocumentDefinition body = null)
        {
             ApiResponse<DocumentSummary> localVarResponse = CreateDocumentWithHttpInfo(clientId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// \u7B7E\u7F72\u6587\u4EF6 \u7B7E\u7F72\u6587\u4EF6
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of DocumentSummary</returns>
        public ApiResponse< DocumentSummary > CreateDocumentWithHttpInfo (string clientId, DocumentDefinition body = null)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling DocumentApi->CreateDocument");
            
    
            var localVarPath = "/clients/{clientId}/documents";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateDocument: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DocumentSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentSummary)));
            
        }

        
        /// <summary>
        /// \u7B7E\u7F72\u6587\u4EF6 \u7B7E\u7F72\u6587\u4EF6
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of DocumentSummary</returns>
        public async System.Threading.Tasks.Task<DocumentSummary> CreateDocumentAsync (string clientId, DocumentDefinition body = null)
        {
             ApiResponse<DocumentSummary> localVarResponse = await CreateDocumentAsyncWithHttpInfo(clientId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// \u7B7E\u7F72\u6587\u4EF6 \u7B7E\u7F72\u6587\u4EF6
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentSummary>> CreateDocumentAsyncWithHttpInfo (string clientId, DocumentDefinition body = null)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling CreateDocument");
            
    
            var localVarPath = "/clients/{clientId}/documents";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateDocument: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DocumentSummary>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentSummary) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentSummary)));
            
        }
        
        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6 \u83B7\u53D6\u6587\u4EF6
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param> 
        /// <param name="documentId"></param> 
        /// <returns>ByteArray</returns>
        public ByteArray GetDocument (string clientId, string documentId)
        {
             ApiResponse<ByteArray> localVarResponse = GetDocumentWithHttpInfo(clientId, documentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6 \u83B7\u53D6\u6587\u4EF6
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param> 
        /// <param name="documentId"></param> 
        /// <returns>ApiResponse of ByteArray</returns>
        public ApiResponse< ByteArray > GetDocumentWithHttpInfo (string clientId, string documentId)
        {
            
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling DocumentApi->GetDocument");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling DocumentApi->GetDocument");
            
    
            var localVarPath = "/clients/{clientId}/documents/{documentId}";
    
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
                "application/pdf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDocument: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ByteArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ByteArray) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ByteArray)));
            
        }

        
        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6 \u83B7\u53D6\u6587\u4EF6
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>Task of ByteArray</returns>
        public async System.Threading.Tasks.Task<ByteArray> GetDocumentAsync (string clientId, string documentId)
        {
             ApiResponse<ByteArray> localVarResponse = await GetDocumentAsyncWithHttpInfo(clientId, documentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// \u83B7\u53D6\u6587\u4EF6 \u83B7\u53D6\u6587\u4EF6
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId"></param>
        /// <param name="documentId"></param>
        /// <returns>Task of ApiResponse (ByteArray)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ByteArray>> GetDocumentAsyncWithHttpInfo (string clientId, string documentId)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null) throw new ApiException(400, "Missing required parameter 'clientId' when calling GetDocument");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocument");
            
    
            var localVarPath = "/clients/{clientId}/documents/{documentId}";
    
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
                "application/pdf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (clientId != null) localVarPathParams.Add("clientId", Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDocument: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDocument: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ByteArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ByteArray) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ByteArray)));
            
        }
        
    }
    
}
