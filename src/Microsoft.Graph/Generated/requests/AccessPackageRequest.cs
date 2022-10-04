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
    /// The type AccessPackageRequest.
    /// </summary>
    public partial class AccessPackageRequest : BaseRequest, IAccessPackageRequest
    {
        /// <summary>
        /// Constructs a new AccessPackageRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessPackageRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AccessPackage using POST.
        /// </summary>
        /// <param name="accessPackageToCreate">The AccessPackage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackage.</returns>
        public async System.Threading.Tasks.Task<AccessPackage> CreateAsync(AccessPackage accessPackageToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AccessPackage>(accessPackageToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AccessPackage using POST and returns a <see cref="GraphResponse{AccessPackage}"/> object.
        /// </summary>
        /// <param name="accessPackageToCreate">The AccessPackage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackage>> CreateResponseAsync(AccessPackage accessPackageToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AccessPackage>(accessPackageToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AccessPackage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AccessPackage>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AccessPackage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AccessPackage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackage.</returns>
        public async System.Threading.Tasks.Task<AccessPackage> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AccessPackage>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AccessPackage and returns a <see cref="GraphResponse{AccessPackage}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackage>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AccessPackage>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessPackage using PATCH.
        /// </summary>
        /// <param name="accessPackageToUpdate">The AccessPackage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackage.</returns>
        public async System.Threading.Tasks.Task<AccessPackage> UpdateAsync(AccessPackage accessPackageToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AccessPackage>(accessPackageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessPackage using PATCH and returns a <see cref="GraphResponse{AccessPackage}"/> object.
        /// </summary>
        /// <param name="accessPackageToUpdate">The AccessPackage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackage}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackage>> UpdateResponseAsync(AccessPackage accessPackageToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AccessPackage>(accessPackageToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AccessPackage using PUT.
        /// </summary>
        /// <param name="accessPackageToUpdate">The AccessPackage object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AccessPackage> PutAsync(AccessPackage accessPackageToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AccessPackage>(accessPackageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessPackage using PUT and returns a <see cref="GraphResponse{AccessPackage}"/> object.
        /// </summary>
        /// <param name="accessPackageToUpdate">The AccessPackage object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AccessPackage}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackage>> PutResponseAsync(AccessPackage accessPackageToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AccessPackage>(accessPackageToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageRequest Expand(Expression<Func<AccessPackage, object>> expandExpression)
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
        public IAccessPackageRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageRequest Select(Expression<Func<AccessPackage, object>> selectExpression)
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
        /// <param name="accessPackageToInitialize">The <see cref="AccessPackage"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AccessPackage accessPackageToInitialize)
        {

            if (accessPackageToInitialize != null)
            {
                if (accessPackageToInitialize.AccessPackagesIncompatibleWith != null && accessPackageToInitialize.AccessPackagesIncompatibleWith.CurrentPage != null)
                {
                    accessPackageToInitialize.AccessPackagesIncompatibleWith.InitializeNextPageRequest(this.Client, accessPackageToInitialize.AccessPackagesIncompatibleWithNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessPackageToInitialize.AccessPackagesIncompatibleWith.AdditionalData = accessPackageToInitialize.AdditionalData;
                }
                if (accessPackageToInitialize.AssignmentPolicies != null && accessPackageToInitialize.AssignmentPolicies.CurrentPage != null)
                {
                    accessPackageToInitialize.AssignmentPolicies.InitializeNextPageRequest(this.Client, accessPackageToInitialize.AssignmentPoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessPackageToInitialize.AssignmentPolicies.AdditionalData = accessPackageToInitialize.AdditionalData;
                }
                if (accessPackageToInitialize.IncompatibleAccessPackages != null && accessPackageToInitialize.IncompatibleAccessPackages.CurrentPage != null)
                {
                    accessPackageToInitialize.IncompatibleAccessPackages.InitializeNextPageRequest(this.Client, accessPackageToInitialize.IncompatibleAccessPackagesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessPackageToInitialize.IncompatibleAccessPackages.AdditionalData = accessPackageToInitialize.AdditionalData;
                }
                if (accessPackageToInitialize.IncompatibleGroups != null && accessPackageToInitialize.IncompatibleGroups.CurrentPage != null)
                {
                    accessPackageToInitialize.IncompatibleGroups.InitializeNextPageRequest(this.Client, accessPackageToInitialize.IncompatibleGroupsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    accessPackageToInitialize.IncompatibleGroups.AdditionalData = accessPackageToInitialize.AdditionalData;
                }

            }


        }
    }
}
