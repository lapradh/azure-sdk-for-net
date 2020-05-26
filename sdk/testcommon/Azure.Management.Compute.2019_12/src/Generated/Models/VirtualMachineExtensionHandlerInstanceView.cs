// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> The instance view of a virtual machine extension handler. </summary>
    public partial class VirtualMachineExtensionHandlerInstanceView
    {
        /// <summary> Initializes a new instance of VirtualMachineExtensionHandlerInstanceView. </summary>
        public VirtualMachineExtensionHandlerInstanceView()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionHandlerInstanceView. </summary>
        /// <param name="type"> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="status"> The extension handler status. </param>
        internal VirtualMachineExtensionHandlerInstanceView(string type, string typeHandlerVersion, InstanceViewStatus status)
        {
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            Status = status;
        }

        /// <summary> Specifies the type of the extension; an example is &quot;CustomScriptExtension&quot;. </summary>
        public string Type { get; set; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; set; }
        /// <summary> The extension handler status. </summary>
        public InstanceViewStatus Status { get; set; }
    }
}
