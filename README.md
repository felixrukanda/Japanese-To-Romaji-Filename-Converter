# Japanese to Romaji Filename Converter
![](https://github.com/felixrukanda/Japanese-To-Romaji-Filename-Converter/assets/155972111/524aef99-1f31-44bd-b0db-f1bc915ea7a1)

Convert filenames with japanese characters (hiragana/kanji/katakana) into romaji/english - with the help of [LibreTranslate](https://libretranslate.com/) and [Kawazu Library](https://github.com/Cutano/Kawazu).

Hiragana and kanji characters are converted into romaji using Kawazu Library, while katakana is converted into English using LibreTranslate.

This project is forked from [here](https://github.com/Lawrr/Japanese-To-Romaji-Filename-Converter), the difference is this project use LibreTranslate and Kawazu Library instead of Google Translate

# [Download Here](https://github.com/felixrukanda/Japanese-To-Romaji-Filename-Converter/releases)
## Requirements
- Python
- .NET Framework 4.6.2

# Current Features
- **Convert filenames**: from japanese to romaji/english.
- **Revert conversions**: ability to change filenames back after a conversion.
- **Phrase mapping**: helps to correct incorrect translations.
- **Particle list**: choose which words you want capitalised.
- **Audio metadata support**: if the file is an audio file with ID3 metadata, this program also converts the title, artists, album artist and album name into romaji/english if it is in japanese.

# Program Usage

### Getting Started
1. Make sure you have Python installed, if you don't have Python installed you can download from [here](https://www.python.org/downloads/) 
2. Install LibreTranslate so you can run LibreTranslate server on your own machine, you can check the instruction from their github [here](https://github.com/LibreTranslate/LibreTranslate#install-and-run)
3. Extract/unzip the downloaded zip file (**Please unzip before using it so that the conversion-history file can be written to properly**)
4. Run `Japanese to Romaji Filename Converter.exe`

### Converting
1. Click `Start Translator Server` to launch a command prompt window that will run a LibreTranslate server
2. Add some files
3. If the file is an audio file, select which type of metadata tags that will be converted
4. Click `Convert`

### Reverting
1. Click `View Conversion History`
2. Select files you want to revert
3. Click `Revert Selected`

# Things To Know When Using The Program
## Translator Server
Translator server is required to run whenever you want to convert files, after clicking the `Start Translator Server` button a command prompt window will be launched and wait until the text `Running on http://127.0.0.1:5000` is shown, do not close this window until you finished converting files. It will automatically close when you close the program, you can also close it manually or by clicking the `Stop Translator Server` button.

## Conversion History
Whenever a conversion occurs, the conversion is saved in the `conversion-history.xml` file in the same directory as the program. The conversion data is saved in this file in case a file has to be reverted back.

## Mappings
To ease the problem of incorrect translations, there are mapping files located in `res/maps/` which will map the specified phrases into another phrase. For example, if the phrase `tsu` continuously gets translated into `tsud`, you can create a new mapping `tsud:tsu` which will map `tsud` to `tsu` whenever a translation occurs.

**Mappings support regular expressions.**

Currently there are two mapping files:
- `hirakanji-latn_maps.txt`: Used whenever a _token_ is translated from hiragana/kanji to romaji
- `kata-en_maps.txt`: Used whenever a _token_ is translated from katakana to english

## Particles
`res/particles/` contains a list of language particles which do not get capitalised during conversion.

**Particles support regular expressions.**

Currently there are two particle files:
- `hirakanji-latn_particles.txt`: list of japanese particles (romanized) which are checked when a _token_ is translated from hiragana/kanji to romaji
- `kata-en_particles.txt`: list of english particles which are checked when a _token_ is translated from katakana to english

# Punctuations
There are mapping file `res/maps/punctuation_maps.txt` that contains a list of Japanese punctuations that will be converted into English punctuations.

# Development Dependencies
- TagLib
- Kawazu
- System.Net.Http.Json

# Disclaimer
Please be aware that the software is not perfect and may make incorrect translations. Please use at your own risk.
