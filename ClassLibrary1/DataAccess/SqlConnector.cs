using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataLibrary.DataAccess;
using System.Linq;

namespace DataLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {


        public PersonData CreatePerson(PersonData personData)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("TestDB")))
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

        public void DeletePerson(PersonData model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("TestDB")))
            {

                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                connection.Execute("dbo.spDeletePerson", p, commandType: CommandType.StoredProcedure);

                
               

            }
        }

        public List<PersonData> GetPerson_All()
        {
            List<PersonData> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("TestDB")))
            {
                output = connection.Query<PersonData>("dbo.spPerson_GetAll").ToList();
            }
            return output;
        }
    }
}
