namespace ProjetoUninove.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using Forms;
    using Model;
    using TesteTecnico2023.Forms;

    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /*Vehicle vehicle = new Car();

            vehicle.ModelName = "Ferrari";

            Console.WriteLine(vehicle.ModelName);
            Console.ReadKey();*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login1());
        }
    }
}
