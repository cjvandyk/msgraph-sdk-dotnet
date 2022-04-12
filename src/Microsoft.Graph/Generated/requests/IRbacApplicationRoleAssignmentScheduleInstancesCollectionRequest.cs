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
    /// The interface IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest.
    /// </summary>
    public partial interface IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified UnifiedRoleAssignmentScheduleInstance to the collection via POST.
        /// </summary>
        /// <param name="unifiedRoleAssignmentScheduleInstance">The UnifiedRoleAssignmentScheduleInstance to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleAssignmentScheduleInstance.</returns>
        System.Threading.Tasks.Task<UnifiedRoleAssignmentScheduleInstance> AddAsync(UnifiedRoleAssignmentScheduleInstance unifiedRoleAssignmentScheduleInstance, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified UnifiedRoleAssignmentScheduleInstance to the collection via POST and returns a <see cref="GraphResponse{UnifiedRoleAssignmentScheduleInstance}"/> object of the request.
        /// </summary>
        /// <param name="unifiedRoleAssignmentScheduleInstance">The UnifiedRoleAssignmentScheduleInstance to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentScheduleInstance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentScheduleInstance>> AddResponseAsync(UnifiedRoleAssignmentScheduleInstance unifiedRoleAssignmentScheduleInstance, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IRbacApplicationRoleAssignmentScheduleInstancesCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{RbacApplicationRoleAssignmentScheduleInstancesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RbacApplicationRoleAssignmentScheduleInstancesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<RbacApplicationRoleAssignmentScheduleInstancesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest Expand(Expression<Func<UnifiedRoleAssignmentScheduleInstance, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest Select(Expression<Func<UnifiedRoleAssignmentScheduleInstance, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IRbacApplicationRoleAssignmentScheduleInstancesCollectionRequest OrderBy(string value);
    }
}
