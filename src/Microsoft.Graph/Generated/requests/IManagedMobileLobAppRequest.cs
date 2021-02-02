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
    /// The interface IManagedMobileLobAppRequest.
    /// </summary>
    public partial interface IManagedMobileLobAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedMobileLobApp using POST.
        /// </summary>
        /// <param name="managedMobileLobAppToCreate">The ManagedMobileLobApp to create.</param>
        /// <returns>The created ManagedMobileLobApp.</returns>
        System.Threading.Tasks.Task<ManagedMobileLobApp> CreateAsync(ManagedMobileLobApp managedMobileLobAppToCreate);        /// <summary>
        /// Creates the specified ManagedMobileLobApp using POST.
        /// </summary>
        /// <param name="managedMobileLobAppToCreate">The ManagedMobileLobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedMobileLobApp.</returns>
        System.Threading.Tasks.Task<ManagedMobileLobApp> CreateAsync(ManagedMobileLobApp managedMobileLobAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedMobileLobApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedMobileLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedMobileLobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified ManagedMobileLobApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedMobileLobApp.
        /// </summary>
        /// <returns>The ManagedMobileLobApp.</returns>
        System.Threading.Tasks.Task<ManagedMobileLobApp> GetAsync();

        /// <summary>
        /// Gets the specified ManagedMobileLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedMobileLobApp.</returns>
        System.Threading.Tasks.Task<ManagedMobileLobApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedMobileLobApp using PATCH.
        /// </summary>
        /// <param name="managedMobileLobAppToUpdate">The ManagedMobileLobApp to update.</param>
        /// <returns>The updated ManagedMobileLobApp.</returns>
        System.Threading.Tasks.Task<ManagedMobileLobApp> UpdateAsync(ManagedMobileLobApp managedMobileLobAppToUpdate);

        /// <summary>
        /// Updates the specified ManagedMobileLobApp using PATCH.
        /// </summary>
        /// <param name="managedMobileLobAppToUpdate">The ManagedMobileLobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedMobileLobApp.</returns>
        System.Threading.Tasks.Task<ManagedMobileLobApp> UpdateAsync(ManagedMobileLobApp managedMobileLobAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppRequest Expand(Expression<Func<ManagedMobileLobApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedMobileLobAppRequest Select(Expression<Func<ManagedMobileLobApp, object>> selectExpression);

    }
}
