// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for Salesforce. </summary>
    public partial class SalesforceLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of SalesforceLinkedService. </summary>
        public SalesforceLinkedService()
        {
            Type = "Salesforce";
        }

        /// <summary> Initializes a new instance of SalesforceLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="environmentUrl"> The URL of Salesforce instance. Default is &apos;https://login.salesforce.com&apos;. To copy data from sandbox, specify &apos;https://test.salesforce.com&apos;. To copy data from custom domain, specify, for example, &apos;https://[domain].my.salesforce.com&apos;. Type: string (or Expression with resultType string). </param>
        /// <param name="username"> The username for Basic authentication of the Salesforce instance. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password for Basic authentication of the Salesforce instance. </param>
        /// <param name="securityToken"> The security token is optional to remotely access Salesforce instance. </param>
        /// <param name="apiVersion"> The Salesforce API version used in ADF. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal SalesforceLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object environmentUrl, object username, SecretBase password, SecretBase securityToken, object apiVersion, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            EnvironmentUrl = environmentUrl;
            Username = username;
            Password = password;
            SecurityToken = securityToken;
            ApiVersion = apiVersion;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Salesforce";
        }

        /// <summary> The URL of Salesforce instance. Default is &apos;https://login.salesforce.com&apos;. To copy data from sandbox, specify &apos;https://test.salesforce.com&apos;. To copy data from custom domain, specify, for example, &apos;https://[domain].my.salesforce.com&apos;. Type: string (or Expression with resultType string). </summary>
        public object EnvironmentUrl { get; set; }
        /// <summary> The username for Basic authentication of the Salesforce instance. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary> The password for Basic authentication of the Salesforce instance. </summary>
        public SecretBase Password { get; set; }
        /// <summary> The security token is optional to remotely access Salesforce instance. </summary>
        public SecretBase SecurityToken { get; set; }
        /// <summary> The Salesforce API version used in ADF. Type: string (or Expression with resultType string). </summary>
        public object ApiVersion { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
