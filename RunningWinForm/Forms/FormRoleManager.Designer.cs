namespace RunningWinForm
{
    partial class frmRoleManager
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
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleManager = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvRoleManager = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.colRoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.Location = new System.Drawing.Point(193, 112);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(170, 31);
            this.lblRoleName.TabIndex = 1;
            this.lblRoleName.Text = "Tên vai trò: ";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(426, 112);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(250, 38);
            this.txtRoleName.TabIndex = 3;
            // 
            // lblRoleManager
            // 
            this.lblRoleManager.AutoSize = true;
            this.lblRoleManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleManager.Location = new System.Drawing.Point(534, 24);
            this.lblRoleManager.Name = "lblRoleManager";
            this.lblRoleManager.Size = new System.Drawing.Size(465, 46);
            this.lblRoleManager.TabIndex = 0;
            this.lblRoleManager.Text = "Màn hình quản lý vai trò";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(188, 649);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(175, 57);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvRoleManager
            // 
            this.dgvRoleManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoleManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoleID,
            this.colRoleName});
            this.dgvRoleManager.Location = new System.Drawing.Point(89, 231);
            this.dgvRoleManager.Name = "dgvRoleManager";
            this.dgvRoleManager.RowHeadersWidth = 82;
            this.dgvRoleManager.RowTemplate.Height = 33;
            this.dgvRoleManager.Size = new System.Drawing.Size(1326, 354);
            this.dgvRoleManager.TabIndex = 16;
            this.dgvRoleManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoleManager_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(657, 649);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(175, 57);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1139, 649);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(175, 57);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // colRoleID
            // 
            this.colRoleID.HeaderText = "ID";
            this.colRoleID.MinimumWidth = 10;
            this.colRoleID.Name = "colRoleID";
            // 
            // colRoleName
            // 
            this.colRoleName.HeaderText = "Tên vai trò";
            this.colRoleName.MinimumWidth = 10;
            this.colRoleName.Name = "colRoleName";
            // 
            // frmRoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 752);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvRoleManager);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.lblRoleManager);
            this.Name = "frmRoleManager";
            this.Text = "Quản lý người dùng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRoleManager_FormClosed);
            this.Load += new System.EventHandler(this.frmRoleManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleManager;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvRoleManager;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleName;
    }
}