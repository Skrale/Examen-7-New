using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackManager : MonoBehaviour
{
    public Card[] commonLibrary;
    public Card[] epicLibrary;
    public Card[] legendaryLibrary;

    public GameManager gameManager;
    public DropCards dropArea;

    void Start()
    {

    }

    void Update()
    {

    }

    public void HasDroppedCorrectly(PackHandler pack)
    {
        if (dropArea.onPointer)
        {
            pack.cardPack.AddCards();
        }
    }

    public List<Card> GetCommon(int value)
    {
        List<Card> tempList = new List<Card>();

        for (int i = 0; i < value; i++)
        {
            tempList.Add(commonLibrary[Random.Range(0, commonLibrary.Length)]);
        }
        return tempList;
    }

    public List<Card> GetEpic(int value)
    {
        List<Card> tempList = new List<Card>();

        for(int i = 0; i < value; i++)
        {
            tempList.Add(epicLibrary[Random.Range(0, epicLibrary.Length)]);
        }
        return tempList;
    }

    public List<Card> GetLegendary(int value)
    {
        List<Card> tempList = new List<Card>();

        for (int i = 0; i < value; i++)
        {
            tempList.Add(legendaryLibrary[Random.Range(0, legendaryLibrary.Length)]);
        }
        return tempList;
    }
}
