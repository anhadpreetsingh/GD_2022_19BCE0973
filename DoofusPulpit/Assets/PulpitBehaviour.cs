using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PulpitBehaviour : MonoBehaviour
{
    JsonManager jsonManager;
    public float timermin = 5f;
    public float timermax = 7f;
    public float timer = 5f;
    public bool scored = false;
    DoofusBehaviour db;

    // Update is called once per frame

    void Start()
    {
        GameObject jsonManagerObject = GameObject.Find("JsonManager");
        jsonManager = jsonManagerObject.GetComponent<JsonManager>();
        timermin = jsonManager.rootObject.pulpit_data.min_pulpit_destroy_time;
        timermax = jsonManager.rootObject.pulpit_data.max_pulpit_destroy_time;

        timer = Random.Range(timermin, timermax);
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
