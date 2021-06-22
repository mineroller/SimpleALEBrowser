
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpCameraInfo = new System.Windows.Forms.GroupBox();
            this.lblOnvifSnapshotStatus = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numOnvifCustomPrf = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOnvifCustomPass = new System.Windows.Forms.TextBox();
            this.txtOnvifCustomLogin = new System.Windows.Forms.TextBox();
            this.chkPreviewCamera = new System.Windows.Forms.CheckBox();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.lblSelectedCamName = new System.Windows.Forms.Label();
            this.lblSelectedCamIp = new System.Windows.Forms.Label();
            this.picCamPreview = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numMaxRows = new System.Windows.Forms.NumericUpDown();
            this.txtObjectName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbActionId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbComputerList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dpkToTime = new System.Windows.Forms.DateTimePicker();
            this.dpkFromTime = new System.Windows.Forms.DateTimePicker();
            this.olvUserAuditResult = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
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
            this.btnInit = new System.Windows.Forms.Button();
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
            this.btnConnectSQL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOldestRow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDbRows = new System.Windows.Forms.Label();
            this.lblTargetServer = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpCameraInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOnvifCustomPrf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvUserAuditResult)).BeginInit();
            this.grpConnectInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 118);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1400, 716);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpCameraInfo);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.numMaxRows);
            this.tabPage1.Controls.Add(this.txtObjectName);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmbActionId);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmbComputerList);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dpkToTime);
            this.tabPage1.Controls.Add(this.dpkFromTime);
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
            this.tabPage1.Size = new System.Drawing.Size(1392, 686);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Audit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpCameraInfo
            // 
            this.grpCameraInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCameraInfo.Controls.Add(this.lblOnvifSnapshotStatus);
            this.grpCameraInfo.Controls.Add(this.label12);
            this.grpCameraInfo.Controls.Add(this.numOnvifCustomPrf);
            this.grpCameraInfo.Controls.Add(this.label11);
            this.grpCameraInfo.Controls.Add(this.label10);
            this.grpCameraInfo.Controls.Add(this.txtOnvifCustomPass);
            this.grpCameraInfo.Controls.Add(this.txtOnvifCustomLogin);
            this.grpCameraInfo.Controls.Add(this.chkPreviewCamera);
            this.grpCameraInfo.Controls.Add(this.lblObjectType);
            this.grpCameraInfo.Controls.Add(this.lblSelectedCamName);
            this.grpCameraInfo.Controls.Add(this.lblSelectedCamIp);
            this.grpCameraInfo.Controls.Add(this.picCamPreview);
            this.grpCameraInfo.Location = new System.Drawing.Point(1007, 135);
            this.grpCameraInfo.Name = "grpCameraInfo";
            this.grpCameraInfo.Size = new System.Drawing.Size(368, 543);
            this.grpCameraInfo.TabIndex = 22;
            this.grpCameraInfo.TabStop = false;
            this.grpCameraInfo.Text = "Associated Object for the Selected Activity";
            // 
            // lblOnvifSnapshotStatus
            // 
            this.lblOnvifSnapshotStatus.BackColor = System.Drawing.Color.Gray;
            this.lblOnvifSnapshotStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnvifSnapshotStatus.ForeColor = System.Drawing.Color.White;
            this.lblOnvifSnapshotStatus.Location = new System.Drawing.Point(16, 426);
            this.lblOnvifSnapshotStatus.Name = "lblOnvifSnapshotStatus";
            this.lblOnvifSnapshotStatus.Size = new System.Drawing.Size(339, 17);
            this.lblOnvifSnapshotStatus.TabIndex = 11;
            this.lblOnvifSnapshotStatus.Text = "[Camera Status]";
            this.lblOnvifSnapshotStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 509);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "ONVIF Profile Number:";
            // 
            // numOnvifCustomPrf
            // 
            this.numOnvifCustomPrf.Location = new System.Drawing.Point(163, 507);
            this.numOnvifCustomPrf.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOnvifCustomPrf.Name = "numOnvifCustomPrf";
            this.numOnvifCustomPrf.Size = new System.Drawing.Size(98, 25);
            this.numOnvifCustomPrf.TabIndex = 9;
            this.numOnvifCustomPrf.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Username";
            // 
            // txtOnvifCustomPass
            // 
            this.txtOnvifCustomPass.Location = new System.Drawing.Point(122, 472);
            this.txtOnvifCustomPass.Name = "txtOnvifCustomPass";
            this.txtOnvifCustomPass.Size = new System.Drawing.Size(100, 25);
            this.txtOnvifCustomPass.TabIndex = 6;
            this.txtOnvifCustomPass.UseSystemPasswordChar = true;
            // 
            // txtOnvifCustomLogin
            // 
            this.txtOnvifCustomLogin.Location = new System.Drawing.Point(16, 472);
            this.txtOnvifCustomLogin.Name = "txtOnvifCustomLogin";
            this.txtOnvifCustomLogin.Size = new System.Drawing.Size(100, 25);
            this.txtOnvifCustomLogin.TabIndex = 5;
            // 
            // chkPreviewCamera
            // 
            this.chkPreviewCamera.AutoSize = true;
            this.chkPreviewCamera.Location = new System.Drawing.Point(16, 194);
            this.chkPreviewCamera.Name = "chkPreviewCamera";
            this.chkPreviewCamera.Size = new System.Drawing.Size(160, 21);
            this.chkPreviewCamera.TabIndex = 4;
            this.chkPreviewCamera.Text = "Preview Camera Image";
            this.chkPreviewCamera.UseVisualStyleBackColor = true;
            this.chkPreviewCamera.CheckedChanged += new System.EventHandler(this.chkPreviewCamera_CheckedChanged);
            // 
            // lblObjectType
            // 
            this.lblObjectType.BackColor = System.Drawing.Color.Indigo;
            this.lblObjectType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectType.ForeColor = System.Drawing.Color.White;
            this.lblObjectType.Location = new System.Drawing.Point(16, 34);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(339, 29);
            this.lblObjectType.TabIndex = 3;
            this.lblObjectType.Text = "[Object Type]";
            this.lblObjectType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedCamName
            // 
            this.lblSelectedCamName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedCamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCamName.Location = new System.Drawing.Point(16, 69);
            this.lblSelectedCamName.Name = "lblSelectedCamName";
            this.lblSelectedCamName.Size = new System.Drawing.Size(339, 84);
            this.lblSelectedCamName.TabIndex = 2;
            this.lblSelectedCamName.Text = "[Object Name]";
            this.lblSelectedCamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedCamIp
            // 
            this.lblSelectedCamIp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCamIp.Location = new System.Drawing.Point(16, 153);
            this.lblSelectedCamIp.Name = "lblSelectedCamIp";
            this.lblSelectedCamIp.Size = new System.Drawing.Size(339, 29);
            this.lblSelectedCamIp.TabIndex = 1;
            this.lblSelectedCamIp.Text = "[IP Address]";
            this.lblSelectedCamIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCamPreview
            // 
            this.picCamPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCamPreview.ErrorImage = global::Simple_ALE_Browser.Properties.Resources.no_icon;
            this.picCamPreview.Image = global::Simple_ALE_Browser.Properties.Resources.IndigoVision_MS_FullColour_RGB_WEBSITE;
            this.picCamPreview.InitialImage = global::Simple_ALE_Browser.Properties.Resources.IndigoVision_MS_FullColour_RGB_WEBSITE;
            this.picCamPreview.Location = new System.Drawing.Point(16, 221);
            this.picCamPreview.Name = "picCamPreview";
            this.picCamPreview.Size = new System.Drawing.Size(339, 202);
            this.picCamPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamPreview.TabIndex = 0;
            this.picCamPreview.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1219, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Export Result to CSV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(753, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Maximum Results (100-2000):";
            // 
            // numMaxRows
            // 
            this.numMaxRows.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMaxRows.Location = new System.Drawing.Point(938, 104);
            this.numMaxRows.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numMaxRows.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMaxRows.Name = "numMaxRows";
            this.numMaxRows.Size = new System.Drawing.Size(91, 25);
            this.numMaxRows.TabIndex = 19;
            this.numMaxRows.ThousandsSeparator = true;
            this.numMaxRows.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtObjectName
            // 
            this.txtObjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjectName.Location = new System.Drawing.Point(1182, 12);
            this.txtObjectName.Name = "txtObjectName";
            this.txtObjectName.Size = new System.Drawing.Size(191, 29);
            this.txtObjectName.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1007, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "4. Camera No/Name:";
            // 
            // cmbActionId
            // 
            this.cmbActionId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbActionId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActionId.FormattingEnabled = true;
            this.cmbActionId.Location = new System.Drawing.Point(714, 12);
            this.cmbActionId.Name = "cmbActionId";
            this.cmbActionId.Size = new System.Drawing.Size(287, 29);
            this.cmbActionId.Sorted = true;
            this.cmbActionId.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "3. Activities:";
            // 
            // cmbComputerList
            // 
            this.cmbComputerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComputerList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComputerList.FormattingEnabled = true;
            this.cmbComputerList.Location = new System.Drawing.Point(418, 12);
            this.cmbComputerList.Name = "cmbComputerList";
            this.cmbComputerList.Size = new System.Drawing.Size(182, 29);
            this.cmbComputerList.Sorted = true;
            this.cmbComputerList.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "2. On this CC:";
            // 
            // dpkToTime
            // 
            this.dpkToTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpkToTime.Location = new System.Drawing.Point(488, 100);
            this.dpkToTime.Name = "dpkToTime";
            this.dpkToTime.ShowUpDown = true;
            this.dpkToTime.Size = new System.Drawing.Size(250, 29);
            this.dpkToTime.TabIndex = 11;
            // 
            // dpkFromTime
            // 
            this.dpkFromTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpkFromTime.Location = new System.Drawing.Point(188, 100);
            this.dpkFromTime.Name = "dpkFromTime";
            this.dpkFromTime.ShowUpDown = true;
            this.dpkFromTime.Size = new System.Drawing.Size(250, 29);
            this.dpkFromTime.TabIndex = 10;
            // 
            // olvUserAuditResult
            // 
            this.olvUserAuditResult.AllColumns.Add(this.olvColumn1);
            this.olvUserAuditResult.AllColumns.Add(this.olvColumn4);
            this.olvUserAuditResult.AllColumns.Add(this.olvColumn2);
            this.olvUserAuditResult.AllColumns.Add(this.olvColumn5);
            this.olvUserAuditResult.AllColumns.Add(this.olvColumn3);
            this.olvUserAuditResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvUserAuditResult.CellEditUseWholeCell = false;
            this.olvUserAuditResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn4,
            this.olvColumn2,
            this.olvColumn5,
            this.olvColumn3});
            this.olvUserAuditResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvUserAuditResult.FullRowSelect = true;
            this.olvUserAuditResult.HideSelection = false;
            this.olvUserAuditResult.Location = new System.Drawing.Point(12, 135);
            this.olvUserAuditResult.Name = "olvUserAuditResult";
            this.olvUserAuditResult.ShowGroups = false;
            this.olvUserAuditResult.Size = new System.Drawing.Size(989, 543);
            this.olvUserAuditResult.TabIndex = 7;
            this.olvUserAuditResult.UseAlternatingBackColors = true;
            this.olvUserAuditResult.UseCompatibleStateImageBehavior = false;
            this.olvUserAuditResult.View = System.Windows.Forms.View.Details;
            this.olvUserAuditResult.SelectedIndexChanged += new System.EventHandler(this.olvUserAuditResult_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "ActionDateLocal";
            this.olvColumn1.Text = "Local Time";
            this.olvColumn1.Width = 162;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "UserName";
            this.olvColumn4.Text = "User ID";
            this.olvColumn4.Width = 142;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "ComputerName";
            this.olvColumn2.Text = "Workstation PC";
            this.olvColumn2.Width = 240;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "ObjectName";
            this.olvColumn5.Text = "Object";
            this.olvColumn5.Width = 182;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Information";
            this.olvColumn3.Text = "Activity";
            this.olvColumn3.Width = 426;
            // 
            // btnQueryUser
            // 
            this.btnQueryUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btnQueryUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueryUser.ForeColor = System.Drawing.Color.Gold;
            this.btnQueryUser.Location = new System.Drawing.Point(744, 62);
            this.btnQueryUser.Name = "btnQueryUser";
            this.btnQueryUser.Size = new System.Drawing.Size(285, 36);
            this.btnQueryUser.TabIndex = 6;
            this.btnQueryUser.Text = "Find User Activity";
            this.btnQueryUser.UseVisualStyleBackColor = false;
            this.btnQueryUser.Click += new System.EventHandler(this.btnQueryUser_Click);
            // 
            // dpkToDate
            // 
            this.dpkToDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkToDate.Location = new System.Drawing.Point(488, 65);
            this.dpkToDate.Name = "dpkToDate";
            this.dpkToDate.Size = new System.Drawing.Size(250, 29);
            this.dpkToDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "From:";
            // 
            // dpkFromDate
            // 
            this.dpkFromDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkFromDate.Location = new System.Drawing.Point(188, 65);
            this.dpkFromDate.Name = "dpkFromDate";
            this.dpkFromDate.Size = new System.Drawing.Size(250, 29);
            this.dpkFromDate.TabIndex = 2;
            // 
            // cmbUserList
            // 
            this.cmbUserList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(115, 12);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(182, 29);
            this.cmbUserList.Sorted = true;
            this.cmbUserList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. This User:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPage2.Size = new System.Drawing.Size(1392, 686);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Workstation Audit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1392, 686);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Event Audit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnInit
            // 
            this.btnInit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.Location = new System.Drawing.Point(22, 24);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(313, 39);
            this.btnInit.TabIndex = 9;
            this.btnInit.Text = "Initialise / Refresh Audit Data";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // grpConnectInfo
            // 
            this.grpConnectInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConnectInfo.Controls.Add(this.lblStatusDisp);
            this.grpConnectInfo.Location = new System.Drawing.Point(944, 29);
            this.grpConnectInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpConnectInfo.Name = "grpConnectInfo";
            this.grpConnectInfo.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpConnectInfo.Size = new System.Drawing.Size(468, 81);
            this.grpConnectInfo.TabIndex = 1;
            this.grpConnectInfo.TabStop = false;
            this.grpConnectInfo.Text = "Query and Status";
            // 
            // lblStatusDisp
            // 
            this.lblStatusDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusDisp.BackColor = System.Drawing.Color.Black;
            this.lblStatusDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusDisp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDisp.ForeColor = System.Drawing.Color.Red;
            this.lblStatusDisp.Location = new System.Drawing.Point(6, 20);
            this.lblStatusDisp.Name = "lblStatusDisp";
            this.lblStatusDisp.Size = new System.Drawing.Size(452, 56);
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
            this.groupBox1.Controls.Add(this.btnInit);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(205, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialise Browser";
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
            this.btnConnectSQL.Text = "Connect to ALE DB";
            this.btnConnectSQL.UseVisualStyleBackColor = false;
            this.btnConnectSQL.Click += new System.EventHandler(this.btnConnectSQL_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOldestRow);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDbRows);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(568, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Information";
            // 
            // lblOldestRow
            // 
            this.lblOldestRow.Location = new System.Drawing.Point(97, 47);
            this.lblOldestRow.Name = "lblOldestRow";
            this.lblOldestRow.Size = new System.Drawing.Size(267, 26);
            this.lblOldestRow.TabIndex = 3;
            this.lblOldestRow.Text = "[Not Connected]";
            this.lblOldestRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Oldest Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "DB Size:";
            // 
            // lblDbRows
            // 
            this.lblDbRows.Location = new System.Drawing.Point(97, 20);
            this.lblDbRows.Name = "lblDbRows";
            this.lblDbRows.Size = new System.Drawing.Size(267, 26);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 839);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1424, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "[Not Connected]";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel2.Text = "[Not Connected]";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTargetServer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConnectSQL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpConnectInfo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple ALE Browser for IV Audit Log Event Database (MS-SQL Edition)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpCameraInfo.ResumeLayout(false);
            this.grpCameraInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOnvifCustomPrf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvUserAuditResult)).EndInit();
            this.grpConnectInfo.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem configureSQLConnectionToolStripMenuItem;
        private System.Windows.Forms.Button btnConnectSQL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDbRows;
        private System.Windows.Forms.Label lblTargetServer;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.DateTimePicker dpkToTime;
        private System.Windows.Forms.DateTimePicker dpkFromTime;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Label lblOldestRow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ComboBox cmbComputerList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbActionId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObjectName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMaxRows;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCameraInfo;
        private System.Windows.Forms.Label lblSelectedCamName;
        private System.Windows.Forms.Label lblSelectedCamIp;
        private System.Windows.Forms.PictureBox picCamPreview;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.CheckBox chkPreviewCamera;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numOnvifCustomPrf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOnvifCustomPass;
        private System.Windows.Forms.TextBox txtOnvifCustomLogin;
        private System.Windows.Forms.Label lblOnvifSnapshotStatus;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
    }
}

