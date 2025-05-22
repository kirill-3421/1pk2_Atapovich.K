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
      /*
       Создайте окно для ввода информации о студенте (отдельно фамилия, имя , отчество, группа, пол – перечисление, 
     дата рождения (календарь)) 
       При нажатии на кнопку «сохранить» данные о студенте сохраняются во внутренний список связанный с ListBox
       При закрытии приложения данные сериализируются в файл
      */
namespace Task_38_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private College _college = new();
        public MainWindow()
        {
            InitializeComponent();
            genderComboBox.SelectedIndex = 1;
            studentsListBox.ItemsSource = _college.Students;
        }

        private bool Validate(out string error)
        {
            error = "";
            if(string.IsNullOrEmpty(surnameTextBox.Text))
            {
                error += "Фамилия пуста\n";
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                error += "Имя пусто\n";
            }
            else if (string.IsNullOrEmpty(patronymicTextBox.Text))
            {
                error += "Отчество пусто\n";
            }
            else if (string.IsNullOrEmpty(groupTextBox.Text))
            {
                error += "Поле группы пуста\n";
            }

            if(error.Length > 0)
            {
                return false;
            }
            return true;
        }

        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if(!Validate(out string errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            Student student = new Student(
                surnameTextBox.Text,
                nameTextBox.Text,
                patronymicTextBox.Text,
                groupTextBox.Text,
                (GenderOfStudents)genderComboBox.SelectedIndex,
                BirthDate.SelectedDate ?? DateTime.Now
                );

            _college.AddStudent(student);
            studentsListBox.Items.Refresh();
            Clear();
        }

        private void deleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            surnameTextBox.Clear();
            nameTextBox.Clear();
            patronymicTextBox.Clear();
            groupTextBox.Clear();
            genderComboBox.SelectedIndex = 1;
            BirthDate.SelectedDate = DateTime.Now;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _college.Load();
            studentsListBox.ItemsSource = _college.Students;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _college.Save();
        }

        private void deleteStudentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var item = studentsListBox.SelectedItem;
            if (item != null && item is Student student)
            {
                _college.RemoveStudent(student);
                studentsListBox.Items.Refresh();
            }
        }

        private void showStudentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShowStudentInfo();
        }

        private void ShowStudentInfo()
        {
            var item = studentsListBox.SelectedItem;
            if(item != null && item is Student student)
            {
                MessageBox.Show($"{student.Surname} {student.Name} {student.Patronymic}\n" +
                    $"Группа - {student.Group}\n" +
                    $"Пол - {student.GenderOfStudents}\n" +
                    $"День рождения - {student.BirthDate}");
            }
        }

        private void studentsListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ShowStudentInfo();
        }
    }
}