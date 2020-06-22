namespace LibrarySystem_Final.LibraryForm
{
    partial class FormManage
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
            this.operationPanel = new System.Windows.Forms.Panel();
            this.shelfPanel = new System.Windows.Forms.Panel();
            this.shelfDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addShelfButton = new System.Windows.Forms.Button();
            this.deleteShelfButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.detailButton = new System.Windows.Forms.Button();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.finishButton = new System.Windows.Forms.Button();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookShelfIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookShelfIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationPanel.SuspendLayout();
            this.shelfPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shelfDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // operationPanel
            // 
            this.operationPanel.Controls.Add(this.finishButton);
            this.operationPanel.Controls.Add(this.refreshButton);
            this.operationPanel.Controls.Add(this.sortButton);
            this.operationPanel.Controls.Add(this.searchTextBox);
            this.operationPanel.Controls.Add(this.searchComboBox);
            this.operationPanel.Controls.Add(this.searchPictureBox);
            this.operationPanel.Controls.Add(this.detailButton);
            this.operationPanel.Controls.Add(this.deleteBookButton);
            this.operationPanel.Controls.Add(this.addBookButton);
            this.operationPanel.Controls.Add(this.deleteShelfButton);
            this.operationPanel.Controls.Add(this.addShelfButton);
            this.operationPanel.Location = new System.Drawing.Point(12, 12);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(1011, 59);
            this.operationPanel.TabIndex = 0;
            // 
            // shelfPanel
            // 
            this.shelfPanel.Controls.Add(this.shelfDataGridView);
            this.shelfPanel.Location = new System.Drawing.Point(12, 77);
            this.shelfPanel.Name = "shelfPanel";
            this.shelfPanel.Size = new System.Drawing.Size(245, 366);
            this.shelfPanel.TabIndex = 1;
            // 
            // shelfDataGridView
            // 
            this.shelfDataGridView.AutoGenerateColumns = false;
            this.shelfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shelfDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookShelfIdDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn});
            this.shelfDataGridView.DataSource = this.shelfBindingSource;
            this.shelfDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shelfDataGridView.Location = new System.Drawing.Point(0, 0);
            this.shelfDataGridView.Name = "shelfDataGridView";
            this.shelfDataGridView.RowTemplate.Height = 23;
            this.shelfDataGridView.Size = new System.Drawing.Size(245, 366);
            this.shelfDataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(263, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 366);
            this.panel1.TabIndex = 2;
            // 
            // addShelfButton
            // 
            this.addShelfButton.Location = new System.Drawing.Point(3, 3);
            this.addShelfButton.Name = "addShelfButton";
            this.addShelfButton.Size = new System.Drawing.Size(75, 23);
            this.addShelfButton.TabIndex = 0;
            this.addShelfButton.Text = "添加书架";
            this.addShelfButton.UseVisualStyleBackColor = true;
            this.addShelfButton.Click += new System.EventHandler(this.addShelfButton_Click);
            // 
            // deleteShelfButton
            // 
            this.deleteShelfButton.Location = new System.Drawing.Point(84, 3);
            this.deleteShelfButton.Name = "deleteShelfButton";
            this.deleteShelfButton.Size = new System.Drawing.Size(75, 23);
            this.deleteShelfButton.TabIndex = 1;
            this.deleteShelfButton.Text = "删除书架";
            this.deleteShelfButton.UseVisualStyleBackColor = true;
            this.deleteShelfButton.Click += new System.EventHandler(this.deleteShelfButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(251, 3);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 2;
            this.addBookButton.Text = "添加书籍";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Location = new System.Drawing.Point(332, 3);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(75, 23);
            this.deleteBookButton.TabIndex = 3;
            this.deleteBookButton.Text = "删除图书";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // detailButton
            // 
            this.detailButton.Location = new System.Drawing.Point(251, 32);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(156, 23);
            this.detailButton.TabIndex = 4;
            this.detailButton.Text = "修改书籍详情";
            this.detailButton.UseVisualStyleBackColor = true;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Image = global::LibrarySystem_Final.Properties.Resources.查询;
            this.searchPictureBox.Location = new System.Drawing.Point(534, 3);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(53, 50);
            this.searchPictureBox.TabIndex = 5;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchPictureBox_Click);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "书号",
            "书名",
            "作者",
            "分类"});
            this.searchComboBox.Location = new System.Drawing.Point(593, 5);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(100, 20);
            this.searchComboBox.TabIndex = 6;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(593, 34);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 21);
            this.searchTextBox.TabIndex = 7;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(775, 3);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(118, 23);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "改为按分类管理";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(775, 32);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(118, 23);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "刷新";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Books";
            this.bookBindingSource.DataSource = this.shelfBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.sortDataGridViewTextBoxColumn,
            this.recommendDataGridViewTextBoxColumn,
            this.bookShelfIdDataGridViewTextBoxColumn1,
            this.stateDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.lendTimeDataGridViewTextBoxColumn,
            this.appointersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(760, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(899, 3);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(109, 50);
            this.finishButton.TabIndex = 10;
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
            this.nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 65;
            // 
            // sortDataGridViewTextBoxColumn
            // 
            this.sortDataGridViewTextBoxColumn.DataPropertyName = "Sort";
            this.sortDataGridViewTextBoxColumn.HeaderText = "分类";
            this.sortDataGridViewTextBoxColumn.Name = "sortDataGridViewTextBoxColumn";
            this.sortDataGridViewTextBoxColumn.Width = 65;
            // 
            // recommendDataGridViewTextBoxColumn
            // 
            this.recommendDataGridViewTextBoxColumn.DataPropertyName = "Recommend";
            this.recommendDataGridViewTextBoxColumn.HeaderText = "推荐数";
            this.recommendDataGridViewTextBoxColumn.Name = "recommendDataGridViewTextBoxColumn";
            this.recommendDataGridViewTextBoxColumn.Width = 60;
            // 
            // bookShelfIdDataGridViewTextBoxColumn1
            // 
            this.bookShelfIdDataGridViewTextBoxColumn1.DataPropertyName = "BookShelfId";
            this.bookShelfIdDataGridViewTextBoxColumn1.HeaderText = "书架号";
            this.bookShelfIdDataGridViewTextBoxColumn1.Name = "bookShelfIdDataGridViewTextBoxColumn1";
            this.bookShelfIdDataGridViewTextBoxColumn1.Width = 60;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "状态";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 70;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "使用人";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // lendTimeDataGridViewTextBoxColumn
            // 
            this.lendTimeDataGridViewTextBoxColumn.DataPropertyName = "LendTime";
            this.lendTimeDataGridViewTextBoxColumn.HeaderText = "到期时间";
            this.lendTimeDataGridViewTextBoxColumn.Name = "lendTimeDataGridViewTextBoxColumn";
            this.lendTimeDataGridViewTextBoxColumn.Width = 90;
            // 
            // appointersDataGridViewTextBoxColumn
            // 
            this.appointersDataGridViewTextBoxColumn.DataPropertyName = "Appointers";
            this.appointersDataGridViewTextBoxColumn.HeaderText = "预约人";
            this.appointersDataGridViewTextBoxColumn.Name = "appointersDataGridViewTextBoxColumn";
            this.appointersDataGridViewTextBoxColumn.Width = 95;
            // 
            // shelfBindingSource
            // 
            this.shelfBindingSource.DataSource = typeof(LibrarySystem_Final.BookShelf);
            // 
            // bookShelfIdDataGridViewTextBoxColumn
            // 
            this.bookShelfIdDataGridViewTextBoxColumn.DataPropertyName = "BookShelfId";
            this.bookShelfIdDataGridViewTextBoxColumn.HeaderText = "书架号";
            this.bookShelfIdDataGridViewTextBoxColumn.Name = "bookShelfIdDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "书籍数量";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shelfPanel);
            this.Controls.Add(this.operationPanel);
            this.Name = "FormManage";
            this.Text = "管理图书";
            this.operationPanel.ResumeLayout(false);
            this.operationPanel.PerformLayout();
            this.shelfPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shelfDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.Panel shelfPanel;
        private System.Windows.Forms.DataGridView shelfDataGridView;
        private System.Windows.Forms.BindingSource shelfBindingSource;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.Button detailButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button deleteShelfButton;
        private System.Windows.Forms.Button addShelfButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookShelfIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookShelfIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Button finishButton;
    }
}