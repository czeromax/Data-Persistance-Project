using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreDataHandler : MonoBehaviour
{
    public static ScoreDataHandler Instance;

    private int BestScore;
    private string BestPlayer;

    private void Awake()
    {
        Instance = this;
        LoadBest();
    }

    [SerializeField]
    class SaveData
    {
        public int HighestScore;
        public string TheBestPlayer;
    }

    public void LoadBest()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            BestPlayer = data.TheBestPlayer;
            BestScore = data.HighestScore;
        }
    }

    public void SaveBest(string bestPlayerName, int bestPlayerScore)
    {
        SaveData data = new SaveData();

        data.HighestScore = bestPlayerScore;
        data.TheBestPlayer = bestPlayerName;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public string GetBestPlayer()
    {
        return BestPlayer;
    }

    public int GetBestScore()
    {
        return BestScore;
    }
}
