using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class moveRock : MonoBehaviour
{
    public float minSpeed=3;
    public float maxSpeed=4;
    float currSpeed;
    Vector3 boundary;
    private gameMain dinoJumpScript;
   
    // Start is called before the first frame update
    void Start()
    {
        dinoJumpScript=GameObject.Find("Main Camera").GetComponent<gameMain>();
        currSpeed=Random.Range(minSpeed,maxSpeed);
        //currSpeed=3;
    }

    // Update is called once per frame
    void Update()
    {
        boundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        if(transform.position.x > -boundary.x - GetComponent<SpriteRenderer>().bounds.size.x/2)
            transform.Translate(new Vector3(-1,0,0)*currSpeed*Time.deltaTime);
        else if(transform.position.x<=-boundary.x - GetComponent<SpriteRenderer>().bounds.size.x/2)
        {
            dinoJumpScript.removeRock();
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dinoJumpScript.TextElement2.text = "Game Over";
            Destroy(collision.gameObject);
            dinoJumpScript.removeRock();
            Destroy(this.gameObject);
            dinoJumpScript.Restart();
        }
    }
}
