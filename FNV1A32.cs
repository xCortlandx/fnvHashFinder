using fnvHashFinder;
using System.Diagnostics;

internal class FNV1A32
{
    private static void Main(string[] args)
    {
        string Path = string.Empty;
        string xAsset = string.Empty;

        // You can add Direct names under any of the types
        string[] ImageTypes =
        {
"",
};
        string[] ImageWpnAttachmentTypes =
        {
"",
};
        string[] ImageWpnBlueprintTypes =
        {
"",
};
        string[] MaterialTypes =
        {
"",
};
        string[] VoxTypes =
        {
"",
};
        string[] LanguageTypes =
        {
"",
};
        string[] StringTypes =
        {
};

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                         __,,,,_");
        Console.WriteLine("          _ __..-;''`--/'/ /.',-`-.");
        Console.WriteLine("      (`/' ` |  \\ \\ \\ / / / / .-'/`,_");
        Console.WriteLine("     /'`\\ \\   |  \\ | \\| // // / -.,/_,'-,");
        Console.WriteLine("    /<7' ;  \\ \\  | ; ||/ /| | \\/    |`-/,/-.,_,/')");
        Console.WriteLine("   /  _.-, `,-\\,__|  _-| / \\ \\/|_/  |    '-/.;.\'");
        Console.WriteLine("   `-`  f/ ;      / __/ \\__ `/ |__/ |");
        Console.WriteLine("    fnv `-'      |  -| =|\\_  \\  |-' |");
        Console.WriteLine("    Hash      __/   /_..-' `  ),'  //");
        Console.WriteLine("    Finder   ((__.-'((___..-'' \\__.'");
        Console.WriteLine("\nA Multi-purpose Tool that verifies pre-defined assets\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[FNV1A32 MODE]\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Specify xAsset Directory:");
        Path = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("[1] Start Scan\n[2] Credit");
            string searchType = Console.ReadLine();
            if (searchType == "1")
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Console.WriteLine("Scanning for Assets...");
                Task.WaitAll(Task.Factory.StartNew(() => SearchForSpecificAsset(xAsset)));
                Console.WriteLine("Scan completed.");
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine("Scan time:" + elapsedTime);
            }
            else if (searchType == "2")
            {
                Console.WriteLine("\nThis Project was made possible by:\n");
                Thread.Sleep(1000);
                Console.WriteLine("Scobalula");
                Thread.Sleep(500);
                Console.WriteLine("itsNatoriousB");
                Thread.Sleep(500);
                Console.WriteLine("Cortland");
                Thread.Sleep(500);
                Console.WriteLine("Amorfirion");
                Thread.Sleep(500);
                Console.WriteLine("Dark7x");
                Thread.Sleep(500);
                Console.WriteLine("DeltaDriver");
                Thread.Sleep(500);
                Console.WriteLine("pmr360");
                Thread.Sleep(500);
                Console.WriteLine("JohnWick [Limitless]\n");
                Thread.Sleep(500);
            }
        }

        void SearchForSpecificAsset(string xAsset)
        {
            foreach (string imageType in ImageTypes)
            {
                foreach (string imageWpnAttachmentType in ImageWpnAttachmentTypes)
                {
                    foreach (string imageWpnBlueprintType in ImageWpnBlueprintTypes)
                    {
                        CheckImageName("" + imageType);
                    }
                }
            }
            foreach (string materialType in MaterialTypes)
            {
                CheckMaterialName("" + materialType);
            }
            foreach (string voxType in VoxTypes)
            {
                foreach (string languageType in LanguageTypes)
                {
                    CheckSoundName("" + voxType + languageType);
                }
            }
            foreach (string stringType in StringTypes)
            {
                CheckStringName("" + stringType);
                CheckStringName("j" + stringType);
                CheckStringName("tag" + stringType);
            }
        }

        void SearchForSpecificName(string SpecificName)
        {
            CheckImageName(SpecificName);
            CheckMaterialName(SpecificName);
            CheckSoundName(SpecificName);
            CheckStringName(SpecificName);
        }

        void CheckImageName(string imageName)
        {
            string hashName = string.Format("{0:x}", Hash32Util.Hash32(imageName));
            if (Directory.Exists(Path + "\\ximage_" + hashName))
            {
                Console.WriteLine("Found Image: {0:x}", hashName + "," + imageName);
                File.AppendAllText(Path + "\\ImagesFound.txt", hashName + "," + imageName + Environment.NewLine);
                Directory.Delete(Path + "\\ximage_" + hashName);
            }
        }

        void CheckMaterialName(string materialName)
        {
            string hashName = string.Format("{0:x}", Hash32Util.Hash32(materialName));
            if (Directory.Exists(Path + "\\xmaterial_" + hashName))
            {
                Console.WriteLine("Found Material: {0:x}", hashName + "," + materialName);
                File.AppendAllText(Path + "\\MaterialsFound.txt", hashName + "," + materialName + Environment.NewLine);
                Directory.Delete(Path + "\\xmaterial_" + hashName);
            }
        }

        void CheckSoundName(string soundName)
        {
            string hashName = string.Format("{0:x}", Hash32Util.Hash32(soundName));
            if (Directory.Exists(Path + "\\xsound_" + hashName))
            {
                Console.WriteLine("Found Sound: {0:x}", hashName + "," + soundName);
                File.AppendAllText(Path + "\\SoundsFound.txt", hashName + "," + soundName + Environment.NewLine);
                Directory.Delete(Path + "\\xsound_" + hashName);
            }
        }
        void CheckStringName(string stringName)
        {
            string hashName = string.Format("{0:x}", Hash32Util.Hash32(stringName));
            if (Directory.Exists(Path + "\\bone_" + hashName))
            {
                Console.WriteLine("Found String: {0:x}", hashName + "," + stringName);
                File.AppendAllText(Path + "\\StringsFound.txt", hashName + "," + stringName + Environment.NewLine);
                Directory.Delete(Path + "\\bone_" + hashName);
            }
        }

        string GetNumberToString(long index)
        {
            string str = "";
            while (index > 0)
            {
                str = GetNumberToChar(index % 37) + str;
                index /= 37;
            }
            return str;
        }

        string GetNumberToChar(long index)
        {
            if (index < 27)
                return char.ConvertFromUtf32(64 + (int)index);
            if (index < 37)
                return (index - 27).ToString();
            return index == 37 ? "_" : "";
        }
    }
}

namespace fnvHashFinder
{
    class Hash32Util
    {
        public static uint Hash32(string input)
        {
            uint num = 2166136261;
            for (int index = 0; index < input.Length; ++index)
                num = (num ^ (uint)input[index]) * 16777619U;
            return num;
        }
    }
}