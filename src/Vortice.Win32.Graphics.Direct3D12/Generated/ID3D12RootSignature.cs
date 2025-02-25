// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12RootSignature"]/*' />
/// <unmanaged>ID3D12RootSignature</unmanaged>
[Guid("c54a6b66-72df-4ee8-8be5-a946a1429214")]
[NativeTypeName("struct ID3D12RootSignature : ID3D12DeviceChild")]
[NativeInheritance("ID3D12DeviceChild")]
public unsafe partial struct ID3D12RootSignature : ID3D12RootSignature.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12RootSignature
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x66, 0x6B, 0x4A, 0xC5,
				0xDF, 0x72,
				0xE8, 0x4E,
				0x8B,
				0xE5,
				0xA9,
				0x46,
				0xA1,
				0x42,
				0x92,
				0x14
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12RootSignature));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12RootSignature));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12RootSignature*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12RootSignature*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12RootSignature*, uint>)(lpVtbl[1]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12RootSignature*, uint>)(lpVtbl[1]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12RootSignature*, uint>)(lpVtbl[2]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12RootSignature*, uint>)(lpVtbl[2]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12RootSignature*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12RootSignature*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12RootSignature*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12RootSignature*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12RootSignature*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12RootSignature*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12RootSignature*, ushort*, int>)(lpVtbl[6]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), Name);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12RootSignature*, ushort*, int>)(lpVtbl[6]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), Name);
#endif
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12RootSignature*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), riid, ppvDevice);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12RootSignature*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12RootSignature*)Unsafe.AsPointer(ref this), riid, ppvDevice);
#endif
	}

	public interface Interface : ID3D12DeviceChild.Interface
	{
	}
}

