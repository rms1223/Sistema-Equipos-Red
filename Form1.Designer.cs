namespace InterfazGrafica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_meraki = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.meraki_LR = new System.Windows.Forms.Button();
            this.meraki_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_interior = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_meraki.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.AutoScroll = true;
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.panel_meraki);
            this.panel_menu.Controls.Add(this.meraki_button);
            this.panel_menu.Controls.Add(this.label2);
            this.panel_menu.Controls.Add(this.panel2);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(215, 618);
            this.panel_menu.TabIndex = 0;
            this.panel_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_menu_MouseDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(0, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 58);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sistema RMS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_meraki
            // 
            this.panel_meraki.Controls.Add(this.button3);
            this.panel_meraki.Controls.Add(this.button2);
            this.panel_meraki.Controls.Add(this.button1);
            this.panel_meraki.Controls.Add(this.meraki_LR);
            this.panel_meraki.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_meraki.Location = new System.Drawing.Point(0, 92);
            this.panel_meraki.Name = "panel_meraki";
            this.panel_meraki.Size = new System.Drawing.Size(213, 129);
            this.panel_meraki.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.button3.Location = new System.Drawing.Point(0, 90);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(213, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Buscar Información del CE";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button3_MouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.button2.Location = new System.Drawing.Point(0, 60);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(213, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Registrar Aceptación de Red";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(213, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar dispositivos Locales";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseClick_1);
            // 
            // meraki_LR
            // 
            this.meraki_LR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.meraki_LR.Dock = System.Windows.Forms.DockStyle.Top;
            this.meraki_LR.FlatAppearance.BorderSize = 0;
            this.meraki_LR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meraki_LR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.meraki_LR.Location = new System.Drawing.Point(0, 0);
            this.meraki_LR.Name = "meraki_LR";
            this.meraki_LR.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.meraki_LR.Size = new System.Drawing.Size(213, 30);
            this.meraki_LR.TabIndex = 9;
            this.meraki_LR.Text = "Buscar Centro Educativo";
            this.meraki_LR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.meraki_LR.UseVisualStyleBackColor = false;
            this.meraki_LR.Click += new System.EventHandler(this.Meraki_LR_Click);
            this.meraki_LR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Meraki_LR_MouseClick);
            // 
            // meraki_button
            // 
            this.meraki_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.meraki_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.meraki_button.FlatAppearance.BorderSize = 0;
            this.meraki_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meraki_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.meraki_button.Location = new System.Drawing.Point(0, 62);
            this.meraki_button.Name = "meraki_button";
            this.meraki_button.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.meraki_button.Size = new System.Drawing.Size(213, 30);
            this.meraki_button.TabIndex = 11;
            this.meraki_button.Text = "Herramientas Técnicos";
            this.meraki_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.meraki_button.UseVisualStyleBackColor = false;
            this.meraki_button.Click += new System.EventHandler(this.Button11_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(0, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "RMS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 62);
            this.panel2.TabIndex = 0;
            // 
            // panel_interior
            // 
            this.panel_interior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_interior.Location = new System.Drawing.Point(215, 0);
            this.panel_interior.Name = "panel_interior";
            this.panel_interior.Size = new System.Drawing.Size(929, 618);
            this.panel_interior.TabIndex = 1;
            this.panel_interior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_interior_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 618);
            this.Controls.Add(this.panel_interior);
            this.Controls.Add(this.panel_menu);
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Equipos";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel_menu.ResumeLayout(false);
            this.panel_meraki.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_interior;
        private System.Windows.Forms.Panel panel_meraki;
        private System.Windows.Forms.Button meraki_LR;
        private System.Windows.Forms.Button meraki_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

