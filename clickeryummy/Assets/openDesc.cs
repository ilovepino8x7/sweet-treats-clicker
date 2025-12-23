using UnityEngine;

public class openDesc : MonoBehaviour
{
    public GameObject description;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        description.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseEnter()
    {
        description.SetActive(true);
    }
    void OnMouseExit()
    {
        description.SetActive(false);
    }
}
