/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityGameplayScripts
{
    
    //This must be attached to the main camera
    public class ClickToSpawn : MonoBehaviour
    {
        //Must drag a prefab onto this reference in the inspector
        public GameObject prefabToSpawn;

        // Update is called once per frame
        void Update()
        {
            //Spawns the prefab on LMB click at the clicked location on the Floor object
            if(Input.GetMouseButtonDown(0))
            {
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hitInfo;

                    if (Physics.Raycast(ray, out hitInfo))
                    {
                        if (hitInfo.transform.name == "Floor")
                        {
                            Instantiate(prefabToSpawn, hitInfo.point, Quaternion.identity);
                        }
                    }
                }
            }

            //Destroys any object tagged as "Enemy" on RMB click
            if (Input.GetMouseButtonDown(1))
            {
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(rayOrigin, out hitInfo))
                {
                    if (hitInfo.collider.gameObject.tag == "Enemy")
                    {
                        Destroy(hitInfo.collider.gameObject);

                    }
                }
            }

        }
    }
}