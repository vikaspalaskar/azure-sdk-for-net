// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubWnsCredential : IUtf8JsonSerializable, IJsonModel<NotificationHubWnsCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationHubWnsCredential>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NotificationHubWnsCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubWnsCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubWnsCredential)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PackageSid))
            {
                writer.WritePropertyName("packageSid"u8);
                writer.WriteStringValue(PackageSid);
            }
            if (Optional.IsDefined(SecretKey))
            {
                writer.WritePropertyName("secretKey"u8);
                writer.WriteStringValue(SecretKey);
            }
            if (Optional.IsDefined(WindowsLiveEndpoint))
            {
                writer.WritePropertyName("windowsLiveEndpoint"u8);
                writer.WriteStringValue(WindowsLiveEndpoint.AbsoluteUri);
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

        NotificationHubWnsCredential IJsonModel<NotificationHubWnsCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubWnsCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubWnsCredential)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubWnsCredential(document.RootElement, options);
        }

        internal static NotificationHubWnsCredential DeserializeNotificationHubWnsCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> packageSid = default;
            Optional<string> secretKey = default;
            Optional<Uri> windowsLiveEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packageSid"u8))
                        {
                            packageSid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secretKey"u8))
                        {
                            secretKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("windowsLiveEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            windowsLiveEndpoint = new Uri(property0.Value.GetString());
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
            return new NotificationHubWnsCredential(packageSid.Value, secretKey.Value, windowsLiveEndpoint.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationHubWnsCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubWnsCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationHubWnsCredential)} does not support '{options.Format}' format.");
            }
        }

        NotificationHubWnsCredential IPersistableModel<NotificationHubWnsCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubWnsCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationHubWnsCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationHubWnsCredential)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationHubWnsCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
