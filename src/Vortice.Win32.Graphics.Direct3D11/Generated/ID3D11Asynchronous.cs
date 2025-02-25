// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Asynchronous"]/*' />
/// <unmanaged>ID3D11Asynchronous</unmanaged>
[Guid("4b35d0cd-1e15-4258-9c98-1b1333f6dd3b")]
[NativeTypeName("struct ID3D11Asynchronous : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11Asynchronous : ID3D11Asynchronous.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Asynchronous
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xCD, 0xD0, 0x35, 0x4B,
				0x15, 0x1E,
				0x58, 0x42,
				0x9C,
				0x98,
				0x1B,
				0x13,
				0x33,
				0xF6,
				0xDD,
				0x3B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Asynchronous));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Asynchronous));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Asynchronous*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Asynchronous*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Asynchronous*, uint>)(lpVtbl[1]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Asynchronous*, uint>)(lpVtbl[1]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Asynchronous*, uint>)(lpVtbl[2]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Asynchronous*, uint>)(lpVtbl[2]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Asynchronous*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Asynchronous*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Asynchronous*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Asynchronous*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Asynchronous*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Asynchronous*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Asynchronous*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Asynchronous*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Asynchronous::GetDataSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public uint GetDataSize()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Asynchronous*, uint>)(lpVtbl[7]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Asynchronous*, uint>)(lpVtbl[7]))((ID3D11Asynchronous*)Unsafe.AsPointer(ref this));
#endif
	}

	public interface Interface : ID3D11DeviceChild.Interface
	{
		[VtblIndex(7)]
		uint GetDataSize();
	}
}

