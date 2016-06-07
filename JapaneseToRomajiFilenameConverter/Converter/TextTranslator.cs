﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace JapaneseToRomajiFileConverter.Converter {
    public class TextTranslator {

        public const string LanguagePair = "ja|en";

        private const string TranslatorUrl = "https://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}";

        // TODO store in better data structure?
        // Unicode ranges for each set
        public const int RomajiMin = 0x0020;
        public const int RomajiMax = 0x007E;
        public const int HiraganaMin = 0x3040;
        public const int HiraganaMax = 0x309F;
        public const int KatakanaMin = 0x30A0;
        public const int KatakanaMax = 0x30FF;
        public const int KanjiMin = 0x4E00;
        public const int KanjiMax = 0x9FBF;
        // Covers Basic Latin, Latin-1 Supplement, Extended A, Extended B
        public const int LatinMin = 0x0000;
        public const int LatinMax = 0x024F;

        public static string GetTranslatorUrl(string text, string languagePair = LanguagePair) {
            return string.Format(TranslatorUrl, text, languagePair);
        }

        public static string Translate(string inText, string languagePair = LanguagePair) {
            // Check if already translated / romanized
            // TODO check japanese punctuation too
            // if (IsTranslated(inText)) return inText;

            // Split the text into separate sequential tokens and translate each token
            List<TextToken> textTokens = TextToken.GetTextTokens(inText);

            // Load maps and particles lists once
            string hirakanjiMapPath = Path.Combine(Maps.DirectoryPath, Maps.HirakanjiLatn);
            List<string> hirakanjiMaps = new List<string>(File.ReadAllLines(hirakanjiMapPath));

            string hirakanjiParticlesPath = Path.Combine(Particles.DirectoryPath, Particles.HirakanjiLatn);
            List<string> hirakanjiParticles = new List<string>(File.ReadAllLines(hirakanjiParticlesPath));

            string kataMapPath = Path.Combine(Maps.DirectoryPath, Maps.KataLatn);
            List<string> kataMaps = new List<string>(File.ReadAllLines(kataMapPath));

            // Translate each token
            string outText = "";
            foreach (TextToken textToken in textTokens) {
                switch (textToken.Type) {
                    case TokenType.HiraganaKanji:
                        outText += textToken.Translate(hirakanjiMaps, hirakanjiParticles);
                        break;

                    case TokenType.Katakana:
                        outText += textToken.Translate(kataMaps);
                        break;

                    case TokenType.Latin:
                    default:
                        outText += textToken.Translate();
                        break;
                }
            }

            // Normalize
            outText = outText.Normalize(NormalizationForm.FormKC);

            return outText;
        }

        public static bool IsTranslated(string text) {
            return text.Where(c => IsJapanese(c.ToString())).Count() == 0;
        }

        public static bool IsLatin(string text) {
            return text.Where(c => c >= LatinMin && c <= LatinMax).Count() == text.Length;
        }

        public static bool IsJapanese(string text) {
            return text.Where(c => IsHiragana(c.ToString()) ||
                                   IsKatakana(c.ToString()) ||
                                   IsKanji(c.ToString())
                             ).Count() == text.Length;
        }

        public static bool IsHiragana(string text) {
            return text.Where(c => c >= HiraganaMin && c <= HiraganaMax).Count() == text.Length;
        }

        public static bool IsKatakana(string text) {
            return text.Where(c => c >= KatakanaMin && c <= KatakanaMax).Count() == text.Length;
        }

        public static bool IsKanji(string text) {
            return text.Where(c => c >= KanjiMin && c <= KanjiMax).Count() == text.Length;
        }

    }
}
