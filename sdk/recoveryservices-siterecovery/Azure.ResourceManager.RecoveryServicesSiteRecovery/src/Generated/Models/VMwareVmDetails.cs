// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMware provider specific settings. </summary>
    public partial class VMwareVmDetails : SiteRecoveryReplicationProviderSettings
    {
        /// <summary> Initializes a new instance of <see cref="VMwareVmDetails"/>. </summary>
        internal VMwareVmDetails()
        {
            DiskDetails = new ChangeTrackingList<InMageDiskDetails>();
            ValidationErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
            InstanceType = "VMwareVirtualMachine";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareVmDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="agentGeneratedId"> The ID generated by the InMage agent after it gets installed on guest. This is the ID to be used during InMage CreateProtection. </param>
        /// <param name="agentInstalled"> The value indicating if InMage scout agent is installed on guest. </param>
        /// <param name="osType"> The OsType installed on VM. </param>
        /// <param name="agentVersion"> The agent version. </param>
        /// <param name="ipAddress"> The IP address. </param>
        /// <param name="poweredOn"> The value indicating whether VM is powered on. </param>
        /// <param name="vCenterInfrastructureId"> The VCenter infrastructure Id. </param>
        /// <param name="discoveryType"> A value indicating the discovery type of the machine. Value can be vCenter or physical. </param>
        /// <param name="diskDetails"> The disk details. </param>
        /// <param name="validationErrors"> The validation errors. </param>
        internal VMwareVmDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string agentGeneratedId, string agentInstalled, string osType, string agentVersion, IPAddress ipAddress, string poweredOn, string vCenterInfrastructureId, string discoveryType, IReadOnlyList<InMageDiskDetails> diskDetails, IReadOnlyList<SiteRecoveryHealthError> validationErrors) : base(instanceType, serializedAdditionalRawData)
        {
            AgentGeneratedId = agentGeneratedId;
            AgentInstalled = agentInstalled;
            OSType = osType;
            AgentVersion = agentVersion;
            IPAddress = ipAddress;
            PoweredOn = poweredOn;
            VCenterInfrastructureId = vCenterInfrastructureId;
            DiscoveryType = discoveryType;
            DiskDetails = diskDetails;
            ValidationErrors = validationErrors;
            InstanceType = instanceType ?? "VMwareVirtualMachine";
        }

        /// <summary> The ID generated by the InMage agent after it gets installed on guest. This is the ID to be used during InMage CreateProtection. </summary>
        public string AgentGeneratedId { get; }
        /// <summary> The value indicating if InMage scout agent is installed on guest. </summary>
        public string AgentInstalled { get; }
        /// <summary> The OsType installed on VM. </summary>
        public string OSType { get; }
        /// <summary> The agent version. </summary>
        public string AgentVersion { get; }
        /// <summary> The IP address. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The value indicating whether VM is powered on. </summary>
        public string PoweredOn { get; }
        /// <summary> The VCenter infrastructure Id. </summary>
        public string VCenterInfrastructureId { get; }
        /// <summary> A value indicating the discovery type of the machine. Value can be vCenter or physical. </summary>
        public string DiscoveryType { get; }
        /// <summary> The disk details. </summary>
        public IReadOnlyList<InMageDiskDetails> DiskDetails { get; }
        /// <summary> The validation errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> ValidationErrors { get; }
    }
}
