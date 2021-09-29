using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    static private ScoreKeeper instance;
    private int score;
    public int pointsPerPick;

    public static ScoreKeeper Instance
    {
        get
        {
            return instance;
        }
    }
    public int Score
    {
        get
        {
            return score;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPointsPerPick()
    {
        score+=pointsPerPick;
    }
}