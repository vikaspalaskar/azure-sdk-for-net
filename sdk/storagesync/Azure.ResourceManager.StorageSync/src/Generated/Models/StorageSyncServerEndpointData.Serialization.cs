// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    public partial class StorageSyncServerEndpointData : IUtf8JsonSerializable, IJsonModel<StorageSyncServerEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageSyncServerEndpointData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageSyncServerEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncServerEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncServerEndpointData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerLocalPath))
            {
                writer.WritePropertyName("serverLocalPath"u8);
                writer.WriteStringValue(ServerLocalPath);
            }
            if (Optional.IsDefined(CloudTiering))
            {
                writer.WritePropertyName("cloudTiering"u8);
                writer.WriteStringValue(CloudTiering.Value.ToString());
            }
            if (Optional.IsDefined(VolumeFreeSpacePercent))
            {
                writer.WritePropertyName("volumeFreeSpacePercent"u8);
                writer.WriteNumberValue(VolumeFreeSpacePercent.Value);
            }
            if (Optional.IsDefined(TierFilesOlderThanDays))
            {
                writer.WritePropertyName("tierFilesOlderThanDays"u8);
                writer.WriteNumberValue(TierFilesOlderThanDays.Value);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ServerResourceId))
            {
                writer.WritePropertyName("serverResourceId"u8);
                writer.WriteStringValue(ServerResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(LastWorkflowId))
            {
                writer.WritePropertyName("lastWorkflowId"u8);
                writer.WriteStringValue(LastWorkflowId);
            }
            if (options.Format != "W" && Optional.IsDefined(LastOperationName))
            {
                writer.WritePropertyName("lastOperationName"u8);
                writer.WriteStringValue(LastOperationName);
            }
            if (options.Format != "W" && Optional.IsDefined(SyncStatus))
            {
                writer.WritePropertyName("syncStatus"u8);
                writer.WriteObjectValue(SyncStatus);
            }
            if (Optional.IsDefined(OfflineDataTransfer))
            {
                writer.WritePropertyName("offlineDataTransfer"u8);
                writer.WriteStringValue(OfflineDataTransfer.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OfflineDataTransferStorageAccountResourceId))
            {
                writer.WritePropertyName("offlineDataTransferStorageAccountResourceId"u8);
                writer.WriteStringValue(OfflineDataTransferStorageAccountResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(OfflineDataTransferStorageAccountTenantId))
            {
                writer.WritePropertyName("offlineDataTransferStorageAccountTenantId"u8);
                writer.WriteStringValue(OfflineDataTransferStorageAccountTenantId.Value);
            }
            if (Optional.IsDefined(OfflineDataTransferShareName))
            {
                writer.WritePropertyName("offlineDataTransferShareName"u8);
                writer.WriteStringValue(OfflineDataTransferShareName);
            }
            if (options.Format != "W" && Optional.IsDefined(CloudTieringStatus))
            {
                writer.WritePropertyName("cloudTieringStatus"u8);
                writer.WriteObjectValue(CloudTieringStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(RecallStatus))
            {
                writer.WritePropertyName("recallStatus"u8);
                writer.WriteObjectValue(RecallStatus);
            }
            if (Optional.IsDefined(InitialDownloadPolicy))
            {
                writer.WritePropertyName("initialDownloadPolicy"u8);
                writer.WriteStringValue(InitialDownloadPolicy.Value.ToString());
            }
            if (Optional.IsDefined(LocalCacheMode))
            {
                writer.WritePropertyName("localCacheMode"u8);
                writer.WriteStringValue(LocalCacheMode.Value.ToString());
            }
            if (Optional.IsDefined(InitialUploadPolicy))
            {
                writer.WritePropertyName("initialUploadPolicy"u8);
                writer.WriteStringValue(InitialUploadPolicy.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        StorageSyncServerEndpointData IJsonModel<StorageSyncServerEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncServerEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncServerEndpointData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSyncServerEndpointData(document.RootElement, options);
        }

        internal static StorageSyncServerEndpointData DeserializeStorageSyncServerEndpointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> serverLocalPath = default;
            Optional<StorageSyncFeatureStatus> cloudTiering = default;
            Optional<int> volumeFreeSpacePercent = default;
            Optional<int> tierFilesOlderThanDays = default;
            Optional<string> friendlyName = default;
            Optional<ResourceIdentifier> serverResourceId = default;
            Optional<string> provisioningState = default;
            Optional<string> lastWorkflowId = default;
            Optional<string> lastOperationName = default;
            Optional<ServerEndpointSyncStatus> syncStatus = default;
            Optional<StorageSyncFeatureStatus> offlineDataTransfer = default;
            Optional<ResourceIdentifier> offlineDataTransferStorageAccountResourceId = default;
            Optional<Guid> offlineDataTransferStorageAccountTenantId = default;
            Optional<string> offlineDataTransferShareName = default;
            Optional<ServerEndpointCloudTieringStatus> cloudTieringStatus = default;
            Optional<ServerEndpointRecallStatus> recallStatus = default;
            Optional<InitialDownloadPolicy> initialDownloadPolicy = default;
            Optional<LocalCacheMode> localCacheMode = default;
            Optional<InitialUploadPolicy> initialUploadPolicy = default;
            Optional<string> serverName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serverLocalPath"u8))
                        {
                            serverLocalPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudTiering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloudTiering = new StorageSyncFeatureStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("volumeFreeSpacePercent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            volumeFreeSpacePercent = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("tierFilesOlderThanDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tierFilesOlderThanDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastWorkflowId"u8))
                        {
                            lastWorkflowId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastOperationName"u8))
                        {
                            lastOperationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("syncStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncStatus = ServerEndpointSyncStatus.DeserializeServerEndpointSyncStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("offlineDataTransfer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offlineDataTransfer = new StorageSyncFeatureStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offlineDataTransferStorageAccountResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offlineDataTransferStorageAccountResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offlineDataTransferStorageAccountTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            offlineDataTransferStorageAccountTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("offlineDataTransferShareName"u8))
                        {
                            offlineDataTransferShareName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudTieringStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cloudTieringStatus = ServerEndpointCloudTieringStatus.DeserializeServerEndpointCloudTieringStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("recallStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recallStatus = ServerEndpointRecallStatus.DeserializeServerEndpointRecallStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("initialDownloadPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            initialDownloadPolicy = new InitialDownloadPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("localCacheMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localCacheMode = new LocalCacheMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("initialUploadPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            initialUploadPolicy = new InitialUploadPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageSyncServerEndpointData(id, name, type, systemData.Value, serverLocalPath.Value, Optional.ToNullable(cloudTiering), Optional.ToNullable(volumeFreeSpacePercent), Optional.ToNullable(tierFilesOlderThanDays), friendlyName.Value, serverResourceId.Value, provisioningState.Value, lastWorkflowId.Value, lastOperationName.Value, syncStatus.Value, Optional.ToNullable(offlineDataTransfer), offlineDataTransferStorageAccountResourceId.Value, Optional.ToNullable(offlineDataTransferStorageAccountTenantId), offlineDataTransferShareName.Value, cloudTieringStatus.Value, recallStatus.Value, Optional.ToNullable(initialDownloadPolicy), Optional.ToNullable(localCacheMode), Optional.ToNullable(initialUploadPolicy), serverName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageSyncServerEndpointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncServerEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageSyncServerEndpointData)} does not support '{options.Format}' format.");
            }
        }

        StorageSyncServerEndpointData IPersistableModel<StorageSyncServerEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncServerEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageSyncServerEndpointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageSyncServerEndpointData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageSyncServerEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
