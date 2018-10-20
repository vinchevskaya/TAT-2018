namespace DEV_2
{
    /// <summary>
    /// This is the entry point to the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Translator transliter = new Translator();
            transliter.TranslationProcess(args);
        }   
    }
}