using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{
    private NavMeshAgent _agent;
    public GameObject moveToObject;
    public GameObject moveToObject2;
    public GameObject moveToObject3;
    private GameObject destinationPlace;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        destinationPlace = moveToObject;
    }

    // Update is called once per frame
    void Update()
    {
        _agent.destination = destinationPlace.transform.position;


        if (Vector3.Distance(transform.position,destinationPlace.transform.position) < 1)
        {
            if (moveToObject2 != null)
            {
                destinationPlace = moveToObject2;
                moveToObject2 = null;
            }
            else
            {
                if(moveToObject3 != null)
                {
                    destinationPlace = moveToObject3;
                }
            }
        }

    }
}
