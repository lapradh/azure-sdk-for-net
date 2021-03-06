// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class BastionShareableLink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vm");
            writer.WriteObjectValue(Vm);
            if (Bsl != null)
            {
                writer.WritePropertyName("bsl");
                writer.WriteStringValue(Bsl);
            }
            if (CreatedAt != null)
            {
                writer.WritePropertyName("createdAt");
                writer.WriteStringValue(CreatedAt);
            }
            if (Message != null)
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            writer.WriteEndObject();
        }

        internal static BastionShareableLink DeserializeBastionShareableLink(JsonElement element)
        {
            Resource vm = default;
            string bsl = default;
            string createdAt = default;
            string message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vm"))
                {
                    vm = Resource.DeserializeResource(property.Value);
                    continue;
                }
                if (property.NameEquals("bsl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bsl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new BastionShareableLink(vm, bsl, createdAt, message);
        }
    }
}
