using UnityEngine;

public class SafetyFlowManager : MonoBehaviour
{
    public GameObject seatbelt;
    public GameObject lifeVest;

    public Animator seatbeltAnimator;
    public Animator lifeVestPinAnimator;
    public Animator lifeVestInflationAnimator;

    private int seatbeltLoopCount = 0;
    private int lifeVestCycleCount = 0;

    void Start()
    {
        StartSeatbeltSequence();
    }

    void StartSeatbeltSequence()
    {
        // Activate Seatbelt, Deactivate Life Vest
        seatbelt.SetActive(true);
        lifeVest.SetActive(false);

        seatbeltLoopCount = 0;
        TriggerSeatbeltAnimation();
    }

    void TriggerSeatbeltAnimation()
    {
        seatbeltAnimator.SetTrigger("TriggerSeatbelt");
        seatbeltLoopCount++;

        if (seatbeltLoopCount < 5)
        {
            Invoke(nameof(TriggerSeatbeltAnimation), 2f); // Adjust timing to match animation length
        }
        else
        {
            Invoke(nameof(StartLifeVestSequence), 2f); // 2-second delay before life vest
        }
    }

    void StartLifeVestSequence()
    {
        // Activate Life Vest, Deactivate Seatbelt
        seatbelt.SetActive(false);
        lifeVest.SetActive(true);

        lifeVestCycleCount = 0;
        TriggerLifeVestCycle();
    }

    void TriggerLifeVestCycle()
    {
        if (lifeVestCycleCount < 3)
        {
            // Play Pin Pull Animation
            lifeVestPinAnimator.SetTrigger("TriggerPinPull");
            Invoke(nameof(TriggerLifeVestInflation), 1f); // Wait 1 second for inflation animation
        }
        else
        {
            Invoke(nameof(StartSeatbeltSequence), 2f); // Restart sequence after life vest
        }
    }

    void TriggerLifeVestInflation()
    {
        // Play Inflation Animation
        lifeVestInflationAnimator.SetTrigger("TriggerInflation");
        lifeVestCycleCount++;

        if (lifeVestCycleCount < 3)
        {
            Invoke(nameof(TriggerLifeVestCycle), 2f); // Wait 2 seconds before the next cycle
        }
        else
        {
            Invoke(nameof(StartSeatbeltSequence), 2f); // Restart sequence after life vest
        }
    }
}