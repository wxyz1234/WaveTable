using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveTable : MonoBehaviour
{
    // Start is called before the first frame update
    bool[,] a=new bool[5,5];
    GameObject[,] smallcube=new GameObject[5,5];   
    public int k=0,i=-1,j=-1;    
    void Start()
    {
        Debug.Log("Hello Unity");        
        this.transform.localScale =new UnityEngine.Vector3(5,5,5);
        this.transform.position =new UnityEngine.Vector3(0,0,0);
        GameObject obj=GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.transform.localScale =new UnityEngine.Vector3(1,4,1);
        obj.transform.position=new UnityEngine.Vector3(0,10,0);
        obj.GetComponent<MeshRenderer>().material.color = Color.blue;
        obj.SetActive(true);                     
        for (int i=0;i<5;i++)
            for (int j=0;j<5;j++){                
                smallcube[i,j]=GameObject.CreatePrimitive(PrimitiveType.Cube);
                smallcube[i,j].transform.localScale=new UnityEngine.Vector3(1,4,1);
                smallcube[i,j].transform.position=new UnityEngine.Vector3(i-2,0,j-2);
                smallcube[i,j].GetComponent<MeshRenderer>().material.color =new Color((float)i/4,(float)j/4,0,1);
                smallcube[i,j].SetActive(true);  
                a[i,j]=false;              
            }       
    }

    public string gett(){
        return "测试结果："+k.ToString()+" "+i.ToString()+" "+j.ToString();
    }
    int geti(){
        return i;
    }

    // Update is called once per frame
    void change(int i,int j){        
        a[i,j]=!a[i,j];
        if (a[i,j]){
            smallcube[i,j].transform.Translate(Vector3.up*1f,Space.World);
        }else{
            smallcube[i,j].transform.Translate(Vector3.down*1f,Space.World);
        }
    }
    void Update()
    {                           
        //this.transform.Rotate(Vector3.up*1,Space.World);        
        this.transform.Translate(Vector3.up*0.1f,Space.World);                
        if (Input.GetKeyDown("0")){
            k+=1;
            if (k==1){                
                i=0;
            }else{                
                j=0;
                change(i,j);
                k=0;
            }
        }
        if (Input.GetKeyDown("1")){
            k+=1;
            if (k==1){
                i=1;
            }else{
                j=1;
                change(i,j);
                k=0;
            }
        }
        if (Input.GetKeyDown("2")){
            k+=1;
            if (k==1){
                i=2;
            }else{
                j=2;
                change(i,j);
                k=0;
            }
        }
        if (Input.GetKeyDown("3")){
            k+=1;
            if (k==1){
                i=3;
            }else{
                j=3;
                change(i,j);
                k=0;
            }
        }
        if (Input.GetKeyDown("4")){
            k+=1;
            if (k==1){
                i=4;
            }else{
                j=4;
                change(i,j);
                k=0;
            }
        }    
        if (Input.GetKeyDown("escape")){
            if (k==1)k-=1;
        }
    }
}
