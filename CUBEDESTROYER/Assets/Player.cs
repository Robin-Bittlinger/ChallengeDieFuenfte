using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int score = 0;

    void Start()
    {
        
    }

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("getroffen");
                Debug.Log(hit.collider);

                var thingtodestroy = hit.collider.gameObject.GetComponent<Cube>();

                score = score + thingtodestroy.cashmoney;
                thingtodestroy.destroySelf();
            }
            else
            {
                Debug.Log("daneben.lol.");
            }

        }

    }

}
