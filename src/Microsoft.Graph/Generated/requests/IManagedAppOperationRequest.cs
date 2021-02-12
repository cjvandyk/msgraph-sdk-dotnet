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
    /// The interface IManagedAppOperationRequest.
    /// </summary>
    public partial interface IManagedAppOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedAppOperation using POST.
        /// </summary>
        /// <param name="managedAppOperationToCreate">The ManagedAppOperation to create.</param>
        /// <returns>The created ManagedAppOperation.</returns>
        System.Threading.Tasks.Task<ManagedAppOperation> CreateAsync(ManagedAppOperation managedAppOperationToCreate);

        /// <summary>
        /// Creates the specified ManagedAppOperation using POST.
        /// </summary>
        /// <param name="managedAppOperationToCreate">The ManagedAppOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppOperation.</returns>
        System.Threading.Tasks.Task<ManagedAppOperation> CreateAsync(ManagedAppOperation managedAppOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified ManagedAppOperation using POST and returns a <see cref="GraphResponse{ManagedAppOperation}"/> object.
        /// </summary>
        /// <param name="managedAppOperationToCreate">The ManagedAppOperation to create.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppOperation>> CreateResponseAsync(ManagedAppOperation managedAppOperationToCreate);

        /// <summary>
        /// Creates the specified ManagedAppOperation using POST and returns a <see cref="GraphResponse{ManagedAppOperation}"/> object.
        /// </summary>
        /// <param name="managedAppOperationToCreate">The ManagedAppOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppOperation>> CreateResponseAsync(ManagedAppOperation managedAppOperationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedAppOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedAppOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedAppOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified ManagedAppOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedAppOperation.
        /// </summary>
        /// <returns>The ManagedAppOperation.</returns>
        System.Threading.Tasks.Task<ManagedAppOperation> GetAsync();

        /// <summary>
        /// Gets the specified ManagedAppOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppOperation.</returns>
        System.Threading.Tasks.Task<ManagedAppOperation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedAppOperation and returns a <see cref="GraphResponse{ManagedAppOperation}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ManagedAppOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppOperation>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ManagedAppOperation and returns a <see cref="GraphResponse{ManagedAppOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppOperation>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedAppOperation using PATCH.
        /// </summary>
        /// <param name="managedAppOperationToUpdate">The ManagedAppOperation to update.</param>
        /// <returns>The updated ManagedAppOperation.</returns>
        System.Threading.Tasks.Task<ManagedAppOperation> UpdateAsync(ManagedAppOperation managedAppOperationToUpdate);

        /// <summary>
        /// Updates the specified ManagedAppOperation using PATCH.
        /// </summary>
        /// <param name="managedAppOperationToUpdate">The ManagedAppOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedAppOperation.</returns>
        System.Threading.Tasks.Task<ManagedAppOperation> UpdateAsync(ManagedAppOperation managedAppOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedAppOperation using PATCH and returns a <see cref="GraphResponse{ManagedAppOperation}"/> object.
        /// </summary>
        /// <param name="managedAppOperationToUpdate">The ManagedAppOperation to update.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppOperation>> UpdateResponseAsync(ManagedAppOperation managedAppOperationToUpdate);

        /// <summary>
        /// Updates the specified ManagedAppOperation using PATCH and returns a <see cref="GraphResponse{ManagedAppOperation}"/> object.
        /// </summary>
        /// <param name="managedAppOperationToUpdate">The ManagedAppOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedAppOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppOperation>> UpdateResponseAsync(ManagedAppOperation managedAppOperationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppOperationRequest Expand(Expression<Func<ManagedAppOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppOperationRequest Select(Expression<Func<ManagedAppOperation, object>> selectExpression);

    }
}
