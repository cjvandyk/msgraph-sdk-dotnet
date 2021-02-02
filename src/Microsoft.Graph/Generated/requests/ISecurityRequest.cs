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
    /// The interface ISecurityRequest.
    /// </summary>
    public partial interface ISecurityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Security using POST.
        /// </summary>
        /// <param name="securityToCreate">The Security to create.</param>
        /// <returns>The created Security.</returns>
        System.Threading.Tasks.Task<Security> CreateAsync(Security securityToCreate);        /// <summary>
        /// Creates the specified Security using POST.
        /// </summary>
        /// <param name="securityToCreate">The Security to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Security.</returns>
        System.Threading.Tasks.Task<Security> CreateAsync(Security securityToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Security.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Security.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Security and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Security and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Security.
        /// </summary>
        /// <returns>The Security.</returns>
        System.Threading.Tasks.Task<Security> GetAsync();

        /// <summary>
        /// Gets the specified Security.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Security.</returns>
        System.Threading.Tasks.Task<Security> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Security using PATCH.
        /// </summary>
        /// <param name="securityToUpdate">The Security to update.</param>
        /// <returns>The updated Security.</returns>
        System.Threading.Tasks.Task<Security> UpdateAsync(Security securityToUpdate);

        /// <summary>
        /// Updates the specified Security using PATCH.
        /// </summary>
        /// <param name="securityToUpdate">The Security to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Security.</returns>
        System.Threading.Tasks.Task<Security> UpdateAsync(Security securityToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityRequest Expand(Expression<Func<Security, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityRequest Select(Expression<Func<Security, object>> selectExpression);

    }
}
