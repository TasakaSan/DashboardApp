
namespace DashboardApp
{
    partial class Dashboard
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
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_Invoice = new System.Windows.Forms.Button();
            this.btn_Sale = new System.Windows.Forms.Button();
            this.btn_Purchase = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.panel_Base = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbl_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logo.ForeColor = System.Drawing.Color.White;
            this.lbl_Logo.Location = new System.Drawing.Point(0, 0);
            this.lbl_Logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(221, 40);
            this.lbl_Logo.TabIndex = 0;
            this.lbl_Logo.Text = "Dashboard App";
            this.lbl_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Title.Location = new System.Drawing.Point(6, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(622, 40);
            this.lbl_Title.TabIndex = 7;
            this.lbl_Title.Text = "Mon tableau d\'activité";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Title_MouseDown);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_Menu.Controls.Add(this.btn_settings);
            this.panel_Menu.Controls.Add(this.btn_Invoice);
            this.panel_Menu.Controls.Add(this.btn_Sale);
            this.panel_Menu.Controls.Add(this.btn_Purchase);
            this.panel_Menu.Controls.Add(this.btn_Dashboard);
            this.panel_Menu.Controls.Add(this.panel3);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(220, 534);
            this.panel_Menu.TabIndex = 7;
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::DashboardApp.Properties.Resources._002_settings;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(0, 280);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_settings.Size = new System.Drawing.Size(220, 60);
            this.btn_settings.TabIndex = 11;
            this.btn_settings.Text = " Paramètres";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.MouseEnter += new System.EventHandler(this.btn_settings_MouseEnter);
            this.btn_settings.MouseLeave += new System.EventHandler(this.btn_settings_MouseLeave);
            // 
            // btn_Invoice
            // 
            this.btn_Invoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Invoice.ForeColor = System.Drawing.Color.White;
            this.btn_Invoice.Image = global::DashboardApp.Properties.Resources._005_invoice;
            this.btn_Invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Invoice.Location = new System.Drawing.Point(0, 220);
            this.btn_Invoice.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Invoice.Name = "btn_Invoice";
            this.btn_Invoice.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Invoice.Size = new System.Drawing.Size(220, 60);
            this.btn_Invoice.TabIndex = 10;
            this.btn_Invoice.Text = " Réaliser une facture";
            this.btn_Invoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Invoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Invoice.UseVisualStyleBackColor = true;
            this.btn_Invoice.Click += new System.EventHandler(this.btn_Invoice_Click);
            this.btn_Invoice.MouseEnter += new System.EventHandler(this.btn_Invoice_MouseEnter);
            this.btn_Invoice.MouseLeave += new System.EventHandler(this.btn_Invoice_MouseLeave);
            // 
            // btn_Sale
            // 
            this.btn_Sale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sale.ForeColor = System.Drawing.Color.White;
            this.btn_Sale.Image = global::DashboardApp.Properties.Resources._001_credit_card;
            this.btn_Sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sale.Location = new System.Drawing.Point(0, 160);
            this.btn_Sale.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Sale.Name = "btn_Sale";
            this.btn_Sale.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Sale.Size = new System.Drawing.Size(220, 60);
            this.btn_Sale.TabIndex = 9;
            this.btn_Sale.Text = " Mes ventes";
            this.btn_Sale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sale.UseVisualStyleBackColor = true;
            this.btn_Sale.Click += new System.EventHandler(this.btn_Sale_Click);
            this.btn_Sale.MouseEnter += new System.EventHandler(this.btn_Sale_MouseEnter);
            this.btn_Sale.MouseLeave += new System.EventHandler(this.btn_Sale_MouseLeave);
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Purchase.ForeColor = System.Drawing.Color.White;
            this.btn_Purchase.Image = global::DashboardApp.Properties.Resources._004_order;
            this.btn_Purchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Purchase.Location = new System.Drawing.Point(0, 100);
            this.btn_Purchase.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Purchase.Size = new System.Drawing.Size(220, 60);
            this.btn_Purchase.TabIndex = 8;
            this.btn_Purchase.Text = " Mes achats";
            this.btn_Purchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Purchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Purchase.UseVisualStyleBackColor = true;
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            this.btn_Purchase.MouseEnter += new System.EventHandler(this.btn_Purchase_MouseEnter);
            this.btn_Purchase.MouseLeave += new System.EventHandler(this.btn_Purchase_MouseLeave);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Image = global::DashboardApp.Properties.Resources._003_dashboard;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 40);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(220, 60);
            this.btn_Dashboard.TabIndex = 7;
            this.btn_Dashboard.Text = " Mon Tableau d\'activité";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            this.btn_Dashboard.MouseEnter += new System.EventHandler(this.btn_Dashboard_MouseEnter);
            this.btn_Dashboard.MouseLeave += new System.EventHandler(this.btn_Dashboard_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_Logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 40);
            this.panel3.TabIndex = 0;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Title.Controls.Add(this.btn_Minimize);
            this.panel_Title.Controls.Add(this.btn_Quit);
            this.panel_Title.Controls.Add(this.lbl_Title);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(220, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(714, 40);
            this.panel_Title.TabIndex = 8;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.AutoSize = true;
            this.btn_Minimize.BackgroundImage = global::DashboardApp.Properties.Resources._001_minimize;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(634, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(40, 40);
            this.btn_Minimize.TabIndex = 9;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.AutoSize = true;
            this.btn_Quit.BackgroundImage = global::DashboardApp.Properties.Resources._002_cancel;
            this.btn_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Quit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Location = new System.Drawing.Point(674, 0);
            this.btn_Quit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(40, 40);
            this.btn_Quit.TabIndex = 8;
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // panel_Base
            // 
            this.panel_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Base.Location = new System.Drawing.Point(220, 40);
            this.panel_Base.Name = "panel_Base";
            this.panel_Base.Size = new System.Drawing.Size(714, 494);
            this.panel_Base.TabIndex = 9;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 534);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Base);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.panel_Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Logo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_Invoice;
        private System.Windows.Forms.Button btn_Sale;
        private System.Windows.Forms.Button btn_Purchase;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Panel panel_Base;
    }
}

