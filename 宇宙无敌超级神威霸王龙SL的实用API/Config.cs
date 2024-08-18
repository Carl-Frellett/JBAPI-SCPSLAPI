using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBAPI
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }
        [Description("AntiCheat-MaxKill，反作弊最大击杀数")]
        public int MaxKill = 20;
        [Description("AntiCheat-BanTime，反作弊Ban时间")]
        public int BanTime = 3600;
    }
}
