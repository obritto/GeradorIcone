using GeradorIcone.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeradorIcone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSelIcone_Click(object sender, RoutedEventArgs e)
        {
            string pathBase = txtPath.Text;
            string path = txtPath.Text;
            System.Drawing.Image imgOK = null;

            var dlg = FileUtil.SelecionarArquivo();

            if (dlg != null)
            {
                var objImg = System.Drawing.Image.FromFile(dlg.FileName);

                // gerar imagens iOS
                if (chkIOS.IsChecked.HasValue && chkIOS.IsChecked.Value)
                {
                    // diretório iOS
                    if (!Directory.Exists($"{pathBase}iOS"))
                    {
                        Directory.CreateDirectory($"{pathBase}iOS");
                    }
                    path = $"{pathBase}iOS\\";

                    // gerar formatos iOS
                    imgOK = objImg.Resize(120, 120);
                    imgOK.Save($"{path}Icon-60@2x.png", ImageFormat.Png);

                    imgOK = objImg.Resize(180, 180);
                    imgOK.Save($"{path}Icon-60@3x.png", ImageFormat.Png);

                    imgOK = objImg.Resize(76, 76);
                    imgOK.Save($"{path}Icon-76.png", ImageFormat.Png);

                    imgOK = objImg.Resize(152, 152);
                    imgOK.Save($"{path}Icon-76@2x.png", ImageFormat.Png);

                    imgOK = objImg.Resize(29, 29);
                    imgOK.Save($"{path}Icon-Small.png", ImageFormat.Png);

                    imgOK = objImg.Resize(58, 58);
                    imgOK.Save($"{path}Icon-Small@2x.png", ImageFormat.Png);

                    imgOK = objImg.Resize(87, 87);
                    imgOK.Save($"{path}Icon-Small@3x.png", ImageFormat.Png);

                    imgOK = objImg.Resize(40, 40);
                    imgOK.Save($"{path}Icon-Small-40.png", ImageFormat.Png);

                    imgOK = objImg.Resize(80, 80);
                    imgOK.Save($"{path}Icon-Small-40@2x.png", ImageFormat.Png);

                    imgOK = objImg.Resize(120, 120);
                    imgOK.Save($"{path}Icon-Small-40@3x.png", ImageFormat.Png);

                    imgOK = objImg.Resize(167, 167);
                    imgOK.Save($"{path}Icon-83.5@2x.png", ImageFormat.Png);
                }

                // gerar imagens Android
                if (chkDroid.IsChecked.HasValue && chkDroid.IsChecked.Value)
                {
                    // diretório android
                    if (!Directory.Exists($"{pathBase}Droid"))
                    {
                        Directory.CreateDirectory($"{pathBase}Droid");
                    }
                    pathBase = $"{pathBase}Droid\\";

                    // gerar formatos Droid

                    // drawable
                    if (!Directory.Exists($"{pathBase}drawable"))
                    {
                        Directory.CreateDirectory($"{pathBase}drawable");
                    }
                    path = $"{pathBase}drawable\\";

                    imgOK = objImg.Resize(72, 72);
                    imgOK.Save($"{path}icon.png", ImageFormat.Png);

                    // drawable-hdpi
                    if (!Directory.Exists($"{pathBase}drawable-hdpi"))
                    {
                        Directory.CreateDirectory($"{pathBase}drawable-hdpi");
                    }
                    path = $"{pathBase}drawable-hdpi\\";

                    imgOK = objImg.Resize(72, 72);
                    imgOK.Save($"{path}icon.png", ImageFormat.Png);

                    // drawable-xhdpi
                    if (!Directory.Exists($"{pathBase}drawable-xhdpi"))
                    {
                        Directory.CreateDirectory($"{pathBase}drawable-xhdpi");
                    }
                    path = $"{pathBase}drawable-xhdpi\\";

                    imgOK = objImg.Resize(96, 96);
                    imgOK.Save($"{path}icon.png", ImageFormat.Png);

                    // drawable-xxhdpi
                    if (!Directory.Exists($"{pathBase}drawable-xxhdpi"))
                    {
                        Directory.CreateDirectory($"{pathBase}drawable-xxhdpi");
                    }
                    path = $"{pathBase}drawable-xxhdpi\\";

                    imgOK = objImg.Resize(144, 144);
                    imgOK.Save($"{path}icon.png", ImageFormat.Png);
                }
            }
        }

        private void btnSelPath_Click(object sender, RoutedEventArgs e)
        {
            txtPath.Text = FileUtil.SelecionarDiretorio();
        }

        private void btnSelSplash_Click(object sender, RoutedEventArgs e)
        {
            string pathBase = txtPath.Text;
            string path = txtPath.Text;
            System.Drawing.Image imgOK = null;

            var dlg = FileUtil.SelecionarArquivo();

            if (dlg != null)
            {
                var objImg = System.Drawing.Image.FromFile(dlg.FileName);

                // gerar imagens iOS
                if (chkIOS.IsChecked.HasValue && chkIOS.IsChecked.Value)
                {
                    // diretório iOS
                    if (!Directory.Exists($"{pathBase}iOS"))
                    {
                        Directory.CreateDirectory($"{pathBase}iOS");
                    }
                    path = $"{pathBase}iOS\\";

                    // gerar formatos iOS
                    imgOK = objImg.Resize(320, 480);
                    imgOK.Save($"{path}Default.png", ImageFormat.Png);

                    imgOK = objImg.Resize(640, 960);
                    imgOK.Save($"{path}Default@2x.png", ImageFormat.Png);

                    imgOK = objImg.Resize(640, 1136);
                    imgOK.Save($"{path}Default-568h@2x.png", ImageFormat.Png);

                    imgOK = objImg.Resize(768, 1004);
                    imgOK.Save($"{path}Default-Portrait.png", ImageFormat.Png);

                    imgOK = objImg.Resize(1536, 2008);
                    imgOK.Save($"{path}Default-Portrait@2x.png", ImageFormat.Png);
                }


                // gerar imagens Android
                if (chkDroid.IsChecked.HasValue && chkDroid.IsChecked.Value)
                {
                    // diretório android
                    if (!Directory.Exists($"{pathBase}Droid"))
                    {
                        Directory.CreateDirectory($"{pathBase}Droid");
                    }
                    pathBase = $"{pathBase}Droid\\";

                    // gerar formatos Droid

                    // drawable
                    if (!Directory.Exists($"{pathBase}drawable"))
                    {
                        Directory.CreateDirectory($"{pathBase}drawable");
                    }
                    path = $"{pathBase}drawable\\";

                    imgOK = objImg.Resize(320, 480);
                    imgOK.Save($"{path}splash.png", ImageFormat.Png);

                    // drawable-hdpi
                    if (!Directory.Exists($"{pathBase}drawable-hdpi"))
                    {
                        Directory.CreateDirectory($"{pathBase}drawable-hdpi");
                    }
                    path = $"{pathBase}drawable-hdpi\\";

                    imgOK = objImg.Resize(480, 720);
                    imgOK.Save($"{path}splash.png", ImageFormat.Png);

                    // drawable-xhdpi
                    if (!Directory.Exists($"{pathBase}drawable-xhdpi"))
                    {
                        Directory.CreateDirectory($"{pathBase}drawable-xhdpi");
                    }
                    path = $"{pathBase}drawable-xhdpi\\";

                    imgOK = objImg.Resize(640, 960);
                    imgOK.Save($"{path}splash.png", ImageFormat.Png);

                    // drawable-xxhdpi
                    if (!Directory.Exists($"{pathBase}drawable-xxhdpi"))
                    {
                        Directory.CreateDirectory($"{pathBase}drawable-xxhdpi");
                    }
                    path = $"{pathBase}drawable-xxhdpi\\";

                    imgOK = objImg.Resize(960, 1440);
                    imgOK.Save($"{path}splash.png", ImageFormat.Png);
                }

            }
        }

    }
}
