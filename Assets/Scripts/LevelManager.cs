using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static LevelManager instance;
    private void Awake()
    {
        instance = this;
    }
    private bool gameActive;
    public float timer;
    public float waitToShowScreen = 1f;
    void Start()
    {
        gameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameActive == true)
        {
            timer += Time.deltaTime;
            UIController.instance.UpdateTimer(timer);
        }  
    }
    public void EndLevel()
    {
        gameActive = false;
        StartCoroutine(EndLevelCo());
    }
    IEnumerator EndLevelCo()
    {
        yield return new WaitForSeconds(waitToShowScreen);
        float minutes = Mathf.FloorToInt(timer / 60f);
        float seconds = Mathf.FloorToInt(timer % 60);
        UIController.instance.endTimeText.text = minutes.ToString() + " mins " + seconds.ToString("00" + " secs");
        UIController.instance.coinEndText.text = "Coin: " + CoinController.instance.currentCoins;
        UIController.instance.levelEndScreen.SetActive(true);
    }
    public void GoToMainMenu()
    {

    }
    public void Restart()
    {

    }
}
