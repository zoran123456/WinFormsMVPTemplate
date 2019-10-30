namespace WinFormsMVPTemplate
{
    partial class MainForm
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
            this.lblTextLabel = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnChangeCase = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextLabel
            // 
            this.lblTextLabel.AutoSize = true;
            this.lblTextLabel.Location = new System.Drawing.Point(30, 38);
            this.lblTextLabel.Name = "lblTextLabel";
            this.lblTextLabel.Size = new System.Drawing.Size(64, 14);
            this.lblTextLabel.TabIndex = 0;
            this.lblTextLabel.Text = "Your name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(33, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 22);
            this.tbName.TabIndex = 1;
            // 
            // btnChangeCase
            // 
            this.btnChangeCase.Location = new System.Drawing.Point(33, 104);
            this.btnChangeCase.Name = "btnChangeCase";
            this.btnChangeCase.Size = new System.Drawing.Size(100, 25);
            this.btnChangeCase.TabIndex = 2;
            this.btnChangeCase.Text = "Change Case";
            this.btnChangeCase.UseVisualStyleBackColor = true;
            this.btnChangeCase.Click += new System.EventHandler(this.btnChangeCase_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(233, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 227);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangeCase);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblTextLabel);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextLabel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnChangeCase;
        private System.Windows.Forms.Button btnSave;
    }
}

