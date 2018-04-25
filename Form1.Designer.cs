namespace contiguous_memory_allocation
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.holeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.processID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deallocate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReAllocate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.apply = new System.Windows.Forms.Button();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.lblHoles = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.txtHoles = new System.Windows.Forms.TextBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.chkFirstFit = new System.Windows.Forms.RadioButton();
            this.chkBestFit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemorySize = new System.Windows.Forms.TextBox();
            this.btnDeallocate = new System.Windows.Forms.Button();
            this.btnReallocate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.holeSize,
            this.startingAddress});
            this.dataGridView1.Location = new System.Drawing.Point(50, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(224, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // holeSize
            // 
            this.holeSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.holeSize.HeaderText = "Hole-Size";
            this.holeSize.Name = "holeSize";
            // 
            // startingAddress
            // 
            this.startingAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startingAddress.HeaderText = "Starting-Address";
            this.startingAddress.Name = "startingAddress";
            this.startingAddress.Width = 109;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processID,
            this.formSize,
            this.formState,
            this.Deallocate,
            this.ReAllocate});
            this.dataGridView2.Location = new System.Drawing.Point(377, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(515, 260);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // processID
            // 
            this.processID.HeaderText = "processID";
            this.processID.Name = "processID";
            // 
            // formSize
            // 
            this.formSize.HeaderText = "Size";
            this.formSize.Name = "formSize";
            // 
            // formState
            // 
            this.formState.HeaderText = "State";
            this.formState.Name = "formState";
            // 
            // Deallocate
            // 
            this.Deallocate.DataPropertyName = "Deallocate";
            this.Deallocate.HeaderText = "Deallocate";
            this.Deallocate.Name = "Deallocate";
            this.Deallocate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Deallocate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ReAllocate
            // 
            this.ReAllocate.HeaderText = "Re-Allocate";
            this.ReAllocate.Name = "ReAllocate";
            this.ReAllocate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReAllocate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.Maroon;
            this.apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.ForeColor = System.Drawing.Color.Black;
            this.apply.Location = new System.Drawing.Point(89, 397);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(151, 60);
            this.apply.TabIndex = 2;
            this.apply.Text = "APPLY";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAllocate
            // 
            this.btnAllocate.BackColor = System.Drawing.Color.DarkRed;
            this.btnAllocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocate.Location = new System.Drawing.Point(377, 397);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(151, 60);
            this.btnAllocate.TabIndex = 3;
            this.btnAllocate.Text = "ALLOCATE";
            this.btnAllocate.UseVisualStyleBackColor = false;
            this.btnAllocate.Click += new System.EventHandler(this.button2_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Maroon;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(1126, 548);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(151, 57);
            this.reset.TabIndex = 4;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // lblHoles
            // 
            this.lblHoles.AutoSize = true;
            this.lblHoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoles.Location = new System.Drawing.Point(973, 95);
            this.lblHoles.Name = "lblHoles";
            this.lblHoles.Size = new System.Drawing.Size(113, 15);
            this.lblHoles.TabIndex = 5;
            this.lblHoles.Text = "Number of holes";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(1136, 95);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(141, 15);
            this.lblProcess.TabIndex = 7;
            this.lblProcess.Text = "number of processes";
            // 
            // txtHoles
            // 
            this.txtHoles.Location = new System.Drawing.Point(976, 163);
            this.txtHoles.Multiline = true;
            this.txtHoles.Name = "txtHoles";
            this.txtHoles.Size = new System.Drawing.Size(74, 38);
            this.txtHoles.TabIndex = 8;
            this.txtHoles.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(1139, 163);
            this.txtProcess.Multiline = true;
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(74, 38);
            this.txtProcess.TabIndex = 9;
            this.txtProcess.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // chkFirstFit
            // 
            this.chkFirstFit.AutoSize = true;
            this.chkFirstFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFirstFit.Location = new System.Drawing.Point(976, 397);
            this.chkFirstFit.Name = "chkFirstFit";
            this.chkFirstFit.Size = new System.Drawing.Size(88, 19);
            this.chkFirstFit.TabIndex = 10;
            this.chkFirstFit.TabStop = true;
            this.chkFirstFit.Text = "FIRST FIT";
            this.chkFirstFit.UseVisualStyleBackColor = true;
            this.chkFirstFit.CheckedChanged += new System.EventHandler(this.chkFirstFit_CheckedChanged);
            // 
            // chkBestFit
            // 
            this.chkBestFit.AutoSize = true;
            this.chkBestFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBestFit.Location = new System.Drawing.Point(976, 440);
            this.chkBestFit.Name = "chkBestFit";
            this.chkBestFit.Size = new System.Drawing.Size(80, 17);
            this.chkBestFit.TabIndex = 11;
            this.chkBestFit.TabStop = true;
            this.chkBestFit.Text = "BEST FIT";
            this.chkBestFit.UseVisualStyleBackColor = true;
            this.chkBestFit.CheckedChanged += new System.EventHandler(this.chkBestFit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1136, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Memory size";
            // 
            // txtMemorySize
            // 
            this.txtMemorySize.Location = new System.Drawing.Point(1139, 309);
            this.txtMemorySize.Multiline = true;
            this.txtMemorySize.Name = "txtMemorySize";
            this.txtMemorySize.Size = new System.Drawing.Size(72, 38);
            this.txtMemorySize.TabIndex = 15;
            this.txtMemorySize.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnDeallocate
            // 
            this.btnDeallocate.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeallocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeallocate.Location = new System.Drawing.Point(573, 397);
            this.btnDeallocate.Name = "btnDeallocate";
            this.btnDeallocate.Size = new System.Drawing.Size(151, 60);
            this.btnDeallocate.TabIndex = 18;
            this.btnDeallocate.Text = "DE_ALLOCATE";
            this.btnDeallocate.UseVisualStyleBackColor = false;
            this.btnDeallocate.Click += new System.EventHandler(this.btnDeallocate_Click);
            // 
            // btnReallocate
            // 
            this.btnReallocate.BackColor = System.Drawing.Color.DarkRed;
            this.btnReallocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReallocate.Location = new System.Drawing.Point(753, 397);
            this.btnReallocate.Name = "btnReallocate";
            this.btnReallocate.Size = new System.Drawing.Size(151, 60);
            this.btnReallocate.TabIndex = 19;
            this.btnReallocate.Text = "RE_ALLOCATE";
            this.btnReallocate.UseVisualStyleBackColor = false;
            this.btnReallocate.Click += new System.EventHandler(this.btnReallocate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1301, 749);
            this.Controls.Add(this.btnReallocate);
            this.Controls.Add(this.btnDeallocate);
            this.Controls.Add(this.txtMemorySize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBestFit);
            this.Controls.Add(this.chkFirstFit);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.txtHoles);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lblHoles);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "contigous-memory-allocation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn holeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingAddress;
        private System.Windows.Forms.Label lblHoles;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.TextBox txtHoles;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.RadioButton chkFirstFit;
        private System.Windows.Forms.RadioButton chkBestFit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemorySize;
        private System.Windows.Forms.Button btnDeallocate;
        private System.Windows.Forms.Button btnReallocate;
        private System.Windows.Forms.DataGridViewTextBoxColumn processID;
        private System.Windows.Forms.DataGridViewTextBoxColumn formSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn formState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deallocate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ReAllocate;
    }
}

