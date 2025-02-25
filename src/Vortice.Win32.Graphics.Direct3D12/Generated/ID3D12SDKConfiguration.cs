// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SDKConfiguration"]/*' />
/// <unmanaged>ID3D12SDKConfiguration</unmanaged>
[Guid("e9eb5314-33aa-42b2-a718-d77f58b1f1c7")]
[NativeTypeName("struct ID3D12SDKConfiguration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SDKConfiguration : ID3D12SDKConfiguration.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12SDKConfiguration
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x14, 0x53, 0xEB, 0xE9,
				0xAA, 0x33,
				0xB2, 0x42,
				0xA7,
				0x18,
				0xD7,
				0x7F,
				0x58,
				0xB1,
				0xF1,
				0xC7
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SDKConfiguration));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SDKConfiguration));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12SDKConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12SDKConfiguration*, uint>)(lpVtbl[1]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint>)(lpVtbl[1]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12SDKConfiguration*, uint>)(lpVtbl[2]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint>)(lpVtbl[2]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SDKConfiguration::SetSDKVersion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetSDKVersion(uint SDKVersion, sbyte* SDKPath)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12SDKConfiguration*, uint, sbyte*, int>)(lpVtbl[3]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this), SDKVersion, SDKPath);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint, sbyte*, int>)(lpVtbl[3]))((ID3D12SDKConfiguration*)Unsafe.AsPointer(ref this), SDKVersion, SDKPath);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult SetSDKVersion(uint SDKVersion, sbyte* SDKPath);
	}
}

