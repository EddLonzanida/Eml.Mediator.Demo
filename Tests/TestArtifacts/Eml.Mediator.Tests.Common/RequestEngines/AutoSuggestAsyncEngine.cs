﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Eml.Mediator.Contracts;
using Eml.Mediator.Tests.Common.Requests;
using Eml.Mediator.Tests.Common.Responses;

namespace Eml.Mediator.Tests.Common.RequestEngines
{
    public class AutoSuggestAsyncEngine<T> : IRequestAsyncEngine<AutoSuggestAsyncRequest<T>, AutoSuggestResponse<T>>
    {
        public async Task<AutoSuggestResponse<T>> ExecuteAsync(AutoSuggestAsyncRequest<T> request)
        {
            return await Task.FromResult(new AutoSuggestResponse<T>(new List<T>()));
        }
    }
}
