﻿
namespace TrackerUI
{
   partial class CreateTeamForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
         this.teamNameValue = new System.Windows.Forms.TextBox();
         this.teamNameLabel = new System.Windows.Forms.Label();
         this.headerLabel = new System.Windows.Forms.Label();
         this.addMemberButton = new System.Windows.Forms.Button();
         this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
         this.selectTeamMemberLabel = new System.Windows.Forms.Label();
         this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
         this.createMemberButton = new System.Windows.Forms.Button();
         this.cellphoneValue = new System.Windows.Forms.TextBox();
         this.cellphoneLabel = new System.Windows.Forms.Label();
         this.emailValue = new System.Windows.Forms.TextBox();
         this.emailLabel = new System.Windows.Forms.Label();
         this.lastNameValue = new System.Windows.Forms.TextBox();
         this.lastNameLabel = new System.Windows.Forms.Label();
         this.firstNameValue = new System.Windows.Forms.TextBox();
         this.firstNameLabel = new System.Windows.Forms.Label();
         this.teamMemberListBox = new System.Windows.Forms.ListBox();
         this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
         this.createTeamButton = new System.Windows.Forms.Button();
         this.addNewMemberGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // teamNameValue
         // 
         this.teamNameValue.Location = new System.Drawing.Point(21, 114);
         this.teamNameValue.Name = "teamNameValue";
         this.teamNameValue.Size = new System.Drawing.Size(358, 35);
         this.teamNameValue.TabIndex = 12;
         // 
         // teamNameLabel
         // 
         this.teamNameLabel.AutoSize = true;
         this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.teamNameLabel.Location = new System.Drawing.Point(14, 74);
         this.teamNameLabel.Name = "teamNameLabel";
         this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
         this.teamNameLabel.TabIndex = 11;
         this.teamNameLabel.Text = "Team Name";
         // 
         // headerLabel
         // 
         this.headerLabel.AutoSize = true;
         this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.headerLabel.Location = new System.Drawing.Point(12, 9);
         this.headerLabel.Name = "headerLabel";
         this.headerLabel.Size = new System.Drawing.Size(213, 50);
         this.headerLabel.TabIndex = 10;
         this.headerLabel.Text = "Create Team";
         // 
         // addMemberButton
         // 
         this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
         this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
         this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.addMemberButton.Location = new System.Drawing.Point(103, 254);
         this.addMemberButton.Name = "addMemberButton";
         this.addMemberButton.Size = new System.Drawing.Size(174, 46);
         this.addMemberButton.TabIndex = 18;
         this.addMemberButton.Text = "Add Member";
         this.addMemberButton.UseVisualStyleBackColor = true;
         // 
         // selectTeamMemberDropDown
         // 
         this.selectTeamMemberDropDown.FormattingEnabled = true;
         this.selectTeamMemberDropDown.Location = new System.Drawing.Point(21, 199);
         this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
         this.selectTeamMemberDropDown.Size = new System.Drawing.Size(358, 38);
         this.selectTeamMemberDropDown.TabIndex = 17;
         // 
         // selectTeamMemberLabel
         // 
         this.selectTeamMemberLabel.AutoSize = true;
         this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.selectTeamMemberLabel.Location = new System.Drawing.Point(14, 159);
         this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
         this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
         this.selectTeamMemberLabel.TabIndex = 16;
         this.selectTeamMemberLabel.Text = "Select Team Member";
         // 
         // addNewMemberGroupBox
         // 
         this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
         this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
         this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
         this.addNewMemberGroupBox.Controls.Add(this.emailValue);
         this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
         this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
         this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
         this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
         this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
         this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.addNewMemberGroupBox.Location = new System.Drawing.Point(21, 319);
         this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
         this.addNewMemberGroupBox.Size = new System.Drawing.Size(357, 307);
         this.addNewMemberGroupBox.TabIndex = 19;
         this.addNewMemberGroupBox.TabStop = false;
         this.addNewMemberGroupBox.Text = "Add New Member";
         // 
         // createMemberButton
         // 
         this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
         this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
         this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.createMemberButton.Location = new System.Drawing.Point(82, 238);
         this.createMemberButton.Name = "createMemberButton";
         this.createMemberButton.Size = new System.Drawing.Size(174, 51);
         this.createMemberButton.TabIndex = 28;
         this.createMemberButton.Text = "Create Member";
         this.createMemberButton.UseVisualStyleBackColor = true;
         this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
         // 
         // cellphoneValue
         // 
         this.cellphoneValue.Location = new System.Drawing.Point(166, 177);
         this.cellphoneValue.Name = "cellphoneValue";
         this.cellphoneValue.Size = new System.Drawing.Size(161, 43);
         this.cellphoneValue.TabIndex = 27;
         // 
         // cellphoneLabel
         // 
         this.cellphoneLabel.AutoSize = true;
         this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.cellphoneLabel.Location = new System.Drawing.Point(16, 180);
         this.cellphoneLabel.Name = "cellphoneLabel";
         this.cellphoneLabel.Size = new System.Drawing.Size(138, 37);
         this.cellphoneLabel.TabIndex = 26;
         this.cellphoneLabel.Text = "Cellphone";
         // 
         // emailValue
         // 
         this.emailValue.Location = new System.Drawing.Point(166, 131);
         this.emailValue.Name = "emailValue";
         this.emailValue.Size = new System.Drawing.Size(161, 43);
         this.emailValue.TabIndex = 25;
         // 
         // emailLabel
         // 
         this.emailLabel.AutoSize = true;
         this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.emailLabel.Location = new System.Drawing.Point(16, 134);
         this.emailLabel.Name = "emailLabel";
         this.emailLabel.Size = new System.Drawing.Size(82, 37);
         this.emailLabel.TabIndex = 24;
         this.emailLabel.Text = "Email";
         // 
         // lastNameValue
         // 
         this.lastNameValue.Location = new System.Drawing.Point(166, 85);
         this.lastNameValue.Name = "lastNameValue";
         this.lastNameValue.Size = new System.Drawing.Size(161, 43);
         this.lastNameValue.TabIndex = 23;
         // 
         // lastNameLabel
         // 
         this.lastNameLabel.AutoSize = true;
         this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.lastNameLabel.Location = new System.Drawing.Point(16, 88);
         this.lastNameLabel.Name = "lastNameLabel";
         this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
         this.lastNameLabel.TabIndex = 22;
         this.lastNameLabel.Text = "Last Name";
         // 
         // firstNameValue
         // 
         this.firstNameValue.Location = new System.Drawing.Point(166, 39);
         this.firstNameValue.Name = "firstNameValue";
         this.firstNameValue.Size = new System.Drawing.Size(161, 43);
         this.firstNameValue.TabIndex = 21;
         // 
         // firstNameLabel
         // 
         this.firstNameLabel.AutoSize = true;
         this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.firstNameLabel.Location = new System.Drawing.Point(16, 42);
         this.firstNameLabel.Name = "firstNameLabel";
         this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
         this.firstNameLabel.TabIndex = 20;
         this.firstNameLabel.Text = "First Name";
         // 
         // teamMemberListBox
         // 
         this.teamMemberListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.teamMemberListBox.FormattingEnabled = true;
         this.teamMemberListBox.ItemHeight = 30;
         this.teamMemberListBox.Location = new System.Drawing.Point(421, 114);
         this.teamMemberListBox.Name = "teamMemberListBox";
         this.teamMemberListBox.Size = new System.Drawing.Size(302, 512);
         this.teamMemberListBox.TabIndex = 20;
         // 
         // deleteSelectedMemberButton
         // 
         this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
         this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
         this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.deleteSelectedMemberButton.Location = new System.Drawing.Point(744, 352);
         this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
         this.deleteSelectedMemberButton.Size = new System.Drawing.Size(112, 73);
         this.deleteSelectedMemberButton.TabIndex = 21;
         this.deleteSelectedMemberButton.Text = "Delete Selected";
         this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
         // 
         // createTeamButton
         // 
         this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
         this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
         this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.createTeamButton.Location = new System.Drawing.Point(267, 657);
         this.createTeamButton.Name = "createTeamButton";
         this.createTeamButton.Size = new System.Drawing.Size(245, 46);
         this.createTeamButton.TabIndex = 24;
         this.createTeamButton.Text = "Create Team";
         this.createTeamButton.UseVisualStyleBackColor = true;
         // 
         // CreateTeamForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(868, 715);
         this.Controls.Add(this.createTeamButton);
         this.Controls.Add(this.deleteSelectedMemberButton);
         this.Controls.Add(this.teamMemberListBox);
         this.Controls.Add(this.addNewMemberGroupBox);
         this.Controls.Add(this.addMemberButton);
         this.Controls.Add(this.selectTeamMemberDropDown);
         this.Controls.Add(this.selectTeamMemberLabel);
         this.Controls.Add(this.teamNameValue);
         this.Controls.Add(this.teamNameLabel);
         this.Controls.Add(this.headerLabel);
         this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
         this.Name = "CreateTeamForm";
         this.Text = "Create Team";
         this.addNewMemberGroupBox.ResumeLayout(false);
         this.addNewMemberGroupBox.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox teamNameValue;
      private System.Windows.Forms.Label teamNameLabel;
      private System.Windows.Forms.Label headerLabel;
      private System.Windows.Forms.Button addMemberButton;
      private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
      private System.Windows.Forms.Label selectTeamMemberLabel;
      private System.Windows.Forms.GroupBox addNewMemberGroupBox;
      private System.Windows.Forms.TextBox firstNameValue;
      private System.Windows.Forms.Label firstNameLabel;
      private System.Windows.Forms.TextBox cellphoneValue;
      private System.Windows.Forms.Label cellphoneLabel;
      private System.Windows.Forms.TextBox emailValue;
      private System.Windows.Forms.Label emailLabel;
      private System.Windows.Forms.TextBox lastNameValue;
      private System.Windows.Forms.Label lastNameLabel;
      private System.Windows.Forms.Button createMemberButton;
      private System.Windows.Forms.ListBox teamMemberListBox;
      private System.Windows.Forms.Button deleteSelectedMemberButton;
      private System.Windows.Forms.Button createTeamButton;
   }
}