
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTable : MonoBehaviour
{
    public string chestAwarded;
    public string prizeAwarded;
    
    
    [Header("Chest Type")]

    public int WoodChest;
    public int BronzeChest;
    public int SilverChest;
    public int GoldChest;
    public int PlatinumChest;

    [SerializeField] private List<string> ChestTypes;

    
    
    [Header("Wooden Chest")]

    public int WoodChestCommon;
    public int WoodChestUncommon;
    public int WoodChestRare;
    public int WoodChestEpic;
    public int WoodChestLegendary;

    [SerializeField] private List<string> WoodChestDrops;
    
    
    [Header("Bronze Chest")]

    public int BronzeChestCommon;
    public int BronzeChestUncommon;
    public int BronzeChestRare;
    public int BronzeChestEpic;
    public int BronzeChestLegendary;

    [SerializeField] private List<string> BronzeChestDrops;



    [Header("Silver Chest")]

    public int SilverChestCommon;
    public int SilverChestUncommon;
    public int SilverChestRare;
    public int SilverChestEpic;
    public int SilverChestLegendary;

    [SerializeField] private List<string> SilverChestDrops;



    [Header("Gold Chest")]

    public int GoldChestCommon;
    public int GoldChestUncommon;
    public int GoldChestRare;
    public int GoldChestEpic;
    public int GoldChestLegendary;

    [SerializeField] private List<string> GoldChestDrops;



    [Header("Platinum Chest")]

    public int PlatinumChestCommon;
    public int PlatinumChestUncommon;
    public int PlatinumChestRare;
    public int PlatinumChestEpic;
    public int PlatinumChestLegendary;

    [SerializeField] private List<string> PlatinumChestDrops;



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < WoodChest; i++){ChestTypes.Add(new string("WoodChest"));}
        for (int i = 0; i < BronzeChest; i++){ChestTypes.Add(new string("BronzeChest"));}
        for (int i = 0; i < SilverChest; i++){ChestTypes.Add(new string("SilverChest"));}
        for (int i = 0; i < GoldChest; i++){ChestTypes.Add(new string("GoldChest"));}
        for (int i = 0; i < PlatinumChest; i++){ChestTypes.Add(new string("PlatinumChest"));}



        for (int i = 0; i < WoodChestCommon; i++) { WoodChestDrops.Add(new string("Common")); }
        for (int i = 0; i < WoodChestUncommon; i++) { WoodChestDrops.Add(new string("Uncommon")); }
        for (int i = 0; i < WoodChestRare; i++) { WoodChestDrops.Add(new string("Rare")); }
        for (int i = 0; i < WoodChestEpic; i++) { WoodChestDrops.Add(new string("Epic")); }
        for (int i = 0; i < WoodChestLegendary; i++) { WoodChestDrops.Add(new string("Platinum")); }

        for (int i = 0; i < BronzeChestCommon; i++) { BronzeChestDrops.Add(new string("Common")); }
        for (int i = 0; i < BronzeChestUncommon; i++) { BronzeChestDrops.Add(new string("Uncommon")); }
        for (int i = 0; i < BronzeChestRare; i++) { BronzeChestDrops.Add(new string("Rare")); }
        for (int i = 0; i < BronzeChestEpic; i++) { BronzeChestDrops.Add(new string("Epic")); }
        for (int i = 0; i < BronzeChestLegendary; i++) { BronzeChestDrops.Add(new string("Platinum")); }

        for (int i = 0; i < SilverChestCommon; i++) { SilverChestDrops.Add(new string("Common")); }
        for (int i = 0; i < SilverChestUncommon; i++) { SilverChestDrops.Add(new string("Uncommon")); }
        for (int i = 0; i < SilverChestRare; i++) { SilverChestDrops.Add(new string("Rare")); }
        for (int i = 0; i < SilverChestEpic; i++) { SilverChestDrops.Add(new string("Epic")); }
        for (int i = 0; i < SilverChestLegendary; i++) { SilverChestDrops.Add(new string("Platinum")); }

        for (int i = 0; i < GoldChestCommon; i++) { GoldChestDrops.Add(new string("Common")); }
        for (int i = 0; i < GoldChestUncommon; i++) { GoldChestDrops.Add(new string("Uncommon")); }
        for (int i = 0; i < GoldChestRare; i++) { GoldChestDrops.Add(new string("Rare")); }
        for (int i = 0; i < GoldChestEpic; i++) { GoldChestDrops.Add(new string("Epic")); }
        for (int i = 0; i < GoldChestLegendary; i++) { GoldChestDrops.Add(new string("Platinum")); }

        for (int i = 0; i < PlatinumChestCommon; i++) { PlatinumChestDrops.Add(new string("Common")); }
        for (int i = 0; i < PlatinumChestUncommon; i++) { PlatinumChestDrops.Add(new string("Uncommon")); }
        for (int i = 0; i < PlatinumChestRare; i++) { PlatinumChestDrops.Add(new string("Rare")); }
        for (int i = 0; i < PlatinumChestEpic; i++) { PlatinumChestDrops.Add(new string("Epic")); }
        for (int i = 0; i < PlatinumChestLegendary; i++) { PlatinumChestDrops.Add(new string("Platinum")); }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            chestAwarded = ChestTypes[Random.Range(0, ChestTypes.Count)];

            if (chestAwarded == "WoodChest")
            {
                prizeAwarded = WoodChestDrops[Random.Range(0, WoodChestDrops.Count)];
            }

            if (chestAwarded == "BronzeChest")
            {
                prizeAwarded = BronzeChestDrops[Random.Range(0, BronzeChestDrops.Count)];
            }

            if (chestAwarded == "SilverChest")
            {
                prizeAwarded = SilverChestDrops[Random.Range(0, SilverChestDrops.Count)];
            }

            if (chestAwarded == "GoldChest")
            {
                prizeAwarded = GoldChestDrops[Random.Range(0, GoldChestDrops.Count)];
            }

            if (chestAwarded == "PlatinumChest")
            {
                prizeAwarded = PlatinumChestDrops[Random.Range(0, PlatinumChestDrops.Count)];
            }

         Debug.Log("Your chest awarded is: " + chestAwarded);
         Debug.Log("Your prize rarity is: " +  prizeAwarded);


        }
            


    }
}
