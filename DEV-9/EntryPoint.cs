using System;

namespace DEV_9
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            FakeUser fakeUser = new FakeUser();

            try
            {
                fakeUser.StartBrowser();
                fakeUser.Test();
                fakeUser.CloseBrowser();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }           
        }
    }
}