using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.Win32;
using SAPBusinessObjects.WPF.Viewer;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PrimerProgramaCrystalReport
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ReportDocument reportDocument = new ReportDocument();
        public Window1()
        {
            InitializeComponent();
            reportViewer.Owner = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string reportPath = @"C:\Users\Alumno\Desktop\Interfaces\INFORMES\375F1D7E272E9937509FBB019A6F1.rpt";

               
                reportDocument.Load(reportPath);

                

                reportViewer.ViewerCore.ReportSource = reportDocument;

            }
            catch
            {
                MessageBox.Show("Error al cargar el reporte");
            }
        }

        private void botoncico_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (reportDocument == null || reportDocument.IsLoaded == false)
                {
                    MessageBox.Show("Primero debes cargar un reporte.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files|*.pdf",
                    Title = "Guardar informe como PDF",
                    FileName = "Informe1.pdf"
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    reportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, saveFileDialog.FileName);
                    MessageBox.Show($"Informe guardado en: {saveFileDialog.FileName}", "Exportación Exitosa", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error al exportar el reporte: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        

    }
    }
}
