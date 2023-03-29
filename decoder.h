#pragma once
#include <chrono>
#include <format>
#include <fstream>
#include <iostream>
#include <string>
#include <thread>
#include <vector>
#include <windows.h>

using namespace std;
using namespace std::chrono;

// Change the uint and Hash class in the .cpp file for the target game

// FNV1a-64 [Modern Warfare 2022 - Modified Function]
class HashMW64Util {
public: static const uint64_t HashMW64(const char* data, const size_t dataLen) {
    const uint64_t FNVPrime = 0x100000001B3;
    const uint64_t FNVOffset = 0xCBF29CE484222325;
    uint64_t result = 0x47F5817A5EF961BA;
    for (size_t i = 0; i < dataLen; i++) {
        uint64_t value = tolower(data[i]);
        if (value == '\\')
            value = '/';
        result = 0x100000001B3 * (value ^ result);
    }
    return result & 0xFFFFFFFFFFFFFFF;
}
};

// FNV1a-64 [Black Ops 4, Black Ops Cold War, Vanguard]
class HashA64Util {
public: static uint64_t HashA64(const char* Data, uint64_t Size) {
    const uint64_t FNVPrime = 0x100000001B3;
    const uint64_t FNVOffset = 0xCBF29CE484222325;
    uint64_t Result = FNVOffset;
    for (uint64_t i = 0; i < Size; i++) {
        Result ^= Data[i];
        Result *= FNVPrime;
    }
    return Result & 0xFFFFFFFFFFFFFFF;
}
};

// FNV1-64 [Unused]
class Hash64Util {
public: static uint64_t Hash64(const char* Data, uint64_t Size) {
    const uint64_t FNVPrime = 0x100000001B3;
    const uint64_t FNVOffset = 0xCBF29CE484222325;
    uint64_t Result = FNVOffset;
    for (uint64_t i = 0; i < Size; i++) {
        Result *= FNVPrime;
        Result ^= Data[i];
    }
    return Result & 0xFFFFFFFFFFFFFFF;
}
};

// FNV1a-32 [Modern Warfare 2022 *Bones* DO NOT USE - HIGH COLLISION RATE]
class HashA32Util {
public: static uint32_t HashA32(const char* Data, uint32_t Size) {
    const uint32_t FNVPrime = 0x01000193;
    const uint32_t FNVOffset = 0x811c9dc5;
    uint32_t Result = FNVOffset;
    for (uint32_t i = 0; i < Size; i++) {
        Result ^= Data[i];
        Result *= FNVPrime;
    }
    return Result & 0xFFFFFFF;
}
};

// FNV1-32 [Unused: DO NOT USE - HIGH COLLISION RATE]
class Hash32Util {
public: static uint32_t Hash32(const char* Data, uint32_t Size) {
    const uint32_t FNVPrime = 0x01000193;
    const uint32_t FNVOffset = 0x811c9dc5;
    uint32_t Result = FNVOffset;
    for (uint32_t i = 0; i < Size; i++) {
        Result *= FNVPrime;
        Result ^= Data[i];
    }
    return Result & 0xFFFFFFF;
}
};