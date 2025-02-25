// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Texture2D1"]/*' />
/// <unmanaged>ID3D11Texture2D1</unmanaged>
[Guid("51218251-1e33-4617-9ccb-4d3a4367e7bb")]
[NativeTypeName("struct ID3D11Texture2D1 : ID3D11Texture2D")]
[NativeInheritance("ID3D11Texture2D")]
public unsafe partial struct ID3D11Texture2D1 : ID3D11Texture2D1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Texture2D1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x51, 0x82, 0x21, 0x51,
				0x33, 0x1E,
				0x17, 0x46,
				0x9C,
				0xCB,
				0x4D,
				0x3A,
				0x43,
				0x67,
				0xE7,
				0xBB
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Texture2D1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Texture2D1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Texture2D1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Texture2D1*, uint>)(lpVtbl[1]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint>)(lpVtbl[1]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Texture2D1*, uint>)(lpVtbl[2]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint>)(lpVtbl[2]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Texture2D1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), ppDevice);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), ppDevice);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Texture2D1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Texture2D1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Texture2D1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, pData);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, pData);
#endif
	}

	/// <inheritdoc cref="ID3D11Resource.GetType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetType(ResourceDimension* pResourceDimension)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Texture2D1*, ResourceDimension*, void>)(lpVtbl[7]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pResourceDimension);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, ResourceDimension*, void>)(lpVtbl[7]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pResourceDimension);
#endif
	}

	/// <inheritdoc cref="ID3D11Resource.SetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void SetEvictionPriority(uint EvictionPriority)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Texture2D1*, uint, void>)(lpVtbl[8]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), EvictionPriority);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint, void>)(lpVtbl[8]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), EvictionPriority);
#endif
	}

	/// <inheritdoc cref="ID3D11Resource.GetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public uint GetEvictionPriority()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D11Texture2D1*, uint>)(lpVtbl[9]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, uint>)(lpVtbl[9]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D11Texture2D.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void GetDesc(Texture2DDescription* pDesc)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Texture2D1*, Texture2DDescription*, void>)(lpVtbl[10]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pDesc);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Texture2DDescription*, void>)(lpVtbl[10]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Texture2D1::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetDesc1(Texture2DDescription1* pDesc)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D11Texture2D1*, Texture2DDescription1*, void>)(lpVtbl[11]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pDesc);
#else
		((delegate* unmanaged[Stdcall]<ID3D11Texture2D1*, Texture2DDescription1*, void>)(lpVtbl[11]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pDesc);
#endif
	}

	public interface Interface : ID3D11Texture2D.Interface
	{
		[VtblIndex(11)]
		void GetDesc1(Texture2DDescription1* pDesc);
	}
}

