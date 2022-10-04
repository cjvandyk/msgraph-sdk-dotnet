// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AttackSimulationRootSimulationAutomationsCollectionRequestBuilder.
    /// </summary>
    public partial class AttackSimulationRootSimulationAutomationsCollectionRequestBuilder : BaseRequestBuilder, IAttackSimulationRootSimulationAutomationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AttackSimulationRootSimulationAutomationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AttackSimulationRootSimulationAutomationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAttackSimulationRootSimulationAutomationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAttackSimulationRootSimulationAutomationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AttackSimulationRootSimulationAutomationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISimulationAutomationRequestBuilder"/> for the specified AttackSimulationRootSimulationAutomation.
        /// </summary>
        /// <param name="id">The ID for the AttackSimulationRootSimulationAutomation.</param>
        /// <returns>The <see cref="ISimulationAutomationRequestBuilder"/>.</returns>
        public ISimulationAutomationRequestBuilder this[string id]
        {
            get
            {
                return new SimulationAutomationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
