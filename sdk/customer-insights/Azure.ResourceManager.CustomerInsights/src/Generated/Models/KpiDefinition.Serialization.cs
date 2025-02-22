// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class KpiDefinition : IUtf8JsonSerializable, IJsonModel<KpiDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KpiDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KpiDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KpiDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KpiDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("entityType"u8);
            writer.WriteStringValue(EntityType.ToSerialString());
            writer.WritePropertyName("entityTypeName"u8);
            writer.WriteStringValue(EntityTypeName);
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(KpiName))
            {
                writer.WritePropertyName("kpiName"u8);
                writer.WriteStringValue(KpiName);
            }
            if (Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("calculationWindow"u8);
            writer.WriteStringValue(CalculationWindow.ToSerialString());
            if (Optional.IsDefined(CalculationWindowFieldName))
            {
                writer.WritePropertyName("calculationWindowFieldName"u8);
                writer.WriteStringValue(CalculationWindowFieldName);
            }
            writer.WritePropertyName("function"u8);
            writer.WriteStringValue(Function.ToSerialString());
            writer.WritePropertyName("expression"u8);
            writer.WriteStringValue(Expression);
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (Optional.IsCollectionDefined(GroupBy))
            {
                writer.WritePropertyName("groupBy"u8);
                writer.WriteStartArray();
                foreach (var item in GroupBy)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(GroupByMetadata))
            {
                writer.WritePropertyName("groupByMetadata"u8);
                writer.WriteStartArray();
                foreach (var item in GroupByMetadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ParticipantProfilesMetadata))
            {
                writer.WritePropertyName("participantProfilesMetadata"u8);
                writer.WriteStartArray();
                foreach (var item in ParticipantProfilesMetadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ThresHolds))
            {
                writer.WritePropertyName("thresHolds"u8);
                writer.WriteObjectValue(ThresHolds);
            }
            if (Optional.IsCollectionDefined(Aliases))
            {
                writer.WritePropertyName("aliases"u8);
                writer.WriteStartArray();
                foreach (var item in Aliases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Extracts))
            {
                writer.WritePropertyName("extracts"u8);
                writer.WriteStartArray();
                foreach (var item in Extracts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        KpiDefinition IJsonModel<KpiDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KpiDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KpiDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKpiDefinition(document.RootElement, options);
        }

        internal static KpiDefinition DeserializeKpiDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EntityType entityType = default;
            string entityTypeName = default;
            Optional<Guid> tenantId = default;
            Optional<string> kpiName = default;
            Optional<IReadOnlyDictionary<string, string>> displayName = default;
            Optional<IReadOnlyDictionary<string, string>> description = default;
            CalculationWindowType calculationWindow = default;
            Optional<string> calculationWindowFieldName = default;
            KpiFunction function = default;
            string expression = default;
            Optional<string> unit = default;
            Optional<string> filter = default;
            Optional<IReadOnlyList<string>> groupBy = default;
            Optional<IReadOnlyList<KpiGroupByMetadata>> groupByMetadata = default;
            Optional<IReadOnlyList<KpiParticipantProfilesMetadata>> participantProfilesMetadata = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<KpiThresholds> thresHolds = default;
            Optional<IReadOnlyList<KpiAlias>> aliases = default;
            Optional<IReadOnlyList<KpiExtract>> extracts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entityType"u8))
                {
                    entityType = property.Value.GetString().ToEntityType();
                    continue;
                }
                if (property.NameEquals("entityTypeName"u8))
                {
                    entityTypeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("kpiName"u8))
                {
                    kpiName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    displayName = dictionary;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    description = dictionary;
                    continue;
                }
                if (property.NameEquals("calculationWindow"u8))
                {
                    calculationWindow = property.Value.GetString().ToCalculationWindowType();
                    continue;
                }
                if (property.NameEquals("calculationWindowFieldName"u8))
                {
                    calculationWindowFieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("function"u8))
                {
                    function = property.Value.GetString().ToKpiFunction();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    groupBy = array;
                    continue;
                }
                if (property.NameEquals("groupByMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KpiGroupByMetadata> array = new List<KpiGroupByMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KpiGroupByMetadata.DeserializeKpiGroupByMetadata(item));
                    }
                    groupByMetadata = array;
                    continue;
                }
                if (property.NameEquals("participantProfilesMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KpiParticipantProfilesMetadata> array = new List<KpiParticipantProfilesMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KpiParticipantProfilesMetadata.DeserializeKpiParticipantProfilesMetadata(item));
                    }
                    participantProfilesMetadata = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("thresHolds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thresHolds = KpiThresholds.DeserializeKpiThresholds(property.Value);
                    continue;
                }
                if (property.NameEquals("aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KpiAlias> array = new List<KpiAlias>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KpiAlias.DeserializeKpiAlias(item));
                    }
                    aliases = array;
                    continue;
                }
                if (property.NameEquals("extracts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KpiExtract> array = new List<KpiExtract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KpiExtract.DeserializeKpiExtract(item));
                    }
                    extracts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KpiDefinition(entityType, entityTypeName, Optional.ToNullable(tenantId), kpiName.Value, Optional.ToDictionary(displayName), Optional.ToDictionary(description), calculationWindow, calculationWindowFieldName.Value, function, expression, unit.Value, filter.Value, Optional.ToList(groupBy), Optional.ToList(groupByMetadata), Optional.ToList(participantProfilesMetadata), Optional.ToNullable(provisioningState), thresHolds.Value, Optional.ToList(aliases), Optional.ToList(extracts), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KpiDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KpiDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KpiDefinition)} does not support '{options.Format}' format.");
            }
        }

        KpiDefinition IPersistableModel<KpiDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KpiDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKpiDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KpiDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KpiDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
