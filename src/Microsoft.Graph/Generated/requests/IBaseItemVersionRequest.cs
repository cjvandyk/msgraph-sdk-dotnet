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
    /// The interface IBaseItemVersionRequest.
    /// </summary>
    public partial interface IBaseItemVersionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BaseItemVersion using POST.
        /// </summary>
        /// <param name="baseItemVersionToCreate">The BaseItemVersion to create.</param>
        /// <returns>The created BaseItemVersion.</returns>
        System.Threading.Tasks.Task<BaseItemVersion> CreateAsync(BaseItemVersion baseItemVersionToCreate);

        /// <summary>
        /// Creates the specified BaseItemVersion using POST.
        /// </summary>
        /// <param name="baseItemVersionToCreate">The BaseItemVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BaseItemVersion.</returns>
        System.Threading.Tasks.Task<BaseItemVersion> CreateAsync(BaseItemVersion baseItemVersionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified BaseItemVersion using POST and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <param name="baseItemVersionToCreate">The BaseItemVersion to create.</param>
        /// <returns>The <see cref="GraphResponse{BaseItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> CreateResponseAsync(BaseItemVersion baseItemVersionToCreate);

        /// <summary>
        /// Creates the specified BaseItemVersion using POST and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <param name="baseItemVersionToCreate">The BaseItemVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BaseItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> CreateResponseAsync(BaseItemVersion baseItemVersionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified BaseItemVersion.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified BaseItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified BaseItemVersion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified BaseItemVersion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BaseItemVersion.
        /// </summary>
        /// <returns>The BaseItemVersion.</returns>
        System.Threading.Tasks.Task<BaseItemVersion> GetAsync();

        /// <summary>
        /// Gets the specified BaseItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BaseItemVersion.</returns>
        System.Threading.Tasks.Task<BaseItemVersion> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BaseItemVersion and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{BaseItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> GetResponseAsync();

        /// <summary>
        /// Gets the specified BaseItemVersion and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BaseItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BaseItemVersion using PATCH.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion to update.</param>
        /// <returns>The updated BaseItemVersion.</returns>
        System.Threading.Tasks.Task<BaseItemVersion> UpdateAsync(BaseItemVersion baseItemVersionToUpdate);

        /// <summary>
        /// Updates the specified BaseItemVersion using PATCH.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BaseItemVersion.</returns>
        System.Threading.Tasks.Task<BaseItemVersion> UpdateAsync(BaseItemVersion baseItemVersionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BaseItemVersion using PATCH and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion to update.</param>
        /// <returns>The <see cref="GraphResponse{BaseItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> UpdateResponseAsync(BaseItemVersion baseItemVersionToUpdate);

        /// <summary>
        /// Updates the specified BaseItemVersion using PATCH and returns a <see cref="GraphResponse{BaseItemVersion}"/> object.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BaseItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItemVersion>> UpdateResponseAsync(BaseItemVersion baseItemVersionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBaseItemVersionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBaseItemVersionRequest Expand(Expression<Func<BaseItemVersion, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBaseItemVersionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBaseItemVersionRequest Select(Expression<Func<BaseItemVersion, object>> selectExpression);

    }
}
