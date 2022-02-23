using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    bool isPLaying = false;
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayMusic("MainMusic");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            PlayVideo();
        }
    }

    void PlayVideo() 
    {
        videoPlayer.Play();
        isPLaying = true;
    }

    public void PlayGunOne() 
    {
        AudioManager.instance.Play("GunOne");
    }

    public void PlayGunTwo()
    {
        AudioManager.instance.Play("GunTwo");
    }

    public void KnifeUnsheath() 
    {

        AudioManager.instance.Play("KnifeUnsheath");

    }
    public void KnifeSwing()
    {

        AudioManager.instance.Play("KnifeSwing");

    }
    public void Punch()
    {

        AudioManager.instance.Play("Punch");

    }

    public void Tackle ()
    {

        AudioManager.instance.Play("Punch");

    }

    public void Roll()
    {

        AudioManager.instance.Play("Roll");

    }
    public void Slide()
    {

        AudioManager.instance.Play("Slide");

    }
    public void GlassCrack()
    {

        AudioManager.instance.Play("GlassCrack");

    }
    public void GlassBreak()
    {

        AudioManager.instance.Play("GlassBreak");

    }

    public void StartFootsteps()
    {

        AudioManager.instance.PlayFromStart("FootSteps");

    }
    public void StopFootSteps()
    {

        AudioManager.instance.Pause("FootSteps");

    }
    public void StartYell()
    {

        AudioManager.instance.Play("Yell");

    }
    public void StopYell()
    {

        AudioManager.instance.Pause("Yell");

    }
}
