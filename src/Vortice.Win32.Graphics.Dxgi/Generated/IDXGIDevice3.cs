// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice3"]/*' />
/// <unmanaged>IDXGIDevice3</unmanaged>
[Guid("6007896c-3244-4afd-bf18-a6d3beda5023")]
[NativeTypeName("struct IDXGIDevice3 : IDXGIDevice2")]
[NativeInheritance("IDXGIDevice2")]
public unsafe partial struct IDXGIDevice3 : IDXGIDevice3.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIDevice3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x6C, 0x89, 0x07, 0x60,
				0x44, 0x32,
				0xFD, 0x4A,
				0xBF,
				0x18,
				0xA6,
				0xD3,
				0xBE,
				0xDA,
				0x50,
				0x23
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice3));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, uint>)(lpVtbl[1]))((IDXGIDevice3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint>)(lpVtbl[1]))((IDXGIDevice3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, uint>)(lpVtbl[2]))((IDXGIDevice3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint>)(lpVtbl[2]))((IDXGIDevice3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), Name, pUnknown);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), Name, pUnknown);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), riid, ppParent);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), riid, ppParent);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.GetAdapter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetAdapter(IDXGIAdapter** pAdapter)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), pAdapter);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), pAdapter);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.CreateSurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSurface(SurfaceDescription* pDesc, uint NumSurfaces, Usage Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, SurfaceDescription*, uint, Usage, SharedResource*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, SurfaceDescription*, uint, Usage, SharedResource*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.QueryResourceResidency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult QueryResourceResidency(IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, IUnknown**, Residency*, uint, int>)(lpVtbl[9]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, IUnknown**, Residency*, uint, int>)(lpVtbl[9]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.SetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetGPUThreadPriority(int Priority)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, int, int>)(lpVtbl[10]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), Priority);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, int, int>)(lpVtbl[10]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), Priority);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice.GetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetGPUThreadPriority(int* pPriority)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, int*, int>)(lpVtbl[11]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), pPriority);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, int*, int>)(lpVtbl[11]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), pPriority);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice1.SetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetMaximumFrameLatency(uint MaxLatency)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, uint, int>)(lpVtbl[12]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), MaxLatency);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, int>)(lpVtbl[12]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), MaxLatency);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice1.GetMaximumFrameLatency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetMaximumFrameLatency(uint* pMaxLatency)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, uint*, int>)(lpVtbl[13]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), pMaxLatency);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint*, int>)(lpVtbl[13]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), pMaxLatency);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice2.OfferResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult OfferResources(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, uint, IDXGIResource**, OfferResourcePriority, int>)(lpVtbl[14]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, IDXGIResource**, OfferResourcePriority, int>)(lpVtbl[14]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), NumResources, ppResources, Priority);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice2.ReclaimResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult ReclaimResources(uint NumResources, IDXGIResource** ppResources, Bool32* pDiscarded)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, uint, IDXGIResource**, Bool32*, int>)(lpVtbl[15]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), NumResources, ppResources, pDiscarded);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, uint, IDXGIResource**, Bool32*, int>)(lpVtbl[15]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), NumResources, ppResources, pDiscarded);
#endif
	}

	/// <inheritdoc cref="IDXGIDevice2.EnqueueSetEvent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult EnqueueSetEvent(Handle hEvent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDevice3*, Handle, int>)(lpVtbl[16]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), hEvent);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice3*, Handle, int>)(lpVtbl[16]))((IDXGIDevice3*)Unsafe.AsPointer(ref this), hEvent);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice3::Trim"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void Trim()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDXGIDevice3*, void>)(lpVtbl[17]))((IDXGIDevice3*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<IDXGIDevice3*, void>)(lpVtbl[17]))((IDXGIDevice3*)Unsafe.AsPointer(ref this));
#endif
	}

	public interface Interface : IDXGIDevice2.Interface
	{
		[VtblIndex(17)]
		void Trim();
	}
}

