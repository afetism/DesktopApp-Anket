namespace DesktopApp_Anket
{
    partial class Form1
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
            LoadTb = new TextBox();
            LoadBtn = new Button();
            groupBox1 = new GroupBox();
            SurnameTb = new TextBox();
            NameTb = new TextBox();
            AgeTb = new TextBox();
            MaleRb = new RadioButton();
            FemaleRb = new RadioButton();
            Nameabel = new Label();
            SurnameLb = new Label();
            AgeLb = new Label();
            MaleLb = new Label();
            SaveBt = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LoadTb
            // 
            LoadTb.Location = new Point(125, 12);
            LoadTb.Name = "LoadTb";
            LoadTb.Size = new Size(100, 23);
            LoadTb.TabIndex = 0;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(306, 12);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(75, 23);
            LoadBtn.TabIndex = 1;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MaleLb);
            groupBox1.Controls.Add(AgeLb);
            groupBox1.Controls.Add(SurnameLb);
            groupBox1.Controls.Add(Nameabel);
            groupBox1.Controls.Add(FemaleRb);
            groupBox1.Controls.Add(MaleRb);
            groupBox1.Controls.Add(AgeTb);
            groupBox1.Controls.Add(SurnameTb);
            groupBox1.Controls.Add(NameTb);
            groupBox1.Location = new Point(67, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 251);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // SurnameTb
            // 
            SurnameTb.Location = new Point(191, 81);
            SurnameTb.Name = "SurnameTb";
            SurnameTb.Size = new Size(100, 23);
            SurnameTb.TabIndex = 2;
            // 
            // NameTb
            // 
            NameTb.Location = new Point(191, 34);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(100, 23);
            NameTb.TabIndex = 1;
            // 
            // AgeTb
            // 
            AgeTb.Location = new Point(191, 135);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(100, 23);
            AgeTb.TabIndex = 3;
            // 
            // MaleRb
            // 
            MaleRb.AutoSize = true;
            MaleRb.Location = new Point(134, 183);
            MaleRb.Name = "MaleRb";
            MaleRb.Size = new Size(51, 19);
            MaleRb.TabIndex = 4;
            MaleRb.TabStop = true;
            MaleRb.Text = "Male";
            MaleRb.UseVisualStyleBackColor = true;
            // 
            // FemaleRb
            // 
            FemaleRb.AutoSize = true;
            FemaleRb.Location = new Point(258, 183);
            FemaleRb.Name = "FemaleRb";
            FemaleRb.Size = new Size(63, 19);
            FemaleRb.TabIndex = 5;
            FemaleRb.TabStop = true;
            FemaleRb.Text = "Famale";
            FemaleRb.UseVisualStyleBackColor = true;
            // 
            // Nameabel
            // 
            Nameabel.AutoSize = true;
            Nameabel.Location = new Point(18, 42);
            Nameabel.Name = "Nameabel";
            Nameabel.Size = new Size(39, 15);
            Nameabel.TabIndex = 6;
            Nameabel.Text = "Name";
            Nameabel.Click += label1_Click;
            // 
            // SurnameLb
            // 
            SurnameLb.AutoSize = true;
            SurnameLb.Location = new Point(18, 89);
            SurnameLb.Name = "SurnameLb";
            SurnameLb.Size = new Size(54, 15);
            SurnameLb.TabIndex = 7;
            SurnameLb.Text = "Surname";
            // 
            // AgeLb
            // 
            AgeLb.AutoSize = true;
            AgeLb.Location = new Point(18, 143);
            AgeLb.Name = "AgeLb";
            AgeLb.Size = new Size(28, 15);
            AgeLb.TabIndex = 8;
            AgeLb.Text = "Age";
            // 
            // MaleLb
            // 
            MaleLb.AutoSize = true;
            MaleLb.Location = new Point(18, 187);
            MaleLb.Name = "MaleLb";
            MaleLb.Size = new Size(45, 15);
            MaleLb.TabIndex = 9;
            MaleLb.Text = "Gender";
            // 
            // SaveBt
            // 
            SaveBt.Location = new Point(67, 323);
            SaveBt.Name = "SaveBt";
            SaveBt.Size = new Size(367, 23);
            SaveBt.TabIndex = 3;
            SaveBt.Text = "Save";
            SaveBt.UseVisualStyleBackColor = true;
            SaveBt.Click += SaveBt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 358);
            Controls.Add(SaveBt);
            Controls.Add(groupBox1);
            Controls.Add(LoadBtn);
            Controls.Add(LoadTb);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoadTb;
        private Button LoadBtn;
        private GroupBox groupBox1;
        private TextBox SurnameTb;
        private TextBox NameTb;
        private Label AgeLb;
        private Label SurnameLb;
        private Label Nameabel;
        private RadioButton FemaleRb;
        private RadioButton MaleRb;
        private TextBox AgeTb;
        private Label MaleLb;
        private Button SaveBt;
    }
}
