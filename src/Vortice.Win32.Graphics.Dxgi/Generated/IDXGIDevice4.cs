// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice4"]/*' />
/// <unmanaged>IDXGIDevice4</unmanaged>
[Guid("95b4f95f-d8da-4ca4-9ee6-3b76d5968a10")]
[NativeTypeName("struct IDXGIDevice4 : IDXGIDevice3")]
[NativeInheritance("IDXGIDevice3")]
public unsafe partial struct IDXGIDevice4 : IDXGIDevice4.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIDevice4
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5F, 0xF9, 0xB4, 0x95,
				0xDA, 0xD8,
				0xA4, 0x4C,
				0x9E,
				0xE6,
				0x3B,
				0x76,
				0xD5,
				0x96,
				0x8A,
				0x10
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice4));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice4));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, uint>)(lpVtbl[1]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint>)(lpVtbl[1]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, uint>)(lpVtbl[2]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint>)(lpVtbl[2]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pUnknown);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pUnknown);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), riid, ppParent);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), riid, ppParent);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.GetAdapter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetAdapter(IDXGIAdapter** pAdapter)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pAdapter);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pAdapter);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.CreateSurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSurface(SurfaceDescription* pDesc, uint NumSurfaces, Usage Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, SurfaceDescription*, uint, Usage, SharedResource*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, SurfaceDescription*, uint, Usage, SharedResource*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.QueryResourceResidency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult QueryResourceResidency(IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, IUnknown**, Residency*, uint, int>)(lpVtbl[9]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, IUnknown**, Residency*, uint, int>)(lpVtbl[9]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.SetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetGPUThreadPriority(int Priority)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, int, int>)(lpVtbl[10]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Priority);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, int, int>)(lpVtbl[10]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), Priority);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.GetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetGPUThreadPriority(int* pPriority)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, int*, int>)(lpVtbl[11]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pPriority);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, int*, int>)(lpVtbl[11]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pPriority);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice1.SetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetMaximumFrameLatency(uint MaxLatency)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, uint, int>)(lpVtbl[12]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), MaxLatency);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, int>)(lpVtbl[12]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), MaxLatency);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice1.GetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetMaximumFrameLatency(uint* pMaxLatency)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, uint*, int>)(lpVtbl[13]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pMaxLatency);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint*, int>)(lpVtbl[13]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), pMaxLatency);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice2.OfferResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult OfferResources(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, int>)(lpVtbl[14]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, int>)(lpVtbl[14]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice2.ReclaimResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult ReclaimResources(uint NumResources, IDXGIResource** ppResources, Bool32* pDiscarded)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, uint, IDXGIResource**, Bool32*, int>)(lpVtbl[15]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pDiscarded);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, Bool32*, int>)(lpVtbl[15]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pDiscarded);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice2.EnqueueSetEvent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult EnqueueSetEvent(Handle hEvent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, Handle, int>)(lpVtbl[16]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), hEvent);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, Handle, int>)(lpVtbl[16]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), hEvent);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice3.Trim" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void Trim()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDXGIDevice4*, void>)(lpVtbl[17]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<IDXGIDevice4*, void>)(lpVtbl[17]))((IDXGIDevice4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice4::OfferResources1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult OfferResources1(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority, uint Flags)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, uint, int>)(lpVtbl[18]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority, Flags);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, uint, int>)(lpVtbl[18]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority, Flags);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice4::ReclaimResources1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult ReclaimResources1(uint NumResources, IDXGIResource** ppResources, ReclaimResourceResults* pResults)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice4*, uint, IDXGIResource**, ReclaimResourceResults*, int>)(lpVtbl[19]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pResults);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint, IDXGIResource**, ReclaimResourceResults*, int>)(lpVtbl[19]))((IDXGIDevice4*)Unsafe.AsPointer(ref this), NumResources, ppResources, pResults);
#endif
	}

	public interface Interface : IDXGIDevice3.Interface
	{
		[VtblIndex(18)]
		HResult OfferResources1(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority, uint Flags);

		[VtblIndex(19)]
		HResult ReclaimResources1(uint NumResources, IDXGIResource** ppResources, ReclaimResourceResults* pResults);
	}
}

