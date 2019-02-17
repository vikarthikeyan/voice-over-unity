/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using FullSerializer;
using System.Collections.Generic;

namespace IBM.Watson.DeveloperCloud.Services.Assistant.v1
{
    /// <summary>
    /// WorkspaceCollection.
    /// </summary>
    [fsObject]
    public class WorkspaceCollection
    {
        /// <summary>
        /// An array of objects describing the workspaces associated with the service instance.
        /// </summary>
        /// <value>An array of objects describing the workspaces associated with the service instance.</value>
        [fsProperty("workspaces")]
        public List<Workspace> Workspaces { get; set; }
        /// <summary>
        /// An object defining the pagination data for the returned objects.
        /// </summary>
        /// <value>An object defining the pagination data for the returned objects.</value>
        [fsProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

}