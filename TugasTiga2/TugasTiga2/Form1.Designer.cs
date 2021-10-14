
namespace TugasTiga2
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
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPekerjaan = new System.Windows.Forms.Label();
            this.lblPendidikan = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNotifName = new System.Windows.Forms.TextBox();
            this.txtNotifPendidikan = new System.Windows.Forms.TextBox();
            this.txtNotifPekerjaan = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.ItemHeight = 16;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS ",
            "Dosen ",
            "Swasta",
            "ABRI"});
            this.lstPekerjaan.Location = new System.Drawing.Point(87, 53);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(698, 335);
            this.lstPekerjaan.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(87, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(698, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblPekerjaan
            // 
            this.lblPekerjaan.AutoSize = true;
            this.lblPekerjaan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPekerjaan.Location = new System.Drawing.Point(3, 50);
            this.lblPekerjaan.Name = "lblPekerjaan";
            this.lblPekerjaan.Size = new System.Drawing.Size(78, 341);
            this.lblPekerjaan.TabIndex = 2;
            this.lblPekerjaan.Text = "Pekerjaan";
            this.lblPekerjaan.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPendidikan
            // 
            this.lblPendidikan.AutoSize = true;
            this.lblPendidikan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendidikan.Location = new System.Drawing.Point(3, 25);
            this.lblPendidikan.Name = "lblPendidikan";
            this.lblPendidikan.Size = new System.Drawing.Size(78, 25);
            this.lblPendidikan.TabIndex = 1;
            this.lblPendidikan.Text = "Pendidikan";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nama";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPendidikan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPekerjaan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstPekerjaan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbPendidikan, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 391);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtNotifName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNotifPendidikan, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtNotifPekerjaan, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 397);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 107);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtNotifName
            // 
            this.txtNotifName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotifName.Enabled = false;
            this.txtNotifName.Location = new System.Drawing.Point(3, 3);
            this.txtNotifName.Name = "txtNotifName";
            this.txtNotifName.Size = new System.Drawing.Size(782, 22);
            this.txtNotifName.TabIndex = 0;
            // 
            // txtNotifPendidikan
            // 
            this.txtNotifPendidikan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotifPendidikan.Enabled = false;
            this.txtNotifPendidikan.Location = new System.Drawing.Point(3, 28);
            this.txtNotifPendidikan.Name = "txtNotifPendidikan";
            this.txtNotifPendidikan.Size = new System.Drawing.Size(782, 22);
            this.txtNotifPendidikan.TabIndex = 1;
            // 
            // txtNotifPekerjaan
            // 
            this.txtNotifPekerjaan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotifPekerjaan.Enabled = false;
            this.txtNotifPekerjaan.Location = new System.Drawing.Point(3, 53);
            this.txtNotifPekerjaan.Name = "txtNotifPekerjaan";
            this.txtNotifPekerjaan.Size = new System.Drawing.Size(782, 22);
            this.txtNotifPekerjaan.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Location = new System.Drawing.Point(3, 78);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(782, 26);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Ok";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Sarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(87, 28);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(698, 24);
            this.cmbPendidikan.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 504);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPekerjaan;
        private System.Windows.Forms.Label lblPendidikan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtNotifName;
        private System.Windows.Forms.TextBox txtNotifPendidikan;
        private System.Windows.Forms.TextBox txtNotifPekerjaan;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbPendidikan;
    }
}

