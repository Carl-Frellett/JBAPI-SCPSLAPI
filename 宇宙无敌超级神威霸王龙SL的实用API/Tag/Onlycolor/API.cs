using Exiled.API.Features;

namespace 宇宙无敌超级神威霸王龙SL的实用API.Tag
{
    public static class Onlycolor
    {
        public static void ORTag(this Player 玩家, string 文本, string 颜色)
        {
            玩家.RankName = 文本;
            玩家.RankColor = 颜色;

            GameCore.Console.AddLog($"JBAPI.Onlycolor调用 玩家 {玩家.Nickname} ({玩家.UserId})", UnityEngine.Color.gray);
        }
    }
}
