using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepScript : MonoBehaviour
{
    public GameObject footstep;

    // Start is called before the first frame update
    void Start()
    {
        footstep.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("d"))
        {
            footsteps();
        }

        if(Input.GetKeyDown("a"))
        {
            footsteps();
        }

        if(Input.GetKeyUp("d"))
        {
            StopFootsteps();
        }

        if(Input.GetKeyUp("a"))
        {
            StopFootsteps();
        }
    }

    void footsteps()
    {
        footstep.SetActive(true);
    }

    void StopFootsteps()
    {
        footstep.SetActive(false);
    }


}
