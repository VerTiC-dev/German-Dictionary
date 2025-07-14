using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace German_Dictionary
{
    public static class JSON
    {
        private const string NEW_WORDS_PATH = "words/new_words.json";
        private const string LEARNED_WORDS_PATH = "words/learned_words.json";

        public static string SerializeWords(List<Word> words)
        {
            return JsonSerializer.Serialize(words);
        }

        public static List<Word> DeserializeWords()
        {
            // just for test
            string json = File.ReadAllText(LEARNED_WORDS_PATH);
            return JsonSerializer.Deserialize<List<Word>>(json);
        }
    }

    public class Word(string translation, string singular, string plural, string article, DateTime time)
    {
        [JsonPropertyName("translation")]
        public string Translation { get; set; } = translation;

        [JsonPropertyName("article")]
        public string Article { get; set; } = article;

        [JsonPropertyName("singular")]
        public string Singular { get; set; } = singular;

        [JsonPropertyName("plural")]
        public string Plural { get; set; } = plural;

        [JsonPropertyName("time")]
        public DateTime Time { get; set; } = time;
    }
}
