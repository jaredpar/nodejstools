﻿namespace Microsoft.NodejsTools.Options {
    partial class NodejsGeneralOptionsControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._surveyNewsCheckLabel = new System.Windows.Forms.Label();
            this._surveyNewsCheckCombo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this._surveyNewsCheckLabel, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this._surveyNewsCheckCombo, 1, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(381, 290);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // _surveyNewsCheckLabel
            // 
            this._surveyNewsCheckLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._surveyNewsCheckLabel.AutoSize = true;
            this._surveyNewsCheckLabel.Location = new System.Drawing.Point(6, 7);
            this._surveyNewsCheckLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._surveyNewsCheckLabel.Name = "_surveyNewsCheckLabel";
            this._surveyNewsCheckLabel.Size = new System.Drawing.Size(117, 13);
            this._surveyNewsCheckLabel.TabIndex = 6;
            this._surveyNewsCheckLabel.Text = "&Check for survey/news";
            this._surveyNewsCheckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _surveyNewsCheckCombo
            // 
            this._surveyNewsCheckCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._surveyNewsCheckCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._surveyNewsCheckCombo.DropDownWidth = 172;
            this._surveyNewsCheckCombo.FormattingEnabled = true;
            this._surveyNewsCheckCombo.Items.AddRange(new object[] {
            "Never",
            "Once a day",
            "Once a week",
            "Once a month"});
            this._surveyNewsCheckCombo.Location = new System.Drawing.Point(135, 3);
            this._surveyNewsCheckCombo.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this._surveyNewsCheckCombo.Name = "_surveyNewsCheckCombo";
            this._surveyNewsCheckCombo.Size = new System.Drawing.Size(240, 21);
            this._surveyNewsCheckCombo.TabIndex = 7;
            this._surveyNewsCheckCombo.SelectedIndexChanged += new System.EventHandler(this._surveyNewsCheckCombo_SelectedIndexChanged);
            // 
            // PythonGeneralOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "PythonGeneralOptionsControl";
            this.Size = new System.Drawing.Size(381, 290);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label _surveyNewsCheckLabel;
        private System.Windows.Forms.ComboBox _surveyNewsCheckCombo;
    }
}