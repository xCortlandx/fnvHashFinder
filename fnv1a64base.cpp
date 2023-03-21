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

void SearchAsset(string xAsset, int& totalHashesFound);
void CheckAnim(string animName, int& totalHashesFound);
void CheckImage(string imageName, int& totalHashesFound);
void CheckMaterial(string materialName, int& totalHashesFound);
void CheckModel(string modelName, int& totalHashesFound);
void CheckSound(string soundName, int& totalHashesFound);
void CheckString(string stringName, int& totalHashesFound);

void SearchAsset(string xAsset, int& totalHashesFound) {
	int intermediateTotal = 0;
	int iterationsCompleted = 0;

	int animIterations = sizeof(animCheck) / sizeof(animCheck[0]) * sizeof(xAnim) / sizeof(xAnim[0]) * sizeof(animFinalCheck) / sizeof(animFinalCheck[0]);
	int imageIterations = sizeof(imageCheck) / sizeof(imageCheck[0]) * sizeof(xImage) / sizeof(xImage[0]);
	int materialIterations = sizeof(materialCheck) / sizeof(materialCheck[0]) * sizeof(xMaterial) / sizeof(xMaterial[0]);
	int modelIterations = sizeof(modelCheck) / sizeof(modelCheck[0]) * sizeof(xModel) / sizeof(xModel[0]);
	int soundWpnIterations = sizeof(soundWpnCheck) / sizeof(soundWpnCheck[0]) * sizeof(xWeaponSound) / sizeof(xWeaponSound[0]) * sizeof(xGenericSound) / sizeof(xGenericSound[0]);
	int soundOperaterIterations = sizeof(soundOperaterCheck) / sizeof(soundOperaterCheck[0]) * sizeof(xOpVox) / sizeof(xOpVox[0]) * sizeof(xLanguage) / sizeof(xLanguage[0]);
	int soundTaacomIterations = sizeof(soundTaacomCheck) / sizeof(soundTaacomCheck[0]) * sizeof(xTAACOM) / sizeof(xTAACOM[0]) * sizeof(xLanguage) / sizeof(xLanguage[0]);
	int stringIterations = sizeof(stringCheck) / sizeof(stringCheck[0]) * sizeof(xString) / sizeof(xString[0]);

	for (const auto& animcheck : animCheck) {
		for (const auto& xanim : xAnim) {
			for (const auto& animfinalcheck : animFinalCheck) {
				CheckAnim(animcheck + xanim + animfinalcheck, intermediateTotal);
				iterationsCompleted++;
			}
		}
	}

	for (const auto& imagecheck : imageCheck) {
		for (const auto& ximage : xImage) {
			CheckImage(imagecheck + ximage, intermediateTotal);
			iterationsCompleted++;
		}
	}

	for (const auto& materialcheck : materialCheck) {
		for (const auto& xmaterial : xMaterial) {
			CheckMaterial(materialcheck + xmaterial, intermediateTotal);
			iterationsCompleted++;
		}
	}

	for (const auto& modelcheck : modelCheck) {
		for (const auto& xmodel : xModel) {
			CheckModel(modelcheck + xmodel, intermediateTotal);
			iterationsCompleted++;
		}
	}

	for (const auto& soundwpncheck : soundWpnCheck) {
		for (const auto& xweaponsound : xWeaponSound) {
			for (const auto& xgenericsound : xGenericSound) {
				CheckSound(soundwpncheck + xweaponsound + xgenericsound, intermediateTotal);
				iterationsCompleted++;
			}
		}
	}

	for (const auto& soundoperatercheck : soundOperaterCheck) {
		for (const auto& xopvox : xOpVox) {
			for (const auto& xlanguage : xLanguage) {
				CheckSound(soundoperatercheck + xopvox + xlanguage, intermediateTotal);
				iterationsCompleted++;
			}
		}
	}

	for (const auto& soundtaacomcheck : soundTaacomCheck) {
		for (const auto& xtaacom : xTAACOM) {
			for (const auto& xlanguage : xLanguage) {
				CheckSound(soundtaacomcheck + xtaacom + xlanguage, intermediateTotal);
				iterationsCompleted++;
			}
		}
	}

	for (const auto& stringcheck : stringCheck) {
		for (const auto& xstring : xString) {
			CheckString(stringcheck + xstring, intermediateTotal);
			iterationsCompleted++;
		}
	}
	totalHashesFound = intermediateTotal;
}

