using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageNumber : MonoBehaviour
{
    public TMP_Text damageText;
    public float lifeTime;
    private float lifeCounter;

    // Start is called before the first frame update
    void Start()
    {
        lifeCounter = lifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeCounter > 0) {
        lifeCounter -= Time.deltaTime;
            if (lifeCounter <= 0)
            {
                Destroy(gameObject);
            }
        }
        //if (Input.GetKeyDown(KeyCode.U))
        //{
        //    Setup(45);
        //}
    }
    public void Setup(int damageDisplay)
    {
        lifeCounter = lifeTime;
        damageText.text = damageDisplay.ToString();
    }
}