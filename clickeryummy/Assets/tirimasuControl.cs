using UnityEngine;

public class fudgeControl : MonoBehaviour
{
    public LogicManager ls;
    public Transform[] spawnPoints;
    public GameObject tmasuMini;
    // wooden, bronze, silver, gold, diamond, platinum
    //sharperspoon
    private int[] spoonStrength = { 1, 50, 2500};
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
        Transform randSpawn = spawnPoints[Random.Range(0,9)];
        Instantiate(tmasuMini,new Vector3(randSpawn.position.x, randSpawn.position.y),Quaternion.identity);
        randSpawn = null;
    }
}
