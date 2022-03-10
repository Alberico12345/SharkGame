using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_following_system : MonoBehaviour
{
    public GameObject Targeted_item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Targeted_item.transform.position.y, Targeted_item.transform.position.z);
    }
}
