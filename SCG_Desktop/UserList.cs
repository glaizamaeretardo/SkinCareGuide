using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCG_BusinessLogic;
using SCG_Common;
using SCG_DataLogic;

namespace SCG_Desktop
{
    public partial class UserList : Form
    {
        private readonly SCGData data;
        public UserList()
        {
            InitializeComponent();

            data = new SCGData();
            Load += UserList_Load;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListReference.SelectedIndex == -1)
            {
                MessageBox.Show("Select a user to delete!");
                return;
            }

            string selectedItem = ListReference.SelectedItem.ToString();
            string name = selectedItem.Split('-')[0].Trim();

            bool deleted = data.DeleteUserDetails(name);

            if (deleted)
            {
                MessageBox.Show("The user has been deleted.");
                RefreshUserList();
            }

            else
            {
                MessageBox.Show("Failed to delete!");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void RefreshUserList()
        {
            ListReference.Items.Clear();
            var users = data.GetAllUserDetails();

            foreach (var user in users)
            {
                string skinTypeName = ((SkinType) user.SkinType).ToString();
                ListReference.Items.Add($"{user.Name} - {skinTypeName}");
            }
        }

        private void lblListHeader_Click(object sender, EventArgs e)
        {

        }

        private void ListReference_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}