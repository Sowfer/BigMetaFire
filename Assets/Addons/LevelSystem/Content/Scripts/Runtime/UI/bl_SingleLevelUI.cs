using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MFPS.Addon.LevelManager
{
    public class bl_SingleLevelUI : MonoBehaviour
    {
        public Image levelIcon;
        public Text levelNameText;
        public Text levelNumberText;

        public void Set(LevelInfo level)
        {
            if(levelIcon != null) levelIcon.sprite = level.Icon;
            if (levelNameText != null) levelNameText.text = level.Name;
            if (levelNumberText != null) levelNumberText.text = level.LevelID.ToString();
        }
    }
}