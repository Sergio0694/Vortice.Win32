// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract"]/*' />
/// <unmanaged>ID3D12SharingContract</unmanaged>
[Guid("0adf7d52-929c-4e61-addb-ffed30de66ef")]
[NativeTypeName("struct ID3D12SharingContract : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SharingContract : ID3D12SharingContract.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12SharingContract
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x52, 0x7D, 0xDF, 0x0A,
				0x9C, 0x92,
				0x61, 0x4E,
				0xAD,
				0xDB,
				0xFF,
				0xED,
				0x30,
				0xDE,
				0x66,
				0xEF
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SharingContract));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SharingContract));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12SharingContract*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12SharingContract*, uint>)(lpVtbl[1]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)(lpVtbl[1]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12SharingContract*, uint>)(lpVtbl[2]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, uint>)(lpVtbl[2]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract::Present"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void Present(ID3D12Resource* pResource, uint Subresource, nint window)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)(lpVtbl[3]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pResource, Subresource, window);
#else
		((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Resource*, uint, nint, void>)(lpVtbl[3]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pResource, Subresource, window);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract::SharedFenceSignal"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SharedFenceSignal(ID3D12Fence* pFence, ulong FenceValue)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)(lpVtbl[4]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pFence, FenceValue);
#else
		((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)(lpVtbl[4]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pFence, FenceValue);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract::BeginCapturableWork"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void BeginCapturableWork(Guid* guid)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12SharingContract*, Guid*, void>)(lpVtbl[5]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
#else
		((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)(lpVtbl[5]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract::EndCapturableWork"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void EndCapturableWork(Guid* guid)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12SharingContract*, Guid*, void>)(lpVtbl[6]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
#else
		((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)(lpVtbl[6]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		void Present(ID3D12Resource* pResource, uint Subresource, nint window);

		[VtblIndex(4)]
		void SharedFenceSignal(ID3D12Fence* pFence, ulong FenceValue);

		[VtblIndex(5)]
		void BeginCapturableWork(Guid* guid);

		[VtblIndex(6)]
		void EndCapturableWork(Guid* guid);
	}
}

