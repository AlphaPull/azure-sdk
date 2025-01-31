// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalAvailableContact
    {
        internal static OrbitalAvailableContact DeserializeOrbitalAvailableContact(JsonElement element)
        {
            Optional<WritableSubResource> spacecraft = default;
            Optional<string> groundStationName = default;
            Optional<float> maximumElevationDegrees = default;
            Optional<DateTimeOffset> txStartTime = default;
            Optional<DateTimeOffset> txEndTime = default;
            Optional<DateTimeOffset> rxStartTime = default;
            Optional<DateTimeOffset> rxEndTime = default;
            Optional<float> startAzimuthDegrees = default;
            Optional<float> endAzimuthDegrees = default;
            Optional<float> startElevationDegrees = default;
            Optional<float> endElevationDegrees = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("spacecraft"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    spacecraft = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("groundStationName"u8))
                {
                    groundStationName = property.Value.GetString();
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
                        if (property0.NameEquals("maximumElevationDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maximumElevationDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("txStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            txStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("txEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            txEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("rxStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rxStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("rxEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rxEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startAzimuthDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startAzimuthDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("endAzimuthDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endAzimuthDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("startElevationDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startElevationDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("endElevationDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endElevationDegrees = property0.Value.GetSingle();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new OrbitalAvailableContact(spacecraft, groundStationName.Value, Optional.ToNullable(maximumElevationDegrees), Optional.ToNullable(txStartTime), Optional.ToNullable(txEndTime), Optional.ToNullable(rxStartTime), Optional.ToNullable(rxEndTime), Optional.ToNullable(startAzimuthDegrees), Optional.ToNullable(endAzimuthDegrees), Optional.ToNullable(startElevationDegrees), Optional.ToNullable(endElevationDegrees));
        }
    }
}
