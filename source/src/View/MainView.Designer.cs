﻿namespace REAPERJapanesePatcher
{
    partial class MainView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BrowseReaperButton = new System.Windows.Forms.Button();
            this.TargetReaperLabel = new System.Windows.Forms.Label();
            this.FontFixCheck = new System.Windows.Forms.CheckBox();
            this.IncludeAllCheck = new System.Windows.Forms.CheckBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.TargetReaperBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.AuthorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.ReaperBrowseDialog = new System.Windows.Forms.OpenFileDialog();
            this.MastarLangPackRadio = new System.Windows.Forms.RadioButton();
            this.TranslationLangPackRadio = new System.Windows.Forms.RadioButton();
            this.LangPackSelectGroup = new System.Windows.Forms.GroupBox();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.LangPackSelectGroup.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseReaperButton
            // 
            this.BrowseReaperButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseReaperButton.Location = new System.Drawing.Point(482, 13);
            this.BrowseReaperButton.Name = "BrowseReaperButton";
            this.BrowseReaperButton.Size = new System.Drawing.Size(77, 23);
            this.BrowseReaperButton.TabIndex = 0;
            this.BrowseReaperButton.Text = "変更";
            this.BrowseReaperButton.UseVisualStyleBackColor = true;
            this.BrowseReaperButton.Click += new System.EventHandler(this.BrowseReaperButton_Click);
            // 
            // TargetReaperLabel
            // 
            this.TargetReaperLabel.AutoSize = true;
            this.TargetReaperLabel.Location = new System.Drawing.Point(0, 0);
            this.TargetReaperLabel.Name = "TargetReaperLabel";
            this.TargetReaperLabel.Size = new System.Drawing.Size(112, 12);
            this.TargetReaperLabel.TabIndex = 1;
            this.TargetReaperLabel.Text = "対象とする reaper.exe";
            // 
            // FontFixCheck
            // 
            this.FontFixCheck.AutoSize = true;
            this.FontFixCheck.Location = new System.Drawing.Point(5, 40);
            this.FontFixCheck.Name = "FontFixCheck";
            this.FontFixCheck.Size = new System.Drawing.Size(179, 16);
            this.FontFixCheck.TabIndex = 2;
            this.FontFixCheck.Text = "フォントとフォントサイズも修正する";
            this.FontFixCheck.UseVisualStyleBackColor = true;
            this.FontFixCheck.CheckedChanged += new System.EventHandler(this.FontFixCheck_CheckedChanged);
            // 
            // IncludeAllCheck
            // 
            this.IncludeAllCheck.AutoSize = true;
            this.IncludeAllCheck.Location = new System.Drawing.Point(5, 62);
            this.IncludeAllCheck.Name = "IncludeAllCheck";
            this.IncludeAllCheck.Size = new System.Drawing.Size(185, 16);
            this.IncludeAllCheck.TabIndex = 3;
            this.IncludeAllCheck.Text = "Plugins フォルダ以下も対象にする";
            this.IncludeAllCheck.UseVisualStyleBackColor = true;
            this.IncludeAllCheck.CheckedChanged += new System.EventHandler(this.IncludeAllCheck_CheckedChanged);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.Location = new System.Drawing.Point(499, 217);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 6;
            this.ExecuteButton.Text = "実行";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // TargetReaperBox
            // 
            this.TargetReaperBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetReaperBox.Location = new System.Drawing.Point(2, 15);
            this.TargetReaperBox.Name = "TargetReaperBox";
            this.TargetReaperBox.Size = new System.Drawing.Size(474, 19);
            this.TargetReaperBox.TabIndex = 7;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(12, 188);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(562, 23);
            this.ProgressBar.TabIndex = 8;
            // 
            // AuthorLinkLabel
            // 
            this.AuthorLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AuthorLinkLabel.AutoSize = true;
            this.AuthorLinkLabel.Location = new System.Drawing.Point(12, 222);
            this.AuthorLinkLabel.Name = "AuthorLinkLabel";
            this.AuthorLinkLabel.Size = new System.Drawing.Size(78, 12);
            this.AuthorLinkLabel.TabIndex = 9;
            this.AuthorLinkLabel.TabStop = true;
            this.AuthorLinkLabel.Text = "by chiepomme";
            this.AuthorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorLinkLabel_LinkClicked);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(12, 173);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(53, 12);
            this.ProgressLabel.TabIndex = 10;
            this.ProgressLabel.Text = "進行状況";
            // 
            // ReaperBrowseDialog
            // 
            this.ReaperBrowseDialog.DefaultExt = "exe";
            this.ReaperBrowseDialog.FileName = "reaper.exe";
            this.ReaperBrowseDialog.Title = "reaper.exe を選択してください";
            // 
            // MastarLangPackRadio
            // 
            this.MastarLangPackRadio.AutoSize = true;
            this.MastarLangPackRadio.Checked = true;
            this.MastarLangPackRadio.Location = new System.Drawing.Point(9, 18);
            this.MastarLangPackRadio.Name = "MastarLangPackRadio";
            this.MastarLangPackRadio.Size = new System.Drawing.Size(178, 16);
            this.MastarLangPackRadio.TabIndex = 11;
            this.MastarLangPackRadio.TabStop = true;
            this.MastarLangPackRadio.Text = "安定バージョン (master ブランチ)";
            this.MastarLangPackRadio.UseVisualStyleBackColor = true;
            this.MastarLangPackRadio.CheckedChanged += new System.EventHandler(this.LangPackRadio_CheckedChanged);
            // 
            // TranslationLangPackRadio
            // 
            this.TranslationLangPackRadio.AutoSize = true;
            this.TranslationLangPackRadio.Location = new System.Drawing.Point(9, 40);
            this.TranslationLangPackRadio.Name = "TranslationLangPackRadio";
            this.TranslationLangPackRadio.Size = new System.Drawing.Size(209, 16);
            this.TranslationLangPackRadio.TabIndex = 12;
            this.TranslationLangPackRadio.Text = "開発中バージョン (translation ブランチ)";
            this.TranslationLangPackRadio.UseVisualStyleBackColor = true;
            this.TranslationLangPackRadio.CheckedChanged += new System.EventHandler(this.LangPackRadio_CheckedChanged);
            // 
            // LangPackSelectGroup
            // 
            this.LangPackSelectGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LangPackSelectGroup.Controls.Add(this.MastarLangPackRadio);
            this.LangPackSelectGroup.Controls.Add(this.TranslationLangPackRadio);
            this.LangPackSelectGroup.Location = new System.Drawing.Point(5, 84);
            this.LangPackSelectGroup.Name = "LangPackSelectGroup";
            this.LangPackSelectGroup.Size = new System.Drawing.Size(554, 63);
            this.LangPackSelectGroup.TabIndex = 13;
            this.LangPackSelectGroup.TabStop = false;
            this.LangPackSelectGroup.Text = "インストールする日本語化パック";
            // 
            // SettingPanel
            // 
            this.SettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingPanel.Controls.Add(this.TargetReaperLabel);
            this.SettingPanel.Controls.Add(this.LangPackSelectGroup);
            this.SettingPanel.Controls.Add(this.BrowseReaperButton);
            this.SettingPanel.Controls.Add(this.IncludeAllCheck);
            this.SettingPanel.Controls.Add(this.FontFixCheck);
            this.SettingPanel.Controls.Add(this.TargetReaperBox);
            this.SettingPanel.Location = new System.Drawing.Point(12, 12);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(562, 149);
            this.SettingPanel.TabIndex = 14;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 252);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.AuthorLinkLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ExecuteButton);
            this.MinimumSize = new System.Drawing.Size(600, 290);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REAPER 日本語化パッチ";
            this.LangPackSelectGroup.ResumeLayout(false);
            this.LangPackSelectGroup.PerformLayout();
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseReaperButton;
        private System.Windows.Forms.Label TargetReaperLabel;
        private System.Windows.Forms.CheckBox FontFixCheck;
        private System.Windows.Forms.CheckBox IncludeAllCheck;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox TargetReaperBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.LinkLabel AuthorLinkLabel;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.OpenFileDialog ReaperBrowseDialog;
        private System.Windows.Forms.RadioButton MastarLangPackRadio;
        private System.Windows.Forms.RadioButton TranslationLangPackRadio;
        private System.Windows.Forms.GroupBox LangPackSelectGroup;
        private System.Windows.Forms.Panel SettingPanel;
    }
}

