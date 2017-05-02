using UnityEngine;
using System.Collections;

public class GameManager{

    private static GameManager gm;
    public int curSelectCar = 0;
    public int curSelectType = 0;

    public bool que = true;
    public bool que2 = true;
    public static GameManager Gm
    {
        get {
            if (gm == null)
            {
                gm = new GameManager();
            }
            return GameManager.gm; 
        }
    }

    private GameManager()
    { 
    }

}
