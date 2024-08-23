using Models;
using Repository;

namespace Service
{
    public class PhoneBookService
    {
        PhoneBookRepository _repo;
        public PhoneBookService()
        {
            _repo = new PhoneBookRepository();
        }

        public List<Contact> GetContacts()
        {
            return _repo.GetContacts();
        }

        public bool SaveContact(Contact model)
        {
            List<Contact> contacts = GetContacts();

            if (model.Id == Guid.Empty) {
                model.Id = Guid.NewGuid();
            }
            contacts.Add(model);

            return _repo.SaveContact(contacts);
        }
        public bool SaveContactList(List<Contact> contacts)
        {
            return _repo.SaveContact(contacts);
        }
        public bool DeleteContact(string id)
        {
            try
            {
                var contacts = GetContacts();
                var contact = contacts.FirstOrDefault(x => x.Id.ToString() == id);
                contacts.Remove(contact);
                _repo.SaveContact(contacts);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
