// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument"]/*' />
/// <unmanaged>ID2D1SvgDocument</unmanaged>
[Guid("86b88e4d-afa4-4d7b-88e4-68a51c4a0aec")]
[NativeTypeName("struct ID2D1SvgDocument : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SvgDocument : ID2D1SvgDocument.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1SvgDocument
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4D, 0x8E, 0xB8, 0x86,
				0xA4, 0xAF,
				0x7B, 0x4D,
				0x88,
				0xE4,
				0x68,
				0xA5,
				0x1C,
				0x4A,
				0x0A,
				0xEC
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgDocument));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgDocument));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, uint>)(lpVtbl[1]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, uint>)(lpVtbl[1]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, uint>)(lpVtbl[2]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, uint>)(lpVtbl[2]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1SvgDocument*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), factory);
#else
		((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), factory);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::SetViewportSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetViewportSize(System.Drawing.SizeF viewportSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, System.Drawing.SizeF, int>)(lpVtbl[4]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), viewportSize);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, System.Drawing.SizeF, int>)(lpVtbl[4]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), viewportSize);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::GetViewportSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public System.Drawing.SizeF GetViewportSize()
	{
		System.Drawing.SizeF result;
#if NET6_0_OR_GREATER
		return *((delegate* unmanaged<ID2D1SvgDocument*, System.Drawing.SizeF*, System.Drawing.SizeF*>)(lpVtbl[5]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), &result);
#else
		return *((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, System.Drawing.SizeF*, System.Drawing.SizeF*>)(lpVtbl[5]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), &result);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::SetRoot"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetRoot(ID2D1SvgElement* root)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, ID2D1SvgElement*, int>)(lpVtbl[6]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement*, int>)(lpVtbl[6]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::GetRoot"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetRoot(ID2D1SvgElement** root)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1SvgDocument*, ID2D1SvgElement**, void>)(lpVtbl[7]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
#else
		((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement**, void>)(lpVtbl[7]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::FindElementById"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult FindElementById(ushort* id, ID2D1SvgElement** svgElement)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, ushort*, ID2D1SvgElement**, int>)(lpVtbl[8]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), id, svgElement);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ushort*, ID2D1SvgElement**, int>)(lpVtbl[8]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), id, svgElement);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::Serialize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult Serialize(Com.IStream* outputXmlStream, ID2D1SvgElement* subtree)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, Com.IStream*, ID2D1SvgElement*, int>)(lpVtbl[9]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), outputXmlStream, subtree);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Com.IStream*, ID2D1SvgElement*, int>)(lpVtbl[9]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), outputXmlStream, subtree);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::Deserialize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult Deserialize(Com.IStream* inputXmlStream, ID2D1SvgElement** subtree)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, Com.IStream*, ID2D1SvgElement**, int>)(lpVtbl[10]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), inputXmlStream, subtree);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Com.IStream*, ID2D1SvgElement**, int>)(lpVtbl[10]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), inputXmlStream, subtree);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::CreatePaint"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreatePaint(SvgPaintType paintType, Color4* color, ushort* id, ID2D1SvgPaint** paint)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, SvgPaintType, Color4*, ushort*, ID2D1SvgPaint**, int>)(lpVtbl[11]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), paintType, color, id, paint);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Color4*, ushort*, ID2D1SvgPaint**, int>)(lpVtbl[11]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), paintType, color, id, paint);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::CreateStrokeDashArray"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateStrokeDashArray(SvgLength* dashes, uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)(lpVtbl[12]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), dashes, dashesCount, strokeDashArray);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)(lpVtbl[12]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), dashes, dashesCount, strokeDashArray);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::CreatePointCollection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreatePointCollection(Vector2* points, uint pointsCount, ID2D1SvgPointCollection** pointCollection)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, Vector2*, uint, ID2D1SvgPointCollection**, int>)(lpVtbl[13]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), points, pointsCount, pointCollection);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Vector2*, uint, ID2D1SvgPointCollection**, int>)(lpVtbl[13]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), points, pointsCount, pointCollection);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgDocument::CreatePathData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreatePathData(float* segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, ID2D1SvgPathData** pathData)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)(lpVtbl[14]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), segmentData, segmentDataCount, commands, commandsCount, pathData);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)(lpVtbl[14]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), segmentData, segmentDataCount, commands, commandsCount, pathData);
#endif
	}

	public interface Interface : ID2D1Resource.Interface
	{
		[VtblIndex(4)]
		HResult SetViewportSize(System.Drawing.SizeF viewportSize);

		[VtblIndex(5)]
		System.Drawing.SizeF GetViewportSize();

		[VtblIndex(6)]
		HResult SetRoot(ID2D1SvgElement* root);

		[VtblIndex(7)]
		void GetRoot(ID2D1SvgElement** root);

		[VtblIndex(8)]
		HResult FindElementById(ushort* id, ID2D1SvgElement** svgElement);

		[VtblIndex(9)]
		HResult Serialize(Com.IStream* outputXmlStream, ID2D1SvgElement* subtree);

		[VtblIndex(10)]
		HResult Deserialize(Com.IStream* inputXmlStream, ID2D1SvgElement** subtree);

		[VtblIndex(11)]
		HResult CreatePaint(SvgPaintType paintType, Color4* color, ushort* id, ID2D1SvgPaint** paint);

		[VtblIndex(12)]
		HResult CreateStrokeDashArray(SvgLength* dashes, uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray);

		[VtblIndex(13)]
		HResult CreatePointCollection(Vector2* points, uint pointsCount, ID2D1SvgPointCollection** pointCollection);

		[VtblIndex(14)]
		HResult CreatePathData(float* segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, ID2D1SvgPathData** pathData);
	}
}

