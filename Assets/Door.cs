using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 Offpos = Vector3.zero;
    public int WaitTime = 5;
    private Vector3 Cpos;
    private Vector3 Opos;
    // Start is called before the first frame update
    void Start()
    {
        Cpos = transform.position;
        Opos = Cpos + Offpos;

        StartCoroutine(MoveObject());
    }

    // Update is called once per frame
    IEnumerator MoveObject()
    {
        Vector3 goal = Opos;
        bool isOpos = false;
        while (true)
        {
            if (Vector3.Distance(transform.position, goal) < 0.2f)
            {
                isOpos = !isOpos;
                if (isOpos)
                {
                    goal = Cpos;
                }
                else
                {
                    goal = Opos;
                }
                yield return new WaitForSeconds(WaitTime);
            }
            transform.position = Vector3.MoveTowards(transform.position, goal, 4f * Time.deltaTime);
            yield return null;
        }

    }
}