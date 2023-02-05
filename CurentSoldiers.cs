using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurentSoldiers : MonoBehaviour
{
    
        public int Mage;
        public int Archer;
        public int Killer;
        public int Tooth;
        public Text mageText;
        public Text archerText;
        public Text killerText;
        public Text ToothText;

    private const string MAGE_KEY = "MAGE";
    private const string ARCHER_KEY = "ARCHER";
    private const string KILLER_KEY = "KILLER";
    private const string TOOTH_KEY = "TOOTH";

    public void Start()
    {
        if((GameData.Mage == 0)&&(GameData.Archer == 0)&&(GameData.Killer == 0))
        {
            GameData.Mage = 2;
            GameData.Archer = 2;
            GameData.Killer = 2;
            GameData.Tooth = 2;
        }



        Mage = PlayerPrefs.GetInt(MAGE_KEY, 2);
        Archer = PlayerPrefs.GetInt(ARCHER_KEY, 2);
        Killer = PlayerPrefs.GetInt(KILLER_KEY, 2);
        Tooth = PlayerPrefs.GetInt(TOOTH_KEY, 15);
        mageText = GameObject.Find("MageText").GetComponent<Text>();
        archerText = GameObject.Find("ArcherText").GetComponent<Text>();
        killerText = GameObject.Find("KillerText").GetComponent<Text>();
        ToothText = GameObject.Find("ToothText").GetComponent<Text>();
        UpdateSoldiersText();
    }
    public void LateUpdate()
    {
        Mage = GameData.Mage;
        Archer = GameData.Archer;
        Killer = GameData.Killer;
        Tooth = GameData.Tooth;
        UpdateSoldiersText();
    }

        public void AddMage()
        {
            if (Tooth>=3)
            {
                GameData.Mage += 1;
                UpdateSoldiersText();
            GameData.Tooth -= 3;
            }
            
        }

        public void AddArcher()
        {

        if (Tooth >= 3)
        {
            GameData.Archer += 1;
            UpdateSoldiersText();
            GameData.Tooth -= 3;
        }
        
        }

        public void AddKiller()
        {
        if (Tooth >= 3)
        {
            GameData.Killer += 1;
            UpdateSoldiersText();
            GameData.Tooth -= 3;
        }
      
        }

    public void UpdateSoldiersText()
    {
        mageText.text = Mage.ToString();
        archerText.text = Archer.ToString();
        killerText.text = Killer.ToString();
        ToothText.text = Tooth.ToString();
        PlayerPrefs.SetInt(MAGE_KEY, Mage);
        PlayerPrefs.SetInt(ARCHER_KEY, Archer);
        PlayerPrefs.SetInt(KILLER_KEY, Killer);
        PlayerPrefs.SetInt(TOOTH_KEY, Tooth);
        PlayerPrefs.Save();
    }
}
    


