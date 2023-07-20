using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public GameObject myparticles;
    public int MyScore;
    float step = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        MyScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float curX = this.transform.position.x;
        curX += step;
        if((curX > 1.5f) || (curX < -1.5f))
        {
            step = -step;
        }
        this.transform.position = new Vector3(curX, this.transform.position.y, this.transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        myparticles = Instantiate(myparticles);
        if (myparticles != null)
            Destroy(myparticles,6);

            
        myparticles.transform.position = this.transform.position;
        MyScore += 1;
        print(MyScore);
    }
}
