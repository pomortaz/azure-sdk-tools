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

namespace Microsoft.WindowsAzure.Utilities.HttpRecorder
{
    /// <summary>
    /// Enum that holds possible modes for the http recorder.
    /// </summary>
    public enum HttpRecorderMode
    {
        /// <summary>
        /// In this mode the mock server watches the out-going requests and records
        /// their corresponding responses.
        /// </summary>
        Record,

        /// <summary>
        /// The playback mode should always be after a successfull record session.
        /// The mock server matches the given requests and return their stored 
        /// corresponding responses.
        /// </summary>
        Playback,

        /// <summary>
        /// The mock server does not do anything.
        /// </summary>
        None
    }
}
