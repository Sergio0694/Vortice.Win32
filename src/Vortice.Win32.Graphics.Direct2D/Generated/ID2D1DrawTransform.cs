// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1DrawTransform"]/*' />
/// <unmanaged>ID2D1DrawTransform</unmanaged>
[Guid("36bfdcb6-9739-435d-a30d-a653beff6a6f")]
[NativeTypeName("struct ID2D1DrawTransform : ID2D1Transform")]
[NativeInheritance("ID2D1Transform")]
public unsafe partial struct ID2D1DrawTransform : ID2D1DrawTransform.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1DrawTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xB6, 0xDC, 0xBF, 0x36,
				0x39, 0x97,
				0x5D, 0x43,
				0xA3,
				0x0D,
				0xA6,
				0x53,
				0xBE,
				0xFF,
				0x6A,
				0x6F
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1DrawTransform));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1DrawTransform));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1DrawTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1DrawTransform*, uint>)(lpVtbl[1]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawTransform*, uint>)(lpVtbl[1]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1DrawTransform*, uint>)(lpVtbl[2]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawTransform*, uint>)(lpVtbl[2]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1TransformNode.GetInputCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetInputCount()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1DrawTransform*, uint>)(lpVtbl[3]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawTransform*, uint>)(lpVtbl[3]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Transform.MapOutputRectToInputRects" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult MapOutputRectToInputRects(Rect* outputRect, Rect* inputRects, uint inputRectsCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1DrawTransform*, Rect*, Rect*, uint, int>)(lpVtbl[4]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawTransform*, Rect*, Rect*, uint, int>)(lpVtbl[4]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
#endif
	}

	/// <inheritdoc cref="ID2D1Transform.MapInputRectsToOutputRect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult MapInputRectsToOutputRect(Rect* inputRects, Rect* inputOpaqueSubRects, uint inputRectCount, Rect* outputRect, Rect* outputOpaqueSubRect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1DrawTransform*, Rect*, Rect*, uint, Rect*, Rect*, int>)(lpVtbl[5]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawTransform*, Rect*, Rect*, uint, Rect*, Rect*, int>)(lpVtbl[5]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
#endif
	}

	/// <inheritdoc cref="ID2D1Transform.MapInvalidRect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult MapInvalidRect(uint inputIndex, Rect invalidInputRect, Rect* invalidOutputRect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1DrawTransform*, uint, Rect, Rect*, int>)(lpVtbl[6]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawTransform*, uint, Rect, Rect*, int>)(lpVtbl[6]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1DrawTransform::SetDrawInfo"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetDrawInfo(ID2D1DrawInfo* drawInfo)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1DrawTransform*, ID2D1DrawInfo*, int>)(lpVtbl[7]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), drawInfo);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawTransform*, ID2D1DrawInfo*, int>)(lpVtbl[7]))((ID2D1DrawTransform*)Unsafe.AsPointer(ref this), drawInfo);
#endif
	}

	public interface Interface : ID2D1Transform.Interface
	{
		[VtblIndex(7)]
		HResult SetDrawInfo(ID2D1DrawInfo* drawInfo);
	}
}

