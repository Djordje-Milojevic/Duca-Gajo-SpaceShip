using UnityEngine;
public class FPP_kamera : MonoBehaviour
{
    public GameObject Player;
    private Vector3 pomeraj;
    void Start()
    {
        pomeraj = transform.position - Player.transform.position;
    }
    void LateUpdate()
    {
        transform.position = Player.transform.position + pomeraj;
    }
}