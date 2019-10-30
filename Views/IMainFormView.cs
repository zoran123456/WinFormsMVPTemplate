namespace WinFormsMVPTemplate.Views
{

    public interface IMainFormView
    {
        string SomeTextValue { get; set; }

        void SaveChangesComplete();
    }

}
