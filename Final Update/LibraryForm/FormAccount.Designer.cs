namespace LibrarySystem_Final.LibraryForm
{
    partial class FormAccount
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
            this.appointPanel = new System.Windows.Forms.Panel();
            this.appointOperationPanel = new System.Windows.Forms.Panel();
            this.detailButton1 = new System.Windows.Forms.Button();
            this.appointLabel = new System.Windows.Forms.Label();
            this.cancellButton = new System.Windows.Forms.Button();
            this.appointBookPanel = new System.Windows.Forms.Panel();
            this.appointDataGridView = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookShelfIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendPanel = new System.Windows.Forms.Panel();
            this.lendOperationPanel = new System.Windows.Forms.Panel();
            this.detailButton2 = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.lendLabel = new System.Windows.Forms.Label();
            this.lendBookPanel = new System.Windows.Forms.Panel();
            this.lendDataGridView = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reNewNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookShelfIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountPanel = new System.Windows.Forms.Panel();
            this.finishButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.appointPanel.SuspendLayout();
            this.appointOperationPanel.SuspendLayout();
            this.appointBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointBindingSource)).BeginInit();
            this.lendPanel.SuspendLayout();
            this.lendOperationPanel.SuspendLayout();
            this.lendBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lendDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).BeginInit();
            this.accountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointPanel
            // 
            this.appointPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appointPanel.Controls.Add(this.appointOperationPanel);
            this.appointPanel.Controls.Add(this.appointBookPanel);
            this.appointPanel.Location = new System.Drawing.Point(12, 50);
            this.appointPanel.Name = "appointPanel";
            this.appointPanel.Size = new System.Drawing.Size(776, 190);
            this.appointPanel.TabIndex = 0;
            // 
            // appointOperationPanel
            // 
            this.appointOperationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appointOperationPanel.Controls.Add(this.detailButton1);
            this.appointOperationPanel.Controls.Add(this.appointLabel);
            this.appointOperationPanel.Controls.Add(this.cancellButton);
            this.appointOperationPanel.Location = new System.Drawing.Point(6, 3);
            this.appointOperationPanel.Name = "appointOperationPanel";
            this.appointOperationPanel.Size = new System.Drawing.Size(95, 184);
            this.appointOperationPanel.TabIndex = 1;
            // 
            // detailButton1
            // 
            this.detailButton1.Location = new System.Drawing.Point(8, 62);
            this.detailButton1.Name = "detailButton1";
            this.detailButton1.Size = new System.Drawing.Size(75, 23);
            this.detailButton1.TabIndex = 2;
            this.detailButton1.Text = "查看细节";
            this.detailButton1.UseVisualStyleBackColor = true;
            this.detailButton1.Click += new System.EventHandler(this.detailButton1_Click);
            // 
            // appointLabel
            // 
            this.appointLabel.AutoSize = true;
            this.appointLabel.Location = new System.Drawing.Point(6, 9);
            this.appointLabel.Name = "appointLabel";
            this.appointLabel.Size = new System.Drawing.Size(77, 12);
            this.appointLabel.TabIndex = 1;
            this.appointLabel.Text = "预约的书籍：";
            // 
            // cancellButton
            // 
            this.cancellButton.Location = new System.Drawing.Point(8, 33);
            this.cancellButton.Name = "cancellButton";
            this.cancellButton.Size = new System.Drawing.Size(75, 23);
            this.cancellButton.TabIndex = 0;
            this.cancellButton.Text = "取消预约";
            this.cancellButton.UseVisualStyleBackColor = true;
            this.cancellButton.Click += new System.EventHandler(this.cancellButton_Click);
            // 
            // appointBookPanel
            // 
            this.appointBookPanel.Controls.Add(this.appointDataGridView);
            this.appointBookPanel.Location = new System.Drawing.Point(107, 3);
            this.appointBookPanel.Name = "appointBookPanel";
            this.appointBookPanel.Size = new System.Drawing.Size(669, 184);
            this.appointBookPanel.TabIndex = 0;
            // 
            // appointDataGridView
            // 
            this.appointDataGridView.AutoGenerateColumns = false;
            this.appointDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.bookShelfIdDataGridViewTextBoxColumn,
            this.sortDataGridViewTextBoxColumn,
            this.appointersDataGridViewTextBoxColumn});
            this.appointDataGridView.DataSource = this.appointBindingSource;
            this.appointDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointDataGridView.Location = new System.Drawing.Point(0, 0);
            this.appointDataGridView.Name = "appointDataGridView";
            this.appointDataGridView.RowTemplate.Height = 23;
            this.appointDataGridView.Size = new System.Drawing.Size(669, 184);
            this.appointDataGridView.TabIndex = 0;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "书号";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "书名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 90;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 90;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "使用人";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // bookShelfIdDataGridViewTextBoxColumn
            // 
            this.bookShelfIdDataGridViewTextBoxColumn.DataPropertyName = "BookShelfId";
            this.bookShelfIdDataGridViewTextBoxColumn.HeaderText = "书架号";
            this.bookShelfIdDataGridViewTextBoxColumn.Name = "bookShelfIdDataGridViewTextBoxColumn";
            this.bookShelfIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // sortDataGridViewTextBoxColumn
            // 
            this.sortDataGridViewTextBoxColumn.DataPropertyName = "Sort";
            this.sortDataGridViewTextBoxColumn.HeaderText = "分类";
            this.sortDataGridViewTextBoxColumn.Name = "sortDataGridViewTextBoxColumn";
            this.sortDataGridViewTextBoxColumn.Width = 90;
            // 
            // appointersDataGridViewTextBoxColumn
            // 
            this.appointersDataGridViewTextBoxColumn.DataPropertyName = "Appointers";
            this.appointersDataGridViewTextBoxColumn.HeaderText = "预约人";
            this.appointersDataGridViewTextBoxColumn.Name = "appointersDataGridViewTextBoxColumn";
            this.appointersDataGridViewTextBoxColumn.Width = 110;
            // 
            // appointBindingSource
            // 
            this.appointBindingSource.DataSource = typeof(LibrarySystem_Final.Book);
            // 
            // lendPanel
            // 
            this.lendPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lendPanel.Controls.Add(this.lendOperationPanel);
            this.lendPanel.Controls.Add(this.lendBookPanel);
            this.lendPanel.Location = new System.Drawing.Point(12, 251);
            this.lendPanel.Name = "lendPanel";
            this.lendPanel.Size = new System.Drawing.Size(776, 187);
            this.lendPanel.TabIndex = 1;
            // 
            // lendOperationPanel
            // 
            this.lendOperationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lendOperationPanel.Controls.Add(this.detailButton2);
            this.lendOperationPanel.Controls.Add(this.returnButton);
            this.lendOperationPanel.Controls.Add(this.newButton);
            this.lendOperationPanel.Controls.Add(this.lendLabel);
            this.lendOperationPanel.Location = new System.Drawing.Point(6, 3);
            this.lendOperationPanel.Name = "lendOperationPanel";
            this.lendOperationPanel.Size = new System.Drawing.Size(95, 181);
            this.lendOperationPanel.TabIndex = 1;
            // 
            // detailButton2
            // 
            this.detailButton2.Location = new System.Drawing.Point(8, 95);
            this.detailButton2.Name = "detailButton2";
            this.detailButton2.Size = new System.Drawing.Size(75, 23);
            this.detailButton2.TabIndex = 3;
            this.detailButton2.Text = "查看细节";
            this.detailButton2.UseVisualStyleBackColor = true;
            this.detailButton2.Click += new System.EventHandler(this.detailButton2_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(8, 66);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "归还书籍";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(8, 37);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "续借书籍";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // lendLabel
            // 
            this.lendLabel.AutoSize = true;
            this.lendLabel.Location = new System.Drawing.Point(6, 11);
            this.lendLabel.Name = "lendLabel";
            this.lendLabel.Size = new System.Drawing.Size(65, 12);
            this.lendLabel.TabIndex = 0;
            this.lendLabel.Text = "借阅的书籍";
            // 
            // lendBookPanel
            // 
            this.lendBookPanel.Controls.Add(this.lendDataGridView);
            this.lendBookPanel.Location = new System.Drawing.Point(107, 3);
            this.lendBookPanel.Name = "lendBookPanel";
            this.lendBookPanel.Size = new System.Drawing.Size(666, 181);
            this.lendBookPanel.TabIndex = 0;
            // 
            // lendDataGridView
            // 
            this.lendDataGridView.AutoGenerateColumns = false;
            this.lendDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lendDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn1,
            this.lendTimeDataGridViewTextBoxColumn,
            this.reNewNumDataGridViewTextBoxColumn,
            this.bookShelfIdDataGridViewTextBoxColumn1,
            this.sortDataGridViewTextBoxColumn1});
            this.lendDataGridView.DataSource = this.lendBindingSource;
            this.lendDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lendDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lendDataGridView.Name = "lendDataGridView";
            this.lendDataGridView.RowTemplate.Height = 23;
            this.lendDataGridView.Size = new System.Drawing.Size(666, 181);
            this.lendDataGridView.TabIndex = 0;
            // 
            // bookIdDataGridViewTextBoxColumn1
            // 
            this.bookIdDataGridViewTextBoxColumn1.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn1.HeaderText = "书号";
            this.bookIdDataGridViewTextBoxColumn1.Name = "bookIdDataGridViewTextBoxColumn1";
            this.bookIdDataGridViewTextBoxColumn1.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "书名";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // authorDataGridViewTextBoxColumn1
            // 
            this.authorDataGridViewTextBoxColumn1.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn1.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn1.Name = "authorDataGridViewTextBoxColumn1";
            // 
            // lendTimeDataGridViewTextBoxColumn
            // 
            this.lendTimeDataGridViewTextBoxColumn.DataPropertyName = "LendTime";
            this.lendTimeDataGridViewTextBoxColumn.HeaderText = "到期时间";
            this.lendTimeDataGridViewTextBoxColumn.Name = "lendTimeDataGridViewTextBoxColumn";
            // 
            // reNewNumDataGridViewTextBoxColumn
            // 
            this.reNewNumDataGridViewTextBoxColumn.DataPropertyName = "reNewNum";
            this.reNewNumDataGridViewTextBoxColumn.HeaderText = "续借次数";
            this.reNewNumDataGridViewTextBoxColumn.Name = "reNewNumDataGridViewTextBoxColumn";
            this.reNewNumDataGridViewTextBoxColumn.Width = 80;
            // 
            // bookShelfIdDataGridViewTextBoxColumn1
            // 
            this.bookShelfIdDataGridViewTextBoxColumn1.DataPropertyName = "BookShelfId";
            this.bookShelfIdDataGridViewTextBoxColumn1.HeaderText = "书架号";
            this.bookShelfIdDataGridViewTextBoxColumn1.Name = "bookShelfIdDataGridViewTextBoxColumn1";
            this.bookShelfIdDataGridViewTextBoxColumn1.Width = 80;
            // 
            // sortDataGridViewTextBoxColumn1
            // 
            this.sortDataGridViewTextBoxColumn1.DataPropertyName = "Sort";
            this.sortDataGridViewTextBoxColumn1.HeaderText = "分类";
            this.sortDataGridViewTextBoxColumn1.Name = "sortDataGridViewTextBoxColumn1";
            // 
            // lendBindingSource
            // 
            this.lendBindingSource.DataSource = typeof(LibrarySystem_Final.Book);
            // 
            // accountPanel
            // 
            this.accountPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountPanel.Controls.Add(this.finishButton);
            this.accountPanel.Controls.Add(this.nameTextBox);
            this.accountPanel.Controls.Add(this.nameLabel);
            this.accountPanel.Location = new System.Drawing.Point(12, 6);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(776, 38);
            this.accountPanel.TabIndex = 2;
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(178, 10);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 2;
            this.finishButton.Text = "完成";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(72, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 12);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "用户名：";
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 436);
            this.ControlBox = false;
            this.Controls.Add(this.lendPanel);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.appointPanel);
            this.Name = "FormAccount";
            this.Text = "我的账号";
            this.appointPanel.ResumeLayout(false);
            this.appointOperationPanel.ResumeLayout(false);
            this.appointOperationPanel.PerformLayout();
            this.appointBookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointBindingSource)).EndInit();
            this.lendPanel.ResumeLayout(false);
            this.lendOperationPanel.ResumeLayout(false);
            this.lendOperationPanel.PerformLayout();
            this.lendBookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lendDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).EndInit();
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel appointPanel;
        private System.Windows.Forms.Panel lendPanel;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Panel appointBookPanel;
        private System.Windows.Forms.Panel lendBookPanel;
        private System.Windows.Forms.Panel appointOperationPanel;
        private System.Windows.Forms.Button detailButton1;
        private System.Windows.Forms.Label appointLabel;
        private System.Windows.Forms.Button cancellButton;
        private System.Windows.Forms.DataGridView appointDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookShelfIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointBindingSource;
        private System.Windows.Forms.Panel lendOperationPanel;
        private System.Windows.Forms.Button detailButton2;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label lendLabel;
        private System.Windows.Forms.DataGridView lendDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reNewNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookShelfIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource lendBindingSource;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}