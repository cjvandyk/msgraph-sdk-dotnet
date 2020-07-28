// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementComplianceManagementPartnersCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementComplianceManagementPartnersCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementComplianceManagementPartnersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementComplianceManagementPartnersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementComplianceManagementPartnersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementComplianceManagementPartnersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementComplianceManagementPartnersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementComplianceManagementPartnersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IComplianceManagementPartnerRequestBuilder"/> for the specified DeviceManagementComplianceManagementPartner.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementComplianceManagementPartner.</param>
        /// <returns>The <see cref="IComplianceManagementPartnerRequestBuilder"/>.</returns>
        public IComplianceManagementPartnerRequestBuilder this[string id]
        {
            get
            {
                return new ComplianceManagementPartnerRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
