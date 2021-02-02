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
    /// The interface IWorkbookChartGridlinesFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartGridlinesFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartGridlinesFormat using POST.
        /// </summary>
        /// <param name="workbookChartGridlinesFormatToCreate">The WorkbookChartGridlinesFormat to create.</param>
        /// <returns>The created WorkbookChartGridlinesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlinesFormat> CreateAsync(WorkbookChartGridlinesFormat workbookChartGridlinesFormatToCreate);        /// <summary>
        /// Creates the specified WorkbookChartGridlinesFormat using POST.
        /// </summary>
        /// <param name="workbookChartGridlinesFormatToCreate">The WorkbookChartGridlinesFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartGridlinesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlinesFormat> CreateAsync(WorkbookChartGridlinesFormat workbookChartGridlinesFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartGridlinesFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartGridlinesFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartGridlinesFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartGridlinesFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartGridlinesFormat.
        /// </summary>
        /// <returns>The WorkbookChartGridlinesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlinesFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartGridlinesFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartGridlinesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlinesFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartGridlinesFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartGridlinesFormatToUpdate">The WorkbookChartGridlinesFormat to update.</param>
        /// <returns>The updated WorkbookChartGridlinesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlinesFormat> UpdateAsync(WorkbookChartGridlinesFormat workbookChartGridlinesFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartGridlinesFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartGridlinesFormatToUpdate">The WorkbookChartGridlinesFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartGridlinesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartGridlinesFormat> UpdateAsync(WorkbookChartGridlinesFormat workbookChartGridlinesFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartGridlinesFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartGridlinesFormatRequest Expand(Expression<Func<WorkbookChartGridlinesFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartGridlinesFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartGridlinesFormatRequest Select(Expression<Func<WorkbookChartGridlinesFormat, object>> selectExpression);

    }
}
