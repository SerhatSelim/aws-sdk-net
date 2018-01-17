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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AutoScalingPlans.Model;

namespace Amazon.AutoScalingPlans
{
    /// <summary>
    /// Interface for accessing AutoScalingPlans
    ///
    /// 
    /// </summary>
    public partial interface IAmazonAutoScalingPlans : IAmazonService, IDisposable
    {

        
        #region  CreateScalingPlan


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScalingPlan service method.</param>
        /// 
        /// <returns>The response from the CreateScalingPlan service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ConcurrentUpdateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/CreateScalingPlan">REST API Reference for CreateScalingPlan Operation</seealso>
        CreateScalingPlanResponse CreateScalingPlan(CreateScalingPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScalingPlan operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScalingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/CreateScalingPlan">REST API Reference for CreateScalingPlan Operation</seealso>
        IAsyncResult BeginCreateScalingPlan(CreateScalingPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScalingPlan.</param>
        /// 
        /// <returns>Returns a  CreateScalingPlanResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/CreateScalingPlan">REST API Reference for CreateScalingPlan Operation</seealso>
        CreateScalingPlanResponse EndCreateScalingPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteScalingPlan


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteScalingPlan service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ConcurrentUpdateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ObjectNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DeleteScalingPlan">REST API Reference for DeleteScalingPlan Operation</seealso>
        DeleteScalingPlanResponse DeleteScalingPlan(DeleteScalingPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPlan operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScalingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DeleteScalingPlan">REST API Reference for DeleteScalingPlan Operation</seealso>
        IAsyncResult BeginDeleteScalingPlan(DeleteScalingPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScalingPlan.</param>
        /// 
        /// <returns>Returns a  DeleteScalingPlanResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DeleteScalingPlan">REST API Reference for DeleteScalingPlan Operation</seealso>
        DeleteScalingPlanResponse EndDeleteScalingPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeScalingPlanResources


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlanResources service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingPlanResources service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ConcurrentUpdateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InvalidNextTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlanResources">REST API Reference for DescribeScalingPlanResources Operation</seealso>
        DescribeScalingPlanResourcesResponse DescribeScalingPlanResources(DescribeScalingPlanResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPlanResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlanResources operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingPlanResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlanResources">REST API Reference for DescribeScalingPlanResources Operation</seealso>
        IAsyncResult BeginDescribeScalingPlanResources(DescribeScalingPlanResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingPlanResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingPlanResources.</param>
        /// 
        /// <returns>Returns a  DescribeScalingPlanResourcesResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlanResources">REST API Reference for DescribeScalingPlanResources Operation</seealso>
        DescribeScalingPlanResourcesResponse EndDescribeScalingPlanResources(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeScalingPlans


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlans service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingPlans service method, as returned by AutoScalingPlans.</returns>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ConcurrentUpdateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.InvalidNextTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.AutoScalingPlans.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlans">REST API Reference for DescribeScalingPlans Operation</seealso>
        DescribeScalingPlansResponse DescribeScalingPlans(DescribeScalingPlansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlans operation on AmazonAutoScalingPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlans">REST API Reference for DescribeScalingPlans Operation</seealso>
        IAsyncResult BeginDescribeScalingPlans(DescribeScalingPlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingPlans.</param>
        /// 
        /// <returns>Returns a  DescribeScalingPlansResult from AutoScalingPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlans">REST API Reference for DescribeScalingPlans Operation</seealso>
        DescribeScalingPlansResponse EndDescribeScalingPlans(IAsyncResult asyncResult);

        #endregion
        
    }
}