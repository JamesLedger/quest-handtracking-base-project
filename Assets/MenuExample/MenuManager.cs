using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject menuObject;
    public GameObject handObject;
    public GameObject headObject;
    public float xOffset;
    public float yOffset;
    public float zOffset;

    // Update is called once per frame
    void Update()
    {
    //    menuObject.transform.position = handObject.transform.position + new Vector3(xOffset, yOffset, zOffset);

      //  Vector3 direction_to_model = headObject.transform.position - menuObject.transform.position;
        //Quaternion rotation = Quaternion.LookRotation(direction_to_model, Vector3.up);
     //   menuObject.transform.rotation = rotation;
    }
}
