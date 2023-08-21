namespace SQL_Inverntory
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.productId = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id.Location = new System.Drawing.Point(400, 134);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(202, 20);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextChanged += new System.EventHandler(this.Txt_id_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_name.Location = new System.Drawing.Point(400, 181);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(202, 20);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.Txt_name_TextChanged);
            // 
            // productId
            // 
            this.productId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productId.AutoSize = true;
            this.productId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productId.ForeColor = System.Drawing.Color.White;
            this.productId.Location = new System.Drawing.Point(233, 130);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(94, 23);
            this.productId.TabIndex = 6;
            this.productId.Text = "ProductID:";
            this.productId.Click += new System.EventHandler(this.ProductId_Click);
            // 
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.Color.White;
            this.productName.Location = new System.Drawing.Point(233, 181);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(124, 23);
            this.productName.TabIndex = 6;
            this.productName.Text = "ProductName:";
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_insert.BackColor = System.Drawing.Color.Teal;
            this.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(237, 265);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(96, 43);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.Btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.BackColor = System.Drawing.Color.Teal;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(376, 265);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 43);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.Teal;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(506, 265);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 43);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 460);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 221);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(162, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inventory Management System";
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.Color.White;
            this.lbl_search.Location = new System.Drawing.Point(233, 370);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(68, 23);
            this.lbl_search.TabIndex = 6;
            this.lbl_search.Text = "Search:";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_search.Location = new System.Drawing.Point(396, 373);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(206, 20);
            this.txt_search.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.BackColor = System.Drawing.Color.Teal;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.Location = new System.Drawing.Point(647, 362);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 43);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(911, 710);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label productId;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
    }
}

