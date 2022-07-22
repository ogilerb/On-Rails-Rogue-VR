using UnityEngine;

public class EnemyLife : MonoBehaviour
{


    public void Kill(string name)
    {
        Debug.Log(name);
        GameObject.Find(name).SetActive(false);

    }
}
