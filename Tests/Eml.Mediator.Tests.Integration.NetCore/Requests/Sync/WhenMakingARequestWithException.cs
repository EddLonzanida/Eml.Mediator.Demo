﻿using System;
using Shouldly;
using Xunit;

namespace Eml.Mediator.Tests.Integration.NetCore.Requests.Sync
{
    public class WhenMakingARequestWithException : IntegrationTestDiBase
    {
        [Fact]
        public void Response_ShouldThrowException()
        {
            var request = new TestRequestWithException(Guid.NewGuid());

            Should.Throw<NotImplementedException>(() => mediator.Execute(request));
        }
    }
}