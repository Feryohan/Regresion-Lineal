using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zona_de_pruebas
{
    class zonaPruebas
    {
        static void Main(string[] args)
        {
            //Dirección del documento de Excel
            string path;
            path = @"C:\Users\SERGIO ROMO\Documents\Semestre 2021-1\Temas Selectos de Programación\DatosTemporales\Documetos de Excel\Regresion Lineal.xlsx";

            //Libreria SpreadsheetLight version 3.4.9 instalada desde el NuGet
            //DocumentFormat.OpenXml version 2.5.0 instalada desde el NuGet
            SLDocument sl = new SLDocument(path);

            //Los arreglos comienzan en cero
            //Las filas comienzan en uno

            //El indice, para la fila, empieza en el dos
            int iRow = 2;

            //Creación del arreglo 
            double[] datosEjeY = new double[50];
            double[] datosEjeX = new double[50];

            //El ciclo while se aplica hasta que no se encuentre un registro vacío
            //fila/columna
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 2)))
            {
                //Se añade al arreglo
                datosEjeY[iRow - 2] = sl.GetCellValueAsInt32(iRow, 2);
                datosEjeX[iRow - 2] = sl.GetCellValueAsInt32(iRow, 1);

                //Se muestra en pantalla
                Console.WriteLine("Datos eje X: " + datosEjeX[iRow - 2]);
                Console.WriteLine("Datos eje Y: " + datosEjeY[iRow - 2]);

                iRow++;
            }

            Console.WriteLine("\nLa pendiente es = " + FuncionesEstadistica.Matlab.Pendiente(datosEjeX,datosEjeY));

            Console.WriteLine("\nLa ordenada es = " + FuncionesEstadistica.Matlab.Ordenada(datosEjeX, datosEjeY));

            Console.Read();
        }
    }
}
