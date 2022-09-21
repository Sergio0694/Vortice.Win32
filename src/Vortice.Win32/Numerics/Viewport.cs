﻿// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

#if NET6_0_OR_GREATER
using System.Runtime.Intrinsics;
using static Win32.Numerics.VectorUtilities;
#endif

namespace Win32.Numerics;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public readonly struct Viewport : IEquatable<Viewport>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Viewport"/> struct.
    /// </summary>
    /// <param name="width">The width of the viewport in pixels.</param>
    /// <param name="height">The height of the viewport in pixels.</param>
    public Viewport(float width, float height)
    {
        X = 0.0f;
        Y = 0.0f;
        Width = width;
        Height = height;
        MinDepth = 0.0f;
        MaxDepth = 1.0f;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Viewport"/> struct.
    /// </summary>
    /// <param name="x">The x coordinate of the upper-left corner of the viewport in pixels.</param>
    /// <param name="y">The y coordinate of the upper-left corner of the viewport in pixels.</param>
    /// <param name="width">The width of the viewport in pixels.</param>
    /// <param name="height">The height of the viewport in pixels.</param>
    public Viewport(float x, float y, float width, float height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        MinDepth = 0.0f;
        MaxDepth = 1.0f;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Viewport"/> struct.
    /// </summary>
    /// <param name="x">The x coordinate of the upper-left corner of the viewport in pixels.</param>
    /// <param name="y">The y coordinate of the upper-left corner of the viewport in pixels.</param>
    /// <param name="width">The width of the viewport in pixels.</param>
    /// <param name="height">The height of the viewport in pixels.</param>
    /// <param name="minDepth">The minimum depth of the clip volume.</param>
    /// <param name="maxDepth">The maximum depth of the clip volume.</param>
    public Viewport(float x, float y, float width, float height, float minDepth, float maxDepth)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        MinDepth = minDepth;
        MaxDepth = maxDepth;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Viewport"/> struct.
    /// </summary>
    /// <param name="bounds">A <see cref="RectangleF"/> that defines the location and size of the viewport in a render target.</param>
    public Viewport(in RectangleF bounds)
    {
        X = bounds.X;
        Y = bounds.Y;
        Width = bounds.Width;
        Height = bounds.Height;
        MinDepth = 0.0f;
        MaxDepth = 1.0f;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Viewport"/> struct.
    /// </summary>
    /// <param name="bounds">A <see cref="Rectangle"/> that defines the location and size of the viewport in a render target.</param>
    public Viewport(in Rectangle bounds)
    {
        X = bounds.X;
        Y = bounds.Y;
        Width = bounds.Width;
        Height = bounds.Height;
        MinDepth = 0.0f;
        MaxDepth = 1.0f;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Viewport"/> struct.
    /// </summary>
    /// <param name="bounds">A <see cref="Vector4"/> that defines the location and size of the viewport in a render target.</param>
    public Viewport(in Vector4 bounds)
    {
        X = bounds.X;
        Y = bounds.Y;
        Width = bounds.Z;
        Height = bounds.W;
        MinDepth = 0.0f;
        MaxDepth = 1.0f;
    }

    /// <summary>
    /// Position of the pixel coordinate of the upper-left corner of the viewport.
    /// </summary>
    public float X { get; }

    /// <summary>
    /// Position of the pixel coordinate of the upper-left corner of the viewport.
    /// </summary>
    public float Y { get; }

    /// <summary>
    /// Width dimension of the viewport.
    /// </summary>
    public float Width { get; }

    /// <summary>
    /// Height dimension of the viewport.
    /// </summary>
    public float Height { get; }

    /// <summary>
    /// Gets or sets the minimum depth of the clip volume.
    /// </summary>
    public float MinDepth { get; }

    /// <summary>
    /// Gets or sets the maximum depth of the clip volume.
    /// </summary>
    public float MaxDepth { get; }

    /// <summary>
    /// Gets or sets the bounds of the viewport.
    /// </summary>
    /// <value>The bounds.</value>
    public RectangleF Bounds => new(X, Y, Width, Height);

    /// <summary>
    /// Gets the aspect ratio used by the viewport.
    /// </summary>
    /// <value>The aspect ratio.</value>
    public readonly float AspectRatio
    {
        get
        {
            if (Width == 0.0f || Height == 0.0f)
                return 0.0f;

            return Width / Height;
        }
    }
    /// <summary>
    /// Compares two <see cref="Viewport"/> objects for equality.
    /// </summary>
    /// <param name="left">The <see cref="Viewport"/> on the left hand of the operand.</param>
    /// <param name="right">The <see cref="Viewport"/> on the right hand of the operand.</param>
    /// <returns>
    /// True if the current left is equal to the <paramref name="right"/> parameter; otherwise, false.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Viewport left, Viewport right) => left.Equals(right);

    /// <summary>
    /// Compares two <see cref="Viewport"/> objects for inequality.
    /// </summary>
    /// <param name="left">The <see cref="Viewport"/> on the left hand of the operand.</param>
    /// <param name="right">The <see cref="Viewport"/> on the right hand of the operand.</param>
    /// <returns>
    /// True if the current left is unequal to the <paramref name="right"/> parameter; otherwise, false.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Viewport left, Viewport right) => !left.Equals(right);

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is Viewport other && Equals(other);

    /// <summary>
    /// Determines whether the specified <see cref="Viewport"/> is equal to this instance.
    /// </summary>
    /// <param name="other">The <see cref="Viewport"/> to compare with this instance.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Viewport other)
    {
        return
            X == other.X &&
            Y == other.Y &&
            Width == other.Width &&
            Height == other.Height &&
            MinDepth == other.MinDepth &&
            MaxDepth == other.MaxDepth;
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(X);
            hashCode.Add(Y);
            hashCode.Add(Width);
            hashCode.Add(Height);
            hashCode.Add(MinDepth);
            hashCode.Add(MaxDepth);
        }
        return hashCode.ToHashCode();
    }

    /// <inheritdoc />
    public override string ToString() => ToString(format: null, formatProvider: null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        var separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

        return new StringBuilder(9 + (separator.Length * 3))
            .Append('<')
            .Append(X.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(Y.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(Width.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(Height.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(MinDepth.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(MaxDepth.ToString(format, formatProvider))
            .Append(' ')
            .Append('>')
            .ToString();
    }

    internal const int Count = 4;

    internal static float GetElement(Color4 vector, int index)
    {
        if (index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return GetElementUnsafe(ref vector, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float GetElementUnsafe(ref Color4 vector, int index)
    {
        Debug.Assert(index is >= 0 and < Count);

        return Unsafe.Add(ref Unsafe.As<Color4, float>(ref vector), index);
    }
}
