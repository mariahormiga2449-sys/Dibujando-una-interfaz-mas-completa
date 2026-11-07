# MiPresentacion_MariaHormiga

## Descripción de la aplicación

MiPresentacion es una aplicación de escritorio que permite ingresar el nombre, apellido y edad de una persona para mostrar una presentación personalizada.

## Controles utilizados

- **TextBlock:** muestra el título de la aplicación y el mensaje de resultado.
- **TextBox:** permite ingresar el nombre, apellido y edad.
- **Button Presentarme:** permite generar la presentación.
- **Button Limpiar:** borra la información ingresada y restaura el mensaje inicial.
- **Button Cambiar saludo:** permite alternar entre dos mensajes diferentes.
- **StackPanel:** organiza los controles de la interfaz mediante las propiedades Margin y Spacing.
- **x:Name:** identifica los controles que se utilizan desde el código C#.

## Funcionamiento de los eventos

- **Presentarme_Click:** obtiene los datos ingresados, verifica que el nombre y el apellido no estén vacíos y comprueba que la edad sea un número entero positivo mediante int.TryParse(). Si los datos son correctos, muestra una presentación personalizada; de lo contrario, muestra una advertencia.
- **Limpiar_Click:** vacía los campos, restaura el mensaje inicial y coloca el cursor en el campo del nombre mediante Focus().
- **CambiarSaludo_Click:** alterna entre dos mensajes de saludo sin necesidad de cerrar la aplicación.

## Instrucciones para ejecutar el programa

1. Abrir la carpeta del proyecto en Visual Studio Code.
2. Abrir una terminal.
3. Ejecutar el comando dotnet restore.
4. Ejecutar el comando dotnet run.

## Pregunta de reflexión

**¿Cuál es la función de MainWindow.axaml y MainWindow.axaml.cs, y cómo se relacionan mediante x:Name y los eventos Click para permitir que el usuario interactúe con la aplicación?**

MainWindow.axaml es el archivo donde se diseña la parte visual de la aplicación, es decir, donde se agregan los campos de texto, botones y mensajes que ve el usuario. Por otro lado, MainWindow.axaml.cs contiene el código C# que permite que esos elementos realicen acciones.

Ambos archivos se relacionan mediante x:Name, que permite identificar los controles para utilizarlos desde C#. También se conectan mediante los eventos Click, que ejecutan un método cuando el usuario presiona un botón. De esta manera, la interfaz y el código trabajan juntos para recibir información, validarla y mostrar resultados.