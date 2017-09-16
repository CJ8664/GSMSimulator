namespace GSM
{
    partial class ControlPanel
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
            this.AddUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.AddCell = new System.Windows.Forms.Button();
            this.DeleteCell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(28, 12);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(228, 35);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Add User";
            this.AddUser.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(28, 62);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(228, 42);
            this.DeleteUser.TabIndex = 1;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = true;
            // 
            // AddCell
            // 
            this.AddCell.Location = new System.Drawing.Point(28, 120);
            this.AddCell.Name = "AddCell";
            this.AddCell.Size = new System.Drawing.Size(228, 41);
            this.AddCell.TabIndex = 2;
            this.AddCell.Text = "Add Cell";
            this.AddCell.UseVisualStyleBackColor = true;
            // 
            // DeleteCell
            // 
            this.DeleteCell.Location = new System.Drawing.Point(28, 177);
            this.DeleteCell.Name = "DeleteCell";
            this.DeleteCell.Size = new System.Drawing.Size(228, 42);
            this.DeleteCell.TabIndex = 3;
            this.DeleteCell.Text = "Delete Cell";
            this.DeleteCell.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.DeleteCell);
            this.Controls.Add(this.AddCell);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.AddUser);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button AddCell;
        private System.Windows.Forms.Button DeleteCell;
    }
}