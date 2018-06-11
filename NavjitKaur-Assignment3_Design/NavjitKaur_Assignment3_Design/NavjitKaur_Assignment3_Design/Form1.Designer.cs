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
            this.toolStripBtnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.radioBtnAdd = new System.Windows.Forms.RadioButton();
            this.radioBtnSub = new System.Windows.Forms.RadioButton();
            this.radioBtnMul = new System.Windows.Forms.RadioButton();
            this.radioBtnDiv = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnClear,
            this.toolStripBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(423, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 256);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnClear
            // 
            this.toolStripBtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnClear.Image")));
            this.toolStripBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnClear.Name = "toolStripBtnClear";
            this.toolStripBtnClear.Size = new System.Drawing.Size(21, 19);
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
            this.toolStripBtnExit.Size = new System.Drawing.Size(21, 19);
            this.toolStripBtnExit.Text = "X";
            this.toolStripBtnExit.ToolTipText = "Exit";
            this.toolStripBtnExit.Click += new System.EventHandler(this.toolStripBtnExit_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(60, 37);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(139, 20);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.Text = "Enter first number";
            this.txtNumber1.Enter += new System.EventHandler(this.txtNumber1_Enter);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(62, 85);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(137, 20);
            this.txtNumber2.TabIndex = 2;
            this.txtNumber2.Text = "Enter second number";
            this.txtNumber2.Enter += new System.EventHandler(this.txtNumber2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(62, 120);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(81, 19);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // radioBtnAdd
            // 
            this.radioBtnAdd.AutoSize = true;
            this.radioBtnAdd.Location = new System.Drawing.Point(38, 35);
            this.radioBtnAdd.Name = "radioBtnAdd";
            this.radioBtnAdd.Size = new System.Drawing.Size(44, 17);
            this.radioBtnAdd.TabIndex = 9;
            this.radioBtnAdd.TabStop = true;
            this.radioBtnAdd.Text = "Add";
            this.radioBtnAdd.UseVisualStyleBackColor = true;
            // 
            // radioBtnSub
            // 
            this.radioBtnSub.AutoSize = true;
            this.radioBtnSub.Location = new System.Drawing.Point(38, 71);
            this.radioBtnSub.Name = "radioBtnSub";
            this.radioBtnSub.Size = new System.Drawing.Size(65, 17);
            this.radioBtnSub.TabIndex = 10;
            this.radioBtnSub.TabStop = true;
            this.radioBtnSub.Text = "Subtract";
            this.radioBtnSub.UseVisualStyleBackColor = true;
            // 
            // radioBtnMul
            // 
            this.radioBtnMul.AutoSize = true;
            this.radioBtnMul.Location = new System.Drawing.Point(38, 110);
            this.radioBtnMul.Name = "radioBtnMul";
            this.radioBtnMul.Size = new System.Drawing.Size(60, 17);
            this.radioBtnMul.TabIndex = 11;
            this.radioBtnMul.TabStop = true;
            this.radioBtnMul.Text = "Multiply";
            this.radioBtnMul.UseVisualStyleBackColor = true;
            // 
            // radioBtnDiv
            // 
            this.radioBtnDiv.AutoSize = true;
            this.radioBtnDiv.Location = new System.Drawing.Point(38, 144);
            this.radioBtnDiv.Name = "radioBtnDiv";
            this.radioBtnDiv.Size = new System.Drawing.Size(55, 17);
            this.radioBtnDiv.TabIndex = 12;
            this.radioBtnDiv.TabStop = true;
            this.radioBtnDiv.Text = "Divide";
            this.radioBtnDiv.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioBtnDiv);
            this.groupBox.Controls.Add(this.radioBtnAdd);
            this.groupBox.Controls.Add(this.radioBtnSub);
            this.groupBox.Controls.Add(this.radioBtnMul);
            this.groupBox.Location = new System.Drawing.Point(237, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(142, 197);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Operations";
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 256);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnClear;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton radioBtnAdd;
        private System.Windows.Forms.RadioButton radioBtnSub;
        private System.Windows.Forms.RadioButton radioBtnMul;
        private System.Windows.Forms.RadioButton radioBtnDiv;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

