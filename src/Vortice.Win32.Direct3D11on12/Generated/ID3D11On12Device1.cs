// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11on12;

/// <include file='../../Direct3D11on12.xml' path='doc/member[@name="ID3D11On12Device1"]/*' />
/// <unmanaged>ID3D11On12Device1</unmanaged>
[Guid("bdb64df4-ea2f-4c70-b861-aaab1258bb5d")]
[NativeTypeName("struct ID3D11On12Device1 : ID3D11On12Device")]
[NativeInheritance("ID3D11On12Device")]
public unsafe partial struct ID3D11On12Device1
{
	public static ref readonly Guid IID_ID3D11On12Device1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF4, 0x4D, 0xB6, 0xBD,
				0x2F, 0xEA,
				0x70, 0x4C,
				0xB8,
				0x61,
				0xAA,
				0xAB,
				0x12,
				0x58,
				0xBB,
				0x5D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11On12Device1));

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

	/// <inheritdoc cref="ID3D11On12Device.CreateWrappedResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateWrappedResource(IUnknown* pResource12, ResourceFlags* pFlags11, Graphics.Direct3D12.ResourceStates InState, Graphics.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, IUnknown*, ResourceFlags*, Graphics.Direct3D12.ResourceStates, Graphics.Direct3D12.ResourceStates, Guid*, void**, int>)(lpVtbl[3]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), pResource12, pFlags11, InState, OutState, riid, ppResource11);
	}

	/// <inheritdoc cref="ID3D11On12Device.ReleaseWrappedResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void ReleaseWrappedResources(Graphics.Direct3D11.ID3D11Resource** ppResources, uint NumResources)
	{
		((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Graphics.Direct3D11.ID3D11Resource**, uint, void>)(lpVtbl[4]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
	}

	/// <inheritdoc cref="ID3D11On12Device.AcquireWrappedResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void AcquireWrappedResources(Graphics.Direct3D11.ID3D11Resource** ppResources, uint NumResources)
	{
		((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Graphics.Direct3D11.ID3D11Resource**, uint, void>)(lpVtbl[5]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), ppResources, NumResources);
	}

	/// <include file='../../Direct3D11on12.xml' path='doc/member[@name="ID3D11On12Device1::GetD3D12Device"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetD3D12Device(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)(lpVtbl[6]))((ID3D11On12Device1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}
}

