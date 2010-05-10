using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sUCO.control.persistence
{
    class PersistenceFactory
    {
        public static Serializador toXML()
        {
            return new SerializadorXML();
        }

        public static Serializador toDB()
        {
            return new SerializadorDB();
        }
    }
}
