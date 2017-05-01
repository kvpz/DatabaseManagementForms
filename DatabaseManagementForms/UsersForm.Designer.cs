namespace DatabaseManagementForms
{
    partial class UsersForm
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
            this.FindUserLabel = new System.Windows.Forms.Label();
            this.FindUserTextbox = new System.Windows.Forms.TextBox();
            this.GetUserButton = new System.Windows.Forms.Button();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
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
            this.SaveModificationsButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FindUserLabel
            // 
            this.FindUserLabel.AutoSize = true;
            this.FindUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindUserLabel.Location = new System.Drawing.Point(12, 9);
            this.FindUserLabel.Name = "FindUserLabel";
            this.FindUserLabel.Size = new System.Drawing.Size(81, 17);
            this.FindUserLabel.TabIndex = 0;
            this.FindUserLabel.Text = "Find user:";
            // 
            // FindUserTextbox
            // 
            this.FindUserTextbox.Location = new System.Drawing.Point(109, 9);
            this.FindUserTextbox.Name = "FindUserTextbox";
            this.FindUserTextbox.Size = new System.Drawing.Size(180, 20);
            this.FindUserTextbox.TabIndex = 1;
            this.FindUserTextbox.Text = "Username/ firstname/ lastname";
            // 
            // GetUserButton
            // 
            this.GetUserButton.Location = new System.Drawing.Point(295, 9);
            this.GetUserButton.Name = "GetUserButton";
            this.GetUserButton.Size = new System.Drawing.Size(75, 20);
            this.GetUserButton.TabIndex = 2;
            this.GetUserButton.Text = "Get user";
            this.GetUserButton.UseVisualStyleBackColor = true;
            this.GetUserButton.Click += new System.EventHandler(this.GetUser_button_click);
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AllowUserToDeleteRows = false;
            this.UsersDataGrid.AutoGenerateColumns = false;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.UsersDataGrid.DataSource = this.usersBindingSource;
            this.UsersDataGrid.Location = new System.Drawing.Point(3, 129);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.Size = new System.Drawing.Size(1116, 150);
            this.UsersDataGrid.TabIndex = 3;
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
            // SaveModificationsButton
            // 
            this.SaveModificationsButton.Location = new System.Drawing.Point(1018, 285);
            this.SaveModificationsButton.Name = "SaveModificationsButton";
            this.SaveModificationsButton.Size = new System.Drawing.Size(101, 23);
            this.SaveModificationsButton.TabIndex = 4;
            this.SaveModificationsButton.Text = "Save Changes";
            this.SaveModificationsButton.UseVisualStyleBackColor = true;
            this.SaveModificationsButton.Click += new System.EventHandler(this.SaveChanges_button_click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(15, 100);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserButton.TabIndex = 5;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUser_button_click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1131, 429);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.SaveModificationsButton);
            this.Controls.Add(this.UsersDataGrid);
            this.Controls.Add(this.GetUserButton);
            this.Controls.Add(this.FindUserTextbox);
            this.Controls.Add(this.FindUserLabel);
            this.Name = "UsersForm";
            this.Text = "IdeallyConnected Users Form";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FindUserLabel;
        private System.Windows.Forms.TextBox FindUserTextbox;
        private System.Windows.Forms.Button GetUserButton;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.BindingSource usersBindingSource;
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
        private System.Windows.Forms.Button SaveModificationsButton;
        private System.Windows.Forms.Button AddUserButton;
    }
}

