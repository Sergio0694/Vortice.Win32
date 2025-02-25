// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice"]/*' />
/// <unmanaged>IDCompositionDevice</unmanaged>
[Guid("c37ea93a-e7aa-450d-b16f-9746cb0407f3")]
[NativeTypeName("struct IDCompositionDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionDevice : IDCompositionDevice.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionDevice
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x3A, 0xA9, 0x7E, 0xC3,
				0xAA, 0xE7,
				0x0D, 0x45,
				0xB1,
				0x6F,
				0x97,
				0x46,
				0xCB,
				0x04,
				0x07,
				0xF3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDevice));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDevice));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, uint>)(lpVtbl[1]))((IDCompositionDevice*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint>)(lpVtbl[1]))((IDCompositionDevice*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, uint>)(lpVtbl[2]))((IDCompositionDevice*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint>)(lpVtbl[2]))((IDCompositionDevice*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::Commit"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Commit()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, int>)(lpVtbl[3]))((IDCompositionDevice*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int>)(lpVtbl[3]))((IDCompositionDevice*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::WaitForCommitCompletion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult WaitForCommitCompletion()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, int>)(lpVtbl[4]))((IDCompositionDevice*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int>)(lpVtbl[4]))((IDCompositionDevice*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::GetFrameStatistics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetFrameStatistics(FrameStatistics* statistics)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, FrameStatistics*, int>)(lpVtbl[5]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), statistics);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, FrameStatistics*, int>)(lpVtbl[5]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), statistics);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateTargetForHwnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateTargetForHwnd(nint hwnd, Bool32 topmost, IDCompositionTarget** target)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, nint, Bool32, IDCompositionTarget**, int>)(lpVtbl[6]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), hwnd, topmost, target);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, Bool32, IDCompositionTarget**, int>)(lpVtbl[6]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), hwnd, topmost, target);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateVisual"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateVisual(IDCompositionVisual** visual)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionVisual**, int>)(lpVtbl[7]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), visual);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionVisual**, int>)(lpVtbl[7]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), visual);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateSurface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSurface(uint width, uint height, Graphics.Dxgi.Common.Format pixelFormat, Graphics.Dxgi.Common.AlphaMode alphaMode, IDCompositionSurface** surface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateVirtualSurface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateVirtualSurface(uint initialWidth, uint initialHeight, Graphics.Dxgi.Common.Format pixelFormat, Graphics.Dxgi.Common.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateSurfaceFromHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateSurfaceFromHandle(Handle handle, IUnknown** surface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, Handle, IUnknown**, int>)(lpVtbl[10]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), handle, surface);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Handle, IUnknown**, int>)(lpVtbl[10]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), handle, surface);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateSurfaceFromHwnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateSurfaceFromHwnd(nint hwnd, IUnknown** surface)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, nint, IUnknown**, int>)(lpVtbl[11]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), hwnd, surface);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, IUnknown**, int>)(lpVtbl[11]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), hwnd, surface);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateTranslateTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionTranslateTransform**, int>)(lpVtbl[12]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), translateTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform**, int>)(lpVtbl[12]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), translateTransform);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateScaleTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionScaleTransform**, int>)(lpVtbl[13]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), scaleTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform**, int>)(lpVtbl[13]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), scaleTransform);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateRotateTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionRotateTransform**, int>)(lpVtbl[14]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), rotateTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform**, int>)(lpVtbl[14]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), rotateTransform);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateSkewTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionSkewTransform**, int>)(lpVtbl[15]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), skewTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionSkewTransform**, int>)(lpVtbl[15]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), skewTransform);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateMatrixTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionMatrixTransform**, int>)(lpVtbl[16]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), matrixTransform);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform**, int>)(lpVtbl[16]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), matrixTransform);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateTransformGroup"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[17]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[17]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateTranslateTransform3D"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), translateTransform3D);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), translateTransform3D);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateScaleTransform3D"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionScaleTransform3D**, int>)(lpVtbl[19]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), scaleTransform3D);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform3D**, int>)(lpVtbl[19]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), scaleTransform3D);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateRotateTransform3D"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionRotateTransform3D**, int>)(lpVtbl[20]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), rotateTransform3D);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform3D**, int>)(lpVtbl[20]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), rotateTransform3D);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateMatrixTransform3D"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[21]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), matrixTransform3D);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[21]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), matrixTransform3D);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateTransform3DGroup"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[22]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[22]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateEffectGroup"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionEffectGroup**, int>)(lpVtbl[23]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), effectGroup);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionEffectGroup**, int>)(lpVtbl[23]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), effectGroup);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateRectangleClip"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateRectangleClip(IDCompositionRectangleClip** clip)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionRectangleClip**, int>)(lpVtbl[24]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), clip);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRectangleClip**, int>)(lpVtbl[24]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), clip);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CreateAnimation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateAnimation(IDCompositionAnimation** animation)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, IDCompositionAnimation**, int>)(lpVtbl[25]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), animation);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionAnimation**, int>)(lpVtbl[25]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), animation);
