using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PulpitBehaviour : MonoBehaviour
{
    
    public float timer = 5f;
    public bool scored = false;
    DoofusBehaviour db;

    // Update is called once per frame

    void Start()
    {
        GameObject dbObject = GameObject.Find("Doofus");
        db = dbObject.GetComponent<DoofusBehaviour>();
    }
    
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
            Destroy(gameObject);
    }

   
    void OnCollisionEnter(Collision collision)
    {
        if(!scored && collision.gameObject.CompareTag("Player"))
        {
            scored = true;
            db.IncrementScore();
        }
    }
    
}
