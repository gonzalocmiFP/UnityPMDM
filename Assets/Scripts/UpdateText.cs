using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateText : MonoBehaviour
{
    public int playerIndex;
    private TMP_Text m_Text;

    // Start is called before the first frame update
    void Start()
    {
        m_Text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Text.text = GameManager.instance.points[playerIndex].ToString();
    }
}
