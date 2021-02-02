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
    /// The interface IWebAppRequest.
    /// </summary>
    public partial interface IWebAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WebApp using POST.
        /// </summary>
        /// <param name="webAppToCreate">The WebApp to create.</param>
        /// <returns>The created WebApp.</returns>
        System.Threading.Tasks.Task<WebApp> CreateAsync(WebApp webAppToCreate);        /// <summary>
        /// Creates the specified WebApp using POST.
        /// </summary>
        /// <param name="webAppToCreate">The WebApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WebApp.</returns>
        System.Threading.Tasks.Task<WebApp> CreateAsync(WebApp webAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WebApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WebApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WebApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WebApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WebApp.
        /// </summary>
        /// <returns>The WebApp.</returns>
        System.Threading.Tasks.Task<WebApp> GetAsync();

        /// <summary>
        /// Gets the specified WebApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WebApp.</returns>
        System.Threading.Tasks.Task<WebApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WebApp using PATCH.
        /// </summary>
        /// <param name="webAppToUpdate">The WebApp to update.</param>
        /// <returns>The updated WebApp.</returns>
        System.Threading.Tasks.Task<WebApp> UpdateAsync(WebApp webAppToUpdate);

        /// <summary>
        /// Updates the specified WebApp using PATCH.
        /// </summary>
        /// <param name="webAppToUpdate">The WebApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WebApp.</returns>
        System.Threading.Tasks.Task<WebApp> UpdateAsync(WebApp webAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWebAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWebAppRequest Expand(Expression<Func<WebApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWebAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWebAppRequest Select(Expression<Func<WebApp, object>> selectExpression);

    }
}
