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
    /// The interface IDeviceEnrollmentPlatformRestrictionsConfigurationRequest.
    /// </summary>
    public partial interface IDeviceEnrollmentPlatformRestrictionsConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceEnrollmentPlatformRestrictionsConfiguration using POST.
        /// </summary>
        /// <param name="deviceEnrollmentPlatformRestrictionsConfigurationToCreate">The DeviceEnrollmentPlatformRestrictionsConfiguration to create.</param>
        /// <returns>The created DeviceEnrollmentPlatformRestrictionsConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentPlatformRestrictionsConfiguration> CreateAsync(DeviceEnrollmentPlatformRestrictionsConfiguration deviceEnrollmentPlatformRestrictionsConfigurationToCreate);        /// <summary>
        /// Creates the specified DeviceEnrollmentPlatformRestrictionsConfiguration using POST.
        /// </summary>
        /// <param name="deviceEnrollmentPlatformRestrictionsConfigurationToCreate">The DeviceEnrollmentPlatformRestrictionsConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceEnrollmentPlatformRestrictionsConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentPlatformRestrictionsConfiguration> CreateAsync(DeviceEnrollmentPlatformRestrictionsConfiguration deviceEnrollmentPlatformRestrictionsConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceEnrollmentPlatformRestrictionsConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceEnrollmentPlatformRestrictionsConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceEnrollmentPlatformRestrictionsConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified DeviceEnrollmentPlatformRestrictionsConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceEnrollmentPlatformRestrictionsConfiguration.
        /// </summary>
        /// <returns>The DeviceEnrollmentPlatformRestrictionsConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentPlatformRestrictionsConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified DeviceEnrollmentPlatformRestrictionsConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceEnrollmentPlatformRestrictionsConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentPlatformRestrictionsConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceEnrollmentPlatformRestrictionsConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceEnrollmentPlatformRestrictionsConfigurationToUpdate">The DeviceEnrollmentPlatformRestrictionsConfiguration to update.</param>
        /// <returns>The updated DeviceEnrollmentPlatformRestrictionsConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentPlatformRestrictionsConfiguration> UpdateAsync(DeviceEnrollmentPlatformRestrictionsConfiguration deviceEnrollmentPlatformRestrictionsConfigurationToUpdate);

        /// <summary>
        /// Updates the specified DeviceEnrollmentPlatformRestrictionsConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceEnrollmentPlatformRestrictionsConfigurationToUpdate">The DeviceEnrollmentPlatformRestrictionsConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceEnrollmentPlatformRestrictionsConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceEnrollmentPlatformRestrictionsConfiguration> UpdateAsync(DeviceEnrollmentPlatformRestrictionsConfiguration deviceEnrollmentPlatformRestrictionsConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentPlatformRestrictionsConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentPlatformRestrictionsConfigurationRequest Expand(Expression<Func<DeviceEnrollmentPlatformRestrictionsConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentPlatformRestrictionsConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceEnrollmentPlatformRestrictionsConfigurationRequest Select(Expression<Func<DeviceEnrollmentPlatformRestrictionsConfiguration, object>> selectExpression);

    }
}
