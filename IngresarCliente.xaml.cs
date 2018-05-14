using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using slnExamen3.Common;
using slnExamen3.DTOs;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace slnExamen3
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class IngresarCliente : Page
    {

        Database database;

        public IngresarCliente()
        {
            this.InitializeComponent();
            this.database = new Database();
            updateList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.database.Insert(new Client(){
                Name = txtName.Text.Trim(),
                Surname = txtSurname.Text.Trim()
            });
            updateList();
            cleanBoxes();
        }

        private void updateList()
        {
            lstClients.ItemsSource = null;
            lstClients.ItemsSource = this.database.getClients();
        }

        private void cleanBoxes()
        {
            txtName.Text = "";
            txtSurname.Text = "";
        }
    }
}
