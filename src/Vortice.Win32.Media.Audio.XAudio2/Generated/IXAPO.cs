// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Media.Audio.XAudio2;

/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO"]/*' />
/// <unmanaged>IXAPO</unmanaged>
[Guid("a410b984-9839-4819-a0be-2856ae6b3adb")]
[NativeTypeName("struct IXAPO : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXAPO : IXAPO.Interface, INativeGuid
{
	public static ref readonly Guid IID_IXAPO
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x84, 0xB9, 0x10, 0xA4,
				0x39, 0x98,
				0x19, 0x48,
				0xA0,
				0xBE,
				0x28,
				0x56,
				0xAE,
				0x6B,
				0x3A,
				0xDB
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXAPO));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXAPO));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, Guid*, void**, int>)(lpVtbl[0]))((IXAPO*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, Guid*, void**, int>)(lpVtbl[0]))((IXAPO*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, uint>)(lpVtbl[1]))((IXAPO*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, uint>)(lpVtbl[1]))((IXAPO*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, uint>)(lpVtbl[2]))((IXAPO*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, uint>)(lpVtbl[2]))((IXAPO*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::GetRegistrationProperties"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetRegistrationProperties(XAPORegistrationProperties** ppRegistrationProperties)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, XAPORegistrationProperties**, int>)(lpVtbl[3]))((IXAPO*)Unsafe.AsPointer(ref this), ppRegistrationProperties);
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, XAPORegistrationProperties**, int>)(lpVtbl[3]))((IXAPO*)Unsafe.AsPointer(ref this), ppRegistrationProperties);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::IsInputFormatSupported"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult IsInputFormatSupported(Media.Audio.WaveFormatEx* pOutputFormat, Media.Audio.WaveFormatEx* pRequestedInputFormat, Media.Audio.WaveFormatEx** ppSupportedInputFormat)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, Media.Audio.WaveFormatEx*, Media.Audio.WaveFormatEx*, Media.Audio.WaveFormatEx**, int>)(lpVtbl[4]))((IXAPO*)Unsafe.AsPointer(ref this), pOutputFormat, pRequestedInputFormat, ppSupportedInputFormat);
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, Media.Audio.WaveFormatEx*, Media.Audio.WaveFormatEx*, Media.Audio.WaveFormatEx**, int>)(lpVtbl[4]))((IXAPO*)Unsafe.AsPointer(ref this), pOutputFormat, pRequestedInputFormat, ppSupportedInputFormat);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::IsOutputFormatSupported"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult IsOutputFormatSupported(Media.Audio.WaveFormatEx* pInputFormat, Media.Audio.WaveFormatEx* pRequestedOutputFormat, Media.Audio.WaveFormatEx** ppSupportedOutputFormat)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, Media.Audio.WaveFormatEx*, Media.Audio.WaveFormatEx*, Media.Audio.WaveFormatEx**, int>)(lpVtbl[5]))((IXAPO*)Unsafe.AsPointer(ref this), pInputFormat, pRequestedOutputFormat, ppSupportedOutputFormat);
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, Media.Audio.WaveFormatEx*, Media.Audio.WaveFormatEx*, Media.Audio.WaveFormatEx**, int>)(lpVtbl[5]))((IXAPO*)Unsafe.AsPointer(ref this), pInputFormat, pRequestedOutputFormat, ppSupportedOutputFormat);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::Initialize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult Initialize(void* pData, uint DataByteSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, void*, uint, int>)(lpVtbl[6]))((IXAPO*)Unsafe.AsPointer(ref this), pData, DataByteSize);
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, void*, uint, int>)(lpVtbl[6]))((IXAPO*)Unsafe.AsPointer(ref this), pData, DataByteSize);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::Reset"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void Reset()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IXAPO*, void>)(lpVtbl[7]))((IXAPO*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<IXAPO*, void>)(lpVtbl[7]))((IXAPO*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::LockForProcess"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult LockForProcess(uint InputLockedParameterCount, XAPOLockForProcessParameters* pInputLockedParameters, uint OutputLockedParameterCount, XAPOLockForProcessParameters* pOutputLockedParameters)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, uint, XAPOLockForProcessParameters*, uint, XAPOLockForProcessParameters*, int>)(lpVtbl[8]))((IXAPO*)Unsafe.AsPointer(ref this), InputLockedParameterCount, pInputLockedParameters, OutputLockedParameterCount, pOutputLockedParameters);
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, uint, XAPOLockForProcessParameters*, uint, XAPOLockForProcessParameters*, int>)(lpVtbl[8]))((IXAPO*)Unsafe.AsPointer(ref this), InputLockedParameterCount, pInputLockedParameters, OutputLockedParameterCount, pOutputLockedParameters);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::UnlockForProcess"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void UnlockForProcess()
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IXAPO*, void>)(lpVtbl[9]))((IXAPO*)Unsafe.AsPointer(ref this));
#else
		((delegate* unmanaged[Stdcall]<IXAPO*, void>)(lpVtbl[9]))((IXAPO*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::Process"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void Process(uint InputProcessParameterCount, XAPOProcessBufferParameters* pInputProcessParameters, uint OutputProcessParameterCount, XAPOProcessBufferParameters* pOutputProcessParameters, Bool32 IsEnabled)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<IXAPO*, uint, XAPOProcessBufferParameters*, uint, XAPOProcessBufferParameters*, Bool32, void>)(lpVtbl[10]))((IXAPO*)Unsafe.AsPointer(ref this), InputProcessParameterCount, pInputProcessParameters, OutputProcessParameterCount, pOutputProcessParameters, IsEnabled);
#else
		((delegate* unmanaged[Stdcall]<IXAPO*, uint, XAPOProcessBufferParameters*, uint, XAPOProcessBufferParameters*, Bool32, void>)(lpVtbl[10]))((IXAPO*)Unsafe.AsPointer(ref this), InputProcessParameterCount, pInputProcessParameters, OutputProcessParameterCount, pOutputProcessParameters, IsEnabled);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::CalcInputFrames"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public uint CalcInputFrames(uint OutputFrameCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, uint, uint>)(lpVtbl[11]))((IXAPO*)Unsafe.AsPointer(ref this), OutputFrameCount);
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, uint, uint>)(lpVtbl[11]))((IXAPO*)Unsafe.AsPointer(ref this), OutputFrameCount);
#endif
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAPO::CalcOutputFrames"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public uint CalcOutputFrames(uint InputFrameCount)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<IXAPO*, uint, uint>)(lpVtbl[12]))((IXAPO*)Unsafe.AsPointer(ref this), InputFrameCount);
#else
		return ((delegate* unmanaged[Stdcall]<IXAPO*, uint, uint>)(lpVtbl[12]))((IXAPO*)Unsafe.AsPointer(ref this), InputFrameCount);
