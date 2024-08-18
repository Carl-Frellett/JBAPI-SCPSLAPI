using Exiled.API.Features.DamageHandlers;
using PlayerRoles;
using Respawning.NamingRules;
using Respawning;
using Exiled.API.Enums;
using Exiled.API.Features;

namespace JBAPI.CustomCassie
{
    public class CustomCassie
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cassiename">播放的内容</param>
        /// <param name="translatedname">显示的内容</param>
        /// <param name="damageHandler">伤害来源</param>
        /// <param name="isNoisy">是否播放语音</param>
        /// <param name="isTranslate">是否显示内容</param>
        public static void PlayCassie(string cassiename, string translatedname, DamageHandler damageHandler, bool isNoisy = true, bool isTranslate = true)
        {
            string cassie = GetCassie(damageHandler);
            string cassieTranslation = GetCassieTranslation(damageHandler);
            if (!isNoisy)
            {
                if (isTranslate)
                {
                    Cassie.MessageTranslated(cassiename + " " + cassie, translatedname + " " + cassieTranslation, isHeld: false, isNoisy: false);
                }
                else
                {
                    Cassie.Message(cassiename + " " + cassie, isHeld: false, isNoisy: false);
                }
            }
            else if (isTranslate)
            {
                Cassie.MessageTranslated(cassiename + " " + cassie, translatedname + " " + cassieTranslation);
            }
            else
            {
                Cassie.Message(cassiename + " " + cassie);
            }
        }

        private static string GetCassieTranslation(DamageHandler damageHandler)
        {
            if (damageHandler == null)
            {
                return "已被成功消灭，死亡原因不明。";
            }

            if (damageHandler.Type == DamageType.Tesla)
            {
                return "已被自动安保系统成功消灭。";
            }

            if (damageHandler.Type == DamageType.Decontamination)
            {
                return "已被轻收容净化系统清除。";
            }

            if (damageHandler.Type == DamageType.Warhead)
            {
                return "已被Alpha核弹头成功消灭。";
            }

            if (damageHandler.Attacker != null)
            {
                if (damageHandler.Attacker.IsCHI)
                {
                    return "已被混沌分裂者重新收容。";
                }

                if (damageHandler.Attacker.Role.Team == Team.ClassD)
                {
                    return "已被D级人员重新收容。";
                }

                if (damageHandler.Attacker.Role.Team == Team.Scientists)
                {
                    return "已被科学家重新收容。";
                }

                if (damageHandler.Attacker.Role.Team == Team.FoundationForces)
                {
                    return "已被" + damageHandler.Attacker.UnitName + "重新收容";
                }

                return "已被成功消灭，死亡原因不明。";
            }

            return "已被成功消灭，死亡原因不明。";
        }

        private static string GetCassie(DamageHandler damageHandler)
        {
            if (damageHandler == null)
            {
                return "SUCCESSFULLY TERMINATED . TERMINATION CAUSE UNSPECIFIED";
            }

            if (damageHandler.Type == DamageType.Tesla)
            {
                return "SUCCESSFULLY TERMINATED BY AUTOMATIC SECURITY SYSTEM";
            }

            if (damageHandler.Type == DamageType.Decontamination)
            {
                return "LOST IN DECONTAMINATION SEQUENCE";
            }

            if (damageHandler.Type == DamageType.Warhead)
            {
                return "SUCCESSFULLY TERMINATED BY ALPHA WARHEAD";
            }

            if (damageHandler.Attacker != null)
            {
                if (damageHandler.Attacker.IsCHI)
                {
                    return "CONTAINEDSUCCESSFULLY BY CHAOSINSURGENCY";
                }

                if (damageHandler.Attacker.Role.Team == Team.ClassD)
                {
                    return "CONTAINEDSUCCESSFULLY BY CLASSD PERSONNEL";
                }

                if (damageHandler.Attacker.Role.Team == Team.Scientists)
                {
                    return "CONTAINEDSUCCESSFULLY BY SCIENCE PERSONNEL";
                }

                if (damageHandler.Attacker.Role.Team == Team.FoundationForces)
                {
                    UnitNamingRule.TryGetNamingRule(SpawnableTeamType.NineTailedFox, out var rule);
                    string cassieUnitName = rule.GetCassieUnitName(damageHandler.Attacker.UnitName);
                    return "CONTAINEDSUCCESSFULLY , CONTAINMENTUNIT " + cassieUnitName;
                }

                return "SUCCESSFULLY TERMINATED . TERMINATION CAUSE UNSPECIFIED";
            }

            return "SUCCESSFULLY TERMINATED . TERMINATION CAUSE UNSPECIFIED";
        }
    }
}
