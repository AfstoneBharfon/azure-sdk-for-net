// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Data POST-ed to the nameAvailability action. </summary>
    public partial class WebPubSubNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of WebPubSubNameAvailabilityContent. </summary>
        /// <param name="resourceType"> The resource type. Can be &quot;Microsoft.SignalRService/SignalR&quot; or &quot;Microsoft.SignalRService/webPubSub&quot;. </param>
        /// <param name="name"> The resource name to validate. e.g.&quot;my-resource-name&quot;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> or <paramref name="name"/> is null. </exception>
        public WebPubSubNameAvailabilityContent(string resourceType, string name)
        {
            Argument.AssertNotNull(resourceType, nameof(resourceType));
            Argument.AssertNotNull(name, nameof(name));

            ResourceType = resourceType;
            Name = name;
        }

        /// <summary> The resource type. Can be &quot;Microsoft.SignalRService/SignalR&quot; or &quot;Microsoft.SignalRService/webPubSub&quot;. </summary>
        public string ResourceType { get; }
        /// <summary> The resource name to validate. e.g.&quot;my-resource-name&quot;. </summary>
        public string Name { get; }
    }
}
