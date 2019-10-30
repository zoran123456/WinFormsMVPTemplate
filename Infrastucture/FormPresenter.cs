using System;
using System.Windows.Forms;

namespace WinFormsMVPTemplate.Infrastructure
{
    public class FormPresenter<T> : Form where T : IFormPresenter
    {
        T _p;

        public T Presenter
        {
            get
            {
                if (ReferenceEquals(_p, null))
                {
                    _p = (T)Activator.CreateInstance(typeof(T), new object[] { this });
                }

                return _p;
            }
        }

    }
}
