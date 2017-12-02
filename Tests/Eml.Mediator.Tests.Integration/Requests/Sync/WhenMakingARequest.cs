﻿using System;
{
    public class WhenMakingARequest : UnitTestBase
    {
        [Test]
        [DotMemoryUnit(FailIfRunWithoutSupport = false)]
        public void Response_ShouldBeCorrectType()
        {
           var request = new TestRequest(Guid.NewGuid());
            
           var response = mediator.Get(request);

            response.ShouldBeOfType(typeof(TestResponse));
            dotMemory.Check(memory =>
            {
                memory.GetObjects(where => where.Type.Is<TestRequestEngine>()).ObjectsCount.ShouldBe(0);
            });
        }

        [Test]
        [DotMemoryUnit(FailIfRunWithoutSupport = false)]
        public void Response_ShouldBeCorrectValue()
        {
            var request = new TestRequest(Guid.NewGuid());

            var response = mediator.Get(request);

            response.ResponseToRequestId.ShouldBe(request.Id);
            dotMemory.Check(memory =>
            {
                memory.GetObjects(where => where.Type.Is<TestRequestEngine>()).ObjectsCount.ShouldBe(0);
            });
        }
    }
}