// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Provider specific input for InMageRcmFailback failover. </summary>
    public partial class InMageRcmFailbackPlannedFailoverProviderContent : PlannedFailoverProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackPlannedFailoverProviderContent"/>. </summary>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        public InMageRcmFailbackPlannedFailoverProviderContent(InMageRcmFailbackRecoveryPointType recoveryPointType)
        {
            RecoveryPointType = recoveryPointType;
            InstanceType = "InMageRcmFailback";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackPlannedFailoverProviderContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        internal InMageRcmFailbackPlannedFailoverProviderContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, InMageRcmFailbackRecoveryPointType recoveryPointType) : base(instanceType, serializedAdditionalRawData)
        {
            RecoveryPointType = recoveryPointType;
            InstanceType = instanceType ?? "InMageRcmFailback";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackPlannedFailoverProviderContent"/> for deserialization. </summary>
        internal InMageRcmFailbackPlannedFailoverProviderContent()
        {
        }

        /// <summary> The recovery point type. </summary>
        public InMageRcmFailbackRecoveryPointType RecoveryPointType { get; }
    }
}
