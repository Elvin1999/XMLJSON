using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLJSON
{
    [Serializable]
    public class Translator
    {
        [XmlArray(elementName:"TranslatorSubjects")]
        public List<Subject> Subjects { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Surname { get; set; }
        [XmlAttribute(AttributeName ="Identification")]
        public int Id { get; set; }

        public string Fullname => $"{Name} {Surname}";

        public override string ToString()
        {
            return $"{Id}   {Fullname}";
        }
        public Translator()
        {
        }
        public Translator(string name,string surname,int id)
        {
            Name = name;
            Surname = surname;
            Id = id;
        }

    }
}
