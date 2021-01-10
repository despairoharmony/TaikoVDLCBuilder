namespace TaikoVDLCBuilder
{
    partial class DLCSelector
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
            this.RunButton = new System.Windows.Forms.Button();
            this.DBView = new System.Windows.Forms.DataGridView();
            this.genreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunPBar = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.RandomButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.isCheckedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameJPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starEasyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starNormalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starHardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starManiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starUraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DBView)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.RunButton.Location = new System.Drawing.Point(544, 0);
            this.RunButton.Margin = new System.Windows.Forms.Padding(1);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(100, 40);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // DBView
            // 
            this.DBView.AllowUserToAddRows = false;
            this.DBView.AllowUserToDeleteRows = false;
            this.DBView.AllowUserToOrderColumns = true;
            this.DBView.AutoGenerateColumns = false;
            this.DBView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isCheckedDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nameJPDataGridViewTextBoxColumn,
            this.folderDataGridViewTextBoxColumn,
            this.genreName,
            this.starEasyDataGridViewTextBoxColumn,
            this.starNormalDataGridViewTextBoxColumn,
            this.starHardDataGridViewTextBoxColumn,
            this.starManiaDataGridViewTextBoxColumn,
            this.starUraDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn});
            this.DBView.DataSource = this.songItemBindingSource;
            this.DBView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBView.Location = new System.Drawing.Point(0, 70);
            this.DBView.Margin = new System.Windows.Forms.Padding(1);
            this.DBView.Name = "DBView";
            this.DBView.RowTemplate.Height = 46;
            this.DBView.Size = new System.Drawing.Size(644, 356);
            this.DBView.TabIndex = 2;
            this.DBView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DBView_DataBindingComplete);
            // 
            // genreName
            // 
            this.genreName.DataPropertyName = "genreName";
            this.genreName.Frozen = true;
            this.genreName.HeaderText = "Genre";
            this.genreName.MinimumWidth = 40;
            this.genreName.Name = "genreName";
            this.genreName.ReadOnly = true;
            this.genreName.Width = 80;
            // 
            // RunPBar
            // 
            this.RunPBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RunPBar.Location = new System.Drawing.Point(0, 426);
            this.RunPBar.Margin = new System.Windows.Forms.Padding(2);
            this.RunPBar.Name = "RunPBar";
            this.RunPBar.Size = new System.Drawing.Size(644, 15);
            this.RunPBar.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // RandomButton
            // 
            this.RandomButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RandomButton.Location = new System.Drawing.Point(0, 0);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(100, 40);
            this.RandomButton.TabIndex = 4;
            this.RandomButton.Text = "Randomize";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClearButton.Location = new System.Drawing.Point(100, 0);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 40);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.RunButton);
            this.BottomPanel.Controls.Add(this.ClearButton);
            this.BottomPanel.Controls.Add(this.RandomButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 441);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(644, 40);
            this.BottomPanel.TabIndex = 6;
            // 
            // IntroLabel
            // 
            this.IntroLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IntroLabel.Location = new System.Drawing.Point(0, 0);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(644, 70);
            this.IntroLabel.TabIndex = 7;
            this.IntroLabel.Text = "Label";
            this.IntroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.IntroLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(644, 70);
            this.TopPanel.TabIndex = 8;
            // 
            // isCheckedDataGridViewCheckBoxColumn
            // 
            this.isCheckedDataGridViewCheckBoxColumn.DataPropertyName = "isChecked";
            this.isCheckedDataGridViewCheckBoxColumn.Frozen = true;
            this.isCheckedDataGridViewCheckBoxColumn.HeaderText = "Select";
            this.isCheckedDataGridViewCheckBoxColumn.MinimumWidth = 20;
            this.isCheckedDataGridViewCheckBoxColumn.Name = "isCheckedDataGridViewCheckBoxColumn";
            this.isCheckedDataGridViewCheckBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameJPDataGridViewTextBoxColumn
            // 
            this.nameJPDataGridViewTextBoxColumn.DataPropertyName = "nameJP";
            this.nameJPDataGridViewTextBoxColumn.Frozen = true;
            this.nameJPDataGridViewTextBoxColumn.HeaderText = "Japanese Name";
            this.nameJPDataGridViewTextBoxColumn.Name = "nameJPDataGridViewTextBoxColumn";
            this.nameJPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // folderDataGridViewTextBoxColumn
            // 
            this.folderDataGridViewTextBoxColumn.DataPropertyName = "folder";
            this.folderDataGridViewTextBoxColumn.HeaderText = "folder";
            this.folderDataGridViewTextBoxColumn.Name = "folderDataGridViewTextBoxColumn";
            this.folderDataGridViewTextBoxColumn.ReadOnly = true;
            this.folderDataGridViewTextBoxColumn.Visible = false;
            // 
            // starEasyDataGridViewTextBoxColumn
            // 
            this.starEasyDataGridViewTextBoxColumn.DataPropertyName = "strEasy";
            this.starEasyDataGridViewTextBoxColumn.Frozen = true;
            this.starEasyDataGridViewTextBoxColumn.HeaderText = "★ Easy";
            this.starEasyDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.starEasyDataGridViewTextBoxColumn.Name = "starEasyDataGridViewTextBoxColumn";
            this.starEasyDataGridViewTextBoxColumn.ReadOnly = true;
            this.starEasyDataGridViewTextBoxColumn.Width = 50;
            // 
            // starNormalDataGridViewTextBoxColumn
            // 
            this.starNormalDataGridViewTextBoxColumn.DataPropertyName = "strNormal";
            this.starNormalDataGridViewTextBoxColumn.Frozen = true;
            this.starNormalDataGridViewTextBoxColumn.HeaderText = "★ Normal";
            this.starNormalDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.starNormalDataGridViewTextBoxColumn.Name = "starNormalDataGridViewTextBoxColumn";
            this.starNormalDataGridViewTextBoxColumn.ReadOnly = true;
            this.starNormalDataGridViewTextBoxColumn.Width = 50;
            // 
            // starHardDataGridViewTextBoxColumn
            // 
            this.starHardDataGridViewTextBoxColumn.DataPropertyName = "strHard";
            this.starHardDataGridViewTextBoxColumn.Frozen = true;
            this.starHardDataGridViewTextBoxColumn.HeaderText = "★ Hard";
            this.starHardDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.starHardDataGridViewTextBoxColumn.Name = "starHardDataGridViewTextBoxColumn";
            this.starHardDataGridViewTextBoxColumn.ReadOnly = true;
            this.starHardDataGridViewTextBoxColumn.Width = 50;
            // 
            // starManiaDataGridViewTextBoxColumn
            // 
            this.starManiaDataGridViewTextBoxColumn.DataPropertyName = "strMania";
            this.starManiaDataGridViewTextBoxColumn.Frozen = true;
            this.starManiaDataGridViewTextBoxColumn.HeaderText = "★ Extreme";
            this.starManiaDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.starManiaDataGridViewTextBoxColumn.Name = "starManiaDataGridViewTextBoxColumn";
            this.starManiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.starManiaDataGridViewTextBoxColumn.Width = 50;
            // 
            // starUraDataGridViewTextBoxColumn
            // 
            this.starUraDataGridViewTextBoxColumn.DataPropertyName = "strUra";
            this.starUraDataGridViewTextBoxColumn.HeaderText = "★ Oni";
            this.starUraDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.starUraDataGridViewTextBoxColumn.Name = "starUraDataGridViewTextBoxColumn";
            this.starUraDataGridViewTextBoxColumn.ReadOnly = true;
            this.starUraDataGridViewTextBoxColumn.Width = 50;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceDataGridViewTextBoxColumn.Visible = false;
            // 
            // songItemBindingSource
            // 
            this.songItemBindingSource.DataSource = typeof(TaikoVDLCBuilder.SongItem);
            // 
            // DLCSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 481);
            this.Controls.Add(this.DBView);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.RunPBar);
            this.Controls.Add(this.BottomPanel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "DLCSelector";
            this.Text = "Taiko no Tatsujin V Version - DLC Builder";
            this.Load += new System.EventHandler(this.DLCSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBView)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.DataGridView DBView;
        private System.Windows.Forms.BindingSource songItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn previewDataGridViewTextBoxColumn;
        private System.Windows.Forms.ProgressBar RunPBar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCheckedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameJPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn starEasyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starNormalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starHardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starManiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starUraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.Panel TopPanel;
    }
}

