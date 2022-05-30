
namespace CalculadoraConMenu_32_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dividirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
          
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.programaToolStripMenuItem.Text = "Programa";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumarToolStripMenuItem,
            this.restarToolStripMenuItem,
            this.multiplicarToolStripMenuItem,
            this.dividirToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumarToolStripMenuItem
            // 
            this.sumarToolStripMenuItem.Name = "sumarToolStripMenuItem";
            this.sumarToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.sumarToolStripMenuItem.Text = "Sumar";
            this.sumarToolStripMenuItem.Click += new System.EventHandler(this.sumarToolStripMenuItem_Click);
            // 
            // restarToolStripMenuItem
            // 
            this.restarToolStripMenuItem.Name = "restarToolStripMenuItem";
            this.restarToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.restarToolStripMenuItem.Text = "Restar";
            this.restarToolStripMenuItem.Click += new System.EventHandler(this.restarToolStripMenuItem_Click);
            // 
            // multiplicarToolStripMenuItem
            // 
            this.multiplicarToolStripMenuItem.Name = "multiplicarToolStripMenuItem";
            this.multiplicarToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.multiplicarToolStripMenuItem.Text = "Multiplicar";
            this.multiplicarToolStripMenuItem.Click += new System.EventHandler(this.multiplicarToolStripMenuItem_Click);
            // 
            // dividirToolStripMenuItem
            // 
            this.dividirToolStripMenuItem.Name = "dividirToolStripMenuItem";
            this.dividirToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.dividirToolStripMenuItem.Text = "Dividir";
            this.dividirToolStripMenuItem.Click += new System.EventHandler(this.dividirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(68, 151);
            this.txb1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(114, 27);
            this.txb1.TabIndex = 3;
            this.txb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(68, 199);
            this.txb2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(114, 27);
            this.txb2.TabIndex = 4;
            this.txb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(101, 91);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 20);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "label1";
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dividirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Label lbl1;
    }
}

