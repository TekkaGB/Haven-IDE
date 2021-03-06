﻿namespace IDE_test
{
    partial class test_IDE
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new FontAwesome.Sharp.IconToolStripButton();
            this.settingsButon = new FontAwesome.Sharp.IconToolStripButton();
            this.openToolStripButton = new FontAwesome.Sharp.IconToolStripButton();
            this.saveToolStripButton = new FontAwesome.Sharp.IconToolStripButton();
            this.cutToolStripButton = new FontAwesome.Sharp.IconToolStripButton();
            this.copyToolStripButton = new FontAwesome.Sharp.IconToolStripButton();
            this.pasteToolStripButton = new FontAwesome.Sharp.IconToolStripButton();
            this.undoButton = new FontAwesome.Sharp.IconToolStripButton();
            this.redoButton2 = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.debugStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.gameComboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestWindowButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.compileButton = new FontAwesome.Sharp.IconButton();
            this.decompileButton = new FontAwesome.Sharp.IconButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.settingsButon,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.undoButton,
            this.redoButton2,
            this.toolStripSeparator,
            this.debugStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(627, 30);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.IconChar = FontAwesome.Sharp.IconChar.File;
            this.newToolStripButton.IconColor = System.Drawing.Color.Orange;
            this.newToolStripButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.newToolStripButton.IconSize = 25;
            this.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 29);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // settingsButon
            // 
            this.settingsButon.AutoSize = false;
            this.settingsButon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsButon.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.settingsButon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.settingsButon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButon.IconSize = 23;
            this.settingsButon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsButon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButon.Name = "settingsButon";
            this.settingsButon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingsButon.Size = new System.Drawing.Size(29, 29);
            this.settingsButon.Text = "settings";
            this.settingsButon.Click += new System.EventHandler(this.settingsButon_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.openToolStripButton.IconColor = System.Drawing.Color.Navy;
            this.openToolStripButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.openToolStripButton.IconSize = 25;
            this.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 29);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveToolStripButton.IconColor = System.Drawing.Color.YellowGreen;
            this.saveToolStripButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveToolStripButton.IconSize = 25;
            this.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 29);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.cutToolStripButton.IconColor = System.Drawing.Color.Crimson;
            this.cutToolStripButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cutToolStripButton.IconSize = 25;
            this.cutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(29, 29);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.copyToolStripButton.IconColor = System.Drawing.Color.DarkTurquoise;
            this.copyToolStripButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.copyToolStripButton.IconSize = 25;
            this.copyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 29);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.pasteToolStripButton.IconColor = System.Drawing.Color.DarkOrange;
            this.pasteToolStripButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pasteToolStripButton.IconSize = 25;
            this.pasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 29);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoButton.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.undoButton.IconColor = System.Drawing.Color.Brown;
            this.undoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.undoButton.IconSize = 25;
            this.undoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(29, 29);
            this.undoButton.Text = "toolStripButton2";
            this.undoButton.ToolTipText = "Undo";
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton2
            // 
            this.redoButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoButton2.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.redoButton2.IconColor = System.Drawing.Color.SeaGreen;
            this.redoButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.redoButton2.IconSize = 25;
            this.redoButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.redoButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoButton2.Name = "redoButton2";
            this.redoButton2.Size = new System.Drawing.Size(29, 29);
            this.redoButton2.Text = "toolStripButton2";
            this.redoButton2.ToolTipText = "Redo";
            this.redoButton2.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // debugStripButton1
            // 
            this.debugStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.debugStripButton1.IconChar = FontAwesome.Sharp.IconChar.Carrot;
            this.debugStripButton1.IconColor = System.Drawing.Color.OrangeRed;
            this.debugStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.debugStripButton1.IconSize = 25;
            this.debugStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.debugStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.debugStripButton1.Name = "debugStripButton1";
            this.debugStripButton1.Size = new System.Drawing.Size(29, 29);
            this.debugStripButton1.ToolTipText = "WIP";
            // 
            // gameComboBox2
            // 
            this.gameComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameComboBox2.BackColor = System.Drawing.Color.DarkGray;
            this.gameComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameComboBox2.FormattingEnabled = true;
            this.gameComboBox2.IntegralHeight = false;
            this.gameComboBox2.Location = new System.Drawing.Point(449, 12);
            this.gameComboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameComboBox2.Name = "gameComboBox2";
            this.gameComboBox2.Size = new System.Drawing.Size(140, 23);
            this.gameComboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(401, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "game:";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 275);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.drawCloseButton);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabControl1_MouseDown);
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.openToolStripMenuItem2,
            this.saveToolStripMenuItem2,
            this.saveAsToolStripMenuItem2,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 26);
            this.fileToolStripMenuItem2.Text = "&File";
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.newToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.newToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.newToolStripMenuItem2.Text = "&New";
            this.newToolStripMenuItem2.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem2
            // 
            this.openToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.openToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.openToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            this.openToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.openToolStripMenuItem2.Text = "&Open";
            this.openToolStripMenuItem2.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.saveToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem2.Text = "&Save";
            // 
            // saveAsToolStripMenuItem2
            // 
            this.saveAsToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.saveAsToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.saveAsToolStripMenuItem2.Name = "saveAsToolStripMenuItem2";
            this.saveAsToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.saveAsToolStripMenuItem2.Text = "Save &As";
            this.saveAsToolStripMenuItem2.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.exitToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem2.Text = "E&xit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(39, 26);
            this.editToolStripMenuItem2.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.undoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.redoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.copyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.selectAllToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // TestWindowButton
            // 
            this.TestWindowButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TestWindowButton.Name = "TestWindowButton";
            this.TestWindowButton.Size = new System.Drawing.Size(86, 26);
            this.TestWindowButton.Text = "Test Window";
            this.TestWindowButton.Visible = false;
            this.TestWindowButton.Click += new System.EventHandler(this.TestWindowButton_Click_1);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2,
            this.editToolStripMenuItem2,
            this.TestWindowButton});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(627, 30);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // compileButton
            // 
            this.compileButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.compileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(73)))), ((int)(((byte)(60)))));
            this.compileButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.compileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compileButton.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.compileButton.IconColor = System.Drawing.Color.Black;
            this.compileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.compileButton.IconSize = 20;
            this.compileButton.Location = new System.Drawing.Point(205, 2);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(87, 28);
            this.compileButton.TabIndex = 7;
            this.compileButton.Text = "Compile";
            this.compileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.compileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.compileButton.UseVisualStyleBackColor = false;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // decompileButton
            // 
            this.decompileButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decompileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.decompileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decompileButton.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.decompileButton.IconColor = System.Drawing.Color.Black;
            this.decompileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.decompileButton.IconSize = 20;
            this.decompileButton.Location = new System.Drawing.Point(298, 2);
            this.decompileButton.Name = "decompileButton";
            this.decompileButton.Size = new System.Drawing.Size(97, 28);
            this.decompileButton.TabIndex = 8;
            this.decompileButton.Text = "Decompile";
            this.decompileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.decompileButton.UseVisualStyleBackColor = false;
            this.decompileButton.Click += new System.EventHandler(this.decompileButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 179);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(627, 156);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // test_IDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(627, 335);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.decompileButton);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameComboBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(643, 374);
            this.Name = "test_IDE";
            this.Text = "Haven - IDE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.test_IDE_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton newToolStripButton;
        private FontAwesome.Sharp.IconToolStripButton openToolStripButton;
        private FontAwesome.Sharp.IconToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private FontAwesome.Sharp.IconToolStripButton cutToolStripButton;
        private FontAwesome.Sharp.IconToolStripButton copyToolStripButton;
        private FontAwesome.Sharp.IconToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private FontAwesome.Sharp.IconToolStripButton undoButton;
        private FontAwesome.Sharp.IconToolStripButton redoButton2;
        private System.Windows.Forms.ComboBox gameComboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private FontAwesome.Sharp.IconToolStripButton settingsButon;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private FontAwesome.Sharp.IconToolStripButton copyToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton pasteToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private FontAwesome.Sharp.IconToolStripButton helpToolStripButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestWindowButton;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconButton compileButton;
        private FontAwesome.Sharp.IconButton decompileButton;
        private FontAwesome.Sharp.IconToolStripButton debugStripButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

