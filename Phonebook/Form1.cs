using Models;
using Service;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        PhoneBookService _service = new PhoneBookService();
        private string selectedId = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var contacts = _service.GetContacts();
            FillGridView(contacts);
        }

        public void ClearForm()
        {
            txt_firstname.Text = string.Empty;
            txt_lastname.Text = string.Empty;
            txt_phoneNumber.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool saveResult = false;
            var index = grd_contacts.CurrentRow.Index;
            string? id = grd_contacts.Rows[index].Cells[0].Value.ToString();

            Contact newContact = new Contact();
            newContact.Firstname = txt_firstname.Text;
            newContact.Lastname = txt_lastname.Text;
            newContact.PhoneNumber = txt_phoneNumber.Text;

            if (!string.IsNullOrEmpty(selectedId))
            {
                var contacts = _service.GetContacts();
                var contact = contacts.FirstOrDefault(x => x.Id.ToString() == selectedId);
                contacts.Remove(contact);
                newContact.Id = Guid.Parse(selectedId);
                contacts.Add(newContact);
                saveResult = _service.SaveContactList(contacts);
                selectedId = "";
            }
            else
            {

                newContact.Id = Guid.NewGuid();
                saveResult = _service.SaveContact(newContact);

            }

            if (saveResult)
            {
                var contacts = _service.GetContacts();
                FillGridView(contacts);
            }
            ClearForm();
        }

        public void FillGridView(List<Contact> model)
        {
            grd_contacts.Rows.Clear();
            foreach (Contact contact in model)
            {
                grd_contacts.Rows.Add(contact.Id, contact.Firstname, contact.Lastname, contact.PhoneNumber);
            }
        }

        private void grd_contacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = grd_contacts.CurrentRow.Index;
            var id = grd_contacts.Rows[index].Cells[0].Value.ToString();
            var contacts = _service.GetContacts();

            try
            {
                var contactForEdit = contacts.FirstOrDefault(x => x.Id.ToString() == id);
                selectedId = id;

                txt_firstname.Text = contactForEdit.Firstname;
                txt_lastname.Text = contactForEdit.Lastname;
                txt_phoneNumber.Text = contactForEdit.PhoneNumber;
            }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedId))
            {
                var deletedResult = _service.DeleteContact(selectedId);
                var contacts = _service.GetContacts();
                FillGridView(contacts);
                selectedId = "";
                ClearForm();
            }
        }
    }
}
