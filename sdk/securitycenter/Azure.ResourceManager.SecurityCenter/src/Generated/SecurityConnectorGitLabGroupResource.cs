// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecurityConnectorGitLabGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SecurityConnectorGitLabGroupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSecurityConnectorGitLabGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="DevOpsConfigurationResource"/> using the GetSecurityConnectorGitLabGroup method.
    /// </summary>
    public partial class SecurityConnectorGitLabGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityConnectorGitLabGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="securityConnectorName"> The securityConnectorName. </param>
        /// <param name="groupFQName"> The groupFQName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string securityConnectorName, string groupFQName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securityConnectorGitLabGroupGitLabGroupsClientDiagnostics;
        private readonly GitLabGroupsRestOperations _securityConnectorGitLabGroupGitLabGroupsRestClient;
        private readonly SecurityConnectorGitLabGroupData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/securityConnectors/devops/gitLabGroups";

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitLabGroupResource"/> class for mocking. </summary>
        protected SecurityConnectorGitLabGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitLabGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityConnectorGitLabGroupResource(ArmClient client, SecurityConnectorGitLabGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorGitLabGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityConnectorGitLabGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityConnectorGitLabGroupGitLabGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityConnectorGitLabGroupGitLabGroupsApiVersion);
            _securityConnectorGitLabGroupGitLabGroupsRestClient = new GitLabGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityConnectorGitLabGroupGitLabGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityConnectorGitLabGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SecurityConnectorGitLabProjectResources in the SecurityConnectorGitLabGroup. </summary>
        /// <returns> An object representing collection of SecurityConnectorGitLabProjectResources and their operations over a SecurityConnectorGitLabProjectResource. </returns>
        public virtual SecurityConnectorGitLabProjectCollection GetSecurityConnectorGitLabProjects()
        {
            return GetCachedClient(client => new SecurityConnectorGitLabProjectCollection(client, Id));
        }

        /// <summary>
        /// Returns a monitored GitLab Project resource for a given fully-qualified group name and project name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabProjects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitLabProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SecurityConnectorGitLabProjectResource>> GetSecurityConnectorGitLabProjectAsync(string projectName, CancellationToken cancellationToken = default)
        {
            return await GetSecurityConnectorGitLabProjects().GetAsync(projectName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a monitored GitLab Project resource for a given fully-qualified group name and project name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}/projects/{projectName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabProjects_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitLabProjectResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="projectName"> The project name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="projectName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SecurityConnectorGitLabProjectResource> GetSecurityConnectorGitLabProject(string projectName, CancellationToken cancellationToken = default)
        {
            return GetSecurityConnectorGitLabProjects().Get(projectName, cancellationToken);
        }

        /// <summary>
        /// Returns a monitored GitLab Group resource for a given fully-qualified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitLabGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityConnectorGitLabGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securityConnectorGitLabGroupGitLabGroupsClientDiagnostics.CreateScope("SecurityConnectorGitLabGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _securityConnectorGitLabGroupGitLabGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitLabGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored GitLab Group resource for a given fully-qualified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/gitLabGroups/{groupFQName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitLabGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityConnectorGitLabGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityConnectorGitLabGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securityConnectorGitLabGroupGitLabGroupsClientDiagnostics.CreateScope("SecurityConnectorGitLabGroupResource.Get");
            scope.Start();
            try
            {
                var response = _securityConnectorGitLabGroupGitLabGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorGitLabGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
