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
    /// The type EducationRootRequest.
    /// </summary>
    public partial class EducationRootRequest : BaseRequest, IEducationRootRequest
    {
        /// <summary>
        /// Constructs a new EducationRootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationRootRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EducationRoot using POST.
        /// </summary>
        /// <param name="educationRootToCreate">The EducationRoot to create.</param>
        /// <returns>The created EducationRoot.</returns>
        public System.Threading.Tasks.Task<EducationRoot> CreateAsync(EducationRoot educationRootToCreate)
        {
            return this.CreateAsync(educationRootToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationRoot using POST.
        /// </summary>
        /// <param name="educationRootToCreate">The EducationRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationRoot.</returns>
        public async System.Threading.Tasks.Task<EducationRoot> CreateAsync(EducationRoot educationRootToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EducationRoot>(educationRootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EducationRoot using POST and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <param name="educationRootToCreate">The EducationRoot to create.</param>
        /// <returns>The <see cref="GraphResponse{EducationRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationRoot>> CreateResponseAsync(EducationRoot educationRootToCreate)
        {
            return this.CreateResponseAsync(educationRootToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationRoot using POST and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <param name="educationRootToCreate">The EducationRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationRoot}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationRoot>> CreateResponseAsync(EducationRoot educationRootToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<EducationRoot>(educationRootToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EducationRoot.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EducationRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EducationRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EducationRoot.
        /// </summary>
        /// <returns>The EducationRoot.</returns>
        public System.Threading.Tasks.Task<EducationRoot> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EducationRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationRoot.</returns>
        public async System.Threading.Tasks.Task<EducationRoot> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EducationRoot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EducationRoot and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{EducationRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationRoot>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EducationRoot and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationRoot}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationRoot>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<EducationRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified EducationRoot using PATCH.
        /// </summary>
        /// <param name="educationRootToUpdate">The EducationRoot to update.</param>
        /// <returns>The updated EducationRoot.</returns>
        public System.Threading.Tasks.Task<EducationRoot> UpdateAsync(EducationRoot educationRootToUpdate)
        {
            return this.UpdateAsync(educationRootToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationRoot using PATCH.
        /// </summary>
        /// <param name="educationRootToUpdate">The EducationRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationRoot.</returns>
        public async System.Threading.Tasks.Task<EducationRoot> UpdateAsync(EducationRoot educationRootToUpdate, CancellationToken cancellationToken)
        {
			if (educationRootToUpdate.AdditionalData != null)
			{
				if (educationRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					educationRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationRootToUpdate.GetType().Name)
						});
				}
			}
            if (educationRootToUpdate.AdditionalData != null)
            {
                if (educationRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    educationRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationRootToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EducationRoot>(educationRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EducationRoot using PATCH and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <param name="educationRootToUpdate">The EducationRoot to update.</param>
        /// <returns>The <see cref="GraphResponse{EducationRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EducationRoot>> UpdateResponseAsync(EducationRoot educationRootToUpdate)
        {
            return this.UpdateResponseAsync(educationRootToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationRoot using PATCH and returns a <see cref="GraphResponse{EducationRoot}"/> object.
        /// </summary>
        /// <param name="educationRootToUpdate">The EducationRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationRoot}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EducationRoot>> UpdateResponseAsync(EducationRoot educationRootToUpdate, CancellationToken cancellationToken)
        {
			if (educationRootToUpdate.AdditionalData != null)
			{
				if (educationRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					educationRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationRootToUpdate.GetType().Name)
						});
				}
			}
            if (educationRootToUpdate.AdditionalData != null)
            {
                if (educationRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    educationRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, educationRootToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<EducationRoot>(educationRootToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationRootRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationRootRequest Expand(Expression<Func<EducationRoot, object>> expandExpression)
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
        public IEducationRootRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationRootRequest Select(Expression<Func<EducationRoot, object>> selectExpression)
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
        /// <param name="educationRootToInitialize">The <see cref="EducationRoot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EducationRoot educationRootToInitialize)
        {

            if (educationRootToInitialize != null && educationRootToInitialize.AdditionalData != null)
            {

                if (educationRootToInitialize.Classes != null && educationRootToInitialize.Classes.CurrentPage != null)
                {
                    educationRootToInitialize.Classes.AdditionalData = educationRootToInitialize.AdditionalData;

                    object nextPageLink;
                    educationRootToInitialize.AdditionalData.TryGetValue("classes@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationRootToInitialize.Classes.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (educationRootToInitialize.Schools != null && educationRootToInitialize.Schools.CurrentPage != null)
                {
                    educationRootToInitialize.Schools.AdditionalData = educationRootToInitialize.AdditionalData;

                    object nextPageLink;
                    educationRootToInitialize.AdditionalData.TryGetValue("schools@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationRootToInitialize.Schools.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (educationRootToInitialize.Users != null && educationRootToInitialize.Users.CurrentPage != null)
                {
                    educationRootToInitialize.Users.AdditionalData = educationRootToInitialize.AdditionalData;

                    object nextPageLink;
                    educationRootToInitialize.AdditionalData.TryGetValue("users@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationRootToInitialize.Users.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
