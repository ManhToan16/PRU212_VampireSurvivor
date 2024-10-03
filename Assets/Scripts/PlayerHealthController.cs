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
    void Start()
    {
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
        }
        healthSlider.value = currentHealth;

    }

}
