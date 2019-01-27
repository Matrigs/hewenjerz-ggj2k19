using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

	public SFX[] sounds;

    // Start is called before the first frame update
	void Awake(){
		foreach (SFX s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
		}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
