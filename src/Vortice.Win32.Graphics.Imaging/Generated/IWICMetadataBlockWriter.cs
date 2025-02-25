// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter"]/*' />
/// <unmanaged>IWICMetadataBlockWriter</unmanaged>
[Guid("08fb9676-b444-41e8-8dbe-6a53a542bff1")]
[NativeTypeName("struct IWICMetadataBlockWriter : IWICMetadataBlockReader")]
[NativeInheritance("IWICMetadataBlockReader")]
public unsafe partial struct IWICMetadataBlockWriter : IWICMetadataBlockWriter.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICMetadataBlockWriter
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x76, 0x96, 0xFB, 0x08,
				0x44, 0xB4,
				0xE8, 0x41,
				0x8D,
				0xBE,
				0x6A,
				0x53,
				0xA5,
				0x42,
				0xBF,
				0xF1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataBlockWriter));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataBlockWriter));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint>)(lpVtbl[1]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint>)(lpVtbl[1]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint>)(lpVtbl[2]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint>)(lpVtbl[2]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IWICMetadataBlockReader.GetContainerFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetContainerFormat(Guid* pguidContainerFormat)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
#endif
	}

	/// <inheritdoc cref="IWICMetadataBlockReader.GetCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCount(uint* pcCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint*, int>)(lpVtbl[4]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pcCount);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint*, int>)(lpVtbl[4]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pcCount);
#endif
	}

	/// <inheritdoc cref="IWICMetadataBlockReader.GetReaderByIndex" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int>)(lpVtbl[5]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int>)(lpVtbl[5]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
#endif
	}

	/// <inheritdoc cref="IWICMetadataBlockReader.GetEnumerator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetEnumerator(Com.IEnumUnknown** ppIEnumMetadata)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, Com.IEnumUnknown**, int>)(lpVtbl[6]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Com.IEnumUnknown**, int>)(lpVtbl[6]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::InitializeFromBlockReader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult InitializeFromBlockReader(IWICMetadataBlockReader* pIMDBlockReader)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int>)(lpVtbl[7]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMDBlockReader);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int>)(lpVtbl[7]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMDBlockReader);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::GetWriterByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetWriterByIndex(uint nIndex, IWICMetadataWriter** ppIMetadataWriter)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int>)(lpVtbl[8]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataWriter);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int>)(lpVtbl[8]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataWriter);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::AddWriter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult AddWriter(IWICMetadataWriter* pIMetadataWriter)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, IWICMetadataWriter*, int>)(lpVtbl[9]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMetadataWriter);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, IWICMetadataWriter*, int>)(lpVtbl[9]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMetadataWriter);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::SetWriterByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetWriterByIndex(uint nIndex, IWICMetadataWriter* pIMetadataWriter)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int>)(lpVtbl[10]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, pIMetadataWriter);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int>)(lpVtbl[10]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, pIMetadataWriter);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::RemoveWriterByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult RemoveWriterByIndex(uint nIndex)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICMetadataBlockWriter*, uint, int>)(lpVtbl[11]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex);
#else
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, int>)(lpVtbl[11]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex);
#endif
	}

	public interface Interface : IWICMetadataBlockReader.Interface
	{
		[VtblIndex(7)]
		HResult InitializeFromBlockReader(IWICMetadataBlockReader* pIMDBlockReader);

		[VtblIndex(8)]
		HResult GetWriterByIndex(uint nIndex, IWICMetadataWriter** ppIMetadataWriter);

		[VtblIndex(9)]
		HResult AddWriter(IWICMetadataWriter* pIMetadataWriter);

		[VtblIndex(10)]
		HResult SetWriterByIndex(uint nIndex, IWICMetadataWriter* pIMetadataWriter);

		[VtblIndex(11)]
		HResult RemoveWriterByIndex(uint nIndex);
	}
}

