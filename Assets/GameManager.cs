using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        GameLoad();
    }

        static public void GameSave()
        {
            PlayerPrefs.SetInt("StatHP", PlayerHP.StatHp);
        }

        public void GameLoad()
        {
            PlayerHP.StatHp = PlayerPrefs.GetInt("StatHP");
        }
    }
