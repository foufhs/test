namespace UI
{
    partial class EditPersonForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.okEditButton = new System.Windows.Forms.Button();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // surnameBox
            // 
            this.surnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.surnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameBox.Location = new System.Drawing.Point(201, 281);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(328, 33);
            this.surnameBox.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Location = new System.Drawing.Point(201, 172);
            this.nameBox.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(330, 26);
            this.nameBox.TabIndex = 6;
            // 
            // okEditButton
            // 
            this.okEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(50)))));
            this.okEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.okEditButton.Location = new System.Drawing.Point(162, 439);
            this.okEditButton.Margin = new System.Windows.Forms.Padding(6);
            this.okEditButton.Name = "okEditButton";
            this.okEditButton.Size = new System.Drawing.Size(180, 44);
            this.okEditButton.TabIndex = 10;
            this.okEditButton.Text = "OK";
            this.okEditButton.UseVisualStyleBackColor = false;
            this.okEditButton.Click += new System.EventHandler(this.okEditButton_Click);
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(50)))));
            this.cancelEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.cancelEditButton.Location = new System.Drawing.Point(389, 439);
            this.cancelEditButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(180, 44);
            this.cancelEditButton.TabIndex = 11;
            this.cancelEditButton.Text = "Cancel";
            this.cancelEditButton.UseVisualStyleBackColor = false;
            this.cancelEditButton.Click += new System.EventHandler(this.cancelEditButton_Click);
            // 
            // EditPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(716, 568);
            this.Controls.Add(this.cancelEditButton);
            this.Controls.Add(this.okEditButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditPersonForm";
            this.Text = "EditPersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button okEditButton;
        private System.Windows.Forms.Button cancelEditButton;
    }
}