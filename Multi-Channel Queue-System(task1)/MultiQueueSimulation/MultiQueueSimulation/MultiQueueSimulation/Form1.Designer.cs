namespace MultiQueueSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Browse = new System.Windows.Forms.Button();
            this.Browse_text = new System.Windows.Forms.TextBox();
            this.The_Run = new System.Windows.Forms.Button();
            this.simulationTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulationSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomInterArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInQueueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Performances = new System.Windows.Forms.Label();
            this.AverageWaitingTime_label = new System.Windows.Forms.Label();
            this.WaitingProbability_label = new System.Windows.Forms.Label();
            this.MaxQueueLength_label = new System.Windows.Forms.Label();
            this.AverageWaitingTime_text = new System.Windows.Forms.TextBox();
            this.MaxQueueLength_text = new System.Windows.Forms.TextBox();
            this.WaitingProbability_text = new System.Windows.Forms.TextBox();
            this.Server_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdleProbability_text = new System.Windows.Forms.TextBox();
            this.AverageServiceTime_text = new System.Windows.Forms.TextBox();
            this.Utilization_text = new System.Windows.Forms.TextBox();
            this.Servers_IDs = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simulationTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(503, 20);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Browse_text
            // 
            this.Browse_text.Location = new System.Drawing.Point(12, 20);
            this.Browse_text.Name = "Browse_text";
            this.Browse_text.Size = new System.Drawing.Size(485, 22);
            this.Browse_text.TabIndex = 1;
            // 
            // The_Run
            // 
            this.The_Run.Location = new System.Drawing.Point(584, 16);
            this.The_Run.Name = "The_Run";
            this.The_Run.Size = new System.Drawing.Size(150, 30);
            this.The_Run.TabIndex = 2;
            this.The_Run.Text = "Run Simulation";
            this.The_Run.UseVisualStyleBackColor = true;
            this.The_Run.Click += new System.EventHandler(this.The_Run_Click);
            // 
            // simulationTableBindingSource
            // 
            this.simulationTableBindingSource.DataMember = "SimulationTable";
            this.simulationTableBindingSource.DataSource = this.simulationSystemBindingSource;
            // 
            // simulationSystemBindingSource
            // 
            this.simulationSystemBindingSource.DataSource = typeof(MultiQueueModels.SimulationSystem);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNumberDataGridViewTextBoxColumn,
            this.randomInterArrivalDataGridViewTextBoxColumn,
            this.interArrivalDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.randomServiceDataGridViewTextBoxColumn,
            this.serverIDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.serviceTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.timeInQueueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.simulationTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1286, 581);
            this.dataGridView1.TabIndex = 3;
            // 
            // customerNumberDataGridViewTextBoxColumn
            // 
            this.customerNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerNumber";
            this.customerNumberDataGridViewTextBoxColumn.HeaderText = "CustomerNumber";
            this.customerNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNumberDataGridViewTextBoxColumn.Name = "customerNumberDataGridViewTextBoxColumn";
            this.customerNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // randomInterArrivalDataGridViewTextBoxColumn
            // 
            this.randomInterArrivalDataGridViewTextBoxColumn.DataPropertyName = "RandomInterArrival";
            this.randomInterArrivalDataGridViewTextBoxColumn.HeaderText = "RandomInterArrival";
            this.randomInterArrivalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randomInterArrivalDataGridViewTextBoxColumn.Name = "randomInterArrivalDataGridViewTextBoxColumn";
            this.randomInterArrivalDataGridViewTextBoxColumn.Width = 120;
            // 
            // interArrivalDataGridViewTextBoxColumn
            // 
            this.interArrivalDataGridViewTextBoxColumn.DataPropertyName = "InterArrival";
            this.interArrivalDataGridViewTextBoxColumn.HeaderText = "InterArrival";
            this.interArrivalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.interArrivalDataGridViewTextBoxColumn.Name = "interArrivalDataGridViewTextBoxColumn";
            this.interArrivalDataGridViewTextBoxColumn.Width = 120;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // randomServiceDataGridViewTextBoxColumn
            // 
            this.randomServiceDataGridViewTextBoxColumn.DataPropertyName = "RandomService";
            this.randomServiceDataGridViewTextBoxColumn.HeaderText = "RandomService";
            this.randomServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randomServiceDataGridViewTextBoxColumn.Name = "randomServiceDataGridViewTextBoxColumn";
            this.randomServiceDataGridViewTextBoxColumn.Width = 120;
            // 
            // serverIDDataGridViewTextBoxColumn
            // 
            this.serverIDDataGridViewTextBoxColumn.DataPropertyName = "Server_ID";
            this.serverIDDataGridViewTextBoxColumn.HeaderText = "Server_ID";
            this.serverIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serverIDDataGridViewTextBoxColumn.Name = "serverIDDataGridViewTextBoxColumn";
            this.serverIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // serviceTimeDataGridViewTextBoxColumn
            // 
            this.serviceTimeDataGridViewTextBoxColumn.DataPropertyName = "ServiceTime";
            this.serviceTimeDataGridViewTextBoxColumn.HeaderText = "ServiceTime";
            this.serviceTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceTimeDataGridViewTextBoxColumn.Name = "serviceTimeDataGridViewTextBoxColumn";
            this.serviceTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // timeInQueueDataGridViewTextBoxColumn
            // 
            this.timeInQueueDataGridViewTextBoxColumn.DataPropertyName = "TimeInQueue";
            this.timeInQueueDataGridViewTextBoxColumn.HeaderText = "TimeInQueue";
            this.timeInQueueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeInQueueDataGridViewTextBoxColumn.Name = "timeInQueueDataGridViewTextBoxColumn";
            this.timeInQueueDataGridViewTextBoxColumn.Width = 120;
            // 
            // Performances
            // 
            this.Performances.AutoSize = true;
            this.Performances.Location = new System.Drawing.Point(1321, 58);
            this.Performances.Name = "Performances";
            this.Performances.Size = new System.Drawing.Size(100, 17);
            this.Performances.TabIndex = 4;
            this.Performances.Text = "Performances:";
            // 
            // AverageWaitingTime_label
            // 
            this.AverageWaitingTime_label.AutoSize = true;
            this.AverageWaitingTime_label.Location = new System.Drawing.Point(1321, 88);
            this.AverageWaitingTime_label.Name = "AverageWaitingTime_label";
            this.AverageWaitingTime_label.Size = new System.Drawing.Size(147, 17);
            this.AverageWaitingTime_label.TabIndex = 5;
            this.AverageWaitingTime_label.Text = "AverageWaitingTime: ";
            // 
            // WaitingProbability_label
            // 
            this.WaitingProbability_label.AutoSize = true;
            this.WaitingProbability_label.Location = new System.Drawing.Point(1321, 144);
            this.WaitingProbability_label.Name = "WaitingProbability_label";
            this.WaitingProbability_label.Size = new System.Drawing.Size(129, 17);
            this.WaitingProbability_label.TabIndex = 6;
            this.WaitingProbability_label.Text = "WaitingProbability: ";
            // 
            // MaxQueueLength_label
            // 
            this.MaxQueueLength_label.AutoSize = true;
            this.MaxQueueLength_label.Location = new System.Drawing.Point(1321, 116);
            this.MaxQueueLength_label.Name = "MaxQueueLength_label";
            this.MaxQueueLength_label.Size = new System.Drawing.Size(128, 17);
            this.MaxQueueLength_label.TabIndex = 7;
            this.MaxQueueLength_label.Text = "MaxQueueLength: ";
            // 
            // AverageWaitingTime_text
            // 
            this.AverageWaitingTime_text.Location = new System.Drawing.Point(1474, 83);
            this.AverageWaitingTime_text.Name = "AverageWaitingTime_text";
            this.AverageWaitingTime_text.Size = new System.Drawing.Size(100, 22);
            this.AverageWaitingTime_text.TabIndex = 8;
            // 
            // MaxQueueLength_text
            // 
            this.MaxQueueLength_text.Location = new System.Drawing.Point(1474, 113);
            this.MaxQueueLength_text.Name = "MaxQueueLength_text";
            this.MaxQueueLength_text.Size = new System.Drawing.Size(100, 22);
            this.MaxQueueLength_text.TabIndex = 9;
            // 
            // WaitingProbability_text
            // 
            this.WaitingProbability_text.Location = new System.Drawing.Point(1474, 144);
            this.WaitingProbability_text.Name = "WaitingProbability_text";
            this.WaitingProbability_text.Size = new System.Drawing.Size(100, 22);
            this.WaitingProbability_text.TabIndex = 10;
            // 
            // Server_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Server_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Server_chart.Legends.Add(legend1);
            this.Server_chart.Location = new System.Drawing.Point(29, 644);
            this.Server_chart.Name = "Server_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Busy";
            this.Server_chart.Series.Add(series1);
            this.Server_chart.Size = new System.Drawing.Size(1545, 274);
            this.Server_chart.TabIndex = 11;
            this.Server_chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1368, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server Performance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1321, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "IdleProbability:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1321, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "AverageServiceTime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1321, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Utilization:";
            // 
            // IdleProbability_text
            // 
            this.IdleProbability_text.Location = new System.Drawing.Point(1474, 548);
            this.IdleProbability_text.Name = "IdleProbability_text";
            this.IdleProbability_text.Size = new System.Drawing.Size(100, 22);
            this.IdleProbability_text.TabIndex = 16;
            // 
            // AverageServiceTime_text
            // 
            this.AverageServiceTime_text.Location = new System.Drawing.Point(1474, 577);
            this.AverageServiceTime_text.Name = "AverageServiceTime_text";
            this.AverageServiceTime_text.Size = new System.Drawing.Size(100, 22);
            this.AverageServiceTime_text.TabIndex = 17;
            // 
            // Utilization_text
            // 
            this.Utilization_text.Location = new System.Drawing.Point(1474, 605);
            this.Utilization_text.Name = "Utilization_text";
            this.Utilization_text.Size = new System.Drawing.Size(100, 22);
            this.Utilization_text.TabIndex = 18;
            // 
            // Servers_IDs
            // 
            this.Servers_IDs.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.simulationTableBindingSource, "Server_ID", true));
            this.Servers_IDs.DataSource = this.simulationTableBindingSource;
            this.Servers_IDs.DisplayMember = "Server_ID";
            this.Servers_IDs.FormattingEnabled = true;
            this.Servers_IDs.Location = new System.Drawing.Point(1474, 489);
            this.Servers_IDs.Name = "Servers_IDs";
            this.Servers_IDs.Size = new System.Drawing.Size(100, 24);
            this.Servers_IDs.TabIndex = 19;
            this.Servers_IDs.ValueMember = "Server_ID";
            this.Servers_IDs.SelectedIndexChanged += new System.EventHandler(this.Servers_IDs_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1323, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Server ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 930);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Servers_IDs);
            this.Controls.Add(this.Utilization_text);
            this.Controls.Add(this.AverageServiceTime_text);
            this.Controls.Add(this.IdleProbability_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Server_chart);
            this.Controls.Add(this.WaitingProbability_text);
            this.Controls.Add(this.MaxQueueLength_text);
            this.Controls.Add(this.AverageWaitingTime_text);
            this.Controls.Add(this.MaxQueueLength_label);
            this.Controls.Add(this.WaitingProbability_label);
            this.Controls.Add(this.AverageWaitingTime_label);
            this.Controls.Add(this.Performances);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.The_Run);
            this.Controls.Add(this.Browse_text);
            this.Controls.Add(this.Browse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simulationTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox Browse_text;
        private System.Windows.Forms.Button The_Run;
        private System.Windows.Forms.BindingSource simulationTableBindingSource;
        private System.Windows.Forms.BindingSource simulationSystemBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomInterArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInQueueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Performances;
        private System.Windows.Forms.Label AverageWaitingTime_label;
        private System.Windows.Forms.Label WaitingProbability_label;
        private System.Windows.Forms.Label MaxQueueLength_label;
        private System.Windows.Forms.TextBox AverageWaitingTime_text;
        private System.Windows.Forms.TextBox MaxQueueLength_text;
        private System.Windows.Forms.TextBox WaitingProbability_text;
        private System.Windows.Forms.DataVisualization.Charting.Chart Server_chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdleProbability_text;
        private System.Windows.Forms.TextBox AverageServiceTime_text;
        private System.Windows.Forms.TextBox Utilization_text;
        private System.Windows.Forms.ComboBox Servers_IDs;
        private System.Windows.Forms.Label label5;
    }
}

