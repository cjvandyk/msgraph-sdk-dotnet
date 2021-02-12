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
    /// The type Fido2AuthenticationMethodConfigurationRequest.
    /// </summary>
    public partial class Fido2AuthenticationMethodConfigurationRequest : BaseRequest, IFido2AuthenticationMethodConfigurationRequest
    {
        /// <summary>
        /// Constructs a new Fido2AuthenticationMethodConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Fido2AuthenticationMethodConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Fido2AuthenticationMethodConfiguration using POST.
        /// </summary>
        /// <param name="fido2AuthenticationMethodConfigurationToCreate">The Fido2AuthenticationMethodConfiguration to create.</param>
        /// <returns>The created Fido2AuthenticationMethodConfiguration.</returns>
        public System.Threading.Tasks.Task<Fido2AuthenticationMethodConfiguration> CreateAsync(Fido2AuthenticationMethodConfiguration fido2AuthenticationMethodConfigurationToCreate)
        {
            return this.CreateAsync(fido2AuthenticationMethodConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Fido2AuthenticationMethodConfiguration using POST.
        /// </summary>
        /// <param name="fido2AuthenticationMethodConfigurationToCreate">The Fido2AuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Fido2AuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<Fido2AuthenticationMethodConfiguration> CreateAsync(Fido2AuthenticationMethodConfiguration fido2AuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Fido2AuthenticationMethodConfiguration>(fido2AuthenticationMethodConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Fido2AuthenticationMethodConfiguration using POST and returns a <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="fido2AuthenticationMethodConfigurationToCreate">The Fido2AuthenticationMethodConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Fido2AuthenticationMethodConfiguration>> CreateResponseAsync(Fido2AuthenticationMethodConfiguration fido2AuthenticationMethodConfigurationToCreate)
        {
            return this.CreateResponseAsync(fido2AuthenticationMethodConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Fido2AuthenticationMethodConfiguration using POST and returns a <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="fido2AuthenticationMethodConfigurationToCreate">The Fido2AuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Fido2AuthenticationMethodConfiguration>> CreateResponseAsync(Fido2AuthenticationMethodConfiguration fido2AuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Fido2AuthenticationMethodConfiguration>(fido2AuthenticationMethodConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Fido2AuthenticationMethodConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Fido2AuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Fido2AuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Fido2AuthenticationMethodConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Fido2AuthenticationMethodConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Fido2AuthenticationMethodConfiguration.
        /// </summary>
        /// <returns>The Fido2AuthenticationMethodConfiguration.</returns>
        public System.Threading.Tasks.Task<Fido2AuthenticationMethodConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Fido2AuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Fido2AuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<Fido2AuthenticationMethodConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Fido2AuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Fido2AuthenticationMethodConfiguration and returns a <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Fido2AuthenticationMethodConfiguration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Fido2AuthenticationMethodConfiguration and returns a <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Fido2AuthenticationMethodConfiguration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<Fido2AuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified Fido2AuthenticationMethodConfiguration using PATCH.
        /// </summary>
        /// <param name="fido2AuthenticationMethodConfigurationToUpdate">The Fido2AuthenticationMethodConfiguration to update.</param>
        /// <returns>The updated Fido2AuthenticationMethodConfiguration.</returns>
        public System.Threading.Tasks.Task<Fido2AuthenticationMethodConfiguration> UpdateAsync(Fido2AuthenticationMethodConfiguration fido2AuthenticationMethodConfigurationToUpdate)
        {
            return this.UpdateAsync(fido2AuthenticationMethodConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Fido2AuthenticationMethodConfiguration using PATCH.
        /// </summary>
        /// <param name="fido2AuthenticationMethodConfigurationToUpdate">The Fido2AuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Fido2AuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<Fido2AuthenticationMethodConfiguration> UpdateAsync(Fido2AuthenticationMethodConfiguration fido2AuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (fido2AuthenticationMethodConfigurationToUpdate.AdditionalData != null)
			{
				if (fido2AuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					fido2AuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, fido2AuthenticationMethodConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (fido2AuthenticationMethodConfigurationToUpdate.AdditionalData != null)
            {
                if (fido2AuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    fido2AuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, fido2AuthenticationMethodConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Fido2AuthenticationMethodConfiguration>(fido2AuthenticationMethodConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Fido2AuthenticationMethodConfiguration using PATCH and returns a <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="fido2AuthenticationMethodConfigurationToUpdate">The Fido2AuthenticationMethodConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Fido2AuthenticationMethodConfiguration>> UpdateResponseAsync(Fido2AuthenticationMethodConfiguration fido2AuthenticationMethodConfigurationToUpdate)
        {
            return this.UpdateResponseAsync(fido2AuthenticationMethodConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Fido2AuthenticationMethodConfiguration using PATCH and returns a <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="fido2AuthenticationMethodConfigurationToUpdate">The Fido2AuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Fido2AuthenticationMethodConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Fido2AuthenticationMethodConfiguration>> UpdateResponseAsync(Fido2AuthenticationMethodConfiguration fido2AuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (fido2AuthenticationMethodConfigurationToUpdate.AdditionalData != null)
			{
				if (fido2AuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					fido2AuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, fido2AuthenticationMethodConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (fido2AuthenticationMethodConfigurationToUpdate.AdditionalData != null)
            {
                if (fido2AuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    fido2AuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, fido2AuthenticationMethodConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Fido2AuthenticationMethodConfiguration>(fido2AuthenticationMethodConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IFido2AuthenticationMethodConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IFido2AuthenticationMethodConfigurationRequest Expand(Expression<Func<Fido2AuthenticationMethodConfiguration, object>> expandExpression)
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
        public IFido2AuthenticationMethodConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IFido2AuthenticationMethodConfigurationRequest Select(Expression<Func<Fido2AuthenticationMethodConfiguration, object>> selectExpression)
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
        /// <param name="fido2AuthenticationMethodConfigurationToInitialize">The <see cref="Fido2AuthenticationMethodConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Fido2AuthenticationMethodConfiguration fido2AuthenticationMethodConfigurationToInitialize)
        {

            if (fido2AuthenticationMethodConfigurationToInitialize != null && fido2AuthenticationMethodConfigurationToInitialize.AdditionalData != null)
            {

                if (fido2AuthenticationMethodConfigurationToInitialize.IncludeTargets != null && fido2AuthenticationMethodConfigurationToInitialize.IncludeTargets.CurrentPage != null)
                {
                    fido2AuthenticationMethodConfigurationToInitialize.IncludeTargets.AdditionalData = fido2AuthenticationMethodConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    fido2AuthenticationMethodConfigurationToInitialize.AdditionalData.TryGetValue("includeTargets@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        fido2AuthenticationMethodConfigurationToInitialize.IncludeTargets.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
