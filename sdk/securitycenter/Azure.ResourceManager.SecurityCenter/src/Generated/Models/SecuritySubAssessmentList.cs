// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of security sub-assessments. </summary>
    internal partial class SecuritySubAssessmentList
    {
        /// <summary> Initializes a new instance of SecuritySubAssessmentList. </summary>
        internal SecuritySubAssessmentList()
        {
            Value = new ChangeTrackingList<SecuritySubAssessmentData>();
        }

        /// <summary> Initializes a new instance of SecuritySubAssessmentList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal SecuritySubAssessmentList(IReadOnlyList<SecuritySubAssessmentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<SecuritySubAssessmentData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
