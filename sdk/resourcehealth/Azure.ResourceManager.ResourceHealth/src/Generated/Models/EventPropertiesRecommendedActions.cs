// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Recommended actions of event. </summary>
    public partial class EventPropertiesRecommendedActions
    {
        /// <summary> Initializes a new instance of EventPropertiesRecommendedActions. </summary>
        internal EventPropertiesRecommendedActions()
        {
            Actions = new ChangeTrackingList<EventPropertiesRecommendedActionsItem>();
        }

        /// <summary> Initializes a new instance of EventPropertiesRecommendedActions. </summary>
        /// <param name="message"> Recommended action title for the service health event. </param>
        /// <param name="actions"> Recommended actions for the service health event. </param>
        /// <param name="localeCode"> Recommended action locale for the service health event. </param>
        internal EventPropertiesRecommendedActions(string message, IReadOnlyList<EventPropertiesRecommendedActionsItem> actions, string localeCode)
        {
            Message = message;
            Actions = actions;
            LocaleCode = localeCode;
        }

        /// <summary> Recommended action title for the service health event. </summary>
        public string Message { get; }
        /// <summary> Recommended actions for the service health event. </summary>
        public IReadOnlyList<EventPropertiesRecommendedActionsItem> Actions { get; }
        /// <summary> Recommended action locale for the service health event. </summary>
        public string LocaleCode { get; }
    }
}
