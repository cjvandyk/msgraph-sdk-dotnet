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
    /// The interface IMobileAppContentRequest.
    /// </summary>
    public partial interface IMobileAppContentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MobileAppContent using POST.
        /// </summary>
        /// <param name="mobileAppContentToCreate">The MobileAppContent to create.</param>
        /// <returns>The created MobileAppContent.</returns>
        System.Threading.Tasks.Task<MobileAppContent> CreateAsync(MobileAppContent mobileAppContentToCreate);        /// <summary>
        /// Creates the specified MobileAppContent using POST.
        /// </summary>
        /// <param name="mobileAppContentToCreate">The MobileAppContent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppContent.</returns>
        System.Threading.Tasks.Task<MobileAppContent> CreateAsync(MobileAppContent mobileAppContentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MobileAppContent.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MobileAppContent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MobileAppContent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified MobileAppContent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MobileAppContent.
        /// </summary>
        /// <returns>The MobileAppContent.</returns>
        System.Threading.Tasks.Task<MobileAppContent> GetAsync();

        /// <summary>
        /// Gets the specified MobileAppContent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppContent.</returns>
        System.Threading.Tasks.Task<MobileAppContent> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MobileAppContent using PATCH.
        /// </summary>
        /// <param name="mobileAppContentToUpdate">The MobileAppContent to update.</param>
        /// <returns>The updated MobileAppContent.</returns>
        System.Threading.Tasks.Task<MobileAppContent> UpdateAsync(MobileAppContent mobileAppContentToUpdate);

        /// <summary>
        /// Updates the specified MobileAppContent using PATCH.
        /// </summary>
        /// <param name="mobileAppContentToUpdate">The MobileAppContent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppContent.</returns>
        System.Threading.Tasks.Task<MobileAppContent> UpdateAsync(MobileAppContent mobileAppContentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppContentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppContentRequest Expand(Expression<Func<MobileAppContent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppContentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppContentRequest Select(Expression<Func<MobileAppContent, object>> selectExpression);

    }
}
