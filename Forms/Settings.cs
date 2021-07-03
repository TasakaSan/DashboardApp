using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardApp.Forms
{
    public partial class Settings : Form
    {
        public string topColor;
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DashboardApp\\Settings\\settings.txt";
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_SaveTheme_Click(object sender, EventArgs e)
        {
            try
            {
                SelectTheme();
                if (topColor != null)
                {
                    string themeColor = topColor.ToString();
                    File.WriteAllText(path, themeColor);
                    Application.Restart();
                }
                else MessageBox.Show("Please choose a theme color before validate");


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void SelectTheme()
        {
            foreach (Control allBtn in this.Controls)
            {
                if (allBtn.GetType() == typeof(Button))
                {
                    Button btn = (Button)allBtn;
                    if (CheckBoxThemeOrange.Checked)
                    {
                        btn.BackColor = Color.Orange;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.Orange;
                        label1.ForeColor = Color.Orange;
                        topColor = "Orange";
                    }
                    else if (CheckBoxThemeRed.Checked)
                    {
                        btn.BackColor = Color.OrangeRed;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.OrangeRed;
                        topColor = "OrangeRed";
                        label1.ForeColor = Color.OrangeRed;
                    }
                    else if (CheckBoxThemeGreen.Checked)
                    {
                        btn.BackColor = Color.LimeGreen;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.LimeGreen;
                        topColor = "LimeGreen";
                        label1.ForeColor = Color.LimeGreen;
                    }
                    else if (CheckBoxThemePink.Checked)
                    {
                        btn.BackColor = Color.MistyRose;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.MistyRose;
                        topColor = "MistyRose";
                        label1.ForeColor = Color.MistyRose;
                    }
                    else if (CheckBoxThemeBlue.Checked)
                    {
                        btn.BackColor = Color.SkyBlue;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.SkyBlue;
                        topColor = "SkyBlue";
                        label1.ForeColor = Color.SkyBlue;
                    }
                    else if (CheckBoxThemeBlue.Checked)
                    {
                        btn.BackColor = Color.SkyBlue;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.SkyBlue;
                        topColor = "SkyBlue";
                        label1.ForeColor = Color.SkyBlue;
                    }
                    else if (CheckBoxThemePurple.Checked)
                    {
                        btn.BackColor = Color.MediumVioletRed;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.MediumVioletRed;
                        topColor = "MediumVioletRed";
                        label1.ForeColor = Color.MediumVioletRed;
                    }
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string pathRead = File.ReadAllText(path);
                foreach (Control allBtn in this.Controls)
                {
                    if (allBtn.GetType() == typeof(Button))
                    {
                        Button btn = (Button)allBtn;
                        btn.BackColor = Color.FromName(pathRead);
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.FromName(pathRead);
                    }
                }
                label1.ForeColor = Color.FromName(pathRead);
            }
            else File.WriteAllText(path, string.Empty);                
        }

        private void pictureBoxOrange_Click(object sender, EventArgs e)
        {
            if (!CheckBoxThemeOrange.Checked)
            {
                CheckBoxThemeOrange.Checked = true;
                CheckBoxThemeBlue.Checked = false;
                CheckBoxThemePink.Checked = false;
                CheckBoxThemeRed.Checked = false;
                CheckBoxThemeGreen.Checked = false;
                CheckBoxThemePurple.Checked = false;
            }
            else SetPictureBoxToFalse();
        }

        private void pictureBoxRed_Click(object sender, EventArgs e)
        {
            if (!CheckBoxThemeRed.Checked)
            {
                CheckBoxThemeOrange.Checked = false;
                CheckBoxThemeBlue.Checked = false;
                CheckBoxThemePink.Checked = false;
                CheckBoxThemeRed.Checked = true;
                CheckBoxThemeGreen.Checked = false;
                CheckBoxThemePurple.Checked = false;
            }
            else SetPictureBoxToFalse();
        }

        private void pictureBoxGreen_Click(object sender, EventArgs e)
        {
            if (!CheckBoxThemeGreen.Checked)
            {
                CheckBoxThemeOrange.Checked = false;
                CheckBoxThemeBlue.Checked = false;
                CheckBoxThemePink.Checked = false;
                CheckBoxThemeRed.Checked = false;
                CheckBoxThemeGreen.Checked = true;
                CheckBoxThemePurple.Checked = false;
            }
            else SetPictureBoxToFalse();
        }

        private void pictureBoxPink_Click(object sender, EventArgs e)
        {
            if (!CheckBoxThemePink.Checked)
            {
                CheckBoxThemeOrange.Checked = false;
                CheckBoxThemeBlue.Checked = false;
                CheckBoxThemePink.Checked = true;
                CheckBoxThemeRed.Checked = false;
                CheckBoxThemeGreen.Checked = false;
                CheckBoxThemePurple.Checked = false;
            }
            else SetPictureBoxToFalse();
        }

        private void pictureBoxBlue_Click(object sender, EventArgs e)
        {
            if (!CheckBoxThemeBlue.Checked)
            {
                CheckBoxThemeOrange.Checked = false;
                CheckBoxThemeBlue.Checked = true;
                CheckBoxThemePink.Checked = false;
                CheckBoxThemeRed.Checked = false;
                CheckBoxThemeGreen.Checked = false;
                CheckBoxThemePurple.Checked = false;
            }
            else SetPictureBoxToFalse();
        }

        private void pictureBoxPurple_Click(object sender, EventArgs e)
        {
            if (!CheckBoxThemePurple.Checked)
            {
                CheckBoxThemeOrange.Checked = false;
                CheckBoxThemeBlue.Checked = false;
                CheckBoxThemePink.Checked = false;
                CheckBoxThemeRed.Checked = false;
                CheckBoxThemeGreen.Checked = false;
                CheckBoxThemePurple.Checked = true;
            }
            else SetPictureBoxToFalse();
        }

        private void SetPictureBoxToFalse()
        {
            CheckBoxThemeOrange.Checked = false;
            CheckBoxThemeBlue.Checked = false;
            CheckBoxThemePink.Checked = false;
            CheckBoxThemeRed.Checked = false;
            CheckBoxThemeGreen.Checked = false;
            CheckBoxThemePurple.Checked = false;
        }
    }
}
