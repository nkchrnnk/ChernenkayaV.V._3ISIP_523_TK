using Avalonia.Controls;          // Базовые UI-элементы Avalonia (Window, TextBox и т.д.)
using Avalonia.Interactivity;    // Поддержка событий (например, Click)
using System;                    // Базовые классы .NET (Convert, Exception)

namespace tk;
/// <summary>
/// Логика взаимодействия для MainWindow.xaml
/// Главное окно приложения для работы калькулятора
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// Конструктор окна, загрузка данных
    /// Инициализирует компоненты главного окна приложения
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Обработчик нажатия кнопки "Вычислить".
    /// Считывает введенные пользователем значения, выполняет выбранную
    /// арифметическую операцию и выводит результат в поле результата.
    /// Также обрабатывает ошибки ввода и деление на ноль.
    /// </summary>
    /// <param name="sender">Источник события (кнопка "Вычислить")</param>
    /// <param name="e">Аргументы события, содержащие информацию о нажатии</param>
    private void Calculate_Click(object? sender, RoutedEventArgs e)
    {
        try
        {
            
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            double result = 0; 
            
            if (rbPlus.IsChecked == true)
                result = a + b; 

            else if (rbMinus.IsChecked == true)
                result = a - b; 

            else if (rbMultiply.IsChecked == true)
                result = a * b;

            else if (rbDivide.IsChecked == true)
            {
                if (b == 0)
                {
                    txtResult.Text = "Деление на 0!"; 
                    return; 
                }

                result = a / b;
            }
            
            txtResult.Text = result.ToString();
        }
        catch
        {
            txtResult.Text = "Ошибка ввода";
        }
    }
}