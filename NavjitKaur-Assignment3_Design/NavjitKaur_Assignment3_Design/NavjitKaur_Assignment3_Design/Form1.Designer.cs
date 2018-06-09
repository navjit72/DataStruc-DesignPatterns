namespace NavjitKaur_Assignment3_Design
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSub = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnMul = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDiv = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAdd,
            this.toolStripBtnSub,
            this.toolStripBtnMul,
            this.toolStripBtnDiv,
            this.toolStripBtnClear,
            this.toolStripBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(173, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(32, 151);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAdd
            // 
            this.toolStripBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAdd.Image")));
            this.toolStripBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAdd.Name = "toolStripBtnAdd";
            this.toolStripBtnAdd.Size = new System.Drawing.Size(29, 19);
            this.toolStripBtnAdd.Text = "+";
            this.toolStripBtnAdd.ToolTipText = "Add";
            this.toolStripBtnAdd.Click += new System.EventHandler(this.toolStripBtnAdd_Click);
            // 
            // toolStripBtnSub
            // 
            this.toolStripBtnSub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnSub.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSub.Image")));
            this.toolStripBtnSub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSub.Name = "toolStripBtnSub";
            this.toolStripBtnSub.Size = new System.Drawing.Size(29, 19);
            this.toolStripBtnSub.Text = "-";
            this.toolStripBtnSub.ToolTipText = "Subtract";
            this.toolStripBtnSub.Click += new System.EventHandler(this.toolStripBtnSub_Click);
            // 
            // toolStripBtnMul
            // 
            this.toolStripBtnMul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnMul.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMul.Image")));
            this.toolStripBtnMul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMul.Name = "toolStripBtnMul";
            this.toolStripBtnMul.Size = new System.Drawing.Size(29, 19);
            this.toolStripBtnMul.Text = "*";
            this.toolStripBtnMul.ToolTipText = "Multiply";
            this.toolStripBtnMul.Click += new System.EventHandler(this.toolStripBtnMul_Click);
            // 
            // toolStripBtnDiv
            // 
            this.toolStripBtnDiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnDiv.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDiv.Image")));
            this.toolStripBtnDiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDiv.Name = "toolStripBtnDiv";
            this.toolStripBtnDiv.Size = new System.Drawing.Size(29, 19);
            this.toolStripBtnDiv.Text = "/";
            this.toolStripBtnDiv.ToolTipText = "Divide";
            this.toolStripBtnDiv.Click += new System.EventHandler(this.toolStripBtnDiv_Click);
            // 
            // toolStripBtnClear
            // 
            this.toolStripBtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnClear.Image")));
            this.toolStripBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnClear.Name = "toolStripBtnClear";
            this.toolStripBtnClear.Size = new System.Drawing.Size(29, 19);
            this.toolStripBtnClear.Text = "C";
            this.toolStripBtnClear.ToolTipText = "Clear";
            this.toolStripBtnClear.Click += new System.EventHandler(this.toolStripBtnClear_Click);
            // 
            // toolStripBtnExit
            // 
            this.toolStripBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExit.Image")));
            this.toolStripBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExit.Name = "toolStripBtnExit";
            this.toolStripBtnExit.Size = new System.Drawing.Size(23, 19);
            this.toolStripBtnExit.Text = "X";
            this.toolStripBtnExit.ToolTipText = "Exit";
            this.toolStripBtnExit.Click += new System.EventHandler(this.toolStripBtnExit_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(24, 32);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(139, 20);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.Text = "Enter first number";
            this.txtNumber1.Enter += new System.EventHandler(this.txtNumber1_Enter);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(26, 80);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(137, 20);
            this.txtNumber2.TabIndex = 2;
            this.txtNumber2.Text = "Enter second number";
            this.txtNumber2.Enter += new System.EventHandler(this.txtNumber2_Enter);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 151);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnSub;
        private System.Windows.Forms.ToolStripButton toolStripBtnMul;
        private System.Windows.Forms.ToolStripButton toolStripBtnDiv;
        private System.Windows.Forms.ToolStripButton toolStripBtnClear;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
    }
}

