/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ConfigService.Model;

namespace Amazon.ConfigService
{
    /// <summary>
    /// Interface for accessing ConfigService
    ///
    /// AWS Config 
    /// <para>
    /// AWS Config provides a way to keep track of the configurations of all the AWS resources
    /// associated with your AWS account. You can use AWS Config to get the current and historical
    /// configurations of each AWS resource and also to get information about the relationship
    /// between the resources. An AWS resource can be an Amazon Compute Cloud (Amazon EC2)
    /// instance, an Elastic Block Store (EBS) volume, an elastic network Interface (ENI),
    /// or a security group. For a complete list of resources currently supported by AWS Config,
    /// see <a href="https://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
    /// AWS Resources</a>.
    /// </para>
    ///  
    /// <para>
    /// You can access and manage AWS Config through the AWS Management Console, the AWS Command
    /// Line Interface (AWS CLI), the AWS Config API, or the AWS SDKs for AWS Config. This
    /// reference guide contains documentation for the AWS Config API and the AWS CLI commands
    /// that you can use to manage AWS Config. The AWS Config API uses the Signature Version
    /// 4 protocol for signing requests. For more information about how to sign a request
    /// with this protocol, see <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>. For detailed information about AWS Config features
    /// and their associated actions or commands, as well as how to work with AWS Management
    /// Console, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/WhatIsConfig.html">What
    /// Is AWS Config</a> in the <i>AWS Config Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonConfigService : IAmazonService, IDisposable
    {

        
        #region  BatchGetAggregateResourceConfig


        /// <summary>
        /// Returns the current configuration items for resources that are present in your AWS
        /// Config aggregator. The operation also returns a list of resources that are not processed
        /// in the current request. If there are no unprocessed resources, the operation returns
        /// an empty <code>unprocessedResourceIdentifiers</code> list. 
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// The API does not return results for deleted resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The API does not return tags and relationships.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAggregateResourceConfig service method.</param>
        /// 
        /// <returns>The response from the BatchGetAggregateResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetAggregateResourceConfig">REST API Reference for BatchGetAggregateResourceConfig Operation</seealso>
        BatchGetAggregateResourceConfigResponse BatchGetAggregateResourceConfig(BatchGetAggregateResourceConfigRequest request);



        /// <summary>
        /// Returns the current configuration items for resources that are present in your AWS
        /// Config aggregator. The operation also returns a list of resources that are not processed
        /// in the current request. If there are no unprocessed resources, the operation returns
        /// an empty <code>unprocessedResourceIdentifiers</code> list. 
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// The API does not return results for deleted resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The API does not return tags and relationships.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAggregateResourceConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAggregateResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetAggregateResourceConfig">REST API Reference for BatchGetAggregateResourceConfig Operation</seealso>
        Task<BatchGetAggregateResourceConfigResponse> BatchGetAggregateResourceConfigAsync(BatchGetAggregateResourceConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetResourceConfig


        /// <summary>
        /// Returns the current configuration for one or more requested resources. The operation
        /// also returns a list of resources that are not processed in the current request. If
        /// there are no unprocessed resources, the operation returns an empty unprocessedResourceKeys
        /// list. 
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// The API does not return results for deleted resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The API does not return any tags for the requested resources. This information is
        /// filtered out of the supplementaryConfiguration section of the API response.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetResourceConfig service method.</param>
        /// 
        /// <returns>The response from the BatchGetResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetResourceConfig">REST API Reference for BatchGetResourceConfig Operation</seealso>
        BatchGetResourceConfigResponse BatchGetResourceConfig(BatchGetResourceConfigRequest request);



        /// <summary>
        /// Returns the current configuration for one or more requested resources. The operation
        /// also returns a list of resources that are not processed in the current request. If
        /// there are no unprocessed resources, the operation returns an empty unprocessedResourceKeys
        /// list. 
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// The API does not return results for deleted resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The API does not return any tags for the requested resources. This information is
        /// filtered out of the supplementaryConfiguration section of the API response.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetResourceConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetResourceConfig">REST API Reference for BatchGetResourceConfig Operation</seealso>
        Task<BatchGetResourceConfigResponse> BatchGetResourceConfigAsync(BatchGetResourceConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAggregationAuthorization


        /// <summary>
        /// Deletes the authorization granted to the specified configuration aggregator account
        /// in a specified region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAggregationAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteAggregationAuthorization service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteAggregationAuthorization">REST API Reference for DeleteAggregationAuthorization Operation</seealso>
        DeleteAggregationAuthorizationResponse DeleteAggregationAuthorization(DeleteAggregationAuthorizationRequest request);



        /// <summary>
        /// Deletes the authorization granted to the specified configuration aggregator account
        /// in a specified region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAggregationAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAggregationAuthorization service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteAggregationAuthorization">REST API Reference for DeleteAggregationAuthorization Operation</seealso>
        Task<DeleteAggregationAuthorizationResponse> DeleteAggregationAuthorizationAsync(DeleteAggregationAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigRule


        /// <summary>
        /// Deletes the specified AWS Config rule and all of its evaluation results.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the state of a rule to <code>DELETING</code> until the deletion is
        /// complete. You cannot update a rule while it is in this state. If you make a <code>PutConfigRule</code>
        /// or <code>DeleteConfigRule</code> request for the rule, you will receive a <code>ResourceInUseException</code>.
        /// </para>
        ///  
        /// <para>
        /// You can check the state of a rule by using the <code>DescribeConfigRules</code> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigRule service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigRule">REST API Reference for DeleteConfigRule Operation</seealso>
        DeleteConfigRuleResponse DeleteConfigRule(DeleteConfigRuleRequest request);



        /// <summary>
        /// Deletes the specified AWS Config rule and all of its evaluation results.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the state of a rule to <code>DELETING</code> until the deletion is
        /// complete. You cannot update a rule while it is in this state. If you make a <code>PutConfigRule</code>
        /// or <code>DeleteConfigRule</code> request for the rule, you will receive a <code>ResourceInUseException</code>.
        /// </para>
        ///  
        /// <para>
        /// You can check the state of a rule by using the <code>DescribeConfigRules</code> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigRule">REST API Reference for DeleteConfigRule Operation</seealso>
        Task<DeleteConfigRuleResponse> DeleteConfigRuleAsync(DeleteConfigRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigurationAggregator


        /// <summary>
        /// Deletes the specified configuration aggregator and the aggregated data associated
        /// with the aggregator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationAggregator service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationAggregator service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationAggregator">REST API Reference for DeleteConfigurationAggregator Operation</seealso>
        DeleteConfigurationAggregatorResponse DeleteConfigurationAggregator(DeleteConfigurationAggregatorRequest request);



        /// <summary>
        /// Deletes the specified configuration aggregator and the aggregated data associated
        /// with the aggregator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationAggregator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationAggregator service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationAggregator">REST API Reference for DeleteConfigurationAggregator Operation</seealso>
        Task<DeleteConfigurationAggregatorResponse> DeleteConfigurationAggregatorAsync(DeleteConfigurationAggregatorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfigurationRecorder


        /// <summary>
        /// Deletes the configuration recorder.
        /// 
        ///  
        /// <para>
        /// After the configuration recorder is deleted, AWS Config will not record resource configuration
        /// changes until you create a new configuration recorder.
        /// </para>
        ///  
        /// <para>
        /// This action does not delete the configuration information that was previously recorded.
        /// You will be able to access the previously recorded information by using the <code>GetResourceConfigHistory</code>
        /// action, but you will not be able to access this information in the AWS Config console
        /// until you create a new configuration recorder.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationRecorder">REST API Reference for DeleteConfigurationRecorder Operation</seealso>
        DeleteConfigurationRecorderResponse DeleteConfigurationRecorder(DeleteConfigurationRecorderRequest request);



        /// <summary>
        /// Deletes the configuration recorder.
        /// 
        ///  
        /// <para>
        /// After the configuration recorder is deleted, AWS Config will not record resource configuration
        /// changes until you create a new configuration recorder.
        /// </para>
        ///  
        /// <para>
        /// This action does not delete the configuration information that was previously recorded.
        /// You will be able to access the previously recorded information by using the <code>GetResourceConfigHistory</code>
        /// action, but you will not be able to access this information in the AWS Config console
        /// until you create a new configuration recorder.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationRecorder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationRecorder">REST API Reference for DeleteConfigurationRecorder Operation</seealso>
        Task<DeleteConfigurationRecorderResponse> DeleteConfigurationRecorderAsync(DeleteConfigurationRecorderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConformancePack


        /// <summary>
        /// Deletes the specified conformance pack and all the AWS Config rules and all evaluation
        /// results within that conformance pack.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the conformance pack to <code>DELETE_IN_PROGRESS</code> until the
        /// deletion is complete. You cannot update a conformance pack while it is in this state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConformancePack service method.</param>
        /// 
        /// <returns>The response from the DeleteConformancePack service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConformancePack">REST API Reference for DeleteConformancePack Operation</seealso>
        DeleteConformancePackResponse DeleteConformancePack(DeleteConformancePackRequest request);



        /// <summary>
        /// Deletes the specified conformance pack and all the AWS Config rules and all evaluation
        /// results within that conformance pack.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the conformance pack to <code>DELETE_IN_PROGRESS</code> until the
        /// deletion is complete. You cannot update a conformance pack while it is in this state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConformancePack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConformancePack service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConformancePack">REST API Reference for DeleteConformancePack Operation</seealso>
        Task<DeleteConformancePackResponse> DeleteConformancePackAsync(DeleteConformancePackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDeliveryChannel


        /// <summary>
        /// Deletes the delivery channel.
        /// 
        ///  
        /// <para>
        /// Before you can delete the delivery channel, you must stop the configuration recorder
        /// by using the <a>StopConfigurationRecorder</a> action.
        /// </para>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel to delete.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.LastDeliveryChannelDeleteFailedException">
        /// You cannot delete the delivery channel you specified because the configuration recorder
        /// is running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        DeleteDeliveryChannelResponse DeleteDeliveryChannel(string deliveryChannelName);

        /// <summary>
        /// Deletes the delivery channel.
        /// 
        ///  
        /// <para>
        /// Before you can delete the delivery channel, you must stop the configuration recorder
        /// by using the <a>StopConfigurationRecorder</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.LastDeliveryChannelDeleteFailedException">
        /// You cannot delete the delivery channel you specified because the configuration recorder
        /// is running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        DeleteDeliveryChannelResponse DeleteDeliveryChannel(DeleteDeliveryChannelRequest request);


        /// <summary>
        /// Deletes the delivery channel.
        /// 
        ///  
        /// <para>
        /// Before you can delete the delivery channel, you must stop the configuration recorder
        /// by using the <a>StopConfigurationRecorder</a> action.
        /// </para>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.LastDeliveryChannelDeleteFailedException">
        /// You cannot delete the delivery channel you specified because the configuration recorder
        /// is running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        Task<DeleteDeliveryChannelResponse> DeleteDeliveryChannelAsync(string deliveryChannelName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes the delivery channel.
        /// 
        ///  
        /// <para>
        /// Before you can delete the delivery channel, you must stop the configuration recorder
        /// by using the <a>StopConfigurationRecorder</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.LastDeliveryChannelDeleteFailedException">
        /// You cannot delete the delivery channel you specified because the configuration recorder
        /// is running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        Task<DeleteDeliveryChannelResponse> DeleteDeliveryChannelAsync(DeleteDeliveryChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEvaluationResults


        /// <summary>
        /// Deletes the evaluation results for the specified AWS Config rule. You can specify
        /// one AWS Config rule per request. After you delete the evaluation results, you can
        /// call the <a>StartConfigRulesEvaluation</a> API to start evaluating your AWS resources
        /// against the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluationResults service method.</param>
        /// 
        /// <returns>The response from the DeleteEvaluationResults service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteEvaluationResults">REST API Reference for DeleteEvaluationResults Operation</seealso>
        DeleteEvaluationResultsResponse DeleteEvaluationResults(DeleteEvaluationResultsRequest request);



        /// <summary>
        /// Deletes the evaluation results for the specified AWS Config rule. You can specify
        /// one AWS Config rule per request. After you delete the evaluation results, you can
        /// call the <a>StartConfigRulesEvaluation</a> API to start evaluating your AWS resources
        /// against the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluationResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEvaluationResults service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteEvaluationResults">REST API Reference for DeleteEvaluationResults Operation</seealso>
        Task<DeleteEvaluationResultsResponse> DeleteEvaluationResultsAsync(DeleteEvaluationResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOrganizationConfigRule


        /// <summary>
        /// Deletes the specified organization config rule and all of its evaluation results from
        /// all member accounts in that organization. Only a master account can delete an organization
        /// config rule.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the state of a rule to DELETE_IN_PROGRESS until the deletion is complete.
        /// You cannot update a rule while it is in this state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationConfigRule service method.</param>
        /// 
        /// <returns>The response from the DeleteOrganizationConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// You specified one or more organization config rules that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteOrganizationConfigRule">REST API Reference for DeleteOrganizationConfigRule Operation</seealso>
        DeleteOrganizationConfigRuleResponse DeleteOrganizationConfigRule(DeleteOrganizationConfigRuleRequest request);



        /// <summary>
        /// Deletes the specified organization config rule and all of its evaluation results from
        /// all member accounts in that organization. Only a master account can delete an organization
        /// config rule.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the state of a rule to DELETE_IN_PROGRESS until the deletion is complete.
        /// You cannot update a rule while it is in this state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationConfigRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOrganizationConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// You specified one or more organization config rules that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteOrganizationConfigRule">REST API Reference for DeleteOrganizationConfigRule Operation</seealso>
        Task<DeleteOrganizationConfigRuleResponse> DeleteOrganizationConfigRuleAsync(DeleteOrganizationConfigRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOrganizationConformancePack


        /// <summary>
        /// Deletes the specified organization conformance pack and all of the config rules and
        /// remediation actions from all member accounts in that organization. Only a master account
        /// can delete an organization conformance pack.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the state of a conformance pack to DELETE_IN_PROGRESS until the deletion
        /// is complete. You cannot update a conformance pack while it is in this state. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationConformancePack service method.</param>
        /// 
        /// <returns>The response from the DeleteOrganizationConformancePack service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConformancePackException">
        /// AWS Config organization conformance pack that you passed in the filter does not exist.
        /// 
        ///  
        /// <para>
        /// For DeleteOrganizationConformancePack, you tried to delete an organization conformance
        /// pack that does not exist.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteOrganizationConformancePack">REST API Reference for DeleteOrganizationConformancePack Operation</seealso>
        DeleteOrganizationConformancePackResponse DeleteOrganizationConformancePack(DeleteOrganizationConformancePackRequest request);



        /// <summary>
        /// Deletes the specified organization conformance pack and all of the config rules and
        /// remediation actions from all member accounts in that organization. Only a master account
        /// can delete an organization conformance pack.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the state of a conformance pack to DELETE_IN_PROGRESS until the deletion
        /// is complete. You cannot update a conformance pack while it is in this state. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationConformancePack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOrganizationConformancePack service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConformancePackException">
        /// AWS Config organization conformance pack that you passed in the filter does not exist.
        /// 
        ///  
        /// <para>
        /// For DeleteOrganizationConformancePack, you tried to delete an organization conformance
        /// pack that does not exist.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteOrganizationConformancePack">REST API Reference for DeleteOrganizationConformancePack Operation</seealso>
        Task<DeleteOrganizationConformancePackResponse> DeleteOrganizationConformancePackAsync(DeleteOrganizationConformancePackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePendingAggregationRequest


        /// <summary>
        /// Deletes pending authorization requests for a specified aggregator account in a specified
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePendingAggregationRequest service method.</param>
        /// 
        /// <returns>The response from the DeletePendingAggregationRequest service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeletePendingAggregationRequest">REST API Reference for DeletePendingAggregationRequest Operation</seealso>
        DeletePendingAggregationRequestResponse DeletePendingAggregationRequest(DeletePendingAggregationRequestRequest request);



        /// <summary>
        /// Deletes pending authorization requests for a specified aggregator account in a specified
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePendingAggregationRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePendingAggregationRequest service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeletePendingAggregationRequest">REST API Reference for DeletePendingAggregationRequest Operation</seealso>
        Task<DeletePendingAggregationRequestResponse> DeletePendingAggregationRequestAsync(DeletePendingAggregationRequestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRemediationConfiguration


        /// <summary>
        /// Deletes the remediation configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemediationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteRemediationConfiguration service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationConfigurationException">
        /// You specified an AWS Config rule without a remediation configuration.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.RemediationInProgressException">
        /// Remediation action is in progress. You can either cancel execution in AWS Systems
        /// Manager or wait and try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRemediationConfiguration">REST API Reference for DeleteRemediationConfiguration Operation</seealso>
        DeleteRemediationConfigurationResponse DeleteRemediationConfiguration(DeleteRemediationConfigurationRequest request);



        /// <summary>
        /// Deletes the remediation configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemediationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRemediationConfiguration service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationConfigurationException">
        /// You specified an AWS Config rule without a remediation configuration.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.RemediationInProgressException">
        /// Remediation action is in progress. You can either cancel execution in AWS Systems
        /// Manager or wait and try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRemediationConfiguration">REST API Reference for DeleteRemediationConfiguration Operation</seealso>
        Task<DeleteRemediationConfigurationResponse> DeleteRemediationConfigurationAsync(DeleteRemediationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRemediationExceptions


        /// <summary>
        /// Deletes one or more remediation exceptions mentioned in the resource keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemediationExceptions service method.</param>
        /// 
        /// <returns>The response from the DeleteRemediationExceptions service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationExceptionException">
        /// You tried to delete a remediation exception that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRemediationExceptions">REST API Reference for DeleteRemediationExceptions Operation</seealso>
        DeleteRemediationExceptionsResponse DeleteRemediationExceptions(DeleteRemediationExceptionsRequest request);



        /// <summary>
        /// Deletes one or more remediation exceptions mentioned in the resource keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemediationExceptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRemediationExceptions service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationExceptionException">
        /// You tried to delete a remediation exception that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRemediationExceptions">REST API Reference for DeleteRemediationExceptions Operation</seealso>
        Task<DeleteRemediationExceptionsResponse> DeleteRemediationExceptionsAsync(DeleteRemediationExceptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRetentionConfiguration


        /// <summary>
        /// Deletes the retention configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteRetentionConfiguration service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRetentionConfigurationException">
        /// You have specified a retention configuration that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRetentionConfiguration">REST API Reference for DeleteRetentionConfiguration Operation</seealso>
        DeleteRetentionConfigurationResponse DeleteRetentionConfiguration(DeleteRetentionConfigurationRequest request);



        /// <summary>
        /// Deletes the retention configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRetentionConfiguration service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRetentionConfigurationException">
        /// You have specified a retention configuration that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRetentionConfiguration">REST API Reference for DeleteRetentionConfiguration Operation</seealso>
        Task<DeleteRetentionConfigurationResponse> DeleteRetentionConfigurationAsync(DeleteRetentionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeliverConfigSnapshot


        /// <summary>
        /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
        /// delivery channel. After the delivery has started, AWS Config sends the following notifications
        /// using an Amazon SNS topic that you have specified.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Notification of the start of the delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of the completion of the delivery, if the delivery was successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of delivery failure, if the delivery failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel through which the snapshot is delivered.</param>
        /// 
        /// <returns>The response from the DeliverConfigSnapshot service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoRunningConfigurationRecorderException">
        /// There is no configuration recorder running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        DeliverConfigSnapshotResponse DeliverConfigSnapshot(string deliveryChannelName);

        /// <summary>
        /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
        /// delivery channel. After the delivery has started, AWS Config sends the following notifications
        /// using an Amazon SNS topic that you have specified.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Notification of the start of the delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of the completion of the delivery, if the delivery was successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of delivery failure, if the delivery failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeliverConfigSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeliverConfigSnapshot service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoRunningConfigurationRecorderException">
        /// There is no configuration recorder running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        DeliverConfigSnapshotResponse DeliverConfigSnapshot(DeliverConfigSnapshotRequest request);


        /// <summary>
        /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
        /// delivery channel. After the delivery has started, AWS Config sends the following notifications
        /// using an Amazon SNS topic that you have specified.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Notification of the start of the delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of the completion of the delivery, if the delivery was successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of delivery failure, if the delivery failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel through which the snapshot is delivered.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeliverConfigSnapshot service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoRunningConfigurationRecorderException">
        /// There is no configuration recorder running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        Task<DeliverConfigSnapshotResponse> DeliverConfigSnapshotAsync(string deliveryChannelName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
        /// delivery channel. After the delivery has started, AWS Config sends the following notifications
        /// using an Amazon SNS topic that you have specified.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Notification of the start of the delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of the completion of the delivery, if the delivery was successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of delivery failure, if the delivery failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeliverConfigSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeliverConfigSnapshot service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoRunningConfigurationRecorderException">
        /// There is no configuration recorder running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        Task<DeliverConfigSnapshotResponse> DeliverConfigSnapshotAsync(DeliverConfigSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAggregateComplianceByConfigRules


        /// <summary>
        /// Returns a list of compliant and noncompliant rules with the number of resources for
        /// compliant and noncompliant rules. 
        /// 
        ///  <note> 
        /// <para>
        /// The results can return an empty result page, but if you have a <code>nextToken</code>,
        /// the results are displayed on the next page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateComplianceByConfigRules service method.</param>
        /// 
        /// <returns>The response from the DescribeAggregateComplianceByConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregateComplianceByConfigRules">REST API Reference for DescribeAggregateComplianceByConfigRules Operation</seealso>
        DescribeAggregateComplianceByConfigRulesResponse DescribeAggregateComplianceByConfigRules(DescribeAggregateComplianceByConfigRulesRequest request);



        /// <summary>
        /// Returns a list of compliant and noncompliant rules with the number of resources for
        /// compliant and noncompliant rules. 
        /// 
        ///  <note> 
        /// <para>
        /// The results can return an empty result page, but if you have a <code>nextToken</code>,
        /// the results are displayed on the next page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateComplianceByConfigRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAggregateComplianceByConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregateComplianceByConfigRules">REST API Reference for DescribeAggregateComplianceByConfigRules Operation</seealso>
        Task<DescribeAggregateComplianceByConfigRulesResponse> DescribeAggregateComplianceByConfigRulesAsync(DescribeAggregateComplianceByConfigRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAggregationAuthorizations


        /// <summary>
        /// Returns a list of authorizations granted to various aggregator accounts and regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregationAuthorizations service method.</param>
        /// 
        /// <returns>The response from the DescribeAggregationAuthorizations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregationAuthorizations">REST API Reference for DescribeAggregationAuthorizations Operation</seealso>
        DescribeAggregationAuthorizationsResponse DescribeAggregationAuthorizations(DescribeAggregationAuthorizationsRequest request);



        /// <summary>
        /// Returns a list of authorizations granted to various aggregator accounts and regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregationAuthorizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAggregationAuthorizations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregationAuthorizations">REST API Reference for DescribeAggregationAuthorizations Operation</seealso>
        Task<DescribeAggregationAuthorizationsResponse> DescribeAggregationAuthorizationsAsync(DescribeAggregationAuthorizationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeComplianceByConfigRule


        /// <summary>
        /// Indicates whether the specified AWS Config rules are compliant. If a rule is noncompliant,
        /// this action returns the number of AWS resources that do not comply with the rule.
        /// 
        ///  
        /// <para>
        /// A rule is compliant if all of the evaluated resources comply with it. It is noncompliant
        /// if any of these resources do not comply.
        /// </para>
        ///  
        /// <para>
        /// If AWS Config has no current evaluation results for the rule, it returns <code>INSUFFICIENT_DATA</code>.
        /// This result might indicate one of the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS Config has never invoked an evaluation for the rule. To check whether it has,
        /// use the <code>DescribeConfigRuleEvaluationStatus</code> action to get the <code>LastSuccessfulInvocationTime</code>
        /// and <code>LastFailedInvocationTime</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function is failing to send evaluation results to AWS Config.
        /// Verify that the role you assigned to your configuration recorder includes the <code>config:PutEvaluations</code>
        /// permission. If the rule is a custom rule, verify that the AWS Lambda execution role
        /// includes the <code>config:PutEvaluations</code> permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function has returned <code>NOT_APPLICABLE</code> for all evaluation
        /// results. This can occur if the resources were deleted or removed from the rule's scope.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByConfigRule service method.</param>
        /// 
        /// <returns>The response from the DescribeComplianceByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByConfigRule">REST API Reference for DescribeComplianceByConfigRule Operation</seealso>
        DescribeComplianceByConfigRuleResponse DescribeComplianceByConfigRule(DescribeComplianceByConfigRuleRequest request);



        /// <summary>
        /// Indicates whether the specified AWS Config rules are compliant. If a rule is noncompliant,
        /// this action returns the number of AWS resources that do not comply with the rule.
        /// 
        ///  
        /// <para>
        /// A rule is compliant if all of the evaluated resources comply with it. It is noncompliant
        /// if any of these resources do not comply.
        /// </para>
        ///  
        /// <para>
        /// If AWS Config has no current evaluation results for the rule, it returns <code>INSUFFICIENT_DATA</code>.
        /// This result might indicate one of the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS Config has never invoked an evaluation for the rule. To check whether it has,
        /// use the <code>DescribeConfigRuleEvaluationStatus</code> action to get the <code>LastSuccessfulInvocationTime</code>
        /// and <code>LastFailedInvocationTime</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function is failing to send evaluation results to AWS Config.
        /// Verify that the role you assigned to your configuration recorder includes the <code>config:PutEvaluations</code>
        /// permission. If the rule is a custom rule, verify that the AWS Lambda execution role
        /// includes the <code>config:PutEvaluations</code> permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function has returned <code>NOT_APPLICABLE</code> for all evaluation
        /// results. This can occur if the resources were deleted or removed from the rule's scope.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByConfigRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComplianceByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByConfigRule">REST API Reference for DescribeComplianceByConfigRule Operation</seealso>
        Task<DescribeComplianceByConfigRuleResponse> DescribeComplianceByConfigRuleAsync(DescribeComplianceByConfigRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeComplianceByResource


        /// <summary>
        /// Indicates whether the specified AWS resources are compliant. If a resource is noncompliant,
        /// this action returns the number of AWS Config rules that the resource does not comply
        /// with.
        /// 
        ///  
        /// <para>
        /// A resource is compliant if it complies with all the AWS Config rules that evaluate
        /// it. It is noncompliant if it does not comply with one or more of these rules.
        /// </para>
        ///  
        /// <para>
        /// If AWS Config has no current evaluation results for the resource, it returns <code>INSUFFICIENT_DATA</code>.
        /// This result might indicate one of the following conditions about the rules that evaluate
        /// the resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS Config has never invoked an evaluation for the rule. To check whether it has,
        /// use the <code>DescribeConfigRuleEvaluationStatus</code> action to get the <code>LastSuccessfulInvocationTime</code>
        /// and <code>LastFailedInvocationTime</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function is failing to send evaluation results to AWS Config.
        /// Verify that the role that you assigned to your configuration recorder includes the
        /// <code>config:PutEvaluations</code> permission. If the rule is a custom rule, verify
        /// that the AWS Lambda execution role includes the <code>config:PutEvaluations</code>
        /// permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function has returned <code>NOT_APPLICABLE</code> for all evaluation
        /// results. This can occur if the resources were deleted or removed from the rule's scope.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByResource service method.</param>
        /// 
        /// <returns>The response from the DescribeComplianceByResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByResource">REST API Reference for DescribeComplianceByResource Operation</seealso>
        DescribeComplianceByResourceResponse DescribeComplianceByResource(DescribeComplianceByResourceRequest request);



        /// <summary>
        /// Indicates whether the specified AWS resources are compliant. If a resource is noncompliant,
        /// this action returns the number of AWS Config rules that the resource does not comply
        /// with.
        /// 
        ///  
        /// <para>
        /// A resource is compliant if it complies with all the AWS Config rules that evaluate
        /// it. It is noncompliant if it does not comply with one or more of these rules.
        /// </para>
        ///  
        /// <para>
        /// If AWS Config has no current evaluation results for the resource, it returns <code>INSUFFICIENT_DATA</code>.
        /// This result might indicate one of the following conditions about the rules that evaluate
        /// the resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS Config has never invoked an evaluation for the rule. To check whether it has,
        /// use the <code>DescribeConfigRuleEvaluationStatus</code> action to get the <code>LastSuccessfulInvocationTime</code>
        /// and <code>LastFailedInvocationTime</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function is failing to send evaluation results to AWS Config.
        /// Verify that the role that you assigned to your configuration recorder includes the
        /// <code>config:PutEvaluations</code> permission. If the rule is a custom rule, verify
        /// that the AWS Lambda execution role includes the <code>config:PutEvaluations</code>
        /// permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function has returned <code>NOT_APPLICABLE</code> for all evaluation
        /// results. This can occur if the resources were deleted or removed from the rule's scope.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComplianceByResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByResource">REST API Reference for DescribeComplianceByResource Operation</seealso>
        Task<DescribeComplianceByResourceResponse> DescribeComplianceByResourceAsync(DescribeComplianceByResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigRuleEvaluationStatus


        /// <summary>
        /// Returns status information for each of your AWS managed Config rules. The status includes
        /// information such as the last time AWS Config invoked the rule, the last time AWS Config
        /// failed to invoke the rule, and the related error for the last failure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRuleEvaluationStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigRuleEvaluationStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRuleEvaluationStatus">REST API Reference for DescribeConfigRuleEvaluationStatus Operation</seealso>
        DescribeConfigRuleEvaluationStatusResponse DescribeConfigRuleEvaluationStatus(DescribeConfigRuleEvaluationStatusRequest request);



        /// <summary>
        /// Returns status information for each of your AWS managed Config rules. The status includes
        /// information such as the last time AWS Config invoked the rule, the last time AWS Config
        /// failed to invoke the rule, and the related error for the last failure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRuleEvaluationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigRuleEvaluationStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRuleEvaluationStatus">REST API Reference for DescribeConfigRuleEvaluationStatus Operation</seealso>
        Task<DescribeConfigRuleEvaluationStatusResponse> DescribeConfigRuleEvaluationStatusAsync(DescribeConfigRuleEvaluationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigRules


        /// <summary>
        /// Returns details about your AWS Config rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRules service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRules">REST API Reference for DescribeConfigRules Operation</seealso>
        DescribeConfigRulesResponse DescribeConfigRules(DescribeConfigRulesRequest request);



        /// <summary>
        /// Returns details about your AWS Config rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRules">REST API Reference for DescribeConfigRules Operation</seealso>
        Task<DescribeConfigRulesResponse> DescribeConfigRulesAsync(DescribeConfigRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationAggregators


        /// <summary>
        /// Returns the details of one or more configuration aggregators. If the configuration
        /// aggregator is not specified, this action returns the details for all the configuration
        /// aggregators associated with the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregators service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationAggregators service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregators">REST API Reference for DescribeConfigurationAggregators Operation</seealso>
        DescribeConfigurationAggregatorsResponse DescribeConfigurationAggregators(DescribeConfigurationAggregatorsRequest request);



        /// <summary>
        /// Returns the details of one or more configuration aggregators. If the configuration
        /// aggregator is not specified, this action returns the details for all the configuration
        /// aggregators associated with the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationAggregators service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregators">REST API Reference for DescribeConfigurationAggregators Operation</seealso>
        Task<DescribeConfigurationAggregatorsResponse> DescribeConfigurationAggregatorsAsync(DescribeConfigurationAggregatorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationAggregatorSourcesStatus


        /// <summary>
        /// Returns status information for sources within an aggregator. The status includes information
        /// about the last time AWS Config verified authorization between the source account and
        /// an aggregator account. In case of a failure, the status contains the related error
        /// code or message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregatorSourcesStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationAggregatorSourcesStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregatorSourcesStatus">REST API Reference for DescribeConfigurationAggregatorSourcesStatus Operation</seealso>
        DescribeConfigurationAggregatorSourcesStatusResponse DescribeConfigurationAggregatorSourcesStatus(DescribeConfigurationAggregatorSourcesStatusRequest request);



        /// <summary>
        /// Returns status information for sources within an aggregator. The status includes information
        /// about the last time AWS Config verified authorization between the source account and
        /// an aggregator account. In case of a failure, the status contains the related error
        /// code or message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregatorSourcesStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationAggregatorSourcesStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregatorSourcesStatus">REST API Reference for DescribeConfigurationAggregatorSourcesStatus Operation</seealso>
        Task<DescribeConfigurationAggregatorSourcesStatusResponse> DescribeConfigurationAggregatorSourcesStatusAsync(DescribeConfigurationAggregatorSourcesStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationRecorders


        /// <summary>
        /// Returns the details for the specified configuration recorders. If the configuration
        /// recorder is not specified, this action returns the details for all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorders service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        DescribeConfigurationRecordersResponse DescribeConfigurationRecorders();


        /// <summary>
        /// Returns the details for the specified configuration recorders. If the configuration
        /// recorder is not specified, this action returns the details for all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorders service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorders service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        DescribeConfigurationRecordersResponse DescribeConfigurationRecorders(DescribeConfigurationRecordersRequest request);


        /// <summary>
        /// Returns the details for the specified configuration recorders. If the configuration
        /// recorder is not specified, this action returns the details for all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorders service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        Task<DescribeConfigurationRecordersResponse> DescribeConfigurationRecordersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns the details for the specified configuration recorders. If the configuration
        /// recorder is not specified, this action returns the details for all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorders service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        Task<DescribeConfigurationRecordersResponse> DescribeConfigurationRecordersAsync(DescribeConfigurationRecordersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationRecorderStatus


        /// <summary>
        /// Returns the current status of the specified configuration recorder. If a configuration
        /// recorder is not specified, this action returns the status of all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorderStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        DescribeConfigurationRecorderStatusResponse DescribeConfigurationRecorderStatus();


        /// <summary>
        /// Returns the current status of the specified configuration recorder. If a configuration
        /// recorder is not specified, this action returns the status of all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorderStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorderStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        DescribeConfigurationRecorderStatusResponse DescribeConfigurationRecorderStatus(DescribeConfigurationRecorderStatusRequest request);


        /// <summary>
        /// Returns the current status of the specified configuration recorder. If a configuration
        /// recorder is not specified, this action returns the status of all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorderStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        Task<DescribeConfigurationRecorderStatusResponse> DescribeConfigurationRecorderStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns the current status of the specified configuration recorder. If a configuration
        /// recorder is not specified, this action returns the status of all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorderStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorderStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        Task<DescribeConfigurationRecorderStatusResponse> DescribeConfigurationRecorderStatusAsync(DescribeConfigurationRecorderStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConformancePackCompliance


        /// <summary>
        /// Returns compliance information for each rule in that conformance pack.
        /// 
        ///  <note> 
        /// <para>
        /// You must provide exact rule names otherwise AWS Config cannot return evaluation results
        /// due to insufficient data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConformancePackCompliance service method.</param>
        /// 
        /// <returns>The response from the DescribeConformancePackCompliance service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleInConformancePackException">
        /// AWS Config rule that you passed in the filter does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConformancePackCompliance">REST API Reference for DescribeConformancePackCompliance Operation</seealso>
        DescribeConformancePackComplianceResponse DescribeConformancePackCompliance(DescribeConformancePackComplianceRequest request);



        /// <summary>
        /// Returns compliance information for each rule in that conformance pack.
        /// 
        ///  <note> 
        /// <para>
        /// You must provide exact rule names otherwise AWS Config cannot return evaluation results
        /// due to insufficient data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConformancePackCompliance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConformancePackCompliance service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleInConformancePackException">
        /// AWS Config rule that you passed in the filter does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConformancePackCompliance">REST API Reference for DescribeConformancePackCompliance Operation</seealso>
        Task<DescribeConformancePackComplianceResponse> DescribeConformancePackComplianceAsync(DescribeConformancePackComplianceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConformancePacks


        /// <summary>
        /// Returns a list of one or more conformance packs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConformancePacks service method.</param>
        /// 
        /// <returns>The response from the DescribeConformancePacks service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConformancePacks">REST API Reference for DescribeConformancePacks Operation</seealso>
        DescribeConformancePacksResponse DescribeConformancePacks(DescribeConformancePacksRequest request);



        /// <summary>
        /// Returns a list of one or more conformance packs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConformancePacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConformancePacks service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConformancePacks">REST API Reference for DescribeConformancePacks Operation</seealso>
        Task<DescribeConformancePacksResponse> DescribeConformancePacksAsync(DescribeConformancePacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConformancePackStatus


        /// <summary>
        /// Provides one or more conformance packs deployment status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConformancePackStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeConformancePackStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConformancePackStatus">REST API Reference for DescribeConformancePackStatus Operation</seealso>
        DescribeConformancePackStatusResponse DescribeConformancePackStatus(DescribeConformancePackStatusRequest request);



        /// <summary>
        /// Provides one or more conformance packs deployment status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConformancePackStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConformancePackStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConformancePackStatus">REST API Reference for DescribeConformancePackStatus Operation</seealso>
        Task<DescribeConformancePackStatusResponse> DescribeConformancePackStatusAsync(DescribeConformancePackStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDeliveryChannels


        /// <summary>
        /// Returns details about the specified delivery channel. If a delivery channel is not
        /// specified, this action returns the details of all delivery channels associated with
        /// the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDeliveryChannels service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        DescribeDeliveryChannelsResponse DescribeDeliveryChannels();


        /// <summary>
        /// Returns details about the specified delivery channel. If a delivery channel is not
        /// specified, this action returns the details of all delivery channels associated with
        /// the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannels service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannels service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        DescribeDeliveryChannelsResponse DescribeDeliveryChannels(DescribeDeliveryChannelsRequest request);


        /// <summary>
        /// Returns details about the specified delivery channel. If a delivery channel is not
        /// specified, this action returns the details of all delivery channels associated with
        /// the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannels service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        Task<DescribeDeliveryChannelsResponse> DescribeDeliveryChannelsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns details about the specified delivery channel. If a delivery channel is not
        /// specified, this action returns the details of all delivery channels associated with
        /// the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannels service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        Task<DescribeDeliveryChannelsResponse> DescribeDeliveryChannelsAsync(DescribeDeliveryChannelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDeliveryChannelStatus


        /// <summary>
        /// Returns the current status of the specified delivery channel. If a delivery channel
        /// is not specified, this action returns the current status of all delivery channels
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDeliveryChannelStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        DescribeDeliveryChannelStatusResponse DescribeDeliveryChannelStatus();


        /// <summary>
        /// Returns the current status of the specified delivery channel. If a delivery channel
        /// is not specified, this action returns the current status of all delivery channels
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannelStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannelStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        DescribeDeliveryChannelStatusResponse DescribeDeliveryChannelStatus(DescribeDeliveryChannelStatusRequest request);


        /// <summary>
        /// Returns the current status of the specified delivery channel. If a delivery channel
        /// is not specified, this action returns the current status of all delivery channels
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannelStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        Task<DescribeDeliveryChannelStatusResponse> DescribeDeliveryChannelStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns the current status of the specified delivery channel. If a delivery channel
        /// is not specified, this action returns the current status of all delivery channels
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannelStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannelStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        Task<DescribeDeliveryChannelStatusResponse> DescribeDeliveryChannelStatusAsync(DescribeDeliveryChannelStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOrganizationConfigRules


        /// <summary>
        /// Returns a list of organization config rules.
        /// 
        ///  <note> 
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. Limit
        /// and next token are not applicable if you specify organization config rule names. It
        /// is only applicable, when you request all the organization config rules.
        /// </para>
        ///  
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfigRules service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// You specified one or more organization config rules that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRules">REST API Reference for DescribeOrganizationConfigRules Operation</seealso>
        DescribeOrganizationConfigRulesResponse DescribeOrganizationConfigRules(DescribeOrganizationConfigRulesRequest request);



        /// <summary>
        /// Returns a list of organization config rules.
        /// 
        ///  <note> 
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. Limit
        /// and next token are not applicable if you specify organization config rule names. It
        /// is only applicable, when you request all the organization config rules.
        /// </para>
        ///  
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfigRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// You specified one or more organization config rules that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRules">REST API Reference for DescribeOrganizationConfigRules Operation</seealso>
        Task<DescribeOrganizationConfigRulesResponse> DescribeOrganizationConfigRulesAsync(DescribeOrganizationConfigRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOrganizationConfigRuleStatuses


        /// <summary>
        /// Provides organization config rule deployment status for an organization.
        /// 
        ///  <note> 
        /// <para>
        /// The status is not considered successful until organization config rule is successfully
        /// deployed in all the member accounts with an exception of excluded accounts.
        /// </para>
        ///  
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. Limit
        /// and next token are not applicable if you specify organization config rule names. It
        /// is only applicable, when you request all the organization config rules.
        /// </para>
        ///  
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfigRuleStatuses service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfigRuleStatuses service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// You specified one or more organization config rules that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRuleStatuses">REST API Reference for DescribeOrganizationConfigRuleStatuses Operation</seealso>
        DescribeOrganizationConfigRuleStatusesResponse DescribeOrganizationConfigRuleStatuses(DescribeOrganizationConfigRuleStatusesRequest request);



        /// <summary>
        /// Provides organization config rule deployment status for an organization.
        /// 
        ///  <note> 
        /// <para>
        /// The status is not considered successful until organization config rule is successfully
        /// deployed in all the member accounts with an exception of excluded accounts.
        /// </para>
        ///  
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. Limit
        /// and next token are not applicable if you specify organization config rule names. It
        /// is only applicable, when you request all the organization config rules.
        /// </para>
        ///  
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfigRuleStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfigRuleStatuses service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// You specified one or more organization config rules that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRuleStatuses">REST API Reference for DescribeOrganizationConfigRuleStatuses Operation</seealso>
        Task<DescribeOrganizationConfigRuleStatusesResponse> DescribeOrganizationConfigRuleStatusesAsync(DescribeOrganizationConfigRuleStatusesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOrganizationConformancePacks


        /// <summary>
        /// Returns a list of organization conformance packs.
        /// 
        ///  <note> 
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. Limit
        /// and next token are not applicable if you specify organization conformance packs names.
        /// They are only applicable, when you request all the organization conformance packs.
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConformancePacks service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConformancePacks service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConformancePackException">
        /// AWS Config organization conformance pack that you passed in the filter does not exist.
        /// 
        ///  
        /// <para>
        /// For DeleteOrganizationConformancePack, you tried to delete an organization conformance
        /// pack that does not exist.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConformancePacks">REST API Reference for DescribeOrganizationConformancePacks Operation</seealso>
        DescribeOrganizationConformancePacksResponse DescribeOrganizationConformancePacks(DescribeOrganizationConformancePacksRequest request);



        /// <summary>
        /// Returns a list of organization conformance packs.
        /// 
        ///  <note> 
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. Limit
        /// and next token are not applicable if you specify organization conformance packs names.
        /// They are only applicable, when you request all the organization conformance packs.
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConformancePacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConformancePacks service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConformancePackException">
        /// AWS Config organization conformance pack that you passed in the filter does not exist.
        /// 
        ///  
        /// <para>
        /// For DeleteOrganizationConformancePack, you tried to delete an organization conformance
        /// pack that does not exist.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConformancePacks">REST API Reference for DescribeOrganizationConformancePacks Operation</seealso>
        Task<DescribeOrganizationConformancePacksResponse> DescribeOrganizationConformancePacksAsync(DescribeOrganizationConformancePacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOrganizationConformancePackStatuses


        /// <summary>
        /// Provides organization conformance pack deployment status for an organization.
        /// 
        ///  <note> 
        /// <para>
        /// The status is not considered successful until organization conformance pack is successfully
        /// deployed in all the member accounts with an exception of excluded accounts.
        /// </para>
        ///  
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. Limit
        /// and next token are not applicable if you specify organization conformance pack names.
        /// They are only applicable, when you request all the organization conformance packs.
        /// </para>
        ///  
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConformancePackStatuses service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConformancePackStatuses service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConformancePackException">
        /// AWS Config organization conformance pack that you passed in the filter does not exist.
        /// 
        ///  
        /// <para>
        /// For DeleteOrganizationConformancePack, you tried to delete an organization conformance
        /// pack that does not exist.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConformancePackStatuses">REST API Reference for DescribeOrganizationConformancePackStatuses Operation</seealso>
        DescribeOrganizationConformancePackStatusesResponse DescribeOrganizationConformancePackStatuses(DescribeOrganizationConformancePackStatusesRequest request);



        /// <summary>
        /// Provides organization conformance pack deployment status for an organization.
        /// 
        ///  <note> 
        /// <para>
        /// The status is not considered successful until organization conformance pack is successfully
        /// deployed in all the member accounts with an exception of excluded accounts.
        /// </para>
        ///  
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. Limit
        /// and next token are not applicable if you specify organization conformance pack names.
        /// They are only applicable, when you request all the organization conformance packs.
        /// </para>
        ///  
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConformancePackStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationConformancePackStatuses service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConformancePackException">
        /// AWS Config organization conformance pack that you passed in the filter does not exist.
        /// 
        ///  
        /// <para>
        /// For DeleteOrganizationConformancePack, you tried to delete an organization conformance
        /// pack that does not exist.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConformancePackStatuses">REST API Reference for DescribeOrganizationConformancePackStatuses Operation</seealso>
        Task<DescribeOrganizationConformancePackStatusesResponse> DescribeOrganizationConformancePackStatusesAsync(DescribeOrganizationConformancePackStatusesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePendingAggregationRequests


        /// <summary>
        /// Returns a list of all pending aggregation requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingAggregationRequests service method.</param>
        /// 
        /// <returns>The response from the DescribePendingAggregationRequests service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribePendingAggregationRequests">REST API Reference for DescribePendingAggregationRequests Operation</seealso>
        DescribePendingAggregationRequestsResponse DescribePendingAggregationRequests(DescribePendingAggregationRequestsRequest request);



        /// <summary>
        /// Returns a list of all pending aggregation requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingAggregationRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePendingAggregationRequests service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribePendingAggregationRequests">REST API Reference for DescribePendingAggregationRequests Operation</seealso>
        Task<DescribePendingAggregationRequestsResponse> DescribePendingAggregationRequestsAsync(DescribePendingAggregationRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRemediationConfigurations


        /// <summary>
        /// Returns the details of one or more remediation configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeRemediationConfigurations service method, as returned by ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationConfigurations">REST API Reference for DescribeRemediationConfigurations Operation</seealso>
        DescribeRemediationConfigurationsResponse DescribeRemediationConfigurations(DescribeRemediationConfigurationsRequest request);



        /// <summary>
        /// Returns the details of one or more remediation configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRemediationConfigurations service method, as returned by ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationConfigurations">REST API Reference for DescribeRemediationConfigurations Operation</seealso>
        Task<DescribeRemediationConfigurationsResponse> DescribeRemediationConfigurationsAsync(DescribeRemediationConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRemediationExceptions


        /// <summary>
        /// Returns the details of one or more remediation exceptions. A detailed view of a remediation
        /// exception for a set of resources that includes an explanation of an exception and
        /// the time when the exception will be deleted. When you specify the limit and the next
        /// token, you receive a paginated response. 
        /// 
        ///  <note> 
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. 
        /// </para>
        ///  
        /// <para>
        /// Limit and next token are not applicable if you request resources in batch. It is only
        /// applicable, when you request all resources.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationExceptions service method.</param>
        /// 
        /// <returns>The response from the DescribeRemediationExceptions service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationExceptions">REST API Reference for DescribeRemediationExceptions Operation</seealso>
        DescribeRemediationExceptionsResponse DescribeRemediationExceptions(DescribeRemediationExceptionsRequest request);



        /// <summary>
        /// Returns the details of one or more remediation exceptions. A detailed view of a remediation
        /// exception for a set of resources that includes an explanation of an exception and
        /// the time when the exception will be deleted. When you specify the limit and the next
        /// token, you receive a paginated response. 
        /// 
        ///  <note> 
        /// <para>
        /// When you specify the limit and the next token, you receive a paginated response. 
        /// </para>
        ///  
        /// <para>
        /// Limit and next token are not applicable if you request resources in batch. It is only
        /// applicable, when you request all resources.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationExceptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRemediationExceptions service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationExceptions">REST API Reference for DescribeRemediationExceptions Operation</seealso>
        Task<DescribeRemediationExceptionsResponse> DescribeRemediationExceptionsAsync(DescribeRemediationExceptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRemediationExecutionStatus


        /// <summary>
        /// Provides a detailed view of a Remediation Execution for a set of resources including
        /// state, timestamps for when steps for the remediation execution occur, and any error
        /// messages for steps that have failed. When you specify the limit and the next token,
        /// you receive a paginated response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationExecutionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeRemediationExecutionStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationConfigurationException">
        /// You specified an AWS Config rule without a remediation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationExecutionStatus">REST API Reference for DescribeRemediationExecutionStatus Operation</seealso>
        DescribeRemediationExecutionStatusResponse DescribeRemediationExecutionStatus(DescribeRemediationExecutionStatusRequest request);



        /// <summary>
        /// Provides a detailed view of a Remediation Execution for a set of resources including
        /// state, timestamps for when steps for the remediation execution occur, and any error
        /// messages for steps that have failed. When you specify the limit and the next token,
        /// you receive a paginated response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationExecutionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRemediationExecutionStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationConfigurationException">
        /// You specified an AWS Config rule without a remediation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationExecutionStatus">REST API Reference for DescribeRemediationExecutionStatus Operation</seealso>
        Task<DescribeRemediationExecutionStatusResponse> DescribeRemediationExecutionStatusAsync(DescribeRemediationExecutionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRetentionConfigurations


        /// <summary>
        /// Returns the details of one or more retention configurations. If the retention configuration
        /// name is not specified, this action returns the details for all the retention configurations
        /// for that account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, AWS Config supports only one retention configuration per region in your
        /// account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRetentionConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeRetentionConfigurations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRetentionConfigurationException">
        /// You have specified a retention configuration that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRetentionConfigurations">REST API Reference for DescribeRetentionConfigurations Operation</seealso>
        DescribeRetentionConfigurationsResponse DescribeRetentionConfigurations(DescribeRetentionConfigurationsRequest request);



        /// <summary>
        /// Returns the details of one or more retention configurations. If the retention configuration
        /// name is not specified, this action returns the details for all the retention configurations
        /// for that account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, AWS Config supports only one retention configuration per region in your
        /// account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRetentionConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRetentionConfigurations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRetentionConfigurationException">
        /// You have specified a retention configuration that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRetentionConfigurations">REST API Reference for DescribeRetentionConfigurations Operation</seealso>
        Task<DescribeRetentionConfigurationsResponse> DescribeRetentionConfigurationsAsync(DescribeRetentionConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAggregateComplianceDetailsByConfigRule


        /// <summary>
        /// Returns the evaluation results for the specified AWS Config rule for a specific resource
        /// in a rule. The results indicate which AWS resources were evaluated by the rule, when
        /// each resource was last evaluated, and whether each resource complies with the rule.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// The results can return an empty result page. But if you have a <code>nextToken</code>,
        /// the results are displayed on the next page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateComplianceDetailsByConfigRule service method.</param>
        /// 
        /// <returns>The response from the GetAggregateComplianceDetailsByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateComplianceDetailsByConfigRule">REST API Reference for GetAggregateComplianceDetailsByConfigRule Operation</seealso>
        GetAggregateComplianceDetailsByConfigRuleResponse GetAggregateComplianceDetailsByConfigRule(GetAggregateComplianceDetailsByConfigRuleRequest request);



        /// <summary>
        /// Returns the evaluation results for the specified AWS Config rule for a specific resource
        /// in a rule. The results indicate which AWS resources were evaluated by the rule, when
        /// each resource was last evaluated, and whether each resource complies with the rule.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// The results can return an empty result page. But if you have a <code>nextToken</code>,
        /// the results are displayed on the next page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateComplianceDetailsByConfigRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAggregateComplianceDetailsByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateComplianceDetailsByConfigRule">REST API Reference for GetAggregateComplianceDetailsByConfigRule Operation</seealso>
        Task<GetAggregateComplianceDetailsByConfigRuleResponse> GetAggregateComplianceDetailsByConfigRuleAsync(GetAggregateComplianceDetailsByConfigRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAggregateConfigRuleComplianceSummary


        /// <summary>
        /// Returns the number of compliant and noncompliant rules for one or more accounts and
        /// regions in an aggregator.
        /// 
        ///  <note> 
        /// <para>
        /// The results can return an empty result page, but if you have a nextToken, the results
        /// are displayed on the next page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateConfigRuleComplianceSummary service method.</param>
        /// 
        /// <returns>The response from the GetAggregateConfigRuleComplianceSummary service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateConfigRuleComplianceSummary">REST API Reference for GetAggregateConfigRuleComplianceSummary Operation</seealso>
        GetAggregateConfigRuleComplianceSummaryResponse GetAggregateConfigRuleComplianceSummary(GetAggregateConfigRuleComplianceSummaryRequest request);



        /// <summary>
        /// Returns the number of compliant and noncompliant rules for one or more accounts and
        /// regions in an aggregator.
        /// 
        ///  <note> 
        /// <para>
        /// The results can return an empty result page, but if you have a nextToken, the results
        /// are displayed on the next page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateConfigRuleComplianceSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAggregateConfigRuleComplianceSummary service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateConfigRuleComplianceSummary">REST API Reference for GetAggregateConfigRuleComplianceSummary Operation</seealso>
        Task<GetAggregateConfigRuleComplianceSummaryResponse> GetAggregateConfigRuleComplianceSummaryAsync(GetAggregateConfigRuleComplianceSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAggregateDiscoveredResourceCounts


        /// <summary>
        /// Returns the resource counts across accounts and regions that are present in your AWS
        /// Config aggregator. You can request the resource counts by providing filters and GroupByKey.
        /// 
        ///  
        /// <para>
        /// For example, if the input contains accountID 12345678910 and region us-east-1 in filters,
        /// the API returns the count of resources in account ID 12345678910 and region us-east-1.
        /// If the input contains ACCOUNT_ID as a GroupByKey, the API returns resource counts
        /// for all source accounts that are present in your aggregator.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateDiscoveredResourceCounts service method.</param>
        /// 
        /// <returns>The response from the GetAggregateDiscoveredResourceCounts service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateDiscoveredResourceCounts">REST API Reference for GetAggregateDiscoveredResourceCounts Operation</seealso>
        GetAggregateDiscoveredResourceCountsResponse GetAggregateDiscoveredResourceCounts(GetAggregateDiscoveredResourceCountsRequest request);



        /// <summary>
        /// Returns the resource counts across accounts and regions that are present in your AWS
        /// Config aggregator. You can request the resource counts by providing filters and GroupByKey.
        /// 
        ///  
        /// <para>
        /// For example, if the input contains accountID 12345678910 and region us-east-1 in filters,
        /// the API returns the count of resources in account ID 12345678910 and region us-east-1.
        /// If the input contains ACCOUNT_ID as a GroupByKey, the API returns resource counts
        /// for all source accounts that are present in your aggregator.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateDiscoveredResourceCounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAggregateDiscoveredResourceCounts service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateDiscoveredResourceCounts">REST API Reference for GetAggregateDiscoveredResourceCounts Operation</seealso>
        Task<GetAggregateDiscoveredResourceCountsResponse> GetAggregateDiscoveredResourceCountsAsync(GetAggregateDiscoveredResourceCountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAggregateResourceConfig


        /// <summary>
        /// Returns configuration item that is aggregated for your specific resource in a specific
        /// source account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateResourceConfig service method.</param>
        /// 
        /// <returns>The response from the GetAggregateResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OversizedConfigurationItemException">
        /// The configuration item size is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotDiscoveredException">
        /// You have specified a resource that is either unknown or has not been discovered.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateResourceConfig">REST API Reference for GetAggregateResourceConfig Operation</seealso>
        GetAggregateResourceConfigResponse GetAggregateResourceConfig(GetAggregateResourceConfigRequest request);



        /// <summary>
        /// Returns configuration item that is aggregated for your specific resource in a specific
        /// source account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateResourceConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAggregateResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OversizedConfigurationItemException">
        /// The configuration item size is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotDiscoveredException">
        /// You have specified a resource that is either unknown or has not been discovered.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateResourceConfig">REST API Reference for GetAggregateResourceConfig Operation</seealso>
        Task<GetAggregateResourceConfigResponse> GetAggregateResourceConfigAsync(GetAggregateResourceConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComplianceDetailsByConfigRule


        /// <summary>
        /// Returns the evaluation results for the specified AWS Config rule. The results indicate
        /// which AWS resources were evaluated by the rule, when each resource was last evaluated,
        /// and whether each resource complies with the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByConfigRule service method.</param>
        /// 
        /// <returns>The response from the GetComplianceDetailsByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByConfigRule">REST API Reference for GetComplianceDetailsByConfigRule Operation</seealso>
        GetComplianceDetailsByConfigRuleResponse GetComplianceDetailsByConfigRule(GetComplianceDetailsByConfigRuleRequest request);



        /// <summary>
        /// Returns the evaluation results for the specified AWS Config rule. The results indicate
        /// which AWS resources were evaluated by the rule, when each resource was last evaluated,
        /// and whether each resource complies with the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByConfigRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComplianceDetailsByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByConfigRule">REST API Reference for GetComplianceDetailsByConfigRule Operation</seealso>
        Task<GetComplianceDetailsByConfigRuleResponse> GetComplianceDetailsByConfigRuleAsync(GetComplianceDetailsByConfigRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComplianceDetailsByResource


        /// <summary>
        /// Returns the evaluation results for the specified AWS resource. The results indicate
        /// which AWS Config rules were used to evaluate the resource, when each rule was last
        /// used, and whether the resource complies with each rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByResource service method.</param>
        /// 
        /// <returns>The response from the GetComplianceDetailsByResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByResource">REST API Reference for GetComplianceDetailsByResource Operation</seealso>
        GetComplianceDetailsByResourceResponse GetComplianceDetailsByResource(GetComplianceDetailsByResourceRequest request);



        /// <summary>
        /// Returns the evaluation results for the specified AWS resource. The results indicate
        /// which AWS Config rules were used to evaluate the resource, when each rule was last
        /// used, and whether the resource complies with each rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComplianceDetailsByResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByResource">REST API Reference for GetComplianceDetailsByResource Operation</seealso>
        Task<GetComplianceDetailsByResourceResponse> GetComplianceDetailsByResourceAsync(GetComplianceDetailsByResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComplianceSummaryByConfigRule


        /// <summary>
        /// Returns the number of AWS Config rules that are compliant and noncompliant, up to
        /// a maximum of 25 for each.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByConfigRule service method.</param>
        /// 
        /// <returns>The response from the GetComplianceSummaryByConfigRule service method, as returned by ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByConfigRule">REST API Reference for GetComplianceSummaryByConfigRule Operation</seealso>
        GetComplianceSummaryByConfigRuleResponse GetComplianceSummaryByConfigRule(GetComplianceSummaryByConfigRuleRequest request);



        /// <summary>
        /// Returns the number of AWS Config rules that are compliant and noncompliant, up to
        /// a maximum of 25 for each.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByConfigRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComplianceSummaryByConfigRule service method, as returned by ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByConfigRule">REST API Reference for GetComplianceSummaryByConfigRule Operation</seealso>
        Task<GetComplianceSummaryByConfigRuleResponse> GetComplianceSummaryByConfigRuleAsync(GetComplianceSummaryByConfigRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComplianceSummaryByResourceType


        /// <summary>
        /// Returns the number of resources that are compliant and the number that are noncompliant.
        /// You can specify one or more resource types to get these numbers for each resource
        /// type. The maximum number returned is 100.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByResourceType service method.</param>
        /// 
        /// <returns>The response from the GetComplianceSummaryByResourceType service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByResourceType">REST API Reference for GetComplianceSummaryByResourceType Operation</seealso>
        GetComplianceSummaryByResourceTypeResponse GetComplianceSummaryByResourceType(GetComplianceSummaryByResourceTypeRequest request);



        /// <summary>
        /// Returns the number of resources that are compliant and the number that are noncompliant.
        /// You can specify one or more resource types to get these numbers for each resource
        /// type. The maximum number returned is 100.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByResourceType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComplianceSummaryByResourceType service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByResourceType">REST API Reference for GetComplianceSummaryByResourceType Operation</seealso>
        Task<GetComplianceSummaryByResourceTypeResponse> GetComplianceSummaryByResourceTypeAsync(GetComplianceSummaryByResourceTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConformancePackComplianceDetails


        /// <summary>
        /// Returns compliance details of a conformance pack for all AWS resources that are monitered
        /// by conformance pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConformancePackComplianceDetails service method.</param>
        /// 
        /// <returns>The response from the GetConformancePackComplianceDetails service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleInConformancePackException">
        /// AWS Config rule that you passed in the filter does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetConformancePackComplianceDetails">REST API Reference for GetConformancePackComplianceDetails Operation</seealso>
        GetConformancePackComplianceDetailsResponse GetConformancePackComplianceDetails(GetConformancePackComplianceDetailsRequest request);



        /// <summary>
        /// Returns compliance details of a conformance pack for all AWS resources that are monitered
        /// by conformance pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConformancePackComplianceDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConformancePackComplianceDetails service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleInConformancePackException">
        /// AWS Config rule that you passed in the filter does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetConformancePackComplianceDetails">REST API Reference for GetConformancePackComplianceDetails Operation</seealso>
        Task<GetConformancePackComplianceDetailsResponse> GetConformancePackComplianceDetailsAsync(GetConformancePackComplianceDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConformancePackComplianceSummary


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConformancePackComplianceSummary service method.</param>
        /// 
        /// <returns>The response from the GetConformancePackComplianceSummary service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetConformancePackComplianceSummary">REST API Reference for GetConformancePackComplianceSummary Operation</seealso>
        GetConformancePackComplianceSummaryResponse GetConformancePackComplianceSummary(GetConformancePackComplianceSummaryRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConformancePackComplianceSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConformancePackComplianceSummary service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConformancePackException">
        /// You specified one or more conformance packs that do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetConformancePackComplianceSummary">REST API Reference for GetConformancePackComplianceSummary Operation</seealso>
        Task<GetConformancePackComplianceSummaryResponse> GetConformancePackComplianceSummaryAsync(GetConformancePackComplianceSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDiscoveredResourceCounts


        /// <summary>
        /// Returns the resource types, the number of each resource type, and the total number
        /// of resources that AWS Config is recording in this region for your AWS account. 
        /// 
        ///  <p class="title"> <b>Example</b> 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// AWS Config is recording three resource types in the US East (Ohio) Region for your
        /// account: 25 EC2 instances, 20 IAM users, and 15 S3 buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You make a call to the <code>GetDiscoveredResourceCounts</code> action and specify
        /// that you want all resource types. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Config returns the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The resource types (EC2 instances, IAM users, and S3 buckets).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of each resource type (25, 20, and 15).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total number of all resources (60).
        /// </para>
        ///  </li> </ul> </li> </ol> 
        /// <para>
        /// The response is paginated. By default, AWS Config lists 100 <a>ResourceCount</a> objects
        /// on each page. You can customize this number with the <code>limit</code> parameter.
        /// The response includes a <code>nextToken</code> string. To get the next page of results,
        /// run the request again and specify the string for the <code>nextToken</code> parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you make a call to the <a>GetDiscoveredResourceCounts</a> action, you might not
        /// immediately receive resource counts in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You are a new AWS Config customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You just enabled resource recording.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// It might take a few minutes for AWS Config to record and count your resources. Wait
        /// a few minutes and then retry the <a>GetDiscoveredResourceCounts</a> action. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredResourceCounts service method.</param>
        /// 
        /// <returns>The response from the GetDiscoveredResourceCounts service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetDiscoveredResourceCounts">REST API Reference for GetDiscoveredResourceCounts Operation</seealso>
        GetDiscoveredResourceCountsResponse GetDiscoveredResourceCounts(GetDiscoveredResourceCountsRequest request);



        /// <summary>
        /// Returns the resource types, the number of each resource type, and the total number
        /// of resources that AWS Config is recording in this region for your AWS account. 
        /// 
        ///  <p class="title"> <b>Example</b> 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// AWS Config is recording three resource types in the US East (Ohio) Region for your
        /// account: 25 EC2 instances, 20 IAM users, and 15 S3 buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You make a call to the <code>GetDiscoveredResourceCounts</code> action and specify
        /// that you want all resource types. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Config returns the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The resource types (EC2 instances, IAM users, and S3 buckets).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of each resource type (25, 20, and 15).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total number of all resources (60).
        /// </para>
        ///  </li> </ul> </li> </ol> 
        /// <para>
        /// The response is paginated. By default, AWS Config lists 100 <a>ResourceCount</a> objects
        /// on each page. You can customize this number with the <code>limit</code> parameter.
        /// The response includes a <code>nextToken</code> string. To get the next page of results,
        /// run the request again and specify the string for the <code>nextToken</code> parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you make a call to the <a>GetDiscoveredResourceCounts</a> action, you might not
        /// immediately receive resource counts in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You are a new AWS Config customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You just enabled resource recording.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// It might take a few minutes for AWS Config to record and count your resources. Wait
        /// a few minutes and then retry the <a>GetDiscoveredResourceCounts</a> action. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredResourceCounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDiscoveredResourceCounts service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetDiscoveredResourceCounts">REST API Reference for GetDiscoveredResourceCounts Operation</seealso>
        Task<GetDiscoveredResourceCountsResponse> GetDiscoveredResourceCountsAsync(GetDiscoveredResourceCountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOrganizationConfigRuleDetailedStatus


        /// <summary>
        /// Returns detailed status for each member account within an organization for a given
        /// organization config rule.
        /// 
        ///  <note> 
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationConfigRuleDetailedStatus service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationConfigRuleDetailedStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// You specified one or more organization config rules that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetOrganizationConfigRuleDetailedStatus">REST API Reference for GetOrganizationConfigRuleDetailedStatus Operation</seealso>
        GetOrganizationConfigRuleDetailedStatusResponse GetOrganizationConfigRuleDetailedStatus(GetOrganizationConfigRuleDetailedStatusRequest request);



        /// <summary>
        /// Returns detailed status for each member account within an organization for a given
        /// organization config rule.
        /// 
        ///  <note> 
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationConfigRuleDetailedStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrganizationConfigRuleDetailedStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// You specified one or more organization config rules that do not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetOrganizationConfigRuleDetailedStatus">REST API Reference for GetOrganizationConfigRuleDetailedStatus Operation</seealso>
        Task<GetOrganizationConfigRuleDetailedStatusResponse> GetOrganizationConfigRuleDetailedStatusAsync(GetOrganizationConfigRuleDetailedStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOrganizationConformancePackDetailedStatus


        /// <summary>
        /// Returns detailed status for each member account within an organization for a given
        /// organization conformance pack.
        /// 
        ///  
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationConformancePackDetailedStatus service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationConformancePackDetailedStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConformancePackException">
        /// AWS Config organization conformance pack that you passed in the filter does not exist.
        /// 
        ///  
        /// <para>
        /// For DeleteOrganizationConformancePack, you tried to delete an organization conformance
        /// pack that does not exist.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetOrganizationConformancePackDetailedStatus">REST API Reference for GetOrganizationConformancePackDetailedStatus Operation</seealso>
        GetOrganizationConformancePackDetailedStatusResponse GetOrganizationConformancePackDetailedStatus(GetOrganizationConformancePackDetailedStatusRequest request);



        /// <summary>
        /// Returns detailed status for each member account within an organization for a given
        /// organization conformance pack.
        /// 
        ///  
        /// <para>
        /// Only a master account can call this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationConformancePackDetailedStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrganizationConformancePackDetailedStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConformancePackException">
        /// AWS Config organization conformance pack that you passed in the filter does not exist.
        /// 
        ///  
        /// <para>
        /// For DeleteOrganizationConformancePack, you tried to delete an organization conformance
        /// pack that does not exist.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetOrganizationConformancePackDetailedStatus">REST API Reference for GetOrganizationConformancePackDetailedStatus Operation</seealso>
        Task<GetOrganizationConformancePackDetailedStatusResponse> GetOrganizationConformancePackDetailedStatusAsync(GetOrganizationConformancePackDetailedStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourceConfigHistory


        /// <summary>
        /// Returns a list of configuration items for the specified resource. The list contains
        /// details about each state of the resource during the specified time interval. If you
        /// specified a retention period to retain your <code>ConfigurationItems</code> between
        /// a minimum of 30 days and a maximum of 7 years (2557 days), AWS Config returns the
        /// <code>ConfigurationItems</code> for the specified retention period. 
        /// 
        ///  
        /// <para>
        /// The response is paginated. By default, AWS Config returns a limit of 10 configuration
        /// items per page. You can customize this number with the <code>limit</code> parameter.
        /// The response includes a <code>nextToken</code> string. To get the next page of results,
        /// run the request again and specify the string for the <code>nextToken</code> parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each call to the API is limited to span a duration of seven days. It is likely that
        /// the number of records returned is smaller than the specified <code>limit</code>. In
        /// such cases, you can make another call, using the <code>nextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfigHistory service method.</param>
        /// 
        /// <returns>The response from the GetResourceConfigHistory service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidTimeRangeException">
        /// The specified time range is not valid. The earlier time is not chronologically before
        /// the later time.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotDiscoveredException">
        /// You have specified a resource that is either unknown or has not been discovered.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetResourceConfigHistory">REST API Reference for GetResourceConfigHistory Operation</seealso>
        GetResourceConfigHistoryResponse GetResourceConfigHistory(GetResourceConfigHistoryRequest request);



        /// <summary>
        /// Returns a list of configuration items for the specified resource. The list contains
        /// details about each state of the resource during the specified time interval. If you
        /// specified a retention period to retain your <code>ConfigurationItems</code> between
        /// a minimum of 30 days and a maximum of 7 years (2557 days), AWS Config returns the
        /// <code>ConfigurationItems</code> for the specified retention period. 
        /// 
        ///  
        /// <para>
        /// The response is paginated. By default, AWS Config returns a limit of 10 configuration
        /// items per page. You can customize this number with the <code>limit</code> parameter.
        /// The response includes a <code>nextToken</code> string. To get the next page of results,
        /// run the request again and specify the string for the <code>nextToken</code> parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each call to the API is limited to span a duration of seven days. It is likely that
        /// the number of records returned is smaller than the specified <code>limit</code>. In
        /// such cases, you can make another call, using the <code>nextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfigHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceConfigHistory service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidTimeRangeException">
        /// The specified time range is not valid. The earlier time is not chronologically before
        /// the later time.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotDiscoveredException">
        /// You have specified a resource that is either unknown or has not been discovered.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetResourceConfigHistory">REST API Reference for GetResourceConfigHistory Operation</seealso>
        Task<GetResourceConfigHistoryResponse> GetResourceConfigHistoryAsync(GetResourceConfigHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAggregateDiscoveredResources


        /// <summary>
        /// Accepts a resource type and returns a list of resource identifiers that are aggregated
        /// for a specific resource type across accounts and regions. A resource identifier includes
        /// the resource type, ID, (if available) the custom resource name, source account, and
        /// source region. You can narrow the results to include only resources that have specific
        /// resource IDs, or a resource name, or source account ID, or source region.
        /// 
        ///  
        /// <para>
        /// For example, if the input consists of accountID 12345678910 and the region is us-east-1
        /// for resource type <code>AWS::EC2::Instance</code> then the API returns all the EC2
        /// instance identifiers of accountID 12345678910 and region us-east-1.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAggregateDiscoveredResources service method.</param>
        /// 
        /// <returns>The response from the ListAggregateDiscoveredResources service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListAggregateDiscoveredResources">REST API Reference for ListAggregateDiscoveredResources Operation</seealso>
        ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest request);



        /// <summary>
        /// Accepts a resource type and returns a list of resource identifiers that are aggregated
        /// for a specific resource type across accounts and regions. A resource identifier includes
        /// the resource type, ID, (if available) the custom resource name, source account, and
        /// source region. You can narrow the results to include only resources that have specific
        /// resource IDs, or a resource name, or source account ID, or source region.
        /// 
        ///  
        /// <para>
        /// For example, if the input consists of accountID 12345678910 and the region is us-east-1
        /// for resource type <code>AWS::EC2::Instance</code> then the API returns all the EC2
        /// instance identifiers of accountID 12345678910 and region us-east-1.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAggregateDiscoveredResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAggregateDiscoveredResources service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListAggregateDiscoveredResources">REST API Reference for ListAggregateDiscoveredResources Operation</seealso>
        Task<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResourcesAsync(ListAggregateDiscoveredResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDiscoveredResources


        /// <summary>
        /// Accepts a resource type and returns a list of resource identifiers for the resources
        /// of that type. A resource identifier includes the resource type, ID, and (if available)
        /// the custom resource name. The results consist of resources that AWS Config has discovered,
        /// including those that AWS Config is not currently recording. You can narrow the results
        /// to include only resources that have specific resource IDs or a resource name.
        /// 
        ///  <note> 
        /// <para>
        /// You can specify either resource IDs or a resource name, but not both, in the same
        /// request.
        /// </para>
        ///  </note> 
        /// <para>
        /// The response is paginated. By default, AWS Config lists 100 resource identifiers on
        /// each page. You can customize this number with the <code>limit</code> parameter. The
        /// response includes a <code>nextToken</code> string. To get the next page of results,
        /// run the request again and specify the string for the <code>nextToken</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveredResources service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request);



        /// <summary>
        /// Accepts a resource type and returns a list of resource identifiers for the resources
        /// of that type. A resource identifier includes the resource type, ID, and (if available)
        /// the custom resource name. The results consist of resources that AWS Config has discovered,
        /// including those that AWS Config is not currently recording. You can narrow the results
        /// to include only resources that have specific resource IDs or a resource name.
        /// 
        ///  <note> 
        /// <para>
        /// You can specify either resource IDs or a resource name, but not both, in the same
        /// request.
        /// </para>
        ///  </note> 
        /// <para>
        /// The response is paginated. By default, AWS Config lists 100 resource identifiers on
        /// each page. You can customize this number with the <code>limit</code> parameter. The
        /// response includes a <code>nextToken</code> string. To get the next page of results,
        /// run the request again and specify the string for the <code>nextToken</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoveredResources service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesAsync(ListDiscoveredResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags for AWS Config resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotFoundException">
        /// You have specified a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List the tags for AWS Config resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotFoundException">
        /// You have specified a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAggregationAuthorization


        /// <summary>
        /// Authorizes the aggregator account and region to collect data from the source account
        /// and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAggregationAuthorization service method.</param>
        /// 
        /// <returns>The response from the PutAggregationAuthorization service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutAggregationAuthorization">REST API Reference for PutAggregationAuthorization Operation</seealso>
        PutAggregationAuthorizationResponse PutAggregationAuthorization(PutAggregationAuthorizationRequest request);



        /// <summary>
        /// Authorizes the aggregator account and region to collect data from the source account
        /// and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAggregationAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAggregationAuthorization service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutAggregationAuthorization">REST API Reference for PutAggregationAuthorization Operation</seealso>
        Task<PutAggregationAuthorizationResponse> PutAggregationAuthorizationAsync(PutAggregationAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutConfigRule


        /// <summary>
        /// Adds or updates an AWS Config rule for evaluating whether your AWS resources comply
        /// with your desired configurations.
        /// 
        ///  
        /// <para>
        /// You can use this action for custom AWS Config rules and AWS managed Config rules.
        /// A custom AWS Config rule is a rule that you develop and maintain. An AWS managed Config
        /// rule is a customizable, predefined rule that AWS Config provides.
        /// </para>
        ///  
        /// <para>
        /// If you are adding a new custom AWS Config rule, you must first create the AWS Lambda
        /// function that the rule invokes to evaluate your resources. When you use the <code>PutConfigRule</code>
        /// action to add the rule to AWS Config, you must specify the Amazon Resource Name (ARN)
        /// that AWS Lambda assigns to the function. Specify the ARN for the <code>SourceIdentifier</code>
        /// key. This key is part of the <code>Source</code> object, which is part of the <code>ConfigRule</code>
        /// object. 
        /// </para>
        ///  
        /// <para>
        /// If you are adding an AWS managed Config rule, specify the rule's identifier for the
        /// <code>SourceIdentifier</code> key. To reference AWS managed Config rule identifiers,
        /// see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">About
        /// AWS Managed Config Rules</a>.
        /// </para>
        ///  
        /// <para>
        /// For any new rule that you add, specify the <code>ConfigRuleName</code> in the <code>ConfigRule</code>
        /// object. Do not specify the <code>ConfigRuleArn</code> or the <code>ConfigRuleId</code>.
        /// These values are generated by AWS Config for new rules.
        /// </para>
        ///  
        /// <para>
        /// If you are updating a rule that you added previously, you can specify the rule by
        /// <code>ConfigRuleName</code>, <code>ConfigRuleId</code>, or <code>ConfigRuleArn</code>
        /// in the <code>ConfigRule</code> data type that you use in this request.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of rules that AWS Config supports is 150.
        /// </para>
        ///  
        /// <para>
        /// For information about requesting a rule limit increase, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_config">AWS
        /// Config Limits</a> in the <i>AWS General Reference Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about developing and using AWS Config rules, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config.html">Evaluating
        /// AWS Resource Configurations with AWS Config</a> in the <i>AWS Config Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigRule service method.</param>
        /// 
        /// <returns>The response from the PutConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConfigRulesExceededException">
        /// Failed to add the AWS Config rule because the account already contains the maximum
        /// number of 150 rules. Consider deleting any deactivated rules before you add new rules.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigRule">REST API Reference for PutConfigRule Operation</seealso>
        PutConfigRuleResponse PutConfigRule(PutConfigRuleRequest request);



        /// <summary>
        /// Adds or updates an AWS Config rule for evaluating whether your AWS resources comply
        /// with your desired configurations.
        /// 
        ///  
        /// <para>
        /// You can use this action for custom AWS Config rules and AWS managed Config rules.
        /// A custom AWS Config rule is a rule that you develop and maintain. An AWS managed Config
        /// rule is a customizable, predefined rule that AWS Config provides.
        /// </para>
        ///  
        /// <para>
        /// If you are adding a new custom AWS Config rule, you must first create the AWS Lambda
        /// function that the rule invokes to evaluate your resources. When you use the <code>PutConfigRule</code>
        /// action to add the rule to AWS Config, you must specify the Amazon Resource Name (ARN)
        /// that AWS Lambda assigns to the function. Specify the ARN for the <code>SourceIdentifier</code>
        /// key. This key is part of the <code>Source</code> object, which is part of the <code>ConfigRule</code>
        /// object. 
        /// </para>
        ///  
        /// <para>
        /// If you are adding an AWS managed Config rule, specify the rule's identifier for the
        /// <code>SourceIdentifier</code> key. To reference AWS managed Config rule identifiers,
        /// see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">About
        /// AWS Managed Config Rules</a>.
        /// </para>
        ///  
        /// <para>
        /// For any new rule that you add, specify the <code>ConfigRuleName</code> in the <code>ConfigRule</code>
        /// object. Do not specify the <code>ConfigRuleArn</code> or the <code>ConfigRuleId</code>.
        /// These values are generated by AWS Config for new rules.
        /// </para>
        ///  
        /// <para>
        /// If you are updating a rule that you added previously, you can specify the rule by
        /// <code>ConfigRuleName</code>, <code>ConfigRuleId</code>, or <code>ConfigRuleArn</code>
        /// in the <code>ConfigRule</code> data type that you use in this request.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of rules that AWS Config supports is 150.
        /// </para>
        ///  
        /// <para>
        /// For information about requesting a rule limit increase, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_config">AWS
        /// Config Limits</a> in the <i>AWS General Reference Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about developing and using AWS Config rules, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config.html">Evaluating
        /// AWS Resource Configurations with AWS Config</a> in the <i>AWS Config Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConfigRulesExceededException">
        /// Failed to add the AWS Config rule because the account already contains the maximum
        /// number of 150 rules. Consider deleting any deactivated rules before you add new rules.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigRule">REST API Reference for PutConfigRule Operation</seealso>
        Task<PutConfigRuleResponse> PutConfigRuleAsync(PutConfigRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutConfigurationAggregator


        /// <summary>
        /// Creates and updates the configuration aggregator with the selected source accounts
        /// and regions. The source account can be individual account(s) or an organization.
        /// 
        ///  <note> 
        /// <para>
        /// AWS Config should be enabled in source accounts and regions you want to aggregate.
        /// </para>
        ///  
        /// <para>
        /// If your source type is an organization, you must be signed in to the master account
        /// and all features must be enabled in your organization. AWS Config calls <code>EnableAwsServiceAccess</code>
        /// API to enable integration between AWS Config and AWS Organizations. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationAggregator service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationAggregator service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRoleException">
        /// You have provided a null or empty role ARN.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.LimitExceededException">
        /// For <code>StartConfigRulesEvaluation</code> API, this exception is thrown if an evaluation
        /// is in progress or if you call the <a>StartConfigRulesEvaluation</a> API more than
        /// once per minute.
        /// 
        ///  
        /// <para>
        /// For <code>PutConfigurationAggregator</code> API, this exception is thrown if the number
        /// of accounts and aggregators exceeds the limit.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableOrganizationException">
        /// Organization is no longer available.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAllFeaturesNotEnabledException">
        /// AWS Config resource cannot be created because your organization does not have all
        /// features enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationAggregator">REST API Reference for PutConfigurationAggregator Operation</seealso>
        PutConfigurationAggregatorResponse PutConfigurationAggregator(PutConfigurationAggregatorRequest request);



        /// <summary>
        /// Creates and updates the configuration aggregator with the selected source accounts
        /// and regions. The source account can be individual account(s) or an organization.
        /// 
        ///  <note> 
        /// <para>
        /// AWS Config should be enabled in source accounts and regions you want to aggregate.
        /// </para>
        ///  
        /// <para>
        /// If your source type is an organization, you must be signed in to the master account
        /// and all features must be enabled in your organization. AWS Config calls <code>EnableAwsServiceAccess</code>
        /// API to enable integration between AWS Config and AWS Organizations. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationAggregator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationAggregator service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRoleException">
        /// You have provided a null or empty role ARN.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.LimitExceededException">
        /// For <code>StartConfigRulesEvaluation</code> API, this exception is thrown if an evaluation
        /// is in progress or if you call the <a>StartConfigRulesEvaluation</a> API more than
        /// once per minute.
        /// 
        ///  
        /// <para>
        /// For <code>PutConfigurationAggregator</code> API, this exception is thrown if the number
        /// of accounts and aggregators exceeds the limit.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableOrganizationException">
        /// Organization is no longer available.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAllFeaturesNotEnabledException">
        /// AWS Config resource cannot be created because your organization does not have all
        /// features enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationAggregator">REST API Reference for PutConfigurationAggregator Operation</seealso>
        Task<PutConfigurationAggregatorResponse> PutConfigurationAggregatorAsync(PutConfigurationAggregatorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutConfigurationRecorder


        /// <summary>
        /// Creates a new configuration recorder to record the selected resource configurations.
        /// 
        ///  
        /// <para>
        /// You can use this action to change the role <code>roleARN</code> or the <code>recordingGroup</code>
        /// of an existing recorder. To change the role, call the action on the existing configuration
        /// recorder and specify a role.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  
        /// <para>
        /// If <code>ConfigurationRecorder</code> does not have the <b>recordingGroup</b> parameter
        /// specified, the default is to record all supported resource types.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidConfigurationRecorderNameException">
        /// You have provided a configuration recorder name that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRecordingGroupException">
        /// AWS Config throws an exception if the recording group does not contain a valid list
        /// of resource types. Invalid values might also be incorrectly formatted.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRoleException">
        /// You have provided a null or empty role ARN.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConfigurationRecordersExceededException">
        /// You have reached the limit of the number of recorders you can create.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationRecorder">REST API Reference for PutConfigurationRecorder Operation</seealso>
        PutConfigurationRecorderResponse PutConfigurationRecorder(PutConfigurationRecorderRequest request);



        /// <summary>
        /// Creates a new configuration recorder to record the selected resource configurations.
        /// 
        ///  
        /// <para>
        /// You can use this action to change the role <code>roleARN</code> or the <code>recordingGroup</code>
        /// of an existing recorder. To change the role, call the action on the existing configuration
        /// recorder and specify a role.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  
        /// <para>
        /// If <code>ConfigurationRecorder</code> does not have the <b>recordingGroup</b> parameter
        /// specified, the default is to record all supported resource types.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationRecorder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidConfigurationRecorderNameException">
        /// You have provided a configuration recorder name that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRecordingGroupException">
        /// AWS Config throws an exception if the recording group does not contain a valid list
        /// of resource types. Invalid values might also be incorrectly formatted.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRoleException">
        /// You have provided a null or empty role ARN.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConfigurationRecordersExceededException">
        /// You have reached the limit of the number of recorders you can create.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationRecorder">REST API Reference for PutConfigurationRecorder Operation</seealso>
        Task<PutConfigurationRecorderResponse> PutConfigurationRecorderAsync(PutConfigurationRecorderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutConformancePack


        /// <summary>
        /// Creates or updates a conformance pack. A conformance pack is a collection of AWS Config
        /// rules that can be easily deployed in an account and a region.
        /// 
        ///  
        /// <para>
        /// This API creates a service linked role <code>AWSServiceRoleForConfigConforms</code>
        /// in your account. The service linked role is created only when the role does not exist
        /// in your account. AWS Config verifies the existence of role with <code>GetRole</code>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify either the <code>TemplateS3Uri</code> or the <code>TemplateBody</code>
        /// parameter, but not both. If you provide both AWS Config uses the <code>TemplateS3Uri</code>
        /// parameter and ignores the <code>TemplateBody</code> parameter.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConformancePack service method.</param>
        /// 
        /// <returns>The response from the PutConformancePack service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.ConformancePackTemplateValidationException">
        /// You have specified a template that is not valid or supported.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConformancePacksExceededException">
        /// You have reached the limit (20) of the number of conformance packs in an account.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConformancePack">REST API Reference for PutConformancePack Operation</seealso>
        PutConformancePackResponse PutConformancePack(PutConformancePackRequest request);



        /// <summary>
        /// Creates or updates a conformance pack. A conformance pack is a collection of AWS Config
        /// rules that can be easily deployed in an account and a region.
        /// 
        ///  
        /// <para>
        /// This API creates a service linked role <code>AWSServiceRoleForConfigConforms</code>
        /// in your account. The service linked role is created only when the role does not exist
        /// in your account. AWS Config verifies the existence of role with <code>GetRole</code>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must specify either the <code>TemplateS3Uri</code> or the <code>TemplateBody</code>
        /// parameter, but not both. If you provide both AWS Config uses the <code>TemplateS3Uri</code>
        /// parameter and ignores the <code>TemplateBody</code> parameter.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConformancePack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConformancePack service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.ConformancePackTemplateValidationException">
        /// You have specified a template that is not valid or supported.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConformancePacksExceededException">
        /// You have reached the limit (20) of the number of conformance packs in an account.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConformancePack">REST API Reference for PutConformancePack Operation</seealso>
        Task<PutConformancePackResponse> PutConformancePackAsync(PutConformancePackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDeliveryChannel


        /// <summary>
        /// Creates a delivery channel object to deliver configuration information to an Amazon
        /// S3 bucket and Amazon SNS topic.
        /// 
        ///  
        /// <para>
        /// Before you can create a delivery channel, you must create a configuration recorder.
        /// </para>
        ///  
        /// <para>
        /// You can use this action to change the Amazon S3 bucket or an Amazon SNS topic of the
        /// existing delivery channel. To change the Amazon S3 bucket or an Amazon SNS topic,
        /// call this action and specify the changed values for the S3 bucket and the SNS topic.
        /// If you specify a different value for either the S3 bucket or the SNS topic, this action
        /// will keep the existing value for the parameter that is not changed.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can have only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryChannel service method.</param>
        /// 
        /// <returns>The response from the PutDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientDeliveryPolicyException">
        /// Your Amazon S3 bucket policy does not permit AWS Config to write to it.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidDeliveryChannelNameException">
        /// The specified delivery channel name is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidS3KeyPrefixException">
        /// The specified Amazon S3 key prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidSNSTopicARNException">
        /// The specified Amazon SNS topic does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfDeliveryChannelsExceededException">
        /// You have reached the limit of the number of delivery channels you can create.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchBucketException">
        /// The specified Amazon S3 bucket does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutDeliveryChannel">REST API Reference for PutDeliveryChannel Operation</seealso>
        PutDeliveryChannelResponse PutDeliveryChannel(PutDeliveryChannelRequest request);



        /// <summary>
        /// Creates a delivery channel object to deliver configuration information to an Amazon
        /// S3 bucket and Amazon SNS topic.
        /// 
        ///  
        /// <para>
        /// Before you can create a delivery channel, you must create a configuration recorder.
        /// </para>
        ///  
        /// <para>
        /// You can use this action to change the Amazon S3 bucket or an Amazon SNS topic of the
        /// existing delivery channel. To change the Amazon S3 bucket or an Amazon SNS topic,
        /// call this action and specify the changed values for the S3 bucket and the SNS topic.
        /// If you specify a different value for either the S3 bucket or the SNS topic, this action
        /// will keep the existing value for the parameter that is not changed.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can have only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientDeliveryPolicyException">
        /// Your Amazon S3 bucket policy does not permit AWS Config to write to it.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidDeliveryChannelNameException">
        /// The specified delivery channel name is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidS3KeyPrefixException">
        /// The specified Amazon S3 key prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidSNSTopicARNException">
        /// The specified Amazon SNS topic does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfDeliveryChannelsExceededException">
        /// You have reached the limit of the number of delivery channels you can create.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchBucketException">
        /// The specified Amazon S3 bucket does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutDeliveryChannel">REST API Reference for PutDeliveryChannel Operation</seealso>
        Task<PutDeliveryChannelResponse> PutDeliveryChannelAsync(PutDeliveryChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutEvaluations


        /// <summary>
        /// Used by an AWS Lambda function to deliver evaluation results to AWS Config. This action
        /// is required in every AWS Lambda function that is invoked by an AWS Config rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvaluations service method.</param>
        /// 
        /// <returns>The response from the PutEvaluations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidResultTokenException">
        /// The specified <code>ResultToken</code> is invalid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutEvaluations">REST API Reference for PutEvaluations Operation</seealso>
        PutEvaluationsResponse PutEvaluations(PutEvaluationsRequest request);



        /// <summary>
        /// Used by an AWS Lambda function to deliver evaluation results to AWS Config. This action
        /// is required in every AWS Lambda function that is invoked by an AWS Config rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvaluations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEvaluations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidResultTokenException">
        /// The specified <code>ResultToken</code> is invalid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutEvaluations">REST API Reference for PutEvaluations Operation</seealso>
        Task<PutEvaluationsResponse> PutEvaluationsAsync(PutEvaluationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutOrganizationConfigRule


        /// <summary>
        /// Adds or updates organization config rule for your entire organization evaluating whether
        /// your AWS resources comply with your desired configurations. Only a master account
        /// can create or update an organization config rule.
        /// 
        ///  
        /// <para>
        /// This API enables organization service access through the <code>EnableAWSServiceAccess</code>
        /// action and creates a service linked role <code>AWSServiceRoleForConfigMultiAccountSetup</code>
        /// in the master account of your organization. The service linked role is created only
        /// when the role does not exist in the master account. AWS Config verifies the existence
        /// of role with <code>GetRole</code> action.
        /// </para>
        ///  
        /// <para>
        /// You can use this action to create both custom AWS Config rules and AWS managed Config
        /// rules. If you are adding a new custom AWS Config rule, you must first create AWS Lambda
        /// function in the master account that the rule invokes to evaluate your resources. When
        /// you use the <code>PutOrganizationConfigRule</code> action to add the rule to AWS Config,
        /// you must specify the Amazon Resource Name (ARN) that AWS Lambda assigns to the function.
        /// If you are adding an AWS managed Config rule, specify the rule's identifier for the
        /// <code>RuleIdentifier</code> key.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of organization config rules that AWS Config supports is 150.
        /// </para>
        ///  <note> 
        /// <para>
        /// Specify either <code>OrganizationCustomRuleMetadata</code> or <code>OrganizationManagedRuleMetadata</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationConfigRule service method.</param>
        /// 
        /// <returns>The response from the PutOrganizationConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfOrganizationConfigRulesExceededException">
        /// You have reached the limit of the number of organization config rules you can create.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableOrganizationException">
        /// Organization is no longer available.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAllFeaturesNotEnabledException">
        /// AWS Config resource cannot be created because your organization does not have all
        /// features enabled.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutOrganizationConfigRule">REST API Reference for PutOrganizationConfigRule Operation</seealso>
        PutOrganizationConfigRuleResponse PutOrganizationConfigRule(PutOrganizationConfigRuleRequest request);



        /// <summary>
        /// Adds or updates organization config rule for your entire organization evaluating whether
        /// your AWS resources comply with your desired configurations. Only a master account
        /// can create or update an organization config rule.
        /// 
        ///  
        /// <para>
        /// This API enables organization service access through the <code>EnableAWSServiceAccess</code>
        /// action and creates a service linked role <code>AWSServiceRoleForConfigMultiAccountSetup</code>
        /// in the master account of your organization. The service linked role is created only
        /// when the role does not exist in the master account. AWS Config verifies the existence
        /// of role with <code>GetRole</code> action.
        /// </para>
        ///  
        /// <para>
        /// You can use this action to create both custom AWS Config rules and AWS managed Config
        /// rules. If you are adding a new custom AWS Config rule, you must first create AWS Lambda
        /// function in the master account that the rule invokes to evaluate your resources. When
        /// you use the <code>PutOrganizationConfigRule</code> action to add the rule to AWS Config,
        /// you must specify the Amazon Resource Name (ARN) that AWS Lambda assigns to the function.
        /// If you are adding an AWS managed Config rule, specify the rule's identifier for the
        /// <code>RuleIdentifier</code> key.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of organization config rules that AWS Config supports is 150.
        /// </para>
        ///  <note> 
        /// <para>
        /// Specify either <code>OrganizationCustomRuleMetadata</code> or <code>OrganizationManagedRuleMetadata</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationConfigRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutOrganizationConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfOrganizationConfigRulesExceededException">
        /// You have reached the limit of the number of organization config rules you can create.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableOrganizationException">
        /// Organization is no longer available.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAllFeaturesNotEnabledException">
        /// AWS Config resource cannot be created because your organization does not have all
        /// features enabled.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutOrganizationConfigRule">REST API Reference for PutOrganizationConfigRule Operation</seealso>
        Task<PutOrganizationConfigRuleResponse> PutOrganizationConfigRuleAsync(PutOrganizationConfigRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutOrganizationConformancePack


        /// <summary>
        /// Deploys conformance packs across member accounts in an AWS Organization.
        /// 
        ///  
        /// <para>
        /// This API enables organization service access through the <code>EnableAWSServiceAccess</code>
        /// action and creates a service linked role AWSServiceRoleForConfigMultiAccountSetup
        /// in the master account of your organization. The service linked role is created only
        /// when the role does not exist in the master account. AWS Config verifies the existence
        /// of role with GetRole action. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The SPN is <code>config-multiaccountsetup.amazonaws.com</code>.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the <code>TemplateS3Uri</code> or the <code>TemplateBody</code>
        /// parameter, but not both. If you provide both AWS Config uses the <code>TemplateS3Uri</code>
        /// parameter and ignores the <code>TemplateBody</code> parameter.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationConformancePack service method.</param>
        /// 
        /// <returns>The response from the PutOrganizationConformancePack service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfOrganizationConformancePacksExceededException">
        /// You have reached the limit (10) of the number of organization conformance packs in
        /// an account.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableOrganizationException">
        /// Organization is no longer available.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAllFeaturesNotEnabledException">
        /// AWS Config resource cannot be created because your organization does not have all
        /// features enabled.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationConformancePackTemplateValidationException">
        /// You have specified a template that is not valid or supported.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutOrganizationConformancePack">REST API Reference for PutOrganizationConformancePack Operation</seealso>
        PutOrganizationConformancePackResponse PutOrganizationConformancePack(PutOrganizationConformancePackRequest request);



        /// <summary>
        /// Deploys conformance packs across member accounts in an AWS Organization.
        /// 
        ///  
        /// <para>
        /// This API enables organization service access through the <code>EnableAWSServiceAccess</code>
        /// action and creates a service linked role AWSServiceRoleForConfigMultiAccountSetup
        /// in the master account of your organization. The service linked role is created only
        /// when the role does not exist in the master account. AWS Config verifies the existence
        /// of role with GetRole action. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The SPN is <code>config-multiaccountsetup.amazonaws.com</code>.
        /// </para>
        ///  
        /// <para>
        /// You must specify either the <code>TemplateS3Uri</code> or the <code>TemplateBody</code>
        /// parameter, but not both. If you provide both AWS Config uses the <code>TemplateS3Uri</code>
        /// parameter and ignores the <code>TemplateBody</code> parameter.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationConformancePack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutOrganizationConformancePack service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfOrganizationConformancePacksExceededException">
        /// You have reached the limit (10) of the number of organization conformance packs in
        /// an account.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableOrganizationException">
        /// Organization is no longer available.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// For PutConfigAggregator API, no permission to call EnableAWSServiceAccess API.
        /// 
        ///  
        /// <para>
        /// For all OrganizationConfigRule and OrganizationConformancePack APIs, AWS Config throws
        /// an exception if APIs are called from member accounts. All APIs must be called from
        /// organization master account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAllFeaturesNotEnabledException">
        /// AWS Config resource cannot be created because your organization does not have all
        /// features enabled.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationConformancePackTemplateValidationException">
        /// You have specified a template that is not valid or supported.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutOrganizationConformancePack">REST API Reference for PutOrganizationConformancePack Operation</seealso>
        Task<PutOrganizationConformancePackResponse> PutOrganizationConformancePackAsync(PutOrganizationConformancePackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRemediationConfigurations


        /// <summary>
        /// Adds or updates the remediation configuration with a specific AWS Config rule with
        /// the selected target or action. The API creates the <code>RemediationConfiguration</code>
        /// object for the AWS Config rule. The AWS Config rule must already exist for you to
        /// add a remediation configuration. The target (SSM document) must exist and have permissions
        /// to use the target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRemediationConfigurations service method.</param>
        /// 
        /// <returns>The response from the PutRemediationConfigurations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRemediationConfigurations">REST API Reference for PutRemediationConfigurations Operation</seealso>
        PutRemediationConfigurationsResponse PutRemediationConfigurations(PutRemediationConfigurationsRequest request);



        /// <summary>
        /// Adds or updates the remediation configuration with a specific AWS Config rule with
        /// the selected target or action. The API creates the <code>RemediationConfiguration</code>
        /// object for the AWS Config rule. The AWS Config rule must already exist for you to
        /// add a remediation configuration. The target (SSM document) must exist and have permissions
        /// to use the target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRemediationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRemediationConfigurations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRemediationConfigurations">REST API Reference for PutRemediationConfigurations Operation</seealso>
        Task<PutRemediationConfigurationsResponse> PutRemediationConfigurationsAsync(PutRemediationConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRemediationExceptions


        /// <summary>
        /// A remediation exception is when a specific resource is no longer considered for auto-remediation.
        /// This API adds a new exception or updates an exisiting exception for a specific resource
        /// with a specific AWS Config rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRemediationExceptions service method.</param>
        /// 
        /// <returns>The response from the PutRemediationExceptions service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRemediationExceptions">REST API Reference for PutRemediationExceptions Operation</seealso>
        PutRemediationExceptionsResponse PutRemediationExceptions(PutRemediationExceptionsRequest request);



        /// <summary>
        /// A remediation exception is when a specific resource is no longer considered for auto-remediation.
        /// This API adds a new exception or updates an exisiting exception for a specific resource
        /// with a specific AWS Config rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRemediationExceptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRemediationExceptions service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRemediationExceptions">REST API Reference for PutRemediationExceptions Operation</seealso>
        Task<PutRemediationExceptionsResponse> PutRemediationExceptionsAsync(PutRemediationExceptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRetentionConfiguration


        /// <summary>
        /// Creates and updates the retention configuration with details about retention period
        /// (number of days) that AWS Config stores your historical information. The API creates
        /// the <code>RetentionConfiguration</code> object and names the object as <b>default</b>.
        /// When you have a <code>RetentionConfiguration</code> object named <b>default</b>, calling
        /// the API modifies the default object. 
        /// 
        ///  <note> 
        /// <para>
        /// Currently, AWS Config supports only one retention configuration per region in your
        /// account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutRetentionConfiguration service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfRetentionConfigurationsExceededException">
        /// Failed to add the retention configuration because a retention configuration with that
        /// name already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRetentionConfiguration">REST API Reference for PutRetentionConfiguration Operation</seealso>
        PutRetentionConfigurationResponse PutRetentionConfiguration(PutRetentionConfigurationRequest request);



        /// <summary>
        /// Creates and updates the retention configuration with details about retention period
        /// (number of days) that AWS Config stores your historical information. The API creates
        /// the <code>RetentionConfiguration</code> object and names the object as <b>default</b>.
        /// When you have a <code>RetentionConfiguration</code> object named <b>default</b>, calling
        /// the API modifies the default object. 
        /// 
        ///  <note> 
        /// <para>
        /// Currently, AWS Config supports only one retention configuration per region in your
        /// account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRetentionConfiguration service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfRetentionConfigurationsExceededException">
        /// Failed to add the retention configuration because a retention configuration with that
        /// name already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRetentionConfiguration">REST API Reference for PutRetentionConfiguration Operation</seealso>
        Task<PutRetentionConfigurationResponse> PutRetentionConfigurationAsync(PutRetentionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SelectResourceConfig


        /// <summary>
        /// Accepts a structured query language (SQL) <code>SELECT</code> command, performs the
        /// corresponding search, and returns resource configurations matching the properties.
        /// 
        ///  
        /// <para>
        /// For more information about query components, see the <a href="https://docs.aws.amazon.com/config/latest/developerguide/query-components.html">
        /// <b>Query Components</b> </a> section in the AWS Config Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SelectResourceConfig service method.</param>
        /// 
        /// <returns>The response from the SelectResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidExpressionException">
        /// The syntax of the query is incorrect.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/SelectResourceConfig">REST API Reference for SelectResourceConfig Operation</seealso>
        SelectResourceConfigResponse SelectResourceConfig(SelectResourceConfigRequest request);



        /// <summary>
        /// Accepts a structured query language (SQL) <code>SELECT</code> command, performs the
        /// corresponding search, and returns resource configurations matching the properties.
        /// 
        ///  
        /// <para>
        /// For more information about query components, see the <a href="https://docs.aws.amazon.com/config/latest/developerguide/query-components.html">
        /// <b>Query Components</b> </a> section in the AWS Config Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SelectResourceConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SelectResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidExpressionException">
        /// The syntax of the query is incorrect.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/SelectResourceConfig">REST API Reference for SelectResourceConfig Operation</seealso>
        Task<SelectResourceConfigResponse> SelectResourceConfigAsync(SelectResourceConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartConfigRulesEvaluation


        /// <summary>
        /// Runs an on-demand evaluation for the specified AWS Config rules against the last known
        /// configuration state of the resources. Use <code>StartConfigRulesEvaluation</code>
        /// when you want to test that a rule you updated is working as expected. <code>StartConfigRulesEvaluation</code>
        /// does not re-record the latest configuration state for your resources. It re-runs an
        /// evaluation against the last known state of your resources. 
        /// 
        ///  
        /// <para>
        /// You can specify up to 25 AWS Config rules per request. 
        /// </para>
        ///  
        /// <para>
        /// An existing <code>StartConfigRulesEvaluation</code> call for the specified rules must
        /// complete before you can call the API again. If you chose to have AWS Config stream
        /// to an Amazon SNS topic, you will receive a <code>ConfigRuleEvaluationStarted</code>
        /// notification when the evaluation starts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You don't need to call the <code>StartConfigRulesEvaluation</code> API to run an evaluation
        /// for a new rule. When you create a rule, AWS Config evaluates your resources against
        /// the rule automatically. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>StartConfigRulesEvaluation</code> API is useful if you want to run on-demand
        /// evaluations, such as the following example:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You have a custom rule that evaluates your IAM resources every 24 hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You update your Lambda function to add additional conditions to your rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instead of waiting for the next periodic evaluation, you call the <code>StartConfigRulesEvaluation</code>
        /// API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Config invokes your Lambda function and evaluates your IAM resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your custom rule will still run periodic evaluations every 24 hours.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigRulesEvaluation service method.</param>
        /// 
        /// <returns>The response from the StartConfigRulesEvaluation service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.LimitExceededException">
        /// For <code>StartConfigRulesEvaluation</code> API, this exception is thrown if an evaluation
        /// is in progress or if you call the <a>StartConfigRulesEvaluation</a> API more than
        /// once per minute.
        /// 
        ///  
        /// <para>
        /// For <code>PutConfigurationAggregator</code> API, this exception is thrown if the number
        /// of accounts and aggregators exceeds the limit.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigRulesEvaluation">REST API Reference for StartConfigRulesEvaluation Operation</seealso>
        StartConfigRulesEvaluationResponse StartConfigRulesEvaluation(StartConfigRulesEvaluationRequest request);



        /// <summary>
        /// Runs an on-demand evaluation for the specified AWS Config rules against the last known
        /// configuration state of the resources. Use <code>StartConfigRulesEvaluation</code>
        /// when you want to test that a rule you updated is working as expected. <code>StartConfigRulesEvaluation</code>
        /// does not re-record the latest configuration state for your resources. It re-runs an
        /// evaluation against the last known state of your resources. 
        /// 
        ///  
        /// <para>
        /// You can specify up to 25 AWS Config rules per request. 
        /// </para>
        ///  
        /// <para>
        /// An existing <code>StartConfigRulesEvaluation</code> call for the specified rules must
        /// complete before you can call the API again. If you chose to have AWS Config stream
        /// to an Amazon SNS topic, you will receive a <code>ConfigRuleEvaluationStarted</code>
        /// notification when the evaluation starts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You don't need to call the <code>StartConfigRulesEvaluation</code> API to run an evaluation
        /// for a new rule. When you create a rule, AWS Config evaluates your resources against
        /// the rule automatically. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>StartConfigRulesEvaluation</code> API is useful if you want to run on-demand
        /// evaluations, such as the following example:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You have a custom rule that evaluates your IAM resources every 24 hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You update your Lambda function to add additional conditions to your rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instead of waiting for the next periodic evaluation, you call the <code>StartConfigRulesEvaluation</code>
        /// API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Config invokes your Lambda function and evaluates your IAM resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your custom rule will still run periodic evaluations every 24 hours.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigRulesEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConfigRulesEvaluation service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.LimitExceededException">
        /// For <code>StartConfigRulesEvaluation</code> API, this exception is thrown if an evaluation
        /// is in progress or if you call the <a>StartConfigRulesEvaluation</a> API more than
        /// once per minute.
        /// 
        ///  
        /// <para>
        /// For <code>PutConfigurationAggregator</code> API, this exception is thrown if the number
        /// of accounts and aggregators exceeds the limit.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// You see this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For DeleteConfigRule, AWS Config is deleting this rule. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, the rule is deleting your evaluation results. Try your request
        /// again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConfigRule, a remediation action is associated with the rule and AWS Config
        /// cannot delete this rule. Delete the remediation action associated with the rule before
        /// deleting the rule and try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigOrganizationRule, organization config rule deletion is in progress. Try
        /// your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteOrganizationConfigRule, organization config rule creation is in progress.
        /// Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack creation,
        /// update, and deletion is in progress. Try your request again later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For DeleteConformancePack, a conformance pack creation, update, and deletion is in
        /// progress. Try your request again later.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigRulesEvaluation">REST API Reference for StartConfigRulesEvaluation Operation</seealso>
        Task<StartConfigRulesEvaluationResponse> StartConfigRulesEvaluationAsync(StartConfigRulesEvaluationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartConfigurationRecorder


        /// <summary>
        /// Starts recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// 
        ///  
        /// <para>
        /// You must have created at least one delivery channel to successfully start the configuration
        /// recorder.
        /// </para>
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// 
        /// <returns>The response from the StartConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableDeliveryChannelException">
        /// There is no delivery channel available to record configurations.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        StartConfigurationRecorderResponse StartConfigurationRecorder(string configurationRecorderName);

        /// <summary>
        /// Starts recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// 
        ///  
        /// <para>
        /// You must have created at least one delivery channel to successfully start the configuration
        /// recorder.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the StartConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableDeliveryChannelException">
        /// There is no delivery channel available to record configurations.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        StartConfigurationRecorderResponse StartConfigurationRecorder(StartConfigurationRecorderRequest request);


        /// <summary>
        /// Starts recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// 
        ///  
        /// <para>
        /// You must have created at least one delivery channel to successfully start the configuration
        /// recorder.
        /// </para>
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableDeliveryChannelException">
        /// There is no delivery channel available to record configurations.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        Task<StartConfigurationRecorderResponse> StartConfigurationRecorderAsync(string configurationRecorderName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Starts recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// 
        ///  
        /// <para>
        /// You must have created at least one delivery channel to successfully start the configuration
        /// recorder.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationRecorder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableDeliveryChannelException">
        /// There is no delivery channel available to record configurations.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        Task<StartConfigurationRecorderResponse> StartConfigurationRecorderAsync(StartConfigurationRecorderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartRemediationExecution


        /// <summary>
        /// Runs an on-demand remediation for the specified AWS Config rules against the last
        /// known remediation configuration. It runs an execution against the current state of
        /// your resources. Remediation execution is asynchronous.
        /// 
        ///  
        /// <para>
        /// You can specify up to 100 resource keys per request. An existing StartRemediationExecution
        /// call for the specified resource keys must complete before you can call the API again.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRemediationExecution service method.</param>
        /// 
        /// <returns>The response from the StartRemediationExecution service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationConfigurationException">
        /// You specified an AWS Config rule without a remediation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartRemediationExecution">REST API Reference for StartRemediationExecution Operation</seealso>
        StartRemediationExecutionResponse StartRemediationExecution(StartRemediationExecutionRequest request);



        /// <summary>
        /// Runs an on-demand remediation for the specified AWS Config rules against the last
        /// known remediation configuration. It runs an execution against the current state of
        /// your resources. Remediation execution is asynchronous.
        /// 
        ///  
        /// <para>
        /// You can specify up to 100 resource keys per request. An existing StartRemediationExecution
        /// call for the specified resource keys must complete before you can call the API again.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRemediationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRemediationExecution service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For PutConfigRule, the rule cannot be created because the IAM role assigned to AWS
        /// Config lacks permissions to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConfigRule, the AWS Lambda function cannot be invoked. Check the function ARN,
        /// and check the function's permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutOrganizationConfigRule, organization config rule cannot be created because
        /// you do not have permissions to call IAM <code>GetRole</code> action or create a service
        /// linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For PutConformancePack and PutOrganizationConformancePack, a conformance pack cannot
        /// be created becuase you do not have permissions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To call IAM <code>GetRole</code> action or create a service linked role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To read Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a rule and a stack.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationConfigurationException">
        /// You specified an AWS Config rule without a remediation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartRemediationExecution">REST API Reference for StartRemediationExecution Operation</seealso>
        Task<StartRemediationExecutionResponse> StartRemediationExecutionAsync(StartRemediationExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopConfigurationRecorder


        /// <summary>
        /// Stops recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// 
        /// <returns>The response from the StopConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        StopConfigurationRecorderResponse StopConfigurationRecorder(string configurationRecorderName);

        /// <summary>
        /// Stops recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the StopConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        StopConfigurationRecorderResponse StopConfigurationRecorder(StopConfigurationRecorderRequest request);


        /// <summary>
        /// Stops recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        Task<StopConfigurationRecorderResponse> StopConfigurationRecorderAsync(string configurationRecorderName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Stops recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopConfigurationRecorder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        Task<StopConfigurationRecorderResponse> StopConfigurationRecorderAsync(StopConfigurationRecorderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified resourceArn. If existing
        /// tags on a resource are not specified in the request parameters, they are not changed.
        /// When a resource is deleted, the tags associated with that resource are deleted as
        /// well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotFoundException">
        /// You have specified a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.TooManyTagsException">
        /// You have reached the limit of the number of tags you can use. You have more than 50
        /// tags.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates the specified tags to a resource with the specified resourceArn. If existing
        /// tags on a resource are not specified in the request parameters, they are not changed.
        /// When a resource is deleted, the tags associated with that resource are deleted as
        /// well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotFoundException">
        /// You have specified a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.TooManyTagsException">
        /// You have reached the limit of the number of tags you can use. You have more than 50
        /// tags.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotFoundException">
        /// You have specified a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotFoundException">
        /// You have specified a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}