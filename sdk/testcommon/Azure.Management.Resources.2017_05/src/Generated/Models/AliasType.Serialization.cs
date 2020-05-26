// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class AliasType
    {
        internal static AliasType DeserializeAliasType(JsonElement element)
        {
            string name = default;
            IReadOnlyList<AliasPathType> paths = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("paths"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AliasPathType> array = new List<AliasPathType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(AliasPathType.DeserializeAliasPathType(item));
                        }
                    }
                    paths = array;
                    continue;
                }
            }
            return new AliasType(name, paths);
        }
    }
}
