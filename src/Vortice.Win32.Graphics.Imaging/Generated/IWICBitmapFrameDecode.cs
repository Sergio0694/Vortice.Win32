// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapFrameDecode"]/*' />
/// <unmanaged>IWICBitmapFrameDecode</unmanaged>
[Guid("3b16811b-6a43-4ec9-a813-3d930c13b940")]
[NativeTypeName("struct IWICBitmapFrameDecode : IWICBitmapSource")]
[NativeInheritance("IWICBitmapSource")]
public unsafe partial struct IWICBitmapFrameDecode : IWICBitmapFrameDecode.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICBitmapFrameDecode
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x1B, 0x81, 0x16, 0x3B,
				0x43, 0x6A,
				0xC9, 0x4E,
				0xA8,
				0x13,
				0x3D,
				0x93,
				0x0C,
				0x13,
				0xB9,
				0x40
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapFrameDecode));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapFrameDecode));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, uint>)(lpVtbl[1]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint>)(lpVtbl[1]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, uint>)(lpVtbl[2]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint>)(lpVtbl[2]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IWICBitmapSource.GetSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetSize(uint* puiWidth, uint* puiHeight)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
#endif
	}

	/// <inheritdoc cref="IWICBitmapSource.GetPixelFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPixelFormat(Guid* pPixelFormat)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, Guid*, int>)(lpVtbl[4]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pPixelFormat);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, Guid*, int>)(lpVtbl[4]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pPixelFormat);
#endif
	}

	/// <inheritdoc cref="IWICBitmapSource.GetResolution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetResolution(double* pDpiX, double* pDpiY)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, double*, double*, int>)(lpVtbl[5]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, double*, double*, int>)(lpVtbl[5]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
#endif
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPalette" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CopyPalette(IWICPalette* pIPalette)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pIPalette);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), pIPalette);
#endif
	}

	/// <inheritdoc cref="IWICBitmapSource.CopyPixels" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CopyPixels(System.Drawing.Rectangle* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, System.Drawing.Rectangle*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, System.Drawing.Rectangle*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapFrameDecode::GetMetadataQueryReader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapFrameDecode::GetColorContexts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)(lpVtbl[9]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, uint, IWICColorContext**, uint*, int>)(lpVtbl[9]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapFrameDecode::GetThumbnail"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetThumbnail(IWICBitmapSource** ppIThumbnail)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapFrameDecode*, IWICBitmapSource**, int>)(lpVtbl[10]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIThumbnail);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapFrameDecode*, IWICBitmapSource**, int>)(lpVtbl[10]))((IWICBitmapFrameDecode*)Unsafe.AsPointer(ref this), ppIThumbnail);
#endif
	}

	public interface Interface : IWICBitmapSource.Interface
	{
		[VtblIndex(8)]
		HResult GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader);

		[VtblIndex(9)]
		HResult GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);

		[VtblIndex(10)]
		HResult GetThumbnail(IWICBitmapSource** ppIThumbnail);
	}
}

