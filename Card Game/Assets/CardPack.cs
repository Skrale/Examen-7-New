using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PackTypes
{
    Standard,
    Special,
    Premium
}

public class CardPack : MonoBehaviour
{
    public int cardAmount;
    public int cardPrice;
    public PackManager packManager;
    public PackHandler packHandler;
    public Text amountText;
    public Button buyButton;
    public PackTypes currentPackType;

    void Start()
    {

    }

    void Update()
    {
        amountText.text = cardAmount.ToString();
        buyButton.interactable = (packManager.gameManager.money >= cardPrice) ? true : false;
        CheckCardAvailability();
    }

    public void AddCards()
    {
        List<Card> tempCompleteList = new List<Card>();

        switch (currentPackType)
        {
            case PackTypes.Premium:
                {
                    List<Card> tempEpicList = new List<Card>();
                    tempEpicList = packManager.GetEpic(2);
                    foreach (Card card in tempEpicList) { tempCompleteList.Add(card); }
                    tempCompleteList.Add(packManager.GetLegendary(1)[0]);
                }
                break;
            case PackTypes.Special:
                {
                    List<Card> tempEpicList = new List<Card>();
                    tempEpicList = packManager.GetEpic(2);
                    foreach (Card card in tempEpicList) { tempCompleteList.Add(card); }
                    tempCompleteList.Add(packManager.GetCommon(1)[0]);
                }
                break;
            case PackTypes.Standard:
                {
                    List<Card> tempCommonList = new List<Card>();
                    tempCommonList = packManager.GetCommon(2);
                    foreach (Card card in tempCommonList) { tempCompleteList.Add(card); }
                    tempCompleteList.Add(packManager.GetEpic(1)[0]);
                }
                break;
            default:
                break;
        }
        foreach(Card card in tempCompleteList)
        {
            packManager.gameManager.cardLibrary.Add(card);
        }
        cardAmount--;
    }

    public void Buy()
    {
        cardAmount++;
        packManager.gameManager.money -= cardPrice;
    }

    public void CheckCardAvailability()
    {
        packHandler.GetComponent<PackHandler>().enabled = (cardAmount > 0) ? true : false;
    }
}
