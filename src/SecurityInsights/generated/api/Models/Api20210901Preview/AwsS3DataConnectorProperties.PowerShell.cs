// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.PowerShell;

    /// <summary>Amazon Web Services S3 data connector properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(AwsS3DataConnectorPropertiesTypeConverter))]
    public partial class AwsS3DataConnectorProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AwsS3DataConnectorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AwsS3DataConnectorProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DataType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorDataTypes) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DataType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AwsS3DataConnectorDataTypesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DestinationTable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DestinationTable = (string) content.GetValueForProperty("DestinationTable",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DestinationTable, global::System.Convert.ToString);
            }
            if (content.Contains("SqsUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).SqsUrl = (string[]) content.GetValueForProperty("SqsUrl",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).SqsUrl, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RoleArn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).RoleArn = (string) content.GetValueForProperty("RoleArn",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).RoleArn, global::System.Convert.ToString);
            }
            if (content.Contains("DataTypeLog"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DataTypeLog = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon) content.GetValueForProperty("DataTypeLog",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DataTypeLog, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorDataTypeCommonTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).LogState = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState) content.GetValueForProperty("LogState",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).LogState, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AwsS3DataConnectorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AwsS3DataConnectorProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DataType = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorDataTypes) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DataType, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AwsS3DataConnectorDataTypesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DestinationTable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DestinationTable = (string) content.GetValueForProperty("DestinationTable",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DestinationTable, global::System.Convert.ToString);
            }
            if (content.Contains("SqsUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).SqsUrl = (string[]) content.GetValueForProperty("SqsUrl",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).SqsUrl, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RoleArn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).RoleArn = (string) content.GetValueForProperty("RoleArn",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).RoleArn, global::System.Convert.ToString);
            }
            if (content.Contains("DataTypeLog"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DataTypeLog = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon) content.GetValueForProperty("DataTypeLog",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).DataTypeLog, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorDataTypeCommonTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).LogState = (Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState) content.GetValueForProperty("LogState",((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorPropertiesInternal)this).LogState, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AwsS3DataConnectorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AwsS3DataConnectorProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.AwsS3DataConnectorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AwsS3DataConnectorProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AwsS3DataConnectorProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AwsS3DataConnectorProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAwsS3DataConnectorProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Amazon Web Services S3 data connector properties.
    [System.ComponentModel.TypeConverter(typeof(AwsS3DataConnectorPropertiesTypeConverter))]
    public partial interface IAwsS3DataConnectorProperties

    {

    }
}