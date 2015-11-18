namespace TESTER
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вариантОтветаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вариантОтветаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вариантОтветаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вариантОтветаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.правильныйОтветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdQuestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet1 = new TESTER.BDDataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bdQuestTableAdapter = new TESTER.BDDataSet1TableAdapters.bdQuestTableAdapter();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdQuestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 109);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(106, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(106, 109);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.вопросDataGridViewTextBoxColumn,
            this.вариантОтветаDataGridViewTextBoxColumn,
            this.вариантОтветаDataGridViewTextBoxColumn1,
            this.вариантОтветаDataGridViewTextBoxColumn2,
            this.вариантОтветаDataGridViewTextBoxColumn3,
            this.правильныйОтветDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdQuestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // вопросDataGridViewTextBoxColumn
            // 
            this.вопросDataGridViewTextBoxColumn.DataPropertyName = "Вопрос";
            this.вопросDataGridViewTextBoxColumn.HeaderText = "Вопрос";
            this.вопросDataGridViewTextBoxColumn.Name = "вопросDataGridViewTextBoxColumn";
            // 
            // вариантОтветаDataGridViewTextBoxColumn
            // 
            this.вариантОтветаDataGridViewTextBoxColumn.DataPropertyName = "1 вариант ответа";
            this.вариантОтветаDataGridViewTextBoxColumn.HeaderText = "1 вариант ответа";
            this.вариантОтветаDataGridViewTextBoxColumn.Name = "вариантОтветаDataGridViewTextBoxColumn";
            // 
            // вариантОтветаDataGridViewTextBoxColumn1
            // 
            this.вариантОтветаDataGridViewTextBoxColumn1.DataPropertyName = "2 вариант ответа";
            this.вариантОтветаDataGridViewTextBoxColumn1.HeaderText = "2 вариант ответа";
            this.вариантОтветаDataGridViewTextBoxColumn1.Name = "вариантОтветаDataGridViewTextBoxColumn1";
            // 
            // вариантОтветаDataGridViewTextBoxColumn2
            // 
            this.вариантОтветаDataGridViewTextBoxColumn2.DataPropertyName = "3 вариант ответа";
            this.вариантОтветаDataGridViewTextBoxColumn2.HeaderText = "3 вариант ответа";
            this.вариантОтветаDataGridViewTextBoxColumn2.Name = "вариантОтветаDataGridViewTextBoxColumn2";
            // 
            // вариантОтветаDataGridViewTextBoxColumn3
            // 
            this.вариантОтветаDataGridViewTextBoxColumn3.DataPropertyName = "4 вариант ответа";
            this.вариантОтветаDataGridViewTextBoxColumn3.HeaderText = "4 вариант ответа";
            this.вариантОтветаDataGridViewTextBoxColumn3.Name = "вариантОтветаDataGridViewTextBoxColumn3";
            // 
            // правильныйОтветDataGridViewTextBoxColumn
            // 
            this.правильныйОтветDataGridViewTextBoxColumn.DataPropertyName = "правильный ответ";
            this.правильныйОтветDataGridViewTextBoxColumn.HeaderText = "правильный ответ";
            this.правильныйОтветDataGridViewTextBoxColumn.Name = "правильныйОтветDataGridViewTextBoxColumn";
            // 
            // bdQuestBindingSource
            // 
            this.bdQuestBindingSource.DataMember = "bdQuest";
            this.bdQuestBindingSource.DataSource = this.bDDataSet1;
            // 
            // bDDataSet1
            // 
            this.bDDataSet1.DataSetName = "BDDataSet1";
            this.bDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(517, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bdQuestTableAdapter
            // 
            this.bdQuestTableAdapter.ClearBeforeFill = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(517, 135);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(623, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 20);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 295);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdQuestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private BDDataSet1 bDDataSet1;
        private System.Windows.Forms.BindingSource bdQuestBindingSource;
        private BDDataSet1TableAdapters.bdQuestTableAdapter bdQuestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вариантОтветаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вариантОтветаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn вариантОтветаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn вариантОтветаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn правильныйОтветDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
    }
}

