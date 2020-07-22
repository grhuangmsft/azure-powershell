namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api202001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Extensions;

    public partial class ConnectedClusterAadProfile
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject into a new instance of <see cref="ConnectedClusterAadProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ConnectedClusterAadProfile(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_clientAppId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("clientAppId"), out var __jsonClientAppId) ? (string)__jsonClientAppId : (string)ClientAppId;}
            {_serverAppId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("serverAppId"), out var __jsonServerAppId) ? (string)__jsonServerAppId : (string)ServerAppId;}
            {_tenantId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("tenantId"), out var __jsonTenantId) ? (string)__jsonTenantId : (string)TenantId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api202001Preview.IConnectedClusterAadProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api202001Preview.IConnectedClusterAadProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api202001Preview.IConnectedClusterAadProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject json ? new ConnectedClusterAadProfile(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ConnectedClusterAadProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ConnectedClusterAadProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._clientAppId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._clientAppId.ToString()) : null, "clientAppId" ,container.Add );
            AddIf( null != (((object)this._serverAppId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._serverAppId.ToString()) : null, "serverAppId" ,container.Add );
            AddIf( null != (((object)this._tenantId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._tenantId.ToString()) : null, "tenantId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}