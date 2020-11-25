using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para el chart
using System.Windows.Forms.DataVisualization.Charting;

namespace DatosTemporales
{
    public partial class Form1 : Form
    {
        #region Apuntadores
        //Apuntador
        DatosPropiedades Archivo1 = new DatosPropiedades();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region ListGridView
        //Método que muestra una tabla con los datos importados de Excel
        public void ListGridView(string rutaArchivo)
        {
            //Creando nuevo objeto SLDocument que recibe el path donde se encuentra el Excel
            SLDocument sl = new SLDocument(rutaArchivo);

            //Los arreglos comienzan en cero
            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

            //Creación de la lista para mostrar la tabla de datos Excel
            List<ExcelViewModel> lstExcelDatos = new List<ExcelViewModel>();

            //El ciclo while se aplica hasta que no se encuentre un registro vacío
            //fila/columna
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                //Creación del apuntador
                ExcelViewModel apuntadorExcel = new ExcelViewModel();
                apuntadorExcel.puntosX = sl.GetCellValueAsInt32(iRow, 1);
                apuntadorExcel.puntosY = sl.GetCellValueAsInt32(iRow, 2);

                //Se añaden a la lista los datos del Excel
                lstExcelDatos.Add(apuntadorExcel);

                iRow++;
            }
            //Haciendo que la lista aparezca en la pantalla
            dataGridView1.DataSource = lstExcelDatos;
        }
        #endregion

        #region LecturaExcel
        //Método que lee los datos del archivo de Excel y los guarda en una lista
        public static List<double> LecturaExcel(string rutaArchivo, int columna)
        {
            //Creando nuevo objeto SLDocument que recibe el path donde se encuentra el Excel
            SLDocument sl = new SLDocument(rutaArchivo);

            //Los arreglos comienzan en cero
            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

            //Creación de la lista para leer los datos
            List<double> lstLecturaExcel = new List<double>();

            //El ciclo while se aplica hasta que no se encuentre un registro vacío
            //fila/columna
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, columna)))
            {
                lstLecturaExcel.Add(sl.GetCellValueAsInt32(iRow, columna));

                iRow++;
            }

            return lstLecturaExcel;

        }
        #endregion

        #region Gráfica
        //Construcción de la gráfica
        public void Grafica(double[] datosEjeX, double[] datosEjeY, string nombreSerie, string tipo)
        {
            //El área de los rectángulos es cero
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            //Se pone nulo para que el numeros aparézcan en los ejes
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";

            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            //Medidas del gráfico
            chart.AxisX.Minimum = FuncionesEstadistica.Matlab.Min(datosEjeX);
            chart.AxisX.Maximum = FuncionesEstadistica.Matlab.Max(datosEjeX)+10;
            chart.AxisX.Interval = 10;

            chart.AxisY.Minimum = FuncionesEstadistica.Matlab.Min(datosEjeY);
            chart.AxisY.Maximum = FuncionesEstadistica.Matlab.Max(datosEjeY)+10;
            chart.AxisY.Interval = 10;

            //Diseño de la gráfica
            chart1.Series.Add(nombreSerie);
            if(tipo == "punto") 
            {
                chart1.Series[nombreSerie].ChartType = SeriesChartType.Point;
                chart1.Series[nombreSerie].Color = Color.Purple;
            }
            else
            {
                chart1.Series[nombreSerie].ChartType = SeriesChartType.Line;
                chart1.Series[nombreSerie].Color = Color.Red;
            }
            chart1.Series[nombreSerie].IsVisibleInLegend = false;

            //Imprimiendo los puntos de la gráfica
            for (int i = 0; i <= datosEjeX.Length - 1; i++)
            {
                chart1.Series[nombreSerie].Points.AddXY(datosEjeX[i], datosEjeY[i]);
            }
        }
        #endregion

        #region Botón: Importar
        private void bttnImportar_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Archivo1.rutaArchivo = string.Empty;
            Archivo1.nombreDatos = "Regresion Lineal";

            //OpenFileDialog permite abrir el buscador de archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //Si el usuario sí abre un archivo, el if se ejecuta
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Archivo1.rutaArchivo = openFileDialog.FileName;
                ListGridView(Archivo1.rutaArchivo);
                Archivo1.datosEjeX = LecturaExcel(Archivo1.rutaArchivo,1).ToArray();
                Archivo1.datosEjeY = LecturaExcel(Archivo1.rutaArchivo,2).ToArray();

                //Método para obtener el nombre del archivo
                string[] nombre = Archivo1.rutaArchivo.Split('\\', '.');
                Archivo1.nombreDatos = nombre[nombre.Length - 2];

                //Graficando
                Grafica(Archivo1.datosEjeX, Archivo1.datosEjeY, Archivo1.nombreDatos, "punto");

                #region Regresión Lineal
                //Obteniendo la pendiente
                Archivo1.pendiente = FuncionesEstadistica.Matlab.Pendiente(Archivo1.datosEjeX, Archivo1.datosEjeY);
                txtBoxPendiente.Text = Convert.ToString(Archivo1.pendiente);

                //Obteniendo la ordenada al origen
                Archivo1.ordenada = FuncionesEstadistica.Matlab.Ordenada(Archivo1.datosEjeX, Archivo1.datosEjeY);
                txtBoxOrdenada.Text = Convert.ToString(Archivo1.ordenada);

                //Datos de la línea de regresión lineal
                Archivo1.regresionLineal = FuncionesEstadistica.Matlab.RegresionLineal(Archivo1.datosEjeX, Archivo1.pendiente, Archivo1.ordenada);
                Grafica(Archivo1.datosEjeX, Archivo1.regresionLineal, "RegresioLineal", "linea");

                labelFormulaRegresionLineal.Visible = true;
                labelFormulaRegresionLineal.Text = "y = " + Math.Round(Archivo1.pendiente,2) + "x + " + Math.Round(Archivo1.ordenada,2);
                #endregion
            }
            txtBoxImportar.Text = Archivo1.nombreDatos;
        }
        #endregion
    }
}