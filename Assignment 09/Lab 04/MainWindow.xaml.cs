//Project: Lab 4 
//Description: WPF app to import CSV file into DataGrid
//Name: Alex Moreno, Andy E. Wold, Bethaly Tenango
//Date: 06 Jul 2016
//Instructor: Brother Daniel Masterson
//Course: CS 176 - Windows Desktop Development

using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblDate.Content = DateTime.Today.Date;
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            DataSet dataSet;

            //Pass the name of the table, if desired
            DataTable dataTable = new DataTable("Table Name");

            //Tell the table how many columns it has
            DataColumn column;
            DataRow row;

            //Create new column
            column = new DataColumn();
            column.DataType = Type.GetType("Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            //Add the column to the table
            dataTable.Columns.Add(column);

            //Create DataSet for the table, so you can bind it to the Data Grid(?)
            dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            //Read the data row-by-row, splitting each CSV row into separate items
            for (int i = 0; i <= 2; i++)
            {
                row = dataTable.NewRow();
                row["id"] = i;
                row["ParentItem"] = "ParentItem " + i;
                dataTable.Rows.Add(row);
            }

            DataGrid dataGrid1 = new DataGrid();

            //Instruct the DataGrid to bind to the DataSet
            //dataGrid1.SetDataBinding(dataSet);

        }

        private void btn_CalcFinalGPA_Click(object sender, RoutedEventArgs e)
        {
            //Calculate the Students' Final Grades
        }

        private void btnCalcClassAve_Click(object sender, RoutedEventArgs e)
        {
            //Calculate the Class Average
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            //Add a Student
        }

        private void btnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            //Delete a Student
        }
    }
}
