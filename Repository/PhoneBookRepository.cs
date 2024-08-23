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
