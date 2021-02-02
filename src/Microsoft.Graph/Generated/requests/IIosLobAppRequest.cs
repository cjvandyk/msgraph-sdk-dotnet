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
    /// The interface IIosLobAppRequest.
    /// </summary>
    public partial interface IIosLobAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosLobApp using POST.
        /// </summary>
        /// <param name="iosLobAppToCreate">The IosLobApp to create.</param>
        /// <returns>The created IosLobApp.</returns>
        System.Threading.Tasks.Task<IosLobApp> CreateAsync(IosLobApp iosLobAppToCreate);        /// <summary>
        /// Creates the specified IosLobApp using POST.
        /// </summary>
        /// <param name="iosLobAppToCreate">The IosLobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosLobApp.</returns>
        System.Threading.Tasks.Task<IosLobApp> CreateAsync(IosLobApp iosLobAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosLobApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosLobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified IosLobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosLobApp.
        /// </summary>
        /// <returns>The IosLobApp.</returns>
        System.Threading.Tasks.Task<IosLobApp> GetAsync();

        /// <summary>
        /// Gets the specified IosLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosLobApp.</returns>
        System.Threading.Tasks.Task<IosLobApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosLobApp using PATCH.
        /// </summary>
        /// <param name="iosLobAppToUpdate">The IosLobApp to update.</param>
        /// <returns>The updated IosLobApp.</returns>
        System.Threading.Tasks.Task<IosLobApp> UpdateAsync(IosLobApp iosLobAppToUpdate);

        /// <summary>
        /// Updates the specified IosLobApp using PATCH.
        /// </summary>
        /// <param name="iosLobAppToUpdate">The IosLobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosLobApp.</returns>
        System.Threading.Tasks.Task<IosLobApp> UpdateAsync(IosLobApp iosLobAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosLobAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosLobAppRequest Expand(Expression<Func<IosLobApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosLobAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosLobAppRequest Select(Expression<Func<IosLobApp, object>> selectExpression);

    }
}
