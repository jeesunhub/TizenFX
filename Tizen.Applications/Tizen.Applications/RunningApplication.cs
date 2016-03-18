/// Copyright 2016 by Samsung Electronics, Inc.,
///
/// This software is the confidential and proprietary information
/// of Samsung Electronics, Inc. ("Confidential Information"). You
/// shall not disclose such Confidential Information and shall use
/// it only in accordance with the terms of the license agreement
/// you entered into with Samsung.

using System;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Tizen.Applications
{
    /// <summary>
    /// RunningApplication class. This class has the properties of RunningApplication.
    /// </summary>
    public class RunningApplication
    {
        private string _applicationId;
        private int _processId;

        internal RunningApplication(string applicationId, int processId)
        {
            _applicationId = applicationId;
            _processId = processId;
        }

        /// <summary>
        /// ApplicationId property.
        /// </summary>
        /// <returns>string application id.</returns>
        public string ApplicationId
        {
            get
            {
                return _applicationId;
            }
        }

        /// <summary>
        /// ProcessId property.
        /// </summary>
        /// <returns>string process id.</returns>
        public int ProcessId
        {
            get
            {
                return _processId;
            }
        }
    }
}
