// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet4"]/*' />
/// <unmanaged>IDWriteFontSet4</unmanaged>
[Guid("eec175fc-bea9-4c86-8b53-ccbdd7df0c82")]
[NativeTypeName("struct IDWriteFontSet4 : IDWriteFontSet3")]
[NativeInheritance("IDWriteFontSet3")]
public unsafe partial struct IDWriteFontSet4 : IDWriteFontSet4.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontSet4
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFC, 0x75, 0xC1, 0xEE,
				0xA9, 0xBE,
				0x86, 0x4C,
				0x8B,
				0x53,
				0xCC,
				0xBD,
				0xD7,
				0xDF,
				0x0C,
				0x82
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet4));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet4));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint>)(lpVtbl[1]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint>)(lpVtbl[1]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint>)(lpVtbl[2]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint>)(lpVtbl[2]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.GetFontCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetFontCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint>)(lpVtbl[3]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint>)(lpVtbl[3]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.GetFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFontFaceReference(uint listIndex, IDWriteFontFaceReference** fontFaceReference)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[4]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[4]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.FindFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, uint* listIndex, Bool32* exists)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, IDWriteFontFaceReference*, uint*, Bool32*, int>)(lpVtbl[5]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, IDWriteFontFaceReference*, uint*, Bool32*, int>)(lpVtbl[5]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.FindFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult FindFontFace(IDWriteFontFace* fontFace, uint* listIndex, Bool32* exists)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, IDWriteFontFace*, uint*, Bool32*, int>)(lpVtbl[6]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, IDWriteFontFace*, uint*, Bool32*, int>)(lpVtbl[6]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.GetPropertyValues" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetPropertyValues(FontPropertyId propertyID, IDWriteStringList** values)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontPropertyId, IDWriteStringList**, int>)(lpVtbl[7]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), propertyID, values);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontPropertyId, IDWriteStringList**, int>)(lpVtbl[7]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), propertyID, values);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.GetPropertyValues" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetPropertyValues(FontPropertyId propertyID, ushort* preferredLocaleNames, IDWriteStringList** values)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontPropertyId, ushort*, IDWriteStringList**, int>)(lpVtbl[8]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontPropertyId, ushort*, IDWriteStringList**, int>)(lpVtbl[8]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.GetPropertyValues" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetPropertyValues(uint listIndex, FontPropertyId propertyId, Bool32* exists, IDWriteLocalizedStrings** values)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, FontPropertyId, Bool32*, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, FontPropertyId, Bool32*, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.GetPropertyOccurrenceCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetPropertyOccurrenceCount(FontProperty* property, uint* propertyOccurrenceCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontProperty*, uint*, int>)(lpVtbl[10]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontProperty*, uint*, int>)(lpVtbl[10]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.GetMatchingFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetMatchingFonts(ushort* familyName, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, IDWriteFontSet** filteredSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, ushort*, FontWeight, FontStretch, FontStyle, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, ushort*, FontWeight, FontStretch, FontStyle, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet.GetMatchingFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetMatchingFonts(FontProperty* properties, uint propertyCount, IDWriteFontSet** filteredSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontProperty*, uint, IDWriteFontSet**, int>)(lpVtbl[12]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontProperty*, uint, IDWriteFontSet**, int>)(lpVtbl[12]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetMatchingFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetMatchingFonts(FontProperty* fontProperty, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontSet1** matchingFonts)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontProperty*, FontAxisValue*, uint, IDWriteFontSet1**, int>)(lpVtbl[13]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontProperty, fontAxisValues, fontAxisValueCount, matchingFonts);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontProperty*, FontAxisValue*, uint, IDWriteFontSet1**, int>)(lpVtbl[13]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontProperty, fontAxisValues, fontAxisValueCount, matchingFonts);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFirstFontResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetFirstFontResources(IDWriteFontSet1** filteredFontSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, IDWriteFontSet1**, int>)(lpVtbl[14]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), filteredFontSet);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, IDWriteFontSet1**, int>)(lpVtbl[14]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), filteredFontSet);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFilteredFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetFilteredFonts(uint* indices, uint indexCount, IDWriteFontSet1** filteredFontSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint*, uint, IDWriteFontSet1**, int>)(lpVtbl[15]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), indices, indexCount, filteredFontSet);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint*, uint, IDWriteFontSet1**, int>)(lpVtbl[15]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), indices, indexCount, filteredFontSet);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFilteredFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetFilteredFonts(FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, Bool32 selectAnyRange, IDWriteFontSet1** filteredFontSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontAxisRange*, uint, Bool32, IDWriteFontSet1**, int>)(lpVtbl[16]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, filteredFontSet);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontAxisRange*, uint, Bool32, IDWriteFontSet1**, int>)(lpVtbl[16]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, filteredFontSet);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFilteredFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetFilteredFonts(FontProperty* properties, uint propertyCount, Bool32 selectAnyProperty, IDWriteFontSet1** filteredFontSet)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontProperty*, uint, Bool32, IDWriteFontSet1**, int>)(lpVtbl[17]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, filteredFontSet);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontProperty*, uint, Bool32, IDWriteFontSet1**, int>)(lpVtbl[17]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, filteredFontSet);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFilteredFontIndices" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetFilteredFontIndices(FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, Bool32 selectAnyRange, uint* indices, uint maxIndexCount, uint* actualIndexCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontAxisRange*, uint, Bool32, uint*, uint, uint*, int>)(lpVtbl[18]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, indices, maxIndexCount, actualIndexCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontAxisRange*, uint, Bool32, uint*, uint, uint*, int>)(lpVtbl[18]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, indices, maxIndexCount, actualIndexCount);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFilteredFontIndices" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFilteredFontIndices(FontProperty* properties, uint propertyCount, Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontProperty*, uint, Bool32, uint*, uint, uint*, int>)(lpVtbl[19]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontProperty*, uint, Bool32, uint*, uint, uint*, int>)(lpVtbl[19]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFontAxisRanges" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult GetFontAxisRanges(uint listIndex, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, FontAxisRange*, uint, uint*, int>)(lpVtbl[20]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, FontAxisRange*, uint, uint*, int>)(lpVtbl[20]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFontAxisRanges" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetFontAxisRanges(FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontAxisRange*, uint, uint*, int>)(lpVtbl[21]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontAxisRange*, uint, uint*, int>)(lpVtbl[21]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult GetFontFaceReference(uint listIndex, IDWriteFontFaceReference1** fontFaceReference)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[22]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[22]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.CreateFontResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateFontResource(uint listIndex, IDWriteFontResource** fontResource)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, IDWriteFontResource**, int>)(lpVtbl[23]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontResource);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, IDWriteFontResource**, int>)(lpVtbl[23]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontResource);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.CreateFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateFontFace(uint listIndex, IDWriteFontFace5** fontFace)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, IDWriteFontFace5**, int>)(lpVtbl[24]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontFace);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, IDWriteFontFace5**, int>)(lpVtbl[24]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontFace);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet1.GetFontLocality" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public Locality GetFontLocality(uint listIndex)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, Locality>)(lpVtbl[25]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, Locality>)(lpVtbl[25]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet2.GetExpirationEvent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public Handle GetExpirationEvent()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, Handle>)(lpVtbl[26]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, Handle>)(lpVtbl[26]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet3.GetFontSourceType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public FontSourceType GetFontSourceType(uint fontIndex)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, FontSourceType>)(lpVtbl[27]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontIndex);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, FontSourceType>)(lpVtbl[27]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontIndex);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet3.GetFontSourceNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public uint GetFontSourceNameLength(uint listIndex)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, uint>)(lpVtbl[28]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, uint>)(lpVtbl[28]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex);
#endif
	}

	/// <inheritdoc cref="IDWriteFontSet3.GetFontSourceName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult GetFontSourceName(uint listIndex, ushort* stringBuffer, uint stringBufferSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, uint, ushort*, uint, int>)(lpVtbl[29]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, stringBuffer, stringBufferSize);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, ushort*, uint, int>)(lpVtbl[29]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, stringBuffer, stringBufferSize);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet4::ConvertWeightStretchStyleToFontAxisValues"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public uint ConvertWeightStretchStyleToFontAxisValues(FontAxisValue* inputAxisValues, uint inputAxisCount, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, float fontSize, FontAxisValue* outputAxisValues)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, FontAxisValue*, uint, FontWeight, FontStretch, FontStyle, float, FontAxisValue*, uint>)(lpVtbl[30]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), inputAxisValues, inputAxisCount, fontWeight, fontStretch, fontStyle, fontSize, outputAxisValues);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontAxisValue*, uint, FontWeight, FontStretch, FontStyle, float, FontAxisValue*, uint>)(lpVtbl[30]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), inputAxisValues, inputAxisCount, fontWeight, fontStretch, fontStyle, fontSize, outputAxisValues);
#endif
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet4::GetMatchingFonts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult GetMatchingFonts(ushort* familyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, FontSimulations allowedSimulations, IDWriteFontSet4** matchingFonts)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDWriteFontSet4*, ushort*, FontAxisValue*, uint, FontSimulations, IDWriteFontSet4**, int>)(lpVtbl[31]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, allowedSimulations, matchingFonts);
#else
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, ushort*, FontAxisValue*, uint, FontSimulations, IDWriteFontSet4**, int>)(lpVtbl[31]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, allowedSimulations, matchingFonts);
#endif
	}

	public interface Interface : IDWriteFontSet3.Interface
	{
		[VtblIndex(30)]
		uint ConvertWeightStretchStyleToFontAxisValues(FontAxisValue* inputAxisValues, uint inputAxisCount, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, float fontSize, FontAxisValue* outputAxisValues);

		[VtblIndex(31)]
		HResult GetMatchingFonts(ushort* familyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, FontSimulations allowedSimulations, IDWriteFontSet4** matchingFonts);
	}
}

