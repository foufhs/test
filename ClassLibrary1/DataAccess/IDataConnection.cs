using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.DataAccess
{
    public interface IDataConnection
    {
        PersonData CreatePerson(PersonData person);
    }
}
