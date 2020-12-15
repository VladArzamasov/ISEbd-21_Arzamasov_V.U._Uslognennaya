namespace WindowsFormsElectrovozs
{
    partial class FormDepo
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
            this.pictureBoxDepo = new System.Windows.Forms.PictureBox();
            this.buttonParkingLocomotive = new System.Windows.Forms.Button();
            this.buttonParkingElectrovoz = new System.Windows.Forms.Button();
            this.groupBoxPlace = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.buttonZobr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxRoga = new System.Windows.Forms.ComboBox();
            this.buttonFirstForm = new System.Windows.Forms.Button();
            this.buttonSecondForm = new System.Windows.Forms.Button();
            this.buttonThirdForm = new System.Windows.Forms.Button();
            this.maskedTextBoxCompareForSimilarity = new System.Windows.Forms.MaskedTextBox();
            this.buttonSvobodMesta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).BeginInit();
            this.groupBoxPlace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDepo
            // 
            this.pictureBoxDepo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxDepo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDepo.Name = "pictureBoxDepo";
            this.pictureBoxDepo.Size = new System.Drawing.Size(641, 502);
            this.pictureBoxDepo.TabIndex = 0;
            this.pictureBoxDepo.TabStop = false;
            // 
            // buttonParkingLocomotive
            // 
            this.buttonParkingLocomotive.Location = new System.Drawing.Point(647, 12);
            this.buttonParkingLocomotive.Name = "buttonParkingLocomotive";
            this.buttonParkingLocomotive.Size = new System.Drawing.Size(149, 56);
            this.buttonParkingLocomotive.TabIndex = 1;
            this.buttonParkingLocomotive.Text = "Добавить локомотив";
            this.buttonParkingLocomotive.UseVisualStyleBackColor = true;
            this.buttonParkingLocomotive.Click += new System.EventHandler(this.buttonParkingLocomotive_Click);
            // 
            // buttonParkingElectrovoz
            // 
            this.buttonParkingElectrovoz.Location = new System.Drawing.Point(647, 73);
            this.buttonParkingElectrovoz.Name = "buttonParkingElectrovoz";
            this.buttonParkingElectrovoz.Size = new System.Drawing.Size(149, 55);
            this.buttonParkingElectrovoz.TabIndex = 2;
            this.buttonParkingElectrovoz.Text = "Добавить электровоз";
            this.buttonParkingElectrovoz.UseVisualStyleBackColor = true;
            this.buttonParkingElectrovoz.Click += new System.EventHandler(this.buttonParkingElectrovoz_Click);
            // 
            // groupBoxPlace
            // 
            this.groupBoxPlace.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxPlace.Controls.Add(this.buttonZobr);
            this.groupBoxPlace.Controls.Add(this.label1);
            this.groupBoxPlace.Location = new System.Drawing.Point(647, 145);
            this.groupBoxPlace.Name = "groupBoxPlace";
            this.groupBoxPlace.Size = new System.Drawing.Size(149, 112);
            this.groupBoxPlace.TabIndex = 3;
            this.groupBoxPlace.TabStop = false;
            this.groupBoxPlace.Text = "Забрать поезд";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(74, 39);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(33, 26);
            this.maskedTextBoxPlace.TabIndex = 2;
            // 
            // buttonZobr
            // 
            this.buttonZobr.Location = new System.Drawing.Point(11, 72);
            this.buttonZobr.Name = "buttonZobr";
            this.buttonZobr.Size = new System.Drawing.Size(130, 34);
            this.buttonZobr.TabIndex = 1;
            this.buttonZobr.Text = "Забрать";
            this.buttonZobr.UseVisualStyleBackColor = true;
            this.buttonZobr.Click += new System.EventHandler(this.buttonZobr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // ComboBoxRoga
            // 
            this.ComboBoxRoga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRoga.FormattingEnabled = true;
            this.ComboBoxRoga.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ComboBoxRoga.Location = new System.Drawing.Point(658, 272);
            this.ComboBoxRoga.Name = "ComboBoxRoga";
            this.ComboBoxRoga.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxRoga.TabIndex = 7;
            // 
            // buttonFirstForm
            // 
            this.buttonFirstForm.Location = new System.Drawing.Point(658, 306);
            this.buttonFirstForm.Name = "buttonFirstForm";
            this.buttonFirstForm.Size = new System.Drawing.Size(121, 32);
            this.buttonFirstForm.TabIndex = 10;
            this.buttonFirstForm.Text = "1 форма рога";
            this.buttonFirstForm.UseVisualStyleBackColor = true;
            this.buttonFirstForm.Click += new System.EventHandler(this.buttonRogaForm_Click);
            // 
            // buttonSecondForm
            // 
            this.buttonSecondForm.Location = new System.Drawing.Point(658, 344);
            this.buttonSecondForm.Name = "buttonSecondForm";
            this.buttonSecondForm.Size = new System.Drawing.Size(121, 32);
            this.buttonSecondForm.TabIndex = 11;
            this.buttonSecondForm.Text = "2 форма рога";
            this.buttonSecondForm.UseVisualStyleBackColor = true;
            this.buttonSecondForm.Click += new System.EventHandler(this.buttonRogaForm_Click);
            // 
            // buttonThirdForm
            // 
            this.buttonThirdForm.Location = new System.Drawing.Point(658, 382);
            this.buttonThirdForm.Name = "buttonThirdForm";
            this.buttonThirdForm.Size = new System.Drawing.Size(121, 32);
            this.buttonThirdForm.TabIndex = 12;
            this.buttonThirdForm.Text = "3 форма рога";
            this.buttonThirdForm.UseVisualStyleBackColor = true;
            this.buttonThirdForm.Click += new System.EventHandler(this.buttonRogaForm_Click);
            // 
            // maskedTextBoxCompareForSimilarity
            // 
            this.maskedTextBoxCompareForSimilarity.Location = new System.Drawing.Point(647, 426);
            this.maskedTextBoxCompareForSimilarity.Name = "maskedTextBoxCompareForSimilarity";
            this.maskedTextBoxCompareForSimilarity.Size = new System.Drawing.Size(33, 26);
            this.maskedTextBoxCompareForSimilarity.TabIndex = 13;
            // 
            // buttonSvobodMesta
            // 
            this.buttonSvobodMesta.Location = new System.Drawing.Point(688, 420);
            this.buttonSvobodMesta.Name = "buttonSvobodMesta";
            this.buttonSvobodMesta.Size = new System.Drawing.Size(108, 39);
            this.buttonSvobodMesta.TabIndex = 14;
            this.buttonSvobodMesta.Text = "Проверить";
            this.buttonSvobodMesta.UseVisualStyleBackColor = true;
            this.buttonSvobodMesta.Click += new System.EventHandler(this.buttonSvobodMesta_Click);
            // 
            // FormDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.buttonSvobodMesta);
            this.Controls.Add(this.maskedTextBoxCompareForSimilarity);
            this.Controls.Add(this.buttonThirdForm);
            this.Controls.Add(this.buttonSecondForm);
            this.Controls.Add(this.buttonFirstForm);
            this.Controls.Add(this.ComboBoxRoga);
            this.Controls.Add(this.groupBoxPlace);
            this.Controls.Add(this.buttonParkingElectrovoz);
            this.Controls.Add(this.buttonParkingLocomotive);
            this.Controls.Add(this.pictureBoxDepo);
            this.Name = "FormDepo";
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).EndInit();
            this.groupBoxPlace.ResumeLayout(false);
            this.groupBoxPlace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepo;
        private System.Windows.Forms.Button buttonParkingLocomotive;
        private System.Windows.Forms.Button buttonParkingElectrovoz;
        private System.Windows.Forms.GroupBox groupBoxPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Button buttonZobr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxRoga;
        private System.Windows.Forms.Button buttonFirstForm;
        private System.Windows.Forms.Button buttonSecondForm;
        private System.Windows.Forms.Button buttonThirdForm;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCompareForSimilarity;
        private System.Windows.Forms.Button buttonSvobodMesta;
    }
}