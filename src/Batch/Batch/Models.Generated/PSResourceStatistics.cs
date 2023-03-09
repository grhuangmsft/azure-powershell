﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.17
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSResourceStatistics
    {
        
        internal Microsoft.Azure.Batch.ResourceStatistics omObject;
        
        internal PSResourceStatistics(Microsoft.Azure.Batch.ResourceStatistics omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public double AverageCpuPercentage
        {
            get
            {
                return this.omObject.AverageCpuPercentage;
            }
        }
        
        public double AverageDiskGiB
        {
            get
            {
                return this.omObject.AverageDiskGiB;
            }
        }
        
        public double AverageMemoryGiB
        {
            get
            {
                return this.omObject.AverageMemoryGiB;
            }
        }
        
        public double DiskReadGiB
        {
            get
            {
                return this.omObject.DiskReadGiB;
            }
        }
        
        public long DiskReadIOps
        {
            get
            {
                return this.omObject.DiskReadIOps;
            }
        }
        
        public double DiskWriteGiB
        {
            get
            {
                return this.omObject.DiskWriteGiB;
            }
        }
        
        public long DiskWriteIOps
        {
            get
            {
                return this.omObject.DiskWriteIOps;
            }
        }
        
        public System.DateTime LastUpdateTime
        {
            get
            {
                return this.omObject.LastUpdateTime;
            }
        }
        
        public double NetworkReadGiB
        {
            get
            {
                return this.omObject.NetworkReadGiB;
            }
        }
        
        public double NetworkWriteGiB
        {
            get
            {
                return this.omObject.NetworkWriteGiB;
            }
        }
        
        public double PeakDiskGiB
        {
            get
            {
                return this.omObject.PeakDiskGiB;
            }
        }
        
        public double PeakMemoryGiB
        {
            get
            {
                return this.omObject.PeakMemoryGiB;
            }
        }
        
        public System.DateTime StartTime
        {
            get
            {
                return this.omObject.StartTime;
            }
        }
    }
}
