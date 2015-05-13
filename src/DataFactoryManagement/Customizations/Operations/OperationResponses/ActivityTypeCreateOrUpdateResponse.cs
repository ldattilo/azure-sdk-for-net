﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.Management.DataFactories.Registration.Models
{
#if ADF_INTERNAL
    public class ActivityTypeCreateOrUpdateResponse : AzureOperationResponse
    {
        /// <summary>
        /// Optional. The ActivityType instance.
        /// </summary>
        public ActivityType ActivityType { get; set; }

        /// <summary>
        /// Optional. Status of the operation.
        /// </summary>
        public OperationStatus Status { get; set; }

        internal ActivityTypeCreateOrUpdateResponse(
            InternalActivityTypeCreateOrUpdateResponse internalResponse,
            DataFactoryManagementClient client)
        {
            DataFactoryUtilities.CopyRuntimeProperties(internalResponse, this);
            this.ActivityType = client.ActivityTypes.Converter.ToWrapperType(internalResponse.ActivityType);
            this.Status = internalResponse.Status;
        }
    }
#endif
}
