// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIosVppEBookAssignmentRequest.
    /// </summary>
    public partial interface IIosVppEBookAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosVppEBookAssignment using POST.
        /// </summary>
        /// <param name="iosVppEBookAssignmentToCreate">The IosVppEBookAssignment to create.</param>
        /// <returns>The created IosVppEBookAssignment.</returns>
        System.Threading.Tasks.Task<IosVppEBookAssignment> CreateAsync(IosVppEBookAssignment iosVppEBookAssignmentToCreate);        /// <summary>
        /// Creates the specified IosVppEBookAssignment using POST.
        /// </summary>
        /// <param name="iosVppEBookAssignmentToCreate">The IosVppEBookAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosVppEBookAssignment.</returns>
        System.Threading.Tasks.Task<IosVppEBookAssignment> CreateAsync(IosVppEBookAssignment iosVppEBookAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosVppEBookAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosVppEBookAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosVppEBookAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified IosVppEBookAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosVppEBookAssignment.
        /// </summary>
        /// <returns>The IosVppEBookAssignment.</returns>
        System.Threading.Tasks.Task<IosVppEBookAssignment> GetAsync();

        /// <summary>
        /// Gets the specified IosVppEBookAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosVppEBookAssignment.</returns>
        System.Threading.Tasks.Task<IosVppEBookAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosVppEBookAssignment using PATCH.
        /// </summary>
        /// <param name="iosVppEBookAssignmentToUpdate">The IosVppEBookAssignment to update.</param>
        /// <returns>The updated IosVppEBookAssignment.</returns>
        System.Threading.Tasks.Task<IosVppEBookAssignment> UpdateAsync(IosVppEBookAssignment iosVppEBookAssignmentToUpdate);

        /// <summary>
        /// Updates the specified IosVppEBookAssignment using PATCH.
        /// </summary>
        /// <param name="iosVppEBookAssignmentToUpdate">The IosVppEBookAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosVppEBookAssignment.</returns>
        System.Threading.Tasks.Task<IosVppEBookAssignment> UpdateAsync(IosVppEBookAssignment iosVppEBookAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppEBookAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppEBookAssignmentRequest Expand(Expression<Func<IosVppEBookAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppEBookAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVppEBookAssignmentRequest Select(Expression<Func<IosVppEBookAssignment, object>> selectExpression);

    }
}
