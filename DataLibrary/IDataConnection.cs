using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary
{
    public interface IDataConnection
    {
        PersonData createData(PersonData person);
    }
}
