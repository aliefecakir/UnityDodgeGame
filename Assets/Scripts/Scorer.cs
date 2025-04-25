using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
        hits +=1;
        Debug.Log("You hit " + hits + " times!");
        }
    }
}
