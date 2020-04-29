using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeats : MonoBehaviour
{
    [SerializeField] float Beats;
    private Vector3 oldPos;
    // Start is called before the first frame update

    void Start()
    {
        oldPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {




        //float phase = Speed * Time.time + deltaPhase / oldPos.x;

        transform.localScale = new Vector3(oldPos.x + (Beats * Time.deltaTime), oldPos.y + (Beats * Time.deltaTime));

    }
}