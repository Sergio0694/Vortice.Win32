// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICPersistStream"]/*' />
/// <unmanaged>IWICPersistStream</unmanaged>
[Guid("00675040-6908-45f8-86a3-49c7dfd6d9ad")]
[NativeTypeName("struct IWICPersistStream : IPersistStream")]
[NativeInheritance("IPersistStream")]
public unsafe partial struct IWICPersistStream : IWICPersistStream.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICPersistStream
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x40, 0x50, 0x67, 0x00,
				0x08, 0x69,
				0xF8, 0x45,
				0x86,
				0xA3,
				0x49,
				0xC7,
				0xDF,
				0xD6,
				0xD9,
				0xAD
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPersistStream));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPersistStream));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICPersistStream*, Guid*, void**, int>)(lpVtbl[0]))((IWICPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Guid*, void**, int>)(lpVtbl[0]))((IWICPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICPersistStream*, uint>)(lpVtbl[1]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, uint>)(lpVtbl[1]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICPersistStream*, uint>)(lpVtbl[2]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, uint>)(lpVtbl[2]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICPersistStream::LoadEx"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult LoadEx(Com.IStream* pIStream, Guid* pguidPreferredVendor, WICPersistOptions dwPersistOptions)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICPersistStream*, Com.IStream*, Guid*, WICPersistOptions, int>)(lpVtbl[8]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, pguidPreferredVendor, dwPersistOptions);
#else
		return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Com.IStream*, Guid*, WICPersistOptions, int>)(lpVtbl[8]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, pguidPreferredVendor, dwPersistOptions);
#endif
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICPersistStream::SaveEx"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SaveEx(Com.IStream* pIStream, WICPersistOptions dwPersistOptions, Bool32 fClearDirty)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IWICPersistStream*, Com.IStream*, WICPersistOptions, Bool32, int>)(lpVtbl[9]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, dwPersistOptions, fClearDirty);
#else
		return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Com.IStream*, WICPersistOptions, Bool32, int>)(lpVtbl[9]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, dwPersistOptions, fClearDirty);
#endif
	}

	public interface Interface : Win32.Com.IPersistStream.Interface
	{
		[VtblIndex(8)]
		HResult LoadEx(Com.IStream* pIStream, Guid* pguidPreferredVendor, WICPersistOptions dwPersistOptions);

		[VtblIndex(9)]
		HResult SaveEx(Com.IStream* pIStream, WICPersistOptions dwPersistOptions, Bool32 fClearDirty);
	}
}

