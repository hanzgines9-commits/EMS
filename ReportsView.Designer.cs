namespace EMS
{
    partial class ReportsView
    {
        private void InitializeComponent()
        {
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.chart = new EMS.BarChart();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblAvgValue = new System.Windows.Forms.Label();
            this.lblAvgCaption = new System.Windows.Forms.Label();
            this.lblLateTotalValue = new System.Windows.Forms.Label();
            this.lblLateTotalCaption = new System.Windows.Forms.Label();
            this.lblAbsentValue = new System.Windows.Forms.Label();
            this.lblAbsentCaption = new System.Windows.Forms.Label();
            this.lblLeaveDaysValue = new System.Windows.Forms.Label();
            this.lblLeaveDaysCaption = new System.Windows.Forms.Label();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.pnlChart.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // pnlFilter
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.TabIndex = 0;
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(24, 20);
            this.pnlFilter.Size = new System.Drawing.Size(845, 64);
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlFilter.Controls.Add(this.lblFrom);
            this.pnlFilter.Controls.Add(this.dtpFrom);
            this.pnlFilter.Controls.Add(this.lblTo);
            this.pnlFilter.Controls.Add(this.dtpTo);
            this.pnlFilter.Controls.Add(this.btnGenerate);
            this.pnlFilter.Controls.Add(this.btnPdf);
            this.pnlFilter.Controls.Add(this.btnPrint);
            // lblFrom
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.TabIndex = 0;
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblFrom.Location = new System.Drawing.Point(16, 24);
            this.lblFrom.Text = "FROM";
            // dtpFrom
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(62, 20);
            this.dtpFrom.Size = new System.Drawing.Size(130, 27);
            // lblTo
            this.lblTo.Name = "lblTo";
            this.lblTo.TabIndex = 2;
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTo.Location = new System.Drawing.Point(212, 24);
            this.lblTo.Text = "TO";
            // dtpTo
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(240, 20);
            this.dtpTo.Size = new System.Drawing.Size(130, 27);
            // btnGenerate
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(400, 13);
            this.btnGenerate.Size = new System.Drawing.Size(110, 38);
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // btnPdf
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.TabIndex = 5;
            this.btnPdf.BackColor = System.Drawing.Color.White;
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnPdf.FlatAppearance.BorderSize = 1;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPdf.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnPdf.Location = new System.Drawing.Point(520, 13);
            this.btnPdf.Size = new System.Drawing.Size(110, 38);
            this.btnPdf.Text = "Save PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // btnPrint
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.TabIndex = 6;
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnPrint.FlatAppearance.BorderSize = 1;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.btnPrint.Location = new System.Drawing.Point(640, 13);
            this.btnPrint.Size = new System.Drawing.Size(100, 38);
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // pnlChart
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.TabIndex = 1;
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.Location = new System.Drawing.Point(24, 100);
            this.pnlChart.Size = new System.Drawing.Size(590, 210);
            this.pnlChart.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlChart.Controls.Add(this.lblChartTitle);
            this.pnlChart.Controls.Add(this.chart);
            // lblChartTitle
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.lblChartTitle.Location = new System.Drawing.Point(16, 14);
            this.lblChartTitle.Text = "Monthly Attendance Rate (%)";
            // chart
            this.chart.Name = "chart";
            this.chart.TabIndex = 1;
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.chart.BackColor = System.Drawing.Color.White;
            this.chart.Location = new System.Drawing.Point(16, 46);
            this.chart.Size = new System.Drawing.Size(558, 152);
            // pnlSummary
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.TabIndex = 2;
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.Location = new System.Drawing.Point(630, 100);
            this.pnlSummary.Size = new System.Drawing.Size(239, 210);
            this.pnlSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.pnlSummary.Controls.Add(this.lblSummary);
            this.pnlSummary.Controls.Add(this.lblAvgValue);
            this.pnlSummary.Controls.Add(this.lblAvgCaption);
            this.pnlSummary.Controls.Add(this.lblLateTotalValue);
            this.pnlSummary.Controls.Add(this.lblLateTotalCaption);
            this.pnlSummary.Controls.Add(this.lblAbsentValue);
            this.pnlSummary.Controls.Add(this.lblAbsentCaption);
            this.pnlSummary.Controls.Add(this.lblLeaveDaysValue);
            this.pnlSummary.Controls.Add(this.lblLeaveDaysCaption);
            // lblSummary
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.TabIndex = 0;
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.lblSummary.Location = new System.Drawing.Point(16, 14);
            this.lblSummary.Text = "Summary";
            // lblAvgValue
            this.lblAvgValue.Name = "lblAvgValue";
            this.lblAvgValue.TabIndex = 1;
            this.lblAvgValue.AutoSize = true;
            this.lblAvgValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvgValue.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.lblAvgValue.Location = new System.Drawing.Point(16, 50);
            this.lblAvgValue.Text = "0";
            // lblAvgCaption
            this.lblAvgCaption.Name = "lblAvgCaption";
            this.lblAvgCaption.TabIndex = 2;
            this.lblAvgCaption.AutoSize = true;
            this.lblAvgCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvgCaption.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblAvgCaption.Location = new System.Drawing.Point(16, 88);
            this.lblAvgCaption.Text = "Avg. Attendance";
            // lblLateTotalValue
            this.lblLateTotalValue.Name = "lblLateTotalValue";
            this.lblLateTotalValue.TabIndex = 3;
            this.lblLateTotalValue.AutoSize = true;
            this.lblLateTotalValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLateTotalValue.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblLateTotalValue.Location = new System.Drawing.Point(130, 50);
            this.lblLateTotalValue.Text = "0";
            // lblLateTotalCaption
            this.lblLateTotalCaption.Name = "lblLateTotalCaption";
            this.lblLateTotalCaption.TabIndex = 4;
            this.lblLateTotalCaption.AutoSize = true;
            this.lblLateTotalCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLateTotalCaption.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblLateTotalCaption.Location = new System.Drawing.Point(130, 88);
            this.lblLateTotalCaption.Text = "Total Late";
            // lblAbsentValue
            this.lblAbsentValue.Name = "lblAbsentValue";
            this.lblAbsentValue.TabIndex = 5;
            this.lblAbsentValue.AutoSize = true;
            this.lblAbsentValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAbsentValue.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblAbsentValue.Location = new System.Drawing.Point(16, 128);
            this.lblAbsentValue.Text = "0";
            // lblAbsentCaption
            this.lblAbsentCaption.Name = "lblAbsentCaption";
            this.lblAbsentCaption.TabIndex = 6;
            this.lblAbsentCaption.AutoSize = true;
            this.lblAbsentCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAbsentCaption.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblAbsentCaption.Location = new System.Drawing.Point(16, 166);
            this.lblAbsentCaption.Text = "Total Absences";
            // lblLeaveDaysValue
            this.lblLeaveDaysValue.Name = "lblLeaveDaysValue";
            this.lblLeaveDaysValue.TabIndex = 7;
            this.lblLeaveDaysValue.AutoSize = true;
            this.lblLeaveDaysValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeaveDaysValue.ForeColor = System.Drawing.Color.FromArgb(0, 112, 186);
            this.lblLeaveDaysValue.Location = new System.Drawing.Point(130, 128);
            this.lblLeaveDaysValue.Text = "0";
            // lblLeaveDaysCaption
            this.lblLeaveDaysCaption.Name = "lblLeaveDaysCaption";
            this.lblLeaveDaysCaption.TabIndex = 8;
            this.lblLeaveDaysCaption.AutoSize = true;
            this.lblLeaveDaysCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeaveDaysCaption.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblLeaveDaysCaption.Location = new System.Drawing.Point(130, 166);
            this.lblLeaveDaysCaption.Text = "Leave Days";
            // lblListTitle
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.TabIndex = 3;
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(0, 48, 135);
            this.lblListTitle.Location = new System.Drawing.Point(24, 326);
            this.lblListTitle.Text = "Per-Employee Attendance (click a row to filter the chart and summary)";
            // dgvList
            this.dgvList.Name = "dgvList";
            this.dgvList.TabIndex = 4;
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvList.Location = new System.Drawing.Point(24, 354);
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(845, 170);
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // ReportsView
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // ReportsView
            this.Name = "ReportsView";
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.Size = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.dgvList);
            this.Load += new System.EventHandler(this.ReportsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlChart.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label lblChartTitle;
        private EMS.BarChart chart;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblAvgValue;
        private System.Windows.Forms.Label lblAvgCaption;
        private System.Windows.Forms.Label lblLateTotalValue;
        private System.Windows.Forms.Label lblLateTotalCaption;
        private System.Windows.Forms.Label lblAbsentValue;
        private System.Windows.Forms.Label lblAbsentCaption;
        private System.Windows.Forms.Label lblLeaveDaysValue;
        private System.Windows.Forms.Label lblLeaveDaysCaption;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dgvList;
    }
}
