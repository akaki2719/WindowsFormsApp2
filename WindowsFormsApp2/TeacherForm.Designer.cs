
namespace SchoolProject
{
    partial class TeacherForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameXD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_teacherinfo = new System.Windows.Forms.Label();
            this.label_gridviewStudents = new System.Windows.Forms.Label();
            this.button_getStats = new System.Windows.Forms.Button();
            this.button_giveGrade = new System.Windows.Forms.Button();
            this.chart_stats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_giveGrade = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gradesPage = new System.Windows.Forms.TabPage();
            this.label_grades = new System.Windows.Forms.Label();
            this.homeworkPage = new System.Windows.Forms.TabPage();
            this.button_sendHW = new System.Windows.Forms.Button();
            this.label_hwDescr = new System.Windows.Forms.Label();
            this.textBox_hwDescr = new System.Windows.Forms.TextBox();
            this.label_hwTitle = new System.Windows.Forms.Label();
            this.textBox_hwTitle = new System.Windows.Forms.TextBox();
            this.label_homework = new System.Windows.Forms.Label();
            this.submissionsPage = new System.Windows.Forms.TabPage();
            this.button_checkSubm = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_submissions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stats)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.gradesPage.SuspendLayout();
            this.homeworkPage.SuspendLayout();
            this.submissionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.ID,
            this.NameXD,
            this.Lastname});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(10, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(424, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Select";
            this.Selected.Name = "Selected";
            this.Selected.Width = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 35;
            // 
            // NameXD
            // 
            this.NameXD.HeaderText = "Name";
            this.NameXD.Name = "NameXD";
            this.NameXD.Width = 115;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.Width = 180;
            // 
            // label_teacherinfo
            // 
            this.label_teacherinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_teacherinfo.AutoSize = true;
            this.label_teacherinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teacherinfo.Location = new System.Drawing.Point(363, 61);
            this.label_teacherinfo.Name = "label_teacherinfo";
            this.label_teacherinfo.Size = new System.Drawing.Size(212, 31);
            this.label_teacherinfo.TabIndex = 1;
            this.label_teacherinfo.Text = "Name Lastname";
            // 
            // label_gridviewStudents
            // 
            this.label_gridviewStudents.AutoSize = true;
            this.label_gridviewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label_gridviewStudents.Location = new System.Drawing.Point(10, 87);
            this.label_gridviewStudents.Name = "label_gridviewStudents";
            this.label_gridviewStudents.Size = new System.Drawing.Size(63, 16);
            this.label_gridviewStudents.TabIndex = 2;
            this.label_gridviewStudents.Text = "Students:";
            // 
            // button_getStats
            // 
            this.button_getStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.button_getStats.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_getStats.Location = new System.Drawing.Point(6, 6);
            this.button_getStats.Name = "button_getStats";
            this.button_getStats.Size = new System.Drawing.Size(163, 39);
            this.button_getStats.TabIndex = 3;
            this.button_getStats.Text = "Get Statistics";
            this.button_getStats.UseVisualStyleBackColor = true;
            this.button_getStats.Click += new System.EventHandler(this.button_getStats_Click);
            // 
            // button_giveGrade
            // 
            this.button_giveGrade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.button_giveGrade.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_giveGrade.Location = new System.Drawing.Point(57, 51);
            this.button_giveGrade.Name = "button_giveGrade";
            this.button_giveGrade.Size = new System.Drawing.Size(112, 39);
            this.button_giveGrade.TabIndex = 4;
            this.button_giveGrade.Text = "Give a Grade";
            this.button_giveGrade.UseVisualStyleBackColor = true;
            this.button_giveGrade.Click += new System.EventHandler(this.button_giveGrade_Click);
            // 
            // chart_stats
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_stats.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_stats.Legends.Add(legend1);
            this.chart_stats.Location = new System.Drawing.Point(6, 105);
            this.chart_stats.Name = "chart_stats";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Grades";
            this.chart_stats.Series.Add(series1);
            this.chart_stats.Size = new System.Drawing.Size(457, 283);
            this.chart_stats.TabIndex = 5;
            this.chart_stats.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Name Lastname";
            this.chart_stats.Titles.Add(title1);
            // 
            // textBox_giveGrade
            // 
            this.textBox_giveGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.textBox_giveGrade.Location = new System.Drawing.Point(6, 52);
            this.textBox_giveGrade.Multiline = true;
            this.textBox_giveGrade.Name = "textBox_giveGrade";
            this.textBox_giveGrade.Size = new System.Drawing.Size(45, 38);
            this.textBox_giveGrade.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.gradesPage);
            this.tabControl1.Controls.Add(this.homeworkPage);
            this.tabControl1.Controls.Add(this.submissionsPage);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.tabControl1.Location = new System.Drawing.Point(440, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 420);
            this.tabControl1.TabIndex = 7;
            // 
            // gradesPage
            // 
            this.gradesPage.BackColor = System.Drawing.Color.Honeydew;
            this.gradesPage.Controls.Add(this.label_grades);
            this.gradesPage.Controls.Add(this.button_getStats);
            this.gradesPage.Controls.Add(this.chart_stats);
            this.gradesPage.Controls.Add(this.textBox_giveGrade);
            this.gradesPage.Controls.Add(this.button_giveGrade);
            this.gradesPage.Location = new System.Drawing.Point(4, 26);
            this.gradesPage.Name = "gradesPage";
            this.gradesPage.Padding = new System.Windows.Forms.Padding(3);
            this.gradesPage.Size = new System.Drawing.Size(469, 390);
            this.gradesPage.TabIndex = 0;
            this.gradesPage.Text = "Grades";
            // 
            // label_grades
            // 
            this.label_grades.AutoSize = true;
            this.label_grades.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_grades.Location = new System.Drawing.Point(241, 29);
            this.label_grades.Name = "label_grades";
            this.label_grades.Size = new System.Drawing.Size(92, 29);
            this.label_grades.TabIndex = 7;
            this.label_grades.Text = "Grades";
            // 
            // homeworkPage
            // 
            this.homeworkPage.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.homeworkPage.Controls.Add(this.button_sendHW);
            this.homeworkPage.Controls.Add(this.label_hwDescr);
            this.homeworkPage.Controls.Add(this.textBox_hwDescr);
            this.homeworkPage.Controls.Add(this.label_hwTitle);
            this.homeworkPage.Controls.Add(this.textBox_hwTitle);
            this.homeworkPage.Controls.Add(this.label_homework);
            this.homeworkPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homeworkPage.Location = new System.Drawing.Point(4, 26);
            this.homeworkPage.Name = "homeworkPage";
            this.homeworkPage.Padding = new System.Windows.Forms.Padding(3);
            this.homeworkPage.Size = new System.Drawing.Size(469, 390);
            this.homeworkPage.TabIndex = 1;
            this.homeworkPage.Text = "Homework";
            // 
            // button_sendHW
            // 
            this.button_sendHW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.button_sendHW.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_sendHW.Location = new System.Drawing.Point(360, 349);
            this.button_sendHW.Name = "button_sendHW";
            this.button_sendHW.Size = new System.Drawing.Size(89, 33);
            this.button_sendHW.TabIndex = 13;
            this.button_sendHW.Text = "Send";
            this.button_sendHW.UseVisualStyleBackColor = true;
            this.button_sendHW.Click += new System.EventHandler(this.button_sendHW_Click);
            // 
            // label_hwDescr
            // 
            this.label_hwDescr.AutoSize = true;
            this.label_hwDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label_hwDescr.Location = new System.Drawing.Point(16, 91);
            this.label_hwDescr.Name = "label_hwDescr";
            this.label_hwDescr.Size = new System.Drawing.Size(102, 16);
            this.label_hwDescr.TabIndex = 12;
            this.label_hwDescr.Text = "HW Description";
            // 
            // textBox_hwDescr
            // 
            this.textBox_hwDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.textBox_hwDescr.Location = new System.Drawing.Point(20, 114);
            this.textBox_hwDescr.Multiline = true;
            this.textBox_hwDescr.Name = "textBox_hwDescr";
            this.textBox_hwDescr.Size = new System.Drawing.Size(429, 226);
            this.textBox_hwDescr.TabIndex = 11;
            // 
            // label_hwTitle
            // 
            this.label_hwTitle.AutoSize = true;
            this.label_hwTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label_hwTitle.Location = new System.Drawing.Point(16, 27);
            this.label_hwTitle.Name = "label_hwTitle";
            this.label_hwTitle.Size = new System.Drawing.Size(56, 17);
            this.label_hwTitle.TabIndex = 10;
            this.label_hwTitle.Text = "HW Title";
            // 
            // textBox_hwTitle
            // 
            this.textBox_hwTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.textBox_hwTitle.Location = new System.Drawing.Point(20, 50);
            this.textBox_hwTitle.Name = "textBox_hwTitle";
            this.textBox_hwTitle.Size = new System.Drawing.Size(181, 25);
            this.textBox_hwTitle.TabIndex = 9;
            // 
            // label_homework
            // 
            this.label_homework.AutoSize = true;
            this.label_homework.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_homework.Location = new System.Drawing.Point(266, 41);
            this.label_homework.Name = "label_homework";
            this.label_homework.Size = new System.Drawing.Size(144, 31);
            this.label_homework.TabIndex = 8;
            this.label_homework.Text = "Homework";
            // 
            // submissionsPage
            // 
            this.submissionsPage.BackColor = System.Drawing.Color.Linen;
            this.submissionsPage.Controls.Add(this.button_checkSubm);
            this.submissionsPage.Controls.Add(this.dataGridView2);
            this.submissionsPage.Controls.Add(this.label_submissions);
            this.submissionsPage.Location = new System.Drawing.Point(4, 26);
            this.submissionsPage.Name = "submissionsPage";
            this.submissionsPage.Size = new System.Drawing.Size(469, 390);
            this.submissionsPage.TabIndex = 2;
            this.submissionsPage.Text = "Submissions";
            // 
            // button_checkSubm
            // 
            this.button_checkSubm.BackColor = System.Drawing.Color.Cyan;
            this.button_checkSubm.Location = new System.Drawing.Point(7, 345);
            this.button_checkSubm.Name = "button_checkSubm";
            this.button_checkSubm.Size = new System.Drawing.Size(108, 36);
            this.button_checkSubm.TabIndex = 8;
            this.button_checkSubm.Text = "Check Submission";
            this.button_checkSubm.UseVisualStyleBackColor = false;
            this.button_checkSubm.Click += new System.EventHandler(this.button_checkSubm_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(7, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(282, 311);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // label_submissions
            // 
            this.label_submissions.AutoSize = true;
            this.label_submissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.label_submissions.Location = new System.Drawing.Point(303, 22);
            this.label_submissions.Name = "label_submissions";
            this.label_submissions.Size = new System.Drawing.Size(85, 16);
            this.label_submissions.TabIndex = 14;
            this.label_submissions.Text = "Submissions";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(929, 573);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_gridviewStudents);
            this.Controls.Add(this.label_teacherinfo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stats)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.gradesPage.ResumeLayout(false);
            this.gradesPage.PerformLayout();
            this.homeworkPage.ResumeLayout(false);
            this.homeworkPage.PerformLayout();
            this.submissionsPage.ResumeLayout(false);
            this.submissionsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_teacherinfo;
        private System.Windows.Forms.Label label_gridviewStudents;
        private System.Windows.Forms.Button button_getStats;
        private System.Windows.Forms.Button button_giveGrade;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stats;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameXD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.TextBox textBox_giveGrade;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gradesPage;
        private System.Windows.Forms.Label label_grades;
        private System.Windows.Forms.TabPage homeworkPage;
        private System.Windows.Forms.Button button_sendHW;
        private System.Windows.Forms.Label label_hwDescr;
        private System.Windows.Forms.TextBox textBox_hwDescr;
        private System.Windows.Forms.Label label_hwTitle;
        private System.Windows.Forms.TextBox textBox_hwTitle;
        private System.Windows.Forms.Label label_homework;
        private System.Windows.Forms.TabPage submissionsPage;
        private System.Windows.Forms.Label label_submissions;
        private System.Windows.Forms.Button button_checkSubm;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}