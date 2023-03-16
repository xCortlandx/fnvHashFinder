using fnvHashFinder;
using System.Diagnostics;

internal class FNV1A64base {
    private static void Main(string[] args) {
        string? Path = string.Empty;
        string? xAsset = string.Empty;

        // You can add Direct names under any of the types
        string[] animCheck = {
"",
};
        string[] xAnim = {
"",
};
        string[] animFinalCheck = {
"",
};
        string[] imageCheck = {
"",
};
        string[] xImage = {
"",
};
        string[] materialCheck = {
"",
};
        string[] xMaterial = {
"",
};
        string[] modelCheck = {
"",
};
        string[] xModel = {
"",
};
        string[] xWpnAttachment = {
"",
};
        string[] xWpnBlueprint = {
"",
};
        string[] soundWpnCheck = {
"",
};
        string[] xWeaponSound = {
"",
};
        string[] soundOperaterCheck = {
"",
};
        string[] soundTaacomCheck = {
"",
};
        string[] xOpVox = {
"",
};
        string[] xTAACOM = {
"",
};
        string[] xGenericSound = {
"",
};
        string[] xLanguage = {
"",
};
        string[] stringCheck = {
"",
};
        string[] xString = {
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
        Console.WriteLine("[FNV1A64 BASE MODE]\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Specify xAsset Directory:");
        Path = Console.ReadLine();
        while (true) {
            Console.WriteLine("[1] Start Scan");
            string? search = Console.ReadLine();
            if (search == "1") {
                Console.WriteLine("\nScanning for Assets...");
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                int totalHashesFound = 0;
                Task.WaitAll(Task.Factory.StartNew(() => SearchAsset(xAsset, ref totalHashesFound)));
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                Console.WriteLine("\nScan completed in " + elapsedTime);
                Console.WriteLine("Total assets found: " + totalHashesFound); }}

        void SearchAsset(string xAsset, ref int totalHashesFound) {
			int intermediateTotal = 0;
			int iterationsCompleted = 0;
			int numIterations =
                animCheck.Length * xAnim.Length * animFinalCheck.Length +
                imageCheck.Length * xImage.Length +
                materialCheck.Length * xMaterial.Length +
                modelCheck.Length * xModel.Length +
                soundWpnCheck.Length * xWeaponSound.Length * xGenericSound.Length +
                soundOperaterCheck.Length * xOpVox.Length * xLanguage.Length +
                soundTaacomCheck.Length * xTAACOM.Length * xLanguage.Length +
                stringCheck.Length * xString.Length;

            Parallel.ForEach(animCheck, animcheck => {
                Parallel.ForEach(xAnim, xanim => {
                    Parallel.ForEach(animFinalCheck, animfinalcheck => {
                        CheckAnim(animcheck + xanim + animfinalcheck, ref intermediateTotal);
                        Interlocked.Add(ref iterationsCompleted, 1); }); }); });

            Parallel.ForEach(imageCheck, imagecheck => {
                Parallel.ForEach(xImage, ximage => {
                    CheckImage(imagecheck + ximage, ref intermediateTotal);
                    Interlocked.Add(ref iterationsCompleted, 1); }); });

            Parallel.ForEach(materialCheck, materialcheck => {
                Parallel.ForEach(xMaterial, xmaterial => {
                    CheckMaterial(materialcheck + xmaterial, ref intermediateTotal);
                    Interlocked.Add(ref iterationsCompleted, 1); }); });

            Parallel.ForEach(modelCheck, modelcheck => {
                Parallel.ForEach(xModel, xmodel => {
                    CheckModel(modelcheck + xmodel, ref intermediateTotal);
                    Interlocked.Add(ref iterationsCompleted, 1); }); });

            Parallel.ForEach(soundWpnCheck, soundwpncheck => {
                Parallel.ForEach(xWeaponSound, xweaponsound => {
                    Parallel.ForEach(xGenericSound, xgenericsound => {
                        CheckSound(soundwpncheck + xweaponsound + xgenericsound, ref intermediateTotal);
                        Interlocked.Add(ref iterationsCompleted, 1); }); }); });

            Parallel.ForEach(soundOperaterCheck, soundoperatercheck => {
                Parallel.ForEach(xOpVox, xopvox => {
                    Parallel.ForEach(xLanguage, xlanguage => {
                        CheckSound(soundoperatercheck + xopvox + xlanguage, ref intermediateTotal);
                        Interlocked.Add(ref iterationsCompleted, 1); }); }); });

            Parallel.ForEach(soundTaacomCheck, soundtaacomcheck => {
                Parallel.ForEach(xTAACOM, xtaacom => {
                    Parallel.ForEach(xLanguage, xlanguage => {
                        CheckSound(soundtaacomcheck + xtaacom + xlanguage, ref intermediateTotal);
                        Interlocked.Add(ref iterationsCompleted, 1); }); }); });

            Parallel.ForEach(stringCheck, stringcheck => {
                Parallel.ForEach(xString, xstring => {
                    CheckString(stringcheck + xstring, ref intermediateTotal);
                    Interlocked.Add(ref iterationsCompleted, 1); }); });
            totalHashesFound += intermediateTotal; }

            void CheckAnim(string animName, ref int totalHashesFound) {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(animName));
            if (File.Exists(Path + "\\xanim\\" + hashName)) {
                Console.WriteLine("Found Anim: {0:x}", hashName + "," + animName);
                File.AppendAllText(Path + "\\AnimsFound.txt", hashName + "," + animName + Environment.NewLine);
                File.Delete(Path + "\\xanim\\" + hashName);
                totalHashesFound++; }}

        void CheckImage(string imageName, ref int totalHashesFound) {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(imageName));
            if (File.Exists(Path + "\\ximage\\" + hashName)) {
                Console.WriteLine("Found Image: {0:x}", hashName + "," + imageName);
                File.AppendAllText(Path + "\\ImagesFound.txt", hashName + "," + imageName + Environment.NewLine);
                File.Delete(Path + "\\ximage\\" + hashName);
                totalHashesFound++; }}

