using UnityEngine;

public class fudgeControl : MonoBehaviour
{
    public LogicManager ls;
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
        ls.clicks++;
    }
}
