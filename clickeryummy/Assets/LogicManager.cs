using UnityEngine;
using TMPro;
using System.ComponentModel;
using System;
using UnityEngine.UI;
public class LogicManager : MonoBehaviour
{
    [HideInInspector]
    public int clicks = 0;
    public TMP_Text clickText;
    public GameObject mouse;
    [HideInInspector]
    public int clickPower;          //0, 1, 2, 3, 4, 5;
    //private int[] spoonStrength = { 1, 10, 250, 1000, 10000, 100000};
    // wooden, bronze, silver, gold, diamond, platinum;
    private int[] prices = { 250, 5000};
    [HideInInspector]
    public int money;
    public TMP_Text moneyCount;
    public Sprite woodSpoon;
    public Sprite silverSpoon;
    public Sprite goldSpoon;
    public Button shovelIcon;
    public TMP_Text upgradePrice;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clickPower = 0;
    }

    // Update is called once per frame
    void Update()
    {
        clickText.text = clicks.ToString() + " Clicks";
        moneyCount.text = money.ToString() + "x";
        Cursor.visible = false;
        mouse.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
        if (clickPower == 0)
        {
            shovelIcon.image.sprite = woodSpoon;
            mouse.GetComponent<SpriteRenderer>().sprite = woodSpoon;
        }
        else if (clickPower == 1)
        {
            shovelIcon.image.sprite = silverSpoon;
            mouse.GetComponent<SpriteRenderer>().sprite = silverSpoon;
        }
        else if (clickPower == 2)
        {
            shovelIcon.image.sprite = goldSpoon;
            mouse.GetComponent<SpriteRenderer>().sprite = goldSpoon;
        }
        upgradePrice.text = prices[clickPower].ToString() + "x";
    }
    public void Upgrade()
    {
        if (clickPower >= prices.Length)
        {
            return;
        }
        if (money >= prices[clickPower])
        {
            money -= prices[clickPower];
            clickPower++;
        }
    }
}
