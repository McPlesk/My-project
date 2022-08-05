using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveplayer : MonoBehaviour
{
    public static string havekey = "n";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal")*4, Input.GetAxis("Vertical")*4);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "spikes"){
            transform.GetComponent<Renderer>().material.color = Color.red;
            //Destroy(gameObject);


        }
    }

    private void OnCollisionEnter2D(Collision2D door){
        if ((door.gameObject.tag == "door") && (havekey == "y")){
            SceneManager.LoadScene("winscreen");
        }

    }
}



