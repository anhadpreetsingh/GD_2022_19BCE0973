using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DoofusBehaviour : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float score = 0f;
    [SerializeField] TextMeshProUGUI textMesh;
    [SerializeField] JsonManager jsonManager;
    // Start is called before the first frame update
    void Start()
    {
        speed = jsonManager.rootObject.player_data.speed;
    }

    // Update is called once per frame
    void Update()
    {
        float Xval = Input.GetAxisRaw("Horizontal");
        float Yval = Input.GetAxisRaw("Vertical");

        float Xmov = Xval*speed*Time.deltaTime;
        float Ymov = -Yval*speed*Time.deltaTime;

        transform.position = new Vector3(transform.position.x + Ymov, transform.position.y, transform.position.z + Xmov);

        if(transform.position.y <= 0.4)
            SceneManager.LoadScene(2);
    }

    public void IncrementScore()
    {
        score++;
        textMesh.text = score.ToString();
    }


}
