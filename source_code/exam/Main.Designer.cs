namespace exam
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView_array = new System.Windows.Forms.DataGridView();
            this.chart_graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_rand = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_task = new System.Windows.Forms.Button();
            this.btn_graph = new System.Windows.Forms.Button();
            this.btn_graphClear = new System.Windows.Forms.Button();
            this.btn_toForm = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_array)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graph)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_array
            // 
            this.dataGridView_array.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_array.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25});
            this.dataGridView_array.Location = new System.Drawing.Point(13, 286);
            this.dataGridView_array.Name = "dataGridView_array";
            this.dataGridView_array.Size = new System.Drawing.Size(769, 41);
            this.dataGridView_array.TabIndex = 0;
            // 
            // chart_graph
            // 
            chartArea7.Name = "ChartArea1";
            this.chart_graph.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart_graph.Legends.Add(legend7);
            this.chart_graph.Location = new System.Drawing.Point(222, 13);
            this.chart_graph.Name = "chart_graph";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Массив";
            this.chart_graph.Series.Add(series7);
            this.chart_graph.Size = new System.Drawing.Size(560, 267);
            this.chart_graph.TabIndex = 1;
            this.chart_graph.Text = "chart_graph";
            // 
            // btn_rand
            // 
            this.btn_rand.Location = new System.Drawing.Point(13, 13);
            this.btn_rand.Name = "btn_rand";
            this.btn_rand.Size = new System.Drawing.Size(203, 33);
            this.btn_rand.TabIndex = 2;
            this.btn_rand.Text = "Задать массив";
            this.btn_rand.UseVisualStyleBackColor = true;
            this.btn_rand.Click += new System.EventHandler(this.btn_rand_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(13, 52);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(203, 33);
            this.btn_sort.TabIndex = 3;
            this.btn_sort.Text = "Сортировка массива";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_task
            // 
            this.btn_task.Location = new System.Drawing.Point(12, 130);
            this.btn_task.Name = "btn_task";
            this.btn_task.Size = new System.Drawing.Size(203, 33);
            this.btn_task.TabIndex = 4;
            this.btn_task.Text = "Выполнить задание";
            this.btn_task.UseVisualStyleBackColor = true;
            this.btn_task.Click += new System.EventHandler(this.btn_task_Click);
            // 
            // btn_graph
            // 
            this.btn_graph.Location = new System.Drawing.Point(13, 91);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(203, 33);
            this.btn_graph.TabIndex = 5;
            this.btn_graph.Text = "Построение графика";
            this.btn_graph.UseVisualStyleBackColor = true;
            this.btn_graph.Click += new System.EventHandler(this.btn_graph_Click);
            // 
            // btn_graphClear
            // 
            this.btn_graphClear.Location = new System.Drawing.Point(13, 169);
            this.btn_graphClear.Name = "btn_graphClear";
            this.btn_graphClear.Size = new System.Drawing.Size(203, 33);
            this.btn_graphClear.TabIndex = 6;
            this.btn_graphClear.Text = "Очистить график";
            this.btn_graphClear.UseVisualStyleBackColor = true;
            this.btn_graphClear.Click += new System.EventHandler(this.btn_graphClear_Click);
            // 
            // btn_toForm
            // 
            this.btn_toForm.Location = new System.Drawing.Point(13, 208);
            this.btn_toForm.Name = "btn_toForm";
            this.btn_toForm.Size = new System.Drawing.Size(203, 33);
            this.btn_toForm.TabIndex = 7;
            this.btn_toForm.Text = "Переход на форму";
            this.btn_toForm.UseVisualStyleBackColor = true;
            this.btn_toForm.Click += new System.EventHandler(this.btn_toForm_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(13, 247);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(203, 33);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Завершение программы";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "9";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "10";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "11";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "12";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "13";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "14";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "15";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "16";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "17";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "18";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "19";
            this.Column19.Name = "Column19";
            // 
            // Column20
            // 
            this.Column20.HeaderText = "20";
            this.Column20.Name = "Column20";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "21";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.HeaderText = "22";
            this.Column22.Name = "Column22";
            // 
            // Column23
            // 
            this.Column23.HeaderText = "23";
            this.Column23.Name = "Column23";
            // 
            // Column24
            // 
            this.Column24.HeaderText = "24";
            this.Column24.Name = "Column24";
            // 
            // Column25
            // 
            this.Column25.HeaderText = "25";
            this.Column25.Name = "Column25";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(794, 339);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_toForm);
            this.Controls.Add(this.btn_graphClear);
            this.Controls.Add(this.btn_graph);
            this.Controls.Add(this.btn_task);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_rand);
            this.Controls.Add(this.chart_graph);
            this.Controls.Add(this.dataGridView_array);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_array)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_array;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graph;
        private System.Windows.Forms.Button btn_rand;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_task;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.Button btn_graphClear;
        private System.Windows.Forms.Button btn_toForm;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
    }
}

