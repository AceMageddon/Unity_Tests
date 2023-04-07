using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float RandomNumber = 7;
    public GameObject SomeObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Randomizer();
    }
    void Randomizer()
    {
        RandomNumber = Random.Range(1, 10);
        Debug.Log(RandomNumber);
        if (RandomNumber == 3)
        {
            Debug.Log("Condition check");
        }
    }
}
