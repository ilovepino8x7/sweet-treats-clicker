using UnityEngine;

public class forkMove : MonoBehaviour
{
    public GameObject[] path;
    private int pathNum = 0;
    private int pleaseSpeedINeedThis = 5;
    private float timer = 0;
    public LogicManager ls;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        path = new GameObject[11];
        ls = GameObject.FindWithTag("logos").GetComponent<LogicManager>();
        ls.cps += 5;
        path[0] = GameObject.FindWithTag("p0");
        path[1] = GameObject.FindWithTag("p1");
        path[2] = GameObject.FindWithTag("p2");
        path[3] = GameObject.FindWithTag("p3");
        path[4] = GameObject.FindWithTag("p4");
        path[5] = GameObject.FindWithTag("p5");
        path[6] = GameObject.FindWithTag("p6");
        path[7] = GameObject.FindWithTag("p7");
        path[8] = GameObject.FindWithTag("p8");
        path[9] = GameObject.FindWithTag("p9");
        path[10] = GameObject.FindWithTag("p10");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, path[pathNum].transform.position, pleaseSpeedINeedThis * Time.deltaTime);
        if (Vector2.Distance(transform.position, path[pathNum].transform.position) <= 0.1f)
        {
            pathNum++;
            if (pathNum > path.Length - 1)
            {
                pathNum = 0;
            }
        }
        if (timer >= 1)
        {
            ls.clicks += 5;
            ls.money += 5;
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
