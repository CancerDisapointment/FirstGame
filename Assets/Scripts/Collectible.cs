using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public ScoreManager ScoreManagerRef; 
    // Start is called before the first frame update
    void Start()
    {
        ScoreManagerRef = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.gameObject.GetComponent<PlayerMovement>();

        if (player != null)
        {
            ScoreManagerRef.Increment();
            Destroy(this.gameObject);
        }
    }
}
