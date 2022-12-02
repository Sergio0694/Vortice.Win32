// Copyright � Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Com;

namespace Win32.Graphics.Imaging;

public unsafe partial struct IWICStream
{
    /// <inheritdoc cref="ISequentialStream.Read" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)(lpVtbl[3]))((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <inheritdoc cref="ISequentialStream.Write" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)(lpVtbl[4]))((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    /// <inheritdoc cref="IStream.Seek" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult Seek(LargeInteger dlibMove, uint dwOrigin, ULargeInteger* plibNewPosition)
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, LargeInteger, uint, ULargeInteger*, int>)(lpVtbl[5]))((IWICStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    /// <inheritdoc cref="IStream.SetSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult SetSize(ULargeInteger libNewSize)
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, ULargeInteger, int>)(lpVtbl[6]))((IWICStream*)Unsafe.AsPointer(ref this), libNewSize);
    }

    /// <inheritdoc cref="IStream.CopyTo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult CopyTo(IStream* pstm, ULargeInteger cb, ULargeInteger* pcbRead, ULargeInteger* pcbWritten)
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, IStream*, ULargeInteger, ULargeInteger*, ULargeInteger*, int>)(lpVtbl[7]))((IWICStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
    }

    /// <inheritdoc cref="IStream.Commit" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, uint, int>)(lpVtbl[8]))((IWICStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    /// <inheritdoc cref="IStream.Revert" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult Revert()
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, int>)(lpVtbl[9]))((IWICStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IStream.LockRegion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult LockRegion(ULargeInteger libOffset, ULargeInteger cb, uint dwLockType)
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, ULargeInteger, ULargeInteger, uint, int>)(lpVtbl[10]))((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref="IStream.UnlockRegion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult UnlockRegion(ULargeInteger libOffset, ULargeInteger cb, uint dwLockType)
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, ULargeInteger, ULargeInteger, uint, int>)(lpVtbl[11]))((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    ///// <inheritdoc cref="IStream.Stat" />
    //[MethodImpl(MethodImplOptions.AggressiveInlining)]
    //[VtblIndex(12)]
    //public HResult Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    //{
    //    return ((delegate* unmanaged[Stdcall]<IWICStream*, STATSTG*, uint, int>)(lpVtbl[12]))((IWICStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
    //}

    /// <inheritdoc cref="IStream.Clone" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult Clone(IStream** ppstm)
    {
        return ((delegate* unmanaged[Stdcall]<IWICStream*, IStream**, int>)(lpVtbl[13]))((IWICStream*)Unsafe.AsPointer(ref this), ppstm);
    }
}

