﻿namespace FirstLabWork
{
    partial class EmpiricFunction
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
            this.components = new System.ComponentModel.Container();
            this.graph = new ZedGraph.ZedGraphControl();
            this.imgBracket = new System.Windows.Forms.PictureBox();
            this.lblFX = new System.Windows.Forms.Label();
            this.panelFunc = new System.Windows.Forms.Panel();
            this.lblA0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBracket)).BeginInit();
            this.panelFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graph.Location = new System.Drawing.Point(12, 12);
            this.graph.Name = "graph";
            this.graph.ScrollGrace = 0D;
            this.graph.ScrollMaxX = 0D;
            this.graph.ScrollMaxY = 0D;
            this.graph.ScrollMaxY2 = 0D;
            this.graph.ScrollMinX = 0D;
            this.graph.ScrollMinY = 0D;
            this.graph.ScrollMinY2 = 0D;
            this.graph.Size = new System.Drawing.Size(573, 488);
            this.graph.TabIndex = 0;
            this.graph.UseExtendedPrintDialog = true;
            // 
            // imgBracket
            // 
            this.imgBracket.BackgroundImage = global::FirstLabWork.Properties.Resources.system;
            this.imgBracket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBracket.InitialImage = global::FirstLabWork.Properties.Resources.system;
            this.imgBracket.Location = new System.Drawing.Point(82, 3);
            this.imgBracket.Name = "imgBracket";
            this.imgBracket.Size = new System.Drawing.Size(27, 185);
            this.imgBracket.TabIndex = 1;
            this.imgBracket.TabStop = false;
            // 
            // lblFX
            // 
            this.lblFX.AutoSize = true;
            this.lblFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFX.Location = new System.Drawing.Point(3, 84);
            this.lblFX.Name = "lblFX";
            this.lblFX.Size = new System.Drawing.Size(73, 25);
            this.lblFX.TabIndex = 2;
            this.lblFX.Text = "F*(X)=";
            // 
            // panelFunc
            // 
            this.panelFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFunc.Controls.Add(this.lblA0);
            this.panelFunc.Controls.Add(this.lblFX);
            this.panelFunc.Controls.Add(this.imgBracket);
            this.panelFunc.Location = new System.Drawing.Point(591, 12);
            this.panelFunc.Name = "panelFunc";
            this.panelFunc.Size = new System.Drawing.Size(279, 488);
            this.panelFunc.TabIndex = 3;
            // 
            // lblA0
            // 
            this.lblA0.AutoSize = true;
            this.lblA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblA0.Location = new System.Drawing.Point(115, 13);
            this.lblA0.Name = "lblA0";
            this.lblA0.Size = new System.Drawing.Size(54, 15);
            this.lblA0.TabIndex = 3;
            this.lblA0.Text = "0, x<=A0";
            // 
            // EmpiricFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 512);
            this.Controls.Add(this.panelFunc);
            this.Controls.Add(this.graph);
            this.Name = "EmpiricFunction";
            this.Text = "Представление эмпирической функции";
            ((System.ComponentModel.ISupportInitialize)(this.imgBracket)).EndInit();
            this.panelFunc.ResumeLayout(false);
            this.panelFunc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl graph;
        private System.Windows.Forms.PictureBox imgBracket;
        private System.Windows.Forms.Label lblFX;
        private System.Windows.Forms.Panel panelFunc;
        private System.Windows.Forms.Label lblA0;
    }
}