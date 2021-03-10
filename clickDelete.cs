using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDelete : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;

                if (bc.CompareTag("block"))
                {
                    Destroy(bc.gameObject);
                }
            }
        }
        
    }
}
