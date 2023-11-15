namespace Backup
{
    partial class frmDB
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
            this.lvDBInformation = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSchema = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label_Database = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Port = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvDBInformation
            // 
            this.lvDBInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lvDBInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader1});
            this.lvDBInformation.ForeColor = System.Drawing.Color.White;
            this.lvDBInformation.FullRowSelect = true;
            this.lvDBInformation.HideSelection = false;
            this.lvDBInformation.Location = new System.Drawing.Point(173, 12);
            this.lvDBInformation.MultiSelect = false;
            this.lvDBInformation.Name = "lvDBInformation";
            this.lvDBInformation.Size = new System.Drawing.Size(445, 273);
            this.lvDBInformation.TabIndex = 9;
            this.lvDBInformation.TabStop = false;
            this.lvDBInformation.UseCompatibleStateImageBehavior = false;
            this.lvDBInformation.View = System.Windows.Forms.View.Details;
            this.lvDBInformation.SelectedIndexChanged += new System.EventHandler(this.lvDBInformation_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IP";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Port";
            this.columnHeader7.Width = 46;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 43;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Password";
            this.columnHeader9.Width = 102;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Schema";
            this.columnHeader10.Width = 101;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSave.Location = new System.Drawing.Point(424, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnRemove.Location = new System.Drawing.Point(242, 305);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 38);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.button2.Location = new System.Drawing.Point(12, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "추가";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSchema
            // 
            this.tbSchema.Location = new System.Drawing.Point(32, 202);
            this.tbSchema.Name = "tbSchema";
            this.tbSchema.Size = new System.Drawing.Size(100, 21);
            this.tbSchema.TabIndex = 21;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(32, 162);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 21);
            this.tbPassword.TabIndex = 20;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(32, 122);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 21);
            this.tbID.TabIndex = 19;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(32, 82);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 21);
            this.tbPort.TabIndex = 18;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(32, 44);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 21);
            this.tbIP.TabIndex = 12;
            // 
            // label_Database
            // 
            this.label_Database.AutoSize = true;
            this.label_Database.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Database.Location = new System.Drawing.Point(29, 186);
            this.label_Database.Name = "label_Database";
            this.label_Database.Size = new System.Drawing.Size(59, 13);
            this.label_Database.TabIndex = 13;
            this.label_Database.Text = "Schema";
            this.label_Database.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Password.Location = new System.Drawing.Point(29, 146);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(71, 13);
            this.label_Password.TabIndex = 14;
            this.label_Password.Text = "Password";
            this.label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_ID.Location = new System.Drawing.Point(29, 106);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(19, 13);
            this.label_ID.TabIndex = 15;
            this.label_ID.Text = "ID";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Port.Location = new System.Drawing.Point(29, 68);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(32, 13);
            this.label_Port.TabIndex = 16;
            this.label_Port.Text = "Port";
            this.label_Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_IP.Location = new System.Drawing.Point(29, 28);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(19, 13);
            this.label_IP.TabIndex = 17;
            this.label_IP.Text = "IP";
            this.label_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(29, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(32, 242);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 22;
            // 
            // frmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(628, 361);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSchema);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label_Database);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvDBInformation);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmDB";
            this.Text = "frmDB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDB_FormClosing);
            this.Load += new System.EventHandler(this.frmDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDBInformation;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbSchema;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label_Database;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
    }
}