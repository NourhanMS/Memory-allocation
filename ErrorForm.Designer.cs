namespace contiguous_memory_allocation
{
    partial class ErrorForm
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
            this.txtError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(212, 119);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(268, 65);
            this.txtError.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(284, 54);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(64, 25);
            this.Error.TabIndex = 3;
            this.Error.Text = "Error";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.DarkRed;
            this.ok.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(546, 190);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 59);
            this.ok.TabIndex = 21;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 261);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Error);
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button ok;
    }
}