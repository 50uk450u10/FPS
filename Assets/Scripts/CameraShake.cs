using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    //variables
    [SerializeField] float amplitude = 1;
    [SerializeField] float frequency = 0.3f;

    //private variables
    CinemachineBasicMultiChannelPerlin camShake;

    private void Start()
    {
        camShake = GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    private void FixedUpdate()
    {
        camShake.m_AmplitudeGain = camShake.m_AmplitudeGain > 0 ? camShake.m_AmplitudeGain -= 0.1f : 0;
        camShake.m_FrequencyGain = camShake.m_FrequencyGain > 0 ? camShake.m_FrequencyGain -= 0.1f : 0;
    }

    //functions
    [ContextMenu("Thug Shaker Central")]
    public void applyScreenShake()
    {
        camShake.m_AmplitudeGain = amplitude;
        camShake.m_FrequencyGain = frequency;
    }
}
