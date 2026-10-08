namespace whatever
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.sporočilnoOknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osnovnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zNapisomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zDvemaGumbomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTremiGumbiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zIkonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dialohToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sporočilnoOknoToolStripMenuItem
            // 
            this.sporočilnoOknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osnovnoToolStripMenuItem,
            this.zNapisomToolStripMenuItem,
            this.zDvemaGumbomaToolStripMenuItem,
            this.sTremiGumbiToolStripMenuItem,
            this.zIkonoToolStripMenuItem});
            this.sporočilnoOknoToolStripMenuItem.Name = "sporočilnoOknoToolStripMenuItem";
            this.sporočilnoOknoToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.sporočilnoOknoToolStripMenuItem.Text = "Sporočilno okno";
            this.sporočilnoOknoToolStripMenuItem.Click += new System.EventHandler(this.sporočilnoOknoToolStripMenuItem_Click);
            // 
            // osnovnoToolStripMenuItem
            // 
            this.osnovnoToolStripMenuItem.Name = "osnovnoToolStripMenuItem";
            this.osnovnoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.osnovnoToolStripMenuItem.Text = "Osnovno";
            // 
            // zNapisomToolStripMenuItem
            // 
            this.zNapisomToolStripMenuItem.Name = "zNapisomToolStripMenuItem";
            this.zNapisomToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.zNapisomToolStripMenuItem.Text = "Z napisom";
            this.zNapisomToolStripMenuItem.Click += new System.EventHandler(this.zNapisomToolStripMenuItem_Click);
            // 
            // zDvemaGumbomaToolStripMenuItem
            // 
            this.zDvemaGumbomaToolStripMenuItem.Name = "zDvemaGumbomaToolStripMenuItem";
            this.zDvemaGumbomaToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.zDvemaGumbomaToolStripMenuItem.Text = "z dvema gumboma";
            this.zDvemaGumbomaToolStripMenuItem.Click += new System.EventHandler(this.zDvemaGumbomaToolStripMenuItem_Click);
            // 
            // sTremiGumbiToolStripMenuItem
            // 
            this.sTremiGumbiToolStripMenuItem.Name = "sTremiGumbiToolStripMenuItem";
            this.sTremiGumbiToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.sTremiGumbiToolStripMenuItem.Text = "s tremi gumbi";
            this.sTremiGumbiToolStripMenuItem.Click += new System.EventHandler(this.sTremiGumbiToolStripMenuItem_Click);
            // 
            // zIkonoToolStripMenuItem
            // 
            this.zIkonoToolStripMenuItem.Name = "zIkonoToolStripMenuItem";
            this.zIkonoToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.zIkonoToolStripMenuItem.Text = "z ikono";
            this.zIkonoToolStripMenuItem.Click += new System.EventHandler(this.zIkonoToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sporočilnoOknoToolStripMenuItem,
            this.dialohToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dialohToolStripMenuItem
            // 
            this.dialohToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dialogToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.dialohToolStripMenuItem.Name = "dialohToolStripMenuItem";
            this.dialohToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.dialohToolStripMenuItem.Text = "dialoh";
            // 
            // dialogToolStripMenuItem
            // 
            this.dialogToolStripMenuItem.Name = "dialogToolStripMenuItem";
            this.dialogToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dialogToolStripMenuItem.Text = "dialog";
            this.dialogToolStripMenuItem.Click += new System.EventHandler(this.dialogToolStripMenuItem_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontToolStripMenuItem.Text = "font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 196);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 118);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Kako lahko devetnajstici odvzamemo 1, \r\nDa dobimo 20\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem sporočilnoOknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osnovnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zNapisomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zDvemaGumbomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTremiGumbiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zIkonoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dialohToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

