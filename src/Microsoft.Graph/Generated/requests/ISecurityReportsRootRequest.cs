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
    /// The interface ISecurityReportsRootRequest.
    /// </summary>
    public partial interface ISecurityReportsRootRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecurityReportsRoot using POST.
        /// </summary>
        /// <param name="securityReportsRootToCreate">The SecurityReportsRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecurityReportsRoot.</returns>
        System.Threading.Tasks.Task<SecurityReportsRoot> CreateAsync(SecurityReportsRoot securityReportsRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SecurityReportsRoot using POST and returns a <see cref="GraphResponse{SecurityReportsRoot}"/> object.
        /// </summary>
        /// <param name="securityReportsRootToCreate">The SecurityReportsRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityReportsRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityReportsRoot>> CreateResponseAsync(SecurityReportsRoot securityReportsRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SecurityReportsRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SecurityReportsRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SecurityReportsRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecurityReportsRoot.</returns>
        System.Threading.Tasks.Task<SecurityReportsRoot> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SecurityReportsRoot and returns a <see cref="GraphResponse{SecurityReportsRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityReportsRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityReportsRoot>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SecurityReportsRoot using PATCH.
        /// </summary>
        /// <param name="securityReportsRootToUpdate">The SecurityReportsRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecurityReportsRoot.</returns>
        System.Threading.Tasks.Task<SecurityReportsRoot> UpdateAsync(SecurityReportsRoot securityReportsRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SecurityReportsRoot using PATCH and returns a <see cref="GraphResponse{SecurityReportsRoot}"/> object.
        /// </summary>
        /// <param name="securityReportsRootToUpdate">The SecurityReportsRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SecurityReportsRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityReportsRoot>> UpdateResponseAsync(SecurityReportsRoot securityReportsRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SecurityReportsRoot using PUT.
        /// </summary>
        /// <param name="securityReportsRootToUpdate">The SecurityReportsRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SecurityReportsRoot> PutAsync(SecurityReportsRoot securityReportsRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SecurityReportsRoot using PUT and returns a <see cref="GraphResponse{SecurityReportsRoot}"/> object.
        /// </summary>
        /// <param name="securityReportsRootToUpdate">The SecurityReportsRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SecurityReportsRoot}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityReportsRoot>> PutResponseAsync(SecurityReportsRoot securityReportsRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityReportsRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityReportsRootRequest Expand(Expression<Func<SecurityReportsRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityReportsRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityReportsRootRequest Select(Expression<Func<SecurityReportsRoot, object>> selectExpression);

    }
}
