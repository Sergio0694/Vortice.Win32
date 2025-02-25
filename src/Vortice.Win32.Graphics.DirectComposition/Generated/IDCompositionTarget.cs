// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTarget"]/*' />
/// <unmanaged>IDCompositionTarget</unmanaged>
[Guid("eacdd04c-117e-4e17-88f4-d1b12b0e3d89")]
[NativeTypeName("struct IDCompositionTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionTarget : IDCompositionTarget.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionTarget
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4C, 0xD0, 0xCD, 0xEA,
				0x7E, 0x11,
				0x17, 0x4E,
				0x88,
				0xF4,
				0xD1,
				0xB1,
				0x2B,
				0x0E,
				0x3D,
				0x89
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTarget));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTarget));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionTarget*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionTarget*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionTarget*, uint>)(lpVtbl[1]))((IDCompositionTarget*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionTarget*, uint>)(lpVtbl[1]))((IDCompositionTarget*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionTarget*, uint>)(lpVtbl[2]))((IDCompositionTarget*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionTarget*, uint>)(lpVtbl[2]))((IDCompositionTarget*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTarget::SetRoot"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetRoot(IDCompositionVisual* visual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionTarget*, IDCompositionVisual*, int>)(lpVtbl[3]))((IDCompositionTarget*)Unsafe.AsPointer(ref this), visual);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionTarget*, IDCompositionVisual*, int>)(lpVtbl[3]))((IDCompositionTarget*)Unsafe.AsPointer(ref this), visual);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult SetRoot(IDCompositionVisual* visual);
	}
}

