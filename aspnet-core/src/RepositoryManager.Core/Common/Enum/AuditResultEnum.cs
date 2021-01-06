using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RepositoryManager.Common.Enum
{
    /// <summary>
    /// 审核结果
    /// </summary>
    public enum AuditResultEnum
    {
        [Description("审核通过")]
        Pass = 1,

        [Description("审核拒绝")]
        Refuse = 2
    }
}
