// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IAccessPackageRequestBuilder.
    /// </summary>
    public partial interface IAccessPackageRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAccessPackageRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAccessPackageRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AccessPackagesIncompatibleWith.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAccessPackagesIncompatibleWithCollectionWithReferencesRequestBuilder"/>.</returns>
        IAccessPackageAccessPackagesIncompatibleWithCollectionWithReferencesRequestBuilder AccessPackagesIncompatibleWith { get; }

        /// <summary>
        /// Gets the request builder for AssignmentPolicies.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentPoliciesCollectionRequestBuilder"/>.</returns>
        IAccessPackageAssignmentPoliciesCollectionRequestBuilder AssignmentPolicies { get; }

        /// <summary>
        /// Gets the request builder for Catalog.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageCatalogWithReferenceRequestBuilder"/>.</returns>
        IAccessPackageCatalogWithReferenceRequestBuilder Catalog { get; }

        /// <summary>
        /// Gets the request builder for IncompatibleAccessPackages.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequestBuilder"/>.</returns>
        IAccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequestBuilder IncompatibleAccessPackages { get; }

        /// <summary>
        /// Gets the request builder for IncompatibleGroups.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageIncompatibleGroupsCollectionRequestBuilder"/>.</returns>
        IAccessPackageIncompatibleGroupsCollectionRequestBuilder IncompatibleGroups { get; }
    
        /// <summary>
        /// Gets the request builder for AccessPackageGetApplicablePolicyRequirements.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageGetApplicablePolicyRequirementsRequestBuilder"/>.</returns>
        IAccessPackageGetApplicablePolicyRequirementsRequestBuilder GetApplicablePolicyRequirements();
    
    }
}
