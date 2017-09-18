using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorIcone.Helpers
{
    public class FileUtil
    {
        public static Microsoft.Win32.OpenFileDialog SelecionarArquivo()
        {
            Microsoft.Win32.OpenFileDialog openFileDialog1 = 
                new Microsoft.Win32.OpenFileDialog();
            openFileDialog1.Filter = "Imagem png|*.png";
            openFileDialog1.Title = "Selecionar imagem";

            var resp = openFileDialog1.ShowDialog();

            if (resp.HasValue && resp.Value)
            {

                return openFileDialog1;
            }
            else
            {
                return null;
            }
        }

        public static string SelecionarDiretorio()
        {
            var selecionaDiretorio = new FolderBrowserDialog();

            var resultado = selecionaDiretorio.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                return selecionaDiretorio.SelectedPath;
            }
            return null;
        }

    }
}
