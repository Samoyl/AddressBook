using AddressBook.Abstractions.Interfaces;

namespace AddressBook.Abstractions
{
    public class Constants : IConstants
    {
        public string PathToAddressFile
        {
            get { return @"C:\Users\Samoyl\Desktop\aca\nacka-admin-master\AddressBook\addressbook.txt"; }
        }
        
        public string PathToLogFile
        {
            get { return @"C:\Users\Samoyl\Desktop\aca\nacka-admin-master\AddressBook\logs.txt"; }
        }

        public string Contacts
        {
            get { return "CONTACTS"; }
        }
    }
}