using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

using System.IO;


namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem simulation_run;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
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

        private void Form1_Load(object sender, EventArgs e)
        {

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
                    Servers_IDs.DataSource = simulation_run.Servers.Select(s => s.ID).Distinct().ToList();
                    //Performance Output
                    AverageWaitingTime_text.Text = simulation_run.PerformanceMeasures.AverageWaitingTime.ToString();
                    AverageWaitingTime_text.ReadOnly = true;
                    MaxQueueLength_text.Text = simulation_run.PerformanceMeasures.MaxQueueLength.ToString();
                    MaxQueueLength_text.ReadOnly = true;
                    WaitingProbability_text.Text = simulation_run.PerformanceMeasures.WaitingProbability.ToString();
                    WaitingProbability_text.ReadOnly = true;
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

        private void Servers_IDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = (int)Servers_IDs.SelectedValue;
            //Server Charts Output
            //X-Axis: Simulation_Time_work
            Server server = simulation_run.Servers[ID - 1];
            Server_chart.Series["Busy"].Points.Clear();
            Server_chart.ChartAreas[0].AxisX.IsMarginVisible = false;
            Server_chart.ChartAreas[0].AxisX.Interval = 10;
            Server_chart.Series["Busy"]["PointWidth"] = "1";
            Dictionary<int, int> server_work = server.Simulation_Time_work;
            for (int i = 0; i < simulation_run.Simulation_End; i++)
                if (server_work.ContainsKey(i)) //Busy
                    Server_chart.Series["Busy"].Points.AddXY(i, 1);
                else // Free
                    Server_chart.Series["Busy"].Points.AddXY(i, 0);
            IdleProbability_text.Text = server.IdleProbability.ToString();
            IdleProbability_text.ReadOnly = true;
            Utilization_text.Text = server.Utilization.ToString();
            Utilization_text.ReadOnly = true;
            AverageServiceTime_text.Text = server.AverageServiceTime.ToString();
            AverageServiceTime_text.ReadOnly = true;
        }
    }
}
