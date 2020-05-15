using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbuelaDistance : MonoBehaviour
{
    public GameObject Abuela;
    public GameObject RangeCenter;
    public float Distance_;
    public float maxrangeAbuela = 1.868127f;
    private Vector3 goPosition = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
    Distance_ = Vector3.Distance(Abuela.transform.position, RangeCenter.transform.position);
        Debug.Log(Distance_);
        //Trying to Keep Abuela in Range of RangeCenter but it does nothing, neither am I getting
        // a value for Distance_ in the public inspector(nm I have to hit play to see it)
        // but its still not keeping her in that range
        if (Distance_ > maxrangeAbuela)
        {
            //Distance_ = 1.868127f;
            goPosition.x = maxrangeAbuela;
            goPosition.y = maxrangeAbuela;
            goPosition.z = maxrangeAbuela;

            Abuela.transform.position = RangeCenter.transform.position + goPosition;
        }

    }
}
