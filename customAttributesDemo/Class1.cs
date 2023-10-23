using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customAttributesDemo
{

    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Field| AttributeTargets.Interface, Inherited = true, AllowMultiple = true)]
     class DeveloperAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;

        // This is a positional argument
        public DeveloperAttribute(string positionalString)
        {
            this.positionalString = positionalString;

            // TODO: Implement code here

            throw new NotImplementedException();
        }

        public string PositionalString
        {
            get { return positionalString; }
        }

        // This is a named argument
        public int NamedInt { get; set; }

        public int Devid { get; set; }
        public string DevName { get; set; }
    }


    //public class DeveloperAttribute
    //{

    //}
}
