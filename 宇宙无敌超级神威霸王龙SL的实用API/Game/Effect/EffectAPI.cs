using Exiled.API.Features;
using Exiled.API.Enums;
using CustomPlayerEffects;
using System;
using InventorySystem.Items.Usables.Scp244.Hypothermia;

namespace JBAPI.Effect
{
    public static class Effect
    {
        /// <summary>
        /// 这是为指定添加效果，目前它处于测试效果，所有效果均源自于“EffectType”枚举
        /// </summary>
        /// <param name="玩家"></param>
        /// <param name="效果类型"></param>
        /// <param name="持续时间"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AddEffects(this Player 玩家, EffectType 效果类型, float 持续时间)
        {
            switch (效果类型)
            {
                case EffectType.AmnesiaItems:
                    玩家.EnableEffect<AmnesiaItems>(持续时间);
                    break;
                case EffectType.AmnesiaVision:
                    玩家.EnableEffect<AmnesiaVision>(持续时间);
                    break;
                case EffectType.AntiScp207:
                    玩家.EnableEffect<AntiScp207>(持续时间);
                    break;
                case EffectType.Asphyxiated:
                    玩家.EnableEffect<Asphyxiated>(持续时间);
                    break;
                case EffectType.CardiacArrest:
                    玩家.EnableEffect<CardiacArrest>(持续时间);
                    break;
                case EffectType.Bleeding:
                    玩家.EnableEffect<Bleeding>(持续时间);
                    break;
                case EffectType.Blinded:
                    玩家.EnableEffect<Blinded>(持续时间);
                    break;
                case EffectType.BodyshotReduction:
                    玩家.EnableEffect<BodyshotReduction>(持续时间);
                    break;
                case EffectType.Burned:
                    玩家.EnableEffect<Burned>(持续时间);
                    break;
                case EffectType.Concussed:
                    玩家.EnableEffect<Concussed>(持续时间);
                    break;
                case EffectType.Corroding:
                    玩家.EnableEffect<Corroding>(持续时间);
                    break;
                case EffectType.DamageReduction:
                    玩家.EnableEffect<DamageReduction>(持续时间);
                    break;
                case EffectType.Deafened:
                    玩家.EnableEffect<Deafened>(持续时间);
                    break;
                case EffectType.Decontaminating:
                    玩家.EnableEffect<Decontaminating>(持续时间);
                    break;
                case EffectType.Disabled:
                    玩家.EnableEffect<Disabled>(持续时间);
                    break;
                case EffectType.Ensnared:
                    玩家.EnableEffect<Ensnared>(持续时间);
                    break;
                case EffectType.Exhausted:
                    玩家.EnableEffect<Exhausted>(持续时间);
                    break;
                case EffectType.Flashed:
                    玩家.EnableEffect<Flashed>(持续时间);
                    break;
                case EffectType.FogControl:
                    玩家.EnableEffect<FogControl>(持续时间);
                    break;
                case EffectType.Ghostly:
                    玩家.EnableEffect<Ghostly>(持续时间);
                    break;
                case EffectType.Hemorrhage:
                    玩家.EnableEffect<Hemorrhage>(持续时间);
                    break;
                case EffectType.Hypothermia:
                    玩家.EnableEffect<Hypothermia>(持续时间);
                    break;
                case EffectType.InsufficientLighting:
                    玩家.EnableEffect<InsufficientLighting>(持续时间);
                    break;
                case EffectType.Invigorated:
                    玩家.EnableEffect<Invigorated>(持续时间);
                    break;
                case EffectType.Invisible:
                    玩家.EnableEffect<Invisible>(持续时间);
                    break;
                case EffectType.MovementBoost:
                    玩家.EnableEffect<MovementBoost>(持续时间);
                    break;
                case EffectType.None:
                    break;
                case EffectType.PocketCorroding:
                    玩家.EnableEffect<PocketCorroding>(持续时间);
                    break;
                case EffectType.Poisoned:
                    玩家.EnableEffect<Poisoned>(持续时间);
                    break;
                case EffectType.RainbowTaste:
                    玩家.EnableEffect<RainbowTaste>(持续时间);
                    break;
                case EffectType.Scanned:
                    玩家.EnableEffect<Scanned>(持续时间);
                    break;
                case EffectType.Scp1853:
                    玩家.EnableEffect<Scp1853>(持续时间);
                    break;
                case EffectType.Scp207:
                    玩家.EnableEffect<Scp207>(持续时间);
                    break;
                case EffectType.SeveredHands:
                    玩家.EnableEffect<SeveredHands>(持续时间);
                    break;
                case EffectType.SilentWalk:
                    玩家.EnableEffect<SilentWalk>(持续时间);
                    break;
                case EffectType.SinkHole:
                    玩家.EnableEffect<Sinkhole>(持续时间);
                    break;
                case EffectType.Slowness:
                    玩家.EnableEffect<Slowness>(持续时间);
                    break;
                case EffectType.SoundtrackMute:
                    玩家.EnableEffect<SoundtrackMute>(持续时间);
                    break;
                case EffectType.SpawnProtected:
                    玩家.EnableEffect<SpawnProtected>(持续时间);
                    break;
                case EffectType.Stained:
                    玩家.EnableEffect<Stained>(持续时间);
                    break;
                case EffectType.Strangled:
                    玩家.EnableEffect<Strangled>(持续时间);
                    break;
                case EffectType.Traumatized:
                    玩家.EnableEffect<Traumatized>(持续时间);
                    break;
                case EffectType.Vitality:
                    玩家.EnableEffect<Vitality>(持续时间);
                    break;
                default:
                    throw new ArgumentException("从未见过的效果类型：" + 效果类型.ToString());
            }
        }
    }
}
