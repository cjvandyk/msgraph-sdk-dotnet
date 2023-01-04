// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AlertComment.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<AlertComment>))]
    public partial class AlertComment
    {

        /// <summary>
        /// Gets or sets comment.
        /// The comment text.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets createdByDisplayName.
        /// The person or app name that submitted the comment.
        /// </summary>
        [JsonPropertyName("createdByDisplayName")]
        public string CreatedByDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets createdDateTime.
        /// The time when the comment was submitted.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
