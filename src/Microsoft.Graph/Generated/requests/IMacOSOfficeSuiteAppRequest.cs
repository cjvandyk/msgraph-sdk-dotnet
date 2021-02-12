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
    /// The interface IMacOSOfficeSuiteAppRequest.
    /// </summary>
    public partial interface IMacOSOfficeSuiteAppRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSOfficeSuiteApp using POST.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToCreate">The MacOSOfficeSuiteApp to create.</param>
        /// <returns>The created MacOSOfficeSuiteApp.</returns>
        System.Threading.Tasks.Task<MacOSOfficeSuiteApp> CreateAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToCreate);

        /// <summary>
        /// Creates the specified MacOSOfficeSuiteApp using POST.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToCreate">The MacOSOfficeSuiteApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSOfficeSuiteApp.</returns>
        System.Threading.Tasks.Task<MacOSOfficeSuiteApp> CreateAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified MacOSOfficeSuiteApp using POST and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToCreate">The MacOSOfficeSuiteApp to create.</param>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> CreateResponseAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToCreate);

        /// <summary>
        /// Creates the specified MacOSOfficeSuiteApp using POST and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToCreate">The MacOSOfficeSuiteApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> CreateResponseAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSOfficeSuiteApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSOfficeSuiteApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSOfficeSuiteApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified MacOSOfficeSuiteApp and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSOfficeSuiteApp.
        /// </summary>
        /// <returns>The MacOSOfficeSuiteApp.</returns>
        System.Threading.Tasks.Task<MacOSOfficeSuiteApp> GetAsync();

        /// <summary>
        /// Gets the specified MacOSOfficeSuiteApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSOfficeSuiteApp.</returns>
        System.Threading.Tasks.Task<MacOSOfficeSuiteApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSOfficeSuiteApp and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> GetResponseAsync();

        /// <summary>
        /// Gets the specified MacOSOfficeSuiteApp and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSOfficeSuiteApp using PATCH.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToUpdate">The MacOSOfficeSuiteApp to update.</param>
        /// <returns>The updated MacOSOfficeSuiteApp.</returns>
        System.Threading.Tasks.Task<MacOSOfficeSuiteApp> UpdateAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToUpdate);

        /// <summary>
        /// Updates the specified MacOSOfficeSuiteApp using PATCH.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToUpdate">The MacOSOfficeSuiteApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSOfficeSuiteApp.</returns>
        System.Threading.Tasks.Task<MacOSOfficeSuiteApp> UpdateAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSOfficeSuiteApp using PATCH and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToUpdate">The MacOSOfficeSuiteApp to update.</param>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> UpdateResponseAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToUpdate);

        /// <summary>
        /// Updates the specified MacOSOfficeSuiteApp using PATCH and returns a <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object.
        /// </summary>
        /// <param name="macOSOfficeSuiteAppToUpdate">The MacOSOfficeSuiteApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSOfficeSuiteApp}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSOfficeSuiteApp>> UpdateResponseAsync(MacOSOfficeSuiteApp macOSOfficeSuiteAppToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSOfficeSuiteAppRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSOfficeSuiteAppRequest Expand(Expression<Func<MacOSOfficeSuiteApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSOfficeSuiteAppRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSOfficeSuiteAppRequest Select(Expression<Func<MacOSOfficeSuiteApp, object>> selectExpression);

    }
}
