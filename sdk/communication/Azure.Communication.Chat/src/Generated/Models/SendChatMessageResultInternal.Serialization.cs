// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class SendChatMessageResultInternal
    {
        internal static SendChatMessageResultInternal DeserializeSendChatMessageResultInternal(JsonElement element)
        {
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new SendChatMessageResultInternal(id);
        }
    }
}
