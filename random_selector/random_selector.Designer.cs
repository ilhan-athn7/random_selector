namespace random_selector
{
    partial class random_selector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            listBox2 = new ListBox();
            btn_RndChoose = new Button();
            lbl_Choosen = new Label();
            lbl_LastChoosen = new Label();
            btn_Add = new Button();
            btn_Exclude = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 550);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seçilecek Öğrenciler";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(6, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 485);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox2);
            groupBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(596, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 550);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seçilen Öğrenciler";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 37;
            listBox2.Location = new Point(6, 42);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(388, 485);
            listBox2.TabIndex = 1;
            // 
            // btn_RndChoose
            // 
            btn_RndChoose.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_RndChoose.Location = new Point(429, 295);
            btn_RndChoose.Name = "btn_RndChoose";
            btn_RndChoose.Size = new Size(150, 50);
            btn_RndChoose.TabIndex = 3;
            btn_RndChoose.Text = "Rastgele Seç";
            btn_RndChoose.UseVisualStyleBackColor = true;
            btn_RndChoose.Click += btn_RndChoose_Click;
            // 
            // lbl_Choosen
            // 
            lbl_Choosen.AutoSize = true;
            lbl_Choosen.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Choosen.Location = new Point(428, 580);
            lbl_Choosen.Name = "lbl_Choosen";
            lbl_Choosen.Size = new Size(162, 37);
            lbl_Choosen.TabIndex = 4;
            lbl_Choosen.Text = "Son seçilen :";
            // 
            // lbl_LastChoosen
            // 
            lbl_LastChoosen.AutoSize = true;
            lbl_LastChoosen.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_LastChoosen.Location = new Point(596, 580);
            lbl_LastChoosen.Name = "lbl_LastChoosen";
            lbl_LastChoosen.Size = new Size(28, 37);
            lbl_LastChoosen.TabIndex = 5;
            lbl_LastChoosen.Text = "-";
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Add.Location = new Point(158, 568);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(50, 50);
            btn_Add.TabIndex = 6;
            btn_Add.Text = "[+]";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Exclude
            // 
            btn_Exclude.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exclude.Location = new Point(216, 568);
            btn_Exclude.Name = "btn_Exclude";
            btn_Exclude.Size = new Size(50, 50);
            btn_Exclude.TabIndex = 7;
            btn_Exclude.Text = "[-]";
            btn_Exclude.UseVisualStyleBackColor = true;
            btn_Exclude.Click += btn_Exclude_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(429, 512);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 8;
            button1.Text = "Seçilenleri Sıfırla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_Reset_Click;
            // 
            // random_selector
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 641);
            Controls.Add(button1);
            Controls.Add(btn_Exclude);
            Controls.Add(btn_Add);
            Controls.Add(lbl_LastChoosen);
            Controls.Add(lbl_Choosen);
            Controls.Add(btn_RndChoose);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "random_selector";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rastgele Seçici";
            FormClosed += random_selector_FormClosed;
            Load += random_selector_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_RndChoose;
        private Label lbl_Choosen;
        private Label lbl_LastChoosen;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btn_Add;
        private Button btn_Exclude;
        private Button button1;
    }
}