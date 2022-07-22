using System.Collections;
using UnityEngine;
using UnityEditor;

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
        string[] materials = { "materials" };
        trail.material = (Material) AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(AssetDatabase.FindAssets("black")[0]), typeof(Material));
        trail.startColor = Color.black;
        trail.endColor = Color.black;

    }

    public void checkTrail(float dist)
    {

        //Debug.Log("After");

        origin = this.transform.position + this.transform.forward * 0f;

        endPoint = origin + this.transform.forward * dist;

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
