using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyGold
{
    private static MyGold gold;
    public int quantity = 1000;

    public static MyGold Gold
    {
        get {
            if (gold==null)
            {
                gold = new MyGold();
            } 
            return MyGold.gold;
        }
        
    }

    private MyGold()
    { 
    }

    

}
