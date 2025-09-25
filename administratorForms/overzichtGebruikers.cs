using AquaPalace.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AquaPalace.administratorForms
{
    public partial class overzichtGebruikers : Form
    {
        public string username;
        public static overzichtGebruikers instance;

        public overzichtGebruikers()
        {
            InitializeComponent();

            instance = this;

            userroleCombobox.Items.Add("admin");
            userroleCombobox.Items.Add("werknemer");
            userroleCombobox.Items.Add("klant");
            userroleCombobox.Items.Add("geen rol");
        }

        private void terugbutton_Click(object sender, EventArgs e)
        {
            Administrator.instance.Show();
            this.Hide();
        }

        private void overzichtGebruikers_Load(object sender, EventArgs e)
        {
            listboxOverzicht.Items.Clear();
            foreach (User gebruikersobject in User.GetAll())
            {
                listboxOverzicht.Items.Add(gebruikersobject);
            }
        }

        private void listboxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            User gebruikersobject = listboxOverzicht.SelectedItem as User;
            idtextbox.Text = gebruikersobject.Id.ToString();
            voornaamtextbox.Text = gebruikersobject.FirstName;
            achternaamtextbox.Text = gebruikersobject.LastName;
            emailtextbox.Text = gebruikersobject.Email;
            gebruikersnaamtextbox.Text = gebruikersobject.Username;
            wachtwoordtextbox.Text = gebruikersobject.Password;

            int loopcount = 0;
            bool found = false;
            while (userroleCombobox.Items.Count > loopcount)
            {
                if (userroleCombobox.Items[loopcount].ToString() == gebruikersobject.Role)
                {
                    userroleCombobox.SelectedIndex = loopcount;
                    found = true;
                    break;
                }
                loopcount++;
            }
            if (found == false)
            {
                userroleCombobox.SelectedIndex = 4;
            }

        }

        private void invoerbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void wijzigenbutton_Click(object sender, EventArgs e)
        {
            User userObject = new User();
            User selecteduser = listboxOverzicht.SelectedItem as User;

            if (selecteduser != null)
            {
                userObject.FirstName = voornaamtextbox.Text;
                userObject.LastName = achternaamtextbox.Text;
                userObject.Email = emailtextbox.Text;
                userObject.Username = gebruikersnaamtextbox.Text;
                userObject.Password = wachtwoordtextbox.Text;
                userObject.Id = selecteduser.Id;
                userObject.Role = userroleCombobox.SelectedItem.ToString();

                int resultaat = User.UpdateDatabase(userObject);

                if (resultaat > 0)
                {
                    MessageBox.Show("Voltooid, geselecteerde user is veranderd");
                }
                else
                {
                    MessageBox.Show("Fout bij het veranderen van de geselecteerde user");
                }

                listboxOverzicht.Items.Clear();
                foreach (User gebruikersobject in User.GetAll())
                {
                    listboxOverzicht.Items.Add(gebruikersobject);
                }

                listboxOverzicht.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("Geen gebruiker geselecteerd");
            }
        }

        private void verwijderenbutton_Click(object sender, EventArgs e)
        {
            User userObject = new User();
            User selecteduser = listboxOverzicht.SelectedItem as User;

            if (selecteduser != null)
            {

                if (username == selecteduser.Username)
                {
                    MessageBox.Show("Fout, je kan niet je eigen account verwijderen");
                }
                else
                {
                    User.DeleteFromDatabase(selecteduser);
                    MessageBox.Show("geselecteerde gebruiker verwijderd");
                }


                listboxOverzicht.Items.Clear();
                foreach (User gebruikersobject in User.GetAll())
                {
                    listboxOverzicht.Items.Add(gebruikersobject);
                }

                listboxOverzicht.SelectedIndex = 0;

            }
            else
            {
                MessageBox.Show("Geen gebruiker geselecteerd");
            }
        }
    }
    }

