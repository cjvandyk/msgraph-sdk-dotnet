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
    /// The type GroupRequest.
    /// </summary>
    public partial class GroupRequest : BaseRequest, IGroupRequest
    {
        /// <summary>
        /// Constructs a new GroupRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Group using POST.
        /// </summary>
        /// <param name="groupToCreate">The Group to create.</param>
        /// <returns>The created Group.</returns>
        public System.Threading.Tasks.Task<Group> CreateAsync(Group groupToCreate)
        {
            return this.CreateAsync(groupToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Group using POST.
        /// </summary>
        /// <param name="groupToCreate">The Group to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Group.</returns>
        public async System.Threading.Tasks.Task<Group> CreateAsync(Group groupToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Group>(groupToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Group.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Group.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Group>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Group and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Group and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Group.
        /// </summary>
        /// <returns>The Group.</returns>
        public System.Threading.Tasks.Task<Group> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Group.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Group.</returns>
        public async System.Threading.Tasks.Task<Group> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Group>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Group using PATCH.
        /// </summary>
        /// <param name="groupToUpdate">The Group to update.</param>
        /// <returns>The updated Group.</returns>
        public System.Threading.Tasks.Task<Group> UpdateAsync(Group groupToUpdate)
        {
            return this.UpdateAsync(groupToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Group using PATCH.
        /// </summary>
        /// <param name="groupToUpdate">The Group to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Group.</returns>
        public async System.Threading.Tasks.Task<Group> UpdateAsync(Group groupToUpdate, CancellationToken cancellationToken)
        {
			if (groupToUpdate.AdditionalData != null)
			{
				if (groupToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					groupToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupToUpdate.GetType().Name)
						});
				}
			}
            if (groupToUpdate.AdditionalData != null)
            {
                if (groupToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    groupToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, groupToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Group>(groupToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupRequest Expand(Expression<Func<Group, object>> expandExpression)
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
        public IGroupRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupRequest Select(Expression<Func<Group, object>> selectExpression)
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
        /// <param name="groupToInitialize">The <see cref="Group"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Group groupToInitialize)
        {

            if (groupToInitialize != null && groupToInitialize.AdditionalData != null)
            {

                if (groupToInitialize.AppRoleAssignments != null && groupToInitialize.AppRoleAssignments.CurrentPage != null)
                {
                    groupToInitialize.AppRoleAssignments.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("appRoleAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.AppRoleAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.MemberOf != null && groupToInitialize.MemberOf.CurrentPage != null)
                {
                    groupToInitialize.MemberOf.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("memberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.MemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Members != null && groupToInitialize.Members.CurrentPage != null)
                {
                    groupToInitialize.Members.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("members@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Members.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.MembersWithLicenseErrors != null && groupToInitialize.MembersWithLicenseErrors.CurrentPage != null)
                {
                    groupToInitialize.MembersWithLicenseErrors.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("membersWithLicenseErrors@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.MembersWithLicenseErrors.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Owners != null && groupToInitialize.Owners.CurrentPage != null)
                {
                    groupToInitialize.Owners.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("owners@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Owners.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.PermissionGrants != null && groupToInitialize.PermissionGrants.CurrentPage != null)
                {
                    groupToInitialize.PermissionGrants.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("permissionGrants@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.PermissionGrants.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Settings != null && groupToInitialize.Settings.CurrentPage != null)
                {
                    groupToInitialize.Settings.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("settings@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Settings.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.TransitiveMemberOf != null && groupToInitialize.TransitiveMemberOf.CurrentPage != null)
                {
                    groupToInitialize.TransitiveMemberOf.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("transitiveMemberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.TransitiveMemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.TransitiveMembers != null && groupToInitialize.TransitiveMembers.CurrentPage != null)
                {
                    groupToInitialize.TransitiveMembers.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("transitiveMembers@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.TransitiveMembers.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.AcceptedSenders != null && groupToInitialize.AcceptedSenders.CurrentPage != null)
                {
                    groupToInitialize.AcceptedSenders.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("acceptedSenders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.AcceptedSenders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.CalendarView != null && groupToInitialize.CalendarView.CurrentPage != null)
                {
                    groupToInitialize.CalendarView.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("calendarView@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.CalendarView.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Conversations != null && groupToInitialize.Conversations.CurrentPage != null)
                {
                    groupToInitialize.Conversations.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("conversations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Conversations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Events != null && groupToInitialize.Events.CurrentPage != null)
                {
                    groupToInitialize.Events.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("events@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Events.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Photos != null && groupToInitialize.Photos.CurrentPage != null)
                {
                    groupToInitialize.Photos.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("photos@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Photos.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.RejectedSenders != null && groupToInitialize.RejectedSenders.CurrentPage != null)
                {
                    groupToInitialize.RejectedSenders.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("rejectedSenders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.RejectedSenders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Threads != null && groupToInitialize.Threads.CurrentPage != null)
                {
                    groupToInitialize.Threads.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("threads@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Threads.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Drives != null && groupToInitialize.Drives.CurrentPage != null)
                {
                    groupToInitialize.Drives.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("drives@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Drives.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Sites != null && groupToInitialize.Sites.CurrentPage != null)
                {
                    groupToInitialize.Sites.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("sites@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Sites.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.Extensions != null && groupToInitialize.Extensions.CurrentPage != null)
                {
                    groupToInitialize.Extensions.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("extensions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.Extensions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (groupToInitialize.GroupLifecyclePolicies != null && groupToInitialize.GroupLifecyclePolicies.CurrentPage != null)
                {
                    groupToInitialize.GroupLifecyclePolicies.AdditionalData = groupToInitialize.AdditionalData;

                    object nextPageLink;
                    groupToInitialize.AdditionalData.TryGetValue("groupLifecyclePolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        groupToInitialize.GroupLifecyclePolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
