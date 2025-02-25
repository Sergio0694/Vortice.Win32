// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip"]/*' />
/// <unmanaged>IDCompositionRectangleClip</unmanaged>
[Guid("9842ad7d-d9cf-4908-aed7-48b51da5e7c2")]
[NativeTypeName("struct IDCompositionRectangleClip : IDCompositionClip")]
[NativeInheritance("IDCompositionClip")]
public unsafe partial struct IDCompositionRectangleClip : IDCompositionRectangleClip.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionRectangleClip
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x7D, 0xAD, 0x42, 0x98,
				0xCF, 0xD9,
				0x08, 0x49,
				0xAE,
				0xD7,
				0x48,
				0xB5,
				0x1D,
				0xA5,
				0xE7,
				0xC2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionRectangleClip));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionRectangleClip));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, uint>)(lpVtbl[1]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, uint>)(lpVtbl[1]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, uint>)(lpVtbl[2]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, uint>)(lpVtbl[2]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetLeft"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetLeft(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetLeft"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetLeft(float left)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[4]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), left);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[4]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), left);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTop"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetTop(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTop"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetTop(float top)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[6]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), top);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[6]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), top);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetRight"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetRight(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetRight"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetRight(float right)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[8]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), right);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[8]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), right);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottom"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetBottom(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottom"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetBottom(float bottom)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[10]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), bottom);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[10]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), bottom);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTopLeftRadiusX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SetTopLeftRadiusX(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTopLeftRadiusX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetTopLeftRadiusX(float radius)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[12]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[12]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTopLeftRadiusY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult SetTopLeftRadiusY(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTopLeftRadiusY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetTopLeftRadiusY(float radius)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[14]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[14]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTopRightRadiusX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult SetTopRightRadiusX(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[15]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[15]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTopRightRadiusX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult SetTopRightRadiusX(float radius)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[16]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[16]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTopRightRadiusY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult SetTopRightRadiusY(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[17]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[17]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetTopRightRadiusY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult SetTopRightRadiusY(float radius)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[18]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[18]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottomLeftRadiusX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult SetBottomLeftRadiusX(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[19]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[19]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottomLeftRadiusX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult SetBottomLeftRadiusX(float radius)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[20]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[20]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottomLeftRadiusY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult SetBottomLeftRadiusY(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[21]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[21]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottomLeftRadiusY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult SetBottomLeftRadiusY(float radius)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[22]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[22]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottomRightRadiusX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult SetBottomRightRadiusX(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[23]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[23]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottomRightRadiusX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult SetBottomRightRadiusX(float radius)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[24]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[24]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottomRightRadiusY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult SetBottomRightRadiusY(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[25]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, IDCompositionAnimation*, int>)(lpVtbl[25]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRectangleClip::SetBottomRightRadiusY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult SetBottomRightRadiusY(float radius)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionRectangleClip*, float, int>)(lpVtbl[26]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)(lpVtbl[26]))((IDCompositionRectangleClip*)Unsafe.AsPointer(ref this), radius);
#endif
	}

	public interface Interface : IDCompositionClip.Interface
	{
		[VtblIndex(3)]
		HResult SetLeft(IDCompositionAnimation* animation);

		[VtblIndex(4)]
		HResult SetLeft(float left);

		[VtblIndex(5)]
		HResult SetTop(IDCompositionAnimation* animation);

		[VtblIndex(6)]
		HResult SetTop(float top);

		[VtblIndex(7)]
		HResult SetRight(IDCompositionAnimation* animation);

		[VtblIndex(8)]
		HResult SetRight(float right);

		[VtblIndex(9)]
		HResult SetBottom(IDCompositionAnimation* animation);

		[VtblIndex(10)]
		HResult SetBottom(float bottom);

		[VtblIndex(11)]
		HResult SetTopLeftRadiusX(IDCompositionAnimation* animation);

		[VtblIndex(12)]
		HResult SetTopLeftRadiusX(float radius);

		[VtblIndex(13)]
		HResult SetTopLeftRadiusY(IDCompositionAnimation* animation);

		[VtblIndex(14)]
		HResult SetTopLeftRadiusY(float radius);

		[VtblIndex(15)]
		HResult SetTopRightRadiusX(IDCompositionAnimation* animation);

		[VtblIndex(16)]
		HResult SetTopRightRadiusX(float radius);

		[VtblIndex(17)]
		HResult SetTopRightRadiusY(IDCompositionAnimation* animation);

		[VtblIndex(18)]
		HResult SetTopRightRadiusY(float radius);

		[VtblIndex(19)]
		HResult SetBottomLeftRadiusX(IDCompositionAnimation* animation);

		[VtblIndex(20)]
		HResult SetBottomLeftRadiusX(float radius);

		[VtblIndex(21)]
		HResult SetBottomLeftRadiusY(IDCompositionAnimation* animation);

		[VtblIndex(22)]
		HResult SetBottomLeftRadiusY(float radius);

		[VtblIndex(23)]
		HResult SetBottomRightRadiusX(IDCompositionAnimation* animation);

		[VtblIndex(24)]
		HResult SetBottomRightRadiusX(float radius);

		[VtblIndex(25)]
		HResult SetBottomRightRadiusY(IDCompositionAnimation* animation);

		[VtblIndex(26)]
		HResult SetBottomRightRadiusY(float radius);
	}
}

