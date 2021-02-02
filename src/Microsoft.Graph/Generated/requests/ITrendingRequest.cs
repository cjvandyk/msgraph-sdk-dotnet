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
    /// The interface ITrendingRequest.
    /// </summary>
    public partial interface ITrendingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Trending using POST.
        /// </summary>
        /// <param name="trendingToCreate">The Trending to create.</param>
        /// <returns>The created Trending.</returns>
        System.Threading.Tasks.Task<Trending> CreateAsync(Trending trendingToCreate);        /// <summary>
        /// Creates the specified Trending using POST.
        /// </summary>
        /// <param name="trendingToCreate">The Trending to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Trending.</returns>
        System.Threading.Tasks.Task<Trending> CreateAsync(Trending trendingToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Trending.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Trending.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Trending and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Trending and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Trending.
        /// </summary>
        /// <returns>The Trending.</returns>
        System.Threading.Tasks.Task<Trending> GetAsync();

        /// <summary>
        /// Gets the specified Trending.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Trending.</returns>
        System.Threading.Tasks.Task<Trending> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Trending using PATCH.
        /// </summary>
        /// <param name="trendingToUpdate">The Trending to update.</param>
        /// <returns>The updated Trending.</returns>
        System.Threading.Tasks.Task<Trending> UpdateAsync(Trending trendingToUpdate);

        /// <summary>
        /// Updates the specified Trending using PATCH.
        /// </summary>
        /// <param name="trendingToUpdate">The Trending to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Trending.</returns>
        System.Threading.Tasks.Task<Trending> UpdateAsync(Trending trendingToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITrendingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITrendingRequest Expand(Expression<Func<Trending, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITrendingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITrendingRequest Select(Expression<Func<Trending, object>> selectExpression);

    }
}
