using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure Matrix as a guide). Use auto-implemented properties for the fields which must be of type “string”. Save the class as “Information.cs”.

namespace Wiki_Application
{
    internal class Information
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        public Information() { }
        public Information(string newName, string newCategory, string newStructure, string newDefinition)
        {
            name = newName;
            category = newCategory;
            structure = newStructure;
            definition = newDefinition;
        }

        public string gsName { get => name; set => name = value; }
        public string gsCategory { get => category; set => category = value; }
        public string gsStructure { get => structure; set => structure = value; }
        public string gsDefinition { get => definition; set => definition = value; }



    }
}
