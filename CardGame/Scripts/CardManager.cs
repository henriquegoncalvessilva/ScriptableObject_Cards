using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardManager : MonoBehaviour
{



    [SerializeField]
    Card card;

    void Awake()
    {
        ChangeInfo();

    }

    void ChangeInfo()
    {

        //Get all info of ScriptableObject and implement in Prefab. 

        transform.GetChild(1).transform.GetChild(0).GetComponent<Text>().text = card.nameCard.ToUpper();
        transform.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = "[ " + card.typeCard + " ]";
        transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = card.descriptionCard;
        transform.GetChild(1).transform.GetChild(3).GetComponent<Text>().text = "ATK/ " + card.attackCard.ToString();
        transform.GetChild(1).transform.GetChild(4).GetComponent<Text>().text = "DEF/ " + card.defenseCard.ToString();


        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = card.imageCard;


    }
}