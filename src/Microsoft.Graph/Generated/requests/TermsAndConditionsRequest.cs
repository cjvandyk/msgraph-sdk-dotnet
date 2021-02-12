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
    /// The type TermsAndConditionsRequest.
    /// </summary>
    public partial class TermsAndConditionsRequest : BaseRequest, ITermsAndConditionsRequest
    {
        /// <summary>
        /// Constructs a new TermsAndConditionsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TermsAndConditionsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TermsAndConditions using POST.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <returns>The created TermsAndConditions.</returns>
        public System.Threading.Tasks.Task<TermsAndConditions> CreateAsync(TermsAndConditions termsAndConditionsToCreate)
        {
            return this.CreateAsync(termsAndConditionsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TermsAndConditions using POST.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TermsAndConditions.</returns>
        public async System.Threading.Tasks.Task<TermsAndConditions> CreateAsync(TermsAndConditions termsAndConditionsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<TermsAndConditions>(termsAndConditionsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified TermsAndConditions using POST and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <returns>The <see cref="GraphResponse{TermsAndConditions}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> CreateResponseAsync(TermsAndConditions termsAndConditionsToCreate)
        {
            return this.CreateResponseAsync(termsAndConditionsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TermsAndConditions using POST and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TermsAndConditions}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> CreateResponseAsync(TermsAndConditions termsAndConditionsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<TermsAndConditions>(termsAndConditionsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TermsAndConditions.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TermsAndConditions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<TermsAndConditions>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified TermsAndConditions and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TermsAndConditions and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified TermsAndConditions.
        /// </summary>
        /// <returns>The TermsAndConditions.</returns>
        public System.Threading.Tasks.Task<TermsAndConditions> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TermsAndConditions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TermsAndConditions.</returns>
        public async System.Threading.Tasks.Task<TermsAndConditions> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<TermsAndConditions>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified TermsAndConditions and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TermsAndConditions}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TermsAndConditions and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TermsAndConditions}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<TermsAndConditions>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified TermsAndConditions using PATCH.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <returns>The updated TermsAndConditions.</returns>
        public System.Threading.Tasks.Task<TermsAndConditions> UpdateAsync(TermsAndConditions termsAndConditionsToUpdate)
        {
            return this.UpdateAsync(termsAndConditionsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TermsAndConditions using PATCH.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TermsAndConditions.</returns>
        public async System.Threading.Tasks.Task<TermsAndConditions> UpdateAsync(TermsAndConditions termsAndConditionsToUpdate, CancellationToken cancellationToken)
        {
			if (termsAndConditionsToUpdate.AdditionalData != null)
			{
				if (termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, termsAndConditionsToUpdate.GetType().Name)
						});
				}
			}
            if (termsAndConditionsToUpdate.AdditionalData != null)
            {
                if (termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, termsAndConditionsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<TermsAndConditions>(termsAndConditionsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified TermsAndConditions using PATCH and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <returns>The <see cref="GraphResponse{TermsAndConditions}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> UpdateResponseAsync(TermsAndConditions termsAndConditionsToUpdate)
        {
            return this.UpdateResponseAsync(termsAndConditionsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TermsAndConditions using PATCH and returns a <see cref="GraphResponse{TermsAndConditions}"/> object.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TermsAndConditions}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<TermsAndConditions>> UpdateResponseAsync(TermsAndConditions termsAndConditionsToUpdate, CancellationToken cancellationToken)
        {
			if (termsAndConditionsToUpdate.AdditionalData != null)
			{
				if (termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, termsAndConditionsToUpdate.GetType().Name)
						});
				}
			}
            if (termsAndConditionsToUpdate.AdditionalData != null)
            {
                if (termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, termsAndConditionsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<TermsAndConditions>(termsAndConditionsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITermsAndConditionsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITermsAndConditionsRequest Expand(Expression<Func<TermsAndConditions, object>> expandExpression)
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
        public ITermsAndConditionsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITermsAndConditionsRequest Select(Expression<Func<TermsAndConditions, object>> selectExpression)
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
        /// <param name="termsAndConditionsToInitialize">The <see cref="TermsAndConditions"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TermsAndConditions termsAndConditionsToInitialize)
        {

            if (termsAndConditionsToInitialize != null && termsAndConditionsToInitialize.AdditionalData != null)
            {

                if (termsAndConditionsToInitialize.AcceptanceStatuses != null && termsAndConditionsToInitialize.AcceptanceStatuses.CurrentPage != null)
                {
                    termsAndConditionsToInitialize.AcceptanceStatuses.AdditionalData = termsAndConditionsToInitialize.AdditionalData;

                    object nextPageLink;
                    termsAndConditionsToInitialize.AdditionalData.TryGetValue("acceptanceStatuses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        termsAndConditionsToInitialize.AcceptanceStatuses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (termsAndConditionsToInitialize.Assignments != null && termsAndConditionsToInitialize.Assignments.CurrentPage != null)
                {
                    termsAndConditionsToInitialize.Assignments.AdditionalData = termsAndConditionsToInitialize.AdditionalData;

                    object nextPageLink;
                    termsAndConditionsToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        termsAndConditionsToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
