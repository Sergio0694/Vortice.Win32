// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapEncoderInfo"]/*' />
/// <unmanaged>IWICBitmapEncoderInfo</unmanaged>
[Guid("94c9b4ee-a09f-4f92-8a1e-4a9bce7e76fb")]
[NativeTypeName("struct IWICBitmapEncoderInfo : IWICBitmapCodecInfo")]
[NativeInheritance("IWICBitmapCodecInfo")]
public unsafe partial struct IWICBitmapEncoderInfo : IWICBitmapEncoderInfo.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICBitmapEncoderInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xEE, 0xB4, 0xC9, 0x94,
				0x9F, 0xA0,
				0x92, 0x4F,
				0x8A,
				0x1E,
				0x4A,
				0x9B,
				0xCE,
				0x7E,
				0x76,
				0xFB
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapEncoderInfo));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapEncoderInfo));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint>)(lpVtbl[1]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint>)(lpVtbl[1]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint>)(lpVtbl[2]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint>)(lpVtbl[2]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetComponentType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetComponentType(WICComponentType* pType)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pType);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pType);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetCLSID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCLSID(Guid* pclsid)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Guid*, int>)(lpVtbl[4]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pclsid);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)(lpVtbl[4]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pclsid);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSigningStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSigningStatus(uint* pStatus)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint*, int>)(lpVtbl[5]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pStatus);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint*, int>)(lpVtbl[5]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pStatus);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetAuthor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetAuthor(uint cchAuthor, ushort* wzAuthor, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVendorGUID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVendorGUID(Guid* pguidVendor)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Guid*, int>)(lpVtbl[7]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)(lpVtbl[7]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVersion(uint cchVersion, ushort* wzVersion, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSpecVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSpecVersion(uint cchSpecVersion, ushort* wzSpecVersion, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICComponentInfo.GetFriendlyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFriendlyName(uint cchFriendlyName, ushort* wzFriendlyName, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetContainerFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetContainerFormat(Guid* pguidContainerFormat)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Guid*, int>)(lpVtbl[11]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Guid*, int>)(lpVtbl[11]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetPixelFormats" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetColorManagementVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetColorManagementVersion(uint cchColorManagementVersion, ushort* wzColorManagementVersion, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetDeviceManufacturer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetDeviceManufacturer(uint cchDeviceManufacturer, ushort* wzDeviceManufacturer, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetDeviceModels" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetDeviceModels(uint cchDeviceModels, ushort* wzDeviceModels, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[15]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[15]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetMimeTypes" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetMimeTypes(uint cchMimeTypes, ushort* wzMimeTypes, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[16]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[16]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetFileExtensions" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetFileExtensions(uint cchFileExtensions, ushort* wzFileExtensions, uint* pcchActual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[17]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, uint, ushort*, uint*, int>)(lpVtbl[17]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportAnimation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult DoesSupportAnimation(Bool32* pfSupportAnimation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Bool32*, int>)(lpVtbl[18]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Bool32*, int>)(lpVtbl[18]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportChromakey" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult DoesSupportChromakey(Bool32* pfSupportChromakey)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Bool32*, int>)(lpVtbl[19]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Bool32*, int>)(lpVtbl[19]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportLossless" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult DoesSupportLossless(Bool32* pfSupportLossless)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Bool32*, int>)(lpVtbl[20]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Bool32*, int>)(lpVtbl[20]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportMultiframe" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult DoesSupportMultiframe(Bool32* pfSupportMultiframe)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, Bool32*, int>)(lpVtbl[21]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, Bool32*, int>)(lpVtbl[21]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
#endif
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.MatchesMimeType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult MatchesMimeType(ushort* wzMimeType, Bool32* pfMatches)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, ushort*, Bool32*, int>)(lpVtbl[22]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, ushort*, Bool32*, int>)(lpVtbl[22]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapEncoderInfo::CreateInstance"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateInstance(IWICBitmapEncoder** ppIBitmapEncoder)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICBitmapEncoderInfo*, IWICBitmapEncoder**, int>)(lpVtbl[23]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapEncoder);
#else
		return ((delegate* unmanaged[Stdcall]<IWICBitmapEncoderInfo*, IWICBitmapEncoder**, int>)(lpVtbl[23]))((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapEncoder);
#endif
	}

	public interface Interface : IWICBitmapCodecInfo.Interface
	{
		[VtblIndex(23)]
		HResult CreateInstance(IWICBitmapEncoder** ppIBitmapEncoder);
	}
}

