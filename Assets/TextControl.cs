using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {                    
        Text text = this.transform.GetComponent<Text>();                
        /*int i,j,k;
        i=GameObject.Find("Cube1").GetComponent<WaveTable>().i; 
        j=GameObject.Find("Cube1").GetComponent<WaveTable>().j; 
        k=GameObject.Find("Cube1").GetComponent<WaveTable>().k;
        i=GameObject.Find("Cube1").GetComponent<WaveTable>().geti();
        text.text=k.ToString()+' '+i.ToString()+' '+j.ToString();
        */
        text.text=GameObject.Find("Cube1").GetComponent<WaveTable>().gett();
    }
}
