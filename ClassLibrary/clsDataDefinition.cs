using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class clsDataDefinition
    {
        private object itemDefinition;
        private List<string> attributes = new List<string>();
        private string insert = "";
        private string update = "";
        private string delete = "";

        //public property for Insert
        public string Insert
        {
            get
            {
                return insert;
            }
            set
            {
                insert = value;
            }
        }

        //public property for Update
        public string Update
        {
            get
            {
                return update;
            }
            set
            {
                update = value;
            }
        }

        //public property for Delete
        public string Delete
        {
            get
            {
                return delete;
            }
            set
            {
                delete = value;
            }
        }

        //public property for sample of item class
        public object ItemDefinition
        {
            get
            {
                return itemDefinition;
            }
            set
            {
                itemDefinition = value;
            }
        }

        //public collection for attributes
        public List<string> Attributes
        {
            get
            {
                return attributes;
            }
            set
            {
                attributes = value;
            }
        }
    }
}
