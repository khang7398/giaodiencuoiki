namespace QuanLyKhachSan
{
    partial class QuanLy
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpROOM = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpUpdateroom = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tpList = new System.Windows.Forms.TabPage();
            this.tpDichVu = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpROOM.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpUpdateroom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpList.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpROOM);
            this.tabControl1.Controls.Add(this.tpDichVu);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tpROOM
            // 
            this.tpROOM.Controls.Add(this.tabControl2);
            this.tpROOM.Location = new System.Drawing.Point(4, 25);
            this.tpROOM.Name = "tpROOM";
            this.tpROOM.Padding = new System.Windows.Forms.Padding(3);
            this.tpROOM.Size = new System.Drawing.Size(694, 346);
            this.tpROOM.TabIndex = 0;
            this.tpROOM.Text = "   ROOM";
            this.tpROOM.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpUpdateroom);
            this.tabControl2.Controls.Add(this.tpList);
            this.tabControl2.Location = new System.Drawing.Point(4, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(669, 322);
            this.tabControl2.TabIndex = 0;
            // 
            // tpUpdateroom
            // 
            this.tpUpdateroom.Controls.Add(this.panel3);
            this.tpUpdateroom.Controls.Add(this.panel2);
            this.tpUpdateroom.Controls.Add(this.panel1);
            this.tpUpdateroom.Location = new System.Drawing.Point(4, 25);
            this.tpUpdateroom.Name = "tpUpdateroom";
            this.tpUpdateroom.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateroom.Size = new System.Drawing.Size(661, 293);
            this.tpUpdateroom.TabIndex = 0;
            this.tpUpdateroom.Text = "UpdateRoom";
            this.tpUpdateroom.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(6, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chartreuse;
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.LawnGreen;
            this.btnView.Location = new System.Drawing.Point(485, 47);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(81, 33);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông Tin Phòng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Phòng";
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.panel4);
            this.tpList.Controls.Add(this.comboBox1);
            this.tpList.Controls.Add(this.label3);
            this.tpList.Location = new System.Drawing.Point(4, 25);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(661, 293);
            this.tpList.TabIndex = 1;
            this.tpList.Text = "List";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // tpDichVu
            // 
            this.tpDichVu.Location = new System.Drawing.Point(4, 25);
            this.tpDichVu.Name = "tpDichVu";
            this.tpDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tpDichVu.Size = new System.Drawing.Size(694, 346);
            this.tpDichVu.TabIndex = 1;
            this.tpDichVu.Text = "  Dịch Vụ";
            this.tpDichVu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Phòng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "120",
            "121",
            "122",
            "123",
            "124"});
            this.comboBox1.Location = new System.Drawing.Point(159, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(394, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 213);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lầu";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(14, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(113, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.tabControl1.ResumeLayout(false);
            this.tpROOM.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpUpdateroom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpList.ResumeLayout(false);
            this.tpList.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpROOM;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpUpdateroom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpDichVu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}