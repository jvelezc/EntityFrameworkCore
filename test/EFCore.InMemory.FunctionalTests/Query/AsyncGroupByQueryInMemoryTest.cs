// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Microsoft.EntityFrameworkCore.TestUtilities.Xunit;
using Xunit.Abstractions;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class AsyncGroupByQueryInMemoryTest : AsyncGroupByQueryTestBase<NorthwindQueryInMemoryFixture<NoopModelCustomizer>>
    {
        // ReSharper disable once UnusedParameter.Local
        public AsyncGroupByQueryInMemoryTest(NorthwindQueryInMemoryFixture<NoopModelCustomizer> fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
            //TestLoggerFactory.TestOutputHelper = testOutputHelper;
        }

        [ConditionalFact(Skip = "See issue#9869")]
        public override Task GroupBy_with_aggregate_through_navigation_property()
        {
            return base.GroupBy_with_aggregate_through_navigation_property();
        }

        [ConditionalFact(Skip = "See issue#9591")]
        public override Task Select_Distinct_GroupBy()
        {
            return base.Select_Distinct_GroupBy();
        }
    }
}
