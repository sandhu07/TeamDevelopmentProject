using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Class_Library
{ 
    ///This class uses the dynamic type to provide generic collection class functionality
    ///add, update, delete and list
    ///it is free for use by anybody so long as you give credit to the original author i.e me
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2014
    ///NOTES
    ///property / attribute and parameter names must be consistent
    ///must have a find method in the associated class definition
    ///the first Attribute in dbDef must be the primary key name


    public class clsDBCollection
    {
        //data member for a single record
        object currentItem;
        //data member for db connection
        clsDataConnection dbCon;
        //stores the collection data
        List<object> itemList = new List<object>();
        //contains the data definition
        clsDataDefinition dbDef = new clsDataDefinition();

        //public property for a single record
        public dynamic CurrentItem
        {
            get
            {
                return currentItem;
            }
            set
            {
                currentItem = value;
            }
        }

        //public property for the data definition
        protected clsDataDefinition DBDef
        {
            get
            {
                return dbDef;
            }
            set
            {
                dbDef = value;
            }
        }

        //used to initialise the definition
        protected void InitDef()
        {
            currentItem = dbDef.ItemDefinition;
        }


        //public property for the collection
        protected List<object> ItemList
        {
            get
            {
                return itemList;
            }
            set
            {
                itemList = value;
            }
        }

        //protected property for the database connection
        protected clsDataConnection DBCon
        {
            get
            {
                return dbCon;
            }
            set
            {
                dbCon = value;
            }
        }

        //public property for the count
        public Int32 Count
        {
            get
            {
                return dbCon.Count;
            }
        }

        ///this function deletes a record in the database
        public void Delete()
        ///it is a void function and returns no value
        {
            object SomeData = "";
            //initialise the Connection
            DBCon = new clsDataConnection();
            //add the parameter data used by the stored procedure
            SomeData = GetPVal(currentItem, dbDef.Attributes[0]);
            DBCon.AddParameter(dbDef.Attributes[0], SomeData);
            //execute the stored procedure to delete the address
            DBCon.Execute(dbDef.Delete);
        }

        //function for the public Update method
        public void Update()
        {
            //this function updates an existing record
            //it returns no value

            DBCon = new clsDataConnection();
            object SomeData = "";
            foreach (string AnAttribute in dbDef.Attributes)
            {
                SomeData = GetPVal(currentItem, AnAttribute);
                DBCon.AddParameter(AnAttribute, SomeData);
            }
            //execute the query
            DBCon.Execute(dbDef.Update);
        }

        //function for the public Add method
        public Int32 Add()
        {
            //this function adds a new record to the database returning the primary key value of the new record

            //var to store the primary key value of the new record
            Int32 PrimaryKey;
            //reset the connection to the database
            DBCon = new clsDataConnection();
            object SomeData = "";
            foreach (string AnAttribute in dbDef.Attributes)
            {
                if (AnAttribute != dbDef.Attributes[0])
                {
                    SomeData = GetPVal(currentItem, AnAttribute);
                    DBCon.AddParameter(AnAttribute, SomeData);
                }
            }
            //execute the query to add the record - it will return the primary key value of the new record
            PrimaryKey = DBCon.Execute(dbDef.Insert);
            //return the primary key value of the new record
            return PrimaryKey;
        }

        //exsposes a list of objects of the type of ItemDefinition
        public List<object> List
        {
            get
            {
                //var to store the primary key value
                Int32 PKValue;
                //var to store the index
                Int32 Index = 0;
                //while there are record to process
                while (Index < DBCon.Count)
                {
                    //get the primary key value
                    PKValue = Convert.ToInt32(DBCon.DataTable.Rows[Index][dbDef.Attributes[0]]);
                    //get the type of the ItemDefinition
                    Type itemType = dbDef.ItemDefinition.GetType();
                    //create an instance of the class
                    dynamic entry = Activator.CreateInstance(itemType);
                    //find the record for this primary key value
                    entry.Find(PKValue);
                    //inc the index
                    Index++;
                    //add the item to the list
                    ItemList.Add(entry);
                }
                return ItemList;
            }
        }

        //this function gets the value of a specified property
        private object GetPVal(object SomeObject, string PName)
        {
            //get the type of the object
            Type myType = SomeObject.GetType();
            //get the property
            PropertyInfo propValue = myType.GetProperty(PName);
            //return the property value
            return propValue.GetValue(SomeObject, null);
        }


    }
}
