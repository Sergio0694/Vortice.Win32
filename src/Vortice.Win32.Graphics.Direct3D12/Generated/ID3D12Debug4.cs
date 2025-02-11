// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Debug4"]/*' />
/// <unmanaged>ID3D12Debug4</unmanaged>
[Guid("014b816e-9ec5-4a2f-a845-ffbe441ce13a")]
[NativeTypeName("struct ID3D12Debug4 : ID3D12Debug3")]
[NativeInheritance("ID3D12Debug3")]
public unsafe partial struct ID3D12Debug4 : ID3D12Debug4.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12Debug4
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x6E, 0x81, 0x4B, 0x01,
				0xC5, 0x9E,
				0x2F, 0x4A,
				0xA8,
				0x45,
				0xFF,
				0xBE,
				0x44,
				0x1C,
				0xE1,
				0x3A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug4));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug4));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Debug4*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Debug4*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Debug4*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Debug4*, uint>)(lpVtbl[1]))((ID3D12Debug4*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, uint>)(lpVtbl[1]))((ID3D12Debug4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12Debug4*, uint>)(lpVtbl[2]))((ID3D12Debug4*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12Debug4*, uint>)(lpVtbl[2]))((ID3D12Debug4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D12Debug.EnableDebugLayer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void EnableDebugLayer()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12Debug4*, void>)(lpVtbl[3]))((ID3D12Debug4*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<ID3D12Debug4*, void>)(lpVtbl[3]))((ID3D12Debug4*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D12Debug3.SetEnableGPUBasedValidation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetEnableGPUBasedValidation(Bool32 Enable)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12Debug4*, Bool32, void>)(lpVtbl[4]))((ID3D12Debug4*)Unsafe.AsPointer(ref this), Enable);
#else
		((delegate* unmanaged[Stdcall]<ID3D12Debug4*, Bool32, void>)(lpVtbl[4]))((ID3D12Debug4*)Unsafe.AsPointer(ref this), Enable);
#endif
	}

	/// <inheritdoc cref="ID3D12Debug3.SetEnableSynchronizedCommandQueueValidation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetEnableSynchronizedCommandQueueValidation(Bool32 Enable)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12Debug4*, Bool32, void>)(lpVtbl[5]))((ID3D12Debug4*)Unsafe.AsPointer(ref this), Enable);
#else
		((delegate* unmanaged[Stdcall]<ID3D12Debug4*, Bool32, void>)(lpVtbl[5]))((ID3D12Debug4*)Unsafe.AsPointer(ref this), Enable);
#endif
	}

	/// <inheritdoc cref="ID3D12Debug3.SetGPUBasedValidationFlags" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetGPUBasedValidationFlags(GpuBasedValidationFlags Flags)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12Debug4*, GpuBasedValidationFlags, void>)(lpVtbl[6]))((ID3D12Debug4*)Unsafe.AsPointer(ref this), Flags);
#else
		((delegate* unmanaged[Stdcall]<ID3D12Debug4*, GpuBasedValidationFlags, void>)(lpVtbl[6]))((ID3D12Debug4*)Unsafe.AsPointer(ref this), Flags);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Debug4::DisableDebugLayer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void DisableDebugLayer()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12Debug4*, void>)(lpVtbl[7]))((ID3D12Debug4*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<ID3D12Debug4*, void>)(lpVtbl[7]))((ID3D12Debug4*)Unsafe.AsPointer(ref this));
#endif
	}

	public interface Interface : ID3D12Debug3.Interface
	{
		[VtblIndex(7)]
		void DisableDebugLayer();
	}
}

