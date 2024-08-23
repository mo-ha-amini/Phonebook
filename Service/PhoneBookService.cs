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

        public bool SaveContact(Contact model)
        {
            List<Contact> contacts = new List<Contact>();

            if (model.Id == Guid.Empty) {
                model.Id = Guid.NewGuid();
                contacts.Add(model);
            }
            return _repo.SaveContact(contacts);
        }
    }
}
