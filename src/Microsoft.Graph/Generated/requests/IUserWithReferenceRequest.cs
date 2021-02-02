// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IUserWithReferenceRequest.
    /// </summary>
    public partial interface IUserWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified User.
        /// </summary>
        /// <returns>The User.</returns>
        System.Threading.Tasks.Task<User> GetAsync();

        /// <summary>
        /// Gets the specified User.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The User.</returns>
        System.Threading.Tasks.Task<User> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified User using POST.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <returns>The created User.</returns>
        System.Threading.Tasks.Task<User> CreateAsync(User userToCreate);        /// <summary>
        /// Creates the specified User using POST.
        /// </summary>
        /// <param name="userToCreate">The User to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created User.</returns>
        System.Threading.Tasks.Task<User> CreateAsync(User userToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified User using PATCH.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <returns>The updated User.</returns>
        System.Threading.Tasks.Task<User> UpdateAsync(User userToUpdate);

        /// <summary>
        /// Updates the specified User using PATCH.
        /// </summary>
        /// <param name="userToUpdate">The User to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated User.</returns>
        System.Threading.Tasks.Task<User> UpdateAsync(User userToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified User.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified User.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified User and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified User and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserWithReferenceRequest Expand(Expression<Func<User, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserWithReferenceRequest Select(Expression<Func<User, object>> selectExpression);

    }
}
