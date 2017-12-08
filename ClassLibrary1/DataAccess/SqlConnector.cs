using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataLibrary.DataAccess;
using System.Linq;
using DataLibrary;

namespace DataLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string databaseInuse = "Remote";

        public PersonData CreatePerson(PersonData personData)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(databaseInuse)))
            {
                var p = new DynamicParameters();
                p.Add("@name", personData.Name);
                p.Add("@surname", personData.Surname);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPersonData_insert", p, commandType: CommandType.StoredProcedure);

                personData.Id = p.Get<int>("@id");
                return personData;
            
            }
        }

        public void EditPerson(PersonData personData, string name, string surname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(databaseInuse)))
            {
                var p = new DynamicParameters();
                p.Add("@name", name);
                p.Add("@surname", surname);
                p.Add("@id", personData.Id);

                connection.Execute("dbo.spPersonData_update", p, commandType: CommandType.StoredProcedure);
               // return personData;

            }
        }

        public int DeletePerson(PersonData model)
        {
            int numberOfRecords;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(databaseInuse)))
            {

                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                numberOfRecords = connection.Execute("dbo.spDeletePerson", p, commandType: CommandType.StoredProcedure);

            }
            return numberOfRecords;
        }

        public List<PersonData> GetPerson_All()
        {
            List<PersonData> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(databaseInuse)))
            {
                output = connection.Query<PersonData>("dbo.spPerson_GetAll").ToList();
            }
            return output;
        }
    }
}
