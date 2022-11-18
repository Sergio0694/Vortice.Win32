// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2"]/*' />
/// <unmanaged>IDXGIFactory2</unmanaged>
[Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0")]
[NativeTypeName("struct IDXGIFactory2 : IDXGIFactory1")]
[NativeInheritance("IDXGIFactory1")]
public unsafe partial struct IDXGIFactory2 : INativeGuid
{
	public static ref readonly Guid IID_IDXGIFactory2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x1C, 0x3A, 0xC8, 0x50,
				0x72, 0xE0,
				0x48, 0x4C,
				0x87,
				0xB0,
				0x36,
				0x30,
				0xFA,
				0x36,
				0xA6,
				0xD0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIFactory.EnumAdapters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
	}

	/// <inheritdoc cref="IDXGIFactory.MakeWindowAssociation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult MakeWindowAssociation(IntPtr WindowHandle, WindowAssociationFlags Flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, IntPtr, WindowAssociationFlags, int>)(lpVtbl[8]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
	}

	/// <inheritdoc cref="IDXGIFactory.GetWindowAssociation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetWindowAssociation(IntPtr* pWindowHandle)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, IntPtr*, int>)(lpVtbl[9]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), pWindowHandle);
	}

	/// <inheritdoc cref="IDXGIFactory.CreateSwapChain" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateSwapChain(IUnknown* pDevice, SwapChainDescription* pDesc, IDXGISwapChain** ppSwapChain)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, IUnknown*, SwapChainDescription*, IDXGISwapChain**, int>)(lpVtbl[10]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
	}

	/// <inheritdoc cref="IDXGIFactory.CreateSoftwareAdapter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateSoftwareAdapter(IntPtr Module, IDXGIAdapter** ppAdapter)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, IntPtr, IDXGIAdapter**, int>)(lpVtbl[11]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), Module, ppAdapter);
	}

	/// <inheritdoc cref="IDXGIFactory1.EnumAdapters1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, IDXGIAdapter1**, int>)(lpVtbl[12]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
	}

	/// <inheritdoc cref="IDXGIFactory1.IsCurrent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public Bool32 IsCurrent()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Bool32>)(lpVtbl[13]))((IDXGIFactory2*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::IsWindowedStereoEnabled"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public Bool32 IsWindowedStereoEnabled()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Bool32>)(lpVtbl[14]))((IDXGIFactory2*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::CreateSwapChainForHwnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateSwapChainForHwnd(IUnknown* pDevice, IntPtr hWnd, SwapChainDescription1* pDesc, SwapChainFullscreenDescription* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, IUnknown*, IntPtr, SwapChainDescription1*, SwapChainFullscreenDescription*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[15]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::CreateSwapChainForCoreWindow"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateSwapChainForCoreWindow(IUnknown* pDevice, IUnknown* pWindow, SwapChainDescription1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, IUnknown*, IUnknown*, SwapChainDescription1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[16]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::GetSharedResourceAdapterLuid"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetSharedResourceAdapterLuid(Handle hResource, Luid* pLuid)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Handle, Luid*, int>)(lpVtbl[17]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), hResource, pLuid);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::RegisterStereoStatusWindow"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult RegisterStereoStatusWindow(IntPtr WindowHandle, uint wMsg, uint* pdwCookie)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, IntPtr, uint, uint*, int>)(lpVtbl[18]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::RegisterStereoStatusEvent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult RegisterStereoStatusEvent(Handle hEvent, uint* pdwCookie)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Handle, uint*, int>)(lpVtbl[19]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::UnregisterStereoStatus"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void UnregisterStereoStatus(uint dwCookie)
	{
		((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, void>)(lpVtbl[20]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), dwCookie);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::RegisterOcclusionStatusWindow"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult RegisterOcclusionStatusWindow(IntPtr WindowHandle, uint wMsg, uint* pdwCookie)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, IntPtr, uint, uint*, int>)(lpVtbl[21]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::RegisterOcclusionStatusEvent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult RegisterOcclusionStatusEvent(Handle hEvent, uint* pdwCookie)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, Handle, uint*, int>)(lpVtbl[22]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::UnregisterOcclusionStatus"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public void UnregisterOcclusionStatus(uint dwCookie)
	{
		((delegate* unmanaged[Stdcall]<IDXGIFactory2*, uint, void>)(lpVtbl[23]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), dwCookie);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory2::CreateSwapChainForComposition"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateSwapChainForComposition(IUnknown* pDevice, SwapChainDescription1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIFactory2*, IUnknown*, SwapChainDescription1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[24]))((IDXGIFactory2*)Unsafe.AsPointer(ref this), pDevice, pDesc, pRestrictToOutput, ppSwapChain);
	}
}

