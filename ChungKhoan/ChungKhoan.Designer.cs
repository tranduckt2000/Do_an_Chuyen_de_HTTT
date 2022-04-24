
namespace ChungKhoan
{
    partial class FormGiaoDich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoDich));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lenhDatGridControl = new DevExpress.XtraGrid.GridControl();
            this.lenhDatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chungKhoanDataSet = new ChungKhoan.ChungKhoanDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiGiaoDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiLenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lenhDatTableAdapter = new ChungKhoan.ChungKhoanDataSetTableAdapters.LenhDatTableAdapter();
            this.tableAdapterManager = new ChungKhoan.ChungKhoanDataSetTableAdapters.TableAdapterManager();
            this.txtMaCoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiGiaoDich = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtGiaDat = new DevExpress.XtraEditors.SpinEdit();
            this.btnGiaoDich = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungKhoanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCoPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lenhDatGridControl);
            this.panel1.Location = new System.Drawing.Point(12, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 288);
            this.panel1.TabIndex = 0;
            // 
            // lenhDatGridControl
            // 
            this.lenhDatGridControl.DataSource = this.lenhDatBindingSource;
            this.lenhDatGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lenhDatGridControl.Location = new System.Drawing.Point(0, 0);
            this.lenhDatGridControl.MainView = this.gridView1;
            this.lenhDatGridControl.Name = "lenhDatGridControl";
            this.lenhDatGridControl.Size = new System.Drawing.Size(841, 288);
            this.lenhDatGridControl.TabIndex = 0;
            this.lenhDatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lenhDatBindingSource
            // 
            this.lenhDatBindingSource.DataMember = "LenhDat";
            this.lenhDatBindingSource.DataSource = this.chungKhoanDataSet;
            // 
            // chungKhoanDataSet
            // 
            this.chungKhoanDataSet.DataSetName = "ChungKhoanDataSet";
            this.chungKhoanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colMaCoPhieu,
            this.colNgayDat,
            this.colLoaiGiaoDich,
            this.colLoaiLenh,
            this.colSoLuong,
            this.colGiaDat,
            this.colTrangThai});
            this.gridView1.GridControl = this.lenhDatGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colMaCoPhieu
            // 
            this.colMaCoPhieu.FieldName = "MaCoPhieu";
            this.colMaCoPhieu.Name = "colMaCoPhieu";
            this.colMaCoPhieu.Visible = true;
            this.colMaCoPhieu.VisibleIndex = 1;
            // 
            // colNgayDat
            // 
            this.colNgayDat.FieldName = "NgayDat";
            this.colNgayDat.Name = "colNgayDat";
            this.colNgayDat.Visible = true;
            this.colNgayDat.VisibleIndex = 2;
            // 
            // colLoaiGiaoDich
            // 
            this.colLoaiGiaoDich.FieldName = "LoaiGiaoDich";
            this.colLoaiGiaoDich.Name = "colLoaiGiaoDich";
            this.colLoaiGiaoDich.Visible = true;
            this.colLoaiGiaoDich.VisibleIndex = 3;
            // 
            // colLoaiLenh
            // 
            this.colLoaiLenh.FieldName = "LoaiLenh";
            this.colLoaiLenh.Name = "colLoaiLenh";
            this.colLoaiLenh.Visible = true;
            this.colLoaiLenh.VisibleIndex = 4;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 5;
            // 
            // colGiaDat
            // 
            this.colGiaDat.FieldName = "GiaDat";
            this.colGiaDat.Name = "colGiaDat";
            this.colGiaDat.Visible = true;
            this.colGiaDat.VisibleIndex = 6;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 7;
            // 
            // lenhDatTableAdapter
            // 
            this.lenhDatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LenhDatTableAdapter = this.lenhDatTableAdapter;
            this.tableAdapterManager.LenhKhopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ChungKhoan.ChungKhoanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMaCoPhieu
            // 
            this.txtMaCoPhieu.Location = new System.Drawing.Point(130, 39);
            this.txtMaCoPhieu.Name = "txtMaCoPhieu";
            this.txtMaCoPhieu.Size = new System.Drawing.Size(100, 20);
            this.txtMaCoPhieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Cổ Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Giao Dịch";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá Đặt";
            // 
            // cbLoaiGiaoDich
            // 
            this.cbLoaiGiaoDich.AllowDrop = true;
            this.cbLoaiGiaoDich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiGiaoDich.FormattingEnabled = true;
            this.cbLoaiGiaoDich.Items.AddRange(new object[] {
            "B",
            "M"});
            this.cbLoaiGiaoDich.Location = new System.Drawing.Point(130, 105);
            this.cbLoaiGiaoDich.Name = "cbLoaiGiaoDich";
            this.cbLoaiGiaoDich.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbLoaiGiaoDich.Size = new System.Drawing.Size(52, 21);
            this.cbLoaiGiaoDich.TabIndex = 6;
            this.cbLoaiGiaoDich.SelectedIndexChanged += new System.EventHandler(this.cbLoaiGiaoDich_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(130, 164);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 7;
            // 
            // txtGiaDat
            // 
            this.txtGiaDat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGiaDat.Location = new System.Drawing.Point(130, 236);
            this.txtGiaDat.Name = "txtGiaDat";
            this.txtGiaDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiaDat.Size = new System.Drawing.Size(100, 20);
            this.txtGiaDat.TabIndex = 8;
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.BackColor = System.Drawing.Color.Turquoise;
            this.btnGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoDich.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnGiaoDich.ForeColor = System.Drawing.Color.DimGray;
            this.btnGiaoDich.Location = new System.Drawing.Point(330, 57);
            this.btnGiaoDich.Name = "btnGiaoDich";
            this.btnGiaoDich.Size = new System.Drawing.Size(128, 61);
            this.btnGiaoDich.TabIndex = 9;
            this.btnGiaoDich.Text = "Đặt Lệnh";
            this.btnGiaoDich.UseVisualStyleBackColor = false;
            this.btnGiaoDich.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(330, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 58);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGiaoDich);
            this.Controls.Add(this.txtGiaDat);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cbLoaiGiaoDich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaCoPhieu);
            this.Controls.Add(this.panel1);
            this.Name = "FormGiaoDich";
            this.Text = "Giao dịch chứng khoán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungKhoanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCoPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ChungKhoanDataSet chungKhoanDataSet;
        private System.Windows.Forms.BindingSource lenhDatBindingSource;
        private ChungKhoanDataSetTableAdapters.LenhDatTableAdapter lenhDatTableAdapter;
        private ChungKhoanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lenhDatGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDat;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiGiaoDich;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiLenh;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaDat;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraEditors.TextEdit txtMaCoPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiGiaoDich;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraEditors.SpinEdit txtGiaDat;
        private System.Windows.Forms.Button btnGiaoDich;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

