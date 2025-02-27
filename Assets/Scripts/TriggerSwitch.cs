using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSwitch : MonoBehaviour
{
    Animator Door;

    // Start is called before the first frame update
    void Start()
    {
        Door = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (IsAnimationPlaying("open") || IsAnimationPlaying("DoorAnimation")))
        {
            Door.SetTrigger("Switch");
        }
    }

    bool IsAnimationPlaying(string animationName)
    {
        var clips = Door.GetCurrentAnimatorClipInfo(0);

        // Check if there are any clips before accessing index 0
        if (clips.Length == 0)
            return false;

        return Door.GetCurrentAnimatorClipInfo(0)[0].clip.name == animationName;
    }
}
