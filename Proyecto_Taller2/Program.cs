using Proyecto_Taller2.C_Presentacion.Administrador;
using Proyecto_Taller2.C_Presentacion.Supervisor;

using Proyecto_Taller2.C_Presentaciones;

namespace Proyecto_Taller2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Principal_Admin());
            //Application.Run(new FormularioPrincipalSupervisor());
            Application.Run(new MenuVendedor());
        }
    }
}