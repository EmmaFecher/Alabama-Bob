using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public PlayerMovement key;
    // Start is called before the first frame update
    void Start()
    {
        key.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(key.hasKeycard == true)
        {
            transform.position = new Vector3(-1.76f, -16.39f, 0);
        }
        else
        {
            transform.position = new Vector3(-1.76f, -19.08f, 0);
        }
    }
}
