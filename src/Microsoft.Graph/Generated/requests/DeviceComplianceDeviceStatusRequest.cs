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
    /// The type DeviceComplianceDeviceStatusRequest.
    /// </summary>
    public partial class DeviceComplianceDeviceStatusRequest : BaseRequest, IDeviceComplianceDeviceStatusRequest
    {
        /// <summary>
        /// Constructs a new DeviceComplianceDeviceStatusRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceComplianceDeviceStatusRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceComplianceDeviceStatus using POST.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToCreate">The DeviceComplianceDeviceStatus to create.</param>
        /// <returns>The created DeviceComplianceDeviceStatus.</returns>
        public System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> CreateAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToCreate)
        {
            return this.CreateAsync(deviceComplianceDeviceStatusToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceComplianceDeviceStatus using POST.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToCreate">The DeviceComplianceDeviceStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceDeviceStatus.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> CreateAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceComplianceDeviceStatus>(deviceComplianceDeviceStatusToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceComplianceDeviceStatus using POST and returns a <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToCreate">The DeviceComplianceDeviceStatus to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceDeviceStatus>> CreateResponseAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToCreate)
        {
            return this.CreateResponseAsync(deviceComplianceDeviceStatusToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceComplianceDeviceStatus using POST and returns a <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToCreate">The DeviceComplianceDeviceStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceComplianceDeviceStatus>> CreateResponseAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceComplianceDeviceStatus>(deviceComplianceDeviceStatusToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceDeviceStatus.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceComplianceDeviceStatus>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceDeviceStatus and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceDeviceStatus and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceComplianceDeviceStatus.
        /// </summary>
        /// <returns>The DeviceComplianceDeviceStatus.</returns>
        public System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceComplianceDeviceStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceDeviceStatus.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceComplianceDeviceStatus>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceComplianceDeviceStatus and returns a <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceDeviceStatus>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceComplianceDeviceStatus and returns a <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceComplianceDeviceStatus>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceComplianceDeviceStatus>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DeviceComplianceDeviceStatus using PATCH.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToUpdate">The DeviceComplianceDeviceStatus to update.</param>
        /// <returns>The updated DeviceComplianceDeviceStatus.</returns>
        public System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> UpdateAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToUpdate)
        {
            return this.UpdateAsync(deviceComplianceDeviceStatusToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceComplianceDeviceStatus using PATCH.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToUpdate">The DeviceComplianceDeviceStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceComplianceDeviceStatus.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceDeviceStatus> UpdateAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToUpdate, CancellationToken cancellationToken)
        {
			if (deviceComplianceDeviceStatusToUpdate.AdditionalData != null)
			{
				if (deviceComplianceDeviceStatusToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceComplianceDeviceStatusToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceDeviceStatusToUpdate.GetType().Name)
						});
				}
			}
            if (deviceComplianceDeviceStatusToUpdate.AdditionalData != null)
            {
                if (deviceComplianceDeviceStatusToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceComplianceDeviceStatusToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceDeviceStatusToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceComplianceDeviceStatus>(deviceComplianceDeviceStatusToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceComplianceDeviceStatus using PATCH and returns a <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToUpdate">The DeviceComplianceDeviceStatus to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceDeviceStatus>> UpdateResponseAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToUpdate)
        {
            return this.UpdateResponseAsync(deviceComplianceDeviceStatusToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceComplianceDeviceStatus using PATCH and returns a <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object.
        /// </summary>
        /// <param name="deviceComplianceDeviceStatusToUpdate">The DeviceComplianceDeviceStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceDeviceStatus}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceComplianceDeviceStatus>> UpdateResponseAsync(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToUpdate, CancellationToken cancellationToken)
        {
			if (deviceComplianceDeviceStatusToUpdate.AdditionalData != null)
			{
				if (deviceComplianceDeviceStatusToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceComplianceDeviceStatusToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceDeviceStatusToUpdate.GetType().Name)
						});
				}
			}
            if (deviceComplianceDeviceStatusToUpdate.AdditionalData != null)
            {
                if (deviceComplianceDeviceStatusToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceComplianceDeviceStatusToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceDeviceStatusToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceComplianceDeviceStatus>(deviceComplianceDeviceStatusToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceDeviceStatusRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceDeviceStatusRequest Expand(Expression<Func<DeviceComplianceDeviceStatus, object>> expandExpression)
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
        public IDeviceComplianceDeviceStatusRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceDeviceStatusRequest Select(Expression<Func<DeviceComplianceDeviceStatus, object>> selectExpression)
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
        /// <param name="deviceComplianceDeviceStatusToInitialize">The <see cref="DeviceComplianceDeviceStatus"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceComplianceDeviceStatus deviceComplianceDeviceStatusToInitialize)
        {

        }
    }
}
