using System.Collections.Generic;
using UnityEngine;

public class OndaPool : MonoBehaviour
{
    public static OndaPool Instance;

    public GameObject wavePrefab;
    public int poolSize = 10;

    private List<GameObject> pool = new List<GameObject>();

    void Awake()
    {
        Instance = this;

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(wavePrefab, transform);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject GetObject()
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        GameObject newObj = Instantiate(wavePrefab, transform);
        newObj.SetActive(false);
        pool.Add(newObj);

        return newObj;
    }
}
