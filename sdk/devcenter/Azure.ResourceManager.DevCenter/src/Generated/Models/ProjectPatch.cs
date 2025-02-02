// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The project properties for partial update. Properties not provided in the update request will not be changed. </summary>
    public partial class ProjectPatch : TrackedResourceUpdate
    {
        /// <summary> Initializes a new instance of ProjectPatch. </summary>
        public ProjectPatch()
        {
        }

        /// <summary> Resource Id of an associated DevCenter. </summary>
        public string DevCenterId { get; set; }
        /// <summary> Description of the project. </summary>
        public string Description { get; set; }
    }
}
