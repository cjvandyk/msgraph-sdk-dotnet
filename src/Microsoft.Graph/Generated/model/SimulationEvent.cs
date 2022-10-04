// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SimulationEvent.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SimulationEvent>))]
    public partial class SimulationEvent
    {

        /// <summary>
        /// Gets or sets count.
        /// Count of the simulation event occurrence in an attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("count")]
        public Int32? Count { get; set; }
    
        /// <summary>
        /// Gets or sets eventName.
        /// Name of the simulation event in an attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("eventName")]
        public string EventName { get; set; }
    
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
