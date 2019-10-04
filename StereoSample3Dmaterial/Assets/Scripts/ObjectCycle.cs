using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ObjectCycle : MonoBehaviour
{
    public GameObject[] gameObjects;
    public Transform spawnPOS;
    GameObject clonedObject;
    int arrayPos = 0;
    public bool objectSpawned = false;
    void Update()
    {


        if (Input.GetButtonDown("Oculus_CrossPlatform_Button2"))
        {
            if (objectSpawned == true)
            {
                DestroyImmediate(clonedObject);
            }
            cycleObjects();
            clonedObject = Instantiate(gameObjects[arrayPos], spawnPOS.position, spawnPOS.rotation);
            objectSpawned = true;


         
        }

    }
    void Start()
    {
        clonedObject = Instantiate(gameObjects[0], spawnPOS.position, spawnPOS.rotation);
        objectSpawned = true;

    }

    void cycleObjects()
    {
        arrayPos++;
        if (arrayPos == gameObjects.Length )
        {
            arrayPos = 0;
        }
        
    }
}
  

