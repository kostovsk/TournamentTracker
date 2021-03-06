using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
   public partial class CreateTeamForm : Form
   {
      private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
      private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

      public CreateTeamForm()
      {
         InitializeComponent();

         //CreateSampleData();

         WireUpLists();
      }

      private void CreateSampleData()
      {
         availableTeamMembers.Add(new PersonModel { FirstName = "Will", LastName = "Bades" });
         availableTeamMembers.Add(new PersonModel { FirstName = "Jim", LastName = "Gatwood" });

         selectedTeamMembers.Add(new PersonModel { FirstName = "John", LastName = "Jones" });
         selectedTeamMembers.Add(new PersonModel { FirstName = "Tyrone", LastName = "Woodley" });
      }

      private void WireUpLists()
      {
         selectTeamMemberDropDown.DataSource = null;

         selectTeamMemberDropDown.DataSource = availableTeamMembers;
         selectTeamMemberDropDown.DisplayMember = "FullName";

         teamMemberListBox.DataSource = null;

         teamMemberListBox.DataSource = selectedTeamMembers;
         teamMemberListBox.DisplayMember = "FullName";
      }

      private void createMemberButton_Click(object sender, EventArgs e)
      {
         if (ValidateForm())
         {
            PersonModel p = new PersonModel();

            p.FirstName = firstNameValue.Text;
            p.LastName = lastNameValue.Text;
            p.EmailAdress = emailValue.Text;
            p.CellphoneNumber = cellphoneValue.Text;

            p = GlobalConfig.Connection.CreatePerson(p);

            selectedTeamMembers.Add(p);

            WireUpLists();

            firstNameValue.Text = "";
            lastNameValue.Text = "";
            emailValue.Text = "";
            cellphoneValue.Text = "";
         }
         else {
            MessageBox.Show("You need to fill in all of the fields");
         }
      }

      private bool ValidateForm()
      {
         if (firstNameValue.Text.Length == 0)
         {
            return false;
         }

         if (lastNameValue.Text.Length == 0)
         {
            return false;
         }

         if (emailValue.Text.Length == 0)
         {
            return false;
         }

         if (cellphoneValue.Text.Length == 0)
         {
            return false;
         }

         return true;
      }

      private void addMemberButton_Click(object sender, EventArgs e)
      {
         PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

         if (p != null)
         {
            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            WireUpLists(); 
         }
      }

      private void removeSelectedMemberButton_Click(object sender, EventArgs e)
      {
         PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;

         if (p != null)
         {
            selectedTeamMembers.Remove(p);
            availableTeamMembers.Add(p);

            WireUpLists(); 
         }
      }

      private void createTeamButton_Click(object sender, EventArgs e)
      {
         TeamModel t = new TeamModel();

         t.TeamName = teamNameValue.Text;
         t.TeamMembers = selectedTeamMembers;

         t = GlobalConfig.Connection.CreateTeam(t);

         // TODO - if we aren't closing that form after creation, reset the form
      }
   }
}
