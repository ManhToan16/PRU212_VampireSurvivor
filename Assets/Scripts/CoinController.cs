using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
  public static CoinController instance;
    private void Awake()
    {
        instance = this;
    }
    public int currentCoins;
    public CoinPickup coin;
    public void AddCoins(int coinsToAdd)
    {
        
        currentCoins += coinsToAdd;
        UIController.instance.UpdateCoin();
    }
    public void DropCoin(Vector3 position,int value)
    {
        CoinPickup newCoin = Instantiate(coin,position+new Vector3(.2f,.1f,0f),Quaternion.identity);
        newCoin.cointAmount = value;
        newCoin.gameObject.SetActive(true);
    }
}