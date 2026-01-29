using UnityEngine;

public class Prepreke : MonoBehaviour
{

    public float Min_Size = 0.5f;
    public float Max_Size = 2.0f;
    public float Min_Speed = 50f;
    public float Max_Speed = 150f;
    Rigidbody2D rb;


    void Start()
    {
        float randomSize = Random.Range(Min_Size, Max_Size);// komponenta za random velicinu
        transform.localScale = new Vector3(randomSize, randomSize, 1); // random velicinu
        rb = GetComponent<Rigidbody2D>(); // komponenta za random brzinu
        float randomSpeed = Random.Range(Min_Speed, Max_Speed); // random brzina
        Vector2 randomDirection = Random.insideUnitCircle; //komponenta za random stranu
        rb.AddForce(randomDirection * randomSpeed); // random strana
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
