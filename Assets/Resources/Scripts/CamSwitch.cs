using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject mainCam; 
    public GameObject cam2;
    public GameObject cam3;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
       mainCam.SetActive(true);
       cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown("c")){
            index++;
            index = index%2;
            if(index==0){
                mainCam.SetActive(true);
                cam2.SetActive(false);
            }
            else{
                cam2.SetActive(true);
                mainCam.SetActive(false);
                //cam2.SetActive(true);
            }
        }
    }
}