#endif
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetRegistrationProperties(XAPORegistrationProperties** ppRegistrationProperties);

		[VtblIndex(4)]
		HResult IsInputFormatSupported(Media.Audio.WaveFormatEx* pOutputFormat, Media.Audio.WaveFormatEx* pRequestedInputFormat, Media.Audio.WaveFormatEx** ppSupportedInputFormat);

		[VtblIndex(5)]
		HResult IsOutputFormatSupported(Media.Audio.WaveFormatEx* pInputFormat, Media.Audio.WaveFormatEx* pRequestedOutputFormat, Media.Audio.WaveFormatEx** ppSupportedOutputFormat);

		[VtblIndex(6)]
		HResult Initialize(void* pData, uint DataByteSize);

		[VtblIndex(7)]
		void Reset();

		[VtblIndex(8)]
		HResult LockForProcess(uint InputLockedParameterCount, XAPOLockForProcessParameters* pInputLockedParameters, uint OutputLockedParameterCount, XAPOLockForProcessParameters* pOutputLockedParameters);

		[VtblIndex(9)]
		void UnlockForProcess();

		[VtblIndex(10)]
		void Process(uint InputProcessParameterCount, XAPOProcessBufferParameters* pInputProcessParameters, uint OutputProcessParameterCount, XAPOProcessBufferParameters* pOutputProcessParameters, Bool32 IsEnabled);

		[VtblIndex(11)]
		uint CalcInputFrames(uint OutputFrameCount);

		[VtblIndex(12)]
		uint CalcOutputFrames(uint InputFrameCount);
	}
}

