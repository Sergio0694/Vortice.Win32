// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice2"]/*' />
/// <unmanaged>IDXGIDevice2</unmanaged>
[Guid("05008617-fbfd-4051-a790-144884b4f6a9")]
[NativeTypeName("struct IDXGIDevice2 : IDXGIDevice1")]
[NativeInheritance("IDXGIDevice1")]
public unsafe partial struct IDXGIDevice2 : INativeGuid
{
	public static ref readonly Guid IID_IDXGIDevice2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x17, 0x86, 0x00, 0x05,
				0xFD, 0xFB,
				0x51, 0x40,
				0xA7,
				0x90,
				0x14,
				0x48,
				0x84,
				0xB4,
				0xF6,
				0xA9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice2));
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
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDevice.GetAdapter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetAdapter(IDXGIAdapter** pAdapter)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), pAdapter);
	}

	/// <inheritdoc cref="IDXGIDevice.CreateSurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSurface(SurfaceDescription* pDesc, uint NumSurfaces, Usage Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, SurfaceDescription*, uint, Usage, SharedResource*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
	}

	/// <inheritdoc cref="IDXGIDevice.QueryResourceResidency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult QueryResourceResidency(IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, IUnknown**, Residency*, uint, int>)(lpVtbl[9]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
	}

	/// <inheritdoc cref="IDXGIDevice.SetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetGPUThreadPriority(int Priority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, int, int>)(lpVtbl[10]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), Priority);
	}

	/// <inheritdoc cref="IDXGIDevice.GetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetGPUThreadPriority(int* pPriority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, int*, int>)(lpVtbl[11]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), pPriority);
	}

	/// <inheritdoc cref="IDXGIDevice1.SetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetMaximumFrameLatency(uint MaxLatency)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, int>)(lpVtbl[12]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), MaxLatency);
	}

	/// <inheritdoc cref="IDXGIDevice1.GetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetMaximumFrameLatency(uint* pMaxLatency)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint*, int>)(lpVtbl[13]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), pMaxLatency);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice2::OfferResources"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult OfferResources(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, IDXGIResource**, OfferResourcePriority, int>)(lpVtbl[14]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice2::ReclaimResources"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult ReclaimResources(uint NumResources, IDXGIResource** ppResources, Bool32* pDiscarded)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, uint, IDXGIResource**, Bool32*, int>)(lpVtbl[15]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), NumResources, ppResources, pDiscarded);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice2::EnqueueSetEvent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult EnqueueSetEvent(Handle hEvent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice2*, Handle, int>)(lpVtbl[16]))((IDXGIDevice2*)Unsafe.AsPointer(ref this), hEvent);
	}
}

