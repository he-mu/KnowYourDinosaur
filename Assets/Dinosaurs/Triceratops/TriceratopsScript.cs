using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriceratopsScript : MonoBehaviour
{

    public float movementSpeed = 5.0f;

    // Used to allow only one walk animation at once 
    // because there is movign back to start position phase
    public bool WalkAnimationRunnig = false;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }


    public void CallAnimation(string AnimationName)
    {

        animator.SetTrigger(AnimationName);

        if (AnimationName == "ToWalk" && !WalkAnimationRunnig )
        {
            StartCoroutine(MoveVectorAmmountOverTime(new Vector3(-0.4f, 0f, 0f), 1f));
        }


    }


    IEnumerator MoveVectorAmmountOverTime(Vector3 end, float seconds, bool updateAtEnd = true)
    {
        WalkAnimationRunnig = true;

        float elapsedTime = 0;
        Vector3 startingPos = transform.position;
        Vector3 endPosition = transform.position + end;


        while (elapsedTime < seconds)
        {
            transform.position = Vector3.Lerp(startingPos, endPosition, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        WalkAnimationRunnig = false;

        if (updateAtEnd)
            StartCoroutine(MoveVectorAmmountOverTime(new Vector3(0.4f, 0f, 0f), 4f, false));
    }
}


/*

        if (Input.GetKeyDown(KeyCode.A))
        {

            if (!WalkAnimationRunnig)
            {
                animator.SetTrigger("ToWalk");

                StartCoroutine(MoveVectorAmmountOverTime(new Vector3(-0.4f, 0f, 0f), 1f));
            }

            //transform.position = Vector3.Lerp(startPosition, endPosition, speed * Time.deltaTime);
            //transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("ToCharge");
        }




        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("ToLookUp");
        }





        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("ToLookUpBackDown");
        }




        


        /*IEnumerator MoveOverSpeed(GameObject objectToMove, Vector3 end, float speed)
        {
            // speed should be 1 unit per second
            while (objectToMove.transform.position != end)
            {
                objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, end, speed * Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }
        }*/

        /*IEnumerator MoveOverSeconds(GameObject objectToMove, Vector3 end, float seconds)
        {
            float elapsedTime = 0;
            Vector3 startingPos = objectToMove.transform.position;
            while (elapsedTime < seconds)
            {
                transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            transform.position = end;
        }*/

