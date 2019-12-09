using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task_manager : MonoBehaviour
{
    public GameObject[] tileprefabs;
    private Transform playertransform;
    private float spawnZ=-10.0f;
    private float tilelength=10.0f;
    private int no=7;
    private float safezone=15.0f;
    private int lastind=0;
    private List<GameObject>activetiles;
    // Start is called before the first frame update
    void Start()
    { activetiles=new List<GameObject>();
        playertransform = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i=0;i<no;i++)
        {
            if(i<2)
                spawntile(0);
            else
                spawntile();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(playertransform.position.z-safezone>(spawnZ-no*tilelength))
        {
            spawntile();
            DeleteTile();
        }
        
    }

    private void spawntile(int prefabindex=-1)
    {
        GameObject go;
        if(prefabindex==-1)
            go=Instantiate(tileprefabs[randomindex()]) as GameObject;
        else
            go=go=Instantiate(tileprefabs[prefabindex]);
        go.transform.SetParent(transform);
        go.transform.position=Vector3.forward*spawnZ;
        spawnZ+=tilelength;
        activetiles.Add(go);
    }
    private void DeleteTile()
    {
        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);
    }
    private int randomindex()
    {
        
        int randomind=lastind;
        while(randomind==lastind)
        {
            randomind=Random.Range(0,4);
            
        }
        lastind=randomind;
        return randomind;
    }
}
