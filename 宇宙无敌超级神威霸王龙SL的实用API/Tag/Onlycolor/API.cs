using Exiled.API.Features;
using JBPI.Log;

namespace JBAPI.Tag
{
    public static class Onlycolor
    {
        public static void ORTag(this Player 玩家, string 文本, string 颜色)
        {
            玩家.RankName = 文本;
            玩家.RankColor = 颜色;

            LogAPI.日志($"JBAPI.OnlyColor调用 玩家 {玩家.Nickname} ({玩家.UserId})");
        }
    }
}
