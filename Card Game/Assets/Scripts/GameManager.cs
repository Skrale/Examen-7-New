using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{

    public List<Card> cardLibrary = new List<Card>();
    public List<Card> deckLibrary = new List<Card>();
    public List<Card> allCards = new List<Card>();

    public int money;
    public Text moneyText;
    public Collection collection;

    void Start()
    {

    }

    void Update()
    {
        moneyText.text = money.ToString();
    }
}
