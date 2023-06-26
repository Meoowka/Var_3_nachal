using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    [DataContract]
    public class Book
    {
        private int Id;
        private string _name;
        private string _author;
        private DateTime _day_Pr;
        [DataMember]
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [DataMember]
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        [DataMember]
        public DateTime Day_Pr
        {
            get { return _day_Pr; }
            set
            {
                _day_Pr = value;
            }
        }
    }
}
