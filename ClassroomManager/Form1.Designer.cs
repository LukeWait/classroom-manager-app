
namespace ClassroomManager
{
    /// <summary>
    /// Form1.Designer
    /// </summary>
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            headerPanel = new System.Windows.Forms.Panel();
            roomTextBox = new System.Windows.Forms.TextBox();
            classTextBox = new System.Windows.Forms.TextBox();
            dateTextBox = new System.Windows.Forms.TextBox();
            teacherTextBox = new System.Windows.Forms.TextBox();
            dateLabel = new System.Windows.Forms.Label();
            roomLabel = new System.Windows.Forms.Label();
            classLabel = new System.Windows.Forms.Label();
            teacherLabel = new System.Windows.Forms.Label();
            footerPanel = new System.Windows.Forms.Panel();
            findButton = new System.Windows.Forms.Button();
            saveRAFButton = new System.Windows.Forms.Button();
            exitButton = new System.Windows.Forms.Button();
            saveChangesButton = new System.Windows.Forms.Button();
            sortButton = new System.Windows.Forms.Button();
            clearButton = new System.Windows.Forms.Button();
            searchLabel = new System.Windows.Forms.Label();
            searchTextBox = new System.Windows.Forms.TextBox();
            bodyPanel = new System.Windows.Forms.Panel();
            dataGridView = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            headerPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(984, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = System.Drawing.Color.Transparent;
            headerPanel.Controls.Add(roomTextBox);
            headerPanel.Controls.Add(classTextBox);
            headerPanel.Controls.Add(dateTextBox);
            headerPanel.Controls.Add(teacherTextBox);
            headerPanel.Controls.Add(dateLabel);
            headerPanel.Controls.Add(roomLabel);
            headerPanel.Controls.Add(classLabel);
            headerPanel.Controls.Add(teacherLabel);
            headerPanel.Location = new System.Drawing.Point(0, 27);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new System.Drawing.Size(984, 45);
            headerPanel.TabIndex = 1;
            // 
            // roomTextBox
            // 
            roomTextBox.Location = new System.Drawing.Point(559, 7);
            roomTextBox.Name = "roomTextBox";
            roomTextBox.Size = new System.Drawing.Size(50, 23);
            roomTextBox.TabIndex = 7;
            roomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classTextBox
            // 
            classTextBox.Location = new System.Drawing.Point(429, 8);
            classTextBox.Name = "classTextBox";
            classTextBox.Size = new System.Drawing.Size(50, 23);
            classTextBox.TabIndex = 6;
            classTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new System.Drawing.Point(822, 7);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new System.Drawing.Size(150, 23);
            dateTextBox.TabIndex = 5;
            dateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teacherTextBox
            // 
            teacherTextBox.Location = new System.Drawing.Point(85, 8);
            teacherTextBox.Name = "teacherTextBox";
            teacherTextBox.Size = new System.Drawing.Size(150, 23);
            teacherTextBox.TabIndex = 4;
            teacherTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            dateLabel.Location = new System.Drawing.Point(773, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(43, 18);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            roomLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            roomLabel.Location = new System.Drawing.Point(505, 9);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(48, 18);
            roomLabel.TabIndex = 2;
            roomLabel.Text = "Room:";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            classLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            classLabel.Location = new System.Drawing.Point(375, 9);
            classLabel.Name = "classLabel";
            classLabel.Size = new System.Drawing.Size(48, 18);
            classLabel.TabIndex = 1;
            classLabel.Text = "Class:";
            // 
            // teacherLabel
            // 
            teacherLabel.AutoSize = true;
            teacherLabel.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            teacherLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            teacherLabel.Location = new System.Drawing.Point(12, 9);
            teacherLabel.Name = "teacherLabel";
            teacherLabel.Size = new System.Drawing.Size(67, 18);
            teacherLabel.TabIndex = 0;
            teacherLabel.Text = "Teacher:";
            // 
            // footerPanel
            // 
            footerPanel.BackColor = System.Drawing.Color.Transparent;
            footerPanel.Controls.Add(findButton);
            footerPanel.Controls.Add(saveRAFButton);
            footerPanel.Controls.Add(exitButton);
            footerPanel.Controls.Add(saveChangesButton);
            footerPanel.Controls.Add(sortButton);
            footerPanel.Controls.Add(clearButton);
            footerPanel.Controls.Add(searchLabel);
            footerPanel.Controls.Add(searchTextBox);
            footerPanel.Location = new System.Drawing.Point(0, 468);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new System.Drawing.Size(984, 61);
            footerPanel.TabIndex = 2;
            // 
            // findButton
            // 
            findButton.BackColor = System.Drawing.Color.PapayaWhip;
            findButton.Cursor = System.Windows.Forms.Cursors.Hand;
            findButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            findButton.Location = new System.Drawing.Point(615, 26);
            findButton.Name = "findButton";
            findButton.Size = new System.Drawing.Size(115, 23);
            findButton.TabIndex = 14;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = false;
            findButton.Click += findButton_Click;
            // 
            // saveRAFButton
            // 
            saveRAFButton.BackColor = System.Drawing.Color.PapayaWhip;
            saveRAFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            saveRAFButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            saveRAFButton.Location = new System.Drawing.Point(736, 26);
            saveRAFButton.Name = "saveRAFButton";
            saveRAFButton.Size = new System.Drawing.Size(115, 23);
            saveRAFButton.TabIndex = 13;
            saveRAFButton.Text = "Save RAF";
            saveRAFButton.UseVisualStyleBackColor = false;
            saveRAFButton.Click += saveRAFButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = System.Drawing.Color.PapayaWhip;
            exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            exitButton.Location = new System.Drawing.Point(857, 26);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(115, 23);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = System.Drawing.Color.PapayaWhip;
            saveChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            saveChangesButton.Location = new System.Drawing.Point(133, 26);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new System.Drawing.Size(115, 23);
            saveChangesButton.TabIndex = 11;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // sortButton
            // 
            sortButton.BackColor = System.Drawing.Color.PapayaWhip;
            sortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            sortButton.Location = new System.Drawing.Point(254, 26);
            sortButton.Name = "sortButton";
            sortButton.Size = new System.Drawing.Size(115, 23);
            sortButton.TabIndex = 10;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = false;
            sortButton.Click += sortButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = System.Drawing.Color.PapayaWhip;
            clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            clearButton.Location = new System.Drawing.Point(12, 26);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(115, 23);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            searchLabel.Location = new System.Drawing.Point(470, 8);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new System.Drawing.Size(45, 15);
            searchLabel.TabIndex = 8;
            searchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new System.Drawing.Point(375, 26);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new System.Drawing.Size(234, 23);
            searchTextBox.TabIndex = 8;
            searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bodyPanel
            // 
            bodyPanel.BackColor = System.Drawing.Color.Transparent;
            bodyPanel.Controls.Add(dataGridView);
            bodyPanel.Location = new System.Drawing.Point(0, 68);
            bodyPanel.Name = "bodyPanel";
            bodyPanel.Size = new System.Drawing.Size(984, 405);
            bodyPanel.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView.Location = new System.Drawing.Point(12, 0);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowHeadersWidth = 50;
            dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowTemplate.Height = 21;
            dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.Size = new System.Drawing.Size(960, 405);
            dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "0";
            Column1.Name = "Column1";
            Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            Column2.HeaderText = "1";
            Column2.Name = "Column2";
            Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            Column3.HeaderText = "2";
            Column3.Name = "Column3";
            Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            Column4.HeaderText = "3";
            Column4.Name = "Column4";
            Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            Column5.HeaderText = "4";
            Column5.Name = "Column5";
            Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            Column6.HeaderText = "5";
            Column6.Name = "Column6";
            Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column7
            // 
            Column7.HeaderText = "6";
            Column7.Name = "Column7";
            Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column8
            // 
            Column8.HeaderText = "7";
            Column8.Name = "Column8";
            Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column9
            // 
            Column9.HeaderText = "8";
            Column9.Name = "Column9";
            Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column10
            // 
            Column10.HeaderText = "9";
            Column10.Name = "Column10";
            Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(984, 531);
            Controls.Add(bodyPanel);
            Controls.Add(footerPanel);
            Controls.Add(headerPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Classroom Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            footerPanel.ResumeLayout(false);
            footerPanel.PerformLayout();
            bodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button saveRAFButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

