﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.DataAccess
{
    public interface IDataConnection
    {
        List<PersonData> GetPerson_All();
        PersonData CreatePerson(PersonData person);
        int DeletePerson(PersonData model);
        void EditPerson(PersonData model, string name, string surname);
    }
}
