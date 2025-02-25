// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDisplayControl"]/*' />
/// <unmanaged>IDXGIDisplayControl</unmanaged>
[Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c")]
[NativeTypeName("struct IDXGIDisplayControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGIDisplayControl : IDXGIDisplayControl.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIDisplayControl
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x1A, 0xBF, 0x9D, 0xEA,
				0x8E, 0xC8,
				0x86, 0x44,
				0x85,
				0x4A,
				0x98,
				0xAA,
				0x01,
				0x38,
				0xF3,
				0x0C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDisplayControl));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDisplayControl));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDisplayControl*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDisplayControl*, uint>)(lpVtbl[1]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, uint>)(lpVtbl[1]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDisplayControl*, uint>)(lpVtbl[2]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, uint>)(lpVtbl[2]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDisplayControl::IsStereoEnabled"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public Bool32 IsStereoEnabled()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IDXGIDisplayControl*, Bool32>)(lpVtbl[3]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, Bool32>)(lpVtbl[3]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDisplayControl::SetStereoEnabled"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetStereoEnabled(Bool32 enabled)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IDXGIDisplayControl*, Bool32, void>)(lpVtbl[4]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), enabled);
#else
		((delegate* unmanaged[Stdcall]<IDXGIDisplayControl*, Bool32, void>)(lpVtbl[4]))((IDXGIDisplayControl*)Unsafe.AsPointer(ref this), enabled);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		Bool32 IsStereoEnabled();

		[VtblIndex(4)]
		void SetStereoEnabled(Bool32 enabled);
	}
}

