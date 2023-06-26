using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookService
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IBookService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        Book GetBooks(int Id);
        [OperationContract]
        void SaveBooks(Book book);
    }
}
