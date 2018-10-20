using System;
using System.Text;

namespace DEV_2
{
    public class Translator
    {
        /// <summary>
        /// Conversion of a string to translait.
        /// </summary>
        public void TranslationProcess(string[] args)
        {
            StringBuilder BuilderForEnteredString = new StringBuilder();
            foreach (var a in args)
            {
                BuilderForEnteredString.Append(a);
            }
            string enteredString = BuilderForEnteredString.ToString().ToUpper();
            char[] enteredCharArray = enteredString.ToCharArray();
            StringBuilder BuilderForFinishedString = new StringBuilder();
            string[] russianLetter = {"А","Б","В","Г","Д","Е","Ё","Ж","З","И","Й","К","Л","М","Н",
                                      "О","П","Р","С","Т","У","Ф","Х","Ц","Ч","Ш", "Щ", "Ъ", "Ы",
                                      "Ь","Э","Ю", "Я", " "};
            string[] englishLetter = {"A","B","V","G","D","E","YO","ZH","Z","I","Y","K","L","M","N",
                                      "O","P","R","S","T","U","F","KH","TS","CH","SH","SCH",null,"Y",
                                      null,"E","YU","YA", };
            for (int i = 0; i < enteredCharArray.Length; i++)
            {
                for (int j = 0; j < russianLetter.Length; j++)
                {
                    if (enteredString.Substring(i, 1) == russianLetter[j])
                    {
                        BuilderForFinishedString.Append(englishLetter[j]);
                    }
                }
            }
            for (int s = 0; s < enteredCharArray.Length; s++)
            {
                for (int t = 0; t < englishLetter.Length; t++)
                {
                    if (enteredString.Substring(s, 1) == englishLetter[t])
                    {
                        BuilderForFinishedString.Append(russianLetter[t]);
                    }
                }
            }
            Console.WriteLine("Сonverted string: " + BuilderForFinishedString);            
        }      
    }
}