// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ConfigurationGroupSchemaVersionUpdateState : IUtf8JsonSerializable, IJsonModel<ConfigurationGroupSchemaVersionUpdateState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationGroupSchemaVersionUpdateState>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfigurationGroupSchemaVersionUpdateState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupSchemaVersionUpdateState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupSchemaVersionUpdateState)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VersionState))
            {
                writer.WritePropertyName("versionState"u8);
                writer.WriteStringValue(VersionState.Value.ToString());
            }
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

        ConfigurationGroupSchemaVersionUpdateState IJsonModel<ConfigurationGroupSchemaVersionUpdateState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupSchemaVersionUpdateState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupSchemaVersionUpdateState)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationGroupSchemaVersionUpdateState(document.RootElement, options);
        }

        internal static ConfigurationGroupSchemaVersionUpdateState DeserializeConfigurationGroupSchemaVersionUpdateState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VersionState> versionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("versionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionState = new VersionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfigurationGroupSchemaVersionUpdateState(Optional.ToNullable(versionState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigurationGroupSchemaVersionUpdateState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupSchemaVersionUpdateState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupSchemaVersionUpdateState)} does not support '{options.Format}' format.");
            }
        }

        ConfigurationGroupSchemaVersionUpdateState IPersistableModel<ConfigurationGroupSchemaVersionUpdateState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupSchemaVersionUpdateState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigurationGroupSchemaVersionUpdateState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupSchemaVersionUpdateState)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationGroupSchemaVersionUpdateState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
