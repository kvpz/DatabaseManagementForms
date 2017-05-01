namespace DatabaseManagementForms
{
    partial class AddUser
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
            this.AddUsersTabcontrol = new System.Windows.Forms.TabControl();
            this.AddUserTab = new System.Windows.Forms.TabPage();
            this.SaveChanges_button = new System.Windows.Forms.Button();
            this.NewUser_DataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biographyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailConfirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passwordHashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.twoFactorEnabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lockoutEndDateUtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockoutEnabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.accessFailedCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collaboratorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collaborators1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userClaimsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLocationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddUser_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddUser_toolStrip_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateRandomUserButton = new System.Windows.Forms.Button();
            this.AddUsersBulkTab = new System.Windows.Forms.TabPage();
            this.BulkCreateRandomUsers_button = new System.Windows.Forms.Button();
            this.BulkAdd_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUsersTabcontrol.SuspendLayout();
            this.AddUserTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewUser_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.AddUser_contextMenuStrip.SuspendLayout();
            this.AddUsersBulkTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulkAdd_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUsersTabcontrol
            // 
            this.AddUsersTabcontrol.Controls.Add(this.AddUserTab);
            this.AddUsersTabcontrol.Controls.Add(this.AddUsersBulkTab);
            this.AddUsersTabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUsersTabcontrol.Location = new System.Drawing.Point(0, 0);
            this.AddUsersTabcontrol.Name = "AddUsersTabcontrol";
            this.AddUsersTabcontrol.SelectedIndex = 0;
            this.AddUsersTabcontrol.Size = new System.Drawing.Size(1076, 514);
            this.AddUsersTabcontrol.TabIndex = 0;
            // 
            // AddUserTab
            // 
            this.AddUserTab.Controls.Add(this.SaveChanges_button);
            this.AddUserTab.Controls.Add(this.NewUser_DataGrid);
            this.AddUserTab.Controls.Add(this.CreateRandomUserButton);
            this.AddUserTab.Location = new System.Drawing.Point(4, 25);
            this.AddUserTab.Name = "AddUserTab";
            this.AddUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddUserTab.Size = new System.Drawing.Size(1068, 485);
            this.AddUserTab.TabIndex = 0;
            this.AddUserTab.Text = "Single User";
            this.AddUserTab.UseVisualStyleBackColor = true;
            // 
            // SaveChanges_button
            // 
            this.SaveChanges_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChanges_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveChanges_button.Location = new System.Drawing.Point(8, 39);
            this.SaveChanges_button.Name = "SaveChanges_button";
            this.SaveChanges_button.Size = new System.Drawing.Size(151, 269);
            this.SaveChanges_button.TabIndex = 5;
            this.SaveChanges_button.Text = "Save Changes";
            this.SaveChanges_button.UseVisualStyleBackColor = true;
            this.SaveChanges_button.Click += new System.EventHandler(this.SaveChanges_button_Click);
            // 
            // NewUser_DataGrid
            // 
            this.NewUser_DataGrid.AutoGenerateColumns = false;
            this.NewUser_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewUser_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.biographyDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.emailConfirmedDataGridViewCheckBoxColumn,
            this.passwordHashDataGridViewTextBoxColumn,
            this.securityStampDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn,
            this.twoFactorEnabledDataGridViewCheckBoxColumn,
            this.lockoutEndDateUtcDataGridViewTextBoxColumn,
            this.lockoutEnabledDataGridViewCheckBoxColumn,
            this.accessFailedCountDataGridViewTextBoxColumn,
            this.collaboratorsDataGridViewTextBoxColumn,
            this.collaborators1DataGridViewTextBoxColumn,
            this.userClaimsDataGridViewTextBoxColumn,
            this.userLocationsDataGridViewTextBoxColumn,
            this.userLoginsDataGridViewTextBoxColumn,
            this.skillsDataGridViewTextBoxColumn,
            this.rolesDataGridViewTextBoxColumn});
            this.NewUser_DataGrid.DataSource = this.usersBindingSource;
            this.NewUser_DataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.NewUser_DataGrid.Location = new System.Drawing.Point(165, 3);
            this.NewUser_DataGrid.Name = "NewUser_DataGrid";
            this.NewUser_DataGrid.RowTemplate.ContextMenuStrip = this.AddUser_contextMenuStrip;
            this.NewUser_DataGrid.Size = new System.Drawing.Size(900, 479);
            this.NewUser_DataGrid.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // biographyDataGridViewTextBoxColumn
            // 
            this.biographyDataGridViewTextBoxColumn.DataPropertyName = "Biography";
            this.biographyDataGridViewTextBoxColumn.HeaderText = "Biography";
            this.biographyDataGridViewTextBoxColumn.Name = "biographyDataGridViewTextBoxColumn";
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // emailConfirmedDataGridViewCheckBoxColumn
            // 
            this.emailConfirmedDataGridViewCheckBoxColumn.DataPropertyName = "EmailConfirmed";
            this.emailConfirmedDataGridViewCheckBoxColumn.HeaderText = "EmailConfirmed";
            this.emailConfirmedDataGridViewCheckBoxColumn.Name = "emailConfirmedDataGridViewCheckBoxColumn";
            // 
            // passwordHashDataGridViewTextBoxColumn
            // 
            this.passwordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash";
            this.passwordHashDataGridViewTextBoxColumn.Name = "passwordHashDataGridViewTextBoxColumn";
            // 
            // securityStampDataGridViewTextBoxColumn
            // 
            this.securityStampDataGridViewTextBoxColumn.DataPropertyName = "SecurityStamp";
            this.securityStampDataGridViewTextBoxColumn.HeaderText = "SecurityStamp";
            this.securityStampDataGridViewTextBoxColumn.Name = "securityStampDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // phoneNumberConfirmedDataGridViewCheckBoxColumn
            // 
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn.DataPropertyName = "PhoneNumberConfirmed";
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn.HeaderText = "PhoneNumberConfirmed";
            this.phoneNumberConfirmedDataGridViewCheckBoxColumn.Name = "phoneNumberConfirmedDataGridViewCheckBoxColumn";
            // 
            // twoFactorEnabledDataGridViewCheckBoxColumn
            // 
            this.twoFactorEnabledDataGridViewCheckBoxColumn.DataPropertyName = "TwoFactorEnabled";
            this.twoFactorEnabledDataGridViewCheckBoxColumn.HeaderText = "TwoFactorEnabled";
            this.twoFactorEnabledDataGridViewCheckBoxColumn.Name = "twoFactorEnabledDataGridViewCheckBoxColumn";
            // 
            // lockoutEndDateUtcDataGridViewTextBoxColumn
            // 
            this.lockoutEndDateUtcDataGridViewTextBoxColumn.DataPropertyName = "LockoutEndDateUtc";
            this.lockoutEndDateUtcDataGridViewTextBoxColumn.HeaderText = "LockoutEndDateUtc";
            this.lockoutEndDateUtcDataGridViewTextBoxColumn.Name = "lockoutEndDateUtcDataGridViewTextBoxColumn";
            // 
            // lockoutEnabledDataGridViewCheckBoxColumn
            // 
            this.lockoutEnabledDataGridViewCheckBoxColumn.DataPropertyName = "LockoutEnabled";
            this.lockoutEnabledDataGridViewCheckBoxColumn.HeaderText = "LockoutEnabled";
            this.lockoutEnabledDataGridViewCheckBoxColumn.Name = "lockoutEnabledDataGridViewCheckBoxColumn";
            // 
            // accessFailedCountDataGridViewTextBoxColumn
            // 
            this.accessFailedCountDataGridViewTextBoxColumn.DataPropertyName = "AccessFailedCount";
            this.accessFailedCountDataGridViewTextBoxColumn.HeaderText = "AccessFailedCount";
            this.accessFailedCountDataGridViewTextBoxColumn.Name = "accessFailedCountDataGridViewTextBoxColumn";
            // 
            // collaboratorsDataGridViewTextBoxColumn
            // 
            this.collaboratorsDataGridViewTextBoxColumn.DataPropertyName = "Collaborators";
            this.collaboratorsDataGridViewTextBoxColumn.HeaderText = "Collaborators";
            this.collaboratorsDataGridViewTextBoxColumn.Name = "collaboratorsDataGridViewTextBoxColumn";
            // 
            // collaborators1DataGridViewTextBoxColumn
            // 
            this.collaborators1DataGridViewTextBoxColumn.DataPropertyName = "Collaborators1";
            this.collaborators1DataGridViewTextBoxColumn.HeaderText = "Collaborators1";
            this.collaborators1DataGridViewTextBoxColumn.Name = "collaborators1DataGridViewTextBoxColumn";
            // 
            // userClaimsDataGridViewTextBoxColumn
            // 
            this.userClaimsDataGridViewTextBoxColumn.DataPropertyName = "UserClaims";
            this.userClaimsDataGridViewTextBoxColumn.HeaderText = "UserClaims";
            this.userClaimsDataGridViewTextBoxColumn.Name = "userClaimsDataGridViewTextBoxColumn";
            // 
            // userLocationsDataGridViewTextBoxColumn
            // 
            this.userLocationsDataGridViewTextBoxColumn.DataPropertyName = "UserLocations";
            this.userLocationsDataGridViewTextBoxColumn.HeaderText = "UserLocations";
            this.userLocationsDataGridViewTextBoxColumn.Name = "userLocationsDataGridViewTextBoxColumn";
            // 
            // userLoginsDataGridViewTextBoxColumn
            // 
            this.userLoginsDataGridViewTextBoxColumn.DataPropertyName = "UserLogins";
            this.userLoginsDataGridViewTextBoxColumn.HeaderText = "UserLogins";
            this.userLoginsDataGridViewTextBoxColumn.Name = "userLoginsDataGridViewTextBoxColumn";
            // 
            // skillsDataGridViewTextBoxColumn
            // 
            this.skillsDataGridViewTextBoxColumn.DataPropertyName = "Skills";
            this.skillsDataGridViewTextBoxColumn.HeaderText = "Skills";
            this.skillsDataGridViewTextBoxColumn.Name = "skillsDataGridViewTextBoxColumn";
            // 
            // rolesDataGridViewTextBoxColumn
            // 
            this.rolesDataGridViewTextBoxColumn.DataPropertyName = "Roles";
            this.rolesDataGridViewTextBoxColumn.HeaderText = "Roles";
            this.rolesDataGridViewTextBoxColumn.Name = "rolesDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(DatabaseManagementForms.Users);
            // 
            // AddUser_contextMenuStrip
            // 
            this.AddUser_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUser_toolStrip_delete});
            this.AddUser_contextMenuStrip.Name = "AddUser_contextMenuStrip";
            this.AddUser_contextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // AddUser_toolStrip_delete
            // 
            this.AddUser_toolStrip_delete.Name = "AddUser_toolStrip_delete";
            this.AddUser_toolStrip_delete.Size = new System.Drawing.Size(107, 22);
            this.AddUser_toolStrip_delete.Text = "Delete";
            // 
            // CreateRandomUserButton
            // 
            this.CreateRandomUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateRandomUserButton.AutoSize = true;
            this.CreateRandomUserButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateRandomUserButton.Location = new System.Drawing.Point(8, 6);
            this.CreateRandomUserButton.Name = "CreateRandomUserButton";
            this.CreateRandomUserButton.Size = new System.Drawing.Size(151, 27);
            this.CreateRandomUserButton.TabIndex = 0;
            this.CreateRandomUserButton.Text = "Create Random User";
            this.CreateRandomUserButton.UseVisualStyleBackColor = true;
            this.CreateRandomUserButton.Click += new System.EventHandler(this.CreateRandomUser_Click);
            // 
            // AddUsersBulkTab
            // 
            this.AddUsersBulkTab.Controls.Add(this.BulkCreateRandomUsers_button);
            this.AddUsersBulkTab.Controls.Add(this.BulkAdd_dataGridView);
            this.AddUsersBulkTab.Location = new System.Drawing.Point(4, 25);
            this.AddUsersBulkTab.Name = "AddUsersBulkTab";
            this.AddUsersBulkTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddUsersBulkTab.Size = new System.Drawing.Size(1068, 485);
            this.AddUsersBulkTab.TabIndex = 1;
            this.AddUsersBulkTab.Text = "Bulk Add";
            this.AddUsersBulkTab.UseVisualStyleBackColor = true;
            // 
            // BulkCreateRandomUsers_button
            // 
            this.BulkCreateRandomUsers_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BulkCreateRandomUsers_button.AutoSize = true;
            this.BulkCreateRandomUsers_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BulkCreateRandomUsers_button.Location = new System.Drawing.Point(8, 6);
            this.BulkCreateRandomUsers_button.Name = "BulkCreateRandomUsers_button";
            this.BulkCreateRandomUsers_button.Size = new System.Drawing.Size(158, 27);
            this.BulkCreateRandomUsers_button.TabIndex = 6;
            this.BulkCreateRandomUsers_button.Text = "Create Random Users";
            this.BulkCreateRandomUsers_button.UseVisualStyleBackColor = true;
            this.BulkCreateRandomUsers_button.Click += new System.EventHandler(this.BulkCreateRandomUsers_button_Click);
            // 
            // BulkAdd_dataGridView
            // 
            this.BulkAdd_dataGridView.AutoGenerateColumns = false;
            this.BulkAdd_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BulkAdd_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.BulkAdd_dataGridView.DataSource = this.usersBindingSource;
            this.BulkAdd_dataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.BulkAdd_dataGridView.Location = new System.Drawing.Point(172, 3);
            this.BulkAdd_dataGridView.Name = "BulkAdd_dataGridView";
            this.BulkAdd_dataGridView.Size = new System.Drawing.Size(893, 479);
            this.BulkAdd_dataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Biography";
            this.dataGridViewTextBoxColumn5.HeaderText = "Biography";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Created";
            this.dataGridViewTextBoxColumn6.HeaderText = "Created";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "EmailConfirmed";
            this.dataGridViewCheckBoxColumn1.HeaderText = "EmailConfirmed";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PasswordHash";
            this.dataGridViewTextBoxColumn8.HeaderText = "PasswordHash";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SecurityStamp";
            this.dataGridViewTextBoxColumn9.HeaderText = "SecurityStamp";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn10.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "PhoneNumberConfirmed";
            this.dataGridViewCheckBoxColumn2.HeaderText = "PhoneNumberConfirmed";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "TwoFactorEnabled";
            this.dataGridViewCheckBoxColumn3.HeaderText = "TwoFactorEnabled";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LockoutEndDateUtc";
            this.dataGridViewTextBoxColumn11.HeaderText = "LockoutEndDateUtc";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "LockoutEnabled";
            this.dataGridViewCheckBoxColumn4.HeaderText = "LockoutEnabled";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "AccessFailedCount";
            this.dataGridViewTextBoxColumn12.HeaderText = "AccessFailedCount";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Collaborators";
            this.dataGridViewTextBoxColumn13.HeaderText = "Collaborators";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Collaborators1";
            this.dataGridViewTextBoxColumn14.HeaderText = "Collaborators1";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "UserClaims";
            this.dataGridViewTextBoxColumn15.HeaderText = "UserClaims";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "UserLocations";
            this.dataGridViewTextBoxColumn16.HeaderText = "UserLocations";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "UserLogins";
            this.dataGridViewTextBoxColumn17.HeaderText = "UserLogins";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Skills";
            this.dataGridViewTextBoxColumn18.HeaderText = "Skills";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Roles";
            this.dataGridViewTextBoxColumn19.HeaderText = "Roles";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1076, 514);
            this.Controls.Add(this.AddUsersTabcontrol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddUser";
            this.Text = "Add Users";
            this.AddUsersTabcontrol.ResumeLayout(false);
            this.AddUserTab.ResumeLayout(false);
            this.AddUserTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewUser_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.AddUser_contextMenuStrip.ResumeLayout(false);
            this.AddUsersBulkTab.ResumeLayout(false);
            this.AddUsersBulkTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulkAdd_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AddUsersTabcontrol;
        private System.Windows.Forms.TabPage AddUsersBulkTab;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.TabPage AddUserTab;
        private System.Windows.Forms.Button SaveChanges_button;
        private System.Windows.Forms.Button CreateRandomUserButton;
        private System.Windows.Forms.DataGridView NewUser_DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biographyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn emailConfirmedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn phoneNumberConfirmedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn twoFactorEnabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockoutEndDateUtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lockoutEnabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessFailedCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collaboratorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collaborators1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userClaimsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLocationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLoginsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BulkCreateRandomUsers_button;
        private System.Windows.Forms.DataGridView BulkAdd_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.ContextMenuStrip AddUser_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddUser_toolStrip_delete;
    }
}