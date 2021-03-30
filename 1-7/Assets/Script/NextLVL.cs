using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLVL : MonoBehaviour
{
    public Transform Player;
    public GameObject Flors;
    public GameObject FirstFlor;

    public List<GameObject> spawnedFlors;

    void Start()
    {
        spawnedFlors.Add(FirstFlor);
    }
    void Update()
    {
        Vector3 LastFlorPos = spawnedFlors[spawnedFlors.Count - 1].transform.position;
        if (Player.position.y >= LastFlorPos.y - 15f)
        {
            SpawnFlorUp();
        }
    }
    void SpawnFlorUp()
    {
        GameObject newFlor = Instantiate(Flors);

        Vector3 Spawnpos = spawnedFlors[spawnedFlors.Count - 1].transform.position;
        newFlor.transform.position = new Vector3(Spawnpos.x, Spawnpos.y + 6.2f, Spawnpos.z);
        spawnedFlors.Add(newFlor);

        if (spawnedFlors.Count >= 10)
        {
            Destroy(spawnedFlors[0].gameObject);
            spawnedFlors.RemoveAt(0);
        }
    }
}
