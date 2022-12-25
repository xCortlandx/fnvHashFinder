# fnvHashFinder

A Multi-purpose Tool that verifies pre-defined assets

## Overview

This tool was created several months ago and was the one that helped me find hundreds and thousands of hashed names. With the help of a few folks from the Hash Scene.
With this tool, you are capable of scanning assets given defined prefixes.
There is already defined names as an example of how it works, which are already found.
There is a good amount implemented and much more to be added, leads are crucial.
Any assets found by other members you can easily remove from yours by creating a batch "rmdir xmodel_example"
Otherwise you can Memory Dump the process, often new names appear on minor title updates, at this point it's 90% looked through. This is how you find leads.
All Asset Logs are provided, you do not need to own any of the games nor do you need to dump anything.
You will need to generate folders with the given batch file of xAssets before scanning on them, this can take up to 30 minutes. Put this in a location outside the Project.
You should stick to Debug mode, but do not Debug with a COD game running (Shadowban risk). If you wish to play a COD title while scanning then compile an AOT Release build.

Assets that you find can be issued here [https://github.com/Scobalula/GreyhoundPackageIndex]
DnGrep is provided to scan strings from .XMODEL_EXPORT files, and can be updated manually https://github.com/dnGrep/dnGrep

Including but not limited to what we need to do:

Black Ops 4: xSound (sabs), xModel/xMaterial/xImage (Operator/Weapon Skins/Bundles) (Ops,Weps will be added soon)
Black Ops CW: Vehicle xModel
Vanguard: xSound
Create a textfile for assets to scan from and eliminate the use of folders

## Bruteforce Methods:

These methods provided are what i did in order to find large amounts of asset names, this is a more effective way. Mostly Regex.

1. Word trimming after the last underscore		_[^_]*$
2. Removing generated junk words from old unverified hashes		^...........................
3. Translating package names, example of Model to image or vice versa:		model:c_t9_rus_pl_stitch		image:i_c_t9_rus_pl_stitch_c
4. Direct word attacks aka Dictionary Attack: Create a wordlist by finding all underscores and replace with \n , remove dupes
5. Using names from previous COD Titles Asset Logs