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
    /// The type WorkbookNamedItemRequest.
    /// </summary>
    public partial class WorkbookNamedItemRequest : BaseRequest, IWorkbookNamedItemRequest
    {
        /// <summary>
        /// Constructs a new WorkbookNamedItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookNamedItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookNamedItem using POST.
        /// </summary>
        /// <param name="workbookNamedItemToCreate">The WorkbookNamedItem to create.</param>
        /// <returns>The created WorkbookNamedItem.</returns>
        public System.Threading.Tasks.Task<WorkbookNamedItem> CreateAsync(WorkbookNamedItem workbookNamedItemToCreate)
        {
            return this.CreateAsync(workbookNamedItemToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookNamedItem using POST.
        /// </summary>
        /// <param name="workbookNamedItemToCreate">The WorkbookNamedItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookNamedItem.</returns>
        public async System.Threading.Tasks.Task<WorkbookNamedItem> CreateAsync(WorkbookNamedItem workbookNamedItemToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookNamedItem>(workbookNamedItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookNamedItem using POST and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <param name="workbookNamedItemToCreate">The WorkbookNamedItem to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> CreateResponseAsync(WorkbookNamedItem workbookNamedItemToCreate)
        {
            return this.CreateResponseAsync(workbookNamedItemToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookNamedItem using POST and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <param name="workbookNamedItemToCreate">The WorkbookNamedItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> CreateResponseAsync(WorkbookNamedItem workbookNamedItemToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookNamedItem>(workbookNamedItemToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookNamedItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookNamedItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookNamedItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookNamedItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookNamedItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookNamedItem.
        /// </summary>
        /// <returns>The WorkbookNamedItem.</returns>
        public System.Threading.Tasks.Task<WorkbookNamedItem> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookNamedItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookNamedItem.</returns>
        public async System.Threading.Tasks.Task<WorkbookNamedItem> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookNamedItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WorkbookNamedItem and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookNamedItem and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WorkbookNamedItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WorkbookNamedItem using PATCH.
        /// </summary>
        /// <param name="workbookNamedItemToUpdate">The WorkbookNamedItem to update.</param>
        /// <returns>The updated WorkbookNamedItem.</returns>
        public System.Threading.Tasks.Task<WorkbookNamedItem> UpdateAsync(WorkbookNamedItem workbookNamedItemToUpdate)
        {
            return this.UpdateAsync(workbookNamedItemToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookNamedItem using PATCH.
        /// </summary>
        /// <param name="workbookNamedItemToUpdate">The WorkbookNamedItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookNamedItem.</returns>
        public async System.Threading.Tasks.Task<WorkbookNamedItem> UpdateAsync(WorkbookNamedItem workbookNamedItemToUpdate, CancellationToken cancellationToken)
        {
			if (workbookNamedItemToUpdate.AdditionalData != null)
			{
				if (workbookNamedItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookNamedItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookNamedItemToUpdate.GetType().Name)
						});
				}
			}
            if (workbookNamedItemToUpdate.AdditionalData != null)
            {
                if (workbookNamedItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookNamedItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookNamedItemToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookNamedItem>(workbookNamedItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookNamedItem using PATCH and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <param name="workbookNamedItemToUpdate">The WorkbookNamedItem to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> UpdateResponseAsync(WorkbookNamedItem workbookNamedItemToUpdate)
        {
            return this.UpdateResponseAsync(workbookNamedItemToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookNamedItem using PATCH and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <param name="workbookNamedItemToUpdate">The WorkbookNamedItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> UpdateResponseAsync(WorkbookNamedItem workbookNamedItemToUpdate, CancellationToken cancellationToken)
        {
			if (workbookNamedItemToUpdate.AdditionalData != null)
			{
				if (workbookNamedItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookNamedItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookNamedItemToUpdate.GetType().Name)
						});
				}
			}
            if (workbookNamedItemToUpdate.AdditionalData != null)
            {
                if (workbookNamedItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookNamedItemToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookNamedItemToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WorkbookNamedItem>(workbookNamedItemToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookNamedItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookNamedItemRequest Expand(Expression<Func<WorkbookNamedItem, object>> expandExpression)
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
        public IWorkbookNamedItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookNamedItemRequest Select(Expression<Func<WorkbookNamedItem, object>> selectExpression)
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
        /// <param name="workbookNamedItemToInitialize">The <see cref="WorkbookNamedItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookNamedItem workbookNamedItemToInitialize)
        {

        }
    }
}
