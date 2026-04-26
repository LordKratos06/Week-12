using UnityEngine;

enum MyStates
{
    idle,
    walk,
    jump,
    fall
}
public class StateExample : MonoBehaviour
{
    [SerializeField] MyStates myCurrentState;

    float timeJumping = 0;
    float timeFalling = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (myCurrentState)
        {
            case MyStates.idle:
                UpdateIdle();

                break;
            case MyStates.walk:
                UpdateWalk();
                break;
            case MyStates.jump:
                UpdateJump();
                break;
            case MyStates.fall:
                UpdateFall();
                break;
        }
    }

    void UpdateIdle()
    {
        Debug.Log("I'm in Idle right now");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myCurrentState = MyStates.jump;
        }
    }

    void UpdateWalk()
    {
        Debug.Log("Walking");
    }


    void UpdateJump()
    {
        Debug.Log("Wahooooo");

        timeJumping += Time.deltaTime;

        if (timeJumping > 0.5f)
            JumpToFalling();

    }

    void UpdateFall()
    {
        Debug.Log("AAAAAAAAAAaaaaaaa");

        timeFalling += Time.deltaTime;

        if (timeFalling > 1)
        {
            FallToIdle();
        }

    }


    void IdleToJump()
    {
        Debug.Log("switching to jump from idle");
        myCurrentState = MyStates.jump;
    }

    void JumpToFalling()
    {
        Debug.Log("switching to falling from jump");
        myCurrentState = MyStates.fall;
        timeJumping = 0;
    }

    void FallToIdle()
    {
        Debug.Log("Landing");
        myCurrentState = MyStates.idle;
        timeFalling = 0;
    }
}

    


