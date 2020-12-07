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
using WinPannel.Models;

namespace WinPannel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ProgrammClass> programms;
        public MainWindow()
        {
            InitializeComponent();

            programms = new List<ProgrammClass>();

            this.programms.Add(new ProgrammClass() { NameProgram = "Android Studio", ImagePath="Images/android_studio.png" });
            this.programms.Add(new ProgrammClass() { NameProgram = "Visual Studio Code", ImagePath="Images/vscode.png" });
            this.programms.Add(new ProgrammClass() { NameProgram = "Google Chrome", ImagePath="Images/gchrome.png" });
            this.programms.Add(new ProgrammClass() { NameProgram = "MongoDB Compass", ImagePath="Images/mongoCompass.png" });
            this.programms.Add(new ProgrammClass() { NameProgram = "Spotify", ImagePath="Images/spotify.png" });
            this.programms.Add(new ProgrammClass() { NameProgram = "docker Desktop", ImagePath="Images/docker.png" });
            this.programms.Add(new ProgrammClass() { NameProgram = "Node.js", ImagePath="Images/nodejs.png" });
            this.programms.Add(new ProgrammClass() { NameProgram = "Python 3.9", ImagePath="Images/python39.png" });
            this.programms.Add(new ProgrammClass() { NameProgram = "Telegram Desktop", ImagePath="Images/telegram.png" });
            this.programms.Add(new ProgrammClass() { NameProgram = "Counter-Strike: Global Offensive", ImagePath = "Images/csgo.png" });
            this.ProgramListView.ItemsSource = this.programms;
            this.ProgramListView.Items.Refresh();
        }

        private void ProgramListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var myList = sender as ListView;
            var value = myList.SelectedItem as ProgrammClass;
            var window = new AboutProgram(value);
            window.ShowDialog();
        }
    }
}
