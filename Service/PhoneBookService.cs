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
    }
}
