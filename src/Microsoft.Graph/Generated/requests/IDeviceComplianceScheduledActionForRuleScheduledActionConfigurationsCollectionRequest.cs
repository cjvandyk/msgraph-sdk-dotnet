// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest.
    /// </summary>
    public partial interface IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified DeviceComplianceActionItem to the collection via POST.
        /// </summary>
        /// <param name="deviceComplianceActionItem">The DeviceComplianceActionItem to add.</param>
        /// <returns>The created DeviceComplianceActionItem.</returns>
        System.Threading.Tasks.Task<DeviceComplianceActionItem> AddAsync(DeviceComplianceActionItem deviceComplianceActionItem);

        /// <summary>
        /// Adds the specified DeviceComplianceActionItem to the collection via POST.
        /// </summary>
        /// <param name="deviceComplianceActionItem">The DeviceComplianceActionItem to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceActionItem.</returns>
        System.Threading.Tasks.Task<DeviceComplianceActionItem> AddAsync(DeviceComplianceActionItem deviceComplianceActionItem, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest Expand(Expression<Func<DeviceComplianceActionItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest Select(Expression<Func<DeviceComplianceActionItem, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest OrderBy(string value);
    }
}
