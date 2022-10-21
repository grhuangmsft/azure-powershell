// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Represents Activity entity query.</summary>
    public partial class ActivityEntityQueryTemplate :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplate,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryTemplate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryTemplate __entityQueryTemplate = new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.EntityQueryTemplate();

        /// <summary>The entity query content to display in timeline</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).Content; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).Content = value ?? null; }

        /// <summary>List of required data types for the given entity query template</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataTypeDefinitions[] DataType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).DataType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).DataType = value ?? null /* arrayOf */; }

        /// <summary>The entity query description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).Description = value ?? null; }

        /// <summary>The query applied only to entities matching to all filters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesEntitiesFilter EntitiesFilter { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).EntitiesFilter; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).EntitiesFilter = value ?? null /* model class */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).Id; }

        /// <summary>The type of the query's source entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType? InputEntityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).InputEntityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).InputEntityType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType)""); }

        /// <summary>the entity query template kind</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryTemplateInternal)__entityQueryTemplate).Kind; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplateProperties Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ActivityEntityQueryTemplateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for QueryDefinition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesQueryDefinitions Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplateInternal.QueryDefinition { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).QueryDefinition; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).QueryDefinition = value; }

        /// <summary>Internal Acessors for Kind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryTemplateInternal.Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryTemplateInternal)__entityQueryTemplate).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryTemplateInternal)__entityQueryTemplate).Kind = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplateProperties _property;

        /// <summary>Activity entity query properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.ActivityEntityQueryTemplateProperties()); set => this._property = value; }

        /// <summary>The Activity query to run on a given entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string QueryDefinitionQuery { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).QueryDefinitionQuery; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).QueryDefinitionQuery = value ?? null; }

        /// <summary>
        /// The dimensions we want to summarize the timeline results on, this is comma separated list
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string QueryDefinitionSummarizeBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).QueryDefinitionSummarizeBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).QueryDefinitionSummarizeBy = value ?? null; }

        /// <summary>List of the fields of the source entity that are required to run the query</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string[][] RequiredInputFieldsSet { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).RequiredInputFieldsSet; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).RequiredInputFieldsSet = value ?? null /* arrayOf */; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.CreatedByType)""); }

        /// <summary>The entity query title</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).Title; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesInternal)Property).Title = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api30.IResourceInternal)__entityQueryTemplate).Type; }

        /// <summary>Creates an new <see cref="ActivityEntityQueryTemplate" /> instance.</summary>
        public ActivityEntityQueryTemplate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__entityQueryTemplate), __entityQueryTemplate);
            await eventListener.AssertObjectIsValid(nameof(__entityQueryTemplate), __entityQueryTemplate);
        }
    }
    /// Represents Activity entity query.
    public partial interface IActivityEntityQueryTemplate :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryTemplate
    {
        /// <summary>The entity query content to display in timeline</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The entity query content to display in timeline",
        SerializedName = @"content",
        PossibleTypes = new [] { typeof(string) })]
        string Content { get; set; }
        /// <summary>List of required data types for the given entity query template</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of required data types for the given entity query template",
        SerializedName = @"dataTypes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataTypeDefinitions) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataTypeDefinitions[] DataType { get; set; }
        /// <summary>The entity query description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The entity query description",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The query applied only to entities matching to all filters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The query applied only to entities matching to all filters",
        SerializedName = @"entitiesFilter",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesEntitiesFilter) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesEntitiesFilter EntitiesFilter { get; set; }
        /// <summary>The type of the query's source entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the query's source entity",
        SerializedName = @"inputEntityType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType? InputEntityType { get; set; }
        /// <summary>The Activity query to run on a given entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Activity query to run on a given entity",
        SerializedName = @"query",
        PossibleTypes = new [] { typeof(string) })]
        string QueryDefinitionQuery { get; set; }
        /// <summary>
        /// The dimensions we want to summarize the timeline results on, this is comma separated list
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The dimensions we want to summarize the timeline results on, this is comma separated list",
        SerializedName = @"summarizeBy",
        PossibleTypes = new [] { typeof(string) })]
        string QueryDefinitionSummarizeBy { get; set; }
        /// <summary>List of the fields of the source entity that are required to run the query</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the fields of the source entity that are required to run the query",
        SerializedName = @"requiredInputFieldsSets",
        PossibleTypes = new [] { typeof(string) })]
        string[][] RequiredInputFieldsSet { get; set; }
        /// <summary>The entity query title</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The entity query title",
        SerializedName = @"title",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get; set; }

    }
    /// Represents Activity entity query.
    internal partial interface IActivityEntityQueryTemplateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IEntityQueryTemplateInternal
    {
        /// <summary>The entity query content to display in timeline</summary>
        string Content { get; set; }
        /// <summary>List of required data types for the given entity query template</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataTypeDefinitions[] DataType { get; set; }
        /// <summary>The entity query description</summary>
        string Description { get; set; }
        /// <summary>The query applied only to entities matching to all filters</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesEntitiesFilter EntitiesFilter { get; set; }
        /// <summary>The type of the query's source entity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityType? InputEntityType { get; set; }
        /// <summary>Activity entity query properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplateProperties Property { get; set; }
        /// <summary>The Activity query definitions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesQueryDefinitions QueryDefinition { get; set; }
        /// <summary>The Activity query to run on a given entity</summary>
        string QueryDefinitionQuery { get; set; }
        /// <summary>
        /// The dimensions we want to summarize the timeline results on, this is comma separated list
        /// </summary>
        string QueryDefinitionSummarizeBy { get; set; }
        /// <summary>List of the fields of the source entity that are required to run the query</summary>
        string[][] RequiredInputFieldsSet { get; set; }
        /// <summary>The entity query title</summary>
        string Title { get; set; }

    }
}