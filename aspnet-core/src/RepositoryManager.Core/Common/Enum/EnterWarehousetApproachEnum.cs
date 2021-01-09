using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RepositoryManager.Common.Enum
{
    /// <summary>
    /// 入库途径
    /// </summary>
    public enum EnterWarehousetApproachEnum
    {
        [Description("购买")]
        Buy=1,


        [Description("顾客退货")]
        Refun=2
    }
}
