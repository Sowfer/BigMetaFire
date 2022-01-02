using MFPSEditor;
using System;
using UnityEngine;

namespace MFPS.Addon.LevelManager
{
    [System.Serializable]
    public class LevelInfo
    {
        public string Name = "Level";
        public int ScoreNeeded = 0;
        [SpritePreview(50)] public Sprite Icon;
        [HideInInspector] public int LevelID;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetRelativeScoreNeeded()
        {
            if (LevelID <= 1) return ScoreNeeded;

            int index = LevelID - 1;
            return bl_LevelManager.Instance.GetLevelByID(index).ScoreNeeded - bl_LevelManager.Instance.GetLevelByID(index - 1).ScoreNeeded;
        }
    }
}