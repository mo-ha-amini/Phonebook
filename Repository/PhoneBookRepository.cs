using Models;
using Newtonsoft.Json;

namespace Repository
{
    public class PhoneBookRepository
    {
        string filePath = @"D:\Codes\Behsa\data.json";

        public PhoneBookRepository()
        {
            if (!System.IO.File.Exists(filePath)) 
            {
                System.IO.File.Create(filePath);
            }
        }

        public List<Contact> GetContacts()
        {
            var result = new List<Contact>();
            try
            {
                var fileString = System.IO.File.ReadAllText(filePath);
                result = JsonConvert.DeserializeObject<List<Contact>>(fileString);
                if (result == null)
                {
                    result = new List<Contact>();
                }
                bool hasInvalidId = false;
                foreach (var contact in result)
                {
                    if(contact.Id == null || contact.Id == Guid.Empty)
                    {
                        hasInvalidId = true;
                        contact.Id = Guid.NewGuid();
                    }
                }
                if (hasInvalidId)
                {
                    SaveContact(result);
                }
            }
            catch (Exception) { }
            return result;
        }

        public bool SaveContact(List<Contact> model)
        {
            try
            {
                var stringModel = JsonConvert.SerializeObject(model);
                System.IO.File.WriteAllText(filePath, stringModel);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
