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
    /// The interface IWindowsHelloForBusinessAuthenticationMethodRequest.
    /// </summary>
    public partial interface IWindowsHelloForBusinessAuthenticationMethodRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsHelloForBusinessAuthenticationMethod using POST.
        /// </summary>
        /// <param name="windowsHelloForBusinessAuthenticationMethodToCreate">The WindowsHelloForBusinessAuthenticationMethod to create.</param>
        /// <returns>The created WindowsHelloForBusinessAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<WindowsHelloForBusinessAuthenticationMethod> CreateAsync(WindowsHelloForBusinessAuthenticationMethod windowsHelloForBusinessAuthenticationMethodToCreate);

        /// <summary>
        /// Creates the specified WindowsHelloForBusinessAuthenticationMethod using POST.
        /// </summary>
        /// <param name="windowsHelloForBusinessAuthenticationMethodToCreate">The WindowsHelloForBusinessAuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsHelloForBusinessAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<WindowsHelloForBusinessAuthenticationMethod> CreateAsync(WindowsHelloForBusinessAuthenticationMethod windowsHelloForBusinessAuthenticationMethodToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WindowsHelloForBusinessAuthenticationMethod using POST and returns a <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="windowsHelloForBusinessAuthenticationMethodToCreate">The WindowsHelloForBusinessAuthenticationMethod to create.</param>
        /// <returns>The <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsHelloForBusinessAuthenticationMethod>> CreateResponseAsync(WindowsHelloForBusinessAuthenticationMethod windowsHelloForBusinessAuthenticationMethodToCreate);

        /// <summary>
        /// Creates the specified WindowsHelloForBusinessAuthenticationMethod using POST and returns a <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="windowsHelloForBusinessAuthenticationMethodToCreate">The WindowsHelloForBusinessAuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsHelloForBusinessAuthenticationMethod>> CreateResponseAsync(WindowsHelloForBusinessAuthenticationMethod windowsHelloForBusinessAuthenticationMethodToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsHelloForBusinessAuthenticationMethod.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsHelloForBusinessAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsHelloForBusinessAuthenticationMethod and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WindowsHelloForBusinessAuthenticationMethod and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsHelloForBusinessAuthenticationMethod.
        /// </summary>
        /// <returns>The WindowsHelloForBusinessAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<WindowsHelloForBusinessAuthenticationMethod> GetAsync();

        /// <summary>
        /// Gets the specified WindowsHelloForBusinessAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsHelloForBusinessAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<WindowsHelloForBusinessAuthenticationMethod> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsHelloForBusinessAuthenticationMethod and returns a <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsHelloForBusinessAuthenticationMethod>> GetResponseAsync();

        /// <summary>
        /// Gets the specified WindowsHelloForBusinessAuthenticationMethod and returns a <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsHelloForBusinessAuthenticationMethod>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsHelloForBusinessAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="windowsHelloForBusinessAuthenticationMethodToUpdate">The WindowsHelloForBusinessAuthenticationMethod to update.</param>
        /// <returns>The updated WindowsHelloForBusinessAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<WindowsHelloForBusinessAuthenticationMethod> UpdateAsync(WindowsHelloForBusinessAuthenticationMethod windowsHelloForBusinessAuthenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified WindowsHelloForBusinessAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="windowsHelloForBusinessAuthenticationMethodToUpdate">The WindowsHelloForBusinessAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsHelloForBusinessAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<WindowsHelloForBusinessAuthenticationMethod> UpdateAsync(WindowsHelloForBusinessAuthenticationMethod windowsHelloForBusinessAuthenticationMethodToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsHelloForBusinessAuthenticationMethod using PATCH and returns a <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="windowsHelloForBusinessAuthenticationMethodToUpdate">The WindowsHelloForBusinessAuthenticationMethod to update.</param>
        /// <returns>The <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsHelloForBusinessAuthenticationMethod>> UpdateResponseAsync(WindowsHelloForBusinessAuthenticationMethod windowsHelloForBusinessAuthenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified WindowsHelloForBusinessAuthenticationMethod using PATCH and returns a <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="windowsHelloForBusinessAuthenticationMethodToUpdate">The WindowsHelloForBusinessAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsHelloForBusinessAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsHelloForBusinessAuthenticationMethod>> UpdateResponseAsync(WindowsHelloForBusinessAuthenticationMethod windowsHelloForBusinessAuthenticationMethodToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsHelloForBusinessAuthenticationMethodRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsHelloForBusinessAuthenticationMethodRequest Expand(Expression<Func<WindowsHelloForBusinessAuthenticationMethod, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsHelloForBusinessAuthenticationMethodRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsHelloForBusinessAuthenticationMethodRequest Select(Expression<Func<WindowsHelloForBusinessAuthenticationMethod, object>> selectExpression);

    }
}
