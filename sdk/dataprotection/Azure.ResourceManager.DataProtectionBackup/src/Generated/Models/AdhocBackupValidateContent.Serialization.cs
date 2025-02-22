// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class AdhocBackupValidateContent : IUtf8JsonSerializable, IJsonModel<AdhocBackupValidateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdhocBackupValidateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AdhocBackupValidateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupValidateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBackupValidateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("backupInstance"u8);
            writer.WriteObjectValue(BackupInstance);
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

        AdhocBackupValidateContent IJsonModel<AdhocBackupValidateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupValidateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdhocBackupValidateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdhocBackupValidateContent(document.RootElement, options);
        }

        internal static AdhocBackupValidateContent DeserializeAdhocBackupValidateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupInstanceProperties backupInstance = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupInstance"u8))
                {
                    backupInstance = DataProtectionBackupInstanceProperties.DeserializeDataProtectionBackupInstanceProperties(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AdhocBackupValidateContent(backupInstance, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdhocBackupValidateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupValidateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdhocBackupValidateContent)} does not support '{options.Format}' format.");
            }
        }

        AdhocBackupValidateContent IPersistableModel<AdhocBackupValidateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdhocBackupValidateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAdhocBackupValidateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdhocBackupValidateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdhocBackupValidateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
