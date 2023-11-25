namespace InventorySimulation
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.The_Run = new System.Windows.Forms.Button();
            this.Browse_text = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayWithinCycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginningInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomDemandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortageQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomLeadDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysUntilOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simulationCasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simulationSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShortageAverage = new System.Windows.Forms.TextBox();
            this.Performances = new System.Windows.Forms.Label();
            this.EndingAverage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationCasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationSystemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // The_Run
            // 
            this.The_Run.Location = new System.Drawing.Point(692, 6);
            this.The_Run.Name = "The_Run";
            this.The_Run.Size = new System.Drawing.Size(150, 30);
            this.The_Run.TabIndex = 23;
            this.The_Run.Text = "Run Simulation";
            this.The_Run.UseVisualStyleBackColor = true;
            this.The_Run.Click += new System.EventHandler(this.The_Run_Click);
            // 
            // Browse_text
            // 
            this.Browse_text.Location = new System.Drawing.Point(12, 5);
            this.Browse_text.Name = "Browse_text";
            this.Browse_text.Size = new System.Drawing.Size(468, 22);
            this.Browse_text.TabIndex = 22;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(486, 5);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 21;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayDataGridViewTextBoxColumn,
            this.cycleDataGridViewTextBoxColumn,
            this.dayWithinCycleDataGridViewTextBoxColumn,
            this.beginningInventoryDataGridViewTextBoxColumn,
            this.randomDemandDataGridViewTextBoxColumn,
            this.demandDataGridViewTextBoxColumn,
            this.endingInventoryDataGridViewTextBoxColumn,
            this.shortageQuantityDataGridViewTextBoxColumn,
            this.orderQuantityDataGridViewTextBoxColumn,
            this.randomLeadDaysDataGridViewTextBoxColumn,
            this.leadDaysDataGridViewTextBoxColumn,
            this.daysUntilOrderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.simulationCasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1520, 612);
            this.dataGridView1.TabIndex = 41;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Width = 120;
            // 
            // cycleDataGridViewTextBoxColumn
            // 
            this.cycleDataGridViewTextBoxColumn.DataPropertyName = "Cycle";
            this.cycleDataGridViewTextBoxColumn.HeaderText = "Cycle";
            this.cycleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cycleDataGridViewTextBoxColumn.Name = "cycleDataGridViewTextBoxColumn";
            this.cycleDataGridViewTextBoxColumn.Width = 120;
            // 
            // dayWithinCycleDataGridViewTextBoxColumn
            // 
            this.dayWithinCycleDataGridViewTextBoxColumn.DataPropertyName = "DayWithinCycle";
            this.dayWithinCycleDataGridViewTextBoxColumn.HeaderText = "DayWithinCycle";
            this.dayWithinCycleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayWithinCycleDataGridViewTextBoxColumn.Name = "dayWithinCycleDataGridViewTextBoxColumn";
            this.dayWithinCycleDataGridViewTextBoxColumn.Width = 120;
            // 
            // beginningInventoryDataGridViewTextBoxColumn
            // 
            this.beginningInventoryDataGridViewTextBoxColumn.DataPropertyName = "BeginningInventory";
            this.beginningInventoryDataGridViewTextBoxColumn.HeaderText = "BeginningInventory";
            this.beginningInventoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beginningInventoryDataGridViewTextBoxColumn.Name = "beginningInventoryDataGridViewTextBoxColumn";
            this.beginningInventoryDataGridViewTextBoxColumn.Width = 120;
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
            // endingInventoryDataGridViewTextBoxColumn
            // 
            this.endingInventoryDataGridViewTextBoxColumn.DataPropertyName = "EndingInventory";
            this.endingInventoryDataGridViewTextBoxColumn.HeaderText = "EndingInventory";
            this.endingInventoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endingInventoryDataGridViewTextBoxColumn.Name = "endingInventoryDataGridViewTextBoxColumn";
            this.endingInventoryDataGridViewTextBoxColumn.Width = 120;
            // 
            // shortageQuantityDataGridViewTextBoxColumn
            // 
            this.shortageQuantityDataGridViewTextBoxColumn.DataPropertyName = "ShortageQuantity";
            this.shortageQuantityDataGridViewTextBoxColumn.HeaderText = "ShortageQuantity";
            this.shortageQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shortageQuantityDataGridViewTextBoxColumn.Name = "shortageQuantityDataGridViewTextBoxColumn";
            this.shortageQuantityDataGridViewTextBoxColumn.Width = 120;
            // 
            // orderQuantityDataGridViewTextBoxColumn
            // 
            this.orderQuantityDataGridViewTextBoxColumn.DataPropertyName = "OrderQuantity";
            this.orderQuantityDataGridViewTextBoxColumn.HeaderText = "OrderQuantity";
            this.orderQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderQuantityDataGridViewTextBoxColumn.Name = "orderQuantityDataGridViewTextBoxColumn";
            this.orderQuantityDataGridViewTextBoxColumn.Width = 120;
            // 
            // randomLeadDaysDataGridViewTextBoxColumn
            // 
            this.randomLeadDaysDataGridViewTextBoxColumn.DataPropertyName = "RandomLeadDays";
            this.randomLeadDaysDataGridViewTextBoxColumn.HeaderText = "RandomLeadDays";
            this.randomLeadDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.randomLeadDaysDataGridViewTextBoxColumn.Name = "randomLeadDaysDataGridViewTextBoxColumn";
            this.randomLeadDaysDataGridViewTextBoxColumn.Width = 120;
            // 
            // leadDaysDataGridViewTextBoxColumn
            // 
            this.leadDaysDataGridViewTextBoxColumn.DataPropertyName = "LeadDays";
            this.leadDaysDataGridViewTextBoxColumn.HeaderText = "LeadDays";
            this.leadDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leadDaysDataGridViewTextBoxColumn.Name = "leadDaysDataGridViewTextBoxColumn";
            this.leadDaysDataGridViewTextBoxColumn.Width = 120;
            // 
            // daysUntilOrderDataGridViewTextBoxColumn
            // 
            this.daysUntilOrderDataGridViewTextBoxColumn.DataPropertyName = "DaysUntilOrder";
            this.daysUntilOrderDataGridViewTextBoxColumn.HeaderText = "DaysUntilOrder";
            this.daysUntilOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysUntilOrderDataGridViewTextBoxColumn.Name = "daysUntilOrderDataGridViewTextBoxColumn";
            this.daysUntilOrderDataGridViewTextBoxColumn.Width = 120;
            // 
            // simulationCasesBindingSource
            // 
            this.simulationCasesBindingSource.DataMember = "SimulationCases";
            this.simulationCasesBindingSource.DataSource = this.simulationSystemBindingSource;
            // 
            // simulationSystemBindingSource
            // 
            this.simulationSystemBindingSource.DataSource = typeof(InventoryModels.SimulationSystem);
            // 
            // ShortageAverage
            // 
            this.ShortageAverage.Location = new System.Drawing.Point(909, 651);
            this.ShortageAverage.Name = "ShortageAverage";
            this.ShortageAverage.Size = new System.Drawing.Size(114, 22);
            this.ShortageAverage.TabIndex = 38;
            // 
            // Performances
            // 
            this.Performances.AutoSize = true;
            this.Performances.Location = new System.Drawing.Point(672, 654);
            this.Performances.Name = "Performances";
            this.Performances.Size = new System.Drawing.Size(105, 17);
            this.Performances.TabIndex = 25;
            this.Performances.Text = "Total Average: ";
            // 
            // EndingAverage
            // 
            this.EndingAverage.Location = new System.Drawing.Point(783, 651);
            this.EndingAverage.Name = "EndingAverage";
            this.EndingAverage.Size = new System.Drawing.Size(120, 22);
            this.EndingAverage.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 690);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShortageAverage);
            this.Controls.Add(this.EndingAverage);
            this.Controls.Add(this.Performances);
            this.Controls.Add(this.The_Run);
            this.Controls.Add(this.Browse_text);
            this.Controls.Add(this.Browse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationCasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationSystemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button The_Run;
        private System.Windows.Forms.TextBox Browse_text;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayWithinCycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginningInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDemandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortageQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomLeadDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysUntilOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource simulationCasesBindingSource;
        private System.Windows.Forms.BindingSource simulationSystemBindingSource;
        private System.Windows.Forms.TextBox ShortageAverage;
        private System.Windows.Forms.Label Performances;
        private System.Windows.Forms.TextBox EndingAverage;
    }
}

