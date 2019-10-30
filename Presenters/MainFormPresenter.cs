using System;
using System.Linq;
using WinFormsMVPTemplate.Infrastructure;
using WinFormsMVPTemplate.Models;
using WinFormsMVPTemplate.Views;

namespace WinFormsMVPTemplate.Presenters
{

    public class MainFormPresenter : IFormPresenter
    {
        readonly IMainFormView view;
        readonly IMainFormModel model;


        string textValue;


        public MainFormPresenter(IMainFormView view)
        {
            this.view = view;
            this.model = Global.Services.GetService<IMainFormModel>();

            this.model.SaveChangesComplete += Model_SaveChangesComplete;
        }


        private void Model_SaveChangesComplete(object sender, EventArgs e)
        {

            view.SaveChangesComplete();

        }


        public void ChangeCase()
        {
            textValue = view.SomeTextValue.Trim();
            textValue = reverse(textValue);
            textValue = changeCase(textValue);

            // Set value back to a View (Form)
            view.SomeTextValue = textValue;
        }

        private string reverse(string s)
        {
            var temp = s.ToArray().Reverse().ToArray();

            return new string(temp);
        }
        
        private string changeCase(string s)
        {
            if (s.Length == 0)
                return s;

            if (char.IsUpper(s[0]))
                return s.ToLower();
            else
                return s.ToUpper();
        }

        public void SaveChanges()
        {

            model.TextValue = textValue;

            model.SaveChanges();

        }
    }
}