void CheckAnim(string animName, int& totalHashesFound) {
	const char* animNameCStr = animName.c_str();
	uint64_t animNameHash = Hash64Util::Hash64(animNameCStr, animName.length());
	ostringstream ss;
	ss << hex << animNameHash;
	string hashName = ss.str();
	if (ifstream(path + "\\xanim\\" + hashName).good()) {
		cout << "Found Anim: " << hashName << "," << animName << "\n";
		ofstream outfile(path + "\\AnimsFound.txt", ios_base::app);
		outfile << hashName << "," << animName << "\n";
		outfile.close();
		remove((path + "\\xanim\\" + hashName).c_str());
		totalHashesFound++;
	}
}

void CheckImage(string imageName, int& totalHashesFound) {
	const char* imageNameCStr = imageName.c_str();
	uint64_t imageNameHash = Hash64Util::Hash64(imageNameCStr, imageName.length());
	ostringstream ss;
	ss << hex << imageNameHash;
	string hashName = ss.str();
	if (ifstream(path + "\\ximage\\" + hashName).good()) {
		cout << "Found Image: " << hashName << "," << imageName << "\n";
		ofstream outfile(path + "\\ImagesFound.txt", ios_base::app);
		outfile << hashName << "," << imageName << "\n";
		outfile.close();
		remove((path + "\\ximage\\" + hashName).c_str());
		totalHashesFound++;
	}
}

void CheckMaterial(string materialName, int& totalHashesFound) {
	const char* materialNameCStr = materialName.c_str();
	uint64_t materialNameHash = Hash64Util::Hash64(materialNameCStr, materialName.length());
	ostringstream ss;
	ss << hex << materialNameHash;
	string hashName = ss.str();
	if (ifstream(path + "\\xmaterial\\" + hashName).good()) {
		cout << "Found Material: " << hashName << "," << materialName << "\n";
		ofstream outfile(path + "\\MaterialsFound.txt", ios_base::app);
		outfile << hashName << "," << materialName << "\n";
		outfile.close();
		remove((path + "\\xmaterial\\" + hashName).c_str());
		totalHashesFound++;
	}
}

void CheckModel(string modelName, int& totalHashesFound) {
	const char* modelNameCStr = modelName.c_str();
	uint64_t modelNameHash = Hash64Util::Hash64(modelNameCStr, modelName.length());
	ostringstream ss;
	ss << hex << modelNameHash;
	string hashName = ss.str();
	if (ifstream(path + "\\xmodel\\" + hashName).good()) {
		cout << "Found Model: " << hashName << "," << modelName << "\n";
		ofstream outfile(path + "\\ModelsFound.txt", ios_base::app);
		outfile << hashName << "," << modelName << "\n";
		outfile.close();
		remove((path + "\\xmodel\\" + hashName).c_str());
		totalHashesFound++;
	}
}

void CheckSound(string soundName, int& totalHashesFound) {
	const char* soundNameCStr = soundName.c_str();
	uint64_t soundNameHash = Hash64Util::Hash64(soundNameCStr, soundName.length());
	ostringstream ss;
	ss << hex << soundNameHash;
	string hashName = ss.str();
	if (ifstream(path + "\\xsound\\" + hashName).good()) {
		cout << "Found Sound: " << hashName << "," << soundName << "\n";
		ofstream outfile(path + "\\SoundsFound.txt", ios_base::app);
		outfile << hashName << "," << soundName << "\n";
		outfile.close();
		remove((path + "\\xsound\\" + hashName).c_str());
		totalHashesFound++;
	}
}

void CheckString(string stringName, int& totalHashesFound) {
	const char* stringNameCStr = stringName.c_str();
	uint64_t stringNameHash = Hash64Util::Hash64(stringNameCStr, stringName.length());
	ostringstream ss;
	ss << hex << stringNameHash;
	string hashName = ss.str();
	if (ifstream(path + "\\xstring\\" + hashName).good()) {
		cout << "Found String: " << hashName << "," << stringName << "\n";
		ofstream outfile(path + "\\StringsFound.txt", ios_base::app);
		outfile << hashName << "," << stringName << "\n";
		outfile.close();
		remove((path + "\\xstring\\" + hashName).c_str());
		totalHashesFound++;
	}
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
	cout << "\nSpecify Root Directory: ";
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
		return 0; }
}