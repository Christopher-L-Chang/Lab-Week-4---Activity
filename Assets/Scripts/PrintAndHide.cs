using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 0;
    int random;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.tag == "Blue" && i == random)
        {
            rend.enabled = false;
        }
        Debug.Log(gameObject.name +  " : " + i++);
    }
}
