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
        private void Form1_Load(object sender, EventArgs e)
        {
            var contacts = _service.GetContacts();
            FillGridView(contacts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var contacts = _service.GetContacts();

            Contact newContact = new Contact();
            newContact.Firstname = txt_firstname.Text;
            newContact.Lastname = txt_lastname.Text;
            newContact.PhoneNumber = txt_phoneNumber.Text;

            newContact.Id = Guid.NewGuid();
            //contacts.Add(newContact);
           
            var saveResult = _service.SaveContact(newContact);

            if (saveResult)
            {
                var contacts = _service.GetContacts();
                FillGridView(contacts);
            }
            

            
        }

        public void FillGridView(List<Contact> model)
        {
            grd_contacts.Rows.Clear();
            foreach (Contact contact in model)
            {
                grd_contacts.Rows.Add(contact.Id, contact.Firstname, contact.Lastname, contact.PhoneNumber);
            }
        }

       
    }
}
