// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Storage container properties. </summary>
    public partial class StorageContainerProperties
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

        /// <summary> Initializes a new instance of <see cref="StorageContainerProperties"/>. </summary>
        /// <param name="name"> Gets or sets the Name. </param>
        /// <param name="clusterSharedVolumePath"> Gets or sets the ClusterSharedVolumePath. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="clusterSharedVolumePath"/> is null. </exception>
        public StorageContainerProperties(string name, string clusterSharedVolumePath)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(clusterSharedVolumePath, nameof(clusterSharedVolumePath));

            Name = name;
            ClusterSharedVolumePath = clusterSharedVolumePath;
        }

        /// <summary> Initializes a new instance of <see cref="StorageContainerProperties"/>. </summary>
        /// <param name="name"> Gets or sets the Name. </param>
        /// <param name="clusterSharedVolumePath"> Gets or sets the ClusterSharedVolumePath. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageContainerProperties(string name, string clusterSharedVolumePath, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ClusterSharedVolumePath = clusterSharedVolumePath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageContainerProperties"/> for deserialization. </summary>
        internal StorageContainerProperties()
        {
        }

        /// <summary> Gets or sets the Name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the ClusterSharedVolumePath. </summary>
        public string ClusterSharedVolumePath { get; set; }
    }
}
