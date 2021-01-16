﻿using System;
using Shouldly;
using Xunit;

namespace Eml.Mediator.Tests.Integration.NetCore.Requests.Sync
{
    public class WhenMakingARequestWithMultipleEngine : IntegrationTestDiBase
    {
        [Fact]
        public void Response_ShouldThrowMultipleEngineException()
        {
            var request = new TestRequestWithMultipleEngine(Guid.NewGuid());

            Should.Throw<MultipleEngineException>(() => mediator.Execute(request));
        }
    }
}