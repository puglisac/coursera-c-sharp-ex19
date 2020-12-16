using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // spawn teddy bear as appropriate
        if(Input.GetAxis("SpawnTeddyBear")>0)
        {
            if (!spawnInputOnPreviousFrame)
            {
                spawnInputOnPreviousFrame = true;

                //get location of mouse on click
                Vector3 newPosition = Input.mousePosition;
                newPosition.z = -Camera.main.transform.position.z;
                newPosition = Camera.main.ScreenToWorldPoint(newPosition);
                //spawn new teddyBear
                GameObject teddyBear = Instantiate(prefabTeddyBear) as GameObject;
                teddyBear.transform.position = newPosition;
            }
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate
        if (Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            if (!explodeInputOnPreviousFrame)
            {
                explodeInputOnPreviousFrame = true;

                GameObject teddyBearToExplode = GameObject.FindWithTag("TeddyBear");
                if (teddyBearToExplode)
                {
                    Vector3 location = teddyBearToExplode.transform.position;
                    GameObject explosion = Instantiate(prefabExplosion) as GameObject;
                    explosion.transform.position = location;
                    Destroy(teddyBearToExplode);
                }
            
            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }

    }
}


//Vector3 newPosition = Input.mousePosition;
//newPosition.z = -Camera.main.transform.position.z;
//newPosition = Camera.main.ScreenToWorldPoint(newPosition);
//transform.position = newPosition;

//GameObject teddyBear = Instantiate(prefabTeddyBear) as GameObject;
//teddyBear.transform.position = worldLocation;