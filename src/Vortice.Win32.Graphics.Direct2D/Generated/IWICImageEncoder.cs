// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging.D2D;

/// <include file='../../Vortice.Win32.Graphics.Imaging/Imaging.xml' path='doc/member[@name="IWICImageEncoder"]/*' />
/// <unmanaged>IWICImageEncoder</unmanaged>
[Guid("04c75bf8-3ce1-473b-acc5-3cc4f5e94999")]
[NativeTypeName("struct IWICImageEncoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICImageEncoder : IWICImageEncoder.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICImageEncoder
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF8, 0x5B, 0xC7, 0x04,
				0xE1, 0x3C,
				0x3B, 0x47,
				0xAC,
				0xC5,
				0x3C,
				0xC4,
				0xF5,
				0xE9,
				0x49,
				0x99
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImageEncoder));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImageEncoder));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImageEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImageEncoder*, uint>)(lpVtbl[1]))((IWICImageEncoder*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, uint>)(lpVtbl[1]))((IWICImageEncoder*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImageEncoder*, uint>)(lpVtbl[2]))((IWICImageEncoder*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, uint>)(lpVtbl[2]))((IWICImageEncoder*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../../Vortice.Win32.Graphics.Imaging/Imaging.xml' path='doc/member[@name="IWICImageEncoder::WriteFrame"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult WriteFrame(Graphics.Direct2D.ID2D1Image* pImage, Graphics.Imaging.IWICBitmapFrameEncode* pFrameEncode, Graphics.Imaging.WICImageParameters* pImageParameters)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImageEncoder*, Graphics.Direct2D.ID2D1Image*, Graphics.Imaging.IWICBitmapFrameEncode*, Graphics.Imaging.WICImageParameters*, int>)(lpVtbl[3]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Graphics.Direct2D.ID2D1Image*, Graphics.Imaging.IWICBitmapFrameEncode*, Graphics.Imaging.WICImageParameters*, int>)(lpVtbl[3]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
#endif
	}

	/// <include file='../../Vortice.Win32.Graphics.Imaging/Imaging.xml' path='doc/member[@name="IWICImageEncoder::WriteFrameThumbnail"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult WriteFrameThumbnail(Graphics.Direct2D.ID2D1Image* pImage, Graphics.Imaging.IWICBitmapFrameEncode* pFrameEncode, Graphics.Imaging.WICImageParameters* pImageParameters)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImageEncoder*, Graphics.Direct2D.ID2D1Image*, Graphics.Imaging.IWICBitmapFrameEncode*, Graphics.Imaging.WICImageParameters*, int>)(lpVtbl[4]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Graphics.Direct2D.ID2D1Image*, Graphics.Imaging.IWICBitmapFrameEncode*, Graphics.Imaging.WICImageParameters*, int>)(lpVtbl[4]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pFrameEncode, pImageParameters);
#endif
	}

	/// <include file='../../Vortice.Win32.Graphics.Imaging/Imaging.xml' path='doc/member[@name="IWICImageEncoder::WriteThumbnail"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult WriteThumbnail(Graphics.Direct2D.ID2D1Image* pImage, Graphics.Imaging.IWICBitmapEncoder* pEncoder, Graphics.Imaging.WICImageParameters* pImageParameters)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImageEncoder*, Graphics.Direct2D.ID2D1Image*, Graphics.Imaging.IWICBitmapEncoder*, Graphics.Imaging.WICImageParameters*, int>)(lpVtbl[5]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pEncoder, pImageParameters);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Graphics.Direct2D.ID2D1Image*, Graphics.Imaging.IWICBitmapEncoder*, Graphics.Imaging.WICImageParameters*, int>)(lpVtbl[5]))((IWICImageEncoder*)Unsafe.AsPointer(ref this), pImage, pEncoder, pImageParameters);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult WriteFrame(Graphics.Direct2D.ID2D1Image* pImage, Graphics.Imaging.IWICBitmapFrameEncode* pFrameEncode, Graphics.Imaging.WICImageParameters* pImageParameters);

		[VtblIndex(4)]
		HResult WriteFrameThumbnail(Graphics.Direct2D.ID2D1Image* pImage, Graphics.Imaging.IWICBitmapFrameEncode* pFrameEncode, Graphics.Imaging.WICImageParameters* pImageParameters);

		[VtblIndex(5)]
		HResult WriteThumbnail(Graphics.Direct2D.ID2D1Image* pImage, Graphics.Imaging.IWICBitmapEncoder* pEncoder, Graphics.Imaging.WICImageParameters* pImageParameters);
	}
}

