using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BuyCar2 : MonoBehaviour {
    public GameObject Qbut;
    public GameObject pur1;
    public GameObject pur2;

    public Text shuo;

    public void buy2()
    {
       
           if (MyGold.Gold.quantity >= 300)
           {
               Qbut.SetActive(true);
               MyGold.Gold.quantity -= 300;
               shuo.text = "恭喜您购买成功！";
               StartCoroutine(DestroyTest());
           GameManager.Gm.que = false;
           }
           else
           {
               shuo.text = "金币不足！";
               StartCoroutine(DestroyTest2());
           }
          
    }
    IEnumerator DestroyTest()
    {
        yield return new WaitForSeconds(0.5f);
        shuo.text = "";
        pur1.SetActive(false);
        pur2.SetActive(false);
    }
    IEnumerator DestroyTest2()
    {
        yield return new WaitForSeconds(0.2f);
        shuo.text = "";
    }
    public void buy3()
    {
        if (MyGold.Gold.quantity >= 500)
        {
            Qbut.SetActive(true);
            MyGold.Gold.quantity -= 500;
            shuo.text = "恭喜您购买成功！";
            StartCoroutine(DestroyTest3());
        GameManager.Gm.que2 = false;
        }
        else 
        {
            shuo.text = "金币不足！";
            StartCoroutine(DestroyTest4());
        }
    }
    IEnumerator DestroyTest3()
    {
        yield return new WaitForSeconds(0.5f);
        shuo.text = "";
        pur1.SetActive(false);
        pur2.SetActive(false);
    }
    IEnumerator DestroyTest4()
    {
        yield return new WaitForSeconds(0.2f);
        shuo.text = "";
    }
}
