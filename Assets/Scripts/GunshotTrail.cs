using System.Collections;
using UnityEngine;

public class GunshotTrail : MonoBehaviour
{

    private LineRenderer trail;
    private Vector3 origin;
    private Vector3 endPoint;
    public float startWidth = 0.01f;
    public float endWidth = 0.01f;
    public float delay = 0.1f;

    void Start()
    {

        trail = this.gameObject.AddComponent<LineRenderer>();
        trail.startWidth = startWidth;
        trail.endWidth = endWidth;
        //trail.SetColors(Color.red, Color.red);
        


    }

    public void checkTrail()
    {

        origin = this.transform.position + this.transform.forward * 0;

        endPoint = origin + this.transform.forward * 20f;

        trail.SetPosition(0, origin);
        trail.SetPosition(1, endPoint);

        trail.enabled = true;

        StartCoroutine(timedDelay(delay));

    }

    IEnumerator timedDelay(float time)
    {
        yield return new WaitForSeconds(time);

        trail.enabled = false;
    }

}
