using System;

namespace WinFormsMVPTemplate.Models
{
    public interface IMainFormModel
    {
        void SaveChanges();

        event EventHandler SaveChangesComplete;

        string TextValue { get; set; }
    }
}
