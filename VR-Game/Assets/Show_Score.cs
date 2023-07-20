using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Score : MonoBehaviour
{
    private GameObject targ;
    // Start is called before the first frame update
    void Start()
    {
        targ = GameObject.Find("Target");        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject curparticles = GameObject.Find("Flare(Clone)");
        
        score scp = targ.GetComponent<score>();
        int sco = scp.MyScore;
        this.GetComponent<TextMesh>().text = sco.ToString();
    }
}
