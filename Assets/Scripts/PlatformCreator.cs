using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreator : MonoBehaviour
{

    [SerializeField] GameObject[] platformPrefab;
    [SerializeField] Transform referencePoint;
    [SerializeField] private GameObject lastCreatedPlatform;
    float lastPlatformWidth;
    [SerializeField] float spaceBetweenPlatforms = 2;
    
    void Start()
    {
        //lastCreatedPlatform = Instantiate(platformPrefab, referencePoint.position, Quaternion.identity);
    }

    void Update()
    {
        if(lastCreatedPlatform.transform.position.x < referencePoint.position.x)
        {
            Vector3 targetCreationPoint = new Vector3(referencePoint.position.x + lastPlatformWidth + spaceBetweenPlatforms, 0, 0);
            int randomPlatform = Random.Range(0, platformPrefab.Length);
            lastCreatedPlatform = Instantiate(platformPrefab[randomPlatform], targetCreationPoint, Quaternion.identity);
            BoxCollider2D collider = lastCreatedPlatform.GetComponent<BoxCollider2D>();
            lastPlatformWidth = collider.bounds.size.x;
        }
    }
}
