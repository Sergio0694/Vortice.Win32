// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionInkTrailDevice"]/*' />
/// <unmanaged>IDCompositionInkTrailDevice</unmanaged>
[Guid("df0c7cec-cdeb-4d4a-b91c-721bf22f4e6c")]
[NativeTypeName("struct IDCompositionInkTrailDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionInkTrailDevice : IDCompositionInkTrailDevice.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionInkTrailDevice
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xEC, 0x7C, 0x0C, 0xDF,
				0xEB, 0xCD,
				0x4A, 0x4D,
				0xB9,
				0x1C,
				0x72,
				0x1B,
				0xF2,
				0x2F,
				0x4E,
				0x6C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionInkTrailDevice));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionInkTrailDevice));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionInkTrailDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionInkTrailDevice*, uint>)(lpVtbl[1]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, uint>)(lpVtbl[1]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionInkTrailDevice*, uint>)(lpVtbl[2]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, uint>)(lpVtbl[2]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionInkTrailDevice::CreateDelegatedInkTrail"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail** inkTrail)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[3]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), inkTrail);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[3]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), inkTrail);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionInkTrailDevice::CreateDelegatedInkTrailForSwapChain"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateDelegatedInkTrailForSwapChain(IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionInkTrailDevice*, IUnknown*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[4]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), swapChain, inkTrail);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, IUnknown*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[4]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), swapChain, inkTrail);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail** inkTrail);

		[VtblIndex(4)]
		HResult CreateDelegatedInkTrailForSwapChain(IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail);
	}
}

