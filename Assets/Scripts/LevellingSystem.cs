using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    public int curretLevel; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXpThreshold = 10; // The amount of xp required to level up.

    private void Start()
    {
        // set our current level to one.
        int currentLevel = 1;

        // set our current XP to zero
        int currentXp = 0;

        // set our current XP Threshold to be our level multiplied by our 100.
        int currentXpThreshold = (currentLevel * 100);

        // Debug out our starting values of our level, xp and current xp threshold
        Debug.Log("Current level = " + currentLevel);
        Debug.Log("Current XP = " + currentXp);
        Debug.Log("Current XP threshold = " + currentXpThreshold);

        // Increase the current XP by one hundred.
        int xpGain = (currentXp + 100);

        // Debug out our current XP.
        Debug.Log("You gained 100XP, your current XP is now = " + xpGain);

        // check if our current XP is more than our threshold.
        if (xpGain > currentXp)
        {
            Debug.Log("Level up!");
        }
        // if it is, then let's increase out level by one.
        if (currentXpThreshold > currentXp)
        {
            currentLevel = (currentLevel + 1);
        }
        // let's also increase recalculate our current xp threshold as we've levelled up.
        currentXpThreshold = (currentLevel * 100);

        // Debug out our new level value, as well as our current XP and our next Threshold we need to hit.
        Debug.Log("Your level is now = " + currentLevel);
        Debug.Log("Current XP is now - " + currentXp);
        Debug.Log("Current XP threshold is now = " + currentXpThreshold);

    }
}
