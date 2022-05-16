using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour
{
   public int numberOfUnbreakableWalls= 15;
   public int numberOfBreakableWalls=50;
   public int numberOfDrops=30;
   //public Transform p1Pos;
   //public Transform p2Pos;
   public GameObject unBreakWallPrefab;
   public GameObject breakWallPrefab;
   public GameObject[] prefabs;
   public Transform[] spawnPosition;

    private int Max;
    private int val; 

    int Rand;
   public List<int> list = new List<int>();
   
   private void Awake() {
       Max=spawnPosition.Length-1;
       val=numberOfBreakableWalls+numberOfUnbreakableWalls+numberOfDrops;
        CreateRandomvalues();
   }

    // Start is called before the first frame update
    void Start()
    {
        
        FillUnBreakableWAlls();
        FillDropItems();
        FillBreakableWAlls();
        
    }

    // Update is called once per frame
    void Update()
    {  
    }

    void AssignPos()
    {
        Vector3 origin =new Vector3(0,0,0);

        //for (int i=0; i< (int)InputAxes.screenWidth;i++)
        //{
       //     for (int j=)
        //}
    }

    void CreateRandomvalues()
    {
        list = new List<int>(new int[val]);

        for (int j=0; j<val; j++)
        {
            Rand = Random.Range(0,Max+1);

            while (list.Contains(Rand))
            {
                Rand=Random.Range(0,Max+1);
            }

            list[j]=Rand;
        }
    }

    void FillUnBreakableWAlls()
    {
        for(int i=0; i<numberOfUnbreakableWalls; i++)
        {
            Instantiate(unBreakWallPrefab, spawnPosition[list[i]].position, Quaternion.identity);
        }
    }
    void FillBreakableWAlls()
    {
        for(int i=0; i<numberOfBreakableWalls; i++)
        {
            Instantiate(breakWallPrefab, spawnPosition[list[(numberOfUnbreakableWalls+i)]].position, Quaternion.identity);
            
        }
    }

    void FillDropItems()
    {
        for(int i=0; i<numberOfDrops; i++)
        {
            int drop = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[drop], spawnPosition[list[(numberOfUnbreakableWalls+numberOfBreakableWalls+i)]].position, Quaternion.identity);
            
        }
    }

}
