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
    /// The type WorkbookWorksheetProtectionRequest.
    /// </summary>
    public partial class WorkbookWorksheetProtectionRequest : BaseRequest, IWorkbookWorksheetProtectionRequest
    {
        /// <summary>
        /// Constructs a new WorkbookWorksheetProtectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookWorksheetProtectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookWorksheetProtection using POST.
        /// </summary>
        /// <param name="workbookWorksheetProtectionToCreate">The WorkbookWorksheetProtection to create.</param>
        /// <returns>The created WorkbookWorksheetProtection.</returns>
        public System.Threading.Tasks.Task<WorkbookWorksheetProtection> CreateAsync(WorkbookWorksheetProtection workbookWorksheetProtectionToCreate)
        {
            return this.CreateAsync(workbookWorksheetProtectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookWorksheetProtection using POST.
        /// </summary>
        /// <param name="workbookWorksheetProtectionToCreate">The WorkbookWorksheetProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookWorksheetProtection.</returns>
        public async System.Threading.Tasks.Task<WorkbookWorksheetProtection> CreateAsync(WorkbookWorksheetProtection workbookWorksheetProtectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookWorksheetProtection>(workbookWorksheetProtectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookWorksheetProtection.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookWorksheetProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookWorksheetProtection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WorkbookWorksheetProtection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookWorksheetProtection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookWorksheetProtection.
        /// </summary>
        /// <returns>The WorkbookWorksheetProtection.</returns>
        public System.Threading.Tasks.Task<WorkbookWorksheetProtection> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookWorksheetProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookWorksheetProtection.</returns>
        public async System.Threading.Tasks.Task<WorkbookWorksheetProtection> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookWorksheetProtection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookWorksheetProtection using PATCH.
        /// </summary>
        /// <param name="workbookWorksheetProtectionToUpdate">The WorkbookWorksheetProtection to update.</param>
        /// <returns>The updated WorkbookWorksheetProtection.</returns>
        public System.Threading.Tasks.Task<WorkbookWorksheetProtection> UpdateAsync(WorkbookWorksheetProtection workbookWorksheetProtectionToUpdate)
        {
            return this.UpdateAsync(workbookWorksheetProtectionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookWorksheetProtection using PATCH.
        /// </summary>
        /// <param name="workbookWorksheetProtectionToUpdate">The WorkbookWorksheetProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookWorksheetProtection.</returns>
        public async System.Threading.Tasks.Task<WorkbookWorksheetProtection> UpdateAsync(WorkbookWorksheetProtection workbookWorksheetProtectionToUpdate, CancellationToken cancellationToken)
        {
			if (workbookWorksheetProtectionToUpdate.AdditionalData != null)
			{
				if (workbookWorksheetProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					workbookWorksheetProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookWorksheetProtectionToUpdate.GetType().Name)
						});
				}
			}
            if (workbookWorksheetProtectionToUpdate.AdditionalData != null)
            {
                if (workbookWorksheetProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookWorksheetProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookWorksheetProtectionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookWorksheetProtection>(workbookWorksheetProtectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookWorksheetProtectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookWorksheetProtectionRequest Expand(Expression<Func<WorkbookWorksheetProtection, object>> expandExpression)
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
        public IWorkbookWorksheetProtectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookWorksheetProtectionRequest Select(Expression<Func<WorkbookWorksheetProtection, object>> selectExpression)
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
        /// <param name="workbookWorksheetProtectionToInitialize">The <see cref="WorkbookWorksheetProtection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookWorksheetProtection workbookWorksheetProtectionToInitialize)
        {

        }
    }
}
