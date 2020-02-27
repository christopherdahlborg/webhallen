using System;
using System.Collections.Generic;

namespace Festival
{
    class Program
    {
        static void Main(string[] args)
        {
            Festival.PrintFestivalInformation();
            Console.ReadKey();
        }
    }

    static class Festival
    {
        private static string festivalName = "Codeworld";
        private static string festivalDescription = @"Codeworld is the next gen festival for passionate coders who would love to attend to a festival where all communication with other attendees is handled through writing code, in your desirable language.
Having trouble understanding someone? Why not learn their language. We have many linguists who speak languages from Java, C#, C++, C, PHP etc. 
Understanding someone speaking a different language can definitely be problematic for many people and therefore we include some of the most popular dictionaries here.";

        public static void PrintFestivalInformation()
        {
            Console.WriteLine($"Festival: {festivalName}\nDescription: {festivalDescription}");
            PrintLanguages();
        }

        private static void PrintLanguages()
        {
            Console.WriteLine("------------------------------Languages------------------------------");
            foreach (Language language in GetLanguages())
            {
                Console.WriteLine($"Language: {language.Name}\nDictionary: {language.DictionaryLink}\n");
            }
        }

        private static List<Language> GetLanguages()
        {
            List<Language> languages = new List<Language>();

            languages.Add(new Language { Name = "C#", DictionaryLink = "https://docs.microsoft.com/en-us/dotnet/csharp/" });
            languages.Add(new Language { Name = "C++", DictionaryLink = "https://docs.microsoft.com/en-us/cpp/?view=vs-2019" });
            languages.Add(new Language { Name = "C", DictionaryLink = "https://docs.microsoft.com/en-us/cpp/c-language/c-language-reference?view=vs-2019" });
            languages.Add(new Language { Name = "Java", DictionaryLink = "https://docs.oracle.com/javase/tutorial/" });
            languages.Add(new Language { Name = "PHP", DictionaryLink = "https://www.php.net/manual/en/" });
            languages.Add(new Language { Name = "PowerShell", DictionaryLink = "https://docs.microsoft.com/sv-se/powershell/scripting/overview?view=powershell-7" });
            languages.Add(new Language { Name = "Python", DictionaryLink = "https://docs.python.org/3/" });
            languages.Add(new Language { Name = "Swift", DictionaryLink = "https://docs.swift.org/swift-book/LanguageGuide/TheBasics.html" });

            return languages;
        }
    }

    class Language
    {
        public string Name { get; set; }
        public string DictionaryLink { get; set; }
    }
}

