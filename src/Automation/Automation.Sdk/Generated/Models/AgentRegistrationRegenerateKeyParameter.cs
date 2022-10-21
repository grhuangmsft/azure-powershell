// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the regenerate keys operation.
    /// </summary>
    public partial class AgentRegistrationRegenerateKeyParameter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AgentRegistrationRegenerateKeyParameter class.
        /// </summary>
        public AgentRegistrationRegenerateKeyParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AgentRegistrationRegenerateKeyParameter class.
        /// </summary>
        /// <param name="keyName">Gets or sets the agent registration key name
        /// - primary or secondary. Possible values include: 'primary',
        /// 'secondary'</param>
        public AgentRegistrationRegenerateKeyParameter(string keyName)
        {
            KeyName = keyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the agent registration key name - primary or
        /// secondary. Possible values include: 'primary', 'secondary'
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyName");
            }
        }
    }
}
