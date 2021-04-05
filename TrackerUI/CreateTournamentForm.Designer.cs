
namespace TrackerUI
{
   partial class CreateTournamentForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
         this.headerLabel = new System.Windows.Forms.Label();
         this.tournamentNameLabel = new System.Windows.Forms.Label();
         this.tournamentNameValue = new System.Windows.Forms.TextBox();
         this.entryFeeValue = new System.Windows.Forms.TextBox();
         this.entryFeeLabel = new System.Windows.Forms.Label();
         this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
         this.selectTeamLabel = new System.Windows.Forms.Label();
         this.createNewTeamLabel = new System.Windows.Forms.LinkLabel();
         this.addTeamButton = new System.Windows.Forms.Button();
         this.createPrizeButton = new System.Windows.Forms.Button();
         this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
         this.tournamentPlayersLabel = new System.Windows.Forms.Label();
         this.deleteSelectedPlayers = new System.Windows.Forms.Button();
         this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
         this.prizesLabel = new System.Windows.Forms.Label();
         this.prizesListBox = new System.Windows.Forms.ListBox();
         this.createTournamentButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // headerLabel
         // 
         this.headerLabel.AutoSize = true;
         this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.headerLabel.Location = new System.Drawing.Point(12, 9);
         this.headerLabel.Name = "headerLabel";
         this.headerLabel.Size = new System.Drawing.Size(317, 50);
         this.headerLabel.TabIndex = 1;
         this.headerLabel.Text = "Create Tournament";
         // 
         // tournamentNameLabel
         // 
         this.tournamentNameLabel.AutoSize = true;
         this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.tournamentNameLabel.Location = new System.Drawing.Point(29, 85);
         this.tournamentNameLabel.Name = "tournamentNameLabel";
         this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
         this.tournamentNameLabel.TabIndex = 8;
         this.tournamentNameLabel.Text = "Tournament Name";
         // 
         // tournamentNameValue
         // 
         this.tournamentNameValue.Location = new System.Drawing.Point(36, 125);
         this.tournamentNameValue.Name = "tournamentNameValue";
         this.tournamentNameValue.Size = new System.Drawing.Size(293, 35);
         this.tournamentNameValue.TabIndex = 9;
         // 
         // entryFeeValue
         // 
         this.entryFeeValue.Location = new System.Drawing.Point(165, 196);
         this.entryFeeValue.Name = "entryFeeValue";
         this.entryFeeValue.Size = new System.Drawing.Size(100, 35);
         this.entryFeeValue.TabIndex = 11;
         this.entryFeeValue.Text = "0";
         // 
         // entryFeeLabel
         // 
         this.entryFeeLabel.AutoSize = true;
         this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.entryFeeLabel.Location = new System.Drawing.Point(29, 193);
         this.entryFeeLabel.Name = "entryFeeLabel";
         this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
         this.entryFeeLabel.TabIndex = 10;
         this.entryFeeLabel.Text = "Entry Fee";
         // 
         // selectTeamDropDown
         // 
         this.selectTeamDropDown.FormattingEnabled = true;
         this.selectTeamDropDown.Location = new System.Drawing.Point(36, 299);
         this.selectTeamDropDown.Name = "selectTeamDropDown";
         this.selectTeamDropDown.Size = new System.Drawing.Size(293, 38);
         this.selectTeamDropDown.TabIndex = 13;
         // 
         // selectTeamLabel
         // 
         this.selectTeamLabel.AutoSize = true;
         this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.selectTeamLabel.Location = new System.Drawing.Point(29, 259);
         this.selectTeamLabel.Name = "selectTeamLabel";
         this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
         this.selectTeamLabel.TabIndex = 12;
         this.selectTeamLabel.Text = "Select Team";
         // 
         // createNewTeamLabel
         // 
         this.createNewTeamLabel.AutoSize = true;
         this.createNewTeamLabel.Location = new System.Drawing.Point(224, 265);
         this.createNewTeamLabel.Name = "createNewTeamLabel";
         this.createNewTeamLabel.Size = new System.Drawing.Size(114, 30);
         this.createNewTeamLabel.TabIndex = 14;
         this.createNewTeamLabel.TabStop = true;
         this.createNewTeamLabel.Text = "create new";
         // 
         // addTeamButton
         // 
         this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
         this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
         this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.addTeamButton.Location = new System.Drawing.Point(86, 353);
         this.addTeamButton.Name = "addTeamButton";
         this.addTeamButton.Size = new System.Drawing.Size(179, 46);
         this.addTeamButton.TabIndex = 15;
         this.addTeamButton.Text = "Add Team";
         this.addTeamButton.UseVisualStyleBackColor = true;
         // 
         // createPrizeButton
         // 
         this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
         this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
         this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.createPrizeButton.Location = new System.Drawing.Point(86, 416);
         this.createPrizeButton.Name = "createPrizeButton";
         this.createPrizeButton.Size = new System.Drawing.Size(179, 46);
         this.createPrizeButton.TabIndex = 16;
         this.createPrizeButton.Text = "Create Prize";
         this.createPrizeButton.UseVisualStyleBackColor = true;
         // 
         // tournamentPlayersListBox
         // 
         this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.tournamentPlayersListBox.FormattingEnabled = true;
         this.tournamentPlayersListBox.ItemHeight = 30;
         this.tournamentPlayersListBox.Location = new System.Drawing.Point(401, 125);
         this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
         this.tournamentPlayersListBox.Size = new System.Drawing.Size(302, 152);
         this.tournamentPlayersListBox.TabIndex = 17;
         // 
         // tournamentPlayersLabel
         // 
         this.tournamentPlayersLabel.AutoSize = true;
         this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.tournamentPlayersLabel.Location = new System.Drawing.Point(394, 85);
         this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
         this.tournamentPlayersLabel.Size = new System.Drawing.Size(198, 37);
         this.tournamentPlayersLabel.TabIndex = 18;
         this.tournamentPlayersLabel.Text = "Teams / Players";
         // 
         // deleteSelectedPlayers
         // 
         this.deleteSelectedPlayers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.deleteSelectedPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
         this.deleteSelectedPlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
         this.deleteSelectedPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.deleteSelectedPlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.deleteSelectedPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.deleteSelectedPlayers.Location = new System.Drawing.Point(723, 158);
         this.deleteSelectedPlayers.Name = "deleteSelectedPlayers";
         this.deleteSelectedPlayers.Size = new System.Drawing.Size(112, 73);
         this.deleteSelectedPlayers.TabIndex = 19;
         this.deleteSelectedPlayers.Text = "Delete Selected";
         this.deleteSelectedPlayers.UseVisualStyleBackColor = true;
         // 
         // deleteSelectedPrizeButton
         // 
         this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
         this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
         this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(723, 385);
         this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
         this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(112, 77);
         this.deleteSelectedPrizeButton.TabIndex = 22;
         this.deleteSelectedPrizeButton.Text = "Delete Selected";
         this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
         // 
         // prizesLabel
         // 
         this.prizesLabel.AutoSize = true;
         this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.prizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.prizesLabel.Location = new System.Drawing.Point(394, 300);
         this.prizesLabel.Name = "prizesLabel";
         this.prizesLabel.Size = new System.Drawing.Size(198, 37);
         this.prizesLabel.TabIndex = 21;
         this.prizesLabel.Text = "Teams / Players";
         // 
         // prizesListBox
         // 
         this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.prizesListBox.FormattingEnabled = true;
         this.prizesListBox.ItemHeight = 30;
         this.prizesListBox.Location = new System.Drawing.Point(401, 340);
         this.prizesListBox.Name = "prizesListBox";
         this.prizesListBox.Size = new System.Drawing.Size(302, 152);
         this.prizesListBox.TabIndex = 20;
         // 
         // createTournamentButton
         // 
         this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
         this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
         this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
         this.createTournamentButton.Location = new System.Drawing.Point(269, 508);
         this.createTournamentButton.Name = "createTournamentButton";
         this.createTournamentButton.Size = new System.Drawing.Size(245, 46);
         this.createTournamentButton.TabIndex = 23;
         this.createTournamentButton.Text = "Create Tournament";
         this.createTournamentButton.UseVisualStyleBackColor = true;
         // 
         // CreateTournamentForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(847, 566);
         this.Controls.Add(this.createTournamentButton);
         this.Controls.Add(this.deleteSelectedPrizeButton);
         this.Controls.Add(this.prizesLabel);
         this.Controls.Add(this.prizesListBox);
         this.Controls.Add(this.deleteSelectedPlayers);
         this.Controls.Add(this.tournamentPlayersLabel);
         this.Controls.Add(this.tournamentPlayersListBox);
         this.Controls.Add(this.createPrizeButton);
         this.Controls.Add(this.addTeamButton);
         this.Controls.Add(this.createNewTeamLabel);
         this.Controls.Add(this.selectTeamDropDown);
         this.Controls.Add(this.selectTeamLabel);
         this.Controls.Add(this.entryFeeValue);
         this.Controls.Add(this.entryFeeLabel);
         this.Controls.Add(this.tournamentNameValue);
         this.Controls.Add(this.tournamentNameLabel);
         this.Controls.Add(this.headerLabel);
         this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
         this.Name = "CreateTournamentForm";
         this.Text = "Create Tournament";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label headerLabel;
      private System.Windows.Forms.Label tournamentNameLabel;
      private System.Windows.Forms.TextBox tournamentNameValue;
      private System.Windows.Forms.TextBox entryFeeValue;
      private System.Windows.Forms.Label entryFeeLabel;
      private System.Windows.Forms.ComboBox selectTeamDropDown;
      private System.Windows.Forms.Label selectTeamLabel;
      private System.Windows.Forms.LinkLabel createNewTeamLabel;
      private System.Windows.Forms.Button addTeamButton;
      private System.Windows.Forms.Button createPrizeButton;
      private System.Windows.Forms.ListBox tournamentPlayersListBox;
      private System.Windows.Forms.Label tournamentPlayersLabel;
      private System.Windows.Forms.Button deleteSelectedPlayers;
      private System.Windows.Forms.Button deleteSelectedPrizeButton;
      private System.Windows.Forms.Label prizesLabel;
      private System.Windows.Forms.ListBox prizesListBox;
      private System.Windows.Forms.Button createTournamentButton;
   }
}