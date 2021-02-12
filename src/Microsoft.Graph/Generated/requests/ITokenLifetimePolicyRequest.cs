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
    /// The interface ITokenLifetimePolicyRequest.
    /// </summary>
    public partial interface ITokenLifetimePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TokenLifetimePolicy using POST.
        /// </summary>
        /// <param name="tokenLifetimePolicyToCreate">The TokenLifetimePolicy to create.</param>
        /// <returns>The created TokenLifetimePolicy.</returns>
        System.Threading.Tasks.Task<TokenLifetimePolicy> CreateAsync(TokenLifetimePolicy tokenLifetimePolicyToCreate);

        /// <summary>
        /// Creates the specified TokenLifetimePolicy using POST.
        /// </summary>
        /// <param name="tokenLifetimePolicyToCreate">The TokenLifetimePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TokenLifetimePolicy.</returns>
        System.Threading.Tasks.Task<TokenLifetimePolicy> CreateAsync(TokenLifetimePolicy tokenLifetimePolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified TokenLifetimePolicy using POST and returns a <see cref="GraphResponse{TokenLifetimePolicy}"/> object.
        /// </summary>
        /// <param name="tokenLifetimePolicyToCreate">The TokenLifetimePolicy to create.</param>
        /// <returns>The <see cref="GraphResponse{TokenLifetimePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenLifetimePolicy>> CreateResponseAsync(TokenLifetimePolicy tokenLifetimePolicyToCreate);

        /// <summary>
        /// Creates the specified TokenLifetimePolicy using POST and returns a <see cref="GraphResponse{TokenLifetimePolicy}"/> object.
        /// </summary>
        /// <param name="tokenLifetimePolicyToCreate">The TokenLifetimePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TokenLifetimePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenLifetimePolicy>> CreateResponseAsync(TokenLifetimePolicy tokenLifetimePolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TokenLifetimePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TokenLifetimePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TokenLifetimePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified TokenLifetimePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TokenLifetimePolicy.
        /// </summary>
        /// <returns>The TokenLifetimePolicy.</returns>
        System.Threading.Tasks.Task<TokenLifetimePolicy> GetAsync();

        /// <summary>
        /// Gets the specified TokenLifetimePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TokenLifetimePolicy.</returns>
        System.Threading.Tasks.Task<TokenLifetimePolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TokenLifetimePolicy and returns a <see cref="GraphResponse{TokenLifetimePolicy}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TokenLifetimePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenLifetimePolicy>> GetResponseAsync();

        /// <summary>
        /// Gets the specified TokenLifetimePolicy and returns a <see cref="GraphResponse{TokenLifetimePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TokenLifetimePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenLifetimePolicy>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TokenLifetimePolicy using PATCH.
        /// </summary>
        /// <param name="tokenLifetimePolicyToUpdate">The TokenLifetimePolicy to update.</param>
        /// <returns>The updated TokenLifetimePolicy.</returns>
        System.Threading.Tasks.Task<TokenLifetimePolicy> UpdateAsync(TokenLifetimePolicy tokenLifetimePolicyToUpdate);

        /// <summary>
        /// Updates the specified TokenLifetimePolicy using PATCH.
        /// </summary>
        /// <param name="tokenLifetimePolicyToUpdate">The TokenLifetimePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TokenLifetimePolicy.</returns>
        System.Threading.Tasks.Task<TokenLifetimePolicy> UpdateAsync(TokenLifetimePolicy tokenLifetimePolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TokenLifetimePolicy using PATCH and returns a <see cref="GraphResponse{TokenLifetimePolicy}"/> object.
        /// </summary>
        /// <param name="tokenLifetimePolicyToUpdate">The TokenLifetimePolicy to update.</param>
        /// <returns>The <see cref="GraphResponse{TokenLifetimePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenLifetimePolicy>> UpdateResponseAsync(TokenLifetimePolicy tokenLifetimePolicyToUpdate);

        /// <summary>
        /// Updates the specified TokenLifetimePolicy using PATCH and returns a <see cref="GraphResponse{TokenLifetimePolicy}"/> object.
        /// </summary>
        /// <param name="tokenLifetimePolicyToUpdate">The TokenLifetimePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TokenLifetimePolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TokenLifetimePolicy>> UpdateResponseAsync(TokenLifetimePolicy tokenLifetimePolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITokenLifetimePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITokenLifetimePolicyRequest Expand(Expression<Func<TokenLifetimePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITokenLifetimePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITokenLifetimePolicyRequest Select(Expression<Func<TokenLifetimePolicy, object>> selectExpression);

    }
}
