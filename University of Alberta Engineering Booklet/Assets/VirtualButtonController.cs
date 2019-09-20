using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonController : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject VirtualButton;
    public GameObject Cube;
    public GameObject Cube1;
    private int check = 0;
    
    // Use this for initialization
	void Start () {
        VirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        check = 0;
	}
	
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        check = 1 - check;
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        //
    }

	// Update is called once per frame
	void Update ()
    {
	    if (check == 0)
        {
            Cube.SetActive(true);
            Cube1.SetActive(false);
        }
        else
        {
            Cube1.SetActive(true);
            Cube.SetActive(false);
        }
	}
}
