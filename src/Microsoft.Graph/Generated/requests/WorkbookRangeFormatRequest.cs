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
    /// The type WorkbookRangeFormatRequest.
    /// </summary>
    public partial class WorkbookRangeFormatRequest : BaseRequest, IWorkbookRangeFormatRequest
    {
        /// <summary>
        /// Constructs a new WorkbookRangeFormatRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookRangeFormatRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFormat using POST.
        /// </summary>
        /// <param name="workbookRangeFormatToCreate">The WorkbookRangeFormat to create.</param>
        /// <returns>The created WorkbookRangeFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeFormat> CreateAsync(WorkbookRangeFormat workbookRangeFormatToCreate)
        {
            return this.CreateAsync(workbookRangeFormatToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFormat using POST.
        /// </summary>
        /// <param name="workbookRangeFormatToCreate">The WorkbookRangeFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFormat> CreateAsync(WorkbookRangeFormat workbookRangeFormatToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookRangeFormat>(workbookRangeFormatToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFormat using POST and returns a <see cref="GraphResponse{WorkbookRangeFormat}"/> object.
        /// </summary>
        /// <param name="workbookRangeFormatToCreate">The WorkbookRangeFormat to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFormat>> CreateResponseAsync(WorkbookRangeFormat workbookRangeFormatToCreate)
        {
            return this.CreateResponseAsync(workbookRangeFormatToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookRangeFormat using POST and returns a <see cref="GraphResponse{WorkbookRangeFormat}"/> object.
        /// </summary>
        /// <param name="workbookRangeFormatToCreate">The WorkbookRangeFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFormat>> CreateResponseAsync(WorkbookRangeFormat workbookRangeFormatToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookRangeFormat>(workbookRangeFormatToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookRangeFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookRangeFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFormat.
        /// </summary>
        /// <returns>The WorkbookRangeFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeFormat> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFormat> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookRangeFormat>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFormat and returns a <see cref="GraphResponse{WorkbookRangeFormat}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFormat>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookRangeFormat and returns a <see cref="GraphResponse{WorkbookRangeFormat}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFormat>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WorkbookRangeFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFormat using PATCH.
        /// </summary>
        /// <param name="workbookRangeFormatToUpdate">The WorkbookRangeFormat to update.</param>
        /// <returns>The updated WorkbookRangeFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeFormat> UpdateAsync(WorkbookRangeFormat workbookRangeFormatToUpdate)
        {
            return this.UpdateAsync(workbookRangeFormatToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFormat using PATCH.
        /// </summary>
        /// <param name="workbookRangeFormatToUpdate">The WorkbookRangeFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRangeFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookRangeFormat> UpdateAsync(WorkbookRangeFormat workbookRangeFormatToUpdate, CancellationToken cancellationToken)
        {
			if (workbookRangeFormatToUpdate.AdditionalData != null)
			{
				if (workbookRangeFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookRangeFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFormatToUpdate.GetType().Name)
						});
				}
			}
            if (workbookRangeFormatToUpdate.AdditionalData != null)
            {
                if (workbookRangeFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookRangeFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFormatToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookRangeFormat>(workbookRangeFormatToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFormat using PATCH and returns a <see cref="GraphResponse{WorkbookRangeFormat}"/> object.
        /// </summary>
        /// <param name="workbookRangeFormatToUpdate">The WorkbookRangeFormat to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFormat>> UpdateResponseAsync(WorkbookRangeFormat workbookRangeFormatToUpdate)
        {
            return this.UpdateResponseAsync(workbookRangeFormatToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookRangeFormat using PATCH and returns a <see cref="GraphResponse{WorkbookRangeFormat}"/> object.
        /// </summary>
        /// <param name="workbookRangeFormatToUpdate">The WorkbookRangeFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFormat>> UpdateResponseAsync(WorkbookRangeFormat workbookRangeFormatToUpdate, CancellationToken cancellationToken)
        {
			if (workbookRangeFormatToUpdate.AdditionalData != null)
			{
				if (workbookRangeFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookRangeFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFormatToUpdate.GetType().Name)
						});
				}
			}
            if (workbookRangeFormatToUpdate.AdditionalData != null)
            {
                if (workbookRangeFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookRangeFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookRangeFormatToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WorkbookRangeFormat>(workbookRangeFormatToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFormatRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFormatRequest Expand(Expression<Func<WorkbookRangeFormat, object>> expandExpression)
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
        public IWorkbookRangeFormatRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeFormatRequest Select(Expression<Func<WorkbookRangeFormat, object>> selectExpression)
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
        /// <param name="workbookRangeFormatToInitialize">The <see cref="WorkbookRangeFormat"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookRangeFormat workbookRangeFormatToInitialize)
        {

            if (workbookRangeFormatToInitialize != null && workbookRangeFormatToInitialize.AdditionalData != null)
            {

                if (workbookRangeFormatToInitialize.Borders != null && workbookRangeFormatToInitialize.Borders.CurrentPage != null)
                {
                    workbookRangeFormatToInitialize.Borders.AdditionalData = workbookRangeFormatToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookRangeFormatToInitialize.AdditionalData.TryGetValue("borders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookRangeFormatToInitialize.Borders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
