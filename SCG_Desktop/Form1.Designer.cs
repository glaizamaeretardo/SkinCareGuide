namespace SCG_Desktop
{
    partial class UserReferenceForm
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
            txtSkinTypeNumber = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Info;
            btnSave.Location = new Point(80, 188);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(271, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(164, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Enter your name:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Honeydew;
            txtName.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(177, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(72, 23);
            txtName.TabIndex = 2;
            // 
            // lblSkinType
            // 
            lblSkinType.AutoSize = true;
            lblSkinType.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSkinType.Location = new Point(114, 114);
            lblSkinType.Name = "lblSkinType";
            lblSkinType.Size = new Size(199, 15);
            lblSkinType.TabIndex = 3;
            lblSkinType.Text = "Enter the number of your Skin Type:";
            // 
            // txtSkinTypeNumber
            // 
            txtSkinTypeNumber.BackColor = Color.Honeydew;
            txtSkinTypeNumber.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSkinTypeNumber.Location = new Point(194, 141);
            txtSkinTypeNumber.Name = "txtSkinTypeNumber";
            txtSkinTypeNumber.Size = new Size(39, 23);
            txtSkinTypeNumber.TabIndex = 4;
            // 
            // UserReferenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(441, 257);
            Controls.Add(txtSkinTypeNumber);
            Controls.Add(lblSkinType);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            Name = "UserReferenceForm";
            Text = "User Skin Type Reference";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblName;
        private TextBox txtName;
        private Label lblSkinType;
        private TextBox txtSkinTypeNumber;
    }
}
