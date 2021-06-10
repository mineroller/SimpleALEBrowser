
namespace Simple_ALE_Browser
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetUsers = new System.Windows.Forms.Button();
            this.lblTempHolder = new System.Windows.Forms.Label();
            this.olvUserAuditResult = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnQueryUser = new System.Windows.Forms.Button();
            this.dpkToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpConnectInfo = new System.Windows.Forms.GroupBox();
            this.lblStatusDisp = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureSQLConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSimpleAuditLogViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSqlServerDetails = new System.Windows.Forms.Label();
            this.btnConnectSQL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDbRows = new System.Windows.Forms.Label();
            this.lblTargetServer = new System.Windows.Forms.Label();
            this.dpkFromTime = new System.Windows.Forms.DateTimePicker();
            this.dpkToTime = new System.Windows.Forms.DateTimePicker();
            this.lblTempHolder2 = new System.Windows.Forms.Label();
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvUserAuditResult)).BeginInit();
            this.grpConnectInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 118);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1400, 729);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTempHolder2);
            this.tabPage1.Controls.Add(this.dpkToTime);
            this.tabPage1.Controls.Add(this.dpkFromTime);
            this.tabPage1.Controls.Add(this.btnGetUsers);
            this.tabPage1.Controls.Add(this.lblTempHolder);
            this.tabPage1.Controls.Add(this.olvUserAuditResult);
            this.tabPage1.Controls.Add(this.btnQueryUser);
            this.tabPage1.Controls.Add(this.dpkToDate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dpkFromDate);
            this.tabPage1.Controls.Add(this.cmbUserList);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage1.Size = new System.Drawing.Size(1392, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Audit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetUsers.Location = new System.Drawing.Point(18, 15);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(129, 98);
            this.btnGetUsers.TabIndex = 9;
            this.btnGetUsers.Text = "Get / Refresh Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            this.btnGetUsers.Click += new System.EventHandler(this.btnGetUsers_Click);
            // 
            // lblTempHolder
            // 
            this.lblTempHolder.AutoSize = true;
            this.lblTempHolder.Location = new System.Drawing.Point(288, 159);
            this.lblTempHolder.Name = "lblTempHolder";
            this.lblTempHolder.Size = new System.Drawing.Size(43, 17);
            this.lblTempHolder.TabIndex = 8;
            this.lblTempHolder.Text = "label4";
            // 
            // olvUserAuditResult
            // 
            this.olvUserAuditResult.AllColumns.Add(this.olvColumn1);
            this.olvUserAuditResult.AllColumns.Add(this.olvColumn4);
            this.olvUserAuditResult.AllColumns.Add(this.olvColumn2);
            this.olvUserAuditResult.AllColumns.Add(this.olvColumn3);
            this.olvUserAuditResult.CellEditUseWholeCell = false;
            this.olvUserAuditResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn4,
            this.olvColumn2,
            this.olvColumn3});
            this.olvUserAuditResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvUserAuditResult.FullRowSelect = true;
            this.olvUserAuditResult.HideSelection = false;
            this.olvUserAuditResult.Location = new System.Drawing.Point(6, 196);
            this.olvUserAuditResult.Name = "olvUserAuditResult";
            this.olvUserAuditResult.ShowGroups = false;
            this.olvUserAuditResult.Size = new System.Drawing.Size(1380, 498);
            this.olvUserAuditResult.TabIndex = 7;
            this.olvUserAuditResult.UseAlternatingBackColors = true;
            this.olvUserAuditResult.UseCompatibleStateImageBehavior = false;
            this.olvUserAuditResult.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "ActionDateLocal";
            this.olvColumn1.Text = "Local Time";
            this.olvColumn1.Width = 162;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "ComputerName";
            this.olvColumn2.Text = "Workstation PC";
            this.olvColumn2.Width = 240;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Information";
            this.olvColumn3.Text = "Activity";
            this.olvColumn3.Width = 768;
            // 
            // btnQueryUser
            // 
            this.btnQueryUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueryUser.Location = new System.Drawing.Point(1093, 62);
            this.btnQueryUser.Name = "btnQueryUser";
            this.btnQueryUser.Size = new System.Drawing.Size(236, 51);
            this.btnQueryUser.TabIndex = 6;
            this.btnQueryUser.Text = "Find User Activity";
            this.btnQueryUser.UseVisualStyleBackColor = true;
            this.btnQueryUser.Click += new System.EventHandler(this.btnQueryUser_Click);
            // 
            // dpkToDate
            // 
            this.dpkToDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkToDate.Location = new System.Drawing.Point(709, 55);
            this.dpkToDate.Name = "dpkToDate";
            this.dpkToDate.Size = new System.Drawing.Size(344, 29);
            this.dpkToDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(672, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "From:";
            // 
            // dpkFromDate
            // 
            this.dpkFromDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkFromDate.Location = new System.Drawing.Point(291, 55);
            this.dpkFromDate.Name = "dpkFromDate";
            this.dpkFromDate.Size = new System.Drawing.Size(344, 29);
            this.dpkFromDate.TabIndex = 2;
            // 
            // cmbUserList
            // 
            this.cmbUserList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(291, 15);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(344, 29);
            this.cmbUserList.Sorted = true;
            this.cmbUserList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select User:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Size = new System.Drawing.Size(1392, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Workstation Audit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1392, 699);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Event Audit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpConnectInfo
            // 
            this.grpConnectInfo.Controls.Add(this.lblStatusDisp);
            this.grpConnectInfo.Location = new System.Drawing.Point(855, 29);
            this.grpConnectInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpConnectInfo.Name = "grpConnectInfo";
            this.grpConnectInfo.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpConnectInfo.Size = new System.Drawing.Size(557, 81);
            this.grpConnectInfo.TabIndex = 1;
            this.grpConnectInfo.TabStop = false;
            this.grpConnectInfo.Text = "Query and Status";
            // 
            // lblStatusDisp
            // 
            this.lblStatusDisp.BackColor = System.Drawing.Color.Black;
            this.lblStatusDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusDisp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDisp.ForeColor = System.Drawing.Color.Red;
            this.lblStatusDisp.Location = new System.Drawing.Point(6, 25);
            this.lblStatusDisp.Name = "lblStatusDisp";
            this.lblStatusDisp.Size = new System.Drawing.Size(545, 51);
            this.lblStatusDisp.TabIndex = 0;
            this.lblStatusDisp.Text = "[Not Connected]";
            this.lblStatusDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1424, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureSQLConnectionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // configureSQLConnectionToolStripMenuItem
            // 
            this.configureSQLConnectionToolStripMenuItem.Name = "configureSQLConnectionToolStripMenuItem";
            this.configureSQLConnectionToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.configureSQLConnectionToolStripMenuItem.Text = "Configure SQL Connection...";
            this.configureSQLConnectionToolStripMenuItem.Click += new System.EventHandler(this.configureSQLConnectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSimpleAuditLogViewerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSimpleAuditLogViewerToolStripMenuItem
            // 
            this.aboutSimpleAuditLogViewerToolStripMenuItem.Name = "aboutSimpleAuditLogViewerToolStripMenuItem";
            this.aboutSimpleAuditLogViewerToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.aboutSimpleAuditLogViewerToolStripMenuItem.Text = "About Simple Audit Log Viewer...";
            this.aboutSimpleAuditLogViewerToolStripMenuItem.Click += new System.EventHandler(this.aboutSimpleAuditLogViewerToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSqlServerDetails);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(205, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Information";
            // 
            // lblSqlServerDetails
            // 
            this.lblSqlServerDetails.Location = new System.Drawing.Point(7, 23);
            this.lblSqlServerDetails.Name = "lblSqlServerDetails";
            this.lblSqlServerDetails.Size = new System.Drawing.Size(344, 46);
            this.lblSqlServerDetails.TabIndex = 0;
            this.lblSqlServerDetails.Text = "[Not Connected]";
            this.lblSqlServerDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnectSQL
            // 
            this.btnConnectSQL.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConnectSQL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectSQL.ForeColor = System.Drawing.SystemColors.Info;
            this.btnConnectSQL.Location = new System.Drawing.Point(12, 70);
            this.btnConnectSQL.Name = "btnConnectSQL";
            this.btnConnectSQL.Size = new System.Drawing.Size(187, 40);
            this.btnConnectSQL.TabIndex = 4;
            this.btnConnectSQL.Text = "Connect to ALEV";
            this.btnConnectSQL.UseVisualStyleBackColor = false;
            this.btnConnectSQL.Click += new System.EventHandler(this.btnConnectSQL_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDbRows);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(568, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Information";
            // 
            // lblDbRows
            // 
            this.lblDbRows.Location = new System.Drawing.Point(7, 23);
            this.lblDbRows.Name = "lblDbRows";
            this.lblDbRows.Size = new System.Drawing.Size(268, 46);
            this.lblDbRows.TabIndex = 0;
            this.lblDbRows.Text = "[Not Connected]";
            this.lblDbRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTargetServer
            // 
            this.lblTargetServer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetServer.Location = new System.Drawing.Point(12, 44);
            this.lblTargetServer.Name = "lblTargetServer";
            this.lblTargetServer.Size = new System.Drawing.Size(187, 23);
            this.lblTargetServer.TabIndex = 5;
            this.lblTargetServer.Text = "Target Server";
            this.lblTargetServer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dpkFromTime
            // 
            this.dpkFromTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpkFromTime.Location = new System.Drawing.Point(291, 90);
            this.dpkFromTime.Name = "dpkFromTime";
            this.dpkFromTime.ShowUpDown = true;
            this.dpkFromTime.Size = new System.Drawing.Size(344, 29);
            this.dpkFromTime.TabIndex = 10;
            // 
            // dpkToTime
            // 
            this.dpkToTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpkToTime.Location = new System.Drawing.Point(709, 90);
            this.dpkToTime.Name = "dpkToTime";
            this.dpkToTime.ShowUpDown = true;
            this.dpkToTime.Size = new System.Drawing.Size(344, 29);
            this.dpkToTime.TabIndex = 11;
            // 
            // lblTempHolder2
            // 
            this.lblTempHolder2.AutoSize = true;
            this.lblTempHolder2.Location = new System.Drawing.Point(724, 150);
            this.lblTempHolder2.Name = "lblTempHolder2";
            this.lblTempHolder2.Size = new System.Drawing.Size(43, 17);
            this.lblTempHolder2.TabIndex = 12;
            this.lblTempHolder2.Text = "label4";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "UserName";
            this.olvColumn4.Text = "User ID";
            this.olvColumn4.Width = 142;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.lblTargetServer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConnectSQL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpConnectInfo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Audit Log Viewer for SQL Server";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvUserAuditResult)).EndInit();
            this.grpConnectInfo.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpConnectInfo;
        private System.Windows.Forms.Button btnQueryUser;
        private System.Windows.Forms.DateTimePicker dpkToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpkFromDate;
        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblStatusDisp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSimpleAuditLogViewerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private BrightIdeasSoftware.ObjectListView olvUserAuditResult;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.Label lblSqlServerDetails;
        private System.Windows.Forms.ToolStripMenuItem configureSQLConnectionToolStripMenuItem;
        private System.Windows.Forms.Button btnConnectSQL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDbRows;
        private System.Windows.Forms.Label lblTempHolder;
        private System.Windows.Forms.Label lblTargetServer;
        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.DateTimePicker dpkToTime;
        private System.Windows.Forms.DateTimePicker dpkFromTime;
        private System.Windows.Forms.Label lblTempHolder2;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}

