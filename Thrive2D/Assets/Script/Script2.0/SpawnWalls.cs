using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour
{
   public int numberOfUnbreakableWalls= 15;
   public int numberOfBreakableWalls=50;
   public int numberOfDrops=30;
   public float reArrangeTime=30;
   public CameraScript camScript;
   public Transform p1Pos;
   //public Transform p2Pos;
   public GameObject unBreakWallPrefab;
   public GameObject breakWallPrefab;
   public GameObject[] prefabs;
   public Transform[] spawnPosition;

   public float timer=0;

    public bool[] isFree;
    private int Max;
    private int val; 

    int Rand;
   public List<int> list = new List<int>();
   
   private void Awake() {
       Max=spawnPosition.Length;
       val=numberOfBreakableWalls+numberOfUnbreakableWalls+numberOfDrops;
        
   }

    // Start is called before the first frame update
    void Start()
    {
        isFree=new bool[Max];
        AssignBoolValue();
        CheckPlayerPos();
        FillUnBreakableWAlls();
        FillDropItems();
        FillBreakableWAlls();
        timer=reArrangeTime;
        
    }

    // Update is called once per frame
    void Update()
    {  
        
        if (timer<=0)
        {
            AssignBoolValue();
            CheckPlayerPos();
            CreateRandomvalues();
            FillUnBreakableWAlls();
            FillDropItems();
            FillBreakableWAlls(); 
            //StartCoroutine(camScript.Shake(.5f,1.9f)); 

            timer = reArrangeTime;
        }

        timer-=Time.deltaTime;
    }

    void AssignPos()
    {
        Vector3 origin =new Vector3(0,0,0);

        //for (int i=0; i< (int)InputAxes.screenWidth;i++)
        //{
       //     for (int j=)
        //}
    }
    void AssignBoolValue()
    {
        for(int i=0;i<Max;i++)
        {
            isFree[i]=true;
        }
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
           if(isFree[list[i]]==true)
           {
               Instantiate(unBreakWallPrefab, spawnPosition[list[i]].position, Quaternion.identity);
               isFree[list[i]]=false;
           }
                
          
        }
    }
    void FillBreakableWAlls()
    {
        for(int i=0; i<numberOfBreakableWalls; i++)
        {
           if(isFree[list[(numberOfUnbreakableWalls+i)]]==true)
           {
               Instantiate(breakWallPrefab, spawnPosition[list[(numberOfUnbreakableWalls+i)]].position, Quaternion.identity);
                isFree[list[(numberOfUnbreakableWalls+i)]]=false;
           }
                
          
        }
    }

    void FillDropItems()
    {
        for(int i=0; i<numberOfDrops; i++)
        {
            int drop = Random.Range(0, prefabs.Length);
             if(isFree[list[(numberOfUnbreakableWalls+numberOfBreakableWalls+i)]]==true)
             {
                 Instantiate(prefabs[drop], spawnPosition[list[(numberOfUnbreakableWalls+numberOfBreakableWalls+i)]].position, Quaternion.identity);
                 isFree[list[(numberOfUnbreakableWalls+numberOfBreakableWalls+i)]]=false;
             }
            
        }
    }

    void CheckPlayerPos()
    {
        int x1=(int)p1Pos.position.x;
        int y1=(int)p1Pos.position.y;
    for (int i=0; i<Max;i++)
    {
       int x=(int)spawnPosition[i].position.x;
       int y=(int)spawnPosition[i].position.y;
        if((int)x1==x && (int)y1 ==y)
        {
             if(!((i-1)<0))
            {
                isFree[i-1]=false;
            }
            isFree[i]=false;
              if(!((i+1)>Max))
            {
                isFree[i+1]=false;
            }
        }
    }
    }
        
}
