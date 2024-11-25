

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillatorAI : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(1f, 0f, 0f); 
    [SerializeField] float period = 4f;         
    [SerializeField] float detectionRange = 6f; 
    [SerializeField] Transform player;         

    private float movementFactor;              
    private Vector3 startPosition;             
    private bool isOscillating = true;        

    void Start()
    {
        startPosition = transform.position;    
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("Player Transform is not assigned!");
            return;
        }

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer < detectionRange)
        {
            period = Mathf.Max(2f, period - Time.deltaTime); 
        }
        else
        {
            period = Mathf.Min(4f, period + Time.deltaTime); 
        }

        Oscillate();
    }

     void Oscillate()
    {
        if (period <= Mathf.Epsilon)
        {
            Debug.LogWarning("Period is too small! Oscillation will not occur.");
            return;
        }

        float cycles = Time.time / period;         
        const float tau = Mathf.PI * 2;           
        float rawSinWave = Mathf.Sin(cycles * tau); 

        movementFactor = (rawSinWave + 1f) / 2f;  

        Vector3 offset = movementVector * movementFactor; 
        transform.position = startPosition + offset;    
          
    }
}
