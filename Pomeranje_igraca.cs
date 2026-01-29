using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Globalization;


public class Pomeranje_igraca : MonoBehaviour
{
    private float vreme = 0f;
    private float rezultat = 0f;
    public float realniRezultat = 1f;
    public float thrustForce = 3f; // Brzina / sila kretanja
    Rigidbody2D rb;
    public UIDocument uiDocument;
    private Label scoreText;
    float v = 0f;
    public GameObject ExplosionEffect;
    private Button restartButton;
    void Start()
    {
        // Uzimamo Rigidbody2D sa objekta i zamrzavamo rotaciju po Z da fizika ne okreće igrača
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        scoreText = uiDocument.rootVisualElement.Q<Label>("ScoreLabel");
        restartButton = uiDocument.rootVisualElement.Q<Button>("RestartButton");
        restartButton.style.display = DisplayStyle.None;
        restartButton.clicked += ReloadScene;
    }

    void FixedUpdate()
    {
        vreme += Time.deltaTime;
        rezultat = vreme * realniRezultat;
        v += Time.deltaTime;

        int minuti = Mathf.FloorToInt(v / 60f);
        float sekunde = v % 60f;

        if (minuti == 0)
        {
            // Samo sekunde (sa dve decimale)
            scoreText.text = "TIME: " + sekunde.ToString("F2");
        }
        else
        {
            // Minuti : sekunde : stotinke
            scoreText.text = "TIME: "
                + minuti + ":"
                + sekunde.ToString("00.00");
        }


        if (Mouse.current.leftButton.isPressed)
        {
            Vector2 misPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector2 direction = (misPos - rb.position).normalized;

            // MovePosition → pomera Rigidbody2D direktno ka poziciji
            rb.MovePosition(rb.position + direction * thrustForce * Time.fixedDeltaTime);

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f; //uzimamo ugao
            rb.rotation = angle;
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Instantiate(ExplosionEffect, transform.position, transform.rotation);
        restartButton.style.display = DisplayStyle.Flex;
    }
    void ReloadScene()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
