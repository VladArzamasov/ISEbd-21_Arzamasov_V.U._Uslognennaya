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
            this.groupBoxPlace = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.buttonZobr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCompareForSimilarity = new System.Windows.Forms.MaskedTextBox();
            this.buttonSvobodMesta = new System.Windows.Forms.Button();
            this.labelDepo = new System.Windows.Forms.Label();
            this.textBoxNameDepo = new System.Windows.Forms.TextBox();
            this.buttonDobavlDepo = new System.Windows.Forms.Button();
            this.ListBoxDepo = new System.Windows.Forms.ListBox();
            this.buttonUdalDepo = new System.Windows.Forms.Button();
            this.buttonTrainsCheck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // groupBoxPlace
            // 
            this.groupBoxPlace.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxPlace.Controls.Add(this.buttonZobr);
            this.groupBoxPlace.Controls.Add(this.label1);
            this.groupBoxPlace.Location = new System.Drawing.Point(658, 41);
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
            // maskedTextBoxCompareForSimilarity
            // 
            this.maskedTextBoxCompareForSimilarity.Location = new System.Drawing.Point(827, 347);
            this.maskedTextBoxCompareForSimilarity.Name = "maskedTextBoxCompareForSimilarity";
            this.maskedTextBoxCompareForSimilarity.Size = new System.Drawing.Size(33, 26);
            this.maskedTextBoxCompareForSimilarity.TabIndex = 13;
            // 
            // buttonSvobodMesta
            // 
            this.buttonSvobodMesta.Location = new System.Drawing.Point(866, 341);
            this.buttonSvobodMesta.Name = "buttonSvobodMesta";
            this.buttonSvobodMesta.Size = new System.Drawing.Size(116, 39);
            this.buttonSvobodMesta.TabIndex = 14;
            this.buttonSvobodMesta.Text = "Проверить";
            this.buttonSvobodMesta.UseVisualStyleBackColor = true;
            this.buttonSvobodMesta.Click += new System.EventHandler(this.buttonSvobodMesta_Click);
            // 
            // labelDepo
            // 
            this.labelDepo.AutoSize = true;
            this.labelDepo.Location = new System.Drawing.Point(880, 18);
            this.labelDepo.Name = "labelDepo";
            this.labelDepo.Size = new System.Drawing.Size(52, 20);
            this.labelDepo.TabIndex = 15;
            this.labelDepo.Text = "Депо:";
            // 
            // textBoxNameDepo
            // 
            this.textBoxNameDepo.Location = new System.Drawing.Point(827, 41);
            this.textBoxNameDepo.Name = "textBoxNameDepo";
            this.textBoxNameDepo.Size = new System.Drawing.Size(155, 26);
            this.textBoxNameDepo.TabIndex = 16;
            // 
            // buttonDobavlDepo
            // 
            this.buttonDobavlDepo.Location = new System.Drawing.Point(827, 73);
            this.buttonDobavlDepo.Name = "buttonDobavlDepo";
            this.buttonDobavlDepo.Size = new System.Drawing.Size(155, 34);
            this.buttonDobavlDepo.TabIndex = 17;
            this.buttonDobavlDepo.Text = "Добавить депо";
            this.buttonDobavlDepo.UseVisualStyleBackColor = true;
            this.buttonDobavlDepo.Click += new System.EventHandler(this.buttonDobavlDepo_Click);
            // 
            // ListBoxDepo
            // 
            this.ListBoxDepo.FormattingEnabled = true;
            this.ListBoxDepo.ItemHeight = 20;
            this.ListBoxDepo.Location = new System.Drawing.Point(827, 125);
            this.ListBoxDepo.Name = "ListBoxDepo";
            this.ListBoxDepo.Size = new System.Drawing.Size(155, 144);
            this.ListBoxDepo.TabIndex = 18;
            this.ListBoxDepo.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonUdalDepo
            // 
            this.buttonUdalDepo.Location = new System.Drawing.Point(827, 287);
            this.buttonUdalDepo.Name = "buttonUdalDepo";
            this.buttonUdalDepo.Size = new System.Drawing.Size(155, 36);
            this.buttonUdalDepo.TabIndex = 19;
            this.buttonUdalDepo.Text = "Удалить депо";
            this.buttonUdalDepo.UseVisualStyleBackColor = true;
            this.buttonUdalDepo.Click += new System.EventHandler(this.buttonUdalDepo_Click);
            // 
            // buttonTrainsCheck
            // 
            this.buttonTrainsCheck.Location = new System.Drawing.Point(827, 401);
            this.buttonTrainsCheck.Name = "buttonTrainsCheck";
            this.buttonTrainsCheck.Size = new System.Drawing.Size(155, 39);
            this.buttonTrainsCheck.TabIndex = 20;
            this.buttonTrainsCheck.Text = "показать";
            this.buttonTrainsCheck.UseVisualStyleBackColor = true;
            this.buttonTrainsCheck.Click += new System.EventHandler(this.buttonTrainsCheck_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "Добавить поезд";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAddTrain_Click);
            // 
            // FormDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTrainsCheck);
            this.Controls.Add(this.buttonUdalDepo);
            this.Controls.Add(this.ListBoxDepo);
            this.Controls.Add(this.buttonDobavlDepo);
            this.Controls.Add(this.textBoxNameDepo);
            this.Controls.Add(this.labelDepo);
            this.Controls.Add(this.buttonSvobodMesta);
            this.Controls.Add(this.maskedTextBoxCompareForSimilarity);
            this.Controls.Add(this.groupBoxPlace);
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
        private System.Windows.Forms.GroupBox groupBoxPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Button buttonZobr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCompareForSimilarity;
        private System.Windows.Forms.Button buttonSvobodMesta;
        private System.Windows.Forms.Label labelDepo;
        private System.Windows.Forms.TextBox textBoxNameDepo;
        private System.Windows.Forms.Button buttonDobavlDepo;
        private System.Windows.Forms.ListBox ListBoxDepo;
        private System.Windows.Forms.Button buttonUdalDepo;
        private System.Windows.Forms.Button buttonTrainsCheck;
        private System.Windows.Forms.Button button1;
    }
}