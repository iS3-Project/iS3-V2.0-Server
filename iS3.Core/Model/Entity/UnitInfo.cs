using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    /// <summary>
    /// 单位信息管理
    /// </summary>
    [Table("Project_UnitInfo")]
    public class UnitInfo : iS3AreaHandle
    {
        //单位名称
        public string Name { get; set; }
        //单位地址
        public string Address { get; set; }
        //联系电话
        public string Telephone { get; set; }
        //传真号码
        public string Fax { get; set; }
        //电子邮箱
        public string EMail { get; set; }
        //备注
        public string Remark { get; set; }
    }
}
