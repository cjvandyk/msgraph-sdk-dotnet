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
    /// The interface IDelegatedPermissionClassificationRequest.
    /// </summary>
    public partial interface IDelegatedPermissionClassificationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DelegatedPermissionClassification using POST.
        /// </summary>
        /// <param name="delegatedPermissionClassificationToCreate">The DelegatedPermissionClassification to create.</param>
        /// <returns>The created DelegatedPermissionClassification.</returns>
        System.Threading.Tasks.Task<DelegatedPermissionClassification> CreateAsync(DelegatedPermissionClassification delegatedPermissionClassificationToCreate);

        /// <summary>
        /// Creates the specified DelegatedPermissionClassification using POST.
        /// </summary>
        /// <param name="delegatedPermissionClassificationToCreate">The DelegatedPermissionClassification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DelegatedPermissionClassification.</returns>
        System.Threading.Tasks.Task<DelegatedPermissionClassification> CreateAsync(DelegatedPermissionClassification delegatedPermissionClassificationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified DelegatedPermissionClassification using POST and returns a <see cref="GraphResponse{DelegatedPermissionClassification}"/> object.
        /// </summary>
        /// <param name="delegatedPermissionClassificationToCreate">The DelegatedPermissionClassification to create.</param>
        /// <returns>The <see cref="GraphResponse{DelegatedPermissionClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DelegatedPermissionClassification>> CreateResponseAsync(DelegatedPermissionClassification delegatedPermissionClassificationToCreate);

        /// <summary>
        /// Creates the specified DelegatedPermissionClassification using POST and returns a <see cref="GraphResponse{DelegatedPermissionClassification}"/> object.
        /// </summary>
        /// <param name="delegatedPermissionClassificationToCreate">The DelegatedPermissionClassification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DelegatedPermissionClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DelegatedPermissionClassification>> CreateResponseAsync(DelegatedPermissionClassification delegatedPermissionClassificationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DelegatedPermissionClassification.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DelegatedPermissionClassification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DelegatedPermissionClassification and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DelegatedPermissionClassification and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DelegatedPermissionClassification.
        /// </summary>
        /// <returns>The DelegatedPermissionClassification.</returns>
        System.Threading.Tasks.Task<DelegatedPermissionClassification> GetAsync();

        /// <summary>
        /// Gets the specified DelegatedPermissionClassification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DelegatedPermissionClassification.</returns>
        System.Threading.Tasks.Task<DelegatedPermissionClassification> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DelegatedPermissionClassification and returns a <see cref="GraphResponse{DelegatedPermissionClassification}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DelegatedPermissionClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DelegatedPermissionClassification>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DelegatedPermissionClassification and returns a <see cref="GraphResponse{DelegatedPermissionClassification}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DelegatedPermissionClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DelegatedPermissionClassification>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DelegatedPermissionClassification using PATCH.
        /// </summary>
        /// <param name="delegatedPermissionClassificationToUpdate">The DelegatedPermissionClassification to update.</param>
        /// <returns>The updated DelegatedPermissionClassification.</returns>
        System.Threading.Tasks.Task<DelegatedPermissionClassification> UpdateAsync(DelegatedPermissionClassification delegatedPermissionClassificationToUpdate);

        /// <summary>
        /// Updates the specified DelegatedPermissionClassification using PATCH.
        /// </summary>
        /// <param name="delegatedPermissionClassificationToUpdate">The DelegatedPermissionClassification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DelegatedPermissionClassification.</returns>
        System.Threading.Tasks.Task<DelegatedPermissionClassification> UpdateAsync(DelegatedPermissionClassification delegatedPermissionClassificationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DelegatedPermissionClassification using PATCH and returns a <see cref="GraphResponse{DelegatedPermissionClassification}"/> object.
        /// </summary>
        /// <param name="delegatedPermissionClassificationToUpdate">The DelegatedPermissionClassification to update.</param>
        /// <returns>The <see cref="GraphResponse{DelegatedPermissionClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DelegatedPermissionClassification>> UpdateResponseAsync(DelegatedPermissionClassification delegatedPermissionClassificationToUpdate);

        /// <summary>
        /// Updates the specified DelegatedPermissionClassification using PATCH and returns a <see cref="GraphResponse{DelegatedPermissionClassification}"/> object.
        /// </summary>
        /// <param name="delegatedPermissionClassificationToUpdate">The DelegatedPermissionClassification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DelegatedPermissionClassification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DelegatedPermissionClassification>> UpdateResponseAsync(DelegatedPermissionClassification delegatedPermissionClassificationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedPermissionClassificationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedPermissionClassificationRequest Expand(Expression<Func<DelegatedPermissionClassification, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedPermissionClassificationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDelegatedPermissionClassificationRequest Select(Expression<Func<DelegatedPermissionClassification, object>> selectExpression);

    }
}
