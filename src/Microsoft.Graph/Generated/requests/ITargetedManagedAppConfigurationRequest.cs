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
    /// The interface ITargetedManagedAppConfigurationRequest.
    /// </summary>
    public partial interface ITargetedManagedAppConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <returns>The created TargetedManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppConfiguration> CreateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate);

        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TargetedManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppConfiguration> CreateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> CreateResponseAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate);

        /// <summary>
        /// Creates the specified TargetedManagedAppConfiguration using POST and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToCreate">The TargetedManagedAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> CreateResponseAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified TargetedManagedAppConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <returns>The TargetedManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified TargetedManagedAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TargetedManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TargetedManagedAppConfiguration and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified TargetedManagedAppConfiguration and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration to update.</param>
        /// <returns>The updated TargetedManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppConfiguration> UpdateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate);

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TargetedManagedAppConfiguration.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppConfiguration> UpdateAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PATCH and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> UpdateResponseAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate);

        /// <summary>
        /// Updates the specified TargetedManagedAppConfiguration using PATCH and returns a <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object.
        /// </summary>
        /// <param name="targetedManagedAppConfigurationToUpdate">The TargetedManagedAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TargetedManagedAppConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TargetedManagedAppConfiguration>> UpdateResponseAsync(TargetedManagedAppConfiguration targetedManagedAppConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppConfigurationRequest Expand(Expression<Func<TargetedManagedAppConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppConfigurationRequest Select(Expression<Func<TargetedManagedAppConfiguration, object>> selectExpression);

    }
}
