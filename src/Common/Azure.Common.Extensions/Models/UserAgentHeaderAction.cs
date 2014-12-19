﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Common;
using System.Net.Http.Headers;

namespace Microsoft.Azure.Common.Extensions.Models
{
    public class UserAgentHeaderAction : IClientAction
    {
        private ProductInfoHeaderValue agentHeaderValue;

        public IClientFactory ClientFactory { get; set; }

        public UserAgentHeaderAction(ProductInfoHeaderValue agentHeaderValue)
        {
            this.agentHeaderValue = agentHeaderValue;
        }

        public void Apply<TClient>(TClient client, AzureContext context, AzureEnvironment.Endpoint endpoint) where TClient : ServiceClient<TClient>
        {
            client.UserAgent.Add(agentHeaderValue);
        }

    }
}
