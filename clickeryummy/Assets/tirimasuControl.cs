using UnityEngine;

public class fudgeControl : MonoBehaviour
{
    public LogicManager ls;
    // wooden, bronze, silver, gold, diamond, platinum
    //sharperspoon
    private int[] spoonStrength = { 1, 10, 250, 1000, 10000, 100000,};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ls = GameObject.FindWithTag("logos").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        ls.clicks += spoonStrength[ls.clickPower];
        ls.money += spoonStrength[ls.clickPower];
    }
}
