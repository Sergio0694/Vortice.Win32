// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandQueue"]/*' />
/// <unmanaged>ID3D12DebugCommandQueue</unmanaged>
[Guid("09e0bf36-54ac-484f-8847-4baeeab6053a")]
[NativeTypeName("struct ID3D12DebugCommandQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugCommandQueue : ID3D12DebugCommandQueue.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12DebugCommandQueue
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x36, 0xBF, 0xE0, 0x09,
				0xAC, 0x54,
				0x4F, 0x48,
				0x88,
				0x47,
				0x4B,
				0xAE,
				0xEA,
				0xB6,
				0x05,
				0x3A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandQueue));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandQueue));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandQueue*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandQueue*, uint>)(lpVtbl[1]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue*, uint>)(lpVtbl[1]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandQueue*, uint>)(lpVtbl[2]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue*, uint>)(lpVtbl[2]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandQueue::AssertResourceState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public Bool32 AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandQueue*, ID3D12Resource*, uint, uint, Bool32>)(lpVtbl[3]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandQueue*, ID3D12Resource*, uint, uint, Bool32>)(lpVtbl[3]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		Bool32 AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State);
	}
}

