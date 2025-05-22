using Microsoft.Win32;
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
using System.IO;

namespace Task_39_02
{
    /*
     Создайте приложение – список покупок. Использовать ListBox. В качестве источника данных использовать не List а ObservableCollection
         Функции:
           • Ввод продуктов
           • Сохранение списка продуктов в текстовый файл
           • Использовать стандартные диалоговые окна
     */
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> shoppingItems = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            ShoppingListBox.ItemsSource = shoppingItems;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewItemTextBox.Text))
            {
                shoppingItems.Add(NewItemTextBox.Text);
                NewItemTextBox.Clear();
                UpdateStatus("Продукт добавлен");
            }
            else
            {
                UpdateStatus("⚠ Введите название продукта", "#FFF44336");
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ShoppingListBox.SelectedItem != null)
            {
                shoppingItems.Remove((string)ShoppingListBox.SelectedItem);
                UpdateStatus("Продукт удалён");
            }
            else
            {
                UpdateStatus("Выберите продукт для удаления");
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveDialog.FileName = "Мой список покупок.txt";

            if (saveDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllLines(saveDialog.FileName, shoppingItems);
                    UpdateStatus($"Список сохранён в {saveDialog.FileName}");
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Ошибка сохранения: {ex.Message}");
                }
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (openDialog.ShowDialog() == true)
            {
                try
                {
                    string[] items = File.ReadAllLines(openDialog.FileName);
                    shoppingItems.Clear();
                    foreach (var item in items)
                    {
                        shoppingItems.Add(item);
                    }
                    UpdateStatus($"Загружено {shoppingItems.Count} продуктов");
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Ошибка загрузки: {ex.Message}");
                }
            }
        }

        private void UpdateStatus(string message, string backgroundColor = "#FFEEE8AA")
        {
            StatusText.Text = message;          
        }
    }
}
