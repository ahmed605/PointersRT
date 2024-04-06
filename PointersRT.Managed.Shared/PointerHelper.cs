using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace PointersRT
{
    public static class PointerHelper
    {
        public static unsafe Pointer GetPointer(void* pointer) => new() { Value = (ulong)pointer };

        public static unsafe LongPointer GetPointer(void** pointer) => new() { Value = (ulong)pointer };

        public static unsafe Pointer GetPointer(nint pointer) => new() { Value = (ulong)pointer };

        public static unsafe Pointer GetPointer<T>(T* pointer) where T : unmanaged => new() { Value = (ulong)pointer };

        public static unsafe LongPointer GetPointer<T>(T** pointer) where T : unmanaged => new() { Value = (ulong)pointer };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Pointer GetPointer<T>(ref T pointer) where T : unmanaged => GetPointer(Unsafe.AsPointer(ref pointer));

        public static unsafe void* GetPointer(Pointer pointer) => (void*)pointer.Value;

        public static unsafe void** GetPointer(LongPointer pointer) => (void**)pointer.Value;

        public static unsafe void* GetPointer(TypedPointer pointer) => (void*)pointer.Value;

        public static unsafe void** GetPointer(TypedLongPointer pointer) => (void**)pointer.Value;

        public static unsafe T* GetPointer<T>(Pointer pointer) where T : unmanaged => (T*)pointer.Value;

        public static unsafe T** GetPointer<T>(LongPointer pointer) where T : unmanaged => (T**)pointer.Value;

        public static unsafe T* GetPointer<T>(TypedPointer pointer) where T : unmanaged => (T*)pointer.Value;

        public static unsafe T** GetPointer<T>(TypedLongPointer pointer) where T : unmanaged => (T**)pointer.Value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Pointer GetPointer<TDelegate>(TDelegate d) where TDelegate : Delegate => GetPointer(Marshal.GetFunctionPointerForDelegate(d));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Pointer GetFunctionPointer<TDelegate>(TDelegate d) where TDelegate : Delegate => GetPointer(d);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe LongPointer GetLongPointer(void** pointer) => GetPointer(pointer);

        public static unsafe LongPointer GetLongPointer(nint pointer) => new() { Value = (ulong)pointer };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe LongPointer GetLongPointer<T>(T** pointer) where T : unmanaged => GetPointer(pointer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void** GetLongPointer(LongPointer pointer) => GetPointer(pointer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void** GetLongPointer(TypedLongPointer pointer) => GetPointer(pointer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe T** GetLongPointer<T>(LongPointer pointer) where T : unmanaged => GetPointer<T>(pointer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe T** GetLongPointer<T>(TypedLongPointer pointer) where T : unmanaged => GetPointer<T>(pointer);

        public static unsafe TypedPointer GetTypedPointer(byte* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Byte };
        
        public static unsafe TypedLongPointer GetTypedPointer(byte** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Byte };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref byte pointer) => GetTypedPointer((byte*)Unsafe.AsPointer(ref pointer));
        
        public static unsafe TypedPointer GetTypedPointer(sbyte* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Int8 };
        
        public static unsafe TypedLongPointer GetTypedPointer(sbyte** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Int8 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref sbyte pointer) => GetTypedPointer((sbyte*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(short* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Int16 };
        
        public static unsafe TypedLongPointer GetTypedPointer(short** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Int16 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref short pointer) => GetTypedPointer((short*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(int* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Int32 };
        
        public static unsafe TypedLongPointer GetTypedPointer(int** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Int32 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref int pointer) => GetTypedPointer((int*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(long* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Int64 };
        
        public static unsafe TypedLongPointer GetTypedPointer(long** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Int64 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref long pointer) => GetTypedPointer((long*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(ushort* pointer) => new() { Value = (ulong)pointer, Type = PointerType.UInt16 };
        
        public static unsafe TypedLongPointer GetTypedPointer(ushort** pointer) => new() { Value = (ulong)pointer, Type = PointerType.UInt16 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref ushort pointer) => GetTypedPointer((ushort*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(uint* pointer) => new() { Value = (ulong)pointer, Type = PointerType.UInt32 };
        
        public static unsafe TypedLongPointer GetTypedPointer(uint** pointer) => new() { Value = (ulong)pointer, Type = PointerType.UInt32 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref uint pointer) => GetTypedPointer((uint*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(ulong* pointer) => new() { Value = (ulong)pointer, Type = PointerType.UInt64 };
        
        public static unsafe TypedLongPointer GetTypedPointer(ulong** pointer) => new() { Value = (ulong)pointer, Type = PointerType.UInt64 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref ulong pointer) => GetTypedPointer((ulong*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(char* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Char };
        
        public static unsafe TypedLongPointer GetTypedPointer(char** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Char };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref char pointer) => GetTypedPointer((char*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(float* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Single };
        
        public static unsafe TypedLongPointer GetTypedPointer(float** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Single };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref float pointer) => GetTypedPointer((float*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(double* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Double };
        
        public static unsafe TypedLongPointer GetTypedPointer(double** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Double };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref double pointer) => GetTypedPointer((double*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(bool* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Boolean };
        
        public static unsafe TypedLongPointer GetTypedPointer(bool** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Boolean };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref bool pointer) => GetTypedPointer((bool*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer(Guid* pointer) => new() { Value = (ulong)pointer, Type = PointerType.Guid };
        
        public static unsafe TypedLongPointer GetTypedPointer(Guid** pointer) => new() { Value = (ulong)pointer, Type = PointerType.Guid };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedPointer(ref Guid pointer) => GetTypedPointer((Guid*)Unsafe.AsPointer(ref pointer));

        public static unsafe TypedPointer GetTypedPointer<TDelegate>(TDelegate d) where TDelegate : Delegate => new() { Value = (ulong)Marshal.GetFunctionPointerForDelegate(d), Type = PointerType.Function };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe TypedPointer GetTypedFunctionPointer<TDelegate>(TDelegate d) where TDelegate : Delegate => GetTypedPointer(d);
    }
}
