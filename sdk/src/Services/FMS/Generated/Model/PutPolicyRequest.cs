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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the PutPolicy operation.
    /// Creates an AWS Firewall Manager policy.
    /// 
    ///  
    /// <para>
    /// Firewall Manager provides the following types of policies: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A Shield Advanced policy, which applies Shield Advanced protection to specified accounts
    /// and resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An AWS WAF policy, which contains a rule group and defines which resources are to
    /// be protected by that rule group
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A security group policy, which manages VPC security groups across your AWS organization.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each policy is specific to one of the three types. If you want to enforce more than
    /// one policy type across accounts, you can create multiple policies. You can create
    /// multiple policies for each type.
    /// </para>
    ///  
    /// <para>
    /// You must be subscribed to Shield Advanced to create a Shield Advanced policy. For
    /// more information about subscribing to Shield Advanced, see <a href="https://docs.aws.amazon.com/waf/latest/DDOSAPIReference/API_CreateSubscription.html">CreateSubscription</a>.
    /// </para>
    /// </summary>
    public partial class PutPolicyRequest : AmazonFMSRequest
    {
        private Policy _policy;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The details of the AWS Firewall Manager policy to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Policy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}