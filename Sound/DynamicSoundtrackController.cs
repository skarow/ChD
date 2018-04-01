using UnityEngine;
using System.Collections;

[System.Serializable]
public enum SoundDefaults
{
	IntensityLevel1,IntensityLevel2,Silence
}

public class DynamicSoundtrackController : MonoBehaviour 
{

    public AudioClip playerWinClip;
	public AudioClip[] intensity1Sound;
	public AudioClip[] intensity2Sound;

	public float fadeSpeed = 0.05f;
	public bool autoPlay = true;
	public SoundDefaults startClip = SoundDefaults.IntensityLevel1;

	private AudioSource source1;
	private AudioSource source2;

	private float volume1 = 0;
	private float volume2 = 0;

	private float destVolume1 = 0;
	private float destVolume2 = 0;

    private int currentIntensity;

	[HideInInspector]
	public float volumeModifier = 1;
	[HideInInspector]
	public bool mute = false;

	private int muteModifier = 1;

	// Use this for initialization
	void Start () 
	{
		source1 = gameObject.AddComponent<AudioSource>();
		source2 = gameObject.AddComponent<AudioSource>();

		source1.loop = true;
		source2.loop = true;

		source1.volume = 0;
		source2.volume = 0;

        currentIntensity = -1;

		if (intensity1Sound == null) Debug.Log ("INFINITRACKS: Please specify a sound for intensity level 1!");
		if (intensity2Sound == null) Debug.Log ("INFINITRACKS: Please specify a sound for intensity level 2!");

        int clipNo = Random.Range(0, intensity1Sound.Length);
		source1.clip = intensity1Sound[clipNo];
        clipNo = Random.Range(0, intensity2Sound.Length);
        source2.clip = intensity2Sound[clipNo];

		if (autoPlay)
		{
			if (startClip == SoundDefaults.IntensityLevel1)
				StartSoundtrack(1);
            if (startClip == SoundDefaults.IntensityLevel2)
                StartSoundtrack(2);
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		if (mute) 
			muteModifier = 0;
		else
			muteModifier = 1;

		volume1 += (destVolume1 - volume1) * fadeSpeed;
		volume2 += (destVolume2 - volume2) * fadeSpeed;

		source1.volume = volume1 * volumeModifier * muteModifier;
		source2.volume = volume2 * volumeModifier * muteModifier;

	}

	public void SetVolume(float v)
	{
		if (v < 0) v = 0;
		if (v > 1) v = 1;

		volumeModifier = v;
	}

	public void SetMute(bool m)
	{
		mute = m;
	}

	public void StartSoundtrack(int intensity)
	{
		source1.Stop ();
		source2.Stop ();
		volume1 = 0;
		volume2 = 0;
		destVolume1 = 0;
		destVolume2 = 0;
		SetIntensity (intensity);
	}

	public void StopSoundtrack()
	{
		source1.Stop ();
		source2.Stop ();
	}

	public void SetIntensity(int intensity)
	{
        if (currentIntensity == intensity)
            return;

        if (intensity == 1 || intensity == 4)
		{
            if (currentIntensity == 1 || currentIntensity == 4) return;
            if (intensity == 1)
            {
                int clipNo = Random.Range(0, intensity1Sound.Length);
                source1.clip = intensity1Sound[clipNo];
                currentIntensity = 1;
            }
            else // player win
            {
                source1.clip = playerWinClip;
                currentIntensity = 4;
            }
            source1.Stop();
            source1.Play();

            destVolume1 = 1;
			destVolume2 = 0;
		}
		else if (intensity == 2)
		{
            source2.Stop();
            int clipNo = Random.Range(0, intensity2Sound.Length);
            source2.clip = intensity2Sound[clipNo];
            source2.Play();
            currentIntensity = 2;

            destVolume1 = 0;
			destVolume2 = 1;
		}
		else if (intensity == 3)
		{
			destVolume1 = 0;
			destVolume2 = 0;
            currentIntensity = 3;
		}
		else
		{
			destVolume1 = 0;
			destVolume2 = 0;
            currentIntensity = -1;
		}
	}

}
