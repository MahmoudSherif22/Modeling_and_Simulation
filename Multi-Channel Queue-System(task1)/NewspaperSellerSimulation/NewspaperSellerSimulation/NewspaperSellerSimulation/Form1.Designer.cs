namespace NewspaperSellerSimulation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomNewsDayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newsDayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomDemandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lostProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyNetProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simulationTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulationSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.The_Run = new System.Windows.Forms.Button();
            this.Browse_text = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TotalSales = new System.Windows.Forms.TextBox();
            this.TotalLost = new System.Windows.Forms.TextBox();
            this.TotalScrap = new System.Windows.Forms.TextBox();
            this.TotalNet = new System.Windows.Forms.TextBox();
            this.TotalCost = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DwMD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DwSP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationSystemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayNoDataGridViewTextBoxColumn,
            this.randomNewsDayTypeDataGridViewTextBoxColumn,
            this.newsDayTypeDataGridViewTextBoxColumn,
            this.randomDemandDataGridViewTextBoxColumn,
            this.demandDataGridViewTextBoxColumn,
            this.salesProfitDataGridViewTextBoxColumn,
            this.lostProfitDataGridViewTextBoxColumn,
            this.scrapProfitDataGridViewTextBoxColumn,
            this.dailyNetProfitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.simulationTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 512);
            this.dataGridView1.TabIndex = 7;
            // 
            // dayNoDataGridViewTextBoxColumn
            // 
            this.dayNoDataGridViewTextBoxColumn.DataPropertyName = "DayNo";
            this.dayNoDataGridViewTextBoxColumn.HeaderText = "DayNo";
            this.dayNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayNoDataGridViewTextBoxColumn.Name = "dayNoDataGridViewTextBoxColumn";
            this.dayNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // randomNewsDayTypeDataGridViewTextBoxColumn
            // 
            this.randomNewsDayTypeDataGridViewTextBoxColumn.DataPropertyName = "RandomNewsDayType";
            this.randomNewsDayTypeDataGridViewTextBoxColumn.HeaderText = "RandomNewsDayType";
            this.randomNewsDayTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randomNewsDayTypeDataGridViewTextBoxColumn.Name = "randomNewsDayTypeDataGridViewTextBoxColumn";
            this.randomNewsDayTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // newsDayTypeDataGridViewTextBoxColumn
            // 
            this.newsDayTypeDataGridViewTextBoxColumn.DataPropertyName = "NewsDayType";
            this.newsDayTypeDataGridViewTextBoxColumn.HeaderText = "NewsDayType";
            this.newsDayTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newsDayTypeDataGridViewTextBoxColumn.Name = "newsDayTypeDataGridViewTextBoxColumn";
            this.newsDayTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // randomDemandDataGridViewTextBoxColumn
            // 
            this.randomDemandDataGridViewTextBoxColumn.DataPropertyName = "RandomDemand";
            this.randomDemandDataGridViewTextBoxColumn.HeaderText = "RandomDemand";
            this.randomDemandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randomDemandDataGridViewTextBoxColumn.Name = "randomDemandDataGridViewTextBoxColumn";
            this.randomDemandDataGridViewTextBoxColumn.Width = 120;
            // 
            // demandDataGridViewTextBoxColumn
            // 
            this.demandDataGridViewTextBoxColumn.DataPropertyName = "Demand";
            this.demandDataGridViewTextBoxColumn.HeaderText = "Demand";
            this.demandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.demandDataGridViewTextBoxColumn.Name = "demandDataGridViewTextBoxColumn";
            this.demandDataGridViewTextBoxColumn.Width = 120;
            // 
            // salesProfitDataGridViewTextBoxColumn
            // 
            this.salesProfitDataGridViewTextBoxColumn.DataPropertyName = "SalesProfit";
            this.salesProfitDataGridViewTextBoxColumn.HeaderText = "SalesProfit";
            this.salesProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesProfitDataGridViewTextBoxColumn.Name = "salesProfitDataGridViewTextBoxColumn";
            this.salesProfitDataGridViewTextBoxColumn.Width = 120;
            // 
            // lostProfitDataGridViewTextBoxColumn
            // 
            this.lostProfitDataGridViewTextBoxColumn.DataPropertyName = "LostProfit";
            this.lostProfitDataGridViewTextBoxColumn.HeaderText = "LostProfit";
            this.lostProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lostProfitDataGridViewTextBoxColumn.Name = "lostProfitDataGridViewTextBoxColumn";
            this.lostProfitDataGridViewTextBoxColumn.Width = 120;
            // 
            // scrapProfitDataGridViewTextBoxColumn
            // 
            this.scrapProfitDataGridViewTextBoxColumn.DataPropertyName = "ScrapProfit";
            this.scrapProfitDataGridViewTextBoxColumn.HeaderText = "ScrapProfit";
            this.scrapProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scrapProfitDataGridViewTextBoxColumn.Name = "scrapProfitDataGridViewTextBoxColumn";
            this.scrapProfitDataGridViewTextBoxColumn.Width = 120;
            // 
            // dailyNetProfitDataGridViewTextBoxColumn
            // 
            this.dailyNetProfitDataGridViewTextBoxColumn.DataPropertyName = "DailyNetProfit";
            this.dailyNetProfitDataGridViewTextBoxColumn.HeaderText = "DailyNetProfit";
            this.dailyNetProfitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dailyNetProfitDataGridViewTextBoxColumn.Name = "dailyNetProfitDataGridViewTextBoxColumn";
            this.dailyNetProfitDataGridViewTextBoxColumn.Width = 120;
            // 
            // simulationTableBindingSource
            // 
            this.simulationTableBindingSource.DataMember = "SimulationTable";
            this.simulationTableBindingSource.DataSource = this.simulationSystemBindingSource;
            // 
            // simulationSystemBindingSource
            // 
            this.simulationSystemBindingSource.DataSource = typeof(NewspaperSellerModels.SimulationSystem);
            // 
            // The_Run
            // 
            this.The_Run.Location = new System.Drawing.Point(517, 8);
            this.The_Run.Name = "The_Run";
            this.The_Run.Size = new System.Drawing.Size(150, 30);
            this.The_Run.TabIndex = 6;
            this.The_Run.Text = "Run Simulation";
            this.The_Run.UseVisualStyleBackColor = true;
            this.The_Run.Click += new System.EventHandler(this.The_Run_Click);
            // 
            // Browse_text
            // 
            this.Browse_text.Location = new System.Drawing.Point(12, 12);
            this.Browse_text.Name = "Browse_text";
            this.Browse_text.Size = new System.Drawing.Size(404, 22);
            this.Browse_text.TabIndex = 5;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(422, 12);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 4;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TotalSales
            // 
            this.TotalSales.Location = new System.Drawing.Point(666, 568);
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.Size = new System.Drawing.Size(100, 22);
            this.TotalSales.TabIndex = 8;
            // 
            // TotalLost
            // 
            this.TotalLost.Location = new System.Drawing.Point(785, 568);
            this.TotalLost.Name = "TotalLost";
            this.TotalLost.Size = new System.Drawing.Size(100, 22);
            this.TotalLost.TabIndex = 9;
            // 
            // TotalScrap
            // 
            this.TotalScrap.Location = new System.Drawing.Point(902, 568);
            this.TotalScrap.Name = "TotalScrap";
            this.TotalScrap.Size = new System.Drawing.Size(100, 22);
            this.TotalScrap.TabIndex = 10;
            // 
            // TotalNet
            // 
            this.TotalNet.Location = new System.Drawing.Point(1022, 568);
            this.TotalNet.Name = "TotalNet";
            this.TotalNet.Size = new System.Drawing.Size(100, 22);
            this.TotalNet.TabIndex = 11;
            // 
            // TotalCost
            // 
            this.TotalCost.Location = new System.Drawing.Point(397, 579);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(100, 22);
            this.TotalCost.TabIndex = 12;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(115, 579);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(100, 22);
            this.Cost.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Cost: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cost: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Days With More Demand: ";
            // 
            // DwMD
            // 
            this.DwMD.Location = new System.Drawing.Point(191, 610);
            this.DwMD.Name = "DwMD";
            this.DwMD.Size = new System.Drawing.Size(100, 22);
            this.DwMD.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 610);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Days With Unsold Papers: ";
            // 
            // DwSP
            // 
            this.DwSP.Location = new System.Drawing.Point(494, 610);
            this.DwSP.Name = "DwSP";
            this.DwSP.Size = new System.Drawing.Size(100, 22);
            this.DwSP.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 637);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DwSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DwMD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.TotalNet);
            this.Controls.Add(this.TotalScrap);
            this.Controls.Add(this.TotalLost);
            this.Controls.Add(this.TotalSales);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.The_Run);
            this.Controls.Add(this.Browse_text);
            this.Controls.Add(this.Browse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationSystemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button The_Run;
        private System.Windows.Forms.TextBox Browse_text;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource simulationTableBindingSource;
        private System.Windows.Forms.BindingSource simulationSystemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomNewsDayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newsDayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDemandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lostProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyNetProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TotalSales;
        private System.Windows.Forms.TextBox TotalLost;
        private System.Windows.Forms.TextBox TotalScrap;
        private System.Windows.Forms.TextBox TotalNet;
        private System.Windows.Forms.TextBox TotalCost;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DwMD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DwSP;
    }
}