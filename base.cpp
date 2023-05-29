#include "decoder.h"

const vector<string> xAnimCheck = {
"",
};
const vector<string> xAnim = {
"",
};
const vector<string> xAnimFinalCheck = {
"",
};
const vector<string> xImageCheck = {
"",
};
const vector<string> xImage = {
"",
};
const vector<string> xImageFinalCheck = {
"",
};
const vector<string> xMaterialCheck = {
"",
};
const vector<string> xMaterial = {
"",
};
const vector<string> xMaterialFinalCheck = {
"",
};
const vector<string> xModelCheck = {
"",
};
const vector<string> xModel = {
"",
};
const vector<string> xModelFinalCheck = {
"",
};
const vector<string> xWpnAttachment = {
"",
};
const vector<string> xWpnBlueprint = {
"",
};
const vector<string> xSoundWpnCheck = {
"",
};
const vector<string> xWeaponSound = {
"",
};
const vector<string> xSoundOperaterCheck = {
"",
};
const vector<string> xSoundTaacomCheck = {
"",
};
const vector<string> xOpVox = {
"",
};
const vector<string> xTAACOM = {
"",
};
const vector<string> xGenericSound = {
"",
};
const vector<string> xLanguage = {
"",
};
const vector<string> xStringCheck = {
"",
};
const vector<string> xString = {
"",
};
const vector<string> xStringFinalCheck = {
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

    auto procChecks = [&](const string& assetPrefix, const vector<string>& firstChecks, const vector<string>& secondChecks, const vector<string>& thirdChecks) {
        for (const auto& firstCheck : firstChecks) {
            for (const auto& secondCheck : secondChecks) {
                for (const auto& thirdCheck : thirdChecks) {
                    CheckAsset(assetPrefix, firstCheck + secondCheck + thirdCheck, intermediateTotal, assetType);
                }
            }
        }
    };

    procChecks("xanim", xAnimCheck, xAnim, xAnimFinalCheck);
    procChecks("ximage", xImageCheck, xImage, xImageFinalCheck);
    procChecks("xmaterial", xMaterialCheck, xMaterial, xMaterialFinalCheck);
    procChecks("xmodel", xModelCheck, xModel, xModelFinalCheck);
    procChecks("xsound", xSoundWpnCheck, xWeaponSound, xGenericSound);
    procChecks("xsound", xSoundOperaterCheck, xOpVox, xLanguage);
    procChecks("xsound", xSoundTaacomCheck, xTAACOM, xLanguage);
    procChecks("xstring", xStringCheck, xString, xStringFinalCheck);

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