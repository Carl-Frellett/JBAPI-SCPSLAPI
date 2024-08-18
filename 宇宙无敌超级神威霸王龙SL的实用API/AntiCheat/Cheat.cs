using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBAPI.AntiCheat
{

    public sealed class AntiCheat : Plugin<Config>
    {
        private static bool _enabled;
        private static Dictionary<Player,int> kill = new Dictionary<Player, int>();
        public override void OnEnabled()
        {
            SCPSLAudioApi.Startup.SetupDependencies();
            Exiled.Events.Handlers.Server.RoundEnded += EndRound;
            Exiled.Events.Handlers.Player.Dying += Kill;
            Exiled.Events.Handlers.Player.Left += Left;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundEnded += EndRound;
            Exiled.Events.Handlers.Player.Dying -= Kill;
            Exiled.Events.Handlers.Player.Left -= Left;
            base.OnDisabled();
        }
        /// <summary>
        /// 加载反作弊
        /// </summary>
        public static void LoadAnitCheat()
        {
            _enabled = true;
        }
        /// <summary>
        /// 解除加载反作弊
        /// </summary>
        public static void UnLoadAnitCheat()
        {
            _enabled = false;
        }
        void EndRound(RoundEndedEventArgs end)
        {
            kill.Clear();
        }
        void Left(LeftEventArgs e)
        {
            if (_enabled)
            {
                if(kill.ContainsKey(e.Player))
                {
                    kill.Remove(e.Player);
                }
            }
        }
        void Kill(DyingEventArgs tg)
        {
            if (_enabled) {
                if (!kill.ContainsKey(tg.Player))
                    kill.Add(tg.Player, 1);
                else if (kill.ContainsKey(tg.Player))
                    kill[tg.Player]++;
                foreach (var target in kill)
                    if (target.Value >= Config.MaxKill)
                    {
                        AntiBan(tg.Player, Config.BanTime, $"你因为涉嫌 刷击杀数 Or 使用外部或者内部第三方软件/作弊软件 已被封禁,封禁时间:{Config.BanTime}",$"----Player {tg.Player.Nickname} 涉嫌作弊已被封禁----",true);
                        kill.Remove(tg.Player);
                    }
            }
            else
                return;
        }
        /// <summary>
        /// Ban某个玩家
        /// </summary>
        /// <param name="player"></param>
        /// <param name="time"></param>
        /// <param name="reason"></param>
        public static void AntiBan(Player player,int time,string reason,string Tips = null,bool isTips = true)
        {
            if(isTips)
                Map.Broadcast(10, Tips);
            player.Ban(time, reason,player);
        }
    }
}
