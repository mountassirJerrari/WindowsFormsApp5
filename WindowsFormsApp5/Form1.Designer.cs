namespace WindowsFormsApp5
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
            this.gvClient = new System.Windows.Forms.DataGridView();
            this.gvCommande = new System.Windows.Forms.DataGridView();
            this.btnAddCmd = new System.Windows.Forms.Button();
            this.btnSuppCmd = new System.Windows.Forms.Button();
            this.tbCmdId = new System.Windows.Forms.TextBox();
            this.lblIsLoyal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateCmd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommande)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvClient
            // 
            this.gvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClient.Location = new System.Drawing.Point(45, 35);
            this.gvClient.Name = "gvClient";
            this.gvClient.ReadOnly = true;
            this.gvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvClient.Size = new System.Drawing.Size(269, 182);
            this.gvClient.TabIndex = 0;
            this.gvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvClient_CellContentClick);
            this.gvClient.SelectionChanged += new System.EventHandler(this.gvClient_SelectionChanged);
            // 
            // gvCommande
            // 
            this.gvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCommande.Location = new System.Drawing.Point(404, 35);
            this.gvCommande.Name = "gvCommande";
            this.gvCommande.ReadOnly = true;
            this.gvCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCommande.Size = new System.Drawing.Size(289, 273);
            this.gvCommande.TabIndex = 1;
            // 
            // btnAddCmd
            // 
            this.btnAddCmd.Location = new System.Drawing.Point(60, 99);
            this.btnAddCmd.Name = "btnAddCmd";
            this.btnAddCmd.Size = new System.Drawing.Size(147, 37);
            this.btnAddCmd.TabIndex = 2;
            this.btnAddCmd.Text = "add commande";
            this.btnAddCmd.UseVisualStyleBackColor = true;
            this.btnAddCmd.Click += new System.EventHandler(this.btnAddCmd_Click);
            // 
            // btnSuppCmd
            // 
            this.btnSuppCmd.Location = new System.Drawing.Point(404, 340);
            this.btnSuppCmd.Name = "btnSuppCmd";
            this.btnSuppCmd.Size = new System.Drawing.Size(147, 37);
            this.btnSuppCmd.TabIndex = 3;
            this.btnSuppCmd.Text = "supprimer commande";
            this.btnSuppCmd.UseVisualStyleBackColor = true;
            this.btnSuppCmd.Click += new System.EventHandler(this.btnSuppCmd_Click);
            // 
            // tbCmdId
            // 
            this.tbCmdId.Location = new System.Drawing.Point(88, 73);
            this.tbCmdId.Name = "tbCmdId";
            this.tbCmdId.Size = new System.Drawing.Size(100, 20);
            this.tbCmdId.TabIndex = 4;
            this.tbCmdId.TextChanged += new System.EventHandler(this.tbCmdId_TextChanged);
            // 
            // lblIsLoyal
            // 
            this.lblIsLoyal.AutoSize = true;
            this.lblIsLoyal.ForeColor = System.Drawing.Color.Orange;
            this.lblIsLoyal.Location = new System.Drawing.Point(4, 35);
            this.lblIsLoyal.Name = "lblIsLoyal";
            this.lblIsLoyal.Size = new System.Drawing.Size(0, 13);
            this.lblIsLoyal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "les clients :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "les commandes associées :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "id commande :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateCmd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddCmd);
            this.groupBox1.Controls.Add(this.tbCmdId);
            this.groupBox1.Location = new System.Drawing.Point(45, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 149);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "creation  d une commande :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "date :";
            // 
            // dateCmd
            // 
            this.dateCmd.Location = new System.Drawing.Point(88, 47);
            this.dateCmd.Name = "dateCmd";
            this.dateCmd.Size = new System.Drawing.Size(200, 20);
            this.dateCmd.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIsLoyal);
            this.Controls.Add(this.btnSuppCmd);
            this.Controls.Add(this.gvCommande);
            this.Controls.Add(this.gvClient);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCommande)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvClient;
        private System.Windows.Forms.DataGridView gvCommande;
        private System.Windows.Forms.Button btnAddCmd;
        private System.Windows.Forms.Button btnSuppCmd;
        private System.Windows.Forms.TextBox tbCmdId;
        private System.Windows.Forms.Label lblIsLoyal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateCmd;
        private System.Windows.Forms.Label label4;
    }
}

