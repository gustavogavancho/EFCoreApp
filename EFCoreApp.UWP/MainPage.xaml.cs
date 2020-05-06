using EFCoreApp.Data;
using EFCoreApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EFCoreApp.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new EFCoreDbContext())
            {
                var clientes = db.Clientes.ToList();
                if (clientes != null)
                {
                    ClientesListView.ItemsSource = clientes;
                }
            }
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new EFCoreDbContext())
            {
                int dni;
                int.TryParse(DniTextBox.Text, out dni);

                var cliente = new Cliente
                {
                    Nombres = NombreTextBox.Text,
                    Apellidos = ApellidosTextBox.Text,
                    Dni = dni,
                    Direccion = DireccionTextBox.Text,
                };

                db.Clientes.Add(cliente);
                db.SaveChanges();
                ClientesListView.ItemsSource = db.Clientes.ToList();
            }
        }
    }
}
