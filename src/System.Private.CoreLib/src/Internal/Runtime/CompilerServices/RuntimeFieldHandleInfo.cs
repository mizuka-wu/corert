// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace Internal.Runtime.CompilerServices
{
    [StructLayout(LayoutKind.Sequential)]
    [CLSCompliant(false)]
    public unsafe struct RuntimeFieldHandleInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible")]
        public IntPtr NativeLayoutInfoSignature;
    }
}
