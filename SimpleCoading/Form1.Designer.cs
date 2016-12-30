namespace SimpleCoading
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.plnMulitipy = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.pnlColore = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.lblText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.letsChangeColorsInTheBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letsMultiplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.plnMulitipy.SuspendLayout();
            this.pnlColore.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.plnMulitipy);
            this.panel1.Controls.Add(this.pnlColore);
            this.panel1.Location = new System.Drawing.Point(20, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 542);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(306, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select from the menu";
            // 
            // plnMulitipy
            // 
            this.plnMulitipy.Controls.Add(this.label4);
            this.plnMulitipy.Controls.Add(this.lblAns);
            this.plnMulitipy.Controls.Add(this.btnCalculate);
            this.plnMulitipy.Controls.Add(this.txtN2);
            this.plnMulitipy.Controls.Add(this.txtN1);
            this.plnMulitipy.Location = new System.Drawing.Point(438, 85);
            this.plnMulitipy.Name = "plnMulitipy";
            this.plnMulitipy.Size = new System.Drawing.Size(350, 435);
            this.plnMulitipy.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(152, 165);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(46, 17);
            this.lblAns.TabIndex = 3;
            this.lblAns.Text = "label4";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(135, 95);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 29);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(226, 40);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(57, 22);
            this.txtN2.TabIndex = 1;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(70, 40);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(57, 22);
            this.txtN1.TabIndex = 0;
            // 
            // pnlColore
            // 
            this.pnlColore.Controls.Add(this.btnChange);
            this.pnlColore.Controls.Add(this.cmbColores);
            this.pnlColore.Controls.Add(this.lblText);
            this.pnlColore.Controls.Add(this.label3);
            this.pnlColore.Controls.Add(this.label2);
            this.pnlColore.Controls.Add(this.btnCopy);
            this.pnlColore.Controls.Add(this.txtWords);
            this.pnlColore.Location = new System.Drawing.Point(35, 85);
            this.pnlColore.Name = "pnlColore";
            this.pnlColore.Size = new System.Drawing.Size(350, 435);
            this.pnlColore.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(103, 340);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(99, 37);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Black"});
            this.cmbColores.Location = new System.Drawing.Point(159, 267);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(121, 24);
            this.cmbColores.TabIndex = 5;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(156, 215);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(46, 17);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Colore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Text";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(87, 89);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(134, 35);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy Your words";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(42, 40);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(241, 22);
            this.txtWords.TabIndex = 0;
            // 
            // letsChangeColorsInTheBoxToolStripMenuItem
            // 
            this.letsChangeColorsInTheBoxToolStripMenuItem.Name = "letsChangeColorsInTheBoxToolStripMenuItem";
            this.letsChangeColorsInTheBoxToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.letsChangeColorsInTheBoxToolStripMenuItem.Text = "Lets Change Colors in the Box";
            this.letsChangeColorsInTheBoxToolStripMenuItem.Click += new System.EventHandler(this.letsChangeColorsInTheBoxToolStripMenuItem_Click);
            // 
            // letsMultiplyToolStripMenuItem
            // 
            this.letsMultiplyToolStripMenuItem.Name = "letsMultiplyToolStripMenuItem";
            this.letsMultiplyToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.letsMultiplyToolStripMenuItem.Text = "Lets Multiply";
            this.letsMultiplyToolStripMenuItem.Click += new System.EventHandler(this.letsMultiplyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letsChangeColorsInTheBoxToolStripMenuItem,
            this.letsMultiplyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Coding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.plnMulitipy.ResumeLayout(false);
            this.plnMulitipy.PerformLayout();
            this.pnlColore.ResumeLayout(false);
            this.pnlColore.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plnMulitipy;
        private System.Windows.Forms.Panel pnlColore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.ToolStripMenuItem letsChangeColorsInTheBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letsMultiplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

