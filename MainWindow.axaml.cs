
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacion;
public partial class MainWindow : Window
{
    private bool saludoAlternativo = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Presentarme_Click(object? sender, RoutedEventArgs e)
    {
        string nombre = Nombre.Text?.Trim() ?? "";
        string apellido = Apellido.Text?.Trim() ?? "";
        if (string.IsNullOrWhiteSpace(nombre))
        {
            Mensaje.Text = "Por favor, ingrese su nombre.";
            return;
        }
        if (string.IsNullOrWhiteSpace(apellido))
        {
            Mensaje.Text = "Por favor, ingrese su apellido.";
            return;
        }
        if (!int.TryParse(Edad.Text, out int edad) || edad <= 0)
        {
            Mensaje.Text = "Por favor, ingrese una edad válida.";
            return;
        }
        Mensaje.Text = "¡Hola! Mi nombre es " + nombre + " " + apellido +
                       ", tengo " + edad + " años y estoy aprendiendo " +
                       "a desarrollar interfaces gráficas con C#.";
    }

    private void Limpiar_Click(object? sender, RoutedEventArgs e)
    {
        Nombre.Text = "";
        Apellido.Text = "";
        Edad.Text = "";
        Mensaje.Text = "Aquí aparecerá tu presentación.";
        Nombre.Focus();
    }

    private void CambiarSaludo_Click(object? sender, RoutedEventArgs e)
    {
        if (saludoAlternativo == false)
        {
            Mensaje.Text = "¡Bienvenido! Estoy aprendiendo a crear aplicaciones con Avalonia UI y C#.";
            saludoAlternativo = true;
        }
        else
        {
            Mensaje.Text = "¡Hola! Gracias por visitar mi primera aplicación.";
            saludoAlternativo = false;
        }
    }
}
