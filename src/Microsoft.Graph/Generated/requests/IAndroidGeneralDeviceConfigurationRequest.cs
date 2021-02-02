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
    /// The interface IAndroidGeneralDeviceConfigurationRequest.
    /// </summary>
    public partial interface IAndroidGeneralDeviceConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidGeneralDeviceConfiguration using POST.
        /// </summary>
        /// <param name="androidGeneralDeviceConfigurationToCreate">The AndroidGeneralDeviceConfiguration to create.</param>
        /// <returns>The created AndroidGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidGeneralDeviceConfiguration> CreateAsync(AndroidGeneralDeviceConfiguration androidGeneralDeviceConfigurationToCreate);        /// <summary>
        /// Creates the specified AndroidGeneralDeviceConfiguration using POST.
        /// </summary>
        /// <param name="androidGeneralDeviceConfigurationToCreate">The AndroidGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidGeneralDeviceConfiguration> CreateAsync(AndroidGeneralDeviceConfiguration androidGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidGeneralDeviceConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidGeneralDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified AndroidGeneralDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidGeneralDeviceConfiguration.
        /// </summary>
        /// <returns>The AndroidGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidGeneralDeviceConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidGeneralDeviceConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidGeneralDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="androidGeneralDeviceConfigurationToUpdate">The AndroidGeneralDeviceConfiguration to update.</param>
        /// <returns>The updated AndroidGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidGeneralDeviceConfiguration> UpdateAsync(AndroidGeneralDeviceConfiguration androidGeneralDeviceConfigurationToUpdate);

        /// <summary>
        /// Updates the specified AndroidGeneralDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="androidGeneralDeviceConfigurationToUpdate">The AndroidGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidGeneralDeviceConfiguration> UpdateAsync(AndroidGeneralDeviceConfiguration androidGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidGeneralDeviceConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidGeneralDeviceConfigurationRequest Expand(Expression<Func<AndroidGeneralDeviceConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidGeneralDeviceConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidGeneralDeviceConfigurationRequest Select(Expression<Func<AndroidGeneralDeviceConfiguration, object>> selectExpression);

    }
}
