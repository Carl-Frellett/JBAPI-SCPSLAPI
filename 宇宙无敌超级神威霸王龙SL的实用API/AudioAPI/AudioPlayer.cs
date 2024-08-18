using Exiled.API.Features;
using PlayerRoles;
using System.Collections.Generic;
using SCPSLAudioApi.AudioCore;
using UnityEngine;
using System.IO;
using System;

namespace JBAPI.AudioPlayer
{
    internal class AudioPlayer
    {
        static List<ReferenceHub> hub = new List<ReferenceHub>();
        static List<AudioPlayerBase> bases = new List<AudioPlayerBase>();
        public static int Id = 1;
        /// <summary>
        /// 初始化Id
        /// </summary>
        public static void ClearId()
        {
            Id = 1;
        }
        /// <summary>
        /// 检查Audio文件夹
        /// </summary>
        public static void VerifyAudio()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string Path1 = Path.Combine(appDataPath, "EXILED", "Configs", "Audio");
            if (Directory.Exists(Path1))
                Log.Info("Audio文件夹存在");
            else
            {
                Log.Info("Audio文件夹不存在");
                Directory.CreateDirectory(Path1);
                Log.Info("创建完成");
            }
        }
        /// <summary>
        /// 创建AudioPlayerNpc
        /// </summary>
        /// <param name="name">Bot名字</param>
        /// <returns></returns>
        public static int AddBot(string name = "AudioPlayer-宇宙无敌超级神威霸王龙")
        {

            var Hub = Npc.Spawn(name, RoleTypeId.Overwatch, 9999 + Id, "AudioPlayer@宇宙无敌超级神威霸王龙", new Vector3(9999, 9999, 9999)).ReferenceHub;
            var Base = AudioPlayerBase.Get(Hub);
            hub.Add(Hub);
            bases.Add(Base);
            Log.Info($"Added Bot with ID: {Id}");
            return Id++;
        }
        /// <summary>
        /// 删除AudioPlayerNpc
        /// </summary>
        /// <param name="id">Bot在List中的Id</param>
        public static void RemoveBot(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            id--;
            if (bases.Count == 0)
            {
                Log.Error("无法删除，空的列表");
                return;
            }

            if (id < 0 || id >= bases.Count)
            {
                Log.Error("无法删除，错误的Id");
                return;
            }

            var sb = AudioPlayerBase.Get(hub[id]);
            hub.RemoveAt(id);
            bases.RemoveAt(id);
            Npc.Get(9999 + id + 1).Destroy();
            sb.OnDestroy();
            Log.Info($"Removed Bot with ID: {id + 1}");
        }
        /// <summary>
        /// 播放AudioPlayerNpc的音频,
        /// </summary>
        /// <param name="id">AudioPlayerNpc在List中的Id</param>
        /// <param name="path">路径，在%EXILED%/Configs/Audio/文件夹放入Ogg,48000Hz,单声道音频</param>
        public static void PlayAudio(int id, string path)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            id--;
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string Path1 = Path.Combine(appDataPath, "EXILED", "Configs", "Audio", path);

            if (bases.Count == 0)
            {
                Log.Error("无法播放，空的列表");
                return;
            }

            if (id < 0 || id >= bases.Count)
            {
                Log.Error("无法播放，错误的Id");
                Log.Error($"List count: {bases.Count}, provided ID: {id + 1}");
                return;
            }

            var sb = AudioPlayerBase.Get(hub[id]);
            sb.AllowUrl = true;
            sb.Enqueue(Path1, 0);
            sb.Play(0);
            Log.Info($"Playing audio for Bot with ID: {id + 1} at path: {Path1}");
        }

        public static void StopAudio(int id)
        {
            id--;

            if (bases.Count == 0)
            {
                Log.Error("无法停止，空的列表");
                return;
            }

            if (id < 0 || id >= bases.Count)
            {
                Log.Error("无法停止，错误的Id");
                Log.Error($"List count: {bases.Count}, provided ID: {id + 1}");
                return;
            }

            var sb = AudioPlayerBase.Get(hub[id]);
            sb.AllowUrl = true;
            sb.Stoptrack(false);
            Log.Info($"Stopped audio for Bot with ID: {id + 1}");
        }
    }
}
