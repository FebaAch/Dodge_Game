using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("You have bumped " + hits +" times");
    }
}
