using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public GameObject gameOverText;
    //public GameOverScript gameOverScript;
    public float speed = 3f;

    void Start()
    {
        //gameOverText.SetActive(false);
    }
    void Update()
    {
        //gameOverText.SetActive(false);   

        //player´s finger
        UnityEngine.Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new UnityEngine.Vector3(pos.x, transform.position.y,transform.position.z);

        //float hor = Input.GetAxisRaw("Horizontal");
        //UnityEngine.Vector3 dir = new UnityEngine.Vector3(hor,0,0);
        //transform.Translate(dir.normalized * Time.deltaTime * speed);
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Car"))
        {
            //gameOverText.SetActive(true);
            //gameOverScript.ShowGameOver();
            Destroy(gameObject);                       
            EditorApplication.isPaused = true;    
        }
    }    
}


