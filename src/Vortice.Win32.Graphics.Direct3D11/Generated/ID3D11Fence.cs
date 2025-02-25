// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Fence"]/*' />
/// <unmanaged>ID3D11Fence</unmanaged>
[Guid("affde9d1-1df7-4bb7-8a34-0f46251dab80")]
[NativeTypeName("struct ID3D11Fence : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11Fence : ID3D11Fence.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Fence
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD1, 0xE9, 0xFD, 0xAF,
				0xF7, 0x1D,
				0xB7, 0x4B,
				0x8A,
				0x34,
				0x0F,
				0x46,
				0x25,
				0x1D,
				0xAB,
				0x80
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Fence));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Fence));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Fence*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Fence*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Fence*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Fence*, uint>)(lpVtbl[1]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Fence*, uint>)(lpVtbl[1]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Fence*, uint>)(lpVtbl[2]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Fence*, uint>)(lpVtbl[2]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Fence*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Fence*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Fence*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Fence*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Fence*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Fence*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Fence*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Fence*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Fence::CreateSharedHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateSharedHandle(Security.SECURITY_ATTRIBUTES* pAttributes, uint dwAccess, ushort* lpName, Handle* pHandle)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Fence*, Security.SECURITY_ATTRIBUTES*, uint, ushort*, Handle*, int>)(lpVtbl[7]))((ID3D11Fence*)Unsafe.AsPointer(ref this), pAttributes, dwAccess, lpName, pHandle);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Fence*, Security.SECURITY_ATTRIBUTES*, uint, ushort*, Handle*, int>)(lpVtbl[7]))((ID3D11Fence*)Unsafe.AsPointer(ref this), pAttributes, dwAccess, lpName, pHandle);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Fence::GetCompletedValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public ulong GetCompletedValue()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Fence*, ulong>)(lpVtbl[8]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ulong>)(lpVtbl[8]))((ID3D11Fence*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Fence::SetEventOnCompletion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetEventOnCompletion(ulong Value, Handle hEvent)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Fence*, ulong, Handle, int>)(lpVtbl[9]))((ID3D11Fence*)Unsafe.AsPointer(ref this), Value, hEvent);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Fence*, ulong, Handle, int>)(lpVtbl[9]))((ID3D11Fence*)Unsafe.AsPointer(ref this), Value, hEvent);
#endif
	}

	public interface Interface : ID3D11DeviceChild.Interface
	{
		[VtblIndex(7)]
		HResult CreateSharedHandle(Security.SECURITY_ATTRIBUTES* pAttributes, uint dwAccess, ushort* lpName, Handle* pHandle);

		[VtblIndex(8)]
		ulong GetCompletedValue();

		[VtblIndex(9)]
		HResult SetEventOnCompletion(ulong Value, Handle hEvent);
	}
}

