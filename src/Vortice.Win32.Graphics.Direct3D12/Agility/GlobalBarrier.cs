// Copyright � Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_GLOBAL_BARRIER</unmanaged>
public unsafe partial struct GlobalBarrier
{
    public BarrierSync SyncBefore;
    public BarrierSync SyncAfter;
    public BarrierAccess AccessBefore;
    public BarrierAccess AccessAfter;
}
