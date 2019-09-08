using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public Transform mobAlien;
    public Transform mobSlime;
    public Transform mobFly;
    public int spawnLoc;
    public int spawnDelay;
    public int randvec;
    public int spawnLoc2;
    public int randvec2;
    public int spawnLoc3;
    public int randvec3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnLoc = Random.Range(1, 5);
        randvec = Random.Range(1, 5);
        spawnLoc2 = Random.Range(1, 5);
        randvec2 = Random.Range(1, 5);
        spawnLoc3 = Random.Range(1, 5);
        randvec3 = Random.Range(1, 5);


        if (spawnDelay == 0)
        {
            Instantiate(mobAlien, new Vector3(spawnLoc, randvec, 0), mobAlien.rotation);
            Instantiate(mobSlime, new Vector3(spawnLoc2, randvec2, 0), mobSlime.rotation);
            Instantiate(mobFly, new Vector3(spawnLoc3, randvec3, 0), mobFly.rotation);
            spawnDelay = 1;
            StartCoroutine(spawnReset());
        }

        /*
        if (spawnLoc == 1 && (spawnDelay==0))
        {
            Instantiate(mobAlien, new Vector3(-5, 0, 0), mobAlien.rotation);
            spawnDelay = 1;
            StartCoroutine(spawnReset());
        }

        if (spawnLoc == 2 && (spawnDelay == 0))
        {
            Instantiate(mobAlien, new Vector3(5, 0, 0), mobAlien.rotation);
            spawnDelay = 1;
            StartCoroutine(spawnReset());
        }

        if (spawnLoc == 3 && (spawnDelay == 0))
        {
            Instantiate(mobAlien, new Vector3(0, 4, 0), mobAlien.rotation);
            spawnDelay = 1;
            StartCoroutine(spawnReset());
        }

        if (spawnLoc > 3 && (spawnDelay == 0))
        {
            Instantiate(mobAlien, new Vector3(4, -4, 0), mobAlien.rotation);
            spawnDelay = 1;
            StartCoroutine(spawnReset());
        }
        */
    }
    IEnumerator spawnReset()
    {
        yield return new WaitForSeconds(3);
        spawnDelay = 0;
    }
}
