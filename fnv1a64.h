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

const uint64_t FNVPrime = 0x100000001B3;
const uint64_t FNVOffset = 0xCBF29CE484222325;

class Hash64Util {
public: static uint64_t Hash64(const char* Data, uint64_t Size) {
    uint64_t Result = FNVOffset;
    for (uint64_t i = 0; i < Size; i++) {
        Result ^= Data[i];
        Result *= FNVPrime;
    }
    return Result & 0xFFFFFFFFFFFFFFF;
}
};