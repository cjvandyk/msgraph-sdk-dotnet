// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWorkbookNamesCollectionRequest.
    /// </summary>
    public partial interface IWorkbookNamesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified WorkbookNamedItem to the collection via POST.
        /// </summary>
        /// <param name="workbookNamedItem">The WorkbookNamedItem to add.</param>
        /// <returns>The created WorkbookNamedItem.</returns>
        System.Threading.Tasks.Task<WorkbookNamedItem> AddAsync(WorkbookNamedItem workbookNamedItem);

        /// <summary>
        /// Adds the specified WorkbookNamedItem to the collection via POST.
        /// </summary>
        /// <param name="workbookNamedItem">The WorkbookNamedItem to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookNamedItem.</returns>
        System.Threading.Tasks.Task<WorkbookNamedItem> AddAsync(WorkbookNamedItem workbookNamedItem, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IWorkbookNamesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IWorkbookNamesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{WorkbookNamesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WorkbookNamesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookNamesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{WorkbookNamesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookNamesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookNamesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamesCollectionRequest Expand(Expression<Func<WorkbookNamedItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamesCollectionRequest Select(Expression<Func<WorkbookNamedItem, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamesCollectionRequest OrderBy(string value);
    }
}
