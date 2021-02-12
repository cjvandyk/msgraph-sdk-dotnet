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
    /// The interface ITodoTaskLinkedResourcesCollectionRequest.
    /// </summary>
    public partial interface ITodoTaskLinkedResourcesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified LinkedResource to the collection via POST.
        /// </summary>
        /// <param name="linkedResource">The LinkedResource to add.</param>
        /// <returns>The created LinkedResource.</returns>
        System.Threading.Tasks.Task<LinkedResource> AddAsync(LinkedResource linkedResource);

        /// <summary>
        /// Adds the specified LinkedResource to the collection via POST.
        /// </summary>
        /// <param name="linkedResource">The LinkedResource to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LinkedResource.</returns>
        System.Threading.Tasks.Task<LinkedResource> AddAsync(LinkedResource linkedResource, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ITodoTaskLinkedResourcesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ITodoTaskLinkedResourcesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{TodoTaskLinkedResourcesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TodoTaskLinkedResourcesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<TodoTaskLinkedResourcesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{TodoTaskLinkedResourcesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TodoTaskLinkedResourcesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<TodoTaskLinkedResourcesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskLinkedResourcesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskLinkedResourcesCollectionRequest Expand(Expression<Func<LinkedResource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskLinkedResourcesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskLinkedResourcesCollectionRequest Select(Expression<Func<LinkedResource, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskLinkedResourcesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskLinkedResourcesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskLinkedResourcesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ITodoTaskLinkedResourcesCollectionRequest OrderBy(string value);
    }
}
