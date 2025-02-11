﻿// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32;

[Guid("00000000-0000-0000-C000-000000000046")]
public unsafe partial struct IUnknown : IUnknown.Interface, INativeGuid
{
    public static ref readonly Guid IID_IUnknown
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00,
                0x00, 0x00,
                0xC0,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x46
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

#if NET6_0_OR_GREATER
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUnknown));
#else
    public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUnknown));
#endif

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface(Guid* riid, void** ppvObject)
    {
#if NET6_0_OR_GREATER
        return ((delegate* unmanaged<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
        return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public uint AddRef()
    {
#if NET6_0_OR_GREATER
        return ((delegate* unmanaged<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
#else
        return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
#endif
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public uint Release()
    {
#if NET6_0_OR_GREATER
        return ((delegate* unmanaged<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
#else
        return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
#endif
    }

    public interface Interface : INativeGuid
    {
        [VtblIndex(0)]
        HResult QueryInterface(Guid* riid, void** ppvObject);

        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        uint AddRef();

        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        uint Release();
    }
}
