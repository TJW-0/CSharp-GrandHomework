namespace LibrarySystem_Final.LibraryForm
{
    partial class FormLibrary
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
            this.bookPanel = new System.Windows.Forms.Panel();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.detailButton = new System.Windows.Forms.Button();
            this.queryComboBox = new System.Windows.Forms.ComboBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookShelfIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.operationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookPanel
            // 
            this.bookPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookPanel.Controls.Add(this.bookDataGridView);
            this.bookPanel.Location = new System.Drawing.Point(12, 61);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(776, 383);
            this.bookPanel.TabIndex = 0;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AutoGenerateColumns = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.sortDataGridViewTextBoxColumn,
            this.recommendDataGridViewTextBoxColumn,
            this.bookShelfIdDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.lendTimeDataGridViewTextBoxColumn,
            this.appointersDataGridViewTextBoxColumn});
            this.bookDataGridView.DataSource = this.bookBindingSource;
            this.bookDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowTemplate.Height = 23;
            this.bookDataGridView.Size = new System.Drawing.Size(776, 383);
            this.bookDataGridView.TabIndex = 0;
            // 
            // operationPanel
            // 
            this.operationPanel.Controls.Add(this.searchPictureBox);
            this.operationPanel.Controls.Add(this.detailButton);
            this.operationPanel.Controls.Add(this.queryComboBox);
            this.operationPanel.Controls.Add(this.queryButton);
            this.operationPanel.Controls.Add(this.searchTextBox);
            this.operationPanel.Controls.Add(this.searchComboBox);
            this.operationPanel.Controls.Add(this.finishButton);
            this.operationPanel.Location = new System.Drawing.Point(12, 4);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(776, 51);
            this.operationPanel.TabIndex = 1;
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Image = global::LibrarySystem_Final.Properties.Resources.查询;
            this.searchPictureBox.Location = new System.Drawing.Point(19, 0);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(54, 51);
            this.searchPictureBox.TabIndex = 7;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchPictureBox_Click);
            // 
            // detailButton
            // 
            this.detailButton.Location = new System.Drawing.Point(617, 10);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(75, 23);
            this.detailButton.TabIndex = 6;
            this.detailButton.Text = "查看细节";
            this.detailButton.UseVisualStyleBackColor = true;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
            // 
            // queryComboBox
            // 
            this.queryComboBox.FormattingEnabled = true;
            this.queryComboBox.Items.AddRange(new object[] {
            "推荐数",
            "书号",
            "作者",
            "分类",
            "书架号"});
            this.queryComboBox.Location = new System.Drawing.Point(405, 12);
            this.queryComboBox.Name = "queryComboBox";
            this.queryComboBox.Size = new System.Drawing.Size(73, 20);
            this.queryComboBox.TabIndex = 5;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(324, 10);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(75, 23);
            this.queryButton.TabIndex = 4;
            this.queryButton.Text = "排序";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(163, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 21);
            this.searchTextBox.TabIndex = 3;
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "书号",
            "书名",
            "作者",
            "分类",
            "书架号"});
            this.searchComboBox.Location = new System.Drawing.Point(84, 10);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(73, 20);
            this.searchComboBox.TabIndex = 2;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(698, 10);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 1;
            this.finishButton.Text = "完成";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "书号";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "书名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 75;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 75;
            // 
            // sortDataGridViewTextBoxColumn
            // 
            this.sortDataGridViewTextBoxColumn.DataPropertyName = "Sort";
            this.sortDataGridViewTextBoxColumn.HeaderText = "分类";
            this.sortDataGridViewTextBoxColumn.Name = "sortDataGridViewTextBoxColumn";
            this.sortDataGridViewTextBoxColumn.Width = 75;
            // 
            // recommendDataGridViewTextBoxColumn
            // 
            this.recommendDataGridViewTextBoxColumn.DataPropertyName = "Recommend";
            this.recommendDataGridViewTextBoxColumn.HeaderText = "推荐数";
            this.recommendDataGridViewTextBoxColumn.Name = "recommendDataGridViewTextBoxColumn";
            this.recommendDataGridViewTextBoxColumn.Width = 60;
            // 
            // bookShelfIdDataGridViewTextBoxColumn
            // 
            this.bookShelfIdDataGridViewTextBoxColumn.DataPropertyName = "BookShelfId";
            this.bookShelfIdDataGridViewTextBoxColumn.HeaderText = "书架号";
            this.bookShelfIdDataGridViewTextBoxColumn.Name = "bookShelfIdDataGridViewTextBoxColumn";
            this.bookShelfIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "状态";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 75;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "使用人";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // lendTimeDataGridViewTextBoxColumn
            // 
            this.lendTimeDataGridViewTextBoxColumn.DataPropertyName = "LendTime";
            this.lendTimeDataGridViewTextBoxColumn.HeaderText = "到期时间";
            this.lendTimeDataGridViewTextBoxColumn.Name = "lendTimeDataGridViewTextBoxColumn";
            this.lendTimeDataGridViewTextBoxColumn.Width = 85;
            // 
            // appointersDataGridViewTextBoxColumn
            // 
            this.appointersDataGridViewTextBoxColumn.DataPropertyName = "Appointers";
            this.appointersDataGridViewTextBoxColumn.HeaderText = "预约人";
            this.appointersDataGridViewTextBoxColumn.Name = "appointersDataGridViewTextBoxColumn";
            this.appointersDataGridViewTextBoxColumn.Width = 93;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(LibrarySystem_Final.Book);
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.operationPanel);
            this.Controls.Add(this.bookPanel);
            this.Name = "FormLibrary";
            this.Text = "馆内藏书";
            this.bookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.operationPanel.ResumeLayout(false);
            this.operationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookShelfIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Button detailButton;
        private System.Windows.Forms.ComboBox queryComboBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.PictureBox searchPictureBox;
    }
}