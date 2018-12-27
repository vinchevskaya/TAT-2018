namespace DEV_10.Pages
{
    public static class Pages
    {
        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                return loginPage;
            }
        }

        public static PageHealth PageHealth
        {
            get
            {
                var pageHealth = new PageHealth();
                return pageHealth;
            }
        }
    }
}