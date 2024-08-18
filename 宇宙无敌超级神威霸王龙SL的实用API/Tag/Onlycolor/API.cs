using Exiled.API.Features;

namespace JBAPI.Tag
{
    public static class Onlycolor
    {
        /// <summary>
        /// 给指定玩家一个带有Color的标签
        /// </summary>
        /// <param name="玩家">指定玩家</param>
        /// <param name="文本">TagRank内容</param>
        /// <param name="颜色">TagRankColor</param>
        public static void ORTag(this Player 玩家, string 文本, string 颜色)
        {
            玩家.RankName = 文本;
            玩家.RankColor = 颜色;

            GameCore.Console.AddLog($"JBAPI.Onlycolor调用 玩家 {玩家.Nickname} ({玩家.UserId})", UnityEngine.Color.gray);
        }
    }
}
