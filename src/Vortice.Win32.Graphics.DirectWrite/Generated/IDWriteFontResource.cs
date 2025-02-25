// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource"]/*' />
/// <unmanaged>IDWriteFontResource</unmanaged>
[Guid("1f803a76-6871-48e8-987f-b975551c50f2")]
[NativeTypeName("struct IDWriteFontResource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontResource : IDWriteFontResource.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontResource
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x76, 0x3A, 0x80, 0x1F,
				0x71, 0x68,
				0xE8, 0x48,
				0x98,
				0x7F,
				0xB9,
				0x75,
				0x55,
				0x1C,
				0x50,
				0xF2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontResource));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontResource));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, uint>)(lpVtbl[1]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)(lpVtbl[1]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, uint>)(lpVtbl[2]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)(lpVtbl[2]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::GetFontFile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetFontFile(IDWriteFontFile** fontFile)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, IDWriteFontFile**, int>)(lpVtbl[3]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontFile);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, IDWriteFontFile**, int>)(lpVtbl[3]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontFile);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::GetFontFaceIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public uint GetFontFaceIndex()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, uint>)(lpVtbl[4]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)(lpVtbl[4]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::GetFontAxisCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetFontAxisCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, uint>)(lpVtbl[5]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)(lpVtbl[5]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::GetDefaultFontAxisValues"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetDefaultFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, FontAxisValue*, uint, int>)(lpVtbl[6]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisValue*, uint, int>)(lpVtbl[6]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::GetFontAxisRanges"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetFontAxisRanges(FontAxisRange* fontAxisRanges, uint fontAxisRangeCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, FontAxisRange*, uint, int>)(lpVtbl[7]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisRange*, uint, int>)(lpVtbl[7]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::GetFontAxisAttributes"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public FontAxisAttributes GetFontAxisAttributes(uint axisIndex)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, uint, FontAxisAttributes>)(lpVtbl[8]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, FontAxisAttributes>)(lpVtbl[8]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::GetAxisNames"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetAxisNames(uint axisIndex, IDWriteLocalizedStrings** names)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, names);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, names);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::GetAxisValueNameCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public uint GetAxisValueNameCount(uint axisIndex)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, uint, uint>)(lpVtbl[10]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint>)(lpVtbl[10]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::GetAxisValueNames"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetAxisValueNames(uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, IDWriteLocalizedStrings** names)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)(lpVtbl[11]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, axisValueIndex, fontAxisRange, names);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)(lpVtbl[11]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, axisValueIndex, fontAxisRange, names);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::HasVariations"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public Bool32 HasVariations()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, Bool32>)(lpVtbl[12]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Bool32>)(lpVtbl[12]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::CreateFontFace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateFontFace(FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFace5** fontFace)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)(lpVtbl[13]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFace);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)(lpVtbl[13]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFace);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontResource::CreateFontFaceReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateFontFaceReference(FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[14]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[14]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetFontFile(IDWriteFontFile** fontFile);

		[VtblIndex(4)]
		uint GetFontFaceIndex();

		[VtblIndex(5)]
		uint GetFontAxisCount();

		[VtblIndex(6)]
		HResult GetDefaultFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount);

		[VtblIndex(7)]
		HResult GetFontAxisRanges(FontAxisRange* fontAxisRanges, uint fontAxisRangeCount);

		[VtblIndex(8)]
		FontAxisAttributes GetFontAxisAttributes(uint axisIndex);

		[VtblIndex(9)]
		HResult GetAxisNames(uint axisIndex, IDWriteLocalizedStrings** names);

		[VtblIndex(10)]
		uint GetAxisValueNameCount(uint axisIndex);

		[VtblIndex(11)]
		HResult GetAxisValueNames(uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, IDWriteLocalizedStrings** names);

		[VtblIndex(12)]
		Bool32 HasVariations();

		[VtblIndex(13)]
		HResult CreateFontFace(FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFace5** fontFace);

		[VtblIndex(14)]
		HResult CreateFontFaceReference(FontSimulations fontSimulations, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference);
	}
}

