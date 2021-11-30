using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]



    public class Pool {
        public string tag;
        public int poolsize;
        public GameObject x;
    }
    public List <Pool> pools;
    public Dictionary<string, Queue<GameObject>> dictionary;



    void Start()
    {
    dictionary = new Dictionary<string, Queue<GameObject>>();
    
    foreach (Pool pool in pools)
    {
    Queue<GameObject> objectPool = new Queue<GameObject>();

    for(int i=0;i<pool.poolsize;i++)
    {
        GameObject o = Instantiate(pool.x);
        o.SetActive(false);
        objectPool.Enqueue(o);
    }

    dictionary.Add(pool.tag, objectPool);
    }
    }



    public GameObject SpawnFromPool(string tag, Vector2 position, Quaternion rotation)
    {
        if (!dictionary.ContainsKey(tag))
        {
            Debug.LogWarning("ERROR: TAG " + tag + "does not exist");
            return null;
        }
        GameObject objectToSpawn = dictionary[tag].Dequeue();
        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        dictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }



}
