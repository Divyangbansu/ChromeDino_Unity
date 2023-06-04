using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameMain : MonoBehaviour
{
    public GameObject Rock;
    public Text TextElement;
    public Text TextElement2;

    // public float jumplength;
    int c;
    public int maxRocks = 20;
    public int curRocks =0;
    public int freq=5;
    Vector3 boundary;
    int s = 0;

    // Start is called before the first frame update
    void Start()
    {
        //c = 0;
        InvokeRepeating("makeRock", 0.1f, 5f); 
    }

    // Update is called once per frame
    void Update()
    {
        boundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        // Dino.transform.position= new Vector2(boundary.x-21,boundary.y-8);
        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //     if (c == 0)
        //     {
        //         jumpmethod(new Vector2(0, 2));
        //         c = 1;
        //     }
        //     else if (c == 1)
        //     {
        //        downmethod(new Vector2(0, -2));
        //        c = 0;
        //     }
        // }
        // if(Input.GetKey(KeyCode.DownArrow))
        // {
        //     downmethod(new Vector2(0, -1));
        // }
    }

    // void jumpmethod(Vector2 direction)
    // {
    //     Dino.transform.Translate(direction * jumplength * Time.deltaTime);
    // }

    // void downmethod(Vector2 direction)
    // {
    //     Dino.transform.Translate(direction * jumplength * Time.deltaTime);
    // }

    void makeRock()
    {
        s += 10;
        Instantiate(Rock);
        Rock.transform.position = new Vector2(boundary.x,boundary.y-8);
        curRocks++;
    }

    public void removeRock()
    {
        curRocks--;
        TextElement.text = "Current Score:" + s;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
