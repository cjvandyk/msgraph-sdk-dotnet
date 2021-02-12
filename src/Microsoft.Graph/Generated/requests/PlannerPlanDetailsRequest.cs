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
    /// The type PlannerPlanDetailsRequest.
    /// </summary>
    public partial class PlannerPlanDetailsRequest : BaseRequest, IPlannerPlanDetailsRequest
    {
        /// <summary>
        /// Constructs a new PlannerPlanDetailsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PlannerPlanDetailsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PlannerPlanDetails using POST.
        /// </summary>
        /// <param name="plannerPlanDetailsToCreate">The PlannerPlanDetails to create.</param>
        /// <returns>The created PlannerPlanDetails.</returns>
        public System.Threading.Tasks.Task<PlannerPlanDetails> CreateAsync(PlannerPlanDetails plannerPlanDetailsToCreate)
        {
            return this.CreateAsync(plannerPlanDetailsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PlannerPlanDetails using POST.
        /// </summary>
        /// <param name="plannerPlanDetailsToCreate">The PlannerPlanDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerPlanDetails.</returns>
        public async System.Threading.Tasks.Task<PlannerPlanDetails> CreateAsync(PlannerPlanDetails plannerPlanDetailsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<PlannerPlanDetails>(plannerPlanDetailsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PlannerPlanDetails using POST and returns a <see cref="GraphResponse{PlannerPlanDetails}"/> object.
        /// </summary>
        /// <param name="plannerPlanDetailsToCreate">The PlannerPlanDetails to create.</param>
        /// <returns>The <see cref="GraphResponse{PlannerPlanDetails}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerPlanDetails>> CreateResponseAsync(PlannerPlanDetails plannerPlanDetailsToCreate)
        {
            return this.CreateResponseAsync(plannerPlanDetailsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PlannerPlanDetails using POST and returns a <see cref="GraphResponse{PlannerPlanDetails}"/> object.
        /// </summary>
        /// <param name="plannerPlanDetailsToCreate">The PlannerPlanDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerPlanDetails}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerPlanDetails>> CreateResponseAsync(PlannerPlanDetails plannerPlanDetailsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<PlannerPlanDetails>(plannerPlanDetailsToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PlannerPlanDetails.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PlannerPlanDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<PlannerPlanDetails>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PlannerPlanDetails and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PlannerPlanDetails and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified PlannerPlanDetails.
        /// </summary>
        /// <returns>The PlannerPlanDetails.</returns>
        public System.Threading.Tasks.Task<PlannerPlanDetails> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PlannerPlanDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerPlanDetails.</returns>
        public async System.Threading.Tasks.Task<PlannerPlanDetails> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<PlannerPlanDetails>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PlannerPlanDetails and returns a <see cref="GraphResponse{PlannerPlanDetails}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PlannerPlanDetails}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerPlanDetails>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PlannerPlanDetails and returns a <see cref="GraphResponse{PlannerPlanDetails}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerPlanDetails}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerPlanDetails>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<PlannerPlanDetails>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified PlannerPlanDetails using PATCH.
        /// </summary>
        /// <param name="plannerPlanDetailsToUpdate">The PlannerPlanDetails to update.</param>
        /// <returns>The updated PlannerPlanDetails.</returns>
        public System.Threading.Tasks.Task<PlannerPlanDetails> UpdateAsync(PlannerPlanDetails plannerPlanDetailsToUpdate)
        {
            return this.UpdateAsync(plannerPlanDetailsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PlannerPlanDetails using PATCH.
        /// </summary>
        /// <param name="plannerPlanDetailsToUpdate">The PlannerPlanDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerPlanDetails.</returns>
        public async System.Threading.Tasks.Task<PlannerPlanDetails> UpdateAsync(PlannerPlanDetails plannerPlanDetailsToUpdate, CancellationToken cancellationToken)
        {
			if (plannerPlanDetailsToUpdate.AdditionalData != null)
			{
				if (plannerPlanDetailsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					plannerPlanDetailsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, plannerPlanDetailsToUpdate.GetType().Name)
						});
				}
			}
            if (plannerPlanDetailsToUpdate.AdditionalData != null)
            {
                if (plannerPlanDetailsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    plannerPlanDetailsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, plannerPlanDetailsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<PlannerPlanDetails>(plannerPlanDetailsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PlannerPlanDetails using PATCH and returns a <see cref="GraphResponse{PlannerPlanDetails}"/> object.
        /// </summary>
        /// <param name="plannerPlanDetailsToUpdate">The PlannerPlanDetails to update.</param>
        /// <returns>The <see cref="GraphResponse{PlannerPlanDetails}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerPlanDetails>> UpdateResponseAsync(PlannerPlanDetails plannerPlanDetailsToUpdate)
        {
            return this.UpdateResponseAsync(plannerPlanDetailsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PlannerPlanDetails using PATCH and returns a <see cref="GraphResponse{PlannerPlanDetails}"/> object.
        /// </summary>
        /// <param name="plannerPlanDetailsToUpdate">The PlannerPlanDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlannerPlanDetails}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerPlanDetails>> UpdateResponseAsync(PlannerPlanDetails plannerPlanDetailsToUpdate, CancellationToken cancellationToken)
        {
			if (plannerPlanDetailsToUpdate.AdditionalData != null)
			{
				if (plannerPlanDetailsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					plannerPlanDetailsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, plannerPlanDetailsToUpdate.GetType().Name)
						});
				}
			}
            if (plannerPlanDetailsToUpdate.AdditionalData != null)
            {
                if (plannerPlanDetailsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    plannerPlanDetailsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, plannerPlanDetailsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<PlannerPlanDetails>(plannerPlanDetailsToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerPlanDetailsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerPlanDetailsRequest Expand(Expression<Func<PlannerPlanDetails, object>> expandExpression)
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
        public IPlannerPlanDetailsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerPlanDetailsRequest Select(Expression<Func<PlannerPlanDetails, object>> selectExpression)
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
        /// <param name="plannerPlanDetailsToInitialize">The <see cref="PlannerPlanDetails"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PlannerPlanDetails plannerPlanDetailsToInitialize)
        {

        }
    }
}
