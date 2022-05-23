using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    public static RandomItem instance;
    public List<GameObject> allItems;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="pos"></param>
    public void RandomClone(Vector3 pos)
    {
        int index = Random.Range(0, allItems.Count);
        Instantiate(allItems[index], pos, Quaternion.identity);
    }
}