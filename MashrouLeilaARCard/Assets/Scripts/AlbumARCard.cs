using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class AlbumARCard : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject aoede, threeminutes, djin;
    // Start is called before the first frame update
    void Start()
    {
        aoede.SetActive(false);
        threeminutes.SetActive(false);
        djin.SetActive(false);

        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i = 0; i < vrb.Length; i++){
            vrb[i].RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        if(vb.VirtualButtonName == "01-Aoede"){
            aoede.SetActive(true);
            threeminutes.SetActive(false);
            djin.SetActive(false);
        }
        else{
            if(vb.VirtualButtonName == "02-3Minutes"){
             aoede.SetActive(false);
             threeminutes.SetActive(true);
             djin.SetActive(false);
            }
            else{
               if(vb.VirtualButtonName == "03-Djin"){
                 aoede.SetActive(false);
                 threeminutes.SetActive(false);
                 djin.SetActive(true);
             }
            }
            
        }
    }

     public void OnButtonReleased(VirtualButtonBehaviour vb){

    }
}
