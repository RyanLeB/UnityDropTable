using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTable : MonoBehaviour
{
    [Header("Chest Type")]

    [SerializeField] private int WoodChest;
    [SerializeField] private int BronzeChest;
    [SerializeField] private int SilverChest;
    [SerializeField] private int GoldChest;
    [SerializeField] private int PlatinumChest;

    [SerializeField] private List<string> ChestTypes;

    
    
    [Header("Wooden Chest")]

    [SerializeField] private int WoodChestCommon;
    [SerializeField] private int WoodChestUncommon;
    [SerializeField] private int WoodChestRare;
    [SerializeField] private int WoodChestEpic;
    [SerializeField] private int WoodChestLegendary;

    [SerializeField] private List<string> WoodChestDrops;

    
    
    [Header("Bronze Chest")]

    [SerializeField] private int BronzeChestCommon;
    [SerializeField] private int BronzeChestUncommon;
    [SerializeField] private int BronzeChestRare;
    [SerializeField] private int BronzeChestEpic;
    [SerializeField] private int BronzeChestLegendary;

    [SerializeField] private List<string> BronzeChestDrops;



    [Header("Silver Chest")]

    [SerializeField] private int SilverChestCommon;
    [SerializeField] private int SilverChestUncommon;
    [SerializeField] private int SilverChestRare;
    [SerializeField] private int SilverChestEpic;
    [SerializeField] private int SilverChestLegendary;

    [SerializeField] private List<string> SilverChestDrops;



    [Header("Gold Chest")]

    [SerializeField] private int GoldChestCommon;
    [SerializeField] private int GoldChestUncommon;
    [SerializeField] private int GoldChestRare;
    [SerializeField] private int GoldChestEpic;
    [SerializeField] private int GoldChestLegendary;

    [SerializeField] private List<string> GoldChestDrops;



    [Header("Platinum Chest")]

    [SerializeField] private int PlatinumChestCommon;
    [SerializeField] private int PlatinumChestUncommon;
    [SerializeField] private int PlatinumChestRare;
    [SerializeField] private int PlatinumChestEpic;
    [SerializeField] private int PlatinumChestLegendary;

    [SerializeField] private List<string> PlatinumChestDrops;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
