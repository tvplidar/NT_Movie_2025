namespace NT_Movie_2025
{
    partial class Frm_movie
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
            this.movie_id = new System.Windows.Forms.TextBox();
            this.movie_name = new System.Windows.Forms.TextBox();
            this.movie_type_id = new System.Windows.Forms.TextBox();
            this.movie_name_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_id
            // 
            this.movie_id.BackColor = System.Drawing.Color.Cornsilk;
            this.movie_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_id.Location = new System.Drawing.Point(280, 36);
            this.movie_id.Name = "movie_id";
            this.movie_id.Size = new System.Drawing.Size(421, 75);
            this.movie_id.TabIndex = 0;
            // 
            // movie_name
            // 
            this.movie_name.BackColor = System.Drawing.Color.Cornsilk;
            this.movie_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name.Location = new System.Drawing.Point(280, 129);
            this.movie_name.Name = "movie_name";
            this.movie_name.Size = new System.Drawing.Size(421, 75);
            this.movie_name.TabIndex = 1;
            // 
            // movie_type_id
            // 
            this.movie_type_id.BackColor = System.Drawing.Color.Cornsilk;
            this.movie_type_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_type_id.Location = new System.Drawing.Point(280, 327);
            this.movie_type_id.Name = "movie_type_id";
            this.movie_type_id.Size = new System.Drawing.Size(421, 75);
            this.movie_type_id.TabIndex = 2;
            // 
            // movie_name_type
            // 
            this.movie_name_type.BackColor = System.Drawing.Color.Cornsilk;
            this.movie_name_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name_type.Location = new System.Drawing.Point(280, 228);
            this.movie_name_type.Name = "movie_name_type";
            this.movie_name_type.Size = new System.Drawing.Size(421, 75);
            this.movie_name_type.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Phetsarath OT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(106, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 48);
            this.label4.TabIndex = 26;
            this.label4.Text = "ລະຫັດໜັງ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 144);
            this.dataGridView1.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Phetsarath OT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(162, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 48);
            this.label5.TabIndex = 43;
            this.label5.Text = "ຊື່ໜັງ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(23, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 48);
            this.label1.TabIndex = 44;
            this.label1.Text = "ລະຫັດປະເພດໜັງ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(79, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 48);
            this.label2.TabIndex = 45;
            this.label2.Text = "ຊື່ປະເພດໜັງ:";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(789, 581);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(183, 90);
            this.btn_delete.TabIndex = 49;
            this.btn_delete.Text = "ລົບຂໍ້ມູນ";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_update.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_update.Location = new System.Drawing.Point(536, 581);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(183, 90);
            this.btn_update.TabIndex = 48;
            this.btn_update.Tag = "";
            this.btn_update.Text = "ແກ້ໄຂຂໍ້ມູນ";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(286, 581);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(184, 90);
            this.btn_save.TabIndex = 47;
            this.btn_save.Text = "ບັນທຶກຂໍ້ມູນ";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_show.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Location = new System.Drawing.Point(42, 581);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(194, 90);
            this.btn_show.TabIndex = 46;
            this.btn_show.Text = "ເພີ່ມຂໍ້ມູນ";
            this.btn_show.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_search.Font = new System.Drawing.Font("Phetsarath OT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(746, 247);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(226, 62);
            this.btn_search.TabIndex = 51;
            this.btn_search.Text = "ຄົ້ນຫາ";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox1.Font = new System.Drawing.Font("Phetsarath OT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(746, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 96);
            this.textBox1.TabIndex = 50;
            // 
            // Frm_movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1006, 683);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movie_name_type);
            this.Controls.Add(this.movie_type_id);
            this.Controls.Add(this.movie_name);
            this.Controls.Add(this.movie_id);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_movie";
            this.Text = "Frm_movie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox movie_id;
        private System.Windows.Forms.TextBox movie_name;
        private System.Windows.Forms.TextBox movie_type_id;
        private System.Windows.Forms.TextBox movie_name_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox1;
    }
}