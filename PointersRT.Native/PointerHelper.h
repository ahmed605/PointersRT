#pragma once

#include <cstdint>
#include <Windows.h>

#if !defined(__cplusplus_winrt)
#include <winrt/PointersRT.h>
#endif

namespace
#if !defined(__cplusplus_winrt)
winrt::
#endif
PointersRT
{
	static class PointerHelper
	{
	public:
		inline static Pointer GetPointer(void* pointer) { return { (uint64_t)pointer }; }
		
		inline static LongPointer GetPointer(void** pointer) { return { (uint64_t)pointer }; }
		
		inline static Pointer GetPointer(intptr_t pointer) { return { (uint64_t)pointer }; }
		
		template <typename T>
		inline static Pointer GetPointer(T* pointer) { return { (uint64_t)pointer }; }

		template <typename T>
		inline static LongPointer GetPointer(T** pointer) { return { (uint64_t)pointer }; }

		template <typename T>
		inline static Pointer GetPointer(T& ref) { return { (uint64_t)&ref }; }

		inline static void* GetPointer(Pointer pointer) { return (void*)pointer.Value; }
		
		inline static void** GetPointer(LongPointer pointer) { return (void**)pointer.Value; }

		inline static void* GetPointer(TypedPointer pointer) { return (void*)pointer.Value; }

		inline static void** GetPointer(TypedLongPointer pointer) { return (void**)pointer.Value; }

		template <typename T>
		inline static T* GetPointer(Pointer pointer) { return (T*)pointer.Value; }

		template <typename T>
		inline static T** GetPointer(LongPointer pointer) { return (T**)pointer.Value; }

		template <typename T>
		inline static T* GetPointer(TypedPointer pointer) { return (T*)pointer.Value; }

		template <typename T>
		inline static T** GetPointer(TypedLongPointer pointer) { return (T**)pointer.Value; }

		inline static LongPointer GetLongPointer(void** pointer) { return GetPointer(pointer); }

		inline static LongPointer GetLongPointer(intptr_t pointer) { return { (uint64_t)pointer }; }

		template <typename T>
		inline static LongPointer GetLongPointer(T** pointer) { return GetPointer<T>(pointer); }

		inline static void** GetLongPointer(LongPointer pointer) { return GetPointer(pointer); }
		
		inline static void** GetLongPointer(TypedLongPointer pointer) { return GetPointer(pointer); }

		template <typename T>
		inline static T** GetLongPointer(LongPointer pointer) { return GetPointer<T>(pointer); }

		template <typename T>
		inline static T** GetLongPointer(TypedLongPointer pointer) { return GetPointer<T>(pointer); }

		inline static TypedPointer GetTypedPointer(char* pointer) { return { (uint64_t)pointer, PointerType::Byte }; }
		
		inline static TypedPointer GetTypedPointer(char& ref) { return { (uint64_t)&ref, PointerType::Byte }; }
		
		inline static TypedLongPointer GetTypedPointer(char** pointer) { return { (uint64_t)pointer, PointerType::Byte }; }

		inline static TypedPointer GetTypedPointer(int8_t* pointer) { return { (uint64_t)pointer, PointerType::Int8 }; }

		inline static TypedPointer GetTypedPointer(int8_t& ref) { return { (uint64_t)&ref, PointerType::Int8 }; }

		inline static TypedLongPointer GetTypedPointer(int8_t** pointer) { return { (uint64_t)pointer, PointerType::Int8 }; }

		inline static TypedPointer GetTypedPointer(int16_t* pointer) { return { (uint64_t)pointer, PointerType::Int16 }; }

		inline static TypedPointer GetTypedPointer(int16_t& ref) { return { (uint64_t)&ref, PointerType::Int16 }; }

		inline static TypedLongPointer GetTypedPointer(int16_t** pointer) { return { (uint64_t)pointer, PointerType::Int16 }; }

		inline static TypedPointer GetTypedPointer(int32_t* pointer) { return { (uint64_t)pointer, PointerType::Int32 }; }

		inline static TypedPointer GetTypedPointer(int32_t& ref) { return { (uint64_t)&ref, PointerType::Int32 }; }

		inline static TypedLongPointer GetTypedPointer(int32_t** pointer) { return { (uint64_t)pointer, PointerType::Int32 }; }

		inline static TypedPointer GetTypedPointer(int64_t* pointer) { return { (uint64_t)pointer, PointerType::Int64 }; }

		inline static TypedPointer GetTypedPointer(int64_t& ref) { return { (uint64_t)&ref, PointerType::Int64 }; }

		inline static TypedLongPointer GetTypedPointer(int64_t** pointer) { return { (uint64_t)pointer, PointerType::Int64 }; }

		inline static TypedPointer GetTypedPointer(uint16_t* pointer) { return { (uint64_t)pointer, PointerType::UInt16 }; }

		inline static TypedPointer GetTypedPointer(uint16_t& ref) { return { (uint64_t)&ref, PointerType::UInt16 }; }

		inline static TypedLongPointer GetTypedPointer(uint16_t** pointer) { return { (uint64_t)pointer, PointerType::UInt16 }; }

		inline static TypedPointer GetTypedPointer(uint32_t* pointer) { return { (uint64_t)pointer, PointerType::UInt32 }; }

		inline static TypedPointer GetTypedPointer(uint32_t& ref) { return { (uint64_t)&ref, PointerType::UInt32 }; }

		inline static TypedLongPointer GetTypedPointer(uint32_t** pointer) { return { (uint64_t)pointer, PointerType::UInt32 }; }

		inline static TypedPointer GetTypedPointer(uint64_t* pointer) { return { (uint64_t)pointer, PointerType::UInt64 }; }

		inline static TypedPointer GetTypedPointer(uint64_t& ref) { return { (uint64_t)&ref, PointerType::UInt64 }; }

		inline static TypedLongPointer GetTypedPointer(uint64_t** pointer) { return { (uint64_t)pointer, PointerType::UInt64 }; }

		inline static TypedPointer GetTypedPointer(wchar_t* pointer) { return { (uint64_t)pointer, PointerType::Char }; }

		inline static TypedPointer GetTypedPointer(wchar_t& ref) { return { (uint64_t)&ref, PointerType::Char }; }

		inline static TypedLongPointer GetTypedPointer(wchar_t** pointer) { return { (uint64_t)pointer, PointerType::Char }; }

		inline static TypedPointer GetTypedPointer(float* pointer) { return { (uint64_t)pointer, PointerType::Single }; }

		inline static TypedPointer GetTypedPointer(float& ref) { return { (uint64_t)&ref, PointerType::Single }; }

		inline static TypedLongPointer GetTypedPointer(float** pointer) { return { (uint64_t)pointer, PointerType::Single }; }

		inline static TypedPointer GetTypedPointer(double* pointer) { return { (uint64_t)pointer, PointerType::Double }; }

		inline static TypedPointer GetTypedPointer(double& ref) { return { (uint64_t)&ref, PointerType::Double }; }

		inline static TypedLongPointer GetTypedPointer(double** pointer) { return { (uint64_t)pointer, PointerType::Double }; }

		inline static TypedPointer GetTypedPointer(bool* pointer) { return { (uint64_t)pointer, PointerType::Boolean }; }

		inline static TypedPointer GetTypedPointer(bool& ref) { return { (uint64_t)&ref, PointerType::Boolean }; }

		inline static TypedLongPointer GetTypedPointer(bool** pointer) { return { (uint64_t)pointer, PointerType::Boolean }; }

		inline static TypedPointer GetTypedPointer(GUID* pointer) { return { (uint64_t)pointer, PointerType::Guid }; }

		inline static TypedPointer GetTypedPointer(GUID& ref) { return { (uint64_t)&ref, PointerType::Guid }; }

		inline static TypedLongPointer GetTypedPointer(GUID** pointer) { return { (uint64_t)pointer, PointerType::Guid }; }
	};
}