﻿
namespace _2021_11_04_dama_GE_PB
{
    partial class Form1
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
            this.fullBTN = new System.Windows.Forms.Button();
            this.headerPANEL = new System.Windows.Forms.Panel();
            this.headerPANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullBTN
            // 
            this.fullBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.fullBTN.Location = new System.Drawing.Point(627, 0);
            this.fullBTN.Name = "fullBTN";
            this.fullBTN.Size = new System.Drawing.Size(51, 30);
            this.fullBTN.TabIndex = 0;
            this.fullBTN.Text = "Full";
            this.fullBTN.UseVisualStyleBackColor = true;
            this.fullBTN.Click += new System.EventHandler(this.fullBTN_Click);
            // 
            // headerPANEL
            // 
            this.headerPANEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.headerPANEL.Controls.Add(this.fullBTN);
            this.headerPANEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPANEL.Location = new System.Drawing.Point(0, 0);
            this.headerPANEL.Margin = new System.Windows.Forms.Padding(0);
            this.headerPANEL.Name = "headerPANEL";
            this.headerPANEL.Size = new System.Drawing.Size(678, 30);
            this.headerPANEL.TabIndex = 3;
            this.headerPANEL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPANEL_MouseDown);
            this.headerPANEL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPANEL_MouseMove);
            this.headerPANEL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPANEL_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(678, 518);
            this.Controls.Add(this.headerPANEL);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fullBTN;
        private System.Windows.Forms.Panel headerPANEL;
    }
}

