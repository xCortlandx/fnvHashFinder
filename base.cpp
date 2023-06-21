#include "decoder.h"

string xAnimCheck[] = {
"",
};
string xAnim[] = {
"",
};
string xAnimFinalCheck[] = {
"",
};
string xImageCheck[] = {
"",
};
string xImage[] = {
"",
};
string xImageFinalCheck[] = {
"",
};
string xMaterialCheck[] = {
"",
};
string xMaterial[] = {
"",
};
string xMaterialFinalCheck[] = {
"",
};
string xModelCheck[] = {
"",
};
string xModel[] = {
"",
};
string xModelFinalCheck[] = {
"",
};
string xWpnAttachment[] = {
"",
};
string xWpnBlueprint[] = {
"",
};
string xSoundWpnCheck[] = {
"",
};
string xWeaponSound[] = {
"",
};
string xSoundOperatorCheck[] = {
"",
};
string xSoundTaacomCheck[] = {
"",
};
string xOpVox[] = {
"",
};
string xTAACOM[] = {
"",
};
string xGenericSound[] = {
"",
};
string xLanguage[] = {
"",
};
string xStringCheck[] = {
"",
};
string xString[] = {
"",
};
string xStringFinalCheck[] = {
"",
};

string path;

void CheckAsset(string assetType, string assetName, int& totalHashesFound, string& foundAssetType) {
    const char* assetNameCStr = assetName.c_str();
    uint64_t assetNameHash = HashA64Util::HashA64(assetNameCStr, assetName.length());
    ostringstream ss;
    ss << hex << assetNameHash;
    string hashName = ss.str();
    if (ifstream(path + "\\" + assetType + "\\" + hashName).good()) {
        cout << "Found " << assetType << ": " << hashName << "," << assetName << "\n";
        unordered_map<string, string> fileNames = {
        {"xanim", "AnimsFound.txt"},
        {"ximage", "ImagesFound.txt"},
        {"xmaterial", "MaterialsFound.txt"},
        {"xmodel", "ModelsFound.txt"},
        {"xsound", "SoundsFound.txt"},
        {"xstring", "StringsFound.txt"}
        };
        string fileName = fileNames[assetType];
        ofstream outfile(path + "\\" + fileName, ios_base::app);
        outfile << hashName << "," << assetName << "\n";
        outfile.close();
        remove((path + "\\" + assetType + "\\" + hashName).c_str());
        totalHashesFound++;
    }
}

void ScanAsset(string xAsset, int& totalHashesFound) {
    string assetType;
    int intermediateTotal = 0;
    int iterationsCompleted = 0;

    for (const auto& xanimcheck : xAnimCheck) {
        for (const auto& xanim : xAnim) {
            for (const auto& xanimfinalcheck : xAnimFinalCheck) {
                CheckAsset("xanim", xanimcheck + xanim + xanimfinalcheck, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& ximagecheck : xImageCheck) {
        for (const auto& ximage : xImage) {
            for (const auto& ximagefinalcheck : xImageFinalCheck) {
                CheckAsset("ximage", ximagecheck + ximage + ximagefinalcheck, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& xmaterialcheck : xMaterialCheck) {
        for (const auto& xmaterial : xMaterial) {
            for (const auto& xmaterialfinalcheck : xMaterialFinalCheck) {
                CheckAsset("xmaterial", xmaterialcheck + xmaterial + xmaterialfinalcheck, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& xmodelcheck : xModelCheck) {
        for (const auto& xmodel : xModel) {
            for (const auto& xmodelfinalcheck : xModelFinalCheck) {
                CheckAsset("xmodel", xmodelcheck + xmodel + xmodelfinalcheck, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& xsoundwpncheck : xSoundWpnCheck) {
        for (const auto& xweaponsound : xWeaponSound) {
            for (const auto& xgenericsound : xGenericSound) {
                CheckAsset("xsound", xsoundwpncheck + xweaponsound + xgenericsound, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& xsoundoperatorcheck : xSoundOperatorCheck) {
        for (const auto& xopvox : xOpVox) {
            for (const auto& xlanguage : xLanguage) {
                CheckAsset("xsound", xsoundoperatorcheck + xopvox + xlanguage, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& xsoundtaacomcheck : xSoundTaacomCheck) {
        for (const auto& xtaacom : xTAACOM) {
            for (const auto& xlanguage : xLanguage) {
                CheckAsset("xsound", xsoundtaacomcheck + xtaacom + xlanguage, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& xstringcheck : xStringCheck) {
        for (const auto& xstring : xString) {
            for (const auto& xstringfinalcheck : xStringFinalCheck) {
                CheckAsset("xstring", xstringcheck + xstring + xstringfinalcheck, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    totalHashesFound = intermediateTotal;
}

int main() {
    SetConsoleTitle(L"fnvHashFinder");
    HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
    SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_RED);
    cout << "                         __,,,,_\n";
    cout << "          _ __..-;''`--/'/ /.',-`-.\n";
    cout << "      (`/' ` |  \\ \\ \\ / / / / .-'/`,_\n";
    cout << "     /'`\\ \\   |  \\ | \\| // // / -.,/_,'-,\n";
    cout << "    /<7' ;  \\ \\  | ; ||/ /| | \\/    |`-/,/-.,_,/')\n";
    cout << "   /  _.-, `,-\\,__|  _-| / \\ \\/|_/  |    '-/.;.\\'\n";
    cout << "   `-`  f/ ;      / __/ \\__ `/ |__/ |\n";
    cout << "    fnv `-'      |  -| =|\\_  \\  |-' |\n";
    cout << "    Hash      __/   /_..-' `  ),'  //\n";
    cout << "    Finder   ((__.-'((___..-'' \\__.'\n";
    cout << "\nA Versatile Tool that verifies hashes\n";
    cout << "\nThis Project was made possible by:\n";
    cout << "Scobalula, Cortland, ItsNatoriousB, Amorfirion\n";
    SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN);
    cout << "\nCPU MODE\n";
    SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_RED);
    cout << "\nSpecify root directory: ";
    getline(cin, path);
    cout << "\nScanning for Assets...\n";
    time_point start = steady_clock::now();
    int totalHashesFound = 0;
    thread t(ScanAsset, path.c_str(), ref(totalHashesFound));
    t.join();
    steady_clock::time_point end = steady_clock::now();
    duration<double> elapsed_seconds = end - start;
    int hours = static_cast<int>(elapsed_seconds.count() / 3600);
    int minutes = static_cast<int>((elapsed_seconds.count() - (hours * 3600)) / 60);
    int seconds = static_cast<int>(elapsed_seconds.count() - (hours * 3600) - (minutes * 60));
    cout << "\nScan completed in: " << setfill('0') << setw(2) << hours << ":" << setw(2) << minutes << ":" << setw(2) << seconds;
    cout << "\nTotal assets found: " << totalHashesFound << '\n';
    system("pause");
    return 0;
}