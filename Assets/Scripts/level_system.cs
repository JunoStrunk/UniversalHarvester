using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_system : MonoBehaviour
{
    public int level;
    public float current_xp;
    public float required_xp;

    private float lerp_timer;
    private float delay_timer;
    [Header("UI")]
    public Image back_xp_bar;
    public Image front_xp_bar;
    [Range(1f,300f)]
    public float addition_multiplier = 300;
    [Range(2f,4f)]
    public float power_multiplier = 2;
    [Range(7f,14f)]
    public float division_multiplier = 7;

    void Start()
    {
        front_xp_bar.fillAmount = current_xp / required_xp;
        back_xp_bar.fillAmount = current_xp / required_xp;
    }

    void Update()
    {
        UpdateXpUI();
        if(Input.GetKeyDown(KeyCode.E))
        {
            GainExperienceFlatRate(20f);
        }
        if (current_xp >= required_xp)
            {
            level_up();
            }
    }

    public void UpdateXpUI()
    {
        float xp_fraction = current_xp / required_xp;
        if(front_xp_bar.fillAmount < xp_fraction)
        {
            delay_timer += Time.deltaTime;
            float percent_complete = lerp_timer / 4;
            front_xp_bar.fillAmount = Mathf.Lerp(front_xp_bar.fillAmount, back_xp_bar.fillAmount, percent_complete);

        }
    }

    public void GainExperienceFlatRate(float xpGained)
    {
        current_xp += xpGained;
        lerp_timer = 0f;
        delay_timer = 0f;
    }

    public void level_up()
    {
        level++;
        front_xp_bar.fillAmount = 0;
        back_xp_bar.fillAmount = 0;
        current_xp = Mathf.RoundToInt(current_xp - required_xp);
        required_xp = CalculateRequiredXp();
    }

    private int CalculateRequiredXp()
    {
        int solve_required_xp = 0;
        for (int levelCycle = 1; levelCycle <= level; levelCycle++)
        {
            solve_required_xp += (int)Mathf.Floor(levelCycle + addition_multiplier * Mathf.Pow(power_multiplier, levelCycle / division_multiplier));
        }
        return solve_required_xp / 4;
    }

}
