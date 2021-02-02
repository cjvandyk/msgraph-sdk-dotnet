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
    /// The interface IWindows10CompliancePolicyRequest.
    /// </summary>
    public partial interface IWindows10CompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10CompliancePolicy using POST.
        /// </summary>
        /// <param name="windows10CompliancePolicyToCreate">The Windows10CompliancePolicy to create.</param>
        /// <returns>The created Windows10CompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10CompliancePolicy> CreateAsync(Windows10CompliancePolicy windows10CompliancePolicyToCreate);        /// <summary>
        /// Creates the specified Windows10CompliancePolicy using POST.
        /// </summary>
        /// <param name="windows10CompliancePolicyToCreate">The Windows10CompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10CompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10CompliancePolicy> CreateAsync(Windows10CompliancePolicy windows10CompliancePolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10CompliancePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10CompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10CompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Windows10CompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10CompliancePolicy.
        /// </summary>
        /// <returns>The Windows10CompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10CompliancePolicy> GetAsync();

        /// <summary>
        /// Gets the specified Windows10CompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10CompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10CompliancePolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10CompliancePolicy using PATCH.
        /// </summary>
        /// <param name="windows10CompliancePolicyToUpdate">The Windows10CompliancePolicy to update.</param>
        /// <returns>The updated Windows10CompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10CompliancePolicy> UpdateAsync(Windows10CompliancePolicy windows10CompliancePolicyToUpdate);

        /// <summary>
        /// Updates the specified Windows10CompliancePolicy using PATCH.
        /// </summary>
        /// <param name="windows10CompliancePolicyToUpdate">The Windows10CompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10CompliancePolicy.</returns>
        System.Threading.Tasks.Task<Windows10CompliancePolicy> UpdateAsync(Windows10CompliancePolicy windows10CompliancePolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CompliancePolicyRequest Expand(Expression<Func<Windows10CompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10CompliancePolicyRequest Select(Expression<Func<Windows10CompliancePolicy, object>> selectExpression);

    }
}
