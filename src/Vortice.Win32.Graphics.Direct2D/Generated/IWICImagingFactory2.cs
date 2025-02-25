// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging.D2D;

/// <include file='../../Vortice.Win32.Graphics.Imaging/Imaging.xml' path='doc/member[@name="IWICImagingFactory2"]/*' />
/// <unmanaged>IWICImagingFactory2</unmanaged>
[Guid("7b816b45-1996-4476-b132-de9e247c8af0")]
[NativeTypeName("struct IWICImagingFactory2 : IWICImagingFactory")]
[NativeInheritance("IWICImagingFactory")]
public unsafe partial struct IWICImagingFactory2 : IWICImagingFactory2.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICImagingFactory2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x45, 0x6B, 0x81, 0x7B,
				0x96, 0x19,
				0x76, 0x44,
				0xB1,
				0x32,
				0xDE,
				0x9E,
				0x24,
				0x7C,
				0x8A,
				0xF0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImagingFactory2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, uint>)(lpVtbl[1]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, uint>)(lpVtbl[1]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, uint>)(lpVtbl[2]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, uint>)(lpVtbl[2]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromFilename" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateDecoderFromFilename(ushort* wzFilename, Guid* pguidVendor, NativeFileAccess dwDesiredAccess, Graphics.Imaging.WICDecodeOptions metadataOptions, Graphics.Imaging.IWICBitmapDecoder** ppIDecoder)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, ushort*, Guid*, NativeFileAccess, Graphics.Imaging.WICDecodeOptions, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[3]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, ushort*, Guid*, NativeFileAccess, Graphics.Imaging.WICDecodeOptions, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[3]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromStream" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateDecoderFromStream(Com.IStream* pIStream, Guid* pguidVendor, Graphics.Imaging.WICDecodeOptions metadataOptions, Graphics.Imaging.IWICBitmapDecoder** ppIDecoder)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Com.IStream*, Guid*, Graphics.Imaging.WICDecodeOptions, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[4]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Com.IStream*, Guid*, Graphics.Imaging.WICDecodeOptions, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[4]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromFileHandle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateDecoderFromFileHandle(nuint hFile, Guid* pguidVendor, Graphics.Imaging.WICDecodeOptions metadataOptions, Graphics.Imaging.IWICBitmapDecoder** ppIDecoder)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, nuint, Guid*, Graphics.Imaging.WICDecodeOptions, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[5]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, nuint, Guid*, Graphics.Imaging.WICDecodeOptions, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[5]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateComponentInfo" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateComponentInfo(Guid* clsidComponent, Graphics.Imaging.IWICComponentInfo** ppIInfo)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, Graphics.Imaging.IWICComponentInfo**, int>)(lpVtbl[6]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Guid*, Graphics.Imaging.IWICComponentInfo**, int>)(lpVtbl[6]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateDecoder(Guid* guidContainerFormat, Guid* pguidVendor, Graphics.Imaging.IWICBitmapDecoder** ppIDecoder)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, Guid*, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[7]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Guid*, Guid*, Graphics.Imaging.IWICBitmapDecoder**, int>)(lpVtbl[7]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateEncoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateEncoder(Guid* guidContainerFormat, Guid* pguidVendor, Graphics.Imaging.IWICBitmapEncoder** ppIEncoder)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, Guid*, Graphics.Imaging.IWICBitmapEncoder**, int>)(lpVtbl[8]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Guid*, Guid*, Graphics.Imaging.IWICBitmapEncoder**, int>)(lpVtbl[8]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreatePalette" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreatePalette(Graphics.Imaging.IWICPalette** ppIPalette)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICPalette**, int>)(lpVtbl[9]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIPalette);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICPalette**, int>)(lpVtbl[9]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIPalette);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateFormatConverter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateFormatConverter(Graphics.Imaging.IWICFormatConverter** ppIFormatConverter)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICFormatConverter**, int>)(lpVtbl[10]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIFormatConverter);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICFormatConverter**, int>)(lpVtbl[10]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIFormatConverter);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapScaler" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateBitmapScaler(Graphics.Imaging.IWICBitmapScaler** ppIBitmapScaler)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapScaler**, int>)(lpVtbl[11]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapScaler**, int>)(lpVtbl[11]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapClipper" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateBitmapClipper(Graphics.Imaging.IWICBitmapClipper** ppIBitmapClipper)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapClipper**, int>)(lpVtbl[12]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapClipper**, int>)(lpVtbl[12]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFlipRotator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateBitmapFlipRotator(Graphics.Imaging.IWICBitmapFlipRotator** ppIBitmapFlipRotator)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapFlipRotator**, int>)(lpVtbl[13]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapFlipRotator**, int>)(lpVtbl[13]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateStream" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateStream(Graphics.Imaging.IWICStream** ppIWICStream)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICStream**, int>)(lpVtbl[14]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICStream);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICStream**, int>)(lpVtbl[14]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICStream);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateColorContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateColorContext(Graphics.Imaging.IWICColorContext** ppIWICColorContext)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICColorContext**, int>)(lpVtbl[15]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorContext);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICColorContext**, int>)(lpVtbl[15]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorContext);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateColorTransformer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateColorTransformer(Graphics.Imaging.IWICColorTransform** ppIWICColorTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICColorTransform**, int>)(lpVtbl[16]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICColorTransform**, int>)(lpVtbl[16]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateBitmap(uint uiWidth, uint uiHeight, Guid* pixelFormat, Graphics.Imaging.WICBitmapCreateCacheOption option, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, uint, uint, Guid*, Graphics.Imaging.WICBitmapCreateCacheOption, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[17]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, uint, uint, Guid*, Graphics.Imaging.WICBitmapCreateCacheOption, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[17]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromSource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateBitmapFromSource(Graphics.Imaging.IWICBitmapSource* pIBitmapSource, Graphics.Imaging.WICBitmapCreateCacheOption option, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapSource*, Graphics.Imaging.WICBitmapCreateCacheOption, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[18]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapSource*, Graphics.Imaging.WICBitmapCreateCacheOption, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[18]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromSourceRect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateBitmapFromSourceRect(Graphics.Imaging.IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapSource*, uint, uint, uint, uint, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[19]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapSource*, uint, uint, uint, uint, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[19]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromMemory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, uint, uint, Guid*, uint, uint, byte*, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[20]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, uint, uint, Guid*, uint, uint, byte*, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[20]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromHBITMAP" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateBitmapFromHBITMAP(IntPtr hBitmap, IntPtr hPalette, Graphics.Imaging.WICBitmapAlphaChannelOption options, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, IntPtr, IntPtr, Graphics.Imaging.WICBitmapAlphaChannelOption, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[21]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, IntPtr, IntPtr, Graphics.Imaging.WICBitmapAlphaChannelOption, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[21]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromHICON" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateBitmapFromHICON(IntPtr hIcon, Graphics.Imaging.IWICBitmap** ppIBitmap)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, IntPtr, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[22]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, IntPtr, Graphics.Imaging.IWICBitmap**, int>)(lpVtbl[22]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateComponentEnumerator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateComponentEnumerator(uint componentTypes, uint options, Com.IEnumUnknown** ppIEnumUnknown)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, uint, uint, Com.IEnumUnknown**, int>)(lpVtbl[23]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, uint, uint, Com.IEnumUnknown**, int>)(lpVtbl[23]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateFastMetadataEncoderFromDecoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateFastMetadataEncoderFromDecoder(Graphics.Imaging.IWICBitmapDecoder* pIDecoder, Graphics.Imaging.IWICFastMetadataEncoder** ppIFastEncoder)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapDecoder*, Graphics.Imaging.IWICFastMetadataEncoder**, int>)(lpVtbl[24]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapDecoder*, Graphics.Imaging.IWICFastMetadataEncoder**, int>)(lpVtbl[24]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateFastMetadataEncoderFromFrameDecode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateFastMetadataEncoderFromFrameDecode(Graphics.Imaging.IWICBitmapFrameDecode* pIFrameDecoder, Graphics.Imaging.IWICFastMetadataEncoder** ppIFastEncoder)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapFrameDecode*, Graphics.Imaging.IWICFastMetadataEncoder**, int>)(lpVtbl[25]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICBitmapFrameDecode*, Graphics.Imaging.IWICFastMetadataEncoder**, int>)(lpVtbl[25]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateQueryWriter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult CreateQueryWriter(Guid* guidMetadataFormat, Guid* pguidVendor, Graphics.Imaging.IWICMetadataQueryWriter** ppIQueryWriter)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Guid*, Guid*, Graphics.Imaging.IWICMetadataQueryWriter**, int>)(lpVtbl[26]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Guid*, Guid*, Graphics.Imaging.IWICMetadataQueryWriter**, int>)(lpVtbl[26]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
#endif
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateQueryWriterFromReader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateQueryWriterFromReader(Graphics.Imaging.IWICMetadataQueryReader* pIQueryReader, Guid* pguidVendor, Graphics.Imaging.IWICMetadataQueryWriter** ppIQueryWriter)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Imaging.IWICMetadataQueryReader*, Guid*, Graphics.Imaging.IWICMetadataQueryWriter**, int>)(lpVtbl[27]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Imaging.IWICMetadataQueryReader*, Guid*, Graphics.Imaging.IWICMetadataQueryWriter**, int>)(lpVtbl[27]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
#endif
	}

	/// <include file='../../Vortice.Win32.Graphics.Imaging/Imaging.xml' path='doc/member[@name="IWICImagingFactory2::CreateImageEncoder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult CreateImageEncoder(Graphics.Direct2D.ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICImagingFactory2*, Graphics.Direct2D.ID2D1Device*, IWICImageEncoder**, int>)(lpVtbl[28]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pD2DDevice, ppWICImageEncoder);
#else
		return ((delegate* unmanaged[Stdcall]<IWICImagingFactory2*, Graphics.Direct2D.ID2D1Device*, IWICImageEncoder**, int>)(lpVtbl[28]))((IWICImagingFactory2*)Unsafe.AsPointer(ref this), pD2DDevice, ppWICImageEncoder);
#endif
	}

	public interface Interface : IWICImagingFactory.Interface
	{
		[VtblIndex(28)]
		HResult CreateImageEncoder(Graphics.Direct2D.ID2D1Device* pD2DDevice, IWICImageEncoder** ppWICImageEncoder);
	}
}

