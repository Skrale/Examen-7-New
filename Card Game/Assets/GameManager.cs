using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<Card> cardLibrary = new List<Card>();
    public List<Card> deckLibrary = new List<Card>();

    public int money;
    public Text moneyText;


    void Start()
    {

    }

    void Update()
    {
        moneyText.text = money.ToString();
    }
}
