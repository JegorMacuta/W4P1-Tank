using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed=20.0f;
    public float speedTurn=20.0f;

    // Update is called once per frame
    void Update()
    {

        float throttle=Input.GetAxis("Vertical");
        float movement=throttle*speed*Time.deltaTime;

        float steering=Input.GetAxis("Horizontal");
        float turn=steering*speedTurn*Time.deltaTime;

        Transform t=gameObject.transform;
        t.Translate(0.0f,0.0f,-movement);
        t.Rotate(0.0f,turn,0.0f);
        
        Debug.Log("steering"+steering);
        Debug.Log("speed"+speedTurn);
        Debug.Log("turn"+turn);
    }
}
