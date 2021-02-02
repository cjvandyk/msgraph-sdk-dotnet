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
    /// The interface IOnenoteEntitySchemaObjectModelRequest.
    /// </summary>
    public partial interface IOnenoteEntitySchemaObjectModelRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnenoteEntitySchemaObjectModel using POST.
        /// </summary>
        /// <param name="onenoteEntitySchemaObjectModelToCreate">The OnenoteEntitySchemaObjectModel to create.</param>
        /// <returns>The created OnenoteEntitySchemaObjectModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntitySchemaObjectModel> CreateAsync(OnenoteEntitySchemaObjectModel onenoteEntitySchemaObjectModelToCreate);        /// <summary>
        /// Creates the specified OnenoteEntitySchemaObjectModel using POST.
        /// </summary>
        /// <param name="onenoteEntitySchemaObjectModelToCreate">The OnenoteEntitySchemaObjectModel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnenoteEntitySchemaObjectModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntitySchemaObjectModel> CreateAsync(OnenoteEntitySchemaObjectModel onenoteEntitySchemaObjectModelToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnenoteEntitySchemaObjectModel.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OnenoteEntitySchemaObjectModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnenoteEntitySchemaObjectModel and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified OnenoteEntitySchemaObjectModel and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OnenoteEntitySchemaObjectModel.
        /// </summary>
        /// <returns>The OnenoteEntitySchemaObjectModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntitySchemaObjectModel> GetAsync();

        /// <summary>
        /// Gets the specified OnenoteEntitySchemaObjectModel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnenoteEntitySchemaObjectModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntitySchemaObjectModel> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnenoteEntitySchemaObjectModel using PATCH.
        /// </summary>
        /// <param name="onenoteEntitySchemaObjectModelToUpdate">The OnenoteEntitySchemaObjectModel to update.</param>
        /// <returns>The updated OnenoteEntitySchemaObjectModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntitySchemaObjectModel> UpdateAsync(OnenoteEntitySchemaObjectModel onenoteEntitySchemaObjectModelToUpdate);

        /// <summary>
        /// Updates the specified OnenoteEntitySchemaObjectModel using PATCH.
        /// </summary>
        /// <param name="onenoteEntitySchemaObjectModelToUpdate">The OnenoteEntitySchemaObjectModel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnenoteEntitySchemaObjectModel.</returns>
        System.Threading.Tasks.Task<OnenoteEntitySchemaObjectModel> UpdateAsync(OnenoteEntitySchemaObjectModel onenoteEntitySchemaObjectModelToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntitySchemaObjectModelRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntitySchemaObjectModelRequest Expand(Expression<Func<OnenoteEntitySchemaObjectModel, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntitySchemaObjectModelRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteEntitySchemaObjectModelRequest Select(Expression<Func<OnenoteEntitySchemaObjectModel, object>> selectExpression);

    }
}
