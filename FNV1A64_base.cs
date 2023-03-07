using fnvHashFinder;
using System.Diagnostics;

internal class FNV1A64base
{
    private static void Main(string[] args)
    {
        string? Path = string.Empty;
        string? xAsset = string.Empty;

        // You can add Direct names under any of the types
        string[] xAnim =
        {
"",
};
        string[] xAIAnim =
        {
"",
};
        string[] xImage =
        {
"",
};
        string[] xMaterial =
        {
"",
};
        string[] xModel =
        {
"",
};
        string[] xWpnAttachment =
        {
"",
};
        string[] xWpnBlueprint =
        {
"",
};
        string[] xOpVox =
        {
"",
};
        string[] xTAACOM =
        {
"",
};
        string[] xGenericSound =
        {
"",
};
        string[] xLanguage =
        {
"",
};
        string[] xWeaponSound =
        {
"",
};
        string[] xString =
        {
"",
};

        Console.Title = "fnvHashFinder";
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
        Console.WriteLine("\nThis Project was made possible by:\n");
        Console.WriteLine("Scobalula, itsNatoriousB, Cortland, Amorfirion, Dark7x, DeltaDriver, pmr360, JohnWick\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[FNV1A64 MODE]\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Specify xAsset Directory:");
        Path = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("[1] Start Scan");
            string? search = Console.ReadLine();
            if (search == "1")
            {
                Console.WriteLine("\nScanning for Assets... ");
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Task.WaitAll(Task.Factory.StartNew(() => SearchForSpecificAsset(xAsset)));
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                Console.WriteLine("Scan completed in " + elapsedTime);
            }
        }

        void SearchForSpecificAsset(string xAsset)
        {
            foreach (string xanim in xAnim)
            {
                foreach (string xaianim in xAIAnim)
                {
                    CheckAnim("" + xanim);
                }
            }
            foreach (string ximage in xImage)
            {
                foreach (string xwpnattachment in xWpnAttachment)
                {
                    foreach (string xwpnblueprint in xWpnBlueprint)
                    {
                        CheckImage("" + ximage);
                    }
                }
            }
            foreach (string xmaterial in xMaterial)
            {
                CheckMaterial("" + xmaterial);
            }
            foreach (string xmodel in xModel)
            {
                CheckModel("" + xmodel);
            }
            foreach (string xweaponsound in xWeaponSound)
            {
                foreach (string xgenericsound in xGenericSound)
                {
                    foreach (string xtaacom in xTAACOM)
                    {
                        foreach (string xlanguage in xLanguage)
                        {
                            foreach (string xopvox in xOpVox)
                            {
                                CheckSound("" + xweaponsound + xgenericsound);
                                CheckSound("" + xtaacom + xlanguage);
                                CheckSound("" + xopvox + xlanguage);
                            }
                        }
                    }
                }
            }
            foreach (string xstring in xString)
            {
                CheckString("" + xstring);
            }
        }

        void CheckAnim(string animName)
        {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(animName));
            if (Directory.Exists(Path + "\\xanim\\" + hashName))
            {
                Console.WriteLine("Found Anim: {0:x}", hashName + "," + animName);
                File.AppendAllText(Path + "\\AnimsFound.txt", hashName + "," + animName + Environment.NewLine);
                Directory.Delete(Path + "\\xanim\\" + hashName);
            }
        }

        void CheckImage(string imageName)
        {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(imageName));
            if (Directory.Exists(Path + "\\ximage\\" + hashName))
            {
                Console.WriteLine("Found Image: {0:x}", hashName + "," + imageName);
                File.AppendAllText(Path + "\\ImagesFound.txt", hashName + "," + imageName + Environment.NewLine);
                Directory.Delete(Path + "\\ximage\\" + hashName);
            }
        }

        void CheckMaterial(string materialName)
        {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(materialName));
            if (Directory.Exists(Path + "\\xmaterial\\" + hashName))
            {
                Console.WriteLine("Found Material: {0:x}", hashName + "," + materialName);
                File.AppendAllText(Path + "\\MaterialsFound.txt", hashName + "," + materialName + Environment.NewLine);
                Directory.Delete(Path + "\\xmaterial\\" + hashName);
            }
        }

        void CheckModel(string modelName)
        {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(modelName));
            if (Directory.Exists(Path + "\\xmodel\\" + hashName))
            {
                Console.WriteLine("Found Model: {0:x}", hashName + "," + modelName);
                File.AppendAllText(Path + "\\ModelsFound.txt", hashName + "," + modelName + Environment.NewLine);
                Directory.Delete(Path + "\\xmodel\\" + hashName);
            }
        }

        void CheckSound(string soundName)
        {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(soundName));
            if (Directory.Exists(Path + "\\xsound\\" + hashName))
            {
                Console.WriteLine("Found Sound: {0:x}", hashName + "," + soundName);
                File.AppendAllText(Path + "\\SoundsFound.txt", hashName + "," + soundName + Environment.NewLine);
                Directory.Delete(Path + "\\xsound\\" + hashName);
            }
        }
        void CheckString(string stringName)
        {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(stringName));
            if (Directory.Exists(Path + "\\xstring\\" + hashName))
            {
                Console.WriteLine("Found String: {0:x}", hashName + "," + stringName);
                File.AppendAllText(Path + "\\StringsFound.txt", hashName + "," + stringName + Environment.NewLine);
                Directory.Delete(Path + "\\xstring\\" + hashName);
            }
        }
    }
}

namespace fnvHashFinder
{
    class Hash64baseUtil
    {
        public static ulong Hash64base(string input)
        {
            ulong num = 14695981039346656037;
            for (int index = 0; index < input.Length; ++index)
                num = (ulong)(((long)num ^ (long)input[index]) * 1099511628211L);
            num &= 0xFFFFFFFFFFFFFFF;
            return num;
        }
    }
}