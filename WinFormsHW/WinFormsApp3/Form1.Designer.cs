namespace WinFormsApp3
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
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            addPhotoButton = new Button();
            pictureBox = new PictureBox();
            label7 = new Label();
            label1 = new Label();
            nameTextBox = new TextBox();
            deleteButton = new Button();
            label2 = new Label();
            sendButton = new Button();
            surnameTextBox = new TextBox();
            cityTextBox = new TextBox();
            label3 = new Label();
            label6 = new Label();
            lastnameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ageTextBox = new TextBox();
            label8 = new Label();
            nameTextBoxLocked = new TextBox();
            ageTextBoxLocked = new TextBox();
            label13 = new Label();
            surnameTextBoxLocked = new TextBox();
            label12 = new Label();
            cityTextBoxLocked = new TextBox();
            phoneTextBoxLocked = new TextBox();
            lastnameTextBoxLocked = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 374);
            panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(addPhotoButton);
            splitContainer1.Panel1.Controls.Add(pictureBox);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(nameTextBox);
            splitContainer1.Panel1.Controls.Add(deleteButton);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(sendButton);
            splitContainer1.Panel1.Controls.Add(surnameTextBox);
            splitContainer1.Panel1.Controls.Add(cityTextBox);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(lastnameTextBox);
            splitContainer1.Panel1.Controls.Add(phoneTextBox);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(ageTextBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(nameTextBoxLocked);
            splitContainer1.Panel2.Controls.Add(ageTextBoxLocked);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(surnameTextBoxLocked);
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(cityTextBoxLocked);
            splitContainer1.Panel2.Controls.Add(phoneTextBoxLocked);
            splitContainer1.Panel2.Controls.Add(lastnameTextBoxLocked);
            splitContainer1.Size = new Size(697, 374);
            splitContainer1.SplitterDistance = 441;
            splitContainer1.TabIndex = 17;
            // 
            // addPhotoButton
            // 
            addPhotoButton.Location = new Point(268, 226);
            addPhotoButton.Name = "addPhotoButton";
            addPhotoButton.Size = new Size(140, 23);
            addPhotoButton.TabIndex = 16;
            addPhotoButton.Text = "Добавить фото";
            addPhotoButton.UseVisualStyleBackColor = true;
            addPhotoButton.Click += addPhotoButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(278, 43);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(120, 160);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 14;
            pictureBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 19);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 15;
            label7.Text = "Ваше фото";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите ваше имя";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(22, 43);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(177, 23);
            nameTextBox.TabIndex = 1;
            nameTextBox.Tag = "textBoxImportant";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(268, 302);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 23);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Удалить все";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 2;
            label2.Text = "Введите вашу фамилию";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(268, 264);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(140, 23);
            sendButton.TabIndex = 12;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(22, 99);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(177, 23);
            surnameTextBox.TabIndex = 3;
            surnameTextBox.Tag = "textBoxImportant";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(22, 323);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(177, 23);
            cityTextBox.TabIndex = 11;
            cityTextBox.Tag = "textBoxImportant";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 131);
            label3.Name = "label3";
            label3.Size = new Size(217, 15);
            label3.TabIndex = 4;
            label3.Text = "Введите ваше отчество (при наличии)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 299);
            label6.Name = "label6";
            label6.Size = new Size(183, 15);
            label6.TabIndex = 10;
            label6.Text = "Введите ваш город проживания";
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(22, 155);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(177, 23);
            lastnameTextBox.TabIndex = 5;
            lastnameTextBox.Tag = "";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(22, 267);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(177, 23);
            phoneTextBox.TabIndex = 9;
            phoneTextBox.Tag = "textBoxImportant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 187);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 6;
            label4.Text = "Введите ваш возраст";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 243);
            label5.Name = "label5";
            label5.Size = new Size(171, 15);
            label5.TabIndex = 8;
            label5.Text = "Введите ваш номер телефона";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(22, 211);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(177, 23);
            ageTextBox.TabIndex = 7;
            ageTextBox.Tag = "textBoxImportant";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 19);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 17;
            label8.Text = "Ваше ФИО";
            // 
            // nameTextBoxLocked
            // 
            nameTextBoxLocked.Location = new Point(20, 43);
            nameTextBoxLocked.Name = "nameTextBoxLocked";
            nameTextBoxLocked.ReadOnly = true;
            nameTextBoxLocked.Size = new Size(177, 23);
            nameTextBoxLocked.TabIndex = 18;
            nameTextBoxLocked.Tag = "textBoxImportant";
            // 
            // ageTextBoxLocked
            // 
            ageTextBoxLocked.Location = new Point(20, 163);
            ageTextBoxLocked.Name = "ageTextBoxLocked";
            ageTextBoxLocked.ReadOnly = true;
            ageTextBoxLocked.Size = new Size(177, 23);
            ageTextBoxLocked.TabIndex = 24;
            ageTextBoxLocked.Tag = "textBoxImportant";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 195);
            label13.Name = "label13";
            label13.Size = new Size(123, 15);
            label13.TabIndex = 25;
            label13.Text = "Личная информация";
            // 
            // surnameTextBoxLocked
            // 
            surnameTextBoxLocked.Location = new Point(20, 75);
            surnameTextBoxLocked.Name = "surnameTextBoxLocked";
            surnameTextBoxLocked.ReadOnly = true;
            surnameTextBoxLocked.Size = new Size(177, 23);
            surnameTextBoxLocked.TabIndex = 20;
            surnameTextBoxLocked.Tag = "textBoxImportant";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 139);
            label12.Name = "label12";
            label12.Size = new Size(76, 15);
            label12.TabIndex = 23;
            label12.Text = "Ваш возраст";
            // 
            // cityTextBoxLocked
            // 
            cityTextBoxLocked.Location = new Point(20, 251);
            cityTextBoxLocked.Name = "cityTextBoxLocked";
            cityTextBoxLocked.ReadOnly = true;
            cityTextBoxLocked.Size = new Size(177, 23);
            cityTextBoxLocked.TabIndex = 28;
            cityTextBoxLocked.Tag = "textBoxImportant";
            // 
            // phoneTextBoxLocked
            // 
            phoneTextBoxLocked.Location = new Point(20, 219);
            phoneTextBoxLocked.Name = "phoneTextBoxLocked";
            phoneTextBoxLocked.ReadOnly = true;
            phoneTextBoxLocked.Size = new Size(177, 23);
            phoneTextBoxLocked.TabIndex = 26;
            phoneTextBoxLocked.Tag = "textBoxImportant";
            // 
            // lastnameTextBoxLocked
            // 
            lastnameTextBoxLocked.Location = new Point(20, 107);
            lastnameTextBoxLocked.Name = "lastnameTextBoxLocked";
            lastnameTextBoxLocked.ReadOnly = true;
            lastnameTextBoxLocked.Size = new Size(177, 23);
            lastnameTextBoxLocked.TabIndex = 22;
            lastnameTextBoxLocked.Tag = "textBoxImportant";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 374);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Анкета";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox surnameTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label1;
        private TextBox cityTextBox;
        private Label label6;
        private TextBox phoneTextBox;
        private Label label5;
        private TextBox ageTextBox;
        private Label label4;
        private TextBox lastnameTextBox;
        private Label label3;
        private Button deleteButton;
        private Button sendButton;
        private Label label7;
        private PictureBox pictureBox;
        private Button addPhotoButton;
        private SplitContainer splitContainer1;
        private Label label8;
        private TextBox nameTextBoxLocked;
        private TextBox ageTextBoxLocked;
        private Label label13;
        private TextBox surnameTextBoxLocked;
        private Label label12;
        private TextBox cityTextBoxLocked;
        private TextBox phoneTextBoxLocked;
        private TextBox lastnameTextBoxLocked;
    }
}
