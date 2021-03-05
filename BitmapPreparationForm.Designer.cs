﻿namespace Cliver.PdfDocumentParser
{
    partial class BitmapPreparationForm
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
            this.bCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bApply = new System.Windows.Forms.Button();
            this.defaultBitmapPreprocessorClassDefinitions = new System.Windows.Forms.ComboBox();
            this.bRemove = new System.Windows.Forms.Button();
            this.bSaveDafault = new System.Windows.Forms.Button();
            this.bitmapPreprocessorClassDefinition = new ICSharpCode.TextEditor.TextEditorControl();
            this.label9 = new System.Windows.Forms.Label();
            this.DeskewBlockMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.Deskew = new System.Windows.Forms.CheckBox();
            this.PageRotation = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PreprocessBitmap = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ScalingAnchor = new System.Windows.Forms.ComboBox();
            this.CvImageScalePyramidStep = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.DeskewMinBlockSpan = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeskewBlockMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CvImageScalePyramidStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskewMinBlockSpan)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCancel.Location = new System.Drawing.Point(654, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 50;
            this.bCancel.Text = "Close";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancel);
            this.flowLayoutPanel1.Controls.Add(this.bApply);
            this.flowLayoutPanel1.Controls.Add(this.defaultBitmapPreprocessorClassDefinitions);
            this.flowLayoutPanel1.Controls.Add(this.bRemove);
            this.flowLayoutPanel1.Controls.Add(this.bSaveDafault);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 316);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(732, 31);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bApply.Location = new System.Drawing.Point(573, 3);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 23);
            this.bApply.TabIndex = 51;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // defaultBitmapPreprocessorClassDefinitions
            // 
            this.defaultBitmapPreprocessorClassDefinitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultBitmapPreprocessorClassDefinitions.FormattingEnabled = true;
            this.defaultBitmapPreprocessorClassDefinitions.Items.AddRange(new object[] {
            "",
            "↻ 90°",
            "↻ 180°",
            "↺ 90°",
            "Auto"});
            this.defaultBitmapPreprocessorClassDefinitions.Location = new System.Drawing.Point(346, 3);
            this.defaultBitmapPreprocessorClassDefinitions.Name = "defaultBitmapPreprocessorClassDefinitions";
            this.defaultBitmapPreprocessorClassDefinitions.Size = new System.Drawing.Size(221, 21);
            this.defaultBitmapPreprocessorClassDefinitions.TabIndex = 85;
            this.defaultBitmapPreprocessorClassDefinitions.SelectedIndexChanged += new System.EventHandler(this.defaults_SelectedIndexChanged);
            // 
            // bRemove
            // 
            this.bRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bRemove.Location = new System.Drawing.Point(306, 3);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(34, 23);
            this.bRemove.TabIndex = 52;
            this.bRemove.Text = "-";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bSaveDafault
            // 
            this.bSaveDafault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSaveDafault.Location = new System.Drawing.Point(266, 3);
            this.bSaveDafault.Name = "bSaveDafault";
            this.bSaveDafault.Size = new System.Drawing.Size(34, 23);
            this.bSaveDafault.TabIndex = 53;
            this.bSaveDafault.Text = "+";
            this.bSaveDafault.UseVisualStyleBackColor = true;
            this.bSaveDafault.Click += new System.EventHandler(this.bSaveDafault_Click);
            // 
            // bitmapPreprocessorClassDefinition
            // 
            this.bitmapPreprocessorClassDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitmapPreprocessorClassDefinition.AutoHideScrollbars = false;
            this.bitmapPreprocessorClassDefinition.Highlighting = null;
            this.bitmapPreprocessorClassDefinition.Location = new System.Drawing.Point(1, 97);
            this.bitmapPreprocessorClassDefinition.Margin = new System.Windows.Forms.Padding(1);
            this.bitmapPreprocessorClassDefinition.Name = "bitmapPreprocessorClassDefinition";
            this.bitmapPreprocessorClassDefinition.ShowVRuler = false;
            this.bitmapPreprocessorClassDefinition.Size = new System.Drawing.Size(732, 218);
            this.bitmapPreprocessorClassDefinition.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Preprocess:";
            // 
            // DeskewBlockMaxHeight
            // 
            this.DeskewBlockMaxHeight.Location = new System.Drawing.Point(436, 11);
            this.DeskewBlockMaxHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DeskewBlockMaxHeight.Name = "DeskewBlockMaxHeight";
            this.DeskewBlockMaxHeight.Size = new System.Drawing.Size(57, 20);
            this.DeskewBlockMaxHeight.TabIndex = 83;
            this.DeskewBlockMaxHeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Deskew
            // 
            this.Deskew.AutoSize = true;
            this.Deskew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deskew.Location = new System.Drawing.Point(258, 15);
            this.Deskew.Name = "Deskew";
            this.Deskew.Size = new System.Drawing.Size(15, 14);
            this.Deskew.TabIndex = 81;
            this.Deskew.UseVisualStyleBackColor = true;
            // 
            // PageRotation
            // 
            this.PageRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PageRotation.FormattingEnabled = true;
            this.PageRotation.Items.AddRange(new object[] {
            "",
            "↻ 90°",
            "↻ 180°",
            "↺ 90°",
            "Auto"});
            this.PageRotation.Location = new System.Drawing.Point(89, 11);
            this.PageRotation.Name = "PageRotation";
            this.PageRotation.Size = new System.Drawing.Size(52, 21);
            this.PageRotation.TabIndex = 80;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(208, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 84;
            this.label21.Text = "Deskew:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(299, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 13);
            this.label14.TabIndex = 82;
            this.label14.Text = "Deskew Block Max Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Rotate Pages:";
            // 
            // PreprocessBitmap
            // 
            this.PreprocessBitmap.AutoSize = true;
            this.PreprocessBitmap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PreprocessBitmap.Location = new System.Drawing.Point(77, 78);
            this.PreprocessBitmap.Name = "PreprocessBitmap";
            this.PreprocessBitmap.Size = new System.Drawing.Size(15, 14);
            this.PreprocessBitmap.TabIndex = 85;
            this.PreprocessBitmap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Rescale By Anchor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Preprocessing Code:";
            // 
            // ScalingAnchor
            // 
            this.ScalingAnchor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScalingAnchor.FormattingEnabled = true;
            this.ScalingAnchor.Items.AddRange(new object[] {
            "",
            "↻ 90°",
            "↻ 180°",
            "↺ 90°",
            "Auto"});
            this.ScalingAnchor.Location = new System.Drawing.Point(118, 44);
            this.ScalingAnchor.Name = "ScalingAnchor";
            this.ScalingAnchor.Size = new System.Drawing.Size(52, 21);
            this.ScalingAnchor.TabIndex = 89;
            // 
            // CvImageScalePyramidStep
            // 
            this.CvImageScalePyramidStep.Location = new System.Drawing.Point(303, 45);
            this.CvImageScalePyramidStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CvImageScalePyramidStep.Name = "CvImageScalePyramidStep";
            this.CvImageScalePyramidStep.Size = new System.Drawing.Size(35, 20);
            this.CvImageScalePyramidStep.TabIndex = 94;
            this.CvImageScalePyramidStep.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(195, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 13);
            this.label19.TabIndex = 93;
            this.label19.Text = "Scale Pyramid Step:";
            // 
            // DeskewMinBlockSpan
            // 
            this.DeskewMinBlockSpan.Location = new System.Drawing.Point(650, 11);
            this.DeskewMinBlockSpan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DeskewMinBlockSpan.Name = "DeskewMinBlockSpan";
            this.DeskewMinBlockSpan.Size = new System.Drawing.Size(46, 20);
            this.DeskewMinBlockSpan.TabIndex = 96;
            this.DeskewMinBlockSpan.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Deskew Block Max Height:";
            // 
            // BitmapPreparationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 347);
            this.Controls.Add(this.DeskewMinBlockSpan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CvImageScalePyramidStep);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ScalingAnchor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PreprocessBitmap);
            this.Controls.Add(this.DeskewBlockMaxHeight);
            this.Controls.Add(this.Deskew);
            this.Controls.Add(this.PageRotation);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitmapPreprocessorClassDefinition);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BitmapPreparationForm";
            this.Text = "Scanned Document Settings";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeskewBlockMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CvImageScalePyramidStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskewMinBlockSpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bApply;
        private ICSharpCode.TextEditor.TextEditorControl bitmapPreprocessorClassDefinition;
        private System.Windows.Forms.NumericUpDown DeskewBlockMaxHeight;
        private System.Windows.Forms.CheckBox Deskew;
        private System.Windows.Forms.ComboBox PageRotation;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bSaveDafault;
        private System.Windows.Forms.ComboBox defaultBitmapPreprocessorClassDefinitions;
        private System.Windows.Forms.CheckBox PreprocessBitmap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ScalingAnchor;
        private System.Windows.Forms.NumericUpDown CvImageScalePyramidStep;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown DeskewMinBlockSpan;
        private System.Windows.Forms.Label label4;
    }
}