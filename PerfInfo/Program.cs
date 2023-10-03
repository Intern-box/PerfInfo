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

            ViewForm viewForm = new ViewForm();
            Model model = new Model();
            Presenter presenter = new Presenter(viewForm, model);
            viewForm.presenter = presenter;

            Application.Run(viewForm);
        }
    }
}
