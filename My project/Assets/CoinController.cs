using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class CoinController : MonoBehaviour
{

+ private float speed = 300.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed*Time.deltaTime, 0);
    }   
     void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Player")
        {
            Destroy(gameObjrct, 0.3f);
        }
     }
}
