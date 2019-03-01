using GameLib;
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

namespace GameView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Core GameCore { get; set; }
        private GameViewModel ViewModel { get; set; }

        public MainWindow()
        {
            MainWindowInitializer initialize = new MainWindowInitializer(this);
            initialize.Model();
            
            InitializeComponent();
        }





        /* ----- Initialization */

        private class MainWindowInitializer
        {
            private MainWindow window;

            internal MainWindowInitializer(MainWindow mainWindow)
            {
                window = mainWindow;
            }

            public void Model()
            {
                GameViewModel viewmodel = new GameViewModel();
                window.ViewModel = viewmodel;
                window.DataContext = viewmodel;

                window.GameCore = new Core(500);
                window.GameCore.RegisterEntity(viewmodel.Player);
                window.GameCore.Start();
            }
        }
    }
}
