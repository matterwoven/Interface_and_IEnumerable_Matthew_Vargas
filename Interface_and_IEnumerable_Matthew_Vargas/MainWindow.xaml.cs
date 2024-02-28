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

namespace Interface_and_IEnumerable_Matthew_Vargas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassRoster prog124 = new ClassRoster();
        public MainWindow()
        {
            InitializeComponent();
            Preload();
            //OpenAndCloseLogicWork();
            //  ^Would be unannotated, but because this is now a wpf form it contains invalid logic

        }
        public void Preload()
        {
            ClassRoster prog124 = new ClassRoster();

            prog124.AddStudent("Will", "Cram", 100, 95);
            prog124.AddStudent("Anne", "Nyugen", 10, 24);
            prog124.AddStudent("Hannah", "Angel", 58, 82);
            prog124.AddStudent("Dylan", "Register", 30, 74);
            prog124.AddStudent("Krystyn", "Taniguchi", 95, 65);
        }
        public void DisplayStudents() 
        {
            lbStudents.Items.Clear();

            foreach (Student student in prog124.ClassList) //whenever ClassList is removed the code runs red in the ClassRoster class, I followed the steps and I have become confused
            {
                lbStudents.Items.Add(student);
            }
        }
        public void OpenAndCloseLogicWork() 
        {
            Door door = new Door();
            Bottle bottle = new Bottle();
            Chest chest = new Chest();

            List<IOpen> openableItems = new List<IOpen>();
            openableItems.Add(door);
            openableItems.Add(bottle);
            openableItems.Add(chest);
            openableItems[0].Open();        }
    }
}
