using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulpitManager : MonoBehaviour
{
    [SerializeField] JsonManager jsonManager;
    [SerializeField] GameObject pulpit;
    PulpitBehaviour currentPulpit;
    [SerializeField] float x = 2f;

    void Start()
    {
        x = jsonManager.rootObject.pulpit_data.pulpit_spawn_time-1;
        GameObject firstPulpit = Instantiate(pulpit, new Vector3(0, 0, 0), Quaternion.identity);
        currentPulpit = firstPulpit.GetComponent<PulpitBehaviour>();
    }
    // Update is called once per frame
    void Update()
    {
        if(currentPulpit.timer <= x)
        {
            GameObject newPulpitObject;
            Vector3 newPulpitPos = new Vector3();
            int pos = Random.Range(1, 4);
            switch(pos)
            {
                case 1:
                    newPulpitPos = new Vector3(currentPulpit.transform.position.x, currentPulpit.transform.position.y, currentPulpit.transform.position.z-9f);
                    break;
                case 2:
                    newPulpitPos = new Vector3(currentPulpit.transform.position.x+9f, currentPulpit.transform.position.y, currentPulpit.transform.position.z);
                    break;
                case 3:
                    newPulpitPos = new Vector3(currentPulpit.transform.position.x, currentPulpit.transform.position.y, currentPulpit.transform.position.z+9f);
                    break;
                case 4:
                    newPulpitPos = new Vector3(currentPulpit.transform.position.x-9f, currentPulpit.transform.position.y, currentPulpit.transform.position.z);
                    break;
            }

            newPulpitObject = Instantiate(pulpit, newPulpitPos, Quaternion.identity);
            currentPulpit = newPulpitObject.GetComponent<PulpitBehaviour>();
            
        }
    }
}
