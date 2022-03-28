using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public float SpawnTime=5f;
    public float JackpotTime=20f;
    public GameObject[] prefabs;

    public float timer1;
    public float timer2;
    //public float screenHeight=10f;
    //public float screenWidth=20f;
    public int ID;
    public float y;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        timer1=SpawnTime;
        timer2=JackpotTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer1-=Time.deltaTime;
        timer2-=Time.deltaTime;
        if (timer1<=0)
        {
            ID=(int)Random.Range(0,prefabs.Length-1);
            y=Random.Range((-1)*InputAxes.screenHeight/2,InputAxes.screenHeight/2-1); 
            x=Random.Range((-1)*InputAxes.screenWidth/2,InputAxes.screenWidth/2); 
            Vector3 pos =new Vector3(x,y,1);

            Instantiate(prefabs[ID], pos, Quaternion.identity);
            timer1=SpawnTime;
        }

        if (timer2<=0)
        {
            for(int i=0; i<prefabs.Length;i++)
            {
            y=Random.Range((-1)*(InputAxes.screenHeight/2), (InputAxes.screenHeight/2-1)); 
            x=Random.Range((-1)*(InputAxes.screenWidth/2), (InputAxes.screenWidth/2)); 
            Vector3 pos =new Vector3(x,y,1);

            Instantiate(prefabs[i], pos, Quaternion.identity);
            }

            timer2=JackpotTime;
        }
      

    }
}
