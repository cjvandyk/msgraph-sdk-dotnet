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
    /// The interface IWindowsInformationProtectionAppLearningSummaryRequest.
    /// </summary>
    public partial interface IWindowsInformationProtectionAppLearningSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsInformationProtectionAppLearningSummary using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLearningSummaryToCreate">The WindowsInformationProtectionAppLearningSummary to create.</param>
        /// <returns>The created WindowsInformationProtectionAppLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> CreateAsync(WindowsInformationProtectionAppLearningSummary windowsInformationProtectionAppLearningSummaryToCreate);        /// <summary>
        /// Creates the specified WindowsInformationProtectionAppLearningSummary using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLearningSummaryToCreate">The WindowsInformationProtectionAppLearningSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtectionAppLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> CreateAsync(WindowsInformationProtectionAppLearningSummary windowsInformationProtectionAppLearningSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionAppLearningSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionAppLearningSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionAppLearningSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionAppLearningSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsInformationProtectionAppLearningSummary.
        /// </summary>
        /// <returns>The WindowsInformationProtectionAppLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> GetAsync();

        /// <summary>
        /// Gets the specified WindowsInformationProtectionAppLearningSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtectionAppLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionAppLearningSummary using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLearningSummaryToUpdate">The WindowsInformationProtectionAppLearningSummary to update.</param>
        /// <returns>The updated WindowsInformationProtectionAppLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> UpdateAsync(WindowsInformationProtectionAppLearningSummary windowsInformationProtectionAppLearningSummaryToUpdate);

        /// <summary>
        /// Updates the specified WindowsInformationProtectionAppLearningSummary using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionAppLearningSummaryToUpdate">The WindowsInformationProtectionAppLearningSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsInformationProtectionAppLearningSummary.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtectionAppLearningSummary> UpdateAsync(WindowsInformationProtectionAppLearningSummary windowsInformationProtectionAppLearningSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionAppLearningSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionAppLearningSummaryRequest Expand(Expression<Func<WindowsInformationProtectionAppLearningSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionAppLearningSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionAppLearningSummaryRequest Select(Expression<Func<WindowsInformationProtectionAppLearningSummary, object>> selectExpression);

    }
}
