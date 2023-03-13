# fnvHashFinder [![Discord](https://img.shields.io/badge/chat-Discord-blue.svg)](https://discord.gg/qqptpeVW)

A Multi-purpose Tool that verifies pre-defined assets

NOTE 1: Delete and regenerate the xassets on each build as the hashes are removed for newer scans
NOTE 2: Change the startup object to FNV1A64base if you are using it for large scans (default)
NOTE 3: You can use Ladisk CascViewer to pull Black Ops 4 Sounds or the full game from their CDN to find assets manually through Greyhound.

## Overview

This tool was created late 2022 and was able to help find thousands of hashed names. With the help of a few folks from the Hash Scene.
With this tool, you are capable of scanning assets given defined words.
There is already defined names as an example of how it works.
There is a good amount implemented and much more to be added, leads are crucial, usually found in Memory Dumps or Decompiled scripts.
Any assets found by other members will always go through mine and I will update the xAssets directory with verified submissions removed from the folders.
Otherwise you can Memory Dump the process, often new names appear on minor title updates, at this point it's 90% looked through. This is how you find leads.
All Asset Logs are provided, you do not need to own any of the games nor do you need to dump anything.
You will need to extract the xassets files before scanning on them, this can take up to 10 minutes or more. Put this in a location outside the Project else Visual Studio will not load.
You should stick to Debug mode, but do not Debug with a COD game running (Shadowban risk). If you wish to play a COD title while scanning then compile an AOT Release build.
Agent Ransack is provided to scan strings from .XMODEL_EXPORT files. You should set the thread speed high.

Assets that you find can be issued here [https://github.com/Scobalula/GreyhoundPackageIndex]

Including but not limited to what we need to do:

Black Ops 4: xSound Languages (sabs/sabl)
Black Ops CW: Vehicle xModel
Vanguard: xSound
(Soon) MW2022: xImage, xMaterial, xSound, bones (bones use fnv1a32)
Create a textfile for assets to scan from and eliminate the use of folders/files
Multithreading

## Bruteforce Methods:

->These methods provided are what i did to find large amounts of assets, this is a more effective way. Mostly Regex.
->Make name checks outside Visual Studio in fnv1a64.cs with Notepad++, after saving, VS can be debugged/compiled instantly without the formating text dialog.

1. (Most Effective) Using names from previous COD Titles Asset Logs
2. (Most Effective) Word trimming after the last underscore		_[^_]*$
3. (Most Effective) Word trimming before the last underscore 	^.*_
3a. Use words on end of each line as a Type and add on top of the current names + trimming the original name back once (multi pass this with and without underscores)
3b. Use end of each line types from other packages over other packages.
4. (Most Effective) Translating package names, example of Model to image or vice versa:		model:c_t9_rus_pl_stitch		image:i_c_t9_rus_pl_stitch_c
5. Swap ^j_ with ^tag_ and vice versa
6. Reword t8/p8 to t9/p9 and vice versa
7. Removing generated junk words from old unverified hashes		^...........................
8. Direct word attacks aka Dictionary Attack: Create a wordlist by finding all underscores and replace with \n , remove dupes
9. (Effective) Trim all words before the last word on raw names on all packages, now a wordlist, revert back to base, trim the last word end of every line on all packages, then trim all words before the last word on all the names on all packages, now your second wordlist to use as point A and the first wordlist created as point B. This way, we create a wordlist to slot in before the last word to work around capturing the last 2 words seperated to use against other hashes rather than creating a whole word that has 2 names together (more results).
10. If you have your own bruteforce technique you can inform me