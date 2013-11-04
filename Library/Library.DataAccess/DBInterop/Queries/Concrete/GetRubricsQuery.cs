using Library.DataAccess.DBInterop.Queries.Abstract;
using Library.DataContracts.Concrete;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.DBInterop.Queries.Concrete
{
    public class GetRubricsQuery : TableQuery<Rubric>
    {
        const string Query = @"select
                                r.rubric_id, r.rubric_name, r.rubric_description,
                                r.rubric_parent_id, p.rubric_name as parent_name, p.rubric_description as parent_description
                            from rubric r
                            left join rubric p on r.rubric_parent_id = p.rubric_id";

        /*const string Query = @"select
                                    r.rubric_id, r.rubric_name, r.rubric_description,
                                    r.rubric_parent_id, p.rubric_name as parent_name, p.rubric_description as parent_description
                                from rubric r
                                left join rubric p on r.rubric_parent_id = p.rubric_id
                                start with r.rubric_parent_id is null
                                connect by prior r.rubric_id = r.rubric_parent_id
                                order siblings by r.rubric_name";*/

        public GetRubricsQuery(ConnectionProvider provider)
            : base(provider) {
        }

        public override Rubric Read(DataRow row) {
            return new Rubric() {
                Id = Convert.ToInt32(row.Field<decimal>("rubric_id")),
                Name = row.Field<string>("rubric_name"),
                Description = row.Field<string>("rubric_description"),
                Parent = row.IsNull("rubric_parent_id") ? null : new Rubric() {
                    Id = Convert.ToInt32(row.Field<decimal>("rubric_parent_id")),
                    Name = row.Field<string>("parent_name"),
                    Description = row.Field<string>("parent_description")
                },
                Childs = new List<Rubric>()
            };
        }

        public override OracleCommand CreateSqlCommand() {
            return new OracleCommand(Query);
        }
    }
}
