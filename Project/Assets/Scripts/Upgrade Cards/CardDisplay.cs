using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{

    public Card card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI tier;

    public Image artworkImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

        public void setCard(Card input)
    {
        card = input;
        updateCard();

    }

    public string getName(){
        return card.name;
    }

    public void updateCard()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        tier.text = card.tier;

        artworkImage.sprite = card.artwork;
        
        if(tier.text == "Rare"){
            tier.GetComponent<TextMeshProUGUI>().faceColor = Color.cyan;
        }
        else if(tier.text == "Epic"){
            tier.GetComponent<TextMeshProUGUI>().faceColor = Color.magenta;
        }
        else if(tier.text == "Common"){
            tier.GetComponent<TextMeshProUGUI>().faceColor = Color.white;
        }
        else if(tier.text == "Legendary"){
            tier.GetComponent<TextMeshProUGUI>().faceColor = Color.yellow;
        }
    }

}
