namespace capstoneproject
{
    partial class Users
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
            this.usersdgv = new System.Windows.Forms.DataGridView();
            this.tblloginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginformDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginformDataSet = new capstoneproject.loginformDataSet();
            this.addbtn = new System.Windows.Forms.Button();
            this.tblloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_loginTableAdapter = new capstoneproject.loginformDataSetTableAdapters.tbl_loginTableAdapter();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersdgv
            // 
            this.usersdgv.AllowUserToAddRows = false;
            this.usersdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersdgv.AutoGenerateColumns = false;
            this.usersdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.usernameDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.usersdgv.DataSource = this.tblloginBindingSource1;
            this.usersdgv.Location = new System.Drawing.Point(12, 52);
            this.usersdgv.Name = "usersdgv";
            this.usersdgv.RowTemplate.Height = 100;
            this.usersdgv.Size = new System.Drawing.Size(649, 504);
            this.usersdgv.TabIndex = 0;
            this.usersdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersdgv_CellContentClick);
            // 
            // tblloginBindingSource1
            // 
            this.tblloginBindingSource1.DataMember = "tbl_login";
            this.tblloginBindingSource1.DataSource = this.loginformDataSetBindingSource;
            // 
            // loginformDataSetBindingSource
            // 
            this.loginformDataSetBindingSource.DataSource = this.loginformDataSet;
            this.loginformDataSetBindingSource.Position = 0;
            // 
            // loginformDataSet
            // 
            this.loginformDataSet.DataSetName = "loginformDataSet";
            this.loginformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(335, 514);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // tblloginBindingSource
            // 
            this.tblloginBindingSource.DataMember = "tbl_login";
            this.tblloginBindingSource.DataSource = this.loginformDataSetBindingSource;
            // 
            // tbl_loginTableAdapter
            // 
            this.tbl_loginTableAdapter.ClearBeforeFill = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(562, 514);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(448, 514);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 101;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 101;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 101;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 101;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 101;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::capstoneproject.Properties.Resources._99425148_2402006923430298_415144967531397120_n;
            this.ClientSize = new System.Drawing.Size(960, 579);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.usersdgv);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersdgv;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.BindingSource loginformDataSetBindingSource;
        private loginformDataSet loginformDataSet;
        private System.Windows.Forms.BindingSource tblloginBindingSource;
        private loginformDataSetTableAdapters.tbl_loginTableAdapter tbl_loginTableAdapter;
        private System.Windows.Forms.BindingSource tblloginBindingSource1;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
    }
}