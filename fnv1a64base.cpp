#include "fnv1a64.h"

string path;

// You can add Direct names under any of the types
string animCheck[] = {
"",
};
string xAnim[] = {
"",
};
string animFinalCheck[] = {
"",
};
string imageCheck[] = {
"",
};
string xImage[] = {
"",
};
string materialCheck[] = {
"",
};
string xMaterial[] = {
"",
};
string modelCheck[] = {
"",
};
string xModel[] = {
"",
};
string xWpnAttachment[] = {
"",
};
string xWpnBlueprint[] = {
"",
};
string soundWpnCheck[] = {
"",
};
string xWeaponSound[] = {
"",
};
string soundOperaterCheck[] = {
"",
};
string soundTaacomCheck[] = {
"",
};
string xOpVox[] = {
// Operator Voicelines
"",
};
string xTAACOM[] = {
// TAACOM Voicelines
"",
};
string xGenericSound[] = {
"",
};
string xLanguage[] = {
"",
};
string stringCheck[] = {
"",
};
string xString[] = {
"",
};

void CheckAsset(string assetType, string assetName, int& totalHashesFound, string& foundAssetType) {
    const char* assetNameCStr = assetName.c_str();
    uint64_t assetNameHash = Hash64Util::Hash64(assetNameCStr, assetName.length());
    ostringstream ss;
    ss << hex << assetNameHash;
    string hashName = ss.str();
    if (ifstream(path + "\\" + assetType + "\\" + hashName).good()) {
        cout << "Found " << assetType << ": " << hashName << "," << assetName << "\n";
        string fileName;
        if (assetType == "xanim") {
            fileName = "AnimsFound.txt";
        }
        else if (assetType == "ximage") {
            fileName = "ImagesFound.txt";
        }
        else if (assetType == "xmaterial") {
            fileName = "MaterialsFound.txt";
        }
        else if (assetType == "xmodel") {
            fileName = "ModelsFound.txt";
        }
        else if (assetType == "xsound") {
            fileName = "SoundsFound.txt";
        }
        else if (assetType == "xstring") {
            fileName = "StringsFound.txt";
        }
        ofstream outfile(path + "\\" + fileName, ios_base::app);
        outfile << hashName << "," << assetName << "\n";
        outfile.close();
        remove((path + "\\" + assetType + "\\" + hashName).c_str());
        totalHashesFound++;
    }
}

void SearchAsset(string xAsset, int& totalHashesFound) {
    string assetType;
    int intermediateTotal = 0;
    int iterationsCompleted = 0;

    const int animIterations = sizeof(animCheck) / sizeof(animCheck[0]) * sizeof(xAnim) / sizeof(xAnim[0]) * sizeof(animFinalCheck) / sizeof(animFinalCheck[0]);
    const int imageIterations = sizeof(imageCheck) / sizeof(imageCheck[0]) * sizeof(xImage) / sizeof(xImage[0]);
    const int materialIterations = sizeof(materialCheck) / sizeof(materialCheck[0]) * sizeof(xMaterial) / sizeof(xMaterial[0]);
    const int modelIterations = sizeof(modelCheck) / sizeof(modelCheck[0]) * sizeof(xModel) / sizeof(xModel[0]);
    const int soundWpnIterations = sizeof(soundWpnCheck) / sizeof(soundWpnCheck[0]) * sizeof(xWeaponSound) / sizeof(xWeaponSound[0]) * sizeof(xGenericSound) / sizeof(xGenericSound[0]);
    const int soundOperaterIterations = sizeof(soundOperaterCheck) / sizeof(soundOperaterCheck[0]) * sizeof(xOpVox) / sizeof(xOpVox[0]) * sizeof(xLanguage) / sizeof(xLanguage[0]);
    const int soundTaacomIterations = sizeof(soundTaacomCheck) / sizeof(soundTaacomCheck[0]) * sizeof(xTAACOM) / sizeof(xTAACOM[0]) * sizeof(xLanguage) / sizeof(xLanguage[0]);
    const int stringIterations = sizeof(stringCheck) / sizeof(stringCheck[0]) * sizeof(xString) / sizeof(xString[0]);

    for (const auto& animcheck : animCheck) {
        for (const auto& xanim : xAnim) {
            for (const auto& animfinalcheck : animFinalCheck) {
                CheckAsset("xanim", animcheck + xanim + animfinalcheck, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& imagecheck : imageCheck) {
        for (const auto& ximage : xImage) {
            CheckAsset("ximage", imagecheck + ximage, intermediateTotal, assetType);
            iterationsCompleted++;
        }
    }

    for (const auto& materialcheck : materialCheck) {
        for (const auto& xmaterial : xMaterial) {
            CheckAsset("xmaterial", materialcheck + xmaterial, intermediateTotal, assetType);
            iterationsCompleted++;
        }
    }

    for (const auto& modelcheck : modelCheck) {
        for (const auto& xmodel : xModel) {
            CheckAsset("xmodel", modelcheck + xmodel, intermediateTotal, assetType);
            iterationsCompleted++;
        }
    }

    for (const auto& soundwpncheck : soundWpnCheck) {
        for (const auto& xweaponsound : xWeaponSound) {
            for (const auto& xgenericsound : xGenericSound) {
                CheckAsset("xsound", soundwpncheck + xweaponsound + xgenericsound, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& soundoperatercheck : soundOperaterCheck) {
        for (const auto& xopvox : xOpVox) {
            for (const auto& xlanguage : xLanguage) {
                CheckAsset("xsound", soundoperatercheck + xopvox + xlanguage, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& soundtaacomcheck : soundTaacomCheck) {
        for (const auto& xtaacom : xTAACOM) {
            for (const auto& xlanguage : xLanguage) {
                CheckAsset("xsound", soundtaacomcheck + xtaacom + xlanguage, intermediateTotal, assetType);
                iterationsCompleted++;
            }
        }
    }

    for (const auto& stringcheck : stringCheck) {
        for (const auto& xstring : xString) {
            CheckAsset("xstring", stringcheck + xstring, intermediateTotal, assetType);
            iterationsCompleted++;
        }
    }
    totalHashesFound = intermediateTotal;
}

int main(const vector<wstring>& args) {
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
    cout << "\nFNV1A64 MODE\n";
    SetConsoleTextAttribute(hConsole, FOREGROUND_GREEN | FOREGROUND_RED);
    cout << "\nSpecify root directory: ";
    getline(cin, path); {
        cout << "\nScanning for Assets...\n";
        time_point start = steady_clock::now();
        int totalHashesFound = 0;
        thread t(SearchAsset, path.c_str(), ref(totalHashesFound));
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
}