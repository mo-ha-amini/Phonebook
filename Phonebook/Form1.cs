using Models;
using Service;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        PhoneBookService _service = new PhoneBookService();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();
            newContact.Firstname= txt_firstname.Text;
            newContact.Lastname = txt_lastname.Text;
            newContact.PhoneNumber = txt_phoneNumber.Text;

            var saveResult = _service.SaveContact(newContact);
        }
    }
}
