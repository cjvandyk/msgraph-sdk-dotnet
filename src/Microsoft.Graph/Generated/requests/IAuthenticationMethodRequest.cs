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
    /// The interface IAuthenticationMethodRequest.
    /// </summary>
    public partial interface IAuthenticationMethodRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AuthenticationMethod using POST.
        /// </summary>
        /// <param name="authenticationMethodToCreate">The AuthenticationMethod to create.</param>
        /// <returns>The created AuthenticationMethod.</returns>
        System.Threading.Tasks.Task<AuthenticationMethod> CreateAsync(AuthenticationMethod authenticationMethodToCreate);

        /// <summary>
        /// Creates the specified AuthenticationMethod using POST.
        /// </summary>
        /// <param name="authenticationMethodToCreate">The AuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthenticationMethod.</returns>
        System.Threading.Tasks.Task<AuthenticationMethod> CreateAsync(AuthenticationMethod authenticationMethodToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified AuthenticationMethod using POST and returns a <see cref="GraphResponse{AuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="authenticationMethodToCreate">The AuthenticationMethod to create.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethod>> CreateResponseAsync(AuthenticationMethod authenticationMethodToCreate);

        /// <summary>
        /// Creates the specified AuthenticationMethod using POST and returns a <see cref="GraphResponse{AuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="authenticationMethodToCreate">The AuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethod>> CreateResponseAsync(AuthenticationMethod authenticationMethodToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AuthenticationMethod.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AuthenticationMethod and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified AuthenticationMethod and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AuthenticationMethod.
        /// </summary>
        /// <returns>The AuthenticationMethod.</returns>
        System.Threading.Tasks.Task<AuthenticationMethod> GetAsync();

        /// <summary>
        /// Gets the specified AuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuthenticationMethod.</returns>
        System.Threading.Tasks.Task<AuthenticationMethod> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AuthenticationMethod and returns a <see cref="GraphResponse{AuthenticationMethod}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethod>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AuthenticationMethod and returns a <see cref="GraphResponse{AuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethod>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="authenticationMethodToUpdate">The AuthenticationMethod to update.</param>
        /// <returns>The updated AuthenticationMethod.</returns>
        System.Threading.Tasks.Task<AuthenticationMethod> UpdateAsync(AuthenticationMethod authenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified AuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="authenticationMethodToUpdate">The AuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuthenticationMethod.</returns>
        System.Threading.Tasks.Task<AuthenticationMethod> UpdateAsync(AuthenticationMethod authenticationMethodToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AuthenticationMethod using PATCH and returns a <see cref="GraphResponse{AuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="authenticationMethodToUpdate">The AuthenticationMethod to update.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethod>> UpdateResponseAsync(AuthenticationMethod authenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified AuthenticationMethod using PATCH and returns a <see cref="GraphResponse{AuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="authenticationMethodToUpdate">The AuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethod>> UpdateResponseAsync(AuthenticationMethod authenticationMethodToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodRequest Expand(Expression<Func<AuthenticationMethod, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodRequest Select(Expression<Func<AuthenticationMethod, object>> selectExpression);

    }
}
