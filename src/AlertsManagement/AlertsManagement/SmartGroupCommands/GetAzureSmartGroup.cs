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

using System.Linq;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Rest.Azure;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Commands.AlertsManagement.OutputModels;
using Microsoft.Azure.Management.AlertsManagement.Models;

namespace Microsoft.Azure.Commands.AlertsManagement
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SmartGroup", DefaultParameterSetName = SmartGroupsListByFilterParameterSet)]
    [OutputType(typeof(PSSmartGroup))]
    public class GetAzureSmartGroup : AlertsManagementBaseCmdlet
    {
        #region Parameter Set Names

        private const string SmartGroupsListByFilterParameterSet = "SmartGroupsListByFilter";
        private const string SmartGroupByIdParameterSet = "SmartGroupById";

        #endregion

        #region Parameters declarations
        /// <summary>
        /// SmartGroup Id
        /// </summary>
        [Parameter(Mandatory = true,
                   ParameterSetName = SmartGroupByIdParameterSet,
                   HelpMessage = "Unique Identifier of SmartGroup / ResourceId of SmartGroup.")]
        [ValidateNotNullOrEmpty]
        [Alias("ResourceId")]
        public string SmartGroupId { get; set; }

        /// <summary>
        /// Smart group property to use while sorting
        /// </summary>
        [Parameter(Mandatory = false,
                   ParameterSetName = SmartGroupsListByFilterParameterSet,
                   HelpMessage = "Alert property to use while sorting")]
        [PSArgumentCompleter("name", "severity", "alertState", "monitorCondition", "targetResource", "targetResourceName", "targetResourceGroup", "targetResourceType", "startDateTime", "lastModifiedDateTime")]
        public string SortBy { get; set; }

        /// <summary>
        /// Sort Order
        /// </summary>
        [Parameter(Mandatory = false,
                   ParameterSetName = SmartGroupsListByFilterParameterSet,
                   HelpMessage = "Sort Order")]
        [PSArgumentCompleter("desc", "asc")]
        public string SortOrder { get; set; }

        /// <summary>
        /// Time range
        /// </summary>
        [Parameter(Mandatory = false,
                   ParameterSetName = SmartGroupsListByFilterParameterSet,
                   HelpMessage = "Supported time range values – 1h, 1d, 7d, 30d (Default is 1d)")]
        [PSArgumentCompleter("1h", "1d", "7d", "30d")]
        public string TimeRange { get; set; }

        #endregion

        protected override void ProcessRecordInternal()
        {
            switch (ParameterSetName)
            {
                case SmartGroupsListByFilterParameterSet:
                    var smartGroupsList = this.AlertsManagementClient.SmartGroups.GetAllWithHttpMessagesAsync(
                        sortBy: SortBy,
                        sortOrder: SortOrder,
                        timeRange: TimeRange
                        ).Result.Body;

                    // Deal with paging in response
                    var resultList = smartGroupsList.ToList();
                    var nextPageLink = smartGroupsList.NextPageLink;
                    while (!string.IsNullOrEmpty(nextPageLink))
                    {
                        var pageResult = this.AlertsManagementClient.SmartGroups.GetAllNextWithHttpMessagesAsync(nextPageLink);
                        foreach (var pageItem in pageResult.Result.Body)
                        {
                            resultList.Add(pageItem);
                        }
                        nextPageLink = pageResult.Result.Body.NextPageLink;
                    }

                    WriteObject(resultList.Select((r) => new PSSmartGroup(r)), enumerateCollection: true);
                    break;

                case SmartGroupByIdParameterSet:
                    string id = CommonUtils.GetIdFromARMResourceId(SmartGroupId);
                    PSSmartGroup smartGroup = new PSSmartGroup(this.AlertsManagementClient.SmartGroups.GetByIdWithHttpMessagesAsync(id).Result.Body);
                    WriteObject(sendToPipeline: smartGroup);
                    break;
            }
        }
    }
}
