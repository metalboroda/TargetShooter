using System.Collections;
using System.Collections.Generic;
using GameScene.Managers;
using GameScene.Managers.Scores;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ScoreCountScript : MonoBehaviour
{
    public ScriptableScoreManager scriptableScoreManager;

    public Text scoreCountText;
    
    // Update is called once per frame
    private void Update()
    {
        scoreCountText.text = scriptableScoreManager.score.ToString();
    }
}