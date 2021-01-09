using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RepositoryManager.Common.Enum
{
    /// <summary>
    /// 出库途径
    /// </summary>
    public enum OutWarehousetApproachEnum
    {
        [Description("卖出")]
        Sale=1,


        [Description("退货给供应商")]
        Refun = 2
    }
}
