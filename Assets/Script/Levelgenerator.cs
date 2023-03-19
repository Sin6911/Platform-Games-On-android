using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelgenerator : MonoBehaviour
{
    public GameObject thePlatfrom;
    public Transform generationPoint;
    public float distanceBetween;
    public float distanceBetweenMin;
    public float distanceBetweenMax;


    private float platformWidth;

    private void Start()
    {
        platformWidth = thePlatfrom.GetComponent<BoxCollider2D>().size.x;
    }
    private void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(thePlatfrom, transform.position, transform.rotation);
        }
    }
}
