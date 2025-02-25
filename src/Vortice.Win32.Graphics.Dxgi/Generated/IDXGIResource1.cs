// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIResource1"]/*' />
/// <unmanaged>IDXGIResource1</unmanaged>
[Guid("30961379-4609-4a41-998e-54fe567ee0c1")]
[NativeTypeName("struct IDXGIResource1 : IDXGIResource")]
[NativeInheritance("IDXGIResource")]
public unsafe partial struct IDXGIResource1 : IDXGIResource1.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIResource1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x79, 0x13, 0x96, 0x30,
				0x09, 0x46,
				0x41, 0x4A,
				0x99,
				0x8E,
				0x54,
				0xFE,
				0x56,
				0x7E,
				0xE0,
				0xC1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIResource1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIResource1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, uint>)(lpVtbl[1]))((IDXGIResource1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint>)(lpVtbl[1]))((IDXGIResource1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, uint>)(lpVtbl[2]))((IDXGIResource1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint>)(lpVtbl[2]))((IDXGIResource1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, pUnknown);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, pUnknown);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIResource1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppParent);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppParent);
#endif
	}

	/// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppDevice)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)(lpVtbl[7]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppDevice);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)(lpVtbl[7]))((IDXGIResource1*)Unsafe.AsPointer(ref this), riid, ppDevice);
#endif
	}

	/// <inheritdoc cref="IDXGIResource.GetSharedHandle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetSharedHandle(Handle* pSharedHandle)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, Handle*, int>)(lpVtbl[8]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pSharedHandle);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Handle*, int>)(lpVtbl[8]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pSharedHandle);
#endif
	}

	/// <inheritdoc cref="IDXGIResource.GetUsage" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetUsage(Usage* pUsage)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, Usage*, int>)(lpVtbl[9]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pUsage);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Usage*, int>)(lpVtbl[9]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pUsage);
#endif
	}

	/// <inheritdoc cref="IDXGIResource.SetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetEvictionPriority(ResourcePriority EvictionPriority)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, ResourcePriority, int>)(lpVtbl[10]))((IDXGIResource1*)Unsafe.AsPointer(ref this), EvictionPriority);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, ResourcePriority, int>)(lpVtbl[10]))((IDXGIResource1*)Unsafe.AsPointer(ref this), EvictionPriority);
#endif
	}

	/// <inheritdoc cref="IDXGIResource.GetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetEvictionPriority(uint* pEvictionPriority)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, uint*, int>)(lpVtbl[11]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pEvictionPriority);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint*, int>)(lpVtbl[11]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pEvictionPriority);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIResource1::CreateSubresourceSurface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateSubresourceSurface(uint index, IDXGISurface2** ppSurface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, uint, IDXGISurface2**, int>)(lpVtbl[12]))((IDXGIResource1*)Unsafe.AsPointer(ref this), index, ppSurface);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint, IDXGISurface2**, int>)(lpVtbl[12]))((IDXGIResource1*)Unsafe.AsPointer(ref this), index, ppSurface);
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIResource1::CreateSharedHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateSharedHandle(Security.SECURITY_ATTRIBUTES* pAttributes, uint dwAccess, ushort* lpName, Handle* pHandle)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIResource1*, Security.SECURITY_ATTRIBUTES*, uint, ushort*, Handle*, int>)(lpVtbl[13]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pAttributes, dwAccess, lpName, pHandle);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Security.SECURITY_ATTRIBUTES*, uint, ushort*, Handle*, int>)(lpVtbl[13]))((IDXGIResource1*)Unsafe.AsPointer(ref this), pAttributes, dwAccess, lpName, pHandle);
#endif
	}

	public interface Interface : IDXGIResource.Interface
	{
		[VtblIndex(12)]
		HResult CreateSubresourceSurface(uint index, IDXGISurface2** ppSurface);

		[VtblIndex(13)]
		HResult CreateSharedHandle(Security.SECURITY_ATTRIBUTES* pAttributes, uint dwAccess, ushort* lpName, Handle* pHandle);
	}
}

