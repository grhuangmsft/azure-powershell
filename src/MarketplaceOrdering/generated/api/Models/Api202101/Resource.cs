// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Models.Api202101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Runtime.Extensions;

    /// <summary>ARM resource.</summary>
    public partial class Resource :
        Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Models.Api202101.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Models.Api202101.IResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Origin(Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Models.Api202101.IResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Models.Api202101.IResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Models.Api202101.IResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Origin(Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Origin(Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {

        }
    }
    /// ARM resource.
    public partial interface IResource :
        Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Runtime.IJsonSerializable
    {
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MarketplaceOrdering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// ARM resource.
    internal partial interface IResourceInternal

    {
        /// <summary>Resource ID.</summary>
        string Id { get; set; }
        /// <summary>Resource name.</summary>
        string Name { get; set; }
        /// <summary>Resource type.</summary>
        string Type { get; set; }

    }
}