        void CheckMaterial(string materialName, ref int totalHashesFound) {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(materialName));
            if (File.Exists(Path + "\\xmaterial\\" + hashName)) {
                Console.WriteLine("Found Material: {0:x}", hashName + "," + materialName);
                File.AppendAllText(Path + "\\MaterialsFound.txt", hashName + "," + materialName + Environment.NewLine);
                File.Delete(Path + "\\xmaterial\\" + hashName);
                totalHashesFound++; }}

        void CheckModel(string modelName, ref int totalHashesFound) {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(modelName));
            if (File.Exists(Path + "\\xmodel\\" + hashName)) {
                Console.WriteLine("Found Model: {0:x}", hashName + "," + modelName);
                File.AppendAllText(Path + "\\ModelsFound.txt", hashName + "," + modelName + Environment.NewLine);
                File.Delete(Path + "\\xmodel\\" + hashName);
                totalHashesFound++; }}

        void CheckSound(string soundName, ref int totalHashesFound) {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(soundName));
            if (File.Exists(Path + "\\xsound\\" + hashName)) {
                Console.WriteLine("Found Sound: {0:x}", hashName + "," + soundName);
                File.AppendAllText(Path + "\\SoundsFound.txt", hashName + "," + soundName + Environment.NewLine);
                File.Delete(Path + "\\xsound\\" + hashName);
                totalHashesFound++; }}

        void CheckString(string stringName, ref int totalHashesFound) {
            string hashName = string.Format("{0:x}", Hash64baseUtil.Hash64base(stringName));
            if (File.Exists(Path + "\\xstring\\" + hashName)) {
                Console.WriteLine("Found String: {0:x}", hashName + "," + stringName);
                File.AppendAllText(Path + "\\StringsFound.txt", hashName + "," + stringName + Environment.NewLine);
                File.Delete(Path + "\\xstring\\" + hashName);
                totalHashesFound++; }}}}

namespace fnvHashFinder {
    class Hash64baseUtil {
        public static ulong Hash64base(string input) {
            ulong num = 14695981039346656037;
            for (int index = 0; index < input.Length; ++index)
                num = (ulong)(((long)num ^ (long)input[index]) * 1099511628211L);
            num &= 0xFFFFFFFFFFFFFFF;
            return num; }}}