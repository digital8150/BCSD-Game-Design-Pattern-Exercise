using UnityEngine;
using UnityEngine.UI;
public class StateManager : MonoBehaviour
{
    [SerializeField]
    Text text;

    public void Test(string content)
    {
        text.text = content;
    }
}

