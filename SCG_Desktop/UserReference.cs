using SCG_BusinessLogic;
using SCG_Common;
using SCG_DataLogic;
using System.Security.Cryptography.Xml;

namespace SCG_Desktop
{
    public partial class UserReference : Form
    {

        private readonly SCGData data;
        public UserReference()
        {
            InitializeComponent();

            data = new SCGData(); //to connect in SCGData
            Load += UserReference_Load;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name!");
                return;
            }

            if (cmbSkinType.SelectedItem is not cmbItems selectedItem)
            {
                MessageBox.Show("Please select the skin type that has been determined for you!");
                return;
            }

            int skinTypeInt = selectedItem.Value;

            data.SaveUserDetails(name, skinTypeInt);
            MessageBox.Show("Saved successfully!");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        public class cmbItems
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public cmbItems(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void UserReference_Load(object sender, EventArgs e)
        {
            cmbSkinType.Items.AddRange(new object[]
            {
                new cmbItems("1 - Oily", 1),
                new cmbItems("2 - Dry", 2),
                new cmbItems("3 - Sensitive", 3),
                new cmbItems("4 - Combination", 4),
                new cmbItems("5 - Normal", 5)
            });
        }
        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
        private void lblSkinType_Click(object sender, EventArgs e)
        {

        }

        private void cmbSkinType_SelectedIndexChanged(object sender, EventArgs e) 
        {

        }

        private void listForUsers_Click(object sender, EventArgs e)
        {
            UserList listForm = new UserList();
            listForm.ShowDialog();
        }
    }
}