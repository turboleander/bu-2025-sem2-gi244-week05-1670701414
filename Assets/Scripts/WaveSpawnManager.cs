using UnityEngine;

public class WaveSpawnManager : MonoBehaviour
{
    public Wave[] wavesConfigs;
    public WaveController waveController;

    private int currentWaveIndex = 0;
    private float waveEndTime = 0;

    void Start()
    {
        waveController.ChangeWave(wavesConfigs[0]);
    }

    void Update()
    {
        if (waveController.IsCompleted())
        {
            currentWaveIndex++;
            if (currentWaveIndex < wavesConfigs.Length)
            {
                waveController.ChangeWave(wavesConfigs[currentWaveIndex]);
            }
            else
            {
                Debug.Log($"All Done");
            }
        }
    }
}