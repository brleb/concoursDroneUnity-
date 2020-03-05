using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public GameObject market;
    

    RectTransform rt;

    // Start is called before the first frame update
    void Start()
    {

        rt = GetComponent<RectTransform>();
        DisplayWorldCorners();

    }

    void DisplayWorldCorners()
    {
        Vector3[] v = new Vector3[4];
        rt.GetWorldCorners(v);

        Debug.Log("World Corners");
        for (var i = 0; i < 4; i++)
        {
            Debug.Log("World Corner " + i + " : " + v[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {


        //Debug.Log(market.transform.lossyScale);
        //Debug.Log(upLeftCorner);











    }
}

