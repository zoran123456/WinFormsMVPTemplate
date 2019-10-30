using System;

namespace WinFormsMVPTemplate.Models
{

    public class MainFormModel : IMainFormModel
    {
        public string TextValue { get; set; }

        public event EventHandler SaveChangesComplete;

        public void SaveChanges()
        {
            // TODO save to DB

            SaveChangesComplete?.Invoke(null, EventArgs.Empty);

        }

    }
}
