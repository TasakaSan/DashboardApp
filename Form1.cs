using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardApp
{
    public partial class Dashboard : Form
    {
        //Fields
        private Form activeForm;
        readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DashboardApp\\Settings\\settings.txt";
        
        //Constructor
        public Dashboard()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((((Screen.PrimaryScreen.Bounds.Width / 2) - this.Width) - 220), ((Screen.PrimaryScreen.Bounds.Height / 2) - this.Height));
            CreateFolder();
            InitializeComponent();
        }

        //Methods
        private void Dashboard_Load(object sender, EventArgs e)
        {
            getColorPanelAndLabel();
            OpenChildForm(new Forms.Dashboard(), sender);

            foreach (Control btns in panel_Menu.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
            foreach (Control btns in panel_Title.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }
        public void CreateFolder()
        {
            string folderApp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DashboardApp";
            string folderSettings = System.IO.Path.Combine(folderApp, "Settings");
            string fileSettings = folderSettings + "\\settings.txt";
            string folderInvoice = System.IO.Path.Combine(folderApp, "Invoices");
            try
            {
                if (!File.Exists(fileSettings))
                {
                    System.IO.Directory.CreateDirectory(folderSettings);
                    System.IO.Directory.CreateDirectory(folderInvoice);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void getColorPanelAndLabel()
        {
            if (File.Exists(path))
            {
                lbl_Title.ForeColor = Color.White;
                string pathRead = File.ReadAllText(path);
                panel_Title.BackColor = Color.FromName(pathRead);
                panel3.BackColor = Color.FromArgb(100, Color.FromName(pathRead));
                lbl_Logo.BackColor = Color.FromArgb(1, Color.FromName(pathRead));
            }           
        }

        //Drag Panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void lbl_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Open Form
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_Base.Controls.Add(childForm);
            this.panel_Base.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Title.Text = childForm.Text;
        }

        //Buttons
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dashboard(), sender);
            getColorPanelAndLabel();
        }
        private void btn_Dashboard_MouseEnter(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string pathRead = File.ReadAllText(path);
                btn_Dashboard.BackColor = Color.FromName(pathRead);
            }
        }

        private void btn_Dashboard_MouseLeave(object sender, EventArgs e)
        {
            btn_Dashboard.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btn_Purchase_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Purchase(), sender);
            getColorPanelAndLabel();
        }
        private void btn_Purchase_MouseEnter(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string pathRead = File.ReadAllText(path);
                btn_Purchase.BackColor = Color.FromName(pathRead);
            }
        }

        private void btn_Purchase_MouseLeave(object sender, EventArgs e)
        {
            btn_Purchase.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSale(), sender);
            getColorPanelAndLabel();
        }
        private void btn_Sale_MouseEnter(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string pathRead = File.ReadAllText(path);
                btn_Sale.BackColor = Color.FromName(pathRead);
            }
        }

        private void btn_Sale_MouseLeave(object sender, EventArgs e)
        {
            btn_Sale.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Invoice(), sender);
            getColorPanelAndLabel();
        }
        private void btn_Invoice_MouseEnter(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string pathRead = File.ReadAllText(path);
                btn_Invoice.BackColor = Color.FromName(pathRead);
            }
        }

        private void btn_Invoice_MouseLeave(object sender, EventArgs e)
        {
            btn_Invoice.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Settings(), sender);
            getColorPanelAndLabel();
        }
        private void btn_settings_MouseEnter(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string pathRead = File.ReadAllText(path);
                btn_settings.BackColor = Color.FromName(pathRead);
            }

        }

        private void btn_settings_MouseLeave(object sender, EventArgs e)
        {
            btn_settings.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
