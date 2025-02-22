// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> IoT Central Application Template. </summary>
    public partial class IotCentralAppTemplate
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

        /// <summary> Initializes a new instance of <see cref="IotCentralAppTemplate"/>. </summary>
        internal IotCentralAppTemplate()
        {
            Locations = new ChangeTrackingList<IotCentralAppTemplateLocation>();
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralAppTemplate"/>. </summary>
        /// <param name="manifestId"> The ID of the template. </param>
        /// <param name="manifestVersion"> The version of the template. </param>
        /// <param name="name"> The name of the template. </param>
        /// <param name="title"> The title of the template. </param>
        /// <param name="order"> The order of the template in the templates list. </param>
        /// <param name="description"> The description of the template. </param>
        /// <param name="industry"> The industry of the template. </param>
        /// <param name="locations"> A list of locations that support the template. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotCentralAppTemplate(string manifestId, string manifestVersion, string name, string title, int? order, string description, string industry, IReadOnlyList<IotCentralAppTemplateLocation> locations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ManifestId = manifestId;
            ManifestVersion = manifestVersion;
            Name = name;
            Title = title;
            Order = order;
            Description = description;
            Industry = industry;
            Locations = locations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the template. </summary>
        public string ManifestId { get; }
        /// <summary> The version of the template. </summary>
        public string ManifestVersion { get; }
        /// <summary> The name of the template. </summary>
        public string Name { get; }
        /// <summary> The title of the template. </summary>
        public string Title { get; }
        /// <summary> The order of the template in the templates list. </summary>
        public int? Order { get; }
        /// <summary> The description of the template. </summary>
        public string Description { get; }
        /// <summary> The industry of the template. </summary>
        public string Industry { get; }
        /// <summary> A list of locations that support the template. </summary>
        public IReadOnlyList<IotCentralAppTemplateLocation> Locations { get; }
    }
}
