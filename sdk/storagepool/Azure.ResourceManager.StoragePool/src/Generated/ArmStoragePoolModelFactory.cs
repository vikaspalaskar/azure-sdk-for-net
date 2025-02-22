// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.StoragePool;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmStoragePoolModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="StoragePool.DiskPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Determines the SKU of the Disk pool. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="availabilityZones"> Logical zone for Disk Pool resource; example: ["1"]. </param>
        /// <param name="status"> Operational status of the Disk Pool. </param>
        /// <param name="disks"> List of Azure Managed Disks to attach to a Disk Pool. </param>
        /// <param name="subnetId"> Azure Resource ID of a Subnet for the Disk Pool. </param>
        /// <param name="additionalCapabilities"> List of additional capabilities for Disk Pool. </param>
        /// <returns> A new <see cref="StoragePool.DiskPoolData"/> instance for mocking. </returns>
        public static DiskPoolData DiskPoolData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, StoragePoolSku sku = null, string managedBy = null, IEnumerable<string> managedByExtended = null, DiskPoolIscsiTargetProvisioningState provisioningState = default, IEnumerable<string> availabilityZones = null, StoragePoolOperationalStatus status = default, IEnumerable<WritableSubResource> disks = null, ResourceIdentifier subnetId = null, IEnumerable<string> additionalCapabilities = null)
        {
            tags ??= new Dictionary<string, string>();
            managedByExtended ??= new List<string>();
            availabilityZones ??= new List<string>();
            disks ??= new List<WritableSubResource>();
            additionalCapabilities ??= new List<string>();

            return new DiskPoolData(id, name, resourceType, systemData, tags, location, sku, managedBy, managedByExtended?.ToList(), provisioningState, availabilityZones?.ToList(), status, disks?.ToList(), subnetId, additionalCapabilities?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DiskPoolCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Determines the SKU of the Disk Pool. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="availabilityZones"> Logical zone for Disk Pool resource; example: ["1"]. </param>
        /// <param name="disks"> List of Azure Managed Disks to attach to a Disk Pool. </param>
        /// <param name="subnetId"> Azure Resource ID of a Subnet for the Disk Pool. </param>
        /// <param name="additionalCapabilities"> List of additional capabilities for a Disk Pool. </param>
        /// <returns> A new <see cref="Models.DiskPoolCreateOrUpdateContent"/> instance for mocking. </returns>
        public static DiskPoolCreateOrUpdateContent DiskPoolCreateOrUpdateContent(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, StoragePoolSku sku = null, IDictionary<string, string> tags = null, AzureLocation location = default, string managedBy = null, IEnumerable<string> managedByExtended = null, IEnumerable<string> availabilityZones = null, IEnumerable<WritableSubResource> disks = null, ResourceIdentifier subnetId = null, IEnumerable<string> additionalCapabilities = null)
        {
            tags ??= new Dictionary<string, string>();
            managedByExtended ??= new List<string>();
            availabilityZones ??= new List<string>();
            disks ??= new List<WritableSubResource>();
            additionalCapabilities ??= new List<string>();

            return new DiskPoolCreateOrUpdateContent(id, name, resourceType, systemData, sku, tags, location, managedBy, managedByExtended?.ToList(), availabilityZones?.ToList(), disks?.ToList(), subnetId, additionalCapabilities?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DiskPoolZoneInfo"/>. </summary>
        /// <param name="availabilityZones"> Logical zone for Disk Pool resource; example: ["1"]. </param>
        /// <param name="additionalCapabilities"> List of additional capabilities for Disk Pool. </param>
        /// <param name="sku"> Determines the SKU of VM deployed for Disk Pool. </param>
        /// <returns> A new <see cref="Models.DiskPoolZoneInfo"/> instance for mocking. </returns>
        public static DiskPoolZoneInfo DiskPoolZoneInfo(IEnumerable<string> availabilityZones = null, IEnumerable<string> additionalCapabilities = null, StoragePoolSku sku = null)
        {
            availabilityZones ??= new List<string>();
            additionalCapabilities ??= new List<string>();

            return new DiskPoolZoneInfo(availabilityZones?.ToList(), additionalCapabilities?.ToList(), sku, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StoragePoolSkuInfo"/>. </summary>
        /// <param name="apiVersion"> StoragePool RP API version. </param>
        /// <param name="resourceType"> StoragePool resource type. </param>
        /// <param name="capabilities"> List of additional capabilities for StoragePool resource. </param>
        /// <param name="locationInfo"> Zones and zone capabilities in those locations where the SKU is available. </param>
        /// <param name="name"> Sku name. </param>
        /// <param name="tier"> Sku tier. </param>
        /// <param name="restrictions"> The restrictions because of which SKU cannot be used. This is empty if there are no restrictions. </param>
        /// <returns> A new <see cref="Models.StoragePoolSkuInfo"/> instance for mocking. </returns>
        public static StoragePoolSkuInfo StoragePoolSkuInfo(string apiVersion = null, string resourceType = null, IEnumerable<StoragePoolSkuCapability> capabilities = null, StoragePoolSkuLocationInfo locationInfo = null, string name = null, string tier = null, IEnumerable<StoragePoolSkuRestrictions> restrictions = null)
        {
            capabilities ??= new List<StoragePoolSkuCapability>();
            restrictions ??= new List<StoragePoolSkuRestrictions>();

            return new StoragePoolSkuInfo(apiVersion, resourceType, capabilities?.ToList(), locationInfo, name, tier, restrictions?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StoragePoolSkuCapability"/>. </summary>
        /// <param name="name"> Capability name. </param>
        /// <param name="value"> Capability value. </param>
        /// <returns> A new <see cref="Models.StoragePoolSkuCapability"/> instance for mocking. </returns>
        public static StoragePoolSkuCapability StoragePoolSkuCapability(string name = null, string value = null)
        {
            return new StoragePoolSkuCapability(name, value, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StoragePoolSkuLocationInfo"/>. </summary>
        /// <param name="location"> Location of the SKU. </param>
        /// <param name="zones"> List of availability zones where the SKU is supported. </param>
        /// <param name="zoneDetails"> Details of capabilities available to a SKU in specific zones. </param>
        /// <returns> A new <see cref="Models.StoragePoolSkuLocationInfo"/> instance for mocking. </returns>
        public static StoragePoolSkuLocationInfo StoragePoolSkuLocationInfo(AzureLocation? location = null, IEnumerable<string> zones = null, IEnumerable<StoragePoolSkuZoneDetails> zoneDetails = null)
        {
            zones ??= new List<string>();
            zoneDetails ??= new List<StoragePoolSkuZoneDetails>();

            return new StoragePoolSkuLocationInfo(location, zones?.ToList(), zoneDetails?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StoragePoolSkuZoneDetails"/>. </summary>
        /// <param name="name"> The set of zones that the SKU is available in with the specified capabilities. </param>
        /// <param name="capabilities"> A list of capabilities that are available for the SKU in the specified list of zones. </param>
        /// <returns> A new <see cref="Models.StoragePoolSkuZoneDetails"/> instance for mocking. </returns>
        public static StoragePoolSkuZoneDetails StoragePoolSkuZoneDetails(IEnumerable<string> name = null, IEnumerable<StoragePoolSkuCapability> capabilities = null)
        {
            name ??= new List<string>();
            capabilities ??= new List<StoragePoolSkuCapability>();

            return new StoragePoolSkuZoneDetails(name?.ToList(), capabilities?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StoragePoolSkuRestrictions"/>. </summary>
        /// <param name="restrictionsType"> The type of restrictions. </param>
        /// <param name="values"> The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted. </param>
        /// <param name="restrictionInfo"> The information about the restriction where the SKU cannot be used. </param>
        /// <param name="reasonCode"> The reason for restriction. </param>
        /// <returns> A new <see cref="Models.StoragePoolSkuRestrictions"/> instance for mocking. </returns>
        public static StoragePoolSkuRestrictions StoragePoolSkuRestrictions(StoragePoolSkuRestrictionsType? restrictionsType = null, IEnumerable<string> values = null, StoragePoolSkuRestrictionInfo restrictionInfo = null, StoragePoolSkuRestrictionsReasonCode? reasonCode = null)
        {
            values ??= new List<string>();

            return new StoragePoolSkuRestrictions(restrictionsType, values?.ToList(), restrictionInfo, reasonCode, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StoragePoolSkuRestrictionInfo"/>. </summary>
        /// <param name="locations"> Locations where the SKU is restricted. </param>
        /// <param name="zones"> List of availability zones where the SKU is restricted. </param>
        /// <returns> A new <see cref="Models.StoragePoolSkuRestrictionInfo"/> instance for mocking. </returns>
        public static StoragePoolSkuRestrictionInfo StoragePoolSkuRestrictionInfo(IEnumerable<AzureLocation> locations = null, IEnumerable<string> zones = null)
        {
            locations ??= new List<AzureLocation>();
            zones ??= new List<string>();

            return new StoragePoolSkuRestrictionInfo(locations?.ToList(), zones?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StoragePoolOutboundEnvironment"/>. </summary>
        /// <param name="category"> The type of service accessed by the App Service Environment, e.g., Azure Storage, Azure SQL Database, and Azure Active Directory. </param>
        /// <param name="endpoints"> The endpoints that the App Service Environment reaches the service at. </param>
        /// <returns> A new <see cref="Models.StoragePoolOutboundEnvironment"/> instance for mocking. </returns>
        public static StoragePoolOutboundEnvironment StoragePoolOutboundEnvironment(string category = null, IEnumerable<OutboundEndpointDependency> endpoints = null)
        {
            endpoints ??= new List<OutboundEndpointDependency>();

            return new StoragePoolOutboundEnvironment(category, endpoints?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OutboundEndpointDependency"/>. </summary>
        /// <param name="domainName"> The domain name of the dependency. </param>
        /// <param name="endpointDetails"> The IP Addresses and Ports used when connecting to DomainName. </param>
        /// <returns> A new <see cref="Models.OutboundEndpointDependency"/> instance for mocking. </returns>
        public static OutboundEndpointDependency OutboundEndpointDependency(string domainName = null, IEnumerable<OutboundEndpointDetail> endpointDetails = null)
        {
            endpointDetails ??= new List<OutboundEndpointDetail>();

            return new OutboundEndpointDependency(domainName, endpointDetails?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OutboundEndpointDetail"/>. </summary>
        /// <param name="ipAddress"> An IP Address that Domain Name currently resolves to. </param>
        /// <param name="port"> The port an endpoint is connected to. </param>
        /// <param name="latencyInMs"> The time in milliseconds it takes for a TCP connection to be created from the App Service Environment to this IpAddress at this Port. </param>
        /// <param name="isAccessible"> Whether it is possible to create a TCP connection from the App Service Environment to this IpAddress at this Port. </param>
        /// <returns> A new <see cref="Models.OutboundEndpointDetail"/> instance for mocking. </returns>
        public static OutboundEndpointDetail OutboundEndpointDetail(IPAddress ipAddress = null, int? port = null, double? latencyInMs = null, bool? isAccessible = null)
        {
            return new OutboundEndpointDetail(ipAddress, port, latencyInMs, isAccessible, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="StoragePool.DiskPoolIscsiTargetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        /// <param name="staticAcls"> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </param>
        /// <param name="luns"> List of LUNs to be exposed through iSCSI Target. </param>
        /// <param name="targetIqn"> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="status"> Operational status of the iSCSI Target. </param>
        /// <param name="endpoints"> List of private IPv4 addresses to connect to the iSCSI Target. </param>
        /// <param name="port"> The port used by iSCSI Target portal group. </param>
        /// <param name="sessions"> List of identifiers for active sessions on the iSCSI target. </param>
        /// <returns> A new <see cref="StoragePool.DiskPoolIscsiTargetData"/> instance for mocking. </returns>
        public static DiskPoolIscsiTargetData DiskPoolIscsiTargetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string managedBy = null, IEnumerable<string> managedByExtended = null, DiskPoolIscsiTargetAclMode aclMode = default, IEnumerable<DiskPoolIscsiTargetPortalGroupAcl> staticAcls = null, IEnumerable<ManagedDiskIscsiLun> luns = null, string targetIqn = null, DiskPoolIscsiTargetProvisioningState provisioningState = default, StoragePoolOperationalStatus status = default, IEnumerable<string> endpoints = null, int? port = null, IEnumerable<string> sessions = null)
        {
            managedByExtended ??= new List<string>();
            staticAcls ??= new List<DiskPoolIscsiTargetPortalGroupAcl>();
            luns ??= new List<ManagedDiskIscsiLun>();
            endpoints ??= new List<string>();
            sessions ??= new List<string>();

            return new DiskPoolIscsiTargetData(id, name, resourceType, systemData, managedBy, managedByExtended?.ToList(), aclMode, staticAcls?.ToList(), luns?.ToList(), targetIqn, provisioningState, status, endpoints?.ToList(), port, sessions?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedDiskIscsiLun"/>. </summary>
        /// <param name="name"> User defined name for iSCSI LUN; example: "lun0". </param>
        /// <param name="managedDiskAzureResourceId"> Azure Resource ID of the Managed Disk. </param>
        /// <param name="lun"> Specifies the Logical Unit Number of the iSCSI LUN. </param>
        /// <returns> A new <see cref="Models.ManagedDiskIscsiLun"/> instance for mocking. </returns>
        public static ManagedDiskIscsiLun ManagedDiskIscsiLun(string name = null, ResourceIdentifier managedDiskAzureResourceId = null, int? lun = null)
        {
            return new ManagedDiskIscsiLun(name, managedDiskAzureResourceId, lun, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DiskPoolIscsiTargetCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="aclMode"> Mode for Target connectivity. </param>
        /// <param name="targetIqn"> iSCSI Target IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:server". </param>
        /// <param name="staticAcls"> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </param>
        /// <param name="luns"> List of LUNs to be exposed through iSCSI Target. </param>
        /// <returns> A new <see cref="Models.DiskPoolIscsiTargetCreateOrUpdateContent"/> instance for mocking. </returns>
        public static DiskPoolIscsiTargetCreateOrUpdateContent DiskPoolIscsiTargetCreateOrUpdateContent(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string managedBy = null, IEnumerable<string> managedByExtended = null, DiskPoolIscsiTargetAclMode aclMode = default, string targetIqn = null, IEnumerable<DiskPoolIscsiTargetPortalGroupAcl> staticAcls = null, IEnumerable<ManagedDiskIscsiLun> luns = null)
        {
            managedByExtended ??= new List<string>();
            staticAcls ??= new List<DiskPoolIscsiTargetPortalGroupAcl>();
            luns ??= new List<ManagedDiskIscsiLun>();

            return new DiskPoolIscsiTargetCreateOrUpdateContent(id, name, resourceType, systemData, managedBy, managedByExtended?.ToList(), aclMode, targetIqn, staticAcls?.ToList(), luns?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DiskPoolIscsiTargetPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="staticAcls"> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </param>
        /// <param name="luns"> List of LUNs to be exposed through iSCSI Target. </param>
        /// <returns> A new <see cref="Models.DiskPoolIscsiTargetPatch"/> instance for mocking. </returns>
        public static DiskPoolIscsiTargetPatch DiskPoolIscsiTargetPatch(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string managedBy = null, IEnumerable<string> managedByExtended = null, IEnumerable<DiskPoolIscsiTargetPortalGroupAcl> staticAcls = null, IEnumerable<ManagedDiskIscsiLun> luns = null)
        {
            managedByExtended ??= new List<string>();
            staticAcls ??= new List<DiskPoolIscsiTargetPortalGroupAcl>();
            luns ??= new List<ManagedDiskIscsiLun>();

            return new DiskPoolIscsiTargetPatch(id, name, resourceType, systemData, managedBy, managedByExtended?.ToList(), staticAcls?.ToList(), luns?.ToList(), serializedAdditionalRawData: null);
        }
    }
}
