namespace WindowsFormsApp5
{
    partial class Form2
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
            this.gvPlats = new System.Windows.Forms.DataGridView();
            this.gvPlatAtt = new System.Windows.Forms.DataGridView();
            this.tbQte = new System.Windows.Forms.TextBox();
            this.btnAddPlat = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlatAtt)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPlats
            // 
            this.gvPlats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPlats.Location = new System.Drawing.Point(414, 115);
            this.gvPlats.Name = "gvPlats";
            this.gvPlats.ReadOnly = true;
            this.gvPlats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPlats.Size = new System.Drawing.Size(290, 177);
            this.gvPlats.TabIndex = 0;
            // 
            // gvPlatAtt
            // 
            this.gvPlatAtt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPlatAtt.Location = new System.Drawing.Point(58, 115);
            this.gvPlatAtt.Name = "gvPlatAtt";
            this.gvPlatAtt.ReadOnly = true;
            this.gvPlatAtt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPlatAtt.Size = new System.Drawing.Size(290, 177);
            this.gvPlatAtt.TabIndex = 1;
            // 
            // tbQte
            // 
            this.tbQte.Location = new System.Drawing.Point(136, 319);
            this.tbQte.Name = "tbQte";
            this.tbQte.Size = new System.Drawing.Size(100, 20);
            this.tbQte.TabIndex = 2;
            // 
            // btnAddPlat
            // 
            this.btnAddPlat.Location = new System.Drawing.Point(58, 358);
            this.btnAddPlat.Name = "btnAddPlat";
            this.btnAddPlat.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlat.TabIndex = 3;
            this.btnAddPlat.Text = "add plat";
            this.btnAddPlat.UseVisualStyleBackColor = true;
            this.btnAddPlat.Click += new System.EventHandler(this.btnAddPlat_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(340, 21);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "les plats attachés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "tous les plats disponibles :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(557, 80);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(147, 20);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(154, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "title :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "la quantité  :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAddPlat);
            this.Controls.Add(this.tbQte);
            this.Controls.Add(this.gvPlatAtt);
            this.Controls.Add(this.gvPlats);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPlats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPlatAtt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPlats;
        private System.Windows.Forms.DataGridView gvPlatAtt;
        private System.Windows.Forms.TextBox tbQte;
        private System.Windows.Forms.Button btnAddPlat;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
    }
}