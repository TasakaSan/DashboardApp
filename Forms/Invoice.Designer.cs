
namespace DashboardApp.Forms
{
    partial class Invoice
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_GenerateFact = new System.Windows.Forms.Button();
            this.lbl_ClientFactNumber = new System.Windows.Forms.Label();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.richTextBoxClientInfo = new System.Windows.Forms.RichTextBox();
            this.lbl_TitleInvoice = new System.Windows.Forms.Label();
            this.textBoxTitleInvoice = new System.Windows.Forms.TextBox();
            this.checkBoxFacture = new System.Windows.Forms.CheckBox();
            this.checkBoxRefound = new System.Windows.Forms.CheckBox();
            this.checkBoxDevis = new System.Windows.Forms.CheckBox();
            this.Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(23, 24);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(94, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Votre Adresse :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cat,
            this.Designation,
            this.Quantity,
            this.Unit_Price,
            this.PrixHT,
            this.TVA});
            this.dataGridView1.Location = new System.Drawing.Point(26, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 259);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_GenerateFact
            // 
            this.btn_GenerateFact.Location = new System.Drawing.Point(589, 442);
            this.btn_GenerateFact.Name = "btn_GenerateFact";
            this.btn_GenerateFact.Size = new System.Drawing.Size(122, 39);
            this.btn_GenerateFact.TabIndex = 13;
            this.btn_GenerateFact.Text = "Générer le document";
            this.btn_GenerateFact.UseVisualStyleBackColor = true;
            this.btn_GenerateFact.Click += new System.EventHandler(this.btn_GenerateFact_Click);
            // 
            // lbl_ClientFactNumber
            // 
            this.lbl_ClientFactNumber.AutoSize = true;
            this.lbl_ClientFactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientFactNumber.Location = new System.Drawing.Point(495, 24);
            this.lbl_ClientFactNumber.Name = "lbl_ClientFactNumber";
            this.lbl_ClientFactNumber.Size = new System.Drawing.Size(96, 13);
            this.lbl_ClientFactNumber.TabIndex = 15;
            this.lbl_ClientFactNumber.Text = "Type Document";
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(26, 41);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(186, 106);
            this.richTextBoxInfo.TabIndex = 16;
            this.richTextBoxInfo.Text = "";
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.AutoSize = true;
            this.lbl_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientName.Location = new System.Drawing.Point(282, 24);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(96, 13);
            this.lbl_ClientName.TabIndex = 17;
            this.lbl_ClientName.Text = "Adresse Client :";
            // 
            // richTextBoxClientInfo
            // 
            this.richTextBoxClientInfo.Location = new System.Drawing.Point(285, 41);
            this.richTextBoxClientInfo.Name = "richTextBoxClientInfo";
            this.richTextBoxClientInfo.Size = new System.Drawing.Size(186, 106);
            this.richTextBoxClientInfo.TabIndex = 18;
            this.richTextBoxClientInfo.Text = "";
            // 
            // lbl_TitleInvoice
            // 
            this.lbl_TitleInvoice.AutoSize = true;
            this.lbl_TitleInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleInvoice.Location = new System.Drawing.Point(23, 164);
            this.lbl_TitleInvoice.Name = "lbl_TitleInvoice";
            this.lbl_TitleInvoice.Size = new System.Drawing.Size(94, 13);
            this.lbl_TitleInvoice.TabIndex = 19;
            this.lbl_TitleInvoice.Text = "Titre Document";
            // 
            // textBoxTitleInvoice
            // 
            this.textBoxTitleInvoice.Location = new System.Drawing.Point(26, 181);
            this.textBoxTitleInvoice.Name = "textBoxTitleInvoice";
            this.textBoxTitleInvoice.Size = new System.Drawing.Size(445, 20);
            this.textBoxTitleInvoice.TabIndex = 20;
            // 
            // checkBoxFacture
            // 
            this.checkBoxFacture.AutoSize = true;
            this.checkBoxFacture.Location = new System.Drawing.Point(498, 40);
            this.checkBoxFacture.Name = "checkBoxFacture";
            this.checkBoxFacture.Size = new System.Drawing.Size(62, 17);
            this.checkBoxFacture.TabIndex = 22;
            this.checkBoxFacture.Text = "Facture";
            this.checkBoxFacture.UseVisualStyleBackColor = true;
            // 
            // checkBoxRefound
            // 
            this.checkBoxRefound.AutoSize = true;
            this.checkBoxRefound.Location = new System.Drawing.Point(498, 63);
            this.checkBoxRefound.Name = "checkBoxRefound";
            this.checkBoxRefound.Size = new System.Drawing.Size(50, 17);
            this.checkBoxRefound.TabIndex = 23;
            this.checkBoxRefound.Text = "Avoir";
            this.checkBoxRefound.UseVisualStyleBackColor = true;
            // 
            // checkBoxDevis
            // 
            this.checkBoxDevis.AutoSize = true;
            this.checkBoxDevis.Location = new System.Drawing.Point(498, 84);
            this.checkBoxDevis.Name = "checkBoxDevis";
            this.checkBoxDevis.Size = new System.Drawing.Size(53, 17);
            this.checkBoxDevis.TabIndex = 24;
            this.checkBoxDevis.Text = "Devis";
            this.checkBoxDevis.UseVisualStyleBackColor = true;
            // 
            // Cat
            // 
            this.Cat.HeaderText = "Cat";
            this.Cat.Name = "Cat";
            this.Cat.Width = 50;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Désignation";
            this.Designation.Name = "Designation";
            this.Designation.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantité";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // Unit_Price
            // 
            this.Unit_Price.HeaderText = "PU";
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.Width = 50;
            // 
            // PrixHT
            // 
            this.PrixHT.HeaderText = "PrixHT";
            this.PrixHT.Name = "PrixHT";
            this.PrixHT.ReadOnly = true;
            this.PrixHT.Width = 50;
            // 
            // TVA
            // 
            this.TVA.FillWeight = 50F;
            this.TVA.HeaderText = "TVA";
            this.TVA.Items.AddRange(new object[] {
            "2.1",
            "5",
            "10",
            "20"});
            this.TVA.Name = "TVA";
            this.TVA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.checkBoxDevis);
            this.Controls.Add(this.checkBoxRefound);
            this.Controls.Add(this.checkBoxFacture);
            this.Controls.Add(this.textBoxTitleInvoice);
            this.Controls.Add(this.lbl_TitleInvoice);
            this.Controls.Add(this.richTextBoxClientInfo);
            this.Controls.Add(this.lbl_ClientName);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.lbl_ClientFactNumber);
            this.Controls.Add(this.btn_GenerateFact);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Invoice";
            this.Text = "Réaliser une fature/devis ou un avoir";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_GenerateFact;
        private System.Windows.Forms.Label lbl_ClientFactNumber;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Label lbl_ClientName;
        private System.Windows.Forms.RichTextBox richTextBoxClientInfo;
        private System.Windows.Forms.Label lbl_TitleInvoice;
        private System.Windows.Forms.TextBox textBoxTitleInvoice;
        private System.Windows.Forms.CheckBox checkBoxFacture;
        private System.Windows.Forms.CheckBox checkBoxRefound;
        private System.Windows.Forms.CheckBox checkBoxDevis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixHT;
        private System.Windows.Forms.DataGridViewComboBoxColumn TVA;
    }
}