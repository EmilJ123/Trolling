using UnityEngine;

public class Detection : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 10f;
    public float detectionSpeed = 25f;
    public float decaySpeed = 15f;
    public float detectionLevel = 0f;

    public UnityEngine.UI.Image detectionMeter; // UGUI Image with fillAmount

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        bool canSeePlayer = distance < detectionRange;

        if (canSeePlayer)
            detectionLevel += detectionSpeed * Time.deltaTime;
        else
            detectionLevel -= decaySpeed * Time.deltaTime;

        detectionLevel = Mathf.Clamp(detectionLevel, 0f, 100f);
        detectionMeter.fillAmount = detectionLevel / 100f;
    }
}

