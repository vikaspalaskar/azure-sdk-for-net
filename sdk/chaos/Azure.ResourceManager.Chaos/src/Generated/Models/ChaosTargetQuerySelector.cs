// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a query selector. </summary>
    public partial class ChaosTargetQuerySelector : ChaosTargetSelector
    {
        /// <summary> Initializes a new instance of <see cref="ChaosTargetQuerySelector"/>. </summary>
        /// <param name="id"> String of the selector ID. </param>
        /// <param name="queryString"> Azure Resource Graph (ARG) Query Language query for target resources. </param>
        /// <param name="subscriptionIds"> Subscription id list to scope resource query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="queryString"/> or <paramref name="subscriptionIds"/> is null. </exception>
        public ChaosTargetQuerySelector(string id, string queryString, IEnumerable<string> subscriptionIds) : base(id)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(queryString, nameof(queryString));
            Argument.AssertNotNull(subscriptionIds, nameof(subscriptionIds));

            QueryString = queryString;
            SubscriptionIds = subscriptionIds.ToList();
            SelectorType = SelectorType.Query;
        }

        /// <summary> Initializes a new instance of <see cref="ChaosTargetQuerySelector"/>. </summary>
        /// <param name="selectorType"> Enum of the selector type. </param>
        /// <param name="id"> String of the selector ID. </param>
        /// <param name="filter">
        /// Model that represents available filter types that can be applied to a targets list.
        /// Please note <see cref="ChaosTargetFilter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChaosTargetSimpleFilter"/>.
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryString"> Azure Resource Graph (ARG) Query Language query for target resources. </param>
        /// <param name="subscriptionIds"> Subscription id list to scope resource query. </param>
        internal ChaosTargetQuerySelector(SelectorType selectorType, string id, ChaosTargetFilter filter, IDictionary<string, BinaryData> additionalProperties, string queryString, IList<string> subscriptionIds) : base(selectorType, id, filter, additionalProperties)
        {
            QueryString = queryString;
            SubscriptionIds = subscriptionIds;
            SelectorType = selectorType;
        }

        /// <summary> Initializes a new instance of <see cref="ChaosTargetQuerySelector"/> for deserialization. </summary>
        internal ChaosTargetQuerySelector()
        {
        }

        /// <summary> Azure Resource Graph (ARG) Query Language query for target resources. </summary>
        public string QueryString { get; set; }
        /// <summary> Subscription id list to scope resource query. </summary>
        public IList<string> SubscriptionIds { get; }
    }
}
