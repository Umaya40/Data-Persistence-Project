using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public string username;
    public string highUser = "CPU";
    public int highScore = 5;

    // Singleton logic
    private void Awake()
    {
        
        if (gameManager != null)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
            DontDestroyOnLoad(this);

            LoadData();
        }
        
    }

    
    class SaveFile
    {
        public string highUser;
        public int highScore;
    }
    
    public void SaveData()
    {
        // highscore updated in MainManager.
        highUser = username;

        SaveFile save = new SaveFile();
        save.highUser = highUser;
        save.highScore = highScore;

        string json = JsonUtility.ToJson(save);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string fileLocation = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(fileLocation))
        {
            string json = File.ReadAllText(fileLocation);
            SaveFile data = JsonUtility.FromJson<SaveFile>(json);

            highUser = data.highUser;
            highScore = data.highScore;
        }
    }
}
