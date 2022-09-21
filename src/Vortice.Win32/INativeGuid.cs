﻿// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32;

public interface INativeGuid
{
#if NET6_0_OR_GREATER
    protected unsafe internal static Guid* NativeGuid { get; }
#endif
}
