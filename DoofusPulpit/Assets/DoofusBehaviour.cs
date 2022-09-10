using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoofusBehaviour : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Xval = Input.GetAxisRaw("Horizontal");
        float Yval = Input.GetAxisRaw("Vertical");

        float Xmov = Xval*speed*Time.deltaTime;
        float Ymov = -Yval*speed*Time.deltaTime;

        transform.position = new Vector3(transform.position.x + Ymov, transform.position.y, transform.position.z + Xmov);
    }
}
