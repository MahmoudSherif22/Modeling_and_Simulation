using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;
using System.IO;
namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem simulation_run;
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            openFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            if (result == DialogResult.OK) // Test result.
            {
                Browse_text.Text = openFileDialog1.FileName;
            }
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void The_Run_Click(object sender, EventArgs e)
        {
            //Read File Data, Path from TextBox Filled either by Dialog or by hand
            int size = -1;
            string file = Browse_text.Text;
            if (Browse.Text.Length > 0)
            {
                try
                {
                    simulation_run = new SimulationSystem();
                    String[] Modeling_file = File.ReadAllLines(file);
                    simulation_run.Inputs(Modeling_file);
                    simulation_run.Simulation_Run();
                    string[] splitted_path = file.Split('\\');
                    string result = TestingManager.Test(simulation_run, splitted_path[splitted_path.Length - 1]);
                    MessageBox.Show(result);
                    //Simulation Table Output
                    dataGridView1.DataSource = simulation_run.SimulationTable;
                    //Performance Output
                    TotalCost.Text = simulation_run.PerformanceMeasures.TotalCost.ToString();
                    TotalCost.ReadOnly = true;
                    TotalLost.Text = simulation_run.PerformanceMeasures.TotalLostProfit.ToString();
                    TotalLost.ReadOnly = true;
                    TotalNet.Text = simulation_run.PerformanceMeasures.TotalNetProfit.ToString();
                    TotalNet.ReadOnly = true;
                    TotalSales.Text = simulation_run.PerformanceMeasures.TotalSalesProfit.ToString();
                    TotalSales.ReadOnly = true;
                    TotalScrap.Text = simulation_run.PerformanceMeasures.TotalScrapProfit.ToString();
                    TotalScrap.ReadOnly = true;
                    DwMD.Text = simulation_run.PerformanceMeasures.DaysWithMoreDemand.ToString();
                    DwMD.ReadOnly = true;
                    DwSP.Text = simulation_run.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
                    DwSP.ReadOnly = true;
                    Cost.Text = simulation_run.SimulationTable[0].DailyCost.ToString();
                    Cost.ReadOnly = true;
                }
                catch (IOException)
                {
                    string message = "File did not Read properly, Retry";
                    string caption = "Error Detected";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                    return;
                }
                Console.WriteLine(size); // <-- Shows file size in debugging mode.
                                         //Open Simulation Form..... (One with Results) Don't forget to close even by X
                                         //Fill the Classes & Calculations of modeling: In new Form

                //testcases.DataSource = Constants.FileNames;

            }
            else
            {
                string message = "Please Add File's Path, then Retry";
                string caption = "NO FILE";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
