/* 
 * Phone.com API
 *
 * This is a Phone.com api Swagger definition
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apisupport@phone.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
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
    public interface IAccountsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve details of an individual account
        /// </summary>
        /// <remarks>
        /// This service shows the details of an individual account. See Accounts for more info on the properties.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <returns>AccountFull</returns>
        AccountFull GetAccount (int? accountId);

        /// <summary>
        /// Retrieve details of an individual account
        /// </summary>
        /// <remarks>
        /// This service shows the details of an individual account. See Accounts for more info on the properties.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <returns>ApiResponse of AccountFull</returns>
        ApiResponse<AccountFull> GetAccountWithHttpInfo (int? accountId);
        /// <summary>
        /// Get a list of accounts visible to the authenticated user or client
        /// </summary>
        /// <remarks>
        /// This service lists the accounts accessible to the authenticated client. In most cases, there will only be one such account. See Accounts for more info on the properties.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filtersId">ID filter (optional)</param>
        /// <param name="sortId">ID sorting (optional)</param>
        /// <param name="limit">Max results (optional)</param>
        /// <param name="offset">Results to skip (optional)</param>
        /// <param name="fields">Field set (optional)</param>
        /// <returns>ListAccounts</returns>
        ListAccounts ListAccounts (List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null);

        /// <summary>
        /// Get a list of accounts visible to the authenticated user or client
        /// </summary>
        /// <remarks>
        /// This service lists the accounts accessible to the authenticated client. In most cases, there will only be one such account. See Accounts for more info on the properties.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filtersId">ID filter (optional)</param>
        /// <param name="sortId">ID sorting (optional)</param>
        /// <param name="limit">Max results (optional)</param>
        /// <param name="offset">Results to skip (optional)</param>
        /// <param name="fields">Field set (optional)</param>
        /// <returns>ApiResponse of ListAccounts</returns>
        ApiResponse<ListAccounts> ListAccountsWithHttpInfo (List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve details of an individual account
        /// </summary>
        /// <remarks>
        /// This service shows the details of an individual account. See Accounts for more info on the properties.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <returns>Task of AccountFull</returns>
        System.Threading.Tasks.Task<AccountFull> GetAccountAsync (int? accountId);

        /// <summary>
        /// Retrieve details of an individual account
        /// </summary>
        /// <remarks>
        /// This service shows the details of an individual account. See Accounts for more info on the properties.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <returns>Task of ApiResponse (AccountFull)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountFull>> GetAccountAsyncWithHttpInfo (int? accountId);
        /// <summary>
        /// Get a list of accounts visible to the authenticated user or client
        /// </summary>
        /// <remarks>
        /// This service lists the accounts accessible to the authenticated client. In most cases, there will only be one such account. See Accounts for more info on the properties.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filtersId">ID filter (optional)</param>
        /// <param name="sortId">ID sorting (optional)</param>
        /// <param name="limit">Max results (optional)</param>
        /// <param name="offset">Results to skip (optional)</param>
        /// <param name="fields">Field set (optional)</param>
        /// <returns>Task of ListAccounts</returns>
        System.Threading.Tasks.Task<ListAccounts> ListAccountsAsync (List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null);

        /// <summary>
        /// Get a list of accounts visible to the authenticated user or client
        /// </summary>
        /// <remarks>
        /// This service lists the accounts accessible to the authenticated client. In most cases, there will only be one such account. See Accounts for more info on the properties.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filtersId">ID filter (optional)</param>
        /// <param name="sortId">ID sorting (optional)</param>
        /// <param name="limit">Max results (optional)</param>
        /// <param name="offset">Results to skip (optional)</param>
        /// <param name="fields">Field set (optional)</param>
        /// <returns>Task of ApiResponse (ListAccounts)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListAccounts>> ListAccountsAsyncWithHttpInfo (List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountsApi : IAccountsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

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
        /// Retrieve details of an individual account This service shows the details of an individual account. See Accounts for more info on the properties.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <returns>AccountFull</returns>
        public AccountFull GetAccount (int? accountId)
        {
             ApiResponse<AccountFull> localVarResponse = GetAccountWithHttpInfo(accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve details of an individual account This service shows the details of an individual account. See Accounts for more info on the properties.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <returns>ApiResponse of AccountFull</returns>
        public ApiResponse< AccountFull > GetAccountWithHttpInfo (int? accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling AccountsApi->GetAccount");

            var localVarPath = "/accounts/{account_id}";
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
            if (accountId != null) localVarPathParams.Add("account_id", Configuration.ApiClient.ParameterToString(accountId)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountFull>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountFull) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountFull)));
            
        }

        /// <summary>
        /// Retrieve details of an individual account This service shows the details of an individual account. See Accounts for more info on the properties.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <returns>Task of AccountFull</returns>
        public async System.Threading.Tasks.Task<AccountFull> GetAccountAsync (int? accountId)
        {
             ApiResponse<AccountFull> localVarResponse = await GetAccountAsyncWithHttpInfo(accountId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve details of an individual account This service shows the details of an individual account. See Accounts for more info on the properties.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Account ID</param>
        /// <returns>Task of ApiResponse (AccountFull)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountFull>> GetAccountAsyncWithHttpInfo (int? accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling AccountsApi->GetAccount");

            var localVarPath = "/accounts/{account_id}";
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
            if (accountId != null) localVarPathParams.Add("account_id", Configuration.ApiClient.ParameterToString(accountId)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAccount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountFull>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountFull) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountFull)));
            
        }

        /// <summary>
        /// Get a list of accounts visible to the authenticated user or client This service lists the accounts accessible to the authenticated client. In most cases, there will only be one such account. See Accounts for more info on the properties.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filtersId">ID filter (optional)</param>
        /// <param name="sortId">ID sorting (optional)</param>
        /// <param name="limit">Max results (optional)</param>
        /// <param name="offset">Results to skip (optional)</param>
        /// <param name="fields">Field set (optional)</param>
        /// <returns>ListAccounts</returns>
        public ListAccounts ListAccounts (List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null)
        {
             ApiResponse<ListAccounts> localVarResponse = ListAccountsWithHttpInfo(filtersId, sortId, limit, offset, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of accounts visible to the authenticated user or client This service lists the accounts accessible to the authenticated client. In most cases, there will only be one such account. See Accounts for more info on the properties.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filtersId">ID filter (optional)</param>
        /// <param name="sortId">ID sorting (optional)</param>
        /// <param name="limit">Max results (optional)</param>
        /// <param name="offset">Results to skip (optional)</param>
        /// <param name="fields">Field set (optional)</param>
        /// <returns>ApiResponse of ListAccounts</returns>
        public ApiResponse< ListAccounts > ListAccountsWithHttpInfo (List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null)
        {

            var localVarPath = "/accounts";
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
            if (filtersId != null) localVarQueryParams.Add("filters[id]", Configuration.ApiClient.ParameterToString(filtersId)); // query parameter
            if (sortId != null) localVarQueryParams.Add("sort[id]", Configuration.ApiClient.ParameterToString(sortId)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccounts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListAccounts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListAccounts) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListAccounts)));
            
        }

        /// <summary>
        /// Get a list of accounts visible to the authenticated user or client This service lists the accounts accessible to the authenticated client. In most cases, there will only be one such account. See Accounts for more info on the properties.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filtersId">ID filter (optional)</param>
        /// <param name="sortId">ID sorting (optional)</param>
        /// <param name="limit">Max results (optional)</param>
        /// <param name="offset">Results to skip (optional)</param>
        /// <param name="fields">Field set (optional)</param>
        /// <returns>Task of ListAccounts</returns>
        public async System.Threading.Tasks.Task<ListAccounts> ListAccountsAsync (List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null)
        {
             ApiResponse<ListAccounts> localVarResponse = await ListAccountsAsyncWithHttpInfo(filtersId, sortId, limit, offset, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of accounts visible to the authenticated user or client This service lists the accounts accessible to the authenticated client. In most cases, there will only be one such account. See Accounts for more info on the properties.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filtersId">ID filter (optional)</param>
        /// <param name="sortId">ID sorting (optional)</param>
        /// <param name="limit">Max results (optional)</param>
        /// <param name="offset">Results to skip (optional)</param>
        /// <param name="fields">Field set (optional)</param>
        /// <returns>Task of ApiResponse (ListAccounts)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListAccounts>> ListAccountsAsyncWithHttpInfo (List<string> filtersId = null, string sortId = null, int? limit = null, int? offset = null, string fields = null)
        {

            var localVarPath = "/accounts";
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
            if (filtersId != null) localVarQueryParams.Add("filters[id]", Configuration.ApiClient.ParameterToString(filtersId)); // query parameter
            if (sortId != null) localVarQueryParams.Add("sort[id]", Configuration.ApiClient.ParameterToString(sortId)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListAccounts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ListAccounts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListAccounts) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListAccounts)));
            
        }

    }
}