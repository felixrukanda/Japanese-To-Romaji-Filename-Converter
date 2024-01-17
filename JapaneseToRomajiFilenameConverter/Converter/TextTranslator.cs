using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JapaneseToRomajiFilenameConverter.Converter {
    public class TextTranslator {

        // katakana use libretranslate
        private const string TranslatorUrlKatakana = "http://127.0.0.1:5000/translate";
        private static char MapSplitChar = ':';
        private static char PunctMapSplitChar = '#';

        private static List<string> Suffixes = new List<string>() {
            "Iru"
        };

        public static string GetTranslatorUrl() {

            return string.Format(TranslatorUrlKatakana);
        }

        public static async Task<string> TranslateAsync(string inText) {
            // Check if already translated / romanized
            // TODO check japanese punctuation too
            // if (IsTranslated(inText)) return inText;

            // Normalize to convert full-width characters
            inText = inText.Normalize(NormalizationForm.FormKC);

            // Split the text into separate sequential tokens and translate each token
            List<TextToken> textTokens = TextToken.GetTextTokens(inText);

            // Load maps and particles lists once
            string hirakanjiMapPath = Path.Combine(Maps.DirectoryPath, Maps.HirakanjiLatn);
            List<string> hirakanjiMaps = new List<string>(File.ReadAllLines(hirakanjiMapPath));

            string hirakanjiParticlesPath = Path.Combine(Particles.DirectoryPath, Particles.HirakanjiLatn);
            List<string> hirakanjiParticles = new List<string>(File.ReadAllLines(hirakanjiParticlesPath));

            string kataMapPath = Path.Combine(Maps.DirectoryPath, Maps.KataEn);
            List<string> kataMaps = new List<string>(File.ReadAllLines(kataMapPath));

            string kataParticlesPath = Path.Combine(Particles.DirectoryPath, Particles.KataEn);
            List<string> kataParticles = new List<string>(File.ReadAllLines(kataParticlesPath));

            string punctMapPath = Path.Combine(Maps.DirectoryPath, Maps.Punctuation);
            List<string> punctMaps = new List<string>(File.ReadAllLines(punctMapPath));

            // Translate each token and join them back together
            string outText = "";
            foreach (TextToken textToken in textTokens) {
                switch (textToken.Type) {
                    case TokenType.HiraganaKanji:
                        outText += await textToken.TranslateAsync(hirakanjiMaps, hirakanjiParticles);
                        break;

                    case TokenType.Katakana:
                        outText += await textToken.TranslateAsync(kataMaps, kataParticles);
                        break;

                    case TokenType.Latin:
                    default:
                        outText += await textToken.TranslateAsync(punctMaps);
                        break;
                }
            }

            // Normalize
            outText = outText.Normalize(NormalizationForm.FormKC);

            return outText;
        }

        public static string MapPhrases(string text, List<string> maps, char splitter) {
            if (maps == null) return text;

            foreach (string map in maps) {
                string[] mapStrings = map.Split(splitter);

                // Make sure mapping is valid
                if (map.IndexOf(splitter) == 0 || (mapStrings.Length != 1 && mapStrings.Length != 2)) continue;

                text = Regex.Replace(text,
                    mapStrings[0],
                    mapStrings[1],
                    RegexOptions.IgnoreCase);
            }

            return text;
        }

        public static string MapPhrases(string text, List<string> maps) {

            return MapPhrases(text, maps, MapSplitChar);
        }

        public static string MapPunctuations(string text, List<string> maps) {

            return MapPhrases(text, maps, PunctMapSplitChar);
        }

        public static string LowercaseParticles(string text, List<string> particles) {
            if (particles == null) return text;

            foreach (string particle in particles) {
                text = Regex.Replace(text,
                    @"\b" + particle + @"\b",
                    particle,
                    RegexOptions.IgnoreCase);
            }

            return text;
        }

        public static bool IsTranslated(string text) {
            return !text.Any(c => Unicode.IsJapanese(c.ToString()));
        }

        public static string AttachSuffixes(string text) {
            foreach (string suffix in Suffixes) {
                text = Regex.Replace(text,
                    @"\s" + suffix + @"\b",
                    suffix.ToLower());
            }

            return text;
        }

        public static string FixYouon(string text) {
            // Shi/chi: shi ~yu -> shu, etc
            text = Regex.Replace(text, @"((?i)(?:s|c)(?-i)h)i ?~y([aou])", "$1$2");
            // shi ~e -> she, etc
            text = Regex.Replace(text, @"((?i)(?:s|c)(?-i)h)i ?~([e])", "$1$2");
            // Non-shi/chi: ji ~yu -> jyu, etc
            text = Regex.Replace(text, @"((?!(?i)(?:s|c)(?-i)h))i ?~(y[aou])", "$1$2");
            // Non-shi/chi unconventional: vu ~yu -> vyu, etc
            text = Regex.Replace(text, @"((?!(?i)(?:s|c)(?-i)h))u ?~(y[aou])", "$1$2");

            // ri ~i -> ryi, etc
            text = Regex.Replace(text, @"((?i)[knhmrgjbp](?-i))i ?~([ei])", "$1y$2");

            // All others, e.g. vu ~o -> vo
            text = Regex.Replace(text, @"[iu] ?~([aeiou])", "$1");

            return text;
        }
    }
}
