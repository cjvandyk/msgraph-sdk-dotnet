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
    /// The interface IDriveItemChildrenCollectionRequest.
    /// </summary>
    public partial interface IDriveItemChildrenCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified DriveItem to the collection via POST.
        /// </summary>
        /// <param name="driveItem">The DriveItem to add.</param>
        /// <returns>The created DriveItem.</returns>
        System.Threading.Tasks.Task<DriveItem> AddAsync(DriveItem driveItem);

        /// <summary>
        /// Adds the specified DriveItem to the collection via POST.
        /// </summary>
        /// <param name="driveItem">The DriveItem to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DriveItem.</returns>
        System.Threading.Tasks.Task<DriveItem> AddAsync(DriveItem driveItem, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDriveItemChildrenCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDriveItemChildrenCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DriveItemChildrenCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DriveItemChildrenCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DriveItemChildrenCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DriveItemChildrenCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DriveItemChildrenCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<DriveItemChildrenCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemChildrenCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemChildrenCollectionRequest Expand(Expression<Func<DriveItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemChildrenCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemChildrenCollectionRequest Select(Expression<Func<DriveItem, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemChildrenCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemChildrenCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemChildrenCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDriveItemChildrenCollectionRequest OrderBy(string value);
    }
}
