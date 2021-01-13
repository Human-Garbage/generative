using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiler : MonoBehaviour
{


    public GameObject thingToTile;
    public float nodeDistance;
    public Vector3Int gridSize = new Vector3Int();
    public Vector3 incrementalDisplacement = new Vector3();
    public float maxRandomDisplacement;
    Vector3 startDisplacement = new Vector3();
    Vector3 finalDisplacement = new Vector3();

    List<Vector3> positions = new List<Vector3>();
    void Start()
    {
        StartCoroutine(Tile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Tile()
    {
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < gridSize.x; i++)
        {
            Vector3 newPos = new Vector3(nodeDistance * i, 0, 0);
            
            positions.Add(newPos);
            newPos += (Random.insideUnitSphere * maxRandomDisplacement);
            Instantiate(thingToTile, newPos, transform.rotation);
            for (int g = 0; g < gridSize.y; g++)
            {
                //yield return null;
                Vector3 newPos2 = new Vector3(nodeDistance * i, nodeDistance * g, 0);

                if (!positions.Contains(newPos2))
                {
                    positions.Add(newPos2);
                    newPos2 += (Random.insideUnitSphere * maxRandomDisplacement);

                    Instantiate(thingToTile, newPos2, transform.rotation);
                    
                }
                for (int f = 0; f < gridSize.z; f++)
                {
                    Vector3 newPos3 = new Vector3(nodeDistance * i, nodeDistance * g, nodeDistance * f);
                    if (!positions.Contains(newPos3))
                    {
                        positions.Add(newPos3);
                        newPos3 += (Random.insideUnitSphere * maxRandomDisplacement);
                        Instantiate(thingToTile, newPos3, transform.rotation);

                    }
                    //yield return null;
                }
                //yield return null;
            }
            //yield return null;
        }
    }
}
