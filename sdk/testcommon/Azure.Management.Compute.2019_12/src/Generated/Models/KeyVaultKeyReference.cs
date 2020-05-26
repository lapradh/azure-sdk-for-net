// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes a reference to Key Vault Key. </summary>
    public partial class KeyVaultKeyReference
    {
        /// <summary> Initializes a new instance of KeyVaultKeyReference. </summary>
        /// <param name="keyUrl"> The URL referencing a key encryption key in Key Vault. </param>
        /// <param name="sourceVault"> The relative URL of the Key Vault containing the key. </param>
        public KeyVaultKeyReference(string keyUrl, SubResource sourceVault)
        {
            if (keyUrl == null)
            {
                throw new ArgumentNullException(nameof(keyUrl));
            }
            if (sourceVault == null)
            {
                throw new ArgumentNullException(nameof(sourceVault));
            }

            KeyUrl = keyUrl;
            SourceVault = sourceVault;
        }

        /// <summary> The URL referencing a key encryption key in Key Vault. </summary>
        public string KeyUrl { get; set; }
        /// <summary> The relative URL of the Key Vault containing the key. </summary>
        public SubResource SourceVault { get; set; }
    }
}
