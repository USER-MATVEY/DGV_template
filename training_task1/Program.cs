using DataGrid.Framework.PeopleManager;
using DataGrid.Storage.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace training_task1
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

            var storage = new MemoryPeopleStorage();
            var manager = new PeopleManager(storage);
            
            Application.Run(new Journal(manager));
        }
    }
}
