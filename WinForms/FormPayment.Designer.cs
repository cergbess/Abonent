namespace MondoDBtest
{
    partial class FormPayment
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualUsageVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalChargedForThePeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRecalculationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benefitsAndSubsidiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtPastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelServiceBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.modelServiceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.modelServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelServiceBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelServiceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelServiceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.29948F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.7005254F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.59036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.409639F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 254);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceNameDataGridViewTextBoxColumn,
            this.unitOfMeasurementDataGridViewTextBoxColumn,
            this.individualUsageVolumeDataGridViewTextBoxColumn,
            this.tariffDataGridViewTextBoxColumn,
            this.totalChargedForThePeriodDataGridViewTextBoxColumn,
            this.totalRecalculationsDataGridViewTextBoxColumn,
            this.benefitsAndSubsidiesDataGridViewTextBoxColumn,
            this.debtPastDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelServiceBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 268);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.45454F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.54546F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(559, 132);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбранная услуга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "К оплате";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(281, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(281, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Внесено";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(646, 270);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(678, 352);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.FillWeight = 10F;
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            // 
            // unitOfMeasurementDataGridViewTextBoxColumn
            // 
            this.unitOfMeasurementDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitOfMeasurementDataGridViewTextBoxColumn.DataPropertyName = "UnitOfMeasurement";
            this.unitOfMeasurementDataGridViewTextBoxColumn.FillWeight = 10F;
            this.unitOfMeasurementDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.unitOfMeasurementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitOfMeasurementDataGridViewTextBoxColumn.Name = "unitOfMeasurementDataGridViewTextBoxColumn";
            // 
            // individualUsageVolumeDataGridViewTextBoxColumn
            // 
            this.individualUsageVolumeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.individualUsageVolumeDataGridViewTextBoxColumn.DataPropertyName = "IndividualUsageVolume";
            this.individualUsageVolumeDataGridViewTextBoxColumn.FillWeight = 10F;
            this.individualUsageVolumeDataGridViewTextBoxColumn.HeaderText = "Потреблено ед.";
            this.individualUsageVolumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.individualUsageVolumeDataGridViewTextBoxColumn.Name = "individualUsageVolumeDataGridViewTextBoxColumn";
            // 
            // tariffDataGridViewTextBoxColumn
            // 
            this.tariffDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tariffDataGridViewTextBoxColumn.DataPropertyName = "tariff";
            this.tariffDataGridViewTextBoxColumn.FillWeight = 10F;
            this.tariffDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.tariffDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tariffDataGridViewTextBoxColumn.Name = "tariffDataGridViewTextBoxColumn";
            // 
            // totalChargedForThePeriodDataGridViewTextBoxColumn
            // 
            this.totalChargedForThePeriodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalChargedForThePeriodDataGridViewTextBoxColumn.DataPropertyName = "TotalChargedForThePeriod";
            this.totalChargedForThePeriodDataGridViewTextBoxColumn.FillWeight = 10F;
            this.totalChargedForThePeriodDataGridViewTextBoxColumn.HeaderText = "Начислено";
            this.totalChargedForThePeriodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalChargedForThePeriodDataGridViewTextBoxColumn.Name = "totalChargedForThePeriodDataGridViewTextBoxColumn";
            this.totalChargedForThePeriodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalRecalculationsDataGridViewTextBoxColumn
            // 
            this.totalRecalculationsDataGridViewTextBoxColumn.DataPropertyName = "TotalRecalculations";
            this.totalRecalculationsDataGridViewTextBoxColumn.FillWeight = 10F;
            this.totalRecalculationsDataGridViewTextBoxColumn.HeaderText = "Пересчеты";
            this.totalRecalculationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalRecalculationsDataGridViewTextBoxColumn.Name = "totalRecalculationsDataGridViewTextBoxColumn";
            this.totalRecalculationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // benefitsAndSubsidiesDataGridViewTextBoxColumn
            // 
            this.benefitsAndSubsidiesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.benefitsAndSubsidiesDataGridViewTextBoxColumn.DataPropertyName = "BenefitsAndSubsidies";
            this.benefitsAndSubsidiesDataGridViewTextBoxColumn.FillWeight = 10F;
            this.benefitsAndSubsidiesDataGridViewTextBoxColumn.HeaderText = "Льготы";
            this.benefitsAndSubsidiesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.benefitsAndSubsidiesDataGridViewTextBoxColumn.Name = "benefitsAndSubsidiesDataGridViewTextBoxColumn";
            // 
            // debtPastDataGridViewTextBoxColumn
            // 
            this.debtPastDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.debtPastDataGridViewTextBoxColumn.DataPropertyName = "DebtPast";
            this.debtPastDataGridViewTextBoxColumn.FillWeight = 10F;
            this.debtPastDataGridViewTextBoxColumn.HeaderText = "Задолжность за пр. период";
            this.debtPastDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.debtPastDataGridViewTextBoxColumn.Name = "debtPastDataGridViewTextBoxColumn";
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewTextBoxColumn.FillWeight = 10F;
            this.paidDataGridViewTextBoxColumn.HeaderText = "Оплачено";
            this.paidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "Debt";
            this.debtDataGridViewTextBoxColumn.FillWeight = 10F;
            this.debtDataGridViewTextBoxColumn.HeaderText = "Текущий долг";
            this.debtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            this.debtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelServiceBindingSource3
            // 
            this.modelServiceBindingSource3.DataSource = typeof(MondoDBtest.ModelService);
            // 
            // modelServiceBindingSource2
            // 
            this.modelServiceBindingSource2.DataSource = typeof(MondoDBtest.ModelService);
            // 
            // modelServiceBindingSource
            // 
            this.modelServiceBindingSource.DataSource = typeof(MondoDBtest.ModelService);
            // 
            // modelServiceBindingSource1
            // 
            this.modelServiceBindingSource1.DataSource = typeof(MondoDBtest.ModelService);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelServiceBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelServiceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelServiceBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource modelServiceBindingSource;
        private System.Windows.Forms.BindingSource modelServiceBindingSource1;
        private System.Windows.Forms.BindingSource modelServiceBindingSource2;
        private System.Windows.Forms.BindingSource modelServiceBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeasurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualUsageVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalChargedForThePeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRecalculationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn benefitsAndSubsidiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtPastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}