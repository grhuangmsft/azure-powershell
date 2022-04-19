//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsLifecycle.Invoke, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VMRunCommand", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSRunCommandResult))]
    public partial class InvokeAzureRmVMRunCommand : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.VMName, VerbsLifecycle.Invoke))
                {
                    string resourceGroupName;
                    string vmName;
                    switch (this.ParameterSetName)
                    {
                        case "ResourceIdParameter":
                            resourceGroupName = GetResourceGroupName(this.ResourceId);
                            vmName = GetResourceName(this.ResourceId, "Microsoft.Compute/virtualMachines");
                            break;
                        case "VMParameter":
                            resourceGroupName = GetResourceGroupName(this.VM.Id);
                            vmName = GetResourceName(this.VM.Id, "Microsoft.Compute/virtualMachines");
                            break;
                        default:
                            resourceGroupName = this.ResourceGroupName;
                            vmName = this.VMName;
                            break;
                    }
                    RunCommandInput parameters = new RunCommandInput();
                    parameters.CommandId = this.CommandId;
                    if (this.ScriptPath != null)
                    {
                        parameters.Script = new List<string>();
                        PathIntrinsics currentPath = SessionState.Path;
                        var filePath = new System.IO.FileInfo(currentPath.GetUnresolvedProviderPathFromPSPath(this.ScriptPath));
                        string fileContent = Commands.Common.Authentication.Abstractions.FileUtilities.DataStore.ReadFileAsText(filePath.FullName);
                        List<string> commandstext = fileContent.Split(new string[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        System.Text.Encoding fileencoding = Commands.Common.Authentication.Abstractions.FileUtilities.GetFileEncoding(filePath.FullName);

                        if (this.ScriptEncoding != null || !fileencoding.Equals(System.Text.Encoding.UTF8))
                        {
                            foreach (var cmd in commandstext)
                            {
                                try
                                {
                                    byte[] cmdBytes = fileencoding.GetBytes(cmd);
                                }
                                catch (System.Text.EncoderFallbackException e)
                                {
                                    WriteError(new ErrorRecord(new Exception(e.Message), "Error", ErrorCategory.NotSpecified, null));
                                    return;
                                }
                                byte[] cmdBytesUTF8 = System.Text.Encoding.Convert(fileencoding, System.Text.Encoding.UTF8, fileencoding.GetBytes(cmd));
                                parameters.Script.Add(System.Text.Encoding.UTF8.GetString(cmdBytesUTF8));
                            }
                        }
                        else
                        {
                            parameters.Script = commandstext;
                        }
                    }
                    else if(this.ScriptString != null)
                    {
                        parameters.Script = new List<string>() { this.ScriptString };
                    }
                    if (this.Parameter != null)
                    {
                        var vParameter = new List<RunCommandInputParameter>();
                        foreach (var key in this.Parameter.Keys)
                        {
                            RunCommandInputParameter p = new RunCommandInputParameter();
                            p.Name = key.ToString();
                            p.Value = this.Parameter[key].ToString();
                            vParameter.Add(p);
                        }
                        parameters.Parameters = vParameter;
                    }

                    var result = VirtualMachinesClient.RunCommand(resourceGroupName, vmName, parameters);
                    var psObject = new PSRunCommandResult();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<RunCommandResult, PSRunCommandResult>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceNameCompleter("Microsoft.Compute/virtualMachines", "ResourceGroupName")]
        [Alias("Name")]
        public string VMName { get; set; }

        [Parameter(
            Mandatory = true)]
        [AllowNull]
        public string CommandId { get; set; }

        [Parameter(
            Mandatory = false)]
        [AllowNull]
        public string ScriptPath { get; set; }

        [Parameter(
            Mandatory = false)]
        public string ScriptEncoding { get; set; }

        [Parameter(
            Mandatory = false)]
        public string ScriptString {get; set; }

        [Parameter(
            Mandatory = false)]
        [AllowNull]
        public Hashtable Parameter { get; set; }

        [Parameter(
            ParameterSetName = "ResourceIdParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        public string ResourceId { get; set; }

        [Alias("VMProfile")]
        [Parameter(
            ParameterSetName = "VMParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public Compute.Models.PSVirtualMachine VM { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }
    }
}
