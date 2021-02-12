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
    /// The type WorkbookChartLegendFormatRequest.
    /// </summary>
    public partial class WorkbookChartLegendFormatRequest : BaseRequest, IWorkbookChartLegendFormatRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartLegendFormatRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartLegendFormatRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartLegendFormat using POST.
        /// </summary>
        /// <param name="workbookChartLegendFormatToCreate">The WorkbookChartLegendFormat to create.</param>
        /// <returns>The created WorkbookChartLegendFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartLegendFormat> CreateAsync(WorkbookChartLegendFormat workbookChartLegendFormatToCreate)
        {
            return this.CreateAsync(workbookChartLegendFormatToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartLegendFormat using POST.
        /// </summary>
        /// <param name="workbookChartLegendFormatToCreate">The WorkbookChartLegendFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartLegendFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartLegendFormat> CreateAsync(WorkbookChartLegendFormat workbookChartLegendFormatToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChartLegendFormat>(workbookChartLegendFormatToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookChartLegendFormat using POST and returns a <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartLegendFormatToCreate">The WorkbookChartLegendFormat to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChartLegendFormat>> CreateResponseAsync(WorkbookChartLegendFormat workbookChartLegendFormatToCreate)
        {
            return this.CreateResponseAsync(workbookChartLegendFormatToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartLegendFormat using POST and returns a <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartLegendFormatToCreate">The WorkbookChartLegendFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartLegendFormat>> CreateResponseAsync(WorkbookChartLegendFormat workbookChartLegendFormatToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookChartLegendFormat>(workbookChartLegendFormatToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartLegendFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartLegendFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartLegendFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartLegendFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartLegendFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartLegendFormat.
        /// </summary>
        /// <returns>The WorkbookChartLegendFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartLegendFormat> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartLegendFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartLegendFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartLegendFormat> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartLegendFormat>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WorkbookChartLegendFormat and returns a <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChartLegendFormat>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartLegendFormat and returns a <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartLegendFormat>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WorkbookChartLegendFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WorkbookChartLegendFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartLegendFormatToUpdate">The WorkbookChartLegendFormat to update.</param>
        /// <returns>The updated WorkbookChartLegendFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartLegendFormat> UpdateAsync(WorkbookChartLegendFormat workbookChartLegendFormatToUpdate)
        {
            return this.UpdateAsync(workbookChartLegendFormatToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartLegendFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartLegendFormatToUpdate">The WorkbookChartLegendFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartLegendFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartLegendFormat> UpdateAsync(WorkbookChartLegendFormat workbookChartLegendFormatToUpdate, CancellationToken cancellationToken)
        {
			if (workbookChartLegendFormatToUpdate.AdditionalData != null)
			{
				if (workbookChartLegendFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookChartLegendFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartLegendFormatToUpdate.GetType().Name)
						});
				}
			}
            if (workbookChartLegendFormatToUpdate.AdditionalData != null)
            {
                if (workbookChartLegendFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookChartLegendFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartLegendFormatToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartLegendFormat>(workbookChartLegendFormatToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartLegendFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartLegendFormatToUpdate">The WorkbookChartLegendFormat to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChartLegendFormat>> UpdateResponseAsync(WorkbookChartLegendFormat workbookChartLegendFormatToUpdate)
        {
            return this.UpdateResponseAsync(workbookChartLegendFormatToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartLegendFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartLegendFormatToUpdate">The WorkbookChartLegendFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLegendFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartLegendFormat>> UpdateResponseAsync(WorkbookChartLegendFormat workbookChartLegendFormatToUpdate, CancellationToken cancellationToken)
        {
			if (workbookChartLegendFormatToUpdate.AdditionalData != null)
			{
				if (workbookChartLegendFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookChartLegendFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartLegendFormatToUpdate.GetType().Name)
						});
				}
			}
            if (workbookChartLegendFormatToUpdate.AdditionalData != null)
            {
                if (workbookChartLegendFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookChartLegendFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartLegendFormatToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WorkbookChartLegendFormat>(workbookChartLegendFormatToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartLegendFormatRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartLegendFormatRequest Expand(Expression<Func<WorkbookChartLegendFormat, object>> expandExpression)
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
        public IWorkbookChartLegendFormatRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartLegendFormatRequest Select(Expression<Func<WorkbookChartLegendFormat, object>> selectExpression)
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
        /// <param name="workbookChartLegendFormatToInitialize">The <see cref="WorkbookChartLegendFormat"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartLegendFormat workbookChartLegendFormatToInitialize)
        {

        }
    }
}
