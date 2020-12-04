namespace WindowsFormsElectrovozs
{
    partial class FormElectrovoz
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.pictureBoxTrains = new System.Windows.Forms.PictureBox();
            this.ComboBoxRoga = new System.Windows.Forms.ComboBox();
            this.buttonCreateLocomotive = new System.Windows.Forms.Button();
            this.buttonCreateElectrovoz = new System.Windows.Forms.Button();
            this.buttonFirstForm = new System.Windows.Forms.Button();
            this.buttonSecondForm = new System.Windows.Forms.Button();
            this.buttonThirdForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrains)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsElectrovozs.Properties.Resources.kisspng_computer_icons_arrow_right_arrow_5ac223069cc060_7838577215226723906421;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(800, 402);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsElectrovozs.Properties.Resources.kisspng_computer_icons_arrow_right_arrow_5ac223069cc0601;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(836, 376);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsElectrovozs.Properties.Resources._12;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(800, 340);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsElectrovozs.Properties.Resources._11;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(764, 376);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxTrains
            // 
            this.pictureBoxTrains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTrains.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTrains.Name = "pictureBoxTrains";
            this.pictureBoxTrains.Size = new System.Drawing.Size(878, 444);
            this.pictureBoxTrains.TabIndex = 0;
            this.pictureBoxTrains.TabStop = false;
            this.pictureBoxTrains.Click += new System.EventHandler(this.buttonCreateLocomotive_Click);
            // 
            // ComboBoxRoga
            // 
            this.ComboBoxRoga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRoga.FormattingEnabled = true;
            this.ComboBoxRoga.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ComboBoxRoga.Location = new System.Drawing.Point(745, 48);
            this.ComboBoxRoga.Name = "ComboBoxRoga";
            this.ComboBoxRoga.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxRoga.TabIndex = 6;
            // 
            // buttonCreateLocomotive
            // 
            this.buttonCreateLocomotive.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateLocomotive.Name = "buttonCreateLocomotive";
            this.buttonCreateLocomotive.Size = new System.Drawing.Size(176, 34);
            this.buttonCreateLocomotive.TabIndex = 7;
            this.buttonCreateLocomotive.Text = "Создать локомотив";
            this.buttonCreateLocomotive.UseVisualStyleBackColor = true;
            this.buttonCreateLocomotive.Click += new System.EventHandler(this.buttonCreateLocomotive_Click);
            // 
            // buttonCreateElectrovoz
            // 
            this.buttonCreateElectrovoz.Location = new System.Drawing.Point(194, 12);
            this.buttonCreateElectrovoz.Name = "buttonCreateElectrovoz";
            this.buttonCreateElectrovoz.Size = new System.Drawing.Size(184, 34);
            this.buttonCreateElectrovoz.TabIndex = 8;
            this.buttonCreateElectrovoz.Text = "Создать электровоз";
            this.buttonCreateElectrovoz.UseVisualStyleBackColor = true;
            this.buttonCreateElectrovoz.Click += new System.EventHandler(this.buttonCreateElectrovoz_Click);
            // 
            // buttonFirstForm
            // 
            this.buttonFirstForm.Location = new System.Drawing.Point(745, 82);
            this.buttonFirstForm.Name = "buttonFirstForm";
            this.buttonFirstForm.Size = new System.Drawing.Size(121, 32);
            this.buttonFirstForm.TabIndex = 9;
            this.buttonFirstForm.Text = "1 форма рога";
            this.buttonFirstForm.UseVisualStyleBackColor = true;
            this.buttonFirstForm.Click += new System.EventHandler(this.buttonRogaForm_Click);
            // 
            // buttonSecondForm
            // 
            this.buttonSecondForm.Location = new System.Drawing.Point(745, 120);
            this.buttonSecondForm.Name = "buttonSecondForm";
            this.buttonSecondForm.Size = new System.Drawing.Size(121, 32);
            this.buttonSecondForm.TabIndex = 10;
            this.buttonSecondForm.Text = "2 форма рога";
            this.buttonSecondForm.UseVisualStyleBackColor = true;
            this.buttonSecondForm.Click += new System.EventHandler(this.buttonRogaForm_Click);
            // 
            // buttonThirdForm
            // 
            this.buttonThirdForm.Location = new System.Drawing.Point(745, 158);
            this.buttonThirdForm.Name = "buttonThirdForm";
            this.buttonThirdForm.Size = new System.Drawing.Size(121, 32);
            this.buttonThirdForm.TabIndex = 11;
            this.buttonThirdForm.Text = "3 форма рога";
            this.buttonThirdForm.UseVisualStyleBackColor = true;
            this.buttonThirdForm.Click += new System.EventHandler(this.buttonRogaForm_Click);
            // 
            // FormElectrovoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 444);
            this.Controls.Add(this.buttonThirdForm);
            this.Controls.Add(this.buttonSecondForm);
            this.Controls.Add(this.buttonFirstForm);
            this.Controls.Add(this.buttonCreateElectrovoz);
            this.Controls.Add(this.buttonCreateLocomotive);
            this.Controls.Add(this.ComboBoxRoga);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.pictureBoxTrains);
            this.Name = "FormElectrovoz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электровоз";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrains;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.ComboBox ComboBoxRoga;
        private System.Windows.Forms.Button buttonCreateLocomotive;
        private System.Windows.Forms.Button buttonCreateElectrovoz;
        private System.Windows.Forms.Button buttonFirstForm;
        private System.Windows.Forms.Button buttonSecondForm;
        private System.Windows.Forms.Button buttonThirdForm;
    }
}

