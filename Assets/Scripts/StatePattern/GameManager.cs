using UnityEngine;

public class GameManager : SingleTone<GameManager>
{
    public StateContext context;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            context.Operate();
        }
    }
}
