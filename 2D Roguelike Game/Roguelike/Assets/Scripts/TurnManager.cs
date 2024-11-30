using UnityEngine;
using System;

public class TurnManager
{
    private int m_TurnCount;

    // Event to notify when a turn happens
    public event Action OnTick;

    public TurnManager()
    {
        m_TurnCount = 1;
    }

    public void Tick()
    {
        m_TurnCount += 1;
        Debug.Log("Current turn count: " + m_TurnCount);

        // Invoke the OnTick event to notify subscribers
        OnTick?.Invoke();
    }
}