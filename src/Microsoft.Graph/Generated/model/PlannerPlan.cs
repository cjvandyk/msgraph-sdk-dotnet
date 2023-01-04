// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Planner Plan.
    /// </summary>
    public partial class PlannerPlan : Entity
    {
    
        /// <summary>
        /// Gets or sets container.
        /// Identifies the container of the plan. Specify only the url, the containerId and type, or all properties. After it is set, this property can’t be updated. Required.
        /// </summary>
        [JsonPropertyName("container")]
        public PlannerPlanContainer Container { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// Read-only. The user who created the plan.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// </summary>
        [Obsolete("Owner property is deprecated and will be removed in April 2024. Please use the container property instead.")]
        [JsonPropertyName("owner")]
        public string Owner { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Required. Title of the plan.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets buckets.
        /// Read-only. Nullable. Collection of buckets in the plan.
        /// </summary>
        [JsonPropertyName("buckets")]
        public IPlannerPlanBucketsCollectionPage Buckets { get; set; }

        /// <summary>
        /// Gets or sets bucketsNextLink.
        /// </summary>
        [JsonPropertyName("buckets@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string BucketsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets details.
        /// Read-only. Nullable. Additional details about the plan.
        /// </summary>
        [JsonPropertyName("details")]
        public PlannerPlanDetails Details { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Read-only. Nullable. Collection of tasks in the plan.
        /// </summary>
        [JsonPropertyName("tasks")]
        public IPlannerPlanTasksCollectionPage Tasks { get; set; }

        /// <summary>
        /// Gets or sets tasksNextLink.
        /// </summary>
        [JsonPropertyName("tasks@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TasksNextLink { get; set; }
    
    }
}

