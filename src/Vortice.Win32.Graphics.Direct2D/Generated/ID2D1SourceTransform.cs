// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SourceTransform"]/*' />
/// <unmanaged>ID2D1SourceTransform</unmanaged>
[Guid("db1800dd-0c34-4cf9-be90-31cc0a5653e1")]
[NativeTypeName("struct ID2D1SourceTransform : ID2D1Transform")]
[NativeInheritance("ID2D1Transform")]
public unsafe partial struct ID2D1SourceTransform : ID2D1SourceTransform.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1SourceTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xDD, 0x00, 0x18, 0xDB,
				0x34, 0x0C,
				0xF9, 0x4C,
				0xBE,
				0x90,
				0x31,
				0xCC,
				0x0A,
				0x56,
				0x53,
				0xE1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SourceTransform));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SourceTransform));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SourceTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SourceTransform*, uint>)(lpVtbl[1]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint>)(lpVtbl[1]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SourceTransform*, uint>)(lpVtbl[2]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint>)(lpVtbl[2]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1TransformNode.GetInputCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetInputCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SourceTransform*, uint>)(lpVtbl[3]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint>)(lpVtbl[3]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Transform.MapOutputRectToInputRects" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult MapOutputRectToInputRects(Rect* outputRect, Rect* inputRects, uint inputRectsCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SourceTransform*, Rect*, Rect*, uint, int>)(lpVtbl[4]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Rect*, Rect*, uint, int>)(lpVtbl[4]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
#endif
	}

	/// <inheritdoc cref="ID2D1Transform.MapInputRectsToOutputRect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult MapInputRectsToOutputRect(Rect* inputRects, Rect* inputOpaqueSubRects, uint inputRectCount, Rect* outputRect, Rect* outputOpaqueSubRect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SourceTransform*, Rect*, Rect*, uint, Rect*, Rect*, int>)(lpVtbl[5]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, Rect*, Rect*, uint, Rect*, Rect*, int>)(lpVtbl[5]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
#endif
	}

	/// <inheritdoc cref="ID2D1Transform.MapInvalidRect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult MapInvalidRect(uint inputIndex, Rect invalidInputRect, Rect* invalidOutputRect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SourceTransform*, uint, Rect, Rect*, int>)(lpVtbl[6]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, uint, Rect, Rect*, int>)(lpVtbl[6]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SourceTransform::SetRenderInfo"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetRenderInfo(ID2D1RenderInfo* renderInfo)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SourceTransform*, ID2D1RenderInfo*, int>)(lpVtbl[7]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), renderInfo);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1RenderInfo*, int>)(lpVtbl[7]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), renderInfo);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SourceTransform::Draw"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Draw(ID2D1Bitmap1* target, Rect* drawRect, System.Drawing.Point targetOrigin)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1SourceTransform*, ID2D1Bitmap1*, Rect*, System.Drawing.Point, int>)(lpVtbl[8]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), target, drawRect, targetOrigin);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1SourceTransform*, ID2D1Bitmap1*, Rect*, System.Drawing.Point, int>)(lpVtbl[8]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), target, drawRect, targetOrigin);
#endif
	}

	public interface Interface : ID2D1Transform.Interface
	{
		[VtblIndex(7)]
		HResult SetRenderInfo(ID2D1RenderInfo* renderInfo);

		[VtblIndex(8)]
		HResult Draw(ID2D1Bitmap1* target, Rect* drawRect, System.Drawing.Point targetOrigin);
	}
}

