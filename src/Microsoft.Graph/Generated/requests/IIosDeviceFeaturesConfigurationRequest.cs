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
    /// The interface IIosDeviceFeaturesConfigurationRequest.
    /// </summary>
    public partial interface IIosDeviceFeaturesConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosDeviceFeaturesConfiguration using POST.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToCreate">The IosDeviceFeaturesConfiguration to create.</param>
        /// <returns>The created IosDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> CreateAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToCreate);

        /// <summary>
        /// Creates the specified IosDeviceFeaturesConfiguration using POST.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToCreate">The IosDeviceFeaturesConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> CreateAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified IosDeviceFeaturesConfiguration using POST and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToCreate">The IosDeviceFeaturesConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> CreateResponseAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToCreate);

        /// <summary>
        /// Creates the specified IosDeviceFeaturesConfiguration using POST and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToCreate">The IosDeviceFeaturesConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> CreateResponseAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosDeviceFeaturesConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosDeviceFeaturesConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosDeviceFeaturesConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified IosDeviceFeaturesConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosDeviceFeaturesConfiguration.
        /// </summary>
        /// <returns>The IosDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified IosDeviceFeaturesConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosDeviceFeaturesConfiguration and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified IosDeviceFeaturesConfiguration and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosDeviceFeaturesConfiguration using PATCH.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToUpdate">The IosDeviceFeaturesConfiguration to update.</param>
        /// <returns>The updated IosDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> UpdateAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToUpdate);

        /// <summary>
        /// Updates the specified IosDeviceFeaturesConfiguration using PATCH.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToUpdate">The IosDeviceFeaturesConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<IosDeviceFeaturesConfiguration> UpdateAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosDeviceFeaturesConfiguration using PATCH and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToUpdate">The IosDeviceFeaturesConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> UpdateResponseAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToUpdate);

        /// <summary>
        /// Updates the specified IosDeviceFeaturesConfiguration using PATCH and returns a <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="iosDeviceFeaturesConfigurationToUpdate">The IosDeviceFeaturesConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosDeviceFeaturesConfiguration>> UpdateResponseAsync(IosDeviceFeaturesConfiguration iosDeviceFeaturesConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosDeviceFeaturesConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosDeviceFeaturesConfigurationRequest Expand(Expression<Func<IosDeviceFeaturesConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosDeviceFeaturesConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosDeviceFeaturesConfigurationRequest Select(Expression<Func<IosDeviceFeaturesConfiguration, object>> selectExpression);

    }
}
