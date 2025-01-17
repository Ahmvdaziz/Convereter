namespace Convereter.Models
{
    public class LanguageConverter
    {
        private static readonly Dictionary<char, string> ArabicToFranco = new Dictionary<char, string>
    {
        {'ا', "a"}, {'ب', "b"}, {'ت', "t"}, {'ث', "th"}, {'ج', "g"},
        {'ح', "7"}, {'خ', "5"}, {'د', "d"}, {'ذ', "z"}, {'ر', "r"},
        {'ز', "z"}, {'س', "s"}, {'ش', "4"}, {'ص', "9"}, {'ض', "9'"},
        {'ط', "6"}, {'ظ', "z"}, {'ع', "3"}, {'غ', "gh"}, {'ف', "f"},
        {'ق', "8"}, {'ك', "k"}, {'ل', "l"}, {'م', "m"}, {'ن', "n"},
        {'ه', "h"}, {'و', "w"}, {'ي', "y"}, {'ء', "2"}
    };

        private static readonly Dictionary<string, char> FrancoToArabic = new Dictionary<string, char>
    {
        {"a", 'ا'}, {"b", 'ب'}, {"t", 'ت'}, {"th", 'ث'}, {"g", 'ج'},
        {"7", 'ح'}, {"5", 'خ'}, {"'7", 'خ'}, {"d", 'د'}, {"z", 'ز'},
        {"s", 'س'}, {"4", 'ش'}, {"9", 'ص'}, {"9'", 'ض'}, {"6", 'ط'},
        {"3", 'ع'}, {"gh", 'غ'}, {"f", 'ف'}, {"8", 'ق'}, {"k", 'ك'},
        {"l", 'ل'}, {"m", 'م'}, {"n", 'ن'}, {"h", 'ه'}, {"w", 'و'},
        {"y", 'ي'}, {"2", 'ء'}
    };

        public static string ConvertToFranco(string arabicText)
        {
            return string.Concat(arabicText.Select(c => ArabicToFranco.ContainsKey(c) ? ArabicToFranco[c] : c.ToString()));
        }

        public static string ConvertToArabic(string francoText)
        {
            string result = francoText;
            foreach (var pair in FrancoToArabic.OrderByDescending(kvp => kvp.Key.Length))
            {
                result = result.Replace(pair.Key, pair.Value.ToString());
            }
            return result;
        }
    }

}