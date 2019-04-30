using iS3.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.Core.Model
{
    [Table("Project_ProjectInfo")]
    public class ProjectInfo: iS3AreaHandle
    {
        /// <summary>
        /// 工程名称
        /// </summary>
        public string ProjectName { get; set; }
        /// <summary>
        /// 工程地址
        /// </summary>
        public string ProjectAddress { get; set; }
        /// <summary>
        /// 建设单位
        /// </summary>
        public string ConstructionUnit { get; set; }
        /// <summary>
        /// 地勘单位
        /// </summary>
        public string GeologicalSurveyUnit { get; set; }
        /// <summary>
        /// 设计单位
        /// </summary>
        public string DesignUnit { get; set; }
        /// <summary>
        /// 监理单位
        /// </summary>
        public string SupervisionUnits { get; set; }
        /// <summary>
        /// 主要合同单位
        /// </summary>
        public string GeneralContractUnit { get; set; }
        /// <summary>
        /// 合同单位
        /// </summary>
        public Nullable<decimal> ContractAmount { get; set; }
        /// <summary>
        /// 合同周期
        /// </summary>
        public Nullable<int> ContractPeriod { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
