namespace WindowsFormsElectrovozs
{
    partial class FormElectrovozConfig
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
            this.groupBoxTypeTrain = new System.Windows.Forms.GroupBox();
            this.labelElectrovoz = new System.Windows.Forms.Label();
            this.labelLocomotive = new System.Windows.Forms.Label();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.checkBoxLightning = new System.Windows.Forms.CheckBox();
            this.checkBoxRoga = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pictureBoxElectrovoz = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelOsnColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxFormRoga = new System.Windows.Forms.GroupBox();
            this.groupBoxNumberRoga = new System.Windows.Forms.GroupBox();
            this.groupBoxTypeTrain.SuspendLayout();
            this.groupBoxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElectrovoz)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTypeTrain
            // 
            this.groupBoxTypeTrain.Controls.Add(this.labelElectrovoz);
            this.groupBoxTypeTrain.Controls.Add(this.labelLocomotive);
            this.groupBoxTypeTrain.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTypeTrain.Name = "groupBoxTypeTrain";
            this.groupBoxTypeTrain.Size = new System.Drawing.Size(200, 215);
            this.groupBoxTypeTrain.TabIndex = 3;
            this.groupBoxTypeTrain.TabStop = false;
            this.groupBoxTypeTrain.Text = "Тип поезда";
            // 
            // labelElectrovoz
            // 
            this.labelElectrovoz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelElectrovoz.Location = new System.Drawing.Point(25, 89);
            this.labelElectrovoz.Name = "labelElectrovoz";
            this.labelElectrovoz.Size = new System.Drawing.Size(150, 50);
            this.labelElectrovoz.TabIndex = 1;
            this.labelElectrovoz.Text = "Электровоз";
            this.labelElectrovoz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelElectrovoz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelElectrovoz_MouseDown);
            // 
            // labelLocomotive
            // 
            this.labelLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLocomotive.Location = new System.Drawing.Point(25, 30);
            this.labelLocomotive.Name = "labelLocomotive";
            this.labelLocomotive.Size = new System.Drawing.Size(150, 50);
            this.labelLocomotive.TabIndex = 0;
            this.labelLocomotive.Text = "Локомотив";
            this.labelLocomotive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLocomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelLocomotive_MuseDown);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.checkBoxLightning);
            this.groupBoxConfig.Controls.Add(this.checkBoxRoga);
            this.groupBoxConfig.Controls.Add(this.numericUpDownWeight);
            this.groupBoxConfig.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxConfig.Controls.Add(this.labelWeight);
            this.groupBoxConfig.Controls.Add(this.labelSpeed);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 236);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(450, 188);
            this.groupBoxConfig.TabIndex = 5;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Параметры";
            // 
            // checkBoxLightning
            // 
            this.checkBoxLightning.AutoSize = true;
            this.checkBoxLightning.Location = new System.Drawing.Point(241, 79);
            this.checkBoxLightning.Name = "checkBoxLightning";
            this.checkBoxLightning.Size = new System.Drawing.Size(163, 24);
            this.checkBoxLightning.TabIndex = 5;
            this.checkBoxLightning.Text = "Наличие молнии";
            this.checkBoxLightning.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoga
            // 
            this.checkBoxRoga.AutoSize = true;
            this.checkBoxRoga.Location = new System.Drawing.Point(241, 28);
            this.checkBoxRoga.Name = "checkBoxRoga";
            this.checkBoxRoga.Size = new System.Drawing.Size(149, 24);
            this.checkBoxRoga.TabIndex = 4;
            this.checkBoxRoga.Text = "Наличие рогов";
            this.checkBoxRoga.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(11, 131);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownWeight.TabIndex = 3;
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(11, 60);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownSpeed.TabIndex = 2;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(7, 98);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(100, 20);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес поезда:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.Location = new System.Drawing.Point(7, 26);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(128, 20);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Макс. скорость:";
            // 
            // panelPicture
            // 
            this.panelPicture.AllowDrop = true;
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Controls.Add(this.pictureBoxElectrovoz);
            this.panelPicture.Location = new System.Drawing.Point(219, 24);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(244, 203);
            this.panelPicture.TabIndex = 6;
            this.panelPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPicture_DragDrop);
            this.panelPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPicture_DragEnter);
            // 
            // pictureBoxElectrovoz
            // 
            this.pictureBoxElectrovoz.Location = new System.Drawing.Point(17, 27);
            this.pictureBoxElectrovoz.Name = "pictureBoxElectrovoz";
            this.pictureBoxElectrovoz.Size = new System.Drawing.Size(209, 148);
            this.pictureBoxElectrovoz.TabIndex = 0;
            this.pictureBoxElectrovoz.TabStop = false;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.labelOsnColor);
            this.groupBoxColor.Location = new System.Drawing.Point(519, 24);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(307, 277);
            this.groupBoxColor.TabIndex = 7;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(168, 203);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(50, 50);
            this.panelGreen.TabIndex = 4;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(240, 203);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(50, 50);
            this.panelBlue.TabIndex = 5;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(168, 126);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(50, 50);
            this.panelBlack.TabIndex = 4;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(240, 126);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(50, 50);
            this.panelWhite.TabIndex = 4;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.Location = new System.Drawing.Point(97, 203);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(50, 50);
            this.panelOrange.TabIndex = 4;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(21, 203);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(50, 50);
            this.panelGray.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(97, 126);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(50, 50);
            this.panelYellow.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(21, 126);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(50, 50);
            this.panelRed.TabIndex = 2;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(160, 28);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(130, 50);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelOsnColor_DragEnter);
            // 
            // labelOsnColor
            // 
            this.labelOsnColor.AllowDrop = true;
            this.labelOsnColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOsnColor.Location = new System.Drawing.Point(21, 28);
            this.labelOsnColor.Name = "labelOsnColor";
            this.labelOsnColor.Size = new System.Drawing.Size(130, 50);
            this.labelOsnColor.TabIndex = 0;
            this.labelOsnColor.Text = "Основной цвет";
            this.labelOsnColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOsnColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelOsnColor_DragDrop);
            this.labelOsnColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelOsnColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(720, 321);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 38);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(720, 374);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 38);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxFormRoga
            // 
            this.groupBoxFormRoga.Location = new System.Drawing.Point(219, 441);
            this.groupBoxFormRoga.Name = "groupBoxFormRoga";
            this.groupBoxFormRoga.Size = new System.Drawing.Size(244, 117);
            this.groupBoxFormRoga.TabIndex = 10;
            this.groupBoxFormRoga.TabStop = false;
            this.groupBoxFormRoga.Text = "Форма рогов";
            // 
            // groupBoxNumberRoga
            // 
            this.groupBoxNumberRoga.Location = new System.Drawing.Point(23, 441);
            this.groupBoxNumberRoga.Name = "groupBoxNumberRoga";
            this.groupBoxNumberRoga.Size = new System.Drawing.Size(190, 117);
            this.groupBoxNumberRoga.TabIndex = 11;
            this.groupBoxNumberRoga.TabStop = false;
            this.groupBoxNumberRoga.Text = "Кол-во рогов";
            // 
            // FormElectrovozConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 583);
            this.Controls.Add(this.groupBoxNumberRoga);
            this.Controls.Add(this.groupBoxFormRoga);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.groupBoxTypeTrain);
            this.Name = "FormElectrovozConfig";
            this.Text = "Выбор поезда";
            this.groupBoxTypeTrain.ResumeLayout(false);
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElectrovoz)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTypeTrain;
        private System.Windows.Forms.Label labelElectrovoz;
        private System.Windows.Forms.Label labelLocomotive;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.CheckBox checkBoxLightning;
        private System.Windows.Forms.CheckBox checkBoxRoga;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureBoxElectrovoz;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelOsnColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxFormRoga;
        private System.Windows.Forms.GroupBox groupBoxNumberRoga;
    }
}