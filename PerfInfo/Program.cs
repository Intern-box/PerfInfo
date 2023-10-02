using System;
using System.Windows.Forms;
using ModelSpace;
using ViewSpace;
using PresenterSpace;

namespace ProgramSpace
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            ViewForm viewForm = new ViewForm();
            Presenter presenter = new Presenter(viewForm, model);
            viewForm.presenter = presenter;

            Application.Run(viewForm);
        }
    }
}
