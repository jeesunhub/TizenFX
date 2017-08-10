/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Multimedia
{
    /// <summary>
    /// An extended EventArgs class which contains details about current state
    /// of the camera when interrupt is invoked internally in Native FW.
    /// </summary>
    public class CameraInterruptStartedEventArgs : EventArgs
    {
        internal CameraInterruptStartedEventArgs(CameraPolicy policy, CameraState state)
        {
            Policy = policy;
            State = state;
        }

        /// <summary>
        /// Current state of the camera.
        /// </summary>
        public CameraState State { get; }

        /// <summary>
        /// The policy that interrupted the camera.
        /// </summary>
        public CameraPolicy Policy { get; }
    }
}
