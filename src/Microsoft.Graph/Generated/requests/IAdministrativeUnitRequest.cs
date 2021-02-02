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
    /// The interface IAdministrativeUnitRequest.
    /// </summary>
    public partial interface IAdministrativeUnitRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AdministrativeUnit using POST.
        /// </summary>
        /// <param name="administrativeUnitToCreate">The AdministrativeUnit to create.</param>
        /// <returns>The created AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> CreateAsync(AdministrativeUnit administrativeUnitToCreate);        /// <summary>
        /// Creates the specified AdministrativeUnit using POST.
        /// </summary>
        /// <param name="administrativeUnitToCreate">The AdministrativeUnit to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> CreateAsync(AdministrativeUnit administrativeUnitToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AdministrativeUnit.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AdministrativeUnit.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AdministrativeUnit and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified AdministrativeUnit and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AdministrativeUnit.
        /// </summary>
        /// <returns>The AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> GetAsync();

        /// <summary>
        /// Gets the specified AdministrativeUnit.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AdministrativeUnit using PATCH.
        /// </summary>
        /// <param name="administrativeUnitToUpdate">The AdministrativeUnit to update.</param>
        /// <returns>The updated AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> UpdateAsync(AdministrativeUnit administrativeUnitToUpdate);

        /// <summary>
        /// Updates the specified AdministrativeUnit using PATCH.
        /// </summary>
        /// <param name="administrativeUnitToUpdate">The AdministrativeUnit to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> UpdateAsync(AdministrativeUnit administrativeUnitToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdministrativeUnitRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdministrativeUnitRequest Expand(Expression<Func<AdministrativeUnit, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAdministrativeUnitRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAdministrativeUnitRequest Select(Expression<Func<AdministrativeUnit, object>> selectExpression);

    }
}
