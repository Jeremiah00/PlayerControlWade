using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    private Vector3 position1 = new Vector3(0, 5, -7);
    private Vector3 position2 = new Vector3(0,2, 1);

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = player.transform.position + position2;
            transform.rotation = player.transform.rotation;
            
        }
        else
        {
            transform.position = player.transform.position + position1;
            transform.rotation = Quaternion.Euler(20, 0, 0);

        }
    }
}
