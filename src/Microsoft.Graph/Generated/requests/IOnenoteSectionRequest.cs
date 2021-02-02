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
    /// The interface IOnenoteSectionRequest.
    /// </summary>
    public partial interface IOnenoteSectionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnenoteSection using POST.
        /// </summary>
        /// <param name="onenoteSectionToCreate">The OnenoteSection to create.</param>
        /// <returns>The created OnenoteSection.</returns>
        System.Threading.Tasks.Task<OnenoteSection> CreateAsync(OnenoteSection onenoteSectionToCreate);        /// <summary>
        /// Creates the specified OnenoteSection using POST.
        /// </summary>
        /// <param name="onenoteSectionToCreate">The OnenoteSection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteSection.</returns>
        System.Threading.Tasks.Task<OnenoteSection> CreateAsync(OnenoteSection onenoteSectionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnenoteSection.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OnenoteSection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnenoteSection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified OnenoteSection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OnenoteSection.
        /// </summary>
        /// <returns>The OnenoteSection.</returns>
        System.Threading.Tasks.Task<OnenoteSection> GetAsync();

        /// <summary>
        /// Gets the specified OnenoteSection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteSection.</returns>
        System.Threading.Tasks.Task<OnenoteSection> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnenoteSection using PATCH.
        /// </summary>
        /// <param name="onenoteSectionToUpdate">The OnenoteSection to update.</param>
        /// <returns>The updated OnenoteSection.</returns>
        System.Threading.Tasks.Task<OnenoteSection> UpdateAsync(OnenoteSection onenoteSectionToUpdate);

        /// <summary>
        /// Updates the specified OnenoteSection using PATCH.
        /// </summary>
        /// <param name="onenoteSectionToUpdate">The OnenoteSection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnenoteSection.</returns>
        System.Threading.Tasks.Task<OnenoteSection> UpdateAsync(OnenoteSection onenoteSectionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteSectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteSectionRequest Expand(Expression<Func<OnenoteSection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteSectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteSectionRequest Select(Expression<Func<OnenoteSection, object>> selectExpression);

    }
}
