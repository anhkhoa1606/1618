namespace asm2_1618
{
    partial class HeThong
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
            this.Floor = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.Typeroom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Hethongbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Maphong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.SystemDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SystemDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Floor
            // 
            this.Floor.Location = new System.Drawing.Point(615, 115);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(100, 22);
            this.Floor.TabIndex = 16;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(615, 172);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 22);
            this.price.TabIndex = 15;
            // 
            // Typeroom
            // 
            this.Typeroom.Location = new System.Drawing.Point(212, 169);
            this.Typeroom.Name = "Typeroom";
            this.Typeroom.Size = new System.Drawing.Size(100, 22);
            this.Typeroom.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(506, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Giá tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tầng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Loại phòng";
            // 
            // Hethongbtn
            // 
            this.Hethongbtn.Location = new System.Drawing.Point(12, 12);
            this.Hethongbtn.Name = "Hethongbtn";
            this.Hethongbtn.Size = new System.Drawing.Size(129, 30);
            this.Hethongbtn.TabIndex = 34;
            this.Hethongbtn.Text = "Phiếu Đặt Phòng";
            this.Hethongbtn.UseVisualStyleBackColor = true;
            this.Hethongbtn.Click += new System.EventHandler(this.Hethongbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Hệ thống";
            // 
            // Maphong
            // 
            this.Maphong.Location = new System.Drawing.Point(212, 115);
            this.Maphong.Name = "Maphong";
            this.Maphong.Size = new System.Drawing.Size(100, 22);
            this.Maphong.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Mã phòng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(178, 241);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // SystemDGV
            // 
            this.SystemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SystemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SystemDGV.Location = new System.Drawing.Point(12, 300);
            this.SystemDGV.Name = "SystemDGV";
            this.SystemDGV.ReadOnly = true;
            this.SystemDGV.RowHeadersWidth = 51;
            this.SystemDGV.RowTemplate.Height = 24;
            this.SystemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SystemDGV.Size = new System.Drawing.Size(844, 189);
            this.SystemDGV.TabIndex = 40;
            this.SystemDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SystemDGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(450, 241);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Reset";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(581, 241);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 501);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SystemDGV);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.Maphong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hethongbtn);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.price);
            this.Controls.Add(this.Typeroom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "HeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeThong";
            this.Load += new System.EventHandler(this.HeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SystemDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Floor;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox Typeroom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Hethongbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Maphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView SystemDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}