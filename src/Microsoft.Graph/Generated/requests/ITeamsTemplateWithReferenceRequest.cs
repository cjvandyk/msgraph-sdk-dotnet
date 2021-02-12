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
    /// The interface ITeamsTemplateWithReferenceRequest.
    /// </summary>
    public partial interface ITeamsTemplateWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified TeamsTemplate.
        /// </summary>
        /// <returns>The TeamsTemplate.</returns>
        System.Threading.Tasks.Task<TeamsTemplate> GetAsync();

        /// <summary>
        /// Gets the specified TeamsTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsTemplate.</returns>
        System.Threading.Tasks.Task<TeamsTemplate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TeamsTemplate and returns a <see cref="GraphResponse{TeamsTemplate}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TeamsTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsTemplate>> GetResponseAsync();

        /// <summary>
        /// Gets the specified TeamsTemplate and returns a <see cref="GraphResponse{TeamsTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsTemplate>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified TeamsTemplate using POST.
        /// </summary>
        /// <param name="teamsTemplateToCreate">The TeamsTemplate to create.</param>
        /// <returns>The created TeamsTemplate.</returns>
        System.Threading.Tasks.Task<TeamsTemplate> CreateAsync(TeamsTemplate teamsTemplateToCreate);

        /// <summary>
        /// Creates the specified TeamsTemplate using POST.
        /// </summary>
        /// <param name="teamsTemplateToCreate">The TeamsTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsTemplate.</returns>
        System.Threading.Tasks.Task<TeamsTemplate> CreateAsync(TeamsTemplate teamsTemplateToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified TeamsTemplate using POST and returns a <see cref="GraphResponse{TeamsTemplate}"/> object.
        /// </summary>
        /// <param name="teamsTemplateToCreate">The TeamsTemplate to create.</param>
        /// <returns>The <see cref="GraphResponse{TeamsTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsTemplate>> CreateResponseAsync(TeamsTemplate teamsTemplateToCreate);

        /// <summary>
        /// Creates the specified TeamsTemplate using POST and returns a <see cref="GraphResponse{TeamsTemplate}"/> object.
        /// </summary>
        /// <param name="teamsTemplateToCreate">The TeamsTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsTemplate>> CreateResponseAsync(TeamsTemplate teamsTemplateToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified TeamsTemplate using PATCH.
        /// </summary>
        /// <param name="teamsTemplateToUpdate">The TeamsTemplate to update.</param>
        /// <returns>The updated TeamsTemplate.</returns>
        System.Threading.Tasks.Task<TeamsTemplate> UpdateAsync(TeamsTemplate teamsTemplateToUpdate);

        /// <summary>
        /// Updates the specified TeamsTemplate using PATCH.
        /// </summary>
        /// <param name="teamsTemplateToUpdate">The TeamsTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsTemplate.</returns>
        System.Threading.Tasks.Task<TeamsTemplate> UpdateAsync(TeamsTemplate teamsTemplateToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified TeamsTemplate using PATCH and returns a <see cref="GraphResponse{TeamsTemplate}"/> object.
        /// </summary>
        /// <param name="teamsTemplateToUpdate">The TeamsTemplate to update.</param>
        /// <returns>The <see cref="GraphResponse{TeamsTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsTemplate>> UpdateResponseAsync(TeamsTemplate teamsTemplateToUpdate);

        /// <summary>
        /// Updates the specified TeamsTemplate using PATCH and returns a <see cref="GraphResponse{TeamsTemplate}"/> object.
        /// </summary>
        /// <param name="teamsTemplateToUpdate">The TeamsTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsTemplate>> UpdateResponseAsync(TeamsTemplate teamsTemplateToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified TeamsTemplate.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TeamsTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified TeamsTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified TeamsTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsTemplateWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsTemplateWithReferenceRequest Expand(Expression<Func<TeamsTemplate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsTemplateWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsTemplateWithReferenceRequest Select(Expression<Func<TeamsTemplate, object>> selectExpression);

    }
}
