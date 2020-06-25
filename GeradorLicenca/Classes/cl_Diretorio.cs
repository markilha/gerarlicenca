using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GeradorLicenca
{
    public class cl_Diretorio
    {
      
        public static string CaminhoSalva(string filtro, string diretorio, string nome)
        {
            string caminho = "";
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = filtro;
            fileDialog.InitialDirectory = diretorio;
            fileDialog.Title = "Selecione o caminho para salvar";
            fileDialog.FileName = nome;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = fileDialog.FileName;               

                FileInfo fileInfo = new FileInfo(fileDialog.FileName);               

                //Mostra a extensão do arquivo
                string fileExtension = fileInfo.Extension;
                //Mostra o caminho completo do arquivo junto com o nome
                string fileFullName = fileInfo.FullName;

            }

            return caminho;
        }
        public static string CaminhoSalva(string filtro, string titulo, string diretorio, string nome)
        {
            string caminho = "";
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = filtro;
            fileDialog.InitialDirectory = diretorio;
            fileDialog.Title = titulo;
            fileDialog.FileName = nome;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = fileDialog.FileName;

                FileInfo fileInfo = new FileInfo(fileDialog.FileName);  

                //Mostra a extensão do arquivo
                string fileExtension = fileInfo.Extension;
                //Mostra o caminho completo do arquivo junto com o nome
                string fileFullName = fileInfo.FullName;

            }

            return caminho;
        }
        static public string CaminhoAbrir(string filtro, string diretorio)
        {
            string caminho = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = filtro;
            fileDialog.InitialDirectory = diretorio;
            fileDialog.Title = "Selecione o objeto...";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = fileDialog.FileName;

            }

            return caminho;
        }
        static public string CaminhoAbrir(string filtro,string titulo, string diretorio)
        {
            string caminho = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = filtro;
            fileDialog.InitialDirectory = diretorio;
            fileDialog.Title = titulo;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = fileDialog.FileName;

            }

            return caminho;
        }
        public static string PastaDiretorio()
        {
            string caminho = "";

            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                folder.ShowNewFolderButton = true;             
                folder.Description = "Escolha a pasta para Salvar!";

                if (folder.ShowDialog() == DialogResult.OK)
                {
                    caminho = folder.SelectedPath;
                }
                else
                {
                    caminho = "";
                }
            }
          
            return caminho;
        }
    }
}
