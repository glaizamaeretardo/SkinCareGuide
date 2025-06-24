using SCG_BusinessLogic;
using SCG_Common;
using SCG_DataLogic;

namespace SCG_Desktop
{
    public partial class UserReferenceForm : Form
    {
        public UserReferenceForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text.Trim();
            string skinTypeInput = txtSkinTypeNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(skinTypeInput))
            {
                MessageBox.Show("Please enter your name and your determined skin type number!");

                return;
            }

            if (!int.TryParse(skinTypeInput, out int skinTypeNumber) || skinTypeNumber < 1 || skinTypeNumber > 5)
            {
                MessageBox.Show("Please enter a number from 1 to 5 only!");

                return;
            }

            SkinType selectedSkinType = (SkinType)(skinTypeNumber - 1);

            User user = new User(Name, selectedSkinType);

            SCGData data = new SCGData();
            data.SaveUserDetails(Name, skinTypeNumber - 1);

            MessageBox.Show("Successfully saved!");

        }
    }
}