using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHandler : MonoBehaviour
{

    public GameObject Leaf1;
    public GameObject Leaf2;
    public GameObject Leaf3;
    public GameObject Leaf4;

    private bool LeafAnimationRunning = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!LeafAnimationRunning)
        {
            //StartCoroutine(RunLeafAnimations(6.0f));
        }
    }




    IEnumerator RunLeafAnimations(float time)
    {
        LeafAnimationRunning = true;

        Leaf1.GetComponent<Animator>().SetTrigger("RunIdle1");
        yield return new WaitForSeconds(0.4f);

        Leaf2.GetComponent<Animator>().SetTrigger("RunIdle1");

        yield return new WaitForSeconds(0.4f);

        Leaf3.GetComponent<Animator>().SetTrigger("RunIdle1");
        yield return new WaitForSeconds(0.4f);

        Leaf4.GetComponent<Animator>().SetTrigger("RunIdle1");

        yield return new WaitForSeconds(time);

        LeafAnimationRunning = false;

        // Code to execute after the delay
    }

}
