// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabAutoShutdownProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ShutdownOnDisconnect))
            {
                writer.WritePropertyName("shutdownOnDisconnect"u8);
                writer.WriteStringValue(ShutdownOnDisconnect.Value.ToSerialString());
            }
            if (Optional.IsDefined(ShutdownWhenNotConnected))
            {
                writer.WritePropertyName("shutdownWhenNotConnected"u8);
                writer.WriteStringValue(ShutdownWhenNotConnected.Value.ToSerialString());
            }
            if (Optional.IsDefined(ShutdownOnIdle))
            {
                writer.WritePropertyName("shutdownOnIdle"u8);
                writer.WriteStringValue(ShutdownOnIdle.Value.ToSerialString());
            }
            if (Optional.IsDefined(DisconnectDelay))
            {
                writer.WritePropertyName("disconnectDelay"u8);
                writer.WriteStringValue(DisconnectDelay.Value, "P");
            }
            if (Optional.IsDefined(NoConnectDelay))
            {
                writer.WritePropertyName("noConnectDelay"u8);
                writer.WriteStringValue(NoConnectDelay.Value, "P");
            }
            if (Optional.IsDefined(IdleDelay))
            {
                writer.WritePropertyName("idleDelay"u8);
                writer.WriteStringValue(IdleDelay.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static LabAutoShutdownProfile DeserializeLabAutoShutdownProfile(JsonElement element)
        {
            Optional<LabServicesEnableState> shutdownOnDisconnect = default;
            Optional<LabServicesEnableState> shutdownWhenNotConnected = default;
            Optional<LabVirtualMachineShutdownOnIdleMode> shutdownOnIdle = default;
            Optional<TimeSpan> disconnectDelay = default;
            Optional<TimeSpan> noConnectDelay = default;
            Optional<TimeSpan> idleDelay = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shutdownOnDisconnect"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    shutdownOnDisconnect = property.Value.GetString().ToLabServicesEnableState();
                    continue;
                }
                if (property.NameEquals("shutdownWhenNotConnected"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    shutdownWhenNotConnected = property.Value.GetString().ToLabServicesEnableState();
                    continue;
                }
                if (property.NameEquals("shutdownOnIdle"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    shutdownOnIdle = property.Value.GetString().ToLabVirtualMachineShutdownOnIdleMode();
                    continue;
                }
                if (property.NameEquals("disconnectDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disconnectDelay = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("noConnectDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    noConnectDelay = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("idleDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    idleDelay = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new LabAutoShutdownProfile(Optional.ToNullable(shutdownOnDisconnect), Optional.ToNullable(shutdownWhenNotConnected), Optional.ToNullable(shutdownOnIdle), Optional.ToNullable(disconnectDelay), Optional.ToNullable(noConnectDelay), Optional.ToNullable(idleDelay));
        }
    }
}
