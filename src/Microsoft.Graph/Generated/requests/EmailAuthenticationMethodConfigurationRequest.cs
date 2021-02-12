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
    /// The type EmailAuthenticationMethodConfigurationRequest.
    /// </summary>
    public partial class EmailAuthenticationMethodConfigurationRequest : BaseRequest, IEmailAuthenticationMethodConfigurationRequest
    {
        /// <summary>
        /// Constructs a new EmailAuthenticationMethodConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EmailAuthenticationMethodConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EmailAuthenticationMethodConfiguration using POST.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToCreate">The EmailAuthenticationMethodConfiguration to create.</param>
        /// <returns>The created EmailAuthenticationMethodConfiguration.</returns>
        public System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> CreateAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToCreate)
        {
            return this.CreateAsync(emailAuthenticationMethodConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EmailAuthenticationMethodConfiguration using POST.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToCreate">The EmailAuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> CreateAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EmailAuthenticationMethodConfiguration using POST and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToCreate">The EmailAuthenticationMethodConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> CreateResponseAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToCreate)
        {
            return this.CreateResponseAsync(emailAuthenticationMethodConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EmailAuthenticationMethodConfiguration using POST and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToCreate">The EmailAuthenticationMethodConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> CreateResponseAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EmailAuthenticationMethodConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EmailAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EmailAuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EmailAuthenticationMethodConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EmailAuthenticationMethodConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EmailAuthenticationMethodConfiguration.
        /// </summary>
        /// <returns>The EmailAuthenticationMethodConfiguration.</returns>
        public System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EmailAuthenticationMethodConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EmailAuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EmailAuthenticationMethodConfiguration and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EmailAuthenticationMethodConfiguration and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<EmailAuthenticationMethodConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified EmailAuthenticationMethodConfiguration using PATCH.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToUpdate">The EmailAuthenticationMethodConfiguration to update.</param>
        /// <returns>The updated EmailAuthenticationMethodConfiguration.</returns>
        public System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> UpdateAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToUpdate)
        {
            return this.UpdateAsync(emailAuthenticationMethodConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EmailAuthenticationMethodConfiguration using PATCH.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToUpdate">The EmailAuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EmailAuthenticationMethodConfiguration.</returns>
        public async System.Threading.Tasks.Task<EmailAuthenticationMethodConfiguration> UpdateAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (emailAuthenticationMethodConfigurationToUpdate.AdditionalData != null)
			{
				if (emailAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					emailAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, emailAuthenticationMethodConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (emailAuthenticationMethodConfigurationToUpdate.AdditionalData != null)
            {
                if (emailAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    emailAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, emailAuthenticationMethodConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EmailAuthenticationMethodConfiguration using PATCH and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToUpdate">The EmailAuthenticationMethodConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> UpdateResponseAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToUpdate)
        {
            return this.UpdateResponseAsync(emailAuthenticationMethodConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EmailAuthenticationMethodConfiguration using PATCH and returns a <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object.
        /// </summary>
        /// <param name="emailAuthenticationMethodConfigurationToUpdate">The EmailAuthenticationMethodConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EmailAuthenticationMethodConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EmailAuthenticationMethodConfiguration>> UpdateResponseAsync(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (emailAuthenticationMethodConfigurationToUpdate.AdditionalData != null)
			{
				if (emailAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					emailAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, emailAuthenticationMethodConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (emailAuthenticationMethodConfigurationToUpdate.AdditionalData != null)
            {
                if (emailAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    emailAuthenticationMethodConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, emailAuthenticationMethodConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<EmailAuthenticationMethodConfiguration>(emailAuthenticationMethodConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmailAuthenticationMethodConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmailAuthenticationMethodConfigurationRequest Expand(Expression<Func<EmailAuthenticationMethodConfiguration, object>> expandExpression)
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
        public IEmailAuthenticationMethodConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEmailAuthenticationMethodConfigurationRequest Select(Expression<Func<EmailAuthenticationMethodConfiguration, object>> selectExpression)
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
        /// <param name="emailAuthenticationMethodConfigurationToInitialize">The <see cref="EmailAuthenticationMethodConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EmailAuthenticationMethodConfiguration emailAuthenticationMethodConfigurationToInitialize)
        {

            if (emailAuthenticationMethodConfigurationToInitialize != null && emailAuthenticationMethodConfigurationToInitialize.AdditionalData != null)
            {

                if (emailAuthenticationMethodConfigurationToInitialize.IncludeTargets != null && emailAuthenticationMethodConfigurationToInitialize.IncludeTargets.CurrentPage != null)
                {
                    emailAuthenticationMethodConfigurationToInitialize.IncludeTargets.AdditionalData = emailAuthenticationMethodConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    emailAuthenticationMethodConfigurationToInitialize.AdditionalData.TryGetValue("includeTargets@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        emailAuthenticationMethodConfigurationToInitialize.IncludeTargets.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
