﻿// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.


using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Win32;

public static unsafe partial class Apis
{
    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <param name="value">A value of type <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref="UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref="Guid"/> pointer, or implicitly assigned to a <see cref="Guid"/> value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe UuidOfType __uuidof<T>(T value) // for type inference similar to C++'s __uuidof
        where T : unmanaged
    {
        return new UuidOfType(UUID<T>.RIID);
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <param name="value">A pointer to a value of type <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref="UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref="Guid"/> pointer, or implicitly assigned to a <see cref="Guid"/> value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe UuidOfType __uuidof<T>(T* value) // for type inference similar to C++'s __uuidof
        where T : unmanaged
    {
        return new UuidOfType(UUID<T>.RIID);
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <typeparam name="T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref="UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref="Guid"/> pointer, or implicitly assigned to a <see cref="Guid"/> value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe UuidOfType __uuidof<T>()
        where T : unmanaged
    {
        return new UuidOfType(UUID<T>.RIID);
    }

    /// <summary>A proxy type that wraps a pointer to GUID data. Values of this type can be implicitly converted to and assigned to <see cref="Guid"/>* or <see cref="Guid"/> parameters.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public readonly unsafe ref struct UuidOfType
    {
        private readonly Guid* riid;

        internal UuidOfType(Guid* riid)
        {
            this.riid = riid;
        }

        /// <summary>Reads a <see cref="Guid"/> value from the GUID buffer for a given <see cref="UuidOfType"/> instance.</summary>
        /// <param name="guid">The input <see cref="UuidOfType"/> instance to read data for.</param>
        public static implicit operator Guid(UuidOfType guid) => *guid.riid;

        /// <summary>Returns the <see cref="Guid"/>* pointer to the GUID buffer for a given <see cref="UuidOfType"/> instance.</summary>
        /// <param name="guid">The input <see cref="UuidOfType"/> instance to read data for.</param>
        public static implicit operator Guid*(UuidOfType guid) => guid.riid;
    }

    /// <summary>A helper type to provide static GUID buffers for specific types.</summary>
    /// <typeparam name="T">The type to allocate a GUID buffer for.</typeparam>
    private static unsafe class UUID<T>
        where T : unmanaged
    {
        /// <summary>The pointer to the <see cref="Guid"/> value for the current type.</summary>
        /// <remarks>The target memory area should never be written to.</remarks>
        public static readonly Guid* RIID = CreateRIID();

        /// <summary>Allocates memory for a <see cref="Guid"/> value and initializes it.</summary>
        /// <returns>A pointer to memory holding the <see cref="Guid"/> value for the current type.</returns>
        private static Guid* CreateRIID()
        {
#if NET6_0_OR_GREATER
            var p = (Guid*)RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(T), sizeof(Guid));
#else
            var p = (Guid*)Marshal.AllocHGlobal(sizeof(Guid));
#endif
            *p = typeof(T).GUID;
            return p;
        }
    }

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HResult CoCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
}
