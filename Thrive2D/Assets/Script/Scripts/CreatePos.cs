using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePos : MonoBehaviour
{
   
    public static CreatePos instance;

    public int minX,maxX,minY,maxY;//±ß½ç
    public int maxCount;

    public List<Transform> usefulPos;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        usefulPos = new List<Transform>();
        for (int i = 0; i < transform .childCount ; i++)
        {
            usefulPos.Add(transform .GetChild (i));

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform    GetPos()
    {
        int index =Random .Range (0,usefulPos.Count);
        Transform tr= usefulPos[index]; ;
        usefulPos.RemoveAt(index);
        return tr ;
    }
    /// <summary>
    /// ÊÍ·Å×ø±ê 
    /// </summary>
    /// <param name="vect"></param>
    public void RemoveVec(Transform  vect)
    {
        usefulPos.Add(vect);
    }
    
}
