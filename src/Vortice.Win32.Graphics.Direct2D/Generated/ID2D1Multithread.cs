// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Multithread"]/*' />
/// <unmanaged>ID2D1Multithread</unmanaged>
[Guid("31e6e7bc-e0ff-4d46-8c64-a0a8c41c15d3")]
[NativeTypeName("struct ID2D1Multithread : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1Multithread : ID2D1Multithread.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1Multithread
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xBC, 0xE7, 0xE6, 0x31,
				0xFF, 0xE0,
				0x46, 0x4D,
				0x8C,
				0x64,
				0xA0,
				0xA8,
				0xC4,
				0x1C,
				0x15,
				0xD3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Multithread));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Multithread));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Multithread*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Multithread*, uint>)(lpVtbl[1]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, uint>)(lpVtbl[1]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Multithread*, uint>)(lpVtbl[2]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, uint>)(lpVtbl[2]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Multithread::GetMultithreadProtected"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public Bool32 GetMultithreadProtected()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Multithread*, Bool32>)(lpVtbl[3]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, Bool32>)(lpVtbl[3]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Multithread::Enter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void Enter()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1Multithread*, void>)(lpVtbl[4]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<ID2D1Multithread*, void>)(lpVtbl[4]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Multithread::Leave"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void Leave()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1Multithread*, void>)(lpVtbl[5]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<ID2D1Multithread*, void>)(lpVtbl[5]))((ID2D1Multithread*)Unsafe.AsPointer(ref this));
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		Bool32 GetMultithreadProtected();

		[VtblIndex(4)]
		void Enter();

		[VtblIndex(5)]
		void Leave();
	}
}

