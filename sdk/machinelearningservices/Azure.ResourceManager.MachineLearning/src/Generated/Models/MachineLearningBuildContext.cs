// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Configuration settings for Docker build context. </summary>
    public partial class MachineLearningBuildContext
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningBuildContext"/>. </summary>
        /// <param name="contextUri">
        /// [Required] URI of the Docker build context used to build the image. Supports blob URIs on environment creation and may return blob or Git URIs.
        /// &lt;seealso href="https://docs.docker.com/engine/reference/commandline/build/#extended-description" /&gt;
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="contextUri"/> is null. </exception>
        public MachineLearningBuildContext(Uri contextUri)
        {
            Argument.AssertNotNull(contextUri, nameof(contextUri));

            ContextUri = contextUri;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningBuildContext"/>. </summary>
        /// <param name="contextUri">
        /// [Required] URI of the Docker build context used to build the image. Supports blob URIs on environment creation and may return blob or Git URIs.
        /// &lt;seealso href="https://docs.docker.com/engine/reference/commandline/build/#extended-description" /&gt;
        /// </param>
        /// <param name="dockerfilePath">
        /// Path to the Dockerfile in the build context.
        /// &lt;seealso href="https://docs.docker.com/engine/reference/builder/" /&gt;
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningBuildContext(Uri contextUri, string dockerfilePath, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContextUri = contextUri;
            DockerfilePath = dockerfilePath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningBuildContext"/> for deserialization. </summary>
        internal MachineLearningBuildContext()
        {
        }

        /// <summary>
        /// [Required] URI of the Docker build context used to build the image. Supports blob URIs on environment creation and may return blob or Git URIs.
        /// &lt;seealso href="https://docs.docker.com/engine/reference/commandline/build/#extended-description" /&gt;
        /// </summary>
        public Uri ContextUri { get; set; }
        /// <summary>
        /// Path to the Dockerfile in the build context.
        /// &lt;seealso href="https://docs.docker.com/engine/reference/builder/" /&gt;
        /// </summary>
        public string DockerfilePath { get; set; }
    }
}
