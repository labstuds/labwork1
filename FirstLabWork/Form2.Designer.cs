﻿namespace FirstLabWork
{
    partial class Form2
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
            this.sourceIntervalSeriesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calculateGroupedSeries = new System.Windows.Forms.Button();
            this.calculateChars = new System.Windows.Forms.Button();
            this.groupedSeriesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.characteristicsLabel = new System.Windows.Forms.Label();
            this.rNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.showGraphicsButton = new System.Windows.Forms.Button();
            this.cbGraphKind = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceIntervalSeriesBox
            // 
            this.sourceIntervalSeriesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sourceIntervalSeriesBox.Location = new System.Drawing.Point(12, 33);
            this.sourceIntervalSeriesBox.Multiline = true;
            this.sourceIntervalSeriesBox.Name = "sourceIntervalSeriesBox";
            this.sourceIntervalSeriesBox.Size = new System.Drawing.Size(200, 234);
            this.sourceIntervalSeriesBox.TabIndex = 3;
            this.sourceIntervalSeriesBox.Text = "0;1 5\r\n1;2 5\r\n2;3 90";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таблица с интервальным рядом распределения частот\r\n";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(218, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculateGroupedSeries
            // 
            this.calculateGroupedSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateGroupedSeries.Location = new System.Drawing.Point(218, 244);
            this.calculateGroupedSeries.Name = "calculateGroupedSeries";
            this.calculateGroupedSeries.Size = new System.Drawing.Size(338, 23);
            this.calculateGroupedSeries.TabIndex = 6;
            this.calculateGroupedSeries.Text = "Рассчитать группированный ряд относительных частот";
            this.calculateGroupedSeries.UseVisualStyleBackColor = true;
            this.calculateGroupedSeries.Click += new System.EventHandler(this.calculateGroupedSeries_Click);
            // 
            // calculateChars
            // 
            this.calculateChars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateChars.Location = new System.Drawing.Point(218, 273);
            this.calculateChars.Name = "calculateChars";
            this.calculateChars.Size = new System.Drawing.Size(338, 23);
            this.calculateChars.TabIndex = 7;
            this.calculateChars.Text = "Рассчитать характерстики";
            this.calculateChars.UseVisualStyleBackColor = true;
            this.calculateChars.Click += new System.EventHandler(this.calculateChars_Click);
            // 
            // groupedSeriesBox
            // 
            this.groupedSeriesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupedSeriesBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupedSeriesBox.Location = new System.Drawing.Point(562, 33);
            this.groupedSeriesBox.Multiline = true;
            this.groupedSeriesBox.Name = "groupedSeriesBox";
            this.groupedSeriesBox.ReadOnly = true;
            this.groupedSeriesBox.Size = new System.Drawing.Size(185, 263);
            this.groupedSeriesBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Группированный ряд относительных частот";
            // 
            // characteristicsLabel
            // 
            this.characteristicsLabel.AutoSize = true;
            this.characteristicsLabel.Location = new System.Drawing.Point(215, 36);
            this.characteristicsLabel.Name = "characteristicsLabel";
            this.characteristicsLabel.Size = new System.Drawing.Size(309, 13);
            this.characteristicsLabel.TabIndex = 10;
            this.characteristicsLabel.Text = "Здесь будут отображены значения характеристик выборки";
            // 
            // rNumber
            // 
            this.rNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rNumber.Location = new System.Drawing.Point(12, 276);
            this.rNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rNumber.Name = "rNumber";
            this.rNumber.Size = new System.Drawing.Size(174, 20);
            this.rNumber.TabIndex = 11;
            this.rNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "R";
            // 
            // showGraphicsButton
            // 
            this.showGraphicsButton.Location = new System.Drawing.Point(385, 186);
            this.showGraphicsButton.Name = "showGraphicsButton";
            this.showGraphicsButton.Size = new System.Drawing.Size(171, 23);
            this.showGraphicsButton.TabIndex = 22;
            this.showGraphicsButton.Text = "Построить";
            this.showGraphicsButton.UseVisualStyleBackColor = true;
            this.showGraphicsButton.Click += new System.EventHandler(this.showGraphicsButton_Click);
            // 
            // cbGraphKind
            // 
            this.cbGraphKind.AutoCompleteCustomSource.AddRange(new string[] {
            "Гистограмма",
            "Полигон"});
            this.cbGraphKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphKind.FormattingEnabled = true;
            this.cbGraphKind.Items.AddRange(new object[] {
            "Полигон",
            "Гистограмма",
            "Функция распределения"});
            this.cbGraphKind.Location = new System.Drawing.Point(216, 188);
            this.cbGraphKind.Name = "cbGraphKind";
            this.cbGraphKind.Size = new System.Drawing.Size(163, 21);
            this.cbGraphKind.TabIndex = 21;
            this.cbGraphKind.SelectedIndexChanged += new System.EventHandler(this.cbGraphKind_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 308);
            this.Controls.Add(this.showGraphicsButton);
            this.Controls.Add(this.cbGraphKind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rNumber);
            this.Controls.Add(this.characteristicsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupedSeriesBox);
            this.Controls.Add(this.calculateChars);
            this.Controls.Add(this.calculateGroupedSeries);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceIntervalSeriesBox);
            this.MinimumSize = new System.Drawing.Size(775, 347);
            this.Name = "Form2";
            this.Text = "Обработка интервального ряда частот";
            ((System.ComponentModel.ISupportInitialize)(this.rNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceIntervalSeriesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calculateGroupedSeries;
        private System.Windows.Forms.Button calculateChars;
        private System.Windows.Forms.TextBox groupedSeriesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label characteristicsLabel;
        private System.Windows.Forms.NumericUpDown rNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showGraphicsButton;
        private System.Windows.Forms.ComboBox cbGraphKind;

    }
}