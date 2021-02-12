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
    /// The type WorkbookChartDataLabelFormatRequest.
    /// </summary>
    public partial class WorkbookChartDataLabelFormatRequest : BaseRequest, IWorkbookChartDataLabelFormatRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartDataLabelFormatRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartDataLabelFormatRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartDataLabelFormat using POST.
        /// </summary>
        /// <param name="workbookChartDataLabelFormatToCreate">The WorkbookChartDataLabelFormat to create.</param>
        /// <returns>The created WorkbookChartDataLabelFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartDataLabelFormat> CreateAsync(WorkbookChartDataLabelFormat workbookChartDataLabelFormatToCreate)
        {
            return this.CreateAsync(workbookChartDataLabelFormatToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartDataLabelFormat using POST.
        /// </summary>
        /// <param name="workbookChartDataLabelFormatToCreate">The WorkbookChartDataLabelFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartDataLabelFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartDataLabelFormat> CreateAsync(WorkbookChartDataLabelFormat workbookChartDataLabelFormatToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChartDataLabelFormat>(workbookChartDataLabelFormatToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WorkbookChartDataLabelFormat using POST and returns a <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartDataLabelFormatToCreate">The WorkbookChartDataLabelFormat to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChartDataLabelFormat>> CreateResponseAsync(WorkbookChartDataLabelFormat workbookChartDataLabelFormatToCreate)
        {
            return this.CreateResponseAsync(workbookChartDataLabelFormatToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartDataLabelFormat using POST and returns a <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartDataLabelFormatToCreate">The WorkbookChartDataLabelFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartDataLabelFormat>> CreateResponseAsync(WorkbookChartDataLabelFormat workbookChartDataLabelFormatToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookChartDataLabelFormat>(workbookChartDataLabelFormatToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartDataLabelFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartDataLabelFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartDataLabelFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartDataLabelFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartDataLabelFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartDataLabelFormat.
        /// </summary>
        /// <returns>The WorkbookChartDataLabelFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartDataLabelFormat> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartDataLabelFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartDataLabelFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartDataLabelFormat> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartDataLabelFormat>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WorkbookChartDataLabelFormat and returns a <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChartDataLabelFormat>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartDataLabelFormat and returns a <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartDataLabelFormat>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WorkbookChartDataLabelFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WorkbookChartDataLabelFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartDataLabelFormatToUpdate">The WorkbookChartDataLabelFormat to update.</param>
        /// <returns>The updated WorkbookChartDataLabelFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartDataLabelFormat> UpdateAsync(WorkbookChartDataLabelFormat workbookChartDataLabelFormatToUpdate)
        {
            return this.UpdateAsync(workbookChartDataLabelFormatToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartDataLabelFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartDataLabelFormatToUpdate">The WorkbookChartDataLabelFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartDataLabelFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartDataLabelFormat> UpdateAsync(WorkbookChartDataLabelFormat workbookChartDataLabelFormatToUpdate, CancellationToken cancellationToken)
        {
			if (workbookChartDataLabelFormatToUpdate.AdditionalData != null)
			{
				if (workbookChartDataLabelFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookChartDataLabelFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartDataLabelFormatToUpdate.GetType().Name)
						});
				}
			}
            if (workbookChartDataLabelFormatToUpdate.AdditionalData != null)
            {
                if (workbookChartDataLabelFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookChartDataLabelFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartDataLabelFormatToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartDataLabelFormat>(workbookChartDataLabelFormatToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartDataLabelFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartDataLabelFormatToUpdate">The WorkbookChartDataLabelFormat to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WorkbookChartDataLabelFormat>> UpdateResponseAsync(WorkbookChartDataLabelFormat workbookChartDataLabelFormatToUpdate)
        {
            return this.UpdateResponseAsync(workbookChartDataLabelFormatToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartDataLabelFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartDataLabelFormatToUpdate">The WorkbookChartDataLabelFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartDataLabelFormat}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookChartDataLabelFormat>> UpdateResponseAsync(WorkbookChartDataLabelFormat workbookChartDataLabelFormatToUpdate, CancellationToken cancellationToken)
        {
			if (workbookChartDataLabelFormatToUpdate.AdditionalData != null)
			{
				if (workbookChartDataLabelFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookChartDataLabelFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartDataLabelFormatToUpdate.GetType().Name)
						});
				}
			}
            if (workbookChartDataLabelFormatToUpdate.AdditionalData != null)
            {
                if (workbookChartDataLabelFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookChartDataLabelFormatToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookChartDataLabelFormatToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WorkbookChartDataLabelFormat>(workbookChartDataLabelFormatToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartDataLabelFormatRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartDataLabelFormatRequest Expand(Expression<Func<WorkbookChartDataLabelFormat, object>> expandExpression)
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
        public IWorkbookChartDataLabelFormatRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartDataLabelFormatRequest Select(Expression<Func<WorkbookChartDataLabelFormat, object>> selectExpression)
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
        /// <param name="workbookChartDataLabelFormatToInitialize">The <see cref="WorkbookChartDataLabelFormat"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartDataLabelFormat workbookChartDataLabelFormatToInitialize)
        {

        }
    }
}
