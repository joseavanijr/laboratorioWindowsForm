using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanoDeSaude.Formularios;

namespace PlanoDeSaude
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //FORMULARIO PRINCIPAL DEVE SER O PRIMEIRO A SER ATIVO QUANDO FOR EXECUTADO, aterar aqui. ( Colocar nome do Form )  ↓↓↓↓
            Application.Run(new FrmPrincipal());
        }
    }
}
