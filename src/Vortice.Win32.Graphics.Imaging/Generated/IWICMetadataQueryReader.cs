// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataQueryReader"]/*' />
/// <unmanaged>IWICMetadataQueryReader</unmanaged>
[Guid("30989668-e1c9-4597-b395-458eedb808df")]
[NativeTypeName("struct IWICMetadataQueryReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICMetadataQueryReader : IWICMetadataQueryReader.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICMetadataQueryReader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x68, 0x96, 0x98, 0x30,
				0xC9, 0xE1,
				0x97, 0x45,
				0xB3,
				0x95,
				0x45,
				0x8E,
				0xED,
				0xB8,
				0x08,
				0xDF
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataQueryReader));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataQueryReader));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataQueryReader*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataQueryReader*, uint>)(lpVtbl[1]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint>)(lpVtbl[1]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataQueryReader*, uint>)(lpVtbl[2]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint>)(lpVtbl[2]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataQueryReader::GetContainerFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetContainerFormat(Guid* pguidContainerFormat)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataQueryReader*, Guid*, int>)(lpVtbl[3]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Guid*, int>)(lpVtbl[3]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataQueryReader::GetLocation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetLocation(uint cchMaxLength, ushort* wzNamespace, uint* pcchActualLength)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataQueryReader*, uint, ushort*, uint*, int>)(lpVtbl[4]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint, ushort*, uint*, int>)(lpVtbl[4]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataQueryReader::GetMetadataByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetMetadataByName(ushort* wzName, Com.Variant** pvarValue)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataQueryReader*, ushort*, Com.Variant**, int>)(lpVtbl[5]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), wzName, pvarValue);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, ushort*, Com.Variant**, int>)(lpVtbl[5]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), wzName, pvarValue);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataQueryReader::GetEnumerator"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetEnumerator(Com.IEnumString** ppIEnumString)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataQueryReader*, Com.IEnumString**, int>)(lpVtbl[6]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), ppIEnumString);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Com.IEnumString**, int>)(lpVtbl[6]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), ppIEnumString);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetContainerFormat(Guid* pguidContainerFormat);

		[VtblIndex(4)]
		HResult GetLocation(uint cchMaxLength, ushort* wzNamespace, uint* pcchActualLength);

		[VtblIndex(5)]
		HResult GetMetadataByName(ushort* wzName, Com.Variant** pvarValue);

		[VtblIndex(6)]
		HResult GetEnumerator(Com.IEnumString** ppIEnumString);
	}
}

