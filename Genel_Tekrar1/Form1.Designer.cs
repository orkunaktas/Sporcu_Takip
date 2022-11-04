
namespace Genel_Tekrar1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuyruk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbrans = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskmaas = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sporcuVeriTabaniDataSet = new Genel_Tekrar1.SporcuVeriTabaniDataSet();
            this.tblSporcuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SporcuTableAdapter = new Genel_Tekrar1.SporcuVeriTabaniDataSetTableAdapters.Tbl_SporcuTableAdapter();
            this.spridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprUyrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporcuVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSporcuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskmaas);
            this.groupBox1.Controls.Add(this.txtbrans);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtuyruk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(150, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sporcu Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(660, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 516);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " İşlemler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(139, 539);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(974, 306);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Kayıtlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(165, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 37);
            this.textBox1.TabIndex = 1;
            // 
            // txtad
            // 
            this.txtad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtad.Location = new System.Drawing.Point(165, 144);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(205, 37);
            this.txtad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtsoyad.Location = new System.Drawing.Point(165, 200);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(205, 37);
            this.txtsoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = " Soyad:";
            // 
            // txtuyruk
            // 
            this.txtuyruk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtuyruk.Location = new System.Drawing.Point(165, 255);
            this.txtuyruk.Name = "txtuyruk";
            this.txtuyruk.Size = new System.Drawing.Size(205, 37);
            this.txtuyruk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = " Uyruk:";
            // 
            // txtbrans
            // 
            this.txtbrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtbrans.Location = new System.Drawing.Point(165, 316);
            this.txtbrans.Name = "txtbrans";
            this.txtbrans.Size = new System.Drawing.Size(205, 37);
            this.txtbrans.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = " Branş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = " Maaş";
            // 
            // mskmaas
            // 
            this.mskmaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskmaas.Location = new System.Drawing.Point(165, 380);
            this.mskmaas.Mask = "0000";
            this.mskmaas.Name = "mskmaas";
            this.mskmaas.Size = new System.Drawing.Size(205, 37);
            this.mskmaas.TabIndex = 11;
            this.mskmaas.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(99, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = " Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(99, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = " Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(99, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = " Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(99, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = " Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(99, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = " Temizle";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(99, 379);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(221, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = " İstatistikler";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spridDataGridViewTextBoxColumn,
            this.sprAdDataGridViewTextBoxColumn,
            this.sprSoyadDataGridViewTextBoxColumn,
            this.sprUyrukDataGridViewTextBoxColumn,
            this.sprBransDataGridViewTextBoxColumn,
            this.sprMaasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSporcuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(968, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sporcuVeriTabaniDataSet
            // 
            this.sporcuVeriTabaniDataSet.DataSetName = "SporcuVeriTabaniDataSet";
            this.sporcuVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSporcuBindingSource
            // 
            this.tblSporcuBindingSource.DataMember = "Tbl_Sporcu";
            this.tblSporcuBindingSource.DataSource = this.sporcuVeriTabaniDataSet;
            // 
            // tbl_SporcuTableAdapter
            // 
            this.tbl_SporcuTableAdapter.ClearBeforeFill = true;
            // 
            // spridDataGridViewTextBoxColumn
            // 
            this.spridDataGridViewTextBoxColumn.DataPropertyName = "Sprid";
            this.spridDataGridViewTextBoxColumn.HeaderText = "Sprid";
            this.spridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.spridDataGridViewTextBoxColumn.Name = "spridDataGridViewTextBoxColumn";
            this.spridDataGridViewTextBoxColumn.ReadOnly = true;
            this.spridDataGridViewTextBoxColumn.Width = 150;
            // 
            // sprAdDataGridViewTextBoxColumn
            // 
            this.sprAdDataGridViewTextBoxColumn.DataPropertyName = "SprAd";
            this.sprAdDataGridViewTextBoxColumn.HeaderText = "SprAd";
            this.sprAdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sprAdDataGridViewTextBoxColumn.Name = "sprAdDataGridViewTextBoxColumn";
            this.sprAdDataGridViewTextBoxColumn.Width = 150;
            // 
            // sprSoyadDataGridViewTextBoxColumn
            // 
            this.sprSoyadDataGridViewTextBoxColumn.DataPropertyName = "SprSoyad";
            this.sprSoyadDataGridViewTextBoxColumn.HeaderText = "SprSoyad";
            this.sprSoyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sprSoyadDataGridViewTextBoxColumn.Name = "sprSoyadDataGridViewTextBoxColumn";
            this.sprSoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // sprUyrukDataGridViewTextBoxColumn
            // 
            this.sprUyrukDataGridViewTextBoxColumn.DataPropertyName = "SprUyruk";
            this.sprUyrukDataGridViewTextBoxColumn.HeaderText = "SprUyruk";
            this.sprUyrukDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sprUyrukDataGridViewTextBoxColumn.Name = "sprUyrukDataGridViewTextBoxColumn";
            this.sprUyrukDataGridViewTextBoxColumn.Width = 150;
            // 
            // sprBransDataGridViewTextBoxColumn
            // 
            this.sprBransDataGridViewTextBoxColumn.DataPropertyName = "SprBrans";
            this.sprBransDataGridViewTextBoxColumn.HeaderText = "SprBrans";
            this.sprBransDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sprBransDataGridViewTextBoxColumn.Name = "sprBransDataGridViewTextBoxColumn";
            this.sprBransDataGridViewTextBoxColumn.Width = 150;
            // 
            // sprMaasDataGridViewTextBoxColumn
            // 
            this.sprMaasDataGridViewTextBoxColumn.DataPropertyName = "SprMaas";
            this.sprMaasDataGridViewTextBoxColumn.HeaderText = "SprMaas";
            this.sprMaasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sprMaasDataGridViewTextBoxColumn.Name = "sprMaasDataGridViewTextBoxColumn";
            this.sprMaasDataGridViewTextBoxColumn.Width = 150;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(1128, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 39);
            this.button7.TabIndex = 3;
            this.button7.Text = "Çıkış";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1256, 878);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporcuVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSporcuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskmaas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtuyruk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SporcuVeriTabaniDataSet sporcuVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblSporcuBindingSource;
        private SporcuVeriTabaniDataSetTableAdapters.Tbl_SporcuTableAdapter tbl_SporcuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn spridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprUyrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
    }
}

