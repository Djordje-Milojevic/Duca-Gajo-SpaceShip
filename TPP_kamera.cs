using UnityEngine;
public class TPP_kamera : MonoBehaviour
{
    public GameObject Player;
    private Vector3 pomeraj;
    void Start()
    {
        pomeraj = transform.position - Player.transform.position;
    }
    void LateUpdate()
    {
        transform.position = Player.transform.position + pomeraj; //prati igraca za njegovo pomeranje, i ne okrece se zbog ovog pomeraja
    }
}