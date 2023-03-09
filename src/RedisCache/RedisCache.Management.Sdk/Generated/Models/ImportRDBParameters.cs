// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RedisCache.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for Redis import operation.
    /// </summary>
    public partial class ImportRDBParameters
    {
        /// <summary>
        /// Initializes a new instance of the ImportRDBParameters class.
        /// </summary>
        public ImportRDBParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportRDBParameters class.
        /// </summary>
        /// <param name="files">files to import.</param>
        /// <param name="format">File format.</param>
        /// <param name="preferredDataArchiveAuthMethod">Preferred auth method
        /// to communicate to storage account used for data archive, specify
        /// SAS or ManagedIdentity, default value is SAS</param>
        public ImportRDBParameters(IList<string> files, string format = default(string), string preferredDataArchiveAuthMethod = default(string))
        {
            Format = format;
            Files = files;
            PreferredDataArchiveAuthMethod = preferredDataArchiveAuthMethod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets file format.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets files to import.
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<string> Files { get; set; }

        /// <summary>
        /// Gets or sets preferred auth method to communicate to storage
        /// account used for data archive, specify SAS or ManagedIdentity,
        /// default value is SAS
        /// </summary>
        [JsonProperty(PropertyName = "preferred-data-archive-auth-method")]
        public string PreferredDataArchiveAuthMethod { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Files == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Files");
            }
        }
    }
}
