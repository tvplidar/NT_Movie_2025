namespace NT_Movie_2025
{
    partial class Frm_adduser
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(726, 242);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(163, 41);
            this.txt_search.TabIndex = 44;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(717, 413);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(163, 88);
            this.btn_search.TabIndex = 43;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Location = new System.Drawing.Point(717, 341);
            this.btn_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(163, 42);
            this.btn_select.TabIndex = 42;
            this.btn_select.Text = "SELECT DATA";
            this.btn_select.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(729, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 66);
            this.label5.TabIndex = 41;
            this.label5.Text = "ກະລຸນາພິມຂໍ້ມູນ\r\nລຸ່ມນີ້ໃສ່ເພື່ອຄົ້ນຫາ";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(505, 459);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(121, 42);
            this.btn_delete.TabIndex = 40;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(379, 459);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(121, 42);
            this.btn_update.TabIndex = 39;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(240, 459);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(123, 42);
            this.btn_save.TabIndex = 38;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(113, 459);
            this.btn_show.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(121, 42);
            this.btn_show.TabIndex = 37;
            this.btn_show.Text = "SHOW";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(506, 197);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(299, 181);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(218, 41);
            this.txt_pass.TabIndex = 32;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "ລະຫັດຜ່ານ:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(299, 81);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(218, 41);
            this.txt_name.TabIndex = 29;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(299, 30);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(218, 41);
            this.txt_id.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "ຊື່ຜູ້ໃຊ້:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "ລະຫັດ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 33);
            this.label6.TabIndex = 33;
            this.label6.Text = "ອີເມວ:";
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Phetsarath OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(299, 130);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(218, 41);
            this.txt_mail.TabIndex = 45;
            // 
            // Frm_adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 691);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_adduser";
            this.Text = "Frm_adduser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mail;
    }
}