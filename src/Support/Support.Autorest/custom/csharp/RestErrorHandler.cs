﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Management.Automation;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.PowerShell.Cmdlets.Support.Models;

namespace Microsoft.Azure.PowerShell.Cmdlets.Support.Cmdlets
{
    internal static class CmdletRestExtension
    {
        public static void WriteError(this Cmdlet cmdlet, HttpResponseMessage responseMessage, Task<IErrorResponse> errorResponseTask, ref Task<bool> returnNow)
        {
            var errorDetailsString = responseMessage.Content.ReadAsStringAsync().Result;

            cmdlet.WriteError(new ErrorRecord(new System.Exception(), null, ErrorCategory.InvalidOperation, null)
            {
                ErrorDetails = new ErrorDetails(errorDetailsString) { RecommendedAction = string.Empty }
            });

            returnNow = Task.FromResult(true);
            //var errorResponse = errorResponseTask?.ConfigureAwait(false).GetAwaiter().GetResult();

            //if (errorResponse?.Detail != null && errorResponse?.Detail.Count > 0)
            //{
            //    //var errorDetails = errorResponse.Detail;
            //    //var errorDetailsString = "";

            //    //foreach (var errorDetail in errorDetails)
            //    //{
            //    //    errorDetailsString += errorDetail.Message + " ";
            //    //}
            //    var errorDetailsString = responseMessage.Content.ReadAsStringAsync().Result;

            //    cmdlet.WriteError(new ErrorRecord(new System.Exception(), null, ErrorCategory.InvalidOperation, null)
            //    {
            //        ErrorDetails = new ErrorDetails(errorDetailsString) { RecommendedAction = string.Empty }
            //    });

            //    returnNow = Task.FromResult(true);
            //}
            //else
            //{
            //    returnNow = Task.FromResult(false);
            //}
        }
    }
}