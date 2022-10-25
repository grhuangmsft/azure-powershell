// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>operator used to compare currentSpend with amount</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertOperatorTypeConverter))]
    public partial struct AlertOperator :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "None".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'None'", "None", global::System.Management.Automation.CompletionResultType.ParameterValue, "None");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "EqualTo".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'EqualTo'", "EqualTo", global::System.Management.Automation.CompletionResultType.ParameterValue, "EqualTo");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "GreaterThan".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'GreaterThan'", "GreaterThan", global::System.Management.Automation.CompletionResultType.ParameterValue, "GreaterThan");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "GreaterThanOrEqualTo".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'GreaterThanOrEqualTo'", "GreaterThanOrEqualTo", global::System.Management.Automation.CompletionResultType.ParameterValue, "GreaterThanOrEqualTo");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LessThan".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'LessThan'", "LessThan", global::System.Management.Automation.CompletionResultType.ParameterValue, "LessThan");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "LessThanOrEqualTo".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'LessThanOrEqualTo'", "LessThanOrEqualTo", global::System.Management.Automation.CompletionResultType.ParameterValue, "LessThanOrEqualTo");
            }
        }
    }
}