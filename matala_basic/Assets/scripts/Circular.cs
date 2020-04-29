using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circular : MonoBehaviour
{
    [SerializeField] Transform rotationCenter;
    [SerializeField]
    float radius = 2f,
        angularSpeed = 2f;
    float posX, posY, angle = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //שינוי זוית בלחיצה

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            angle += Time.deltaTime * -angularSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            angle += Time.deltaTime * angularSpeed;

        }

        //שינוי מקום

        posX = radius * Mathf.Cos(angle);
        posY = radius * Mathf.Sin(angle);
        transform.localPosition = new Vector3(posX, posY, transform.position.z);
    }
}