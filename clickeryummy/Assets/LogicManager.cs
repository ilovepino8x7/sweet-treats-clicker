using UnityEngine;
using TMPro;
public class LogicManager : MonoBehaviour
{
    [HideInInspector]
    public int clicks = 0;
    public TMP_Text clickText;
    public GameObject mouse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clickText.text = clicks.ToString() + " Clicks";
        Cursor.visible = false;
        mouse.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
    }
}
