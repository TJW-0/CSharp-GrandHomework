namespace LibrarySystem_Final.LibraryForm
{
    partial class FormDetail
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
            this.bookPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shelfIdTextBox = new System.Windows.Forms.TextBox();
            this.sortTextBox = new System.Windows.Forms.TextBox();
            this.introductionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discoverPictureBox = new System.Windows.Forms.PictureBox();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.recommendButton = new System.Windows.Forms.Button();
            this.lendButton = new System.Windows.Forms.Button();
            this.appointButton = new System.Windows.Forms.Button();
            this.choosePictureButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bookPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discoverPictureBox)).BeginInit();
            this.operationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookPanel
            // 
            this.bookPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookPanel.Controls.Add(this.panel1);
            this.bookPanel.Controls.Add(this.discoverPictureBox);
            this.bookPanel.Location = new System.Drawing.Point(12, 12);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(776, 362);
            this.bookPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shelfIdTextBox);
            this.panel1.Controls.Add(this.sortTextBox);
            this.panel1.Controls.Add(this.introductionTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.authorTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(524, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 359);
            this.panel1.TabIndex = 1;
            // 
            // shelfIdTextBox
            // 
            this.shelfIdTextBox.Location = new System.Drawing.Point(67, 213);
            this.shelfIdTextBox.Name = "shelfIdTextBox";
            this.shelfIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.shelfIdTextBox.TabIndex = 9;
            // 
            // sortTextBox
            // 
            this.sortTextBox.Location = new System.Drawing.Point(67, 145);
            this.sortTextBox.Name = "sortTextBox";
            this.sortTextBox.Size = new System.Drawing.Size(100, 21);
            this.sortTextBox.TabIndex = 8;
            // 
            // introductionTextBox
            // 
            this.introductionTextBox.Location = new System.Drawing.Point(67, 270);
            this.introductionTextBox.Multiline = true;
            this.introductionTextBox.Name = "introductionTextBox";
            this.introductionTextBox.Size = new System.Drawing.Size(100, 86);
            this.introductionTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "描述：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "书架号：";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 127);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 12);
            this.label.TabIndex = 4;
            this.label.Text = "分类：";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(67, 90);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 21);
            this.authorTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "作者：";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(67, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "书名：";
            // 
            // discoverPictureBox
            // 
            this.discoverPictureBox.Location = new System.Drawing.Point(3, 0);
            this.discoverPictureBox.Name = "discoverPictureBox";
            this.discoverPictureBox.Size = new System.Drawing.Size(515, 359);
            this.discoverPictureBox.TabIndex = 0;
            this.discoverPictureBox.TabStop = false;
            // 
            // operationPanel
            // 
            this.operationPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.operationPanel.Controls.Add(this.recommendButton);
            this.operationPanel.Controls.Add(this.lendButton);
            this.operationPanel.Controls.Add(this.appointButton);
            this.operationPanel.Controls.Add(this.choosePictureButton);
            this.operationPanel.Controls.Add(this.addButton);
            this.operationPanel.Controls.Add(this.finishButton);
            this.operationPanel.Location = new System.Drawing.Point(12, 380);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(776, 58);
            this.operationPanel.TabIndex = 1;
            // 
            // recommendButton
            // 
            this.recommendButton.Location = new System.Drawing.Point(165, 18);
            this.recommendButton.Name = "recommendButton";
            this.recommendButton.Size = new System.Drawing.Size(75, 23);
            this.recommendButton.TabIndex = 5;
            this.recommendButton.Text = "推荐该书";
            this.recommendButton.UseVisualStyleBackColor = true;
            this.recommendButton.Click += new System.EventHandler(this.recommendButton_Click);
            // 
            // lendButton
            // 
            this.lendButton.Location = new System.Drawing.Point(84, 18);
            this.lendButton.Name = "lendButton";
            this.lendButton.Size = new System.Drawing.Size(75, 23);
            this.lendButton.TabIndex = 4;
            this.lendButton.Text = "借阅该书";
            this.lendButton.UseVisualStyleBackColor = true;
            this.lendButton.Click += new System.EventHandler(this.lendButton_Click);
            // 
            // appointButton
            // 
            this.appointButton.Location = new System.Drawing.Point(3, 18);
            this.appointButton.Name = "appointButton";
            this.appointButton.Size = new System.Drawing.Size(75, 23);
            this.appointButton.TabIndex = 3;
            this.appointButton.Text = "预约该书";
            this.appointButton.UseVisualStyleBackColor = true;
            this.appointButton.Click += new System.EventHandler(this.appointButton_Click);
            // 
            // choosePictureButton
            // 
            this.choosePictureButton.Location = new System.Drawing.Point(524, 18);
            this.choosePictureButton.Name = "choosePictureButton";
            this.choosePictureButton.Size = new System.Drawing.Size(75, 23);
            this.choosePictureButton.TabIndex = 2;
            this.choosePictureButton.Text = "选择图片";
            this.choosePictureButton.UseVisualStyleBackColor = true;
            this.choosePictureButton.Click += new System.EventHandler(this.choosePictureButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(605, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "加入书架";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(686, 18);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 0;
            this.finishButton.Text = "完成";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.operationPanel);
            this.Controls.Add(this.bookPanel);
            this.Name = "FormDetail";
            this.Text = "书籍详情";
            this.bookPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discoverPictureBox)).EndInit();
            this.operationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox discoverPictureBox;
        private System.Windows.Forms.TextBox shelfIdTextBox;
        private System.Windows.Forms.TextBox sortTextBox;
        private System.Windows.Forms.TextBox introductionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recommendButton;
        private System.Windows.Forms.Button lendButton;
        private System.Windows.Forms.Button appointButton;
        private System.Windows.Forms.Button choosePictureButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}