using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthController : MonoBehaviour
{
    // Start is called before the first frame update
    public static PlayerHealthController instance;
    public float currentHealth, maxHealth;
    private void Awake()
    {
        instance = this;
    }
    public Slider healthSlider;
    public GameObject deathEffect;
    void Start()
    {
        maxHealth = PlayerStatController.instance.health[0].value;
        currentHealth=maxHealth;
        healthSlider.maxValue=maxHealth;
        healthSlider.value=currentHealth;

    }
  

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    TakeDame(10f);
        //} 
    }
    public void TakeDame(float dameToTake)
    {
        currentHealth -= dameToTake;
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            LevelManager.instance.EndLevel();
            Instantiate(deathEffect,transform.position,transform.rotation);
        }
        healthSlider.value = currentHealth;

    }

}
