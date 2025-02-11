// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ComputeShader"]/*' />
/// <unmanaged>ID3D11ComputeShader</unmanaged>
[Guid("4f5b196e-c2bd-495e-bd01-1fded38e4969")]
[NativeTypeName("struct ID3D11ComputeShader : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11ComputeShader : ID3D11ComputeShader.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11ComputeShader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x6E, 0x19, 0x5B, 0x4F,
				0xBD, 0xC2,
				0x5E, 0x49,
				0xBD,
				0x01,
				0x1F,
				0xDE,
				0xD3,
				0x8E,
				0x49,
				0x69
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ComputeShader));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ComputeShader));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ComputeShader*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ComputeShader*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ComputeShader*, uint>)(lpVtbl[1]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ComputeShader*, uint>)(lpVtbl[1]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ComputeShader*, uint>)(lpVtbl[2]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ComputeShader*, uint>)(lpVtbl[2]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11ComputeShader*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11ComputeShader*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ComputeShader*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ComputeShader*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ComputeShader*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ComputeShader*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11ComputeShader*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11ComputeShader*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ComputeShader*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	public interface Interface : ID3D11DeviceChild.Interface
	{
	}
}

