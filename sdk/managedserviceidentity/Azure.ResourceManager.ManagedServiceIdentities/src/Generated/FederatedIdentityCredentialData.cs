// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    /// <summary>
    /// A class representing the FederatedIdentityCredential data model.
    /// Describes a federated identity credential.
    /// </summary>
    public partial class FederatedIdentityCredentialData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FederatedIdentityCredentialData"/>. </summary>
        public FederatedIdentityCredentialData()
        {
            Audiences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FederatedIdentityCredentialData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="issuerUri"> The URL of the issuer to be trusted. </param>
        /// <param name="subject"> The identifier of the external identity. </param>
        /// <param name="audiences"> The list of audiences that can appear in the issued token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FederatedIdentityCredentialData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri issuerUri, string subject, IList<string> audiences, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            IssuerUri = issuerUri;
            Subject = subject;
            Audiences = audiences;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The URL of the issuer to be trusted. </summary>
        public Uri IssuerUri { get; set; }
        /// <summary> The identifier of the external identity. </summary>
        public string Subject { get; set; }
        /// <summary> The list of audiences that can appear in the issued token. </summary>
        public IList<string> Audiences { get; }
    }
}
