namespace SCG_Desktop
{
    partial class UserList
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
            btnDelete = new Button();
            btnBack = new Button();
            lblListHeader = new Label();
            ListReference = new ListBox();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSeaGreen;
            btnDelete.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Snow;
            btnDelete.Location = new Point(27, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkSeaGreen;
            btnBack.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Snow;
            btnBack.Location = new Point(132, 256);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(77, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Go Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblListHeader
            // 
            lblListHeader.AutoSize = true;
            lblListHeader.BackColor = Color.Snow;
            lblListHeader.Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListHeader.ForeColor = Color.DarkOliveGreen;
            lblListHeader.Location = new Point(38, 20);
            lblListHeader.Name = "lblListHeader";
            lblListHeader.Size = new Size(164, 26);
            lblListHeader.TabIndex = 4;
            lblListHeader.Text = "List of Reference";
            lblListHeader.Click += lblListHeader_Click;
            // 
            // ListReference
            // 
            ListReference.BackColor = Color.Honeydew;
            ListReference.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListReference.FormattingEnabled = true;
            ListReference.ItemHeight = 15;
            ListReference.Location = new Point(50, 69);
            ListReference.Name = "ListReference";
            ListReference.Size = new Size(139, 169);
            ListReference.TabIndex = 5;
            ListReference.SelectedIndexChanged += ListReference_SelectedIndexChanged;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(242, 317);
            Controls.Add(ListReference);
            Controls.Add(lblListHeader);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Name = "UserList";
            Text = "Reference List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDelete;
        private Button btnBack;
        private Label lblListHeader;
        private ListBox ListReference;
    }
}