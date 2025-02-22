// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Returns the requested Docker V2 Manifest file. </summary>
    internal partial class V2Manifest : Manifest
    {
        /// <summary> Initializes a new instance of <see cref="V2Manifest"/>. </summary>
        internal V2Manifest()
        {
            Layers = new ChangeTrackingList<OciDescriptor>();
        }

        /// <summary> Initializes a new instance of <see cref="V2Manifest"/>. </summary>
        /// <param name="schemaVersion"> Schema version. </param>
        /// <param name="mediaType"> Media type for this Manifest. </param>
        /// <param name="config"> V2 image config descriptor. </param>
        /// <param name="layers"> List of V2 image layer information. </param>
        internal V2Manifest(int? schemaVersion, string mediaType, OciDescriptor config, IReadOnlyList<OciDescriptor> layers) : base(schemaVersion)
        {
            MediaType = mediaType;
            Config = config;
            Layers = layers;
        }

        /// <summary> Media type for this Manifest. </summary>
        public string MediaType { get; }
        /// <summary> V2 image config descriptor. </summary>
        public OciDescriptor Config { get; }
        /// <summary> List of V2 image layer information. </summary>
        public IReadOnlyList<OciDescriptor> Layers { get; }
    }
}
