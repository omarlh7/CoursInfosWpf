using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoursInfosWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Cours> ListeCours { get; set; }
        public Cours SelectedCourse { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            // Liaison du DataContext à la fenêtre pour permettre le binding
            this.DataContext = this;

            // Initialisation de la liste avec des cours
            ListeCours = new ObservableCollection<Cours>
{
new Cours { Nom = "Gestion", Code = "1", NombreHeure = 40 },
new Cours { Nom = "Programmation", Code = "2", NombreHeure = 35 },
new Cours { Nom = "Developpement WEB", Code = "3", NombreHeure = 40 }
};
        }

    }
}