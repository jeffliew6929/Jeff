using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image HealthBar;
    public float MaxHealth = 100f;
    public float CurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        HealthBar = this.GetComponent<Image>();
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}