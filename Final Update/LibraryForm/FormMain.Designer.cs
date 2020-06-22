namespace LibrarySystem_Final
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.recommendPanel = new System.Windows.Forms.Panel();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.recommendDataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.signOutButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.accountButton = new System.Windows.Forms.Button();
            this.libraryButton = new System.Windows.Forms.Button();
            this.managePictureBox = new System.Windows.Forms.PictureBox();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookShelfIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recommendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recommendPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recommendDataGridView)).BeginInit();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // recommendPanel
            // 
            this.recommendPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recommendPanel.Controls.Add(this.operationPanel);
            this.recommendPanel.Controls.Add(this.recommendDataGridView);
            this.recommendPanel.Location = new System.Drawing.Point(1, 62);
            this.recommendPanel.Name = "recommendPanel";
            this.recommendPanel.Size = new System.Drawing.Size(798, 237);
            this.recommendPanel.TabIndex = 0;
            // 
            // operationPanel
            // 
            this.operationPanel.Location = new System.Drawing.Point(0, 243);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(798, 145);
            this.operationPanel.TabIndex = 5;
            // 
            // recommendDataGridView
            // 
            this.recommendDataGridView.AutoGenerateColumns = false;
            this.recommendDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recommendDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.sortDataGridViewTextBoxColumn,
            this.recommendDataGridViewTextBoxColumn,
            this.bookShelfIdDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.appointersDataGridViewTextBoxColumn});
            this.recommendDataGridView.DataSource = this.recommendBindingSource;
            this.recommendDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recommendDataGridView.Location = new System.Drawing.Point(0, 0);
            this.recommendDataGridView.Name = "recommendDataGridView";
            this.recommendDataGridView.RowTemplate.Height = 23;
            this.recommendDataGridView.Size = new System.Drawing.Size(798, 237);
            this.recommendDataGridView.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 12);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "用户名：";
            // 
            // clientPanel
            // 
            this.clientPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPanel.Controls.Add(this.signOutButton);
            this.clientPanel.Controls.Add(this.registerButton);
            this.clientPanel.Controls.Add(this.signInButton);
            this.clientPanel.Controls.Add(this.nameTextBox);
            this.clientPanel.Controls.Add(this.nameLabel);
            this.clientPanel.Location = new System.Drawing.Point(1, 3);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(798, 53);
            this.clientPanel.TabIndex = 4;
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(383, 13);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(75, 23);
            this.signOutButton.TabIndex = 7;
            this.signOutButton.Text = "退出登录";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(302, 13);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "注册";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(221, 13);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "登录";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(70, 15);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 4;
            // 
            // accountButton
            // 
            this.accountButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountButton.Location = new System.Drawing.Point(57, 336);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(162, 80);
            this.accountButton.TabIndex = 5;
            this.accountButton.Text = "我的账号";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // libraryButton
            // 
            this.libraryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.libraryButton.Location = new System.Drawing.Point(335, 336);
            this.libraryButton.Name = "libraryButton";
            this.libraryButton.Size = new System.Drawing.Size(162, 80);
            this.libraryButton.TabIndex = 6;
            this.libraryButton.Text = "查阅馆内藏书";
            this.libraryButton.UseVisualStyleBackColor = true;
            this.libraryButton.Click += new System.EventHandler(this.libraryButton_Click);
            // 
            // managePictureBox
            // 
            this.managePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.managePictureBox.Image = global::LibrarySystem_Final.Properties.Resources.管理;
            this.managePictureBox.Location = new System.Drawing.Point(609, 336);
            this.managePictureBox.Name = "managePictureBox";
            this.managePictureBox.Size = new System.Drawing.Size(162, 80);
            this.managePictureBox.TabIndex = 7;
            this.managePictureBox.TabStop = false;
            this.managePictureBox.Click += new System.EventHandler(this.managePictureBox_Click);
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "书号";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "书名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 90;
            // 
            // sortDataGridViewTextBoxColumn
            // 
            this.sortDataGridViewTextBoxColumn.DataPropertyName = "Sort";
            this.sortDataGridViewTextBoxColumn.HeaderText = "分类";
            this.sortDataGridViewTextBoxColumn.Name = "sortDataGridViewTextBoxColumn";
            this.sortDataGridViewTextBoxColumn.Width = 90;
            // 
            // recommendDataGridViewTextBoxColumn
            // 
            this.recommendDataGridViewTextBoxColumn.DataPropertyName = "Recommend";
            this.recommendDataGridViewTextBoxColumn.HeaderText = "推荐数";
            this.recommendDataGridViewTextBoxColumn.Name = "recommendDataGridViewTextBoxColumn";
            this.recommendDataGridViewTextBoxColumn.Width = 70;
            // 
            // bookShelfIdDataGridViewTextBoxColumn
            // 
            this.bookShelfIdDataGridViewTextBoxColumn.DataPropertyName = "BookShelfId";
            this.bookShelfIdDataGridViewTextBoxColumn.HeaderText = "书架号";
            this.bookShelfIdDataGridViewTextBoxColumn.Name = "bookShelfIdDataGridViewTextBoxColumn";
            this.bookShelfIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "状态";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 90;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "使用人";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // appointersDataGridViewTextBoxColumn
            // 
            this.appointersDataGridViewTextBoxColumn.DataPropertyName = "Appointers";
            this.appointersDataGridViewTextBoxColumn.HeaderText = "预约人";
            this.appointersDataGridViewTextBoxColumn.Name = "appointersDataGridViewTextBoxColumn";
            // 
            // recommendBindingSource
            // 
            this.recommendBindingSource.DataSource = typeof(LibrarySystem_Final.Book);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.managePictureBox);
            this.Controls.Add(this.libraryButton);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.recommendPanel);
            this.Name = "FormMain";
            this.Text = "图书管理系统";
            this.recommendPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recommendDataGridView)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recommendBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel recommendPanel;
        private System.Windows.Forms.BindingSource recommendBindingSource;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.DataGridView recommendDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recommendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookShelfIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button libraryButton;
        private System.Windows.Forms.PictureBox managePictureBox;
    }
}

