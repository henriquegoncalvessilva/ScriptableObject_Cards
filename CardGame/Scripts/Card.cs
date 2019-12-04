using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[ExecuteInEditMode]
[CreateAssetMenu(fileName = "Card", menuName = "CardGame/Generate Card", order = 1)]
public class Card : ScriptableObject
{
    
    //Image of Card
    public Sprite imageCard;


    //Info of Card
    public string nameCard;

    public string descriptionCard;

    public types typeCard;

    public int attackCard;

    public int defenseCard;

    public enum types
    {
        //If you want add more type of card in ENUMERATOR, so follow the structure below: ↓
        SpeelCaster,
        Dragon,
        Beast,
        Effect,
        Warrior,
        Plant

    }

     


   


}
