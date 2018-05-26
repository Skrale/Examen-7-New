using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{

    public List<Card> cardLibrary = new List<Card>();

    public GameManager manager;

    public GameObject cardPrefab;
    public GameObject collectionPanel;

    void Start()
    {
    }
    
    void Update()
    {

    }

    private void OnEnable()
    {
        CompareForNewCards();
        
        //collectionPanel.GetComponent<RectTransform>().sizeDelta = cardPrefab.GetComponent<RectTransform>().sizeDelta;
    }

    void CompareForNewCards()
    {
        List<Card> tempCards = new List<Card>();

        foreach(Card card in manager.cardLibrary)
        {
            if (!cardLibrary.Contains(card))
            {
                InstantiateCard(card);
            }
        }
    }

    void InstantiateCard(Card card)
    {
        GameObject tempObject = Instantiate(cardPrefab);
        tempObject.transform.SetParent(collectionPanel.transform);
        tempObject.GetComponent<CardDisplay>().Initialize(card);
        cardLibrary.Add(card);
    }
}
