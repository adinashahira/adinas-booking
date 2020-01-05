namespace Adinas_Booking
{
    partial class SenaraiPelanggan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mukaDepanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adinasbookingdataDataSet1 = new Adinas_Booking.adinasbookingdataDataSet1();
            this.custInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custInfoTableAdapter = new Adinas_Booking.adinasbookingdataDataSet1TableAdapters.custInfoTableAdapter();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custShoulderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custChestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custWaistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custHipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custTopLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custTopLengthShortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custBottomLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSleeveLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custShoulderDownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custArmCircDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPtPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSleeveOpenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFullDressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSleeveLength2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adinasbookingdataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.HotPink;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mukaDepanToolStripMenuItem,
            this.daftarPelangganToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1942, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mukaDepanToolStripMenuItem
            // 
            this.mukaDepanToolStripMenuItem.Name = "mukaDepanToolStripMenuItem";
            this.mukaDepanToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.mukaDepanToolStripMenuItem.Text = "Muka Depan";
            // 
            // daftarPelangganToolStripMenuItem
            // 
            this.daftarPelangganToolStripMenuItem.Name = "daftarPelangganToolStripMenuItem";
            this.daftarPelangganToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.daftarPelangganToolStripMenuItem.Text = "Daftar Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepPink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(800, 80, 800, 80);
            this.label1.Size = new System.Drawing.Size(1942, 204);
            this.label1.TabIndex = 20;
            this.label1.Text = "Senarai Pelanggan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNameDataGridViewTextBoxColumn,
            this.custContactDataGridViewTextBoxColumn,
            this.custShoulderDataGridViewTextBoxColumn,
            this.custChestDataGridViewTextBoxColumn,
            this.custWaistDataGridViewTextBoxColumn,
            this.custHipDataGridViewTextBoxColumn,
            this.custTopLengthDataGridViewTextBoxColumn,
            this.custTopLengthShortDataGridViewTextBoxColumn,
            this.custBottomLengthDataGridViewTextBoxColumn,
            this.custSleeveLengthDataGridViewTextBoxColumn,
            this.custShoulderDownDataGridViewTextBoxColumn,
            this.custArmCircDataGridViewTextBoxColumn,
            this.custPtPDataGridViewTextBoxColumn,
            this.custSleeveOpenDataGridViewTextBoxColumn,
            this.custFullDressDataGridViewTextBoxColumn,
            this.custPTDataGridViewTextBoxColumn,
            this.custSleeveLength2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.custInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1756, 521);
            this.dataGridView1.TabIndex = 22;
            // 
            // adinasbookingdataDataSet1
            // 
            this.adinasbookingdataDataSet1.DataSetName = "adinasbookingdataDataSet1";
            this.adinasbookingdataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custInfoBindingSource
            // 
            this.custInfoBindingSource.DataMember = "custInfo";
            this.custInfoBindingSource.DataSource = this.adinasbookingdataDataSet1;
            // 
            // custInfoTableAdapter
            // 
            this.custInfoTableAdapter.ClearBeforeFill = true;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "custName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "custName";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            // 
            // custContactDataGridViewTextBoxColumn
            // 
            this.custContactDataGridViewTextBoxColumn.DataPropertyName = "custContact";
            this.custContactDataGridViewTextBoxColumn.HeaderText = "custContact";
            this.custContactDataGridViewTextBoxColumn.Name = "custContactDataGridViewTextBoxColumn";
            // 
            // custShoulderDataGridViewTextBoxColumn
            // 
            this.custShoulderDataGridViewTextBoxColumn.DataPropertyName = "custShoulder";
            this.custShoulderDataGridViewTextBoxColumn.HeaderText = "custShoulder";
            this.custShoulderDataGridViewTextBoxColumn.Name = "custShoulderDataGridViewTextBoxColumn";
            // 
            // custChestDataGridViewTextBoxColumn
            // 
            this.custChestDataGridViewTextBoxColumn.DataPropertyName = "custChest";
            this.custChestDataGridViewTextBoxColumn.HeaderText = "custChest";
            this.custChestDataGridViewTextBoxColumn.Name = "custChestDataGridViewTextBoxColumn";
            // 
            // custWaistDataGridViewTextBoxColumn
            // 
            this.custWaistDataGridViewTextBoxColumn.DataPropertyName = "custWaist";
            this.custWaistDataGridViewTextBoxColumn.HeaderText = "custWaist";
            this.custWaistDataGridViewTextBoxColumn.Name = "custWaistDataGridViewTextBoxColumn";
            // 
            // custHipDataGridViewTextBoxColumn
            // 
            this.custHipDataGridViewTextBoxColumn.DataPropertyName = "custHip";
            this.custHipDataGridViewTextBoxColumn.HeaderText = "custHip";
            this.custHipDataGridViewTextBoxColumn.Name = "custHipDataGridViewTextBoxColumn";
            // 
            // custTopLengthDataGridViewTextBoxColumn
            // 
            this.custTopLengthDataGridViewTextBoxColumn.DataPropertyName = "custTopLength";
            this.custTopLengthDataGridViewTextBoxColumn.HeaderText = "custTopLength";
            this.custTopLengthDataGridViewTextBoxColumn.Name = "custTopLengthDataGridViewTextBoxColumn";
            // 
            // custTopLengthShortDataGridViewTextBoxColumn
            // 
            this.custTopLengthShortDataGridViewTextBoxColumn.DataPropertyName = "custTopLengthShort";
            this.custTopLengthShortDataGridViewTextBoxColumn.HeaderText = "custTopLengthShort";
            this.custTopLengthShortDataGridViewTextBoxColumn.Name = "custTopLengthShortDataGridViewTextBoxColumn";
            // 
            // custBottomLengthDataGridViewTextBoxColumn
            // 
            this.custBottomLengthDataGridViewTextBoxColumn.DataPropertyName = "custBottomLength";
            this.custBottomLengthDataGridViewTextBoxColumn.HeaderText = "custBottomLength";
            this.custBottomLengthDataGridViewTextBoxColumn.Name = "custBottomLengthDataGridViewTextBoxColumn";
            // 
            // custSleeveLengthDataGridViewTextBoxColumn
            // 
            this.custSleeveLengthDataGridViewTextBoxColumn.DataPropertyName = "custSleeveLength";
            this.custSleeveLengthDataGridViewTextBoxColumn.HeaderText = "custSleeveLength";
            this.custSleeveLengthDataGridViewTextBoxColumn.Name = "custSleeveLengthDataGridViewTextBoxColumn";
            // 
            // custShoulderDownDataGridViewTextBoxColumn
            // 
            this.custShoulderDownDataGridViewTextBoxColumn.DataPropertyName = "custShoulderDown";
            this.custShoulderDownDataGridViewTextBoxColumn.HeaderText = "custShoulderDown";
            this.custShoulderDownDataGridViewTextBoxColumn.Name = "custShoulderDownDataGridViewTextBoxColumn";
            // 
            // custArmCircDataGridViewTextBoxColumn
            // 
            this.custArmCircDataGridViewTextBoxColumn.DataPropertyName = "custArmCirc";
            this.custArmCircDataGridViewTextBoxColumn.HeaderText = "custArmCirc";
            this.custArmCircDataGridViewTextBoxColumn.Name = "custArmCircDataGridViewTextBoxColumn";
            // 
            // custPtPDataGridViewTextBoxColumn
            // 
            this.custPtPDataGridViewTextBoxColumn.DataPropertyName = "custPtP";
            this.custPtPDataGridViewTextBoxColumn.HeaderText = "custPtP";
            this.custPtPDataGridViewTextBoxColumn.Name = "custPtPDataGridViewTextBoxColumn";
            // 
            // custSleeveOpenDataGridViewTextBoxColumn
            // 
            this.custSleeveOpenDataGridViewTextBoxColumn.DataPropertyName = "custSleeveOpen";
            this.custSleeveOpenDataGridViewTextBoxColumn.HeaderText = "custSleeveOpen";
            this.custSleeveOpenDataGridViewTextBoxColumn.Name = "custSleeveOpenDataGridViewTextBoxColumn";
            // 
            // custFullDressDataGridViewTextBoxColumn
            // 
            this.custFullDressDataGridViewTextBoxColumn.DataPropertyName = "custFullDress";
            this.custFullDressDataGridViewTextBoxColumn.HeaderText = "custFullDress";
            this.custFullDressDataGridViewTextBoxColumn.Name = "custFullDressDataGridViewTextBoxColumn";
            // 
            // custPTDataGridViewTextBoxColumn
            // 
            this.custPTDataGridViewTextBoxColumn.DataPropertyName = "custPT";
            this.custPTDataGridViewTextBoxColumn.HeaderText = "custPT";
            this.custPTDataGridViewTextBoxColumn.Name = "custPTDataGridViewTextBoxColumn";
            // 
            // custSleeveLength2DataGridViewTextBoxColumn
            // 
            this.custSleeveLength2DataGridViewTextBoxColumn.DataPropertyName = "custSleeveLength2";
            this.custSleeveLength2DataGridViewTextBoxColumn.HeaderText = "custSleeveLength2";
            this.custSleeveLength2DataGridViewTextBoxColumn.Name = "custSleeveLength2DataGridViewTextBoxColumn";
            // 
            // SenaraiPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 991);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "SenaraiPelanggan";
            this.Text = "SenaraiPelanggan";
            this.Load += new System.EventHandler(this.SenaraiPelanggan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adinasbookingdataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mukaDepanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarPelangganToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private adinasbookingdataDataSet1 adinasbookingdataDataSet1;
        private System.Windows.Forms.BindingSource custInfoBindingSource;
        private adinasbookingdataDataSet1TableAdapters.custInfoTableAdapter custInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custShoulderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custChestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custWaistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custHipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custTopLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custTopLengthShortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custBottomLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSleeveLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custShoulderDownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custArmCircDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPtPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSleeveOpenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFullDressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSleeveLength2DataGridViewTextBoxColumn;
    }
}