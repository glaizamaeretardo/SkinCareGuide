namespace SCG_Desktop
{
    partial class UserReference
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            lblName = new Label();
            txtName = new TextBox();
            lblSkinType = new Label();
            cmbSkinType = new ComboBox();
            lblHeader = new Label();
            listForUsers = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Info;
            btnSave.Location = new Point(97, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(175, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Enter your name:";
            lblName.Click += lblName_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Honeydew;
            txtName.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(187, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(72, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblSkinType
            // 
            lblSkinType.AutoSize = true;
            lblSkinType.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSkinType.Location = new Point(126, 167);
            lblSkinType.Name = "lblSkinType";
            lblSkinType.Size = new Size(210, 15);
            lblSkinType.TabIndex = 3;
            lblSkinType.Text = "Choose the number of your Skin Type:";
            lblSkinType.Click += lblSkinType_Click;
            // 
            // cmbSkinType
            // 
            cmbSkinType.BackColor = Color.Honeydew;
            cmbSkinType.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSkinType.FormattingEnabled = true;
            cmbSkinType.Location = new Point(170, 198);
            cmbSkinType.Name = "cmbSkinType";
            cmbSkinType.Size = new Size(106, 23);
            cmbSkinType.TabIndex = 4;
            cmbSkinType.SelectedIndexChanged += cmbSkinType_SelectedIndexChanged;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Snow;
            lblHeader.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.DarkOliveGreen;
            lblHeader.Location = new Point(116, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(218, 29);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "Skin Type Reference";
            lblHeader.Click += lblHeader_Click;
            // 
            // listForUsers
            // 
            listForUsers.BackColor = Color.MediumSeaGreen;
            listForUsers.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listForUsers.ForeColor = SystemColors.Info;
            listForUsers.Location = new Point(228, 250);
            listForUsers.Name = "listForUsers";
            listForUsers.Size = new Size(126, 34);
            listForUsers.TabIndex = 6;
            listForUsers.Text = "View List";
            listForUsers.UseVisualStyleBackColor = false;
            listForUsers.Click += listForUsers_Click;
            // 
            // UserReference
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(465, 313);
            Controls.Add(listForUsers);
            Controls.Add(lblHeader);
            Controls.Add(cmbSkinType);
            Controls.Add(lblSkinType);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            Name = "UserReference";
            Text = "User Skin Type Reference";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblName;
        private TextBox txtName;
        private Label lblSkinType;
        private ComboBox cmbSkinType;
        private Label lblHeader;
        private Button listForUsers;
    }
}
