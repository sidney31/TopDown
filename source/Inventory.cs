using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    [SerializeField] private TMP_Text MushroomCountText;
    [SerializeField] public int MushroomCount;
    [SerializeField] private TMP_Text Stone�ountText;
    [SerializeField] public int Stone�ount;

    private void Update()
    {
        MushroomCountText.text = MushroomCount.ToString();
        Stone�ountText.text = Stone�ount.ToString();
    }

    private void trade()
    {
        // if (MushroomCount > 5 && Stone�ount > 5) { tradeaga }
    }
}
