using System;
using System.Collections.Generic;
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
using System.IO;

namespace TemplateHomeWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSaveClick(object sender, RoutedEventArgs e)
        {

                var dataRichTextBox = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text;
            try
            {
                using (var stream = new StreamReader(nameDocument.Text + ".txt"))
                {
                    MessageBox.Show("Такое имя файла уже есть!");
                }
            }
            catch
            {
            using (var stream = new StreamWriter(nameDocument.Text + ".txt"))
            {
                stream.WriteLine(dataRichTextBox);
                stream.Close();
            }
            }

            
            

        }
    }
}
