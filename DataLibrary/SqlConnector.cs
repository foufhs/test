using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary
{
    public class SqlConnector : IDataConnection
    {
        public PersonData createData(PersonData dataLib)
        {
            dataLib.id = 1;
            dataLib.Name = "";
            dataLib.Surname = "";
            return dataLib;
        }
    }
}
