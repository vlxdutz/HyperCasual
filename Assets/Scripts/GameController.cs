using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textPenalizari;
    public TextMeshProUGUI textCiocniri;
    public int Scor = 0;
    public int Penalizare = 0;
    public int Ciocniri = 0;

    // Start is called before the first frame update
    void Start()
    {
        Scor = 0;
        Penalizare = 0;
        Ciocniri = 0;
    }

    public void BorderTrigger() {
        Ciocniri++;
        textCiocniri.text = $"CIOCNIRI: {Ciocniri}";
    }

     public void InelTrigger() {
        Scor++;
        textScore.text = $"SCOR: {Scor}";
    }

    public void PenalizariTrigger() {
        Penalizare++;
        textPenalizari.text = $"PENALIZARI: {Penalizare}";
    }

    
}
