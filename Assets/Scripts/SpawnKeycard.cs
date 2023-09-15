using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKeycard : MonoBehaviour
{
    List<Vector3> keyPos;
    private int chosenSpot;

    // Start is called before the first frame update
    void Start()
    {
        CreateList();
        GetRandomIndex();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateList()
    {
        //keyPos.Add(new Vector3());
        keyPos = new List<Vector3>();
        keyPos.Add(new Vector3(-20.77f, -11.27f, 0));
        keyPos.Add(new Vector3(-25.6f, -6.24f, 0));
        keyPos.Add(new Vector3(-13.24f, -6.26f, 0));
        keyPos.Add(new Vector3(-20.75f, 3.75f, 0));
        keyPos.Add(new Vector3(-10.46f, -1.26f, 0));
        keyPos.Add(new Vector3(2.06f, 1.48f, 0));
        keyPos.Add(new Vector3(4.45f, -3.61f, 0));
        keyPos.Add(new Vector3(-0.52f, -13.82f, 0));
        keyPos.Add(new Vector3(-30f, -16.5f, 0));
        keyPos.Add(new Vector3(-20.3f, -24.3f, 0));
        keyPos.Add(new Vector3(-14.53f, -24.51f, 0));
        keyPos.Add(new Vector3(3f, -27.9f, 0));
        keyPos.Add(new Vector3(-30.88f, -11f, 0));
        keyPos.Add(new Vector3(-36.47f, 3.83f, 0));
    }

    void GetRandomIndex()
    {
        chosenSpot = Random.Range(0, 14);
        transform.position = keyPos[chosenSpot];
    }

}
