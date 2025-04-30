using UnityEngine;

[ExecuteAlways] // Optional: allows it to run in Editor mode
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Real time in seconds it takes for a full in-game day to pass.")]
    [Range(10, 86400)] // From 10 seconds to 24 hours
    public float dayDurationInSeconds = 120f;

    private void Update()
    {
        if (dayDurationInSeconds <= 0) return;

        // Calculate rotation speed
        float degreesPerSecond = 360f / dayDurationInSeconds;

        // Rotate the light around the X axis
        transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime);
    }
}
