// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap"]/*' />
/// <unmanaged>ID2D1Bitmap</unmanaged>
[Guid("a2296057-ea42-4099-983b-539fb6505426")]
[NativeTypeName("struct ID2D1Bitmap : ID2D1Image")]
[NativeInheritance("ID2D1Image")]
public unsafe partial struct ID2D1Bitmap : ID2D1Bitmap.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1Bitmap
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x57, 0x60, 0x29, 0xA2,
				0x42, 0xEA,
				0x99, 0x40,
				0x98,
				0x3B,
				0x53,
				0x9F,
				0xB6,
				0x50,
				0x54,
				0x26
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Bitmap));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Bitmap));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Bitmap*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Bitmap*, uint>)(lpVtbl[1]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, uint>)(lpVtbl[1]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Bitmap*, uint>)(lpVtbl[2]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, uint>)(lpVtbl[2]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1Bitmap*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), factory);
#else
		((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), factory);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap::GetSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public System.Drawing.SizeF GetSize()
	{
		System.Drawing.SizeF result;
#if NET6_0_OR_GREATER
		return *((delegate* unmanaged<ID2D1Bitmap*, System.Drawing.SizeF*, System.Drawing.SizeF*>)(lpVtbl[4]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
#else
		return *((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, System.Drawing.SizeF*, System.Drawing.SizeF*>)(lpVtbl[4]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap::GetPixelSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public System.Drawing.Size GetPixelSize()
	{
		System.Drawing.Size result;
#if NET6_0_OR_GREATER
		return *((delegate* unmanaged<ID2D1Bitmap*, System.Drawing.Size*, System.Drawing.Size*>)(lpVtbl[5]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
#else
		return *((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, System.Drawing.Size*, System.Drawing.Size*>)(lpVtbl[5]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap::GetPixelFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public Common.PixelFormat GetPixelFormat()
	{
		Common.PixelFormat result;
#if NET6_0_OR_GREATER
		return *((delegate* unmanaged<ID2D1Bitmap*, Common.PixelFormat*, Common.PixelFormat*>)(lpVtbl[6]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
#else
		return *((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Common.PixelFormat*, Common.PixelFormat*>)(lpVtbl[6]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), &result);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap::GetDpi"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetDpi(float* dpiX, float* dpiY)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID2D1Bitmap*, float*, float*, void>)(lpVtbl[7]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), dpiX, dpiY);
#else
		((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, float*, float*, void>)(lpVtbl[7]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), dpiX, dpiY);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap::CopyFromBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CopyFromBitmap(System.Drawing.Point* destPoint, ID2D1Bitmap* bitmap, Win32.Numerics.Rect* srcRect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Bitmap*, System.Drawing.Point*, ID2D1Bitmap*, Win32.Numerics.Rect*, int>)(lpVtbl[8]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), destPoint, bitmap, srcRect);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, System.Drawing.Point*, ID2D1Bitmap*, Win32.Numerics.Rect*, int>)(lpVtbl[8]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), destPoint, bitmap, srcRect);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap::CopyFromRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CopyFromRenderTarget(System.Drawing.Point* destPoint, ID2D1RenderTarget* renderTarget, Win32.Numerics.Rect* srcRect)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Bitmap*, System.Drawing.Point*, ID2D1RenderTarget*, Win32.Numerics.Rect*, int>)(lpVtbl[9]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), destPoint, renderTarget, srcRect);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, System.Drawing.Point*, ID2D1RenderTarget*, Win32.Numerics.Rect*, int>)(lpVtbl[9]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), destPoint, renderTarget, srcRect);
#endif
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Bitmap::CopyFromMemory"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CopyFromMemory(Win32.Numerics.Rect* dstRect, void* srcData, uint pitch)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID2D1Bitmap*, Win32.Numerics.Rect*, void*, uint, int>)(lpVtbl[10]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), dstRect, srcData, pitch);
#else
		return ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Win32.Numerics.Rect*, void*, uint, int>)(lpVtbl[10]))((ID2D1Bitmap*)Unsafe.AsPointer(ref this), dstRect, srcData, pitch);
#endif
	}

	public interface Interface : ID2D1Image.Interface
	{
		[VtblIndex(4)]
		System.Drawing.SizeF GetSize();

		[VtblIndex(5)]
		System.Drawing.Size GetPixelSize();

		[VtblIndex(6)]
		Common.PixelFormat GetPixelFormat();

		[VtblIndex(7)]
		void GetDpi(float* dpiX, float* dpiY);

		[VtblIndex(8)]
		HResult CopyFromBitmap(System.Drawing.Point* destPoint, ID2D1Bitmap* bitmap, Win32.Numerics.Rect* srcRect);

		[VtblIndex(9)]
		HResult CopyFromRenderTarget(System.Drawing.Point* destPoint, ID2D1RenderTarget* renderTarget, Win32.Numerics.Rect* srcRect);

		[VtblIndex(10)]
		HResult CopyFromMemory(Win32.Numerics.Rect* dstRect, void* srcData, uint pitch);
	}
}

