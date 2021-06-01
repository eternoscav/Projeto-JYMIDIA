using UnityEngine;
using System.Collections;

/// <summary>
/// This sample demonstrates some of the supported one-finger gestures:
/// - LongPress
/// - Tap
/// - Drag
/// - Swipe
/// </summary>
public class OneFingerGestureSample : SampleBase
{
	#region Properties exposed to the editor
	
		//public GameObject longPressObject;
		public AudioClip Selecionar;
		public AudioClip Selecionado;
		public _Parallax ParalaxConfig;
		public SwipeMotions ligarGame;
		public GameObject selectPlayer;
		public GameObject tapObject1;
		public GameObject tapObject2;
		public GameObject tapObject3;
//		public GameObject doubleTapObject1;
//		public GameObject doubleTapObject2;
//		public GameObject doubleTapObject3;
		//    public GameObject swipeObject;
		//    public GameObject dragObject;
		public Rotation2 Rotation01;
		public Rotation2 Rotation02;
		public Rotation2 Rotation03;
		public TrocaCor troca01;
		public TrocaCor troca02;
		public TrocaCor troca03;
	
	#endregion
	
	#region Misc
	
		protected override string GetHelpText ()
		{
				return @"This sample demonstrates some of the supported single-finger gestures:

- Drag: press the red sphere and move your finger to drag it around  

- LongPress: keep your finger pressed on the cyan sphere for at least " + FingerGestures.Defaults.Fingers [0].LongPress.Duration + @" seconds

- Tap: press & release the purple sphere 

- Double Tap: quickly press & release the green sphere twice in a row

- Swipe: press the yellow sphere and move your finger in one of the four cardinal directions, then release. The speed of the motion is taken into account.";
		}
	
	#endregion
	
	#region Gesture event registration/unregistration
	
		void OnEnable ()
		{
//				Debug.Log ("Registering finger gesture events from C# script");
		
				// register input events
				FingerGestures.OnFingerTap += FingerGestures_OnFingerTap1;
				FingerGestures.OnFingerTap += FingerGestures_OnFingerTap2;
				FingerGestures.OnFingerTap += FingerGestures_OnFingerTap3;

		}
	
		void OnDisable ()
		{

				FingerGestures.OnFingerTap -= FingerGestures_OnFingerTap1;
				FingerGestures.OnFingerTap -= FingerGestures_OnFingerTap2;
				FingerGestures.OnFingerTap -= FingerGestures_OnFingerTap3;

		}
	

	
		void FingerGestures_OnFingerTap1 (int fingerIndex, Vector2 fingerPos)
		{
				if (CheckSpawnParticles (fingerPos, tapObject1)) {
						audio.PlayOneShot (Selecionar);
						troca01.PlayerGirl = true;
						troca01.Ligado = true; 
						troca02.Ligado = false;
						troca03.Ligado = false;
						ligarGame.AnimacaoGirl = true;
						StartCoroutine (StartGirl ());	
				}
		}
	
		void FingerGestures_OnFingerTap2 (int fingerIndex, Vector2 fingerPos)
		{
				if (CheckSpawnParticles (fingerPos, tapObject2)) {
						audio.PlayOneShot (Selecionar);
						troca02.PlayerSpecial = true;
						troca01.Ligado = false; 
						troca02.Ligado = true;
						troca03.Ligado = false;
//						ligarGame.AnimacaoBoy = true;
//						StartCoroutine (StartBoy ());
				}
		}
	
		void FingerGestures_OnFingerTap3 (int fingerIndex, Vector2 fingerPos)
		{
				if (CheckSpawnParticles (fingerPos, tapObject3)) {
			audio.PlayOneShot (Selecionar);
			troca03.PlayerBoy = true;
			troca01.Ligado = false; 
			troca02.Ligado = false;
			troca03.Ligado = true;
			ligarGame.AnimacaoBoy = true;
			StartCoroutine (StartBoy ());
				}
		}
	


	public IEnumerator StartGirl ()
	{
		yield return new WaitForSeconds (1f);
		ligarGame.AudioFase();
		ParalaxConfig.baseSpeed = 3;
		ligarGame.LigarGame = true;
		selectPlayer.SetActive (false);
		gamestate.Instance.PlayerGirl = true;
		gamestate.Instance.PlayerBoy = false;
		gamestate.Instance.PlayerSpecial = false;

	}

	public IEnumerator StartSpecial ()
	{
		yield return new WaitForSeconds (1f);
		ligarGame.AudioFase();
		ParalaxConfig.baseSpeed = 3;
		ligarGame.LigarGame = true;
		selectPlayer.SetActive (false);
		gamestate.Instance.PlayerSpecial = true;
		gamestate.Instance.PlayerGirl = false;
		gamestate.Instance.PlayerBoy = false;


	}

	public IEnumerator StartBoy ()
	{
		yield return new WaitForSeconds (1f);
		ligarGame.AudioFase();
		ParalaxConfig.baseSpeed = 3;
		selectPlayer.SetActive (false);
		ligarGame.LigarGame = true;
		gamestate.Instance.PlayerBoy = true;
		gamestate.Instance.PlayerGirl = false;
		gamestate.Instance.PlayerSpecial = false;

		}



		bool CheckSpawnParticles (Vector2 fingerPos, GameObject requiredObject)
		{
				GameObject selection = PickObject (fingerPos);
		
				if (!selection || selection != requiredObject)
						return false;
		
				SpawnParticles (selection);
				return true;
		}
	
		void SpawnParticles (GameObject obj)
		{
				ParticleEmitter emitter = obj.GetComponentInChildren<ParticleEmitter> ();
				if (emitter)
						emitter.Emit ();
		}
	
	#endregion
}