#endif
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDevice::CheckDeviceState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult CheckDeviceState(Bool32* pfValid)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDCompositionDevice*, Bool32*, int>)(lpVtbl[26]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), pfValid);
#else
		return ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Bool32*, int>)(lpVtbl[26]))((IDCompositionDevice*)Unsafe.AsPointer(ref this), pfValid);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult Commit();

		[VtblIndex(4)]
		HResult WaitForCommitCompletion();

		[VtblIndex(5)]
		HResult GetFrameStatistics(FrameStatistics* statistics);

		[VtblIndex(6)]
		HResult CreateTargetForHwnd(nint hwnd, Bool32 topmost, IDCompositionTarget** target);

		[VtblIndex(7)]
		HResult CreateVisual(IDCompositionVisual** visual);

		[VtblIndex(8)]
		HResult CreateSurface(uint width, uint height, Graphics.Dxgi.Common.Format pixelFormat, Graphics.Dxgi.Common.AlphaMode alphaMode, IDCompositionSurface** surface);

		[VtblIndex(9)]
		HResult CreateVirtualSurface(uint initialWidth, uint initialHeight, Graphics.Dxgi.Common.Format pixelFormat, Graphics.Dxgi.Common.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface);

		[VtblIndex(10)]
		HResult CreateSurfaceFromHandle(Handle handle, IUnknown** surface);

		[VtblIndex(11)]
		HResult CreateSurfaceFromHwnd(nint hwnd, IUnknown** surface);

		[VtblIndex(12)]
		HResult CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform);

		[VtblIndex(13)]
		HResult CreateScaleTransform(IDCompositionScaleTransform** scaleTransform);

		[VtblIndex(14)]
		HResult CreateRotateTransform(IDCompositionRotateTransform** rotateTransform);

		[VtblIndex(15)]
		HResult CreateSkewTransform(IDCompositionSkewTransform** skewTransform);

		[VtblIndex(16)]
		HResult CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform);

		[VtblIndex(17)]
		HResult CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup);

		[VtblIndex(18)]
		HResult CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D);

		[VtblIndex(19)]
		HResult CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D);

		[VtblIndex(20)]
		HResult CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D);

		[VtblIndex(21)]
		HResult CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D);

		[VtblIndex(22)]
		HResult CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup);

		[VtblIndex(23)]
		HResult CreateEffectGroup(IDCompositionEffectGroup** effectGroup);

		[VtblIndex(24)]
		HResult CreateRectangleClip(IDCompositionRectangleClip** clip);

		[VtblIndex(25)]
		HResult CreateAnimation(IDCompositionAnimation** animation);

		[VtblIndex(26)]
		HResult CheckDeviceState(Bool32* pfValid);
	}
}

