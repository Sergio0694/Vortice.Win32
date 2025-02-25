// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutputDuplication"]/*' />
/// <unmanaged>IDXGIOutputDuplication</unmanaged>
[Guid("191cfac3-a341-470d-b26e-a864f428319c")]
[NativeTypeName("struct IDXGIOutputDuplication : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
public unsafe partial struct IDXGIOutputDuplication : IDXGIOutputDuplication.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIOutputDuplication
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC3, 0xFA, 0x1C, 0x19,
				0x41, 0xA3,
				0x0D, 0x47,
				0xB2,
				0x6E,
				0xA8,
				0x64,
				0xF4,
				0x28,
				0x31,
				0x9C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutputDuplication));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutputDuplication));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, uint>)(lpVtbl[1]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)(lpVtbl[1]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, uint>)(lpVtbl[2]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)(lpVtbl[2]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pUnknown);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pUnknown);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppParent);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppParent);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutputDuplication::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetDesc(OutduplDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDXGIOutputDuplication*, OutduplDescription*, void>)(lpVtbl[7]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pDesc);
#else
		((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDescription*, void>)(lpVtbl[7]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutputDuplication::AcquireNextFrame"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult AcquireNextFrame(uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, IDXGIResource** ppDesktopResource)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)(lpVtbl[8]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)(lpVtbl[8]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutputDuplication::GetFrameDirtyRects"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetFrameDirtyRects(uint DirtyRectsBufferSize, Rect* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, Rect*, uint*, int>)(lpVtbl[9]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Rect*, uint*, int>)(lpVtbl[9]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutputDuplication::GetFrameMoveRects"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFrameMoveRects(uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)(lpVtbl[10]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)(lpVtbl[10]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutputDuplication::GetFramePointerShape"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)(lpVtbl[11]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)(lpVtbl[11]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutputDuplication::MapDesktopSurface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult MapDesktopSurface(MappedRect* pLockedRect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, MappedRect*, int>)(lpVtbl[12]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pLockedRect);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, MappedRect*, int>)(lpVtbl[12]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pLockedRect);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutputDuplication::UnMapDesktopSurface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult UnMapDesktopSurface()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, int>)(lpVtbl[13]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)(lpVtbl[13]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutputDuplication::ReleaseFrame"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult ReleaseFrame()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIOutputDuplication*, int>)(lpVtbl[14]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)(lpVtbl[14]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
#endif
	}

	public interface Interface : IDXGIObject.Interface
	{
		[VtblIndex(7)]
		void GetDesc(OutduplDescription* pDesc);

		[VtblIndex(8)]
		HResult AcquireNextFrame(uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, IDXGIResource** ppDesktopResource);

		[VtblIndex(9)]
		HResult GetFrameDirtyRects(uint DirtyRectsBufferSize, Rect* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired);

		[VtblIndex(10)]
		HResult GetFrameMoveRects(uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired);

		[VtblIndex(11)]
		HResult GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo);

		[VtblIndex(12)]
		HResult MapDesktopSurface(MappedRect* pLockedRect);

		[VtblIndex(13)]
		HResult UnMapDesktopSurface();

		[VtblIndex(14)]
		HResult ReleaseFrame();
	}
}

