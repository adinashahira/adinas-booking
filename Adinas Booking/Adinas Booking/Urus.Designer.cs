namespace Adinas_Booking
{
    partial class Urus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urus));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mukaDepanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderFabricDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDesignDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTailorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orPayStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tailorPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orRemarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adinasbookingdataDataSet = new Adinas_Booking.adinasbookingdataDataSet();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tblBooking_TableAdapter = new Adinas_Booking.adinasbookingdataDataSetTableAdapters.tblBooking_TableAdapter();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxTailor = new System.Windows.Forms.ComboBox();
            this.rbtnDone = new System.Windows.Forms.RadioButton();
            this.rbtnNotDone = new System.Windows.Forms.RadioButton();
            this.rbtnNotPaid = new System.Windows.Forms.RadioButton();
            this.rbtnPaid = new System.Windows.Forms.RadioButton();
            this.daftarPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adinasbookingdataDataSet)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(2031, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mukaDepanToolStripMenuItem
            // 
            this.mukaDepanToolStripMenuItem.Name = "mukaDepanToolStripMenuItem";
            this.mukaDepanToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.mukaDepanToolStripMenuItem.Text = "Muka Depan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepPink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(770, 80, 770, 80);
            this.label1.Size = new System.Drawing.Size(2023, 204);
            this.label1.TabIndex = 18;
            this.label1.Text = "Urus Tempahan Pelanggan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orIDDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.orderFabricDataGridViewTextBoxColumn,
            this.orderDesignDataGridViewTextBoxColumn,
            this.orderCategoryDataGridViewTextBoxColumn,
            this.orderTailorDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.finishDateDataGridViewTextBoxColumn,
            this.orStatusDataGridViewTextBoxColumn,
            this.orderPriceDataGridViewTextBoxColumn,
            this.orPayStatusDataGridViewTextBoxColumn,
            this.payDateDataGridViewTextBoxColumn,
            this.tailorPriceDataGridViewTextBoxColumn,
            this.orRemarksDataGridViewTextBoxColumn,
            this.edit});
            this.dataGridView1.DataSource = this.tblBookingBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 379);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(2023, 550);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orIDDataGridViewTextBoxColumn
            // 
            this.orIDDataGridViewTextBoxColumn.DataPropertyName = "orID";
            this.orIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.orIDDataGridViewTextBoxColumn.Name = "orIDDataGridViewTextBoxColumn";
            this.orIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "custName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "Pelanggan";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            // 
            // orderFabricDataGridViewTextBoxColumn
            // 
            this.orderFabricDataGridViewTextBoxColumn.DataPropertyName = "orderFabric";
            this.orderFabricDataGridViewTextBoxColumn.HeaderText = "Jenis dan Warna Kain";
            this.orderFabricDataGridViewTextBoxColumn.Name = "orderFabricDataGridViewTextBoxColumn";
            this.orderFabricDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderDesignDataGridViewTextBoxColumn
            // 
            this.orderDesignDataGridViewTextBoxColumn.DataPropertyName = "orderDesign";
            this.orderDesignDataGridViewTextBoxColumn.HeaderText = "Jenis Baju";
            this.orderDesignDataGridViewTextBoxColumn.Name = "orderDesignDataGridViewTextBoxColumn";
            this.orderDesignDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderCategoryDataGridViewTextBoxColumn
            // 
            this.orderCategoryDataGridViewTextBoxColumn.DataPropertyName = "orderCategory";
            this.orderCategoryDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.orderCategoryDataGridViewTextBoxColumn.Name = "orderCategoryDataGridViewTextBoxColumn";
            // 
            // orderTailorDataGridViewTextBoxColumn
            // 
            this.orderTailorDataGridViewTextBoxColumn.DataPropertyName = "orderTailor";
            this.orderTailorDataGridViewTextBoxColumn.HeaderText = "Tukang Jahit";
            this.orderTailorDataGridViewTextBoxColumn.Name = "orderTailorDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Tarikh Hantar";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // finishDateDataGridViewTextBoxColumn
            // 
            this.finishDateDataGridViewTextBoxColumn.DataPropertyName = "finishDate";
            this.finishDateDataGridViewTextBoxColumn.HeaderText = "Tarikh Siap";
            this.finishDateDataGridViewTextBoxColumn.Name = "finishDateDataGridViewTextBoxColumn";
            // 
            // orStatusDataGridViewTextBoxColumn
            // 
            this.orStatusDataGridViewTextBoxColumn.DataPropertyName = "orStatus";
            this.orStatusDataGridViewTextBoxColumn.HeaderText = "Siap";
            this.orStatusDataGridViewTextBoxColumn.Name = "orStatusDataGridViewTextBoxColumn";
            this.orStatusDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderPriceDataGridViewTextBoxColumn
            // 
            this.orderPriceDataGridViewTextBoxColumn.DataPropertyName = "orderPrice";
            this.orderPriceDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.orderPriceDataGridViewTextBoxColumn.Name = "orderPriceDataGridViewTextBoxColumn";
            this.orderPriceDataGridViewTextBoxColumn.Width = 50;
            // 
            // orPayStatusDataGridViewTextBoxColumn
            // 
            this.orPayStatusDataGridViewTextBoxColumn.DataPropertyName = "orPayStatus";
            this.orPayStatusDataGridViewTextBoxColumn.HeaderText = "Bayar";
            this.orPayStatusDataGridViewTextBoxColumn.Name = "orPayStatusDataGridViewTextBoxColumn";
            this.orPayStatusDataGridViewTextBoxColumn.Width = 50;
            // 
            // payDateDataGridViewTextBoxColumn
            // 
            this.payDateDataGridViewTextBoxColumn.DataPropertyName = "payDate";
            this.payDateDataGridViewTextBoxColumn.HeaderText = "Tarikh Bayaran";
            this.payDateDataGridViewTextBoxColumn.Name = "payDateDataGridViewTextBoxColumn";
            // 
            // tailorPriceDataGridViewTextBoxColumn
            // 
            this.tailorPriceDataGridViewTextBoxColumn.DataPropertyName = "tailorPrice";
            this.tailorPriceDataGridViewTextBoxColumn.HeaderText = "Upah Jahit";
            this.tailorPriceDataGridViewTextBoxColumn.Name = "tailorPriceDataGridViewTextBoxColumn";
            this.tailorPriceDataGridViewTextBoxColumn.Width = 50;
            // 
            // orRemarksDataGridViewTextBoxColumn
            // 
            this.orRemarksDataGridViewTextBoxColumn.DataPropertyName = "orRemarks";
            this.orRemarksDataGridViewTextBoxColumn.HeaderText = "Catatan";
            this.orRemarksDataGridViewTextBoxColumn.Name = "orRemarksDataGridViewTextBoxColumn";
            this.orRemarksDataGridViewTextBoxColumn.Width = 150;
            // 
            // edit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            this.edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.edit.HeaderText = "Kemaskini";
            this.edit.Name = "edit";
            this.edit.Text = "Kemaskini";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 70;
            // 
            // tblBookingBindingSource
            // 
            this.tblBookingBindingSource.DataMember = "tblBooking$";
            this.tblBookingBindingSource.DataSource = this.adinasbookingdataDataSet;
            // 
            // adinasbookingdataDataSet
            // 
            this.adinasbookingdataDataSet.DataSetName = "adinasbookingdataDataSet";
            this.adinasbookingdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCustName
            // 
            this.txtCustName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustName.Location = new System.Drawing.Point(147, 323);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(152, 22);
            this.txtCustName.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepPink;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(342, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tblBooking_TableAdapter
            // 
            this.tblBooking_TableAdapter.ClearBeforeFill = true;
            // 
            // lblFilterType
            // 
            this.lblFilterType.AutoSize = true;
            this.lblFilterType.Location = new System.Drawing.Point(36, 323);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(76, 17);
            this.lblFilterType.TabIndex = 23;
            this.lblFilterType.Text = "Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tukang Jahit";
            // 
            // cboxTailor
            // 
            this.cboxTailor.FormattingEnabled = true;
            this.cboxTailor.Items.AddRange(new object[] {
            "CHAH",
            "JC",
            "MARDIYAH"});
            this.cboxTailor.Location = new System.Drawing.Point(147, 269);
            this.cboxTailor.Name = "cboxTailor";
            this.cboxTailor.Size = new System.Drawing.Size(152, 24);
            this.cboxTailor.TabIndex = 22;
            // 
            // rbtnDone
            // 
            this.rbtnDone.AutoSize = true;
            this.rbtnDone.Location = new System.Drawing.Point(500, 267);
            this.rbtnDone.Name = "rbtnDone";
            this.rbtnDone.Size = new System.Drawing.Size(57, 21);
            this.rbtnDone.TabIndex = 27;
            this.rbtnDone.TabStop = true;
            this.rbtnDone.Text = "Siap";
            this.rbtnDone.UseVisualStyleBackColor = true;
            // 
            // rbtnNotDone
            // 
            this.rbtnNotDone.AutoSize = true;
            this.rbtnNotDone.Location = new System.Drawing.Point(652, 267);
            this.rbtnNotDone.Name = "rbtnNotDone";
            this.rbtnNotDone.Size = new System.Drawing.Size(100, 21);
            this.rbtnNotDone.TabIndex = 28;
            this.rbtnNotDone.TabStop = true;
            this.rbtnNotDone.Text = "Belum Siap";
            this.rbtnNotDone.UseVisualStyleBackColor = true;
            // 
            // rbtnNotPaid
            // 
            this.rbtnNotPaid.AutoSize = true;
            this.rbtnNotPaid.Location = new System.Drawing.Point(652, 321);
            this.rbtnNotPaid.Name = "rbtnNotPaid";
            this.rbtnNotPaid.Size = new System.Drawing.Size(109, 21);
            this.rbtnNotPaid.TabIndex = 30;
            this.rbtnNotPaid.TabStop = true;
            this.rbtnNotPaid.Text = "Belum Bayar";
            this.rbtnNotPaid.UseVisualStyleBackColor = true;
            // 
            // rbtnPaid
            // 
            this.rbtnPaid.AutoSize = true;
            this.rbtnPaid.Location = new System.Drawing.Point(500, 321);
            this.rbtnPaid.Name = "rbtnPaid";
            this.rbtnPaid.Size = new System.Drawing.Size(66, 21);
            this.rbtnPaid.TabIndex = 29;
            this.rbtnPaid.TabStop = true;
            this.rbtnPaid.Text = "Bayar";
            this.rbtnPaid.UseVisualStyleBackColor = true;
            // 
            // daftarPelangganToolStripMenuItem
            // 
            this.daftarPelangganToolStripMenuItem.Name = "daftarPelangganToolStripMenuItem";
            this.daftarPelangganToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.daftarPelangganToolStripMenuItem.Text = "Daftar Pelanggan";
            this.daftarPelangganToolStripMenuItem.Click += new System.EventHandler(this.daftarPelangganToolStripMenuItem_Click);
            // 
            // Urus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 991);
            this.Controls.Add(this.rbtnNotPaid);
            this.Controls.Add(this.rbtnPaid);
            this.Controls.Add(this.rbtnNotDone);
            this.Controls.Add(this.rbtnDone);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblFilterType);
            this.Controls.Add(this.cboxTailor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urus";
            this.Text = "Urus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Urus_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adinasbookingdataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mukaDepanToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private adinasbookingdataDataSet adinasbookingdataDataSet;
        private System.Windows.Forms.BindingSource tblBookingBindingSource;
        private adinasbookingdataDataSetTableAdapters.tblBooking_TableAdapter tblBooking_TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxTailor;
        private System.Windows.Forms.RadioButton rbtnDone;
        private System.Windows.Forms.RadioButton rbtnNotDone;
        private System.Windows.Forms.RadioButton rbtnNotPaid;
        private System.Windows.Forms.RadioButton rbtnPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn orIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderFabricDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDesignDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTailorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orPayStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tailorPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orRemarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.ToolStripMenuItem daftarPelangganToolStripMenuItem;
    }
}