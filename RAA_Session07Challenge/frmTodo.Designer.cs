namespace RAA_Session07Challenge
{
    partial class frmTodo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddEdit = new System.Windows.Forms.Label();
            this.lbxTodo = new System.Windows.Forms.ListBox();
            this.tbxAddEdit = new System.Windows.Forms.TextBox();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDn = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todo Items";
            // 
            // lblAddEdit
            // 
            this.lblAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEdit.AutoSize = true;
            this.lblAddEdit.Location = new System.Drawing.Point(432, 9);
            this.lblAddEdit.Name = "lblAddEdit";
            this.lblAddEdit.Size = new System.Drawing.Size(109, 20);
            this.lblAddEdit.TabIndex = 1;
            this.lblAddEdit.Text = "Add New Item";
            // 
            // lbxTodo
            // 
            this.lbxTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxTodo.FormattingEnabled = true;
            this.lbxTodo.ItemHeight = 20;
            this.lbxTodo.Location = new System.Drawing.Point(12, 42);
            this.lbxTodo.Name = "lbxTodo";
            this.lbxTodo.Size = new System.Drawing.Size(405, 524);
            this.lbxTodo.TabIndex = 2;
            this.lbxTodo.DoubleClick += new System.EventHandler(this.lbxTodo_DoubleClick);
            // 
            // tbxAddEdit
            // 
            this.tbxAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAddEdit.Location = new System.Drawing.Point(436, 42);
            this.tbxAddEdit.Name = "tbxAddEdit";
            this.tbxAddEdit.Size = new System.Drawing.Size(417, 26);
            this.tbxAddEdit.TabIndex = 3;
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEdit.Location = new System.Drawing.Point(436, 74);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(179, 33);
            this.btnAddEdit.TabIndex = 4;
            this.btnAddEdit.Text = "Add Item";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(436, 267);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 37);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(436, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDn
            // 
            this.btnDn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDn.Location = new System.Drawing.Point(436, 425);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(65, 40);
            this.btnDn.TabIndex = 8;
            this.btnDn.Text = "Dn";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Location = new System.Drawing.Point(436, 382);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(65, 37);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(423, 542);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(147, 20);
            this.lblFilename.TabIndex = 9;
            this.lblFilename.Text = "Name of current file";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current File:";
            // 
            // frmTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 596);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.tbxAddEdit);
            this.Controls.Add(this.lbxTodo);
            this.Controls.Add(this.lblAddEdit);
            this.Controls.Add(this.label1);
            this.Name = "frmTodo";
            this.Text = "Revit Todo Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddEdit;
        private System.Windows.Forms.ListBox lbxTodo;
        private System.Windows.Forms.TextBox tbxAddEdit;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label label4;
    }
}