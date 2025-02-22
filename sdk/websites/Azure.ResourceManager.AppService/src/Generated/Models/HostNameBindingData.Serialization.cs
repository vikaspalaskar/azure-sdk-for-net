// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class HostNameBindingData : IUtf8JsonSerializable, IJsonModel<HostNameBindingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostNameBindingData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HostNameBindingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameBindingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostNameBindingData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (Optional.IsDefined(SiteName))
            {
                writer.WritePropertyName("siteName"u8);
                writer.WriteStringValue(SiteName);
            }
            if (Optional.IsDefined(DomainId))
            {
                writer.WritePropertyName("domainId"u8);
                writer.WriteStringValue(DomainId);
            }
            if (Optional.IsDefined(AzureResourceName))
            {
                writer.WritePropertyName("azureResourceName"u8);
                writer.WriteStringValue(AzureResourceName);
            }
            if (Optional.IsDefined(AzureResourceType))
            {
                writer.WritePropertyName("azureResourceType"u8);
                writer.WriteStringValue(AzureResourceType.Value.ToSerialString());
            }
            if (Optional.IsDefined(CustomHostNameDnsRecordType))
            {
                writer.WritePropertyName("customHostNameDnsRecordType"u8);
                writer.WriteStringValue(CustomHostNameDnsRecordType.Value.ToSerialString());
            }
            if (Optional.IsDefined(HostNameType))
            {
                writer.WritePropertyName("hostNameType"u8);
                writer.WriteStringValue(HostNameType.Value.ToSerialString());
            }
            if (Optional.IsDefined(SslState))
            {
                writer.WritePropertyName("sslState"u8);
                writer.WriteStringValue(SslState.Value.ToSerialString());
            }
            if (Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (options.Format != "W" && Optional.IsDefined(VirtualIP))
            {
                writer.WritePropertyName("virtualIP"u8);
                writer.WriteStringValue(VirtualIP);
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

        HostNameBindingData IJsonModel<HostNameBindingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameBindingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostNameBindingData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostNameBindingData(document.RootElement, options);
        }

        internal static HostNameBindingData DeserializeHostNameBindingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> siteName = default;
            Optional<string> domainId = default;
            Optional<string> azureResourceName = default;
            Optional<AppServiceResourceType> azureResourceType = default;
            Optional<CustomHostNameDnsRecordType> customHostNameDnsRecordType = default;
            Optional<AppServiceHostNameType> hostNameType = default;
            Optional<HostNameBindingSslState> sslState = default;
            Optional<string> thumbprint = default;
            Optional<string> virtualIP = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("siteName"u8))
                        {
                            siteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainId"u8))
                        {
                            domainId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureResourceName"u8))
                        {
                            azureResourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureResourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureResourceType = property0.Value.GetString().ToAppServiceResourceType();
                            continue;
                        }
                        if (property0.NameEquals("customHostNameDnsRecordType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customHostNameDnsRecordType = property0.Value.GetString().ToCustomHostNameDnsRecordType();
                            continue;
                        }
                        if (property0.NameEquals("hostNameType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostNameType = property0.Value.GetString().ToAppServiceHostNameType();
                            continue;
                        }
                        if (property0.NameEquals("sslState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sslState = property0.Value.GetString().ToHostNameBindingSslState();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"u8))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualIP"u8))
                        {
                            virtualIP = property0.Value.GetString();
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
            return new HostNameBindingData(id, name, type, systemData.Value, siteName.Value, domainId.Value, azureResourceName.Value, Optional.ToNullable(azureResourceType), Optional.ToNullable(customHostNameDnsRecordType), Optional.ToNullable(hostNameType), Optional.ToNullable(sslState), thumbprint.Value, virtualIP.Value, kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HostNameBindingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameBindingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HostNameBindingData)} does not support '{options.Format}' format.");
            }
        }

        HostNameBindingData IPersistableModel<HostNameBindingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostNameBindingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostNameBindingData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostNameBindingData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostNameBindingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
