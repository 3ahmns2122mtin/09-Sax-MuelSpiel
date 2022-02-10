using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGarbage : MonoBehaviour
{
    public GameObject parentOfGarbage;
    public GameObject Garbage;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn", 1f, 2f);


    }
    private void Spawn()
    {
        float randomX = Random.Range(-370, 370);
        float randomY = Random.Range(-197, 197);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myTarget = Instantiate(Garbage, parentOfGarbage.transform);
        myTarget.transform.localPosition = random2DPosition;

    }
    void OnTriggerEnter(Collider TheColliderThatIWillBeCollidingWith)
    {
        if (transform.tag == "Garbage")
        {
            Destroy(TheColliderThatIWillBeCollidingWith.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
