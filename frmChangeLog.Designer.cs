﻿namespace LaraAlvaroProjectA
{
    partial class frmChangeLog
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
            this.crvChangeLog = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvChangeLog
            // 
            this.crvChangeLog.ActiveViewIndex = -1;
            this.crvChangeLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvChangeLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvChangeLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvChangeLog.Location = new System.Drawing.Point(0, 0);
            this.crvChangeLog.Name = "crvChangeLog";
            this.crvChangeLog.ShowGroupTreeButton = false;
            this.crvChangeLog.ShowParameterPanelButton = false;
            this.crvChangeLog.Size = new System.Drawing.Size(800, 450);
            this.crvChangeLog.TabIndex = 0;
            this.crvChangeLog.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvChangeLog);
            this.Name = "frmChangeLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Log";
            this.Load += new System.EventHandler(this.frmChangeLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvChangeLog;
    }
}