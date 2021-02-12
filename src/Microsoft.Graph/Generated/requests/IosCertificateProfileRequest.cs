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
    /// The type IosCertificateProfileRequest.
    /// </summary>
    public partial class IosCertificateProfileRequest : BaseRequest, IIosCertificateProfileRequest
    {
        /// <summary>
        /// Constructs a new IosCertificateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosCertificateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosCertificateProfile using POST.
        /// </summary>
        /// <param name="iosCertificateProfileToCreate">The IosCertificateProfile to create.</param>
        /// <returns>The created IosCertificateProfile.</returns>
        public System.Threading.Tasks.Task<IosCertificateProfile> CreateAsync(IosCertificateProfile iosCertificateProfileToCreate)
        {
            return this.CreateAsync(iosCertificateProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosCertificateProfile using POST.
        /// </summary>
        /// <param name="iosCertificateProfileToCreate">The IosCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<IosCertificateProfile> CreateAsync(IosCertificateProfile iosCertificateProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<IosCertificateProfile>(iosCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IosCertificateProfile using POST and returns a <see cref="GraphResponse{IosCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosCertificateProfileToCreate">The IosCertificateProfile to create.</param>
        /// <returns>The <see cref="GraphResponse{IosCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosCertificateProfile>> CreateResponseAsync(IosCertificateProfile iosCertificateProfileToCreate)
        {
            return this.CreateResponseAsync(iosCertificateProfileToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified IosCertificateProfile using POST and returns a <see cref="GraphResponse{IosCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosCertificateProfileToCreate">The IosCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosCertificateProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IosCertificateProfile>> CreateResponseAsync(IosCertificateProfile iosCertificateProfileToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<IosCertificateProfile>(iosCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<IosCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified IosCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified IosCertificateProfile.
        /// </summary>
        /// <returns>The IosCertificateProfile.</returns>
        public System.Threading.Tasks.Task<IosCertificateProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IosCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<IosCertificateProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<IosCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IosCertificateProfile and returns a <see cref="GraphResponse{IosCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IosCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosCertificateProfile>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified IosCertificateProfile and returns a <see cref="GraphResponse{IosCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosCertificateProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IosCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<IosCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified IosCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosCertificateProfileToUpdate">The IosCertificateProfile to update.</param>
        /// <returns>The updated IosCertificateProfile.</returns>
        public System.Threading.Tasks.Task<IosCertificateProfile> UpdateAsync(IosCertificateProfile iosCertificateProfileToUpdate)
        {
            return this.UpdateAsync(iosCertificateProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IosCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosCertificateProfileToUpdate">The IosCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<IosCertificateProfile> UpdateAsync(IosCertificateProfile iosCertificateProfileToUpdate, CancellationToken cancellationToken)
        {
			if (iosCertificateProfileToUpdate.AdditionalData != null)
			{
				if (iosCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					iosCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosCertificateProfileToUpdate.GetType().Name)
						});
				}
			}
            if (iosCertificateProfileToUpdate.AdditionalData != null)
            {
                if (iosCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    iosCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosCertificateProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<IosCertificateProfile>(iosCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosCertificateProfile using PATCH and returns a <see cref="GraphResponse{IosCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosCertificateProfileToUpdate">The IosCertificateProfile to update.</param>
        /// <returns>The <see cref="GraphResponse{IosCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosCertificateProfile>> UpdateResponseAsync(IosCertificateProfile iosCertificateProfileToUpdate)
        {
            return this.UpdateResponseAsync(iosCertificateProfileToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified IosCertificateProfile using PATCH and returns a <see cref="GraphResponse{IosCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosCertificateProfileToUpdate">The IosCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosCertificateProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<IosCertificateProfile>> UpdateResponseAsync(IosCertificateProfile iosCertificateProfileToUpdate, CancellationToken cancellationToken)
        {
			if (iosCertificateProfileToUpdate.AdditionalData != null)
			{
				if (iosCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					iosCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosCertificateProfileToUpdate.GetType().Name)
						});
				}
			}
            if (iosCertificateProfileToUpdate.AdditionalData != null)
            {
                if (iosCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    iosCertificateProfileToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, iosCertificateProfileToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<IosCertificateProfile>(iosCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosCertificateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosCertificateProfileRequest Expand(Expression<Func<IosCertificateProfile, object>> expandExpression)
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
        public IIosCertificateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosCertificateProfileRequest Select(Expression<Func<IosCertificateProfile, object>> selectExpression)
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
        /// <param name="iosCertificateProfileToInitialize">The <see cref="IosCertificateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosCertificateProfile iosCertificateProfileToInitialize)
        {

        }
    }
}
