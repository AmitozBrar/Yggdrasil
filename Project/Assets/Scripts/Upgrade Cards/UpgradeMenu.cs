using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
{

    [SerializeField] public GameObject upgradeMenu;

     public GameObject firstCard;
     public CardDisplay card1;
     public CardDisplay card2;
     public CardDisplay card3;
     public GameObject secondCard;
     public GameObject thirdCard;

    [SerializeField] Card[] commonCards;
    [SerializeField] Card[] rareCards;
    [SerializeField] Card[] epicCards;
    [SerializeField] Card[] legendaryCards;
    [SerializeField] public Card card;

    [SerializeField] public bool isUpgrading;

    // Start is called before the first frame update
    void Start()
    {
        upgradeMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void inUpgrade()
    {
        randomCardsOne();
        randomCardsTwo();
        randomCardsThree();
        upgradeMenu.SetActive(true);
        Time.timeScale = 0f;
        isUpgrading = true;
    }

    public void finishUpgrade()
    {
        upgradeMenu.SetActive(false);
        Time.timeScale = 1f;
        isUpgrading = false;
    }

    public void randomCardsOne()
    {
        card1 = firstCard.GetComponent<CardDisplay>();
        int rareRange = Random.Range(1,100);
        if(rareRange <=50){
            int cardNum = Random.Range(1, commonCards.Length);
            card1.setCard(commonCards[cardNum-1]);
            card1.name = card1.getName();
        }
        else if(rareRange <=80 && rareRange > 50){
            int cardNum = Random.Range(1, rareCards.Length);
            card1.setCard(rareCards[cardNum-1]);
            card1.name = card1.getName();
        }
        else if(rareRange <=97 && rareRange > 80){
            int cardNum = Random.Range(1, epicCards.Length);
            card1.setCard(epicCards[cardNum-1]);
            card1.name = card1.getName();
        }
        else if(rareRange <= 100 && rareRange > 97){
            int cardNum = Random.Range(1, legendaryCards.Length);
            card1.setCard(legendaryCards[cardNum-1]);
            card1.name = card1.getName();
        }
    }
    public void randomCardsTwo()
    {
        card2 = secondCard.GetComponent<CardDisplay>();
        int rareRange = Random.Range(1,100);
        if(rareRange <=50){
            int cardNum = Random.Range(1, commonCards.Length);
            card2.setCard(commonCards[cardNum-1]);
            card2.name = card2.getName();
            if(card2.name == card1.name){
                randomCardsTwo();
            }
        }
        else if(rareRange <=80 && rareRange > 50){
            int cardNum = Random.Range(1, rareCards.Length);
            card2.setCard(rareCards[cardNum-1]);
            card2.name = card2.getName();
            if(card2.name == card1.name){
                randomCardsTwo();
            }
        }
        else if(rareRange <=97 && rareRange > 80){
            int cardNum = Random.Range(1, epicCards.Length);
            card2.setCard(epicCards[cardNum-1]);
            card2.name = card2.getName();
            if(card2.name == card1.name){
                randomCardsTwo();
            }
        }
        else if(rareRange <= 100 && rareRange > 97){
            int cardNum = Random.Range(1, legendaryCards.Length);
            card2.setCard(legendaryCards[cardNum-1]);
            card2.name = card2.getName();
            if(card2.name == card1.name){
                randomCardsTwo();
            }
        }
    }
    public void randomCardsThree()
    {
        card3 = thirdCard.GetComponent<CardDisplay>();
        int rareRange = Random.Range(1,100);
        if(rareRange <=50){
            int cardNum = Random.Range(1, commonCards.Length);
            card3.setCard(commonCards[cardNum-1]);
            card3.name = card3.getName();
            if(card3.name == card1.name || card3.name == card2.name){
                randomCardsThree();
            }
        }
        else if(rareRange <=80 && rareRange > 50){
            int cardNum = Random.Range(1, rareCards.Length);
            card3.setCard(rareCards[cardNum-1]);
            card3.name = card3.getName();
            if(card3.name == card1.name || card3.name == card2.name){
                randomCardsThree();
            }
        }
        else if(rareRange <=97 && rareRange > 80){
            int cardNum = Random.Range(1, epicCards.Length);
            card3.setCard(epicCards[cardNum-1]);
            card3.name = card3.getName();
            if(card3.name == card1.name || card3.name == card2.name){
                randomCardsThree();
            }
        }
        else if(rareRange <= 100 && rareRange > 97){
            int cardNum = Random.Range(1, legendaryCards.Length);
            card3.setCard(legendaryCards[cardNum-1]);
            card3.name = card3.getName();
            if(card3.name == card1.name || card3.name == card2.name){
                randomCardsThree();
            }
        }
    }
}
