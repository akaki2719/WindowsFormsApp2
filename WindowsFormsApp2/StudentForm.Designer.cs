
namespace SchoolProject
{
    partial class StudentForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label_studentinfo = new System.Windows.Forms.Label();
            this.chart_stats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_checkHW = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.richTextBox_soution = new System.Windows.Forms.RichTextBox();
            this.button_submit_hw = new System.Windows.Forms.Button();
            this.textBox_homework_description = new System.Windows.Forms.TextBox();
            this.label_hw_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_studentinfo
            // 
            this.label_studentinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_studentinfo.AutoSize = true;
            this.label_studentinfo.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.label_studentinfo.Location = new System.Drawing.Point(352, 9);
            this.label_studentinfo.Name = "label_studentinfo";
            this.label_studentinfo.Size = new System.Drawing.Size(0, 47);
            this.label_studentinfo.TabIndex = 2;
            // 
            // chart_stats
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_stats.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_stats.Legends.Add(legend1);
            this.chart_stats.Location = new System.Drawing.Point(12, 69);
            this.chart_stats.Name = "chart_stats";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Grades";
            this.chart_stats.Series.Add(series1);
            this.chart_stats.Size = new System.Drawing.Size(397, 241);
            this.chart_stats.TabIndex = 6;
            this.chart_stats.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Name Lastname";
            this.chart_stats.Titles.Add(title1);
            // 
            // button_checkHW
            // 
            this.button_checkHW.BackColor = System.Drawing.Color.Cyan;
            this.button_checkHW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.button_checkHW.Location = new System.Drawing.Point(301, 316);
            this.button_checkHW.Name = "button_checkHW";
            this.button_checkHW.Size = new System.Drawing.Size(108, 36);
            this.button_checkHW.TabIndex = 8;
            this.button_checkHW.Text = "Check Homework";
            this.button_checkHW.UseVisualStyleBackColor = false;
            this.button_checkHW.Click += new System.EventHandler(this.button_checkHW_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(12, 316);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(279, 245);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // richTextBox_soution
            // 
            this.richTextBox_soution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.richTextBox_soution.Location = new System.Drawing.Point(442, 261);
            this.richTextBox_soution.Name = "richTextBox_soution";
            this.richTextBox_soution.Size = new System.Drawing.Size(475, 247);
            this.richTextBox_soution.TabIndex = 17;
            this.richTextBox_soution.Text = "";
            // 
            // button_submit_hw
            // 
            this.button_submit_hw.BackColor = System.Drawing.Color.Aqua;
            this.button_submit_hw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.button_submit_hw.Location = new System.Drawing.Point(752, 525);
            this.button_submit_hw.Name = "button_submit_hw";
            this.button_submit_hw.Size = new System.Drawing.Size(165, 36);
            this.button_submit_hw.TabIndex = 18;
            this.button_submit_hw.Text = "Submit Homework";
            this.button_submit_hw.UseVisualStyleBackColor = false;
            this.button_submit_hw.Click += new System.EventHandler(this.button_submit_hw_Click);
            // 
            // textBox_homework_description
            // 
            this.textBox_homework_description.BackColor = System.Drawing.Color.LightCyan;
            this.textBox_homework_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.textBox_homework_description.Location = new System.Drawing.Point(442, 121);
            this.textBox_homework_description.Multiline = true;
            this.textBox_homework_description.Name = "textBox_homework_description";
            this.textBox_homework_description.Size = new System.Drawing.Size(475, 112);
            this.textBox_homework_description.TabIndex = 19;
            // 
            // label_hw_title
            // 
            this.label_hw_title.AutoSize = true;
            this.label_hw_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hw_title.Location = new System.Drawing.Point(436, 69);
            this.label_hw_title.Name = "label_hw_title";
            this.label_hw_title.Size = new System.Drawing.Size(0, 31);
            this.label_hw_title.TabIndex = 20;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(929, 573);
            this.Controls.Add(this.label_hw_title);
            this.Controls.Add(this.textBox_homework_description);
            this.Controls.Add(this.button_submit_hw);
            this.Controls.Add(this.richTextBox_soution);
            this.Controls.Add(this.button_checkHW);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.chart_stats);
            this.Controls.Add(this.label_studentinfo);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_stats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_studentinfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stats;
        private System.Windows.Forms.Button button_checkHW;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox richTextBox_soution;
        private System.Windows.Forms.Button button_submit_hw;
        private System.Windows.Forms.TextBox textBox_homework_description;
        private System.Windows.Forms.Label label_hw_title;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}