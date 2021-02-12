// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ManagedDeviceMobileAppConfigurationUserSummaryRequest.
    /// </summary>
    public partial class ManagedDeviceMobileAppConfigurationUserSummaryRequest : BaseRequest, IManagedDeviceMobileAppConfigurationUserSummaryRequest
    {
        /// <summary>
        /// Constructs a new ManagedDeviceMobileAppConfigurationUserSummaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ManagedDeviceMobileAppConfigurationUserSummaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationUserSummary using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserSummaryToCreate">The ManagedDeviceMobileAppConfigurationUserSummary to create.</param>
        /// <returns>The created ManagedDeviceMobileAppConfigurationUserSummary.</returns>
        public System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationUserSummary> CreateAsync(ManagedDeviceMobileAppConfigurationUserSummary managedDeviceMobileAppConfigurationUserSummaryToCreate)
        {
            return this.CreateAsync(managedDeviceMobileAppConfigurationUserSummaryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationUserSummary using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserSummaryToCreate">The ManagedDeviceMobileAppConfigurationUserSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceMobileAppConfigurationUserSummary.</returns>
        public async System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationUserSummary> CreateAsync(ManagedDeviceMobileAppConfigurationUserSummary managedDeviceMobileAppConfigurationUserSummaryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ManagedDeviceMobileAppConfigurationUserSummary>(managedDeviceMobileAppConfigurationUserSummaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationUserSummary using POST and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserSummaryToCreate">The ManagedDeviceMobileAppConfigurationUserSummary to create.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationUserSummary>> CreateResponseAsync(ManagedDeviceMobileAppConfigurationUserSummary managedDeviceMobileAppConfigurationUserSummaryToCreate)
        {
            return this.CreateResponseAsync(managedDeviceMobileAppConfigurationUserSummaryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationUserSummary using POST and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserSummaryToCreate">The ManagedDeviceMobileAppConfigurationUserSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationUserSummary>> CreateResponseAsync(ManagedDeviceMobileAppConfigurationUserSummary managedDeviceMobileAppConfigurationUserSummaryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<ManagedDeviceMobileAppConfigurationUserSummary>(managedDeviceMobileAppConfigurationUserSummaryToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationUserSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationUserSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ManagedDeviceMobileAppConfigurationUserSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationUserSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationUserSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationUserSummary.
        /// </summary>
        /// <returns>The ManagedDeviceMobileAppConfigurationUserSummary.</returns>
        public System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationUserSummary> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationUserSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDeviceMobileAppConfigurationUserSummary.</returns>
        public async System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationUserSummary> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ManagedDeviceMobileAppConfigurationUserSummary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationUserSummary and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationUserSummary>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationUserSummary and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationUserSummary>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<ManagedDeviceMobileAppConfigurationUserSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationUserSummary using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserSummaryToUpdate">The ManagedDeviceMobileAppConfigurationUserSummary to update.</param>
        /// <returns>The updated ManagedDeviceMobileAppConfigurationUserSummary.</returns>
        public System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationUserSummary> UpdateAsync(ManagedDeviceMobileAppConfigurationUserSummary managedDeviceMobileAppConfigurationUserSummaryToUpdate)
        {
            return this.UpdateAsync(managedDeviceMobileAppConfigurationUserSummaryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationUserSummary using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserSummaryToUpdate">The ManagedDeviceMobileAppConfigurationUserSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDeviceMobileAppConfigurationUserSummary.</returns>
        public async System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationUserSummary> UpdateAsync(ManagedDeviceMobileAppConfigurationUserSummary managedDeviceMobileAppConfigurationUserSummaryToUpdate, CancellationToken cancellationToken)
        {
			if (managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData != null)
			{
				if (managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedDeviceMobileAppConfigurationUserSummaryToUpdate.GetType().Name)
						});
				}
			}
            if (managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData != null)
            {
                if (managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedDeviceMobileAppConfigurationUserSummaryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ManagedDeviceMobileAppConfigurationUserSummary>(managedDeviceMobileAppConfigurationUserSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationUserSummary using PATCH and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserSummaryToUpdate">The ManagedDeviceMobileAppConfigurationUserSummary to update.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationUserSummary>> UpdateResponseAsync(ManagedDeviceMobileAppConfigurationUserSummary managedDeviceMobileAppConfigurationUserSummaryToUpdate)
        {
            return this.UpdateResponseAsync(managedDeviceMobileAppConfigurationUserSummaryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationUserSummary using PATCH and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserSummaryToUpdate">The ManagedDeviceMobileAppConfigurationUserSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserSummary}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationUserSummary>> UpdateResponseAsync(ManagedDeviceMobileAppConfigurationUserSummary managedDeviceMobileAppConfigurationUserSummaryToUpdate, CancellationToken cancellationToken)
        {
			if (managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData != null)
			{
				if (managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedDeviceMobileAppConfigurationUserSummaryToUpdate.GetType().Name)
						});
				}
			}
            if (managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData != null)
            {
                if (managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    managedDeviceMobileAppConfigurationUserSummaryToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, managedDeviceMobileAppConfigurationUserSummaryToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<ManagedDeviceMobileAppConfigurationUserSummary>(managedDeviceMobileAppConfigurationUserSummaryToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceMobileAppConfigurationUserSummaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceMobileAppConfigurationUserSummaryRequest Expand(Expression<Func<ManagedDeviceMobileAppConfigurationUserSummary, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceMobileAppConfigurationUserSummaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IManagedDeviceMobileAppConfigurationUserSummaryRequest Select(Expression<Func<ManagedDeviceMobileAppConfigurationUserSummary, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserSummaryToInitialize">The <see cref="ManagedDeviceMobileAppConfigurationUserSummary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ManagedDeviceMobileAppConfigurationUserSummary managedDeviceMobileAppConfigurationUserSummaryToInitialize)
        {

        }
    }
}
