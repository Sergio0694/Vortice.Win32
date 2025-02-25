// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D"]/*' />
/// <unmanaged>IDCompositionScaleTransform3D</unmanaged>
[Guid("2a9e9ead-364b-4b15-a7c4-a1997f78b389")]
[NativeTypeName("struct IDCompositionScaleTransform3D : IDCompositionTransform3D")]
[NativeInheritance("IDCompositionTransform3D")]
public unsafe partial struct IDCompositionScaleTransform3D : IDCompositionScaleTransform3D.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionScaleTransform3D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xAD, 0x9E, 0x9E, 0x2A,
				0x4B, 0x36,
				0x15, 0x4B,
				0xA7,
				0xC4,
				0xA1,
				0x99,
				0x7F,
				0x78,
				0xB3,
				0x89
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionScaleTransform3D));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionScaleTransform3D));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, uint>)(lpVtbl[1]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, uint>)(lpVtbl[1]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, uint>)(lpVtbl[2]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, uint>)(lpVtbl[2]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetScaleX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetScaleX(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetScaleX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetScaleX(float scaleX)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[4]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleX);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[4]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleX);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetScaleY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetScaleY(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetScaleY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetScaleY(float scaleY)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[6]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleY);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[6]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleY);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetScaleZ"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetScaleZ(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetScaleZ"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetScaleZ(float scaleZ)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[8]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleZ);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[8]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), scaleZ);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetCenterX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetCenterX(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetCenterX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetCenterX(float centerX)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[10]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerX);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[10]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerX);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetCenterY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SetCenterY(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetCenterY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetCenterY(float centerY)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[12]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerY);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[12]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerY);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetCenterZ"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult SetCenterZ(IDCompositionAnimation* animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform3D::SetCenterZ"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetCenterZ(float centerZ)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[14]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerZ);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform3D*, float, int>)(lpVtbl[14]))((IDCompositionScaleTransform3D*)Unsafe.AsPointer(ref this), centerZ);
#endif
	}

	public interface Interface : IDCompositionTransform3D.Interface
	{
		[VtblIndex(3)]
		HResult SetScaleX(IDCompositionAnimation* animation);

		[VtblIndex(4)]
		HResult SetScaleX(float scaleX);

		[VtblIndex(5)]
		HResult SetScaleY(IDCompositionAnimation* animation);

		[VtblIndex(6)]
		HResult SetScaleY(float scaleY);

		[VtblIndex(7)]
		HResult SetScaleZ(IDCompositionAnimation* animation);

		[VtblIndex(8)]
		HResult SetScaleZ(float scaleZ);

		[VtblIndex(9)]
		HResult SetCenterX(IDCompositionAnimation* animation);

		[VtblIndex(10)]
		HResult SetCenterX(float centerX);

		[VtblIndex(11)]
		HResult SetCenterY(IDCompositionAnimation* animation);

		[VtblIndex(12)]
		HResult SetCenterY(float centerY);

		[VtblIndex(13)]
		HResult SetCenterZ(IDCompositionAnimation* animation);

		[VtblIndex(14)]
		HResult SetCenterZ(float centerZ);
	}
}

