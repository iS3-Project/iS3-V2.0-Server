using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    /// <summary>
    /// 人员信息管理
    /// </summary>
    [Table("Project_PersonnelInfo")]
    public class PersonnelInfo: iS3AreaHandle
    {
        //姓名
        public string Name { get; set; }
        //单位标识
        public int UnitID { get; set; }
        //联系电话
        public string Telephone { get; set; }
        //电子邮箱
        public string EMail { get; set; }
        //备注
        public string Remark { get; set; }
    }
}
