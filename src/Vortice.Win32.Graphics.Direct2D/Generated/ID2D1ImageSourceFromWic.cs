// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageSourceFromWic"]/*' />
/// <unmanaged>ID2D1ImageSourceFromWic</unmanaged>
[Guid("77395441-1c8f-4555-8683-f50dab0fe792")]
[NativeTypeName("struct ID2D1ImageSourceFromWic : ID2D1ImageSource")]
[NativeInheritance("ID2D1ImageSource")]
public unsafe partial struct ID2D1ImageSourceFromWic : ID2D1ImageSourceFromWic.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1ImageSourceFromWic
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x41, 0x54, 0x39, 0x77,
				0x8F, 0x1C,
				0x55, 0x45,
				0x86,
				0x83,
				0xF5,
				0x0D,
				0xAB,
				0x0F,
				0xE7,
				0x92
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageSourceFromWic));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageSourceFromWic));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, uint>)(lpVtbl[1]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, uint>)(lpVtbl[2]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1ImageSource.OfferResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult OfferResources()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, int>)(lpVtbl[4]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1ImageSource.TryReclaimResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult TryReclaimResources(Bool32* resourcesDiscarded)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Bool32*, int>)(lpVtbl[5]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), resourcesDiscarded);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageSourceFromWic::EnsureCached"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult EnsureCached(Win32.Numerics.Rect* rectangleToFill)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Win32.Numerics.Rect*, int>)(lpVtbl[6]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToFill);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageSourceFromWic::TrimCache"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult TrimCache(Win32.Numerics.Rect* rectangleToPreserve)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Win32.Numerics.Rect*, int>)(lpVtbl[7]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToPreserve);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ImageSourceFromWic::GetSource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetSource(Graphics.Imaging.IWICBitmapSource** wicBitmapSource)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Graphics.Imaging.IWICBitmapSource**, void>)(lpVtbl[8]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), wicBitmapSource);
	}

	public interface Interface : ID2D1ImageSource.Interface
	{
		[VtblIndex(6)]
		HResult EnsureCached(Win32.Numerics.Rect* rectangleToFill);

		[VtblIndex(7)]
		HResult TrimCache(Win32.Numerics.Rect* rectangleToPreserve);

		[VtblIndex(8)]
		void GetSource(Graphics.Imaging.IWICBitmapSource** wicBitmapSource);
	}
}

