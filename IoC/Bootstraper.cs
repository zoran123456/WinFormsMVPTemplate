namespace WinFormsMVPTemplate.IoC
{
    public static class Bootstraper
    {

        public static void AddServices()
        {

            Global.Services.AddService<Models.IMainFormModel>(new Models.MainFormModel());

        }

    }

}
