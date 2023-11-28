using XIIRPL1_04_Ticketing.MasterForm;

namespace XIIRPL1_04_Ticketing
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
            //FrmLogin login = new FrmLogin();
            //login.Show();
            //Application.Run();

            //FrmMasterBd bandara = new FrmMasterBd();
            //bandara.Show();
            //Application.Run();

            //JP penerbangan = new JP();
            //penerbangan.Show();
            //Application.Run();


            //FrmMasterMk maskapai = new FrmMasterMk();
            //maskapai.Show();
            //Application.Run();

            FrmMasterKP promo = new FrmMasterKP();
            promo.Show();
            Application.Run();

        }
    }
}