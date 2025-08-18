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
using System.Windows.Shapes;

namespace InterfazDeUsuarioUI
{
    /// <summary>
    /// Lógica de interacción para InicioAdministrador.xaml
    /// </summary>
    public partial class InicioAdministrador : Window
    {
        public InicioAdministrador()
        {
            InitializeComponent();
        }
        // Método para el DataGrid SelectionChanged
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;

            if (dataGrid.SelectedItem != null)
            {
                // Procesar elemento seleccionado
                var itemSeleccionado = dataGrid.SelectedItem;

                // Si tienes una clase Raza, puedes hacer:
                // Raza razaSeleccionada = itemSeleccionado as Raza;
                // if (razaSeleccionada != null)
                // {
                //     txtId.Text = razaSeleccionada.Id.ToString();
                //     // Llenar otros campos
                // }
            }
        }

        // Método para mover la ventana
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        // Botones de la barra de título
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // Event handlers para los botones de funcionalidad
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para guardar raza
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para modificar raza
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para eliminar raza
        }

    }
}
