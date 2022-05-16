using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour
{
   public int numberOfUnbreakableWalls= 12;
   public int numberOfBreakableWalls=5;
   public int numberOfDrops=20;
   //public Transform p1Pos;
   //public Transform p2Pos;
   public GameObject unBreakWallPrefab;
   public GameObject breakWallPrefab;
   public GameObject[] prefabs;
   public Transform[] spawnPosition;
   public int randomNumber;
   
   public bool[] ifFilled;

    private int Max;
    private int val; 
   

    // Start is called before the first frame update
    void Start()
    {
        ifFilled = new bool[spawnPosition.Length];
        Max=spawnPosition.Length;
        AssignBoolValues();

        FillUnBreakableWAlls();
        FillBreakableWAlls();
        FillDropItems();
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

    void AssignBoolValues()
    {
       for(int i = 0; i<spawnPosition.Length; i++)
        {
            ifFilled[i]=false;
        }  
    }

    void FillUnBreakableWAlls()
    {
        for(int i=0; i<numberOfUnbreakableWalls; i++)
        {
            randomNumber= Random.Range(0, Max);
            Instantiate(unBreakWallPrefab, spawnPosition[randomNumber].position, Quaternion.identity);
            ifFilled[randomNumber]=true;
        }
    }
    void FillBreakableWAlls()
    {
        for(int i=0; i<numberOfBreakableWalls; i++)
        {
            returnRandomNumber();

            
            Instantiate(breakWallPrefab, spawnPosition[val].position, Quaternion.identity);
            ifFilled[val]=true;
            
        }
    }

    void FillDropItems()
    {
        for(int i=0; i<numberOfDrops; i++)
        {
            returnRandomNumber();

            int drop = Random.Range(0, prefabs.Length +1);
            Instantiate(prefabs[drop], spawnPosition[val].position, Quaternion.identity);
            ifFilled[val]=true;
            
        }
    }

    void returnRandomNumber()
    {
        randomNumber= Random.Range(0, Max);
            for(int i=0; i<=Max; i++)
            {
                 if (ifFilled[randomNumber]==true)
                 {
                randomNumber= Random.Range(0, Max);
                }
                else
                {
                    ran(randomNumber);
                }
            } 
    }

    void ran(int x)
    {
        val=x;
    }
}
