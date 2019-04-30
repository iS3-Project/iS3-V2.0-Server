
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iS3.Core
{
    public class DGObjectsFilter
    {
        public static string GetDGObjectsSQL(string project, string tableName, int objsID, string filter)
        {
            using (CoreContext db = new CoreContext(project))
            {
                var objs = db.ObjectsDefinition.Where(x => x.ID == objsID).FirstOrDefault();
                //filter字符串解码
                //filter = MessageConverter.Decode(filter);
                string conditionSQL;
                if (objs==null)
                {
                    conditionSQL = filter;
                }
                else
                {
                    conditionSQL = objs.ConditionSQL;
                    //重组查询字符串
                    if ((filter != null) && (filter.Length > 0) && (conditionSQL != null) && (conditionSQL.Length > 0))
                    {
                        conditionSQL = string.Format("{0} and {1}", filter, conditionSQL);
                    }
                    else
                    {
                        conditionSQL = filter + conditionSQL;
                    }
                }

                if ((conditionSQL != "")&&(conditionSQL!=null))
                {
                    return string.Format("select * from {0} where ({1})", tableName, conditionSQL);
                }
                else
                {
                    return string.Format("select * from {0}", tableName);
                }
            }
        }
    }
}
