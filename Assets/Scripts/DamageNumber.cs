using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageNumber : MonoBehaviour
{
    public TMP_Text damageText;
    public float lifeTime;
    private float lifeCounter;
    public float speed = 1f;

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
                //Destroy(gameObject);
                DamageNumberController.instance.PlaceInPool(this);  
            }
        }
        transform.position += Vector3.up * speed * Time.deltaTime;
       
    }
    public void Setup(int damageDisplay)
    {
        lifeCounter = lifeTime;
        damageText.text = damageDisplay.ToString();
    }
}
