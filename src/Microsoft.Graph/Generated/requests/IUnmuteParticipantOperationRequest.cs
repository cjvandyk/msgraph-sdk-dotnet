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
    /// The interface IUnmuteParticipantOperationRequest.
    /// </summary>
    public partial interface IUnmuteParticipantOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnmuteParticipantOperation using POST.
        /// </summary>
        /// <param name="unmuteParticipantOperationToCreate">The UnmuteParticipantOperation to create.</param>
        /// <returns>The created UnmuteParticipantOperation.</returns>
        System.Threading.Tasks.Task<UnmuteParticipantOperation> CreateAsync(UnmuteParticipantOperation unmuteParticipantOperationToCreate);        /// <summary>
        /// Creates the specified UnmuteParticipantOperation using POST.
        /// </summary>
        /// <param name="unmuteParticipantOperationToCreate">The UnmuteParticipantOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnmuteParticipantOperation.</returns>
        System.Threading.Tasks.Task<UnmuteParticipantOperation> CreateAsync(UnmuteParticipantOperation unmuteParticipantOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UnmuteParticipantOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UnmuteParticipantOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UnmuteParticipantOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified UnmuteParticipantOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnmuteParticipantOperation.
        /// </summary>
        /// <returns>The UnmuteParticipantOperation.</returns>
        System.Threading.Tasks.Task<UnmuteParticipantOperation> GetAsync();

        /// <summary>
        /// Gets the specified UnmuteParticipantOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnmuteParticipantOperation.</returns>
        System.Threading.Tasks.Task<UnmuteParticipantOperation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnmuteParticipantOperation using PATCH.
        /// </summary>
        /// <param name="unmuteParticipantOperationToUpdate">The UnmuteParticipantOperation to update.</param>
        /// <returns>The updated UnmuteParticipantOperation.</returns>
        System.Threading.Tasks.Task<UnmuteParticipantOperation> UpdateAsync(UnmuteParticipantOperation unmuteParticipantOperationToUpdate);

        /// <summary>
        /// Updates the specified UnmuteParticipantOperation using PATCH.
        /// </summary>
        /// <param name="unmuteParticipantOperationToUpdate">The UnmuteParticipantOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnmuteParticipantOperation.</returns>
        System.Threading.Tasks.Task<UnmuteParticipantOperation> UpdateAsync(UnmuteParticipantOperation unmuteParticipantOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnmuteParticipantOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnmuteParticipantOperationRequest Expand(Expression<Func<UnmuteParticipantOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnmuteParticipantOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnmuteParticipantOperationRequest Select(Expression<Func<UnmuteParticipantOperation, object>> selectExpression);

    }
}
