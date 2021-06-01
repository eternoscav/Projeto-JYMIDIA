using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))] 

public class SwipeMotions : MonoBehaviour
{
		public GameObject ApplesGeral;
		public GameObject MonstersGeral;
		public GameObject Portal;
		public FundoMorte fundo1;
		public FundoMorte fundo2;
		public GameObject FundoMorte;
		public GameObject FundoMorte2;
		public GameObject AutoTrigger;
		public GameObject FundoInstrucao;
		public GameObject FingerDown;
		public GameObject FingerUp;
		public GameObject FingerRight;
		public GameObject menuPause;
		public GameObject menuObjeto;
		public GameObject Interface;
		public GameObject spawnPersonagem;
		public GameObject Plat;
		public GameObject spawnPlat;
		public GameObject Fumaca;
		public GameObject PortaFinal;
		public GameObject ColisorFinal;
		public GameObject spawnBullet;
		public GameObject Particulas;
		public GameObject Controls;
		public GameObject PartBatida;
		public GameObject StopSpawnColisor;
		public GameObject Sangue;
		public GameObject LigarFogo;
		public GameObject PlayerGirl;
		public GameObject PlayerSpecial;
		public GameObject PlayerBoy;
		public GameObject AudioBotao;
		public GameObject AudioBotao2;
		public GameObject Pause;
		public float speed = 6.0f;
		public float jumpSpeed = 8.0f;
		public float gravity = 20.0f;
		public float PersonSpeed = 20;
		public float minSwipeDistY;
		public float minSwipeDistX;
		public bool LigarAudio;
		public bool LigarSlide;
		public bool LigarBotao;
		public bool AnimacaoGirl;
		public bool AnimacaoBoy;
		public bool ParallaxConfig;
		public bool ComFrutas;
		private bool grounded = false;
		public bool JumpLigado = false;
		public bool PowerLigado = false;
		public bool SlideTrue = false;
		public bool ligar = false;
		public bool TouchLigar = false;
		public bool AnimarLigado = false;
		public bool SlideLiga = false;
		public bool testeShrink = false;
		public bool ligarRunning = true;
		public bool Correr = true;
		public bool ShrinkLigar = true;
		public bool Magia1;
		public bool LigarFumaca;
		public bool LigarGame;
		public bool DesligarInstrucao;
		public int Apples;
		public int Crystals;
		private int Vidas = 5 ;
		public GUIText Swipe;
		public GUIText VidaGuiBranco;
		public GUIText VidaGuiPreto;
		public GUIText AppleGUIBranco;
		public GUIText AppleGUIPreto;
		public GUIText ApplesFra;
		private Vector3 moveDirection = Vector3.zero;
		private Vector2 startPos;
		public PlataformMoviment plataform;
		public _Parallax parallax;
		public LimitScreen2D limit2d;
		public AudioClip ChinaWall;
		public AudioClip Pulo;
		public AudioClip Pulo2;
		public AudioClip ChinaWall2;
		public AudioClip Power;
		public AudioClip Power2;
		public AudioClip SoundApples;
		public AudioClip Vitoria;
		public AudioClip Vitoria2;
		public AudioClip Derrota;
		public AudioClip Derrota2;
		public AudioClip crystalSound;
		public AudioClip SlideAudio;
		public CharacterController controle;
		public BulletRed bulletred;
		public PortalMagnet Fruta01;
		public PortalMagnet Fruta02;
		public PortalMagnet Fruta03;
		public PortalMagnet Fruta04;
		public PortalMagnet Fruta05;
		public PortalMagnet Fruta06;
		public PortalMagnet Fruta07;
		public PortalMagnet Fruta08;
		public PortalMagnet Fruta09;
		public PortalMagnet Fruta10;
		public TrocaRoupa cat;
		public BulletRed bulletpink;
		public TorraApple fruta01;
		public TorraApple fruta02;
		public TorraApple fruta03;
		public TorraApple fruta04;
		public TorraApple fruta05;
		public TorraApple fruta06;
		public TorraApple fruta07;
		public TorraApple fruta08;
		public TorraApple fruta09;
		public TorraApple fruta10;
		public TrocaFace face;
		public AnimarPortal animarportal;
		public MenuPrincipal menu;
		public float minMovement = 20.0f;
		private Vector2 StartPos;
		private int SwipeID = -1;
		public bool sendUpMessage = true;
		public bool sendDownMessage = true;
		public bool sendLeftMessage = true;
		public bool sendRightMessage = true;
		public GameObject MessageTarget = null;
		public bool pauseEnabled = true;
		public bool Pausar;
		public bool TimeController = false;
		public Opcoes opcoes;
//		public Instrucao instruction;

		public void Start ()
		{
				audio.PlayOneShot (ChinaWall);
				//Manter a Luz da tela Ligaada.
				Screen.sleepTimeout = SleepTimeout.NeverSleep;
		}

		IEnumerator ControlsTime ()
		{
				TimeController = true;
				yield return new WaitForSeconds (0.6f);
				ShrinkLigar = true;
				TimeController = false;
		}

		IEnumerator ControlsShrink ()
		{
				TimeController = true;
				ShrinkLigar = false;
				yield return new WaitForSeconds (0.5f);
				ShrinkLigar = true;
				TimeController = false;

		}

		IEnumerator ControlsPowerTime ()
		{
				TimeController = true;
				yield return new WaitForSeconds (0.3f);
				TimeController = false;
		}

		void Update ()
		{

				if (LigarBotao == false && LigarSlide == true) {
						if (TouchLigar == true) {
								if (TimeController == false) {
										if (MessageTarget == null)
												MessageTarget = gameObject;
										foreach (var T in Input.touches) {
												var P = T.position;
												if (T.phase == TouchPhase.Began && SwipeID == -1) {
														SwipeID = T.fingerId;
														StartPos = P;
												} else if (T.fingerId == SwipeID) {
														var delta = P - StartPos;
														if (T.phase == TouchPhase.Moved && delta.magnitude > minMovement) {
																SwipeID = -1;
																if (Mathf.Abs (delta.x) > Mathf.Abs (delta.y)) {
																		if (sendRightMessage && delta.x > 0)
																				MagiaRed ();
							//Swipe.text = "ARRASTA PARA DIREITA";
						//	Teste1.SetActive (false);
						//MessageTarget.SendMessage("OnSwipeRight", SendMessageOptions.DontRequireReceiver);
						else if (sendLeftMessage && delta.x < 0)
																				Swipe.text = "ARRASTA PARA ESQUERDA";
																		//	Teste2.SetActive (false);
																		//MessageTarget.SendMessage("OnSwipeLeft", SendMessageOptions.DontRequireReceiver);
																} else {
																		if (sendUpMessage && delta.y > 0)
																				Jump ();
							//Swipe.text = "ARRASTA PARA CIMA";
						//	Teste3.SetActive (false);
						//MessageTarget.SendMessage("OnSwipeUp", SendMessageOptions.DontRequireReceiver);
						else if (sendDownMessage && delta.y < 0)
																				Shrink ();
																		//MessageTarget.SendMessage("OnSwipeDown", SendMessageOptions.DontRequireReceiver);
																		//	Teste4.SetActive (false);
																		//Swipe.text = "ARRASTA PARA BAIXO";
																}
														} else if (T.phase == TouchPhase.Canceled || T.phase == TouchPhase.Ended) {
																SwipeID = -1;
																MessageTarget.SendMessage ("OnTap", SendMessageOptions.DontRequireReceiver);
														}
												}
										}
								}
						}
				}
				if (pauseEnabled == true && Pausar == false) {
						Controls.SetActive (true);
						pauseEnabled = false;
						Time.timeScale = 1;
						AudioListener.volume = 1;
						//Plat.SetActive (true);
						//Screen.showCursor = false;			
				}
				if (pauseEnabled == false && Pausar == true) {
						Controls.SetActive (false);
						pauseEnabled = true;
						AudioListener.volume = 0;
						Time.timeScale = 0;
						//Plat.SetActive (false);
						//Screen.showCursor = true; 
				}
				if (ParallaxConfig == true) {
						parallax.baseSpeed = 3;
				}
				if (LigarGame == true) {
			
			
						menu.enabled = false;
						
						plataform.enabled = true;
						if (gamestate.Instance.PlayerGirl == true) {
								PlayerGirl.SetActive (true);
								PlayerBoy.SetActive (false);
								PlayerSpecial.SetActive (false);
				
						}
						if (gamestate.Instance.PlayerSpecial == true) {
								PlayerGirl.SetActive (false);
								PlayerSpecial.SetActive (true);
								PlayerBoy.SetActive (false);
				
				
						}
						if (gamestate.Instance.PlayerBoy == true) {
								PlayerBoy.SetActive (true);
								PlayerGirl.SetActive (false);
								PlayerSpecial.SetActive (false);
				
						}
						VidaGuiPreto.text = Vidas.ToString ();
						VidaGuiBranco.text = Vidas.ToString ();
			
						if (SlideLiga == true) {
								Shrink ();
						}
			

						if (AnimarLigado == true) {
				
								transform.Translate (Vector3.forward * Time.deltaTime * PersonSpeed);
						}
				}
		}

		public void MagiaRed ()
		{

				if (Apples >= 1) {
						StartCoroutine (ControlsPowerTime ());
						Swipe.text = "ARRASTA PARA DIREITA";
						if (AnimacaoGirl == true) {
								if (Magia1 == true) {
										Instantiate (bulletred.gameObject, spawnBullet.transform.position, Quaternion.identity);
										audio.PlayOneShot (Power);
								}
								if (Magia1 == false) {
										Instantiate (bulletpink.gameObject, spawnBullet.transform.position, Quaternion.identity);
										audio.PlayOneShot (Power);
								}
								//audio.PlayOneShot (Derrota);
						}
						if (AnimacaoBoy == true) {
								if (Magia1 == true) {
										Instantiate (bulletred.gameObject, spawnBullet.transform.position, Quaternion.identity);
										audio.PlayOneShot (Power2);
								}
								if (Magia1 == false) {
										Instantiate (bulletpink.gameObject, spawnBullet.transform.position, Quaternion.identity);
										audio.PlayOneShot (Power2);
								}
								//audio.PlayOneShot (Derrota);
						}
				}
		}
//				if (Apples >= 50)
//						ComFrutas = false;
//		}

		void FixedUpdate ()
		{
				if (LigarGame == true) {


						if (Input.GetKeyDown (KeyCode.P)) {
								if (TimeController == false) {
										MagiaRed ();
								}

						}


						if (Input.GetButton ("Morte"))
								Morte ();


						if (grounded) {
								// We are grounded, so recalculate movedirection directly from axes
								moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
								moveDirection = transform.TransformDirection (moveDirection);
								moveDirection *= speed;
								if (Input.GetButton ("Jump"))
								if (TimeController == false) {
										Jump ();
								}
								if (Input.GetButton ("Slide"))
								if (TimeController == false) {
										Shrink ();
								}

						}
						// Apply gravity
						moveDirection.y -= gravity * Time.deltaTime;
						// Move the controller
						CharacterController controller = (CharacterController)GetComponent (typeof(CharacterController));
						CollisionFlags flags = controller.Move (moveDirection * Time.deltaTime);
						grounded = (flags & CollisionFlags.CollidedBelow) != 0;
				}
		}

		public void AudioFase ()
		{
				audio.Stop (); 
				audio.loop = true;
				audio.clip = ChinaWall2;
				//audio.PlayOneShot (ChinaWall2);
				audio.Play ();
		}

		void On_ButtonUp (string buttonName)
		{
				if (buttonName == "SomLigar") {
						AudioBotao.SetActive (false);
						AudioBotao2.SetActive (true);
						AudioListener.pause = true;
				} else if (buttonName == "SomDesligar") {
						AudioBotao.SetActive (true);
						AudioBotao2.SetActive (false);
						AudioListener.pause = false;
				}
				if (buttonName == "Pause") {
						Pausar = true;
						Pause.SetActive (false);
						menuPause.SetActive (true);

						//	menuObjeto.renderer.enabled = true;
				}

				if (LigarBotao == true && LigarSlide == false) {
						if (buttonName == "Jump") {
								if (JumpLigado == false) {
										StartCoroutine (JumpTime ());
								}
						}
						if (buttonName == "Fire")
						if (PowerLigado == false) {
								StartCoroutine (PowerTime ());

						}
						if (buttonName == "Slide")
						if (SlideTrue == false) {
								StartCoroutine (SlideTime ());
			
						}
				}
		}
		//	}
//			
//		}


	
		IEnumerator JumpTime ()
		{

				Jump ();

				yield return new WaitForSeconds (0.1f);
				JumpLigado = true;
				yield return new WaitForSeconds (0.3f);
				JumpLigado = false;

		}

		IEnumerator SlideTime ()
		{
		
				Shrink ();
		
				yield return new WaitForSeconds (0.1f);
				SlideTrue = true;
				yield return new WaitForSeconds (0.3f);
				SlideTrue = false;
		
		}

		IEnumerator PowerTime ()
		{
				MagiaRed ();
				
				yield return new WaitForSeconds (0.1f);
				PowerLigado = true;
				yield return new WaitForSeconds (0.3f);
				PowerLigado = false;
		
		}

		void OnEnable ()
		{
		
				//EasyJoystick.On_JoystickMove += On_JoystickMove;	
				//EasyJoystick.On_JoystickMoveEnd += On_JoystickMoveEnd;
				//	EasyButton.On_ButtonPress += On_ButtonPress;
				EasyButton.On_ButtonUp += On_ButtonUp;	
		}
	
		void OnDisable ()
		{
				//EasyJoystick.On_JoystickMove -= On_JoystickMove;	
				//EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
				//	EasyButton.On_ButtonPress -= On_ButtonPress;
				EasyButton.On_ButtonUp -= On_ButtonUp;	
		}
	
		void OnDestroy ()
		{
				//EasyJoystick.On_JoystickMove -= On_JoystickMove;	
				//EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
				//	EasyButton.On_ButtonPress -= On_ButtonPress;
				EasyButton.On_ButtonUp -= On_ButtonUp;	
		}

		public void AnimacaoFinal ()
		{
				if (Apples >= 50) {
						plataform.Speed = 0;
						animarportal.enabled = true;
						StartCoroutine (FrutasMagneto ());
						Particulas.SetActive (true);
						parallax.enabled = false;
						TouchLigar = false;
						AnimarLigado = true;
						PersonSpeed = 10;
						animation.Stop ();
						if (AnimacaoGirl == true) {
								animation.CrossFade ("Victory");
								audio.PlayOneShot (Vitoria);
						}
						if (AnimacaoBoy == true) {
								animation.CrossFade ("Victory2");
								audio.PlayOneShot (Vitoria2);

						}
						
						PortaFinal.SetActive (false);
						ColisorFinal.SetActive (false);
						limit2d.enabled = false;
						Controls.SetActive (false);
						face.valorFace = 1;
						StartCoroutine (FrutasTorrar ());
						StartCoroutine (FinalVitoria ());
						

				} else if (Apples < 50) {
						plataform.Speed = 0;
						parallax.enabled = false;
						TouchLigar = false;
						AnimarLigado = true;
						PersonSpeed = 10;

				}


		}

		public IEnumerator FrutasTorrar ()
		{
				//animation.Stop ();
//		if (AnimacaoBoy == true) {
//			animation.CrossFade ("Running2");
//			
//		}
				yield return new WaitForSeconds (2.5f);
				LigarFogo.SetActive (true);
				fruta01.enabled = true;
				fruta02.enabled = true;
				fruta03.enabled = true;
				fruta04.enabled = true;
				fruta05.enabled = true;
				fruta06.enabled = true;
				fruta07.enabled = true;
				fruta08.enabled = true;
				fruta09.enabled = true;
				fruta10.enabled = true;
		}

		public IEnumerator FinalVitoria ()
		{
				yield return new WaitForSeconds (7);
				Application.LoadLevel (Application.loadedLevel);
		
		}

		public void RecolherMaca (int maca)
		{
				Apples += maca;
				gamestate.Instance.frutas += maca;
				//gamestate.Instance.maca += Apples;
				AppleGUIBranco.text = Apples.ToString ();
				AppleGUIPreto.text = Apples.ToString ();
				audio.PlayOneShot (SoundApples);
		
				if (Apples >= 50) {
						ApplesFra.material.color = Color.red;
			
						//AumentarVidas (1);
						//			estrelas = 0;
			
				}
		}

		public IEnumerator FrutasMagneto ()
		{
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta01.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
				yield return new WaitForSeconds (0.2f);
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta02.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
				yield return new WaitForSeconds (0.2f);
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta03.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
				yield return new WaitForSeconds (0.2f);
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta04.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
				yield return new WaitForSeconds (0.2f);
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta05.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
				yield return new WaitForSeconds (0.2f);
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta06.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
				yield return new WaitForSeconds (0.2f);
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta07.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
				yield return new WaitForSeconds (0.2f);
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta08.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
				yield return new WaitForSeconds (0.2f);
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta09.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
				yield return new WaitForSeconds (0.2f);
//				Apples -= 5;
//				AppleGUIBranco.text = Apples.ToString ();
//				AppleGUIPreto.text = Apples.ToString ();
				Fruta10.enabled = true;
				Sangue.SetActive (true);
				yield return new WaitForSeconds (0.03f);
				Sangue.SetActive (false);
			
	
		}

		public void AnimacaoInicial ()
		{
				//PersonSpeed = 5;
				//StartCoroutine (TimeInicial ());
				Portal.SetActive (true);
				ApplesGeral.SetActive (true);
				MonstersGeral.SetActive (true);
				if (opcoes.ligarbotao == false && DesligarInstrucao == true) {
						FundoInstrucao.SetActive (true);
						StartCoroutine (opcoes.AcaoSlideInicial ());
						StartCoroutine (TimeInicialInstrucao ());

						PersonSpeed = 5;

				}
				if (opcoes.ligarbotao == true) {
						PersonSpeed = 5;
						StartCoroutine (TimeInicial ());

				}
				if (DesligarInstrucao == false) {
						FundoInstrucao.SetActive (false);				
						PersonSpeed = 5;
						StartCoroutine (TimeInicial ());
						//StartCoroutine (TimeInicial ());
				}
		}

		public IEnumerator TimeInicialInstrucao ()
		{	
				AnimarLigado = true;
				plataform.enabled = true;
				plataform.Speed = 8;
				parallax.baseSpeed = 3;
				Correr = true;
				AutoTrigger.SetActive (true);
				yield return new WaitForSeconds (0);
				if (AnimacaoGirl == true) {
						animation.CrossFade ("Running");
				}
				if (AnimacaoBoy == true) {
						animation.CrossFade ("Running2");
				}	

		}

		public IEnumerator TimeInicial ()
		{	
				
				plataform.Speed = 8;
				parallax.baseSpeed = 3;
				LigarGame = true;
				Fumaca.SetActive (false);
				StopSpawnColisor.SetActive (true);
				face.valorFace = 0;
				if (AnimacaoGirl == true) {
						animation.CrossFade ("Running");
				}
				if (AnimacaoBoy == true) {
						animation.CrossFade ("Running2");
				}	
			
				Correr = true;
				AnimarLigado = true;
				yield return new WaitForSeconds (2);
				PartBatida.SetActive (false);
				Controls.SetActive (true);
				Interface.SetActive (true);

				
				TouchLigar = true;
				AnimarLigado = false;
				transform.Translate (Vector3.forward * Time.deltaTime * PersonSpeed);
				yield return new WaitForSeconds (2);
				limit2d.enabled = true;
				PartBatida.SetActive (false);

		}

		public void RecolherCrystal (int crystal)
		{
				Crystals += crystal;
				audio.PlayOneShot (crystalSound);
				if (Crystals == 6) {
			
			
				}
		
		}

		public void AumentarVidas (int vida)
		{ 
				Vidas += vida;
				gamestate.Instance.vidas += vida;
				VidaGuiBranco.text = Vidas.ToString ();
				if (Vidas == 0) {
						StartCoroutine (GameOver ());
							
				}
		}

//		public void AumentarPontos (int ponto)
//		{ 
//				Pontos += ponto;
//				ScoreGui.text = Pontos.ToString ();
//				if (Pontos == 0) {
//						//	GameOver ();
//				}
//		}
		
		public IEnumerator PararPlatform ()
		{
				yield return new WaitForSeconds (0);
				plataform.Speed = 0;
		}
 
		public void Ajuste ()
		{
				var pos = transform.position;
				pos.y += 1.5f;
				transform.position = pos;
		}
//	public IEnumerator AtivarColisao ()
//	{
//		rigidbody.isKinematic = false;
//		yield return new WaitForSeconds (1);
//		rigidbody.isKinematic = true;
//	}

		public void Morte ()
		{		

				fundo1.Ligar = true;
				fundo2.Ligar = true;
				//StartCoroutine (AtivarColisao ());
				var pos = transform.position;
				pos.x -= 0.5f;
				transform.position = pos;
				Fumaca.SetActive (false);
				if (AnimacaoGirl == true) {
						animation.Stop ("Running");
				}
				if (AnimacaoBoy == true) {
						animation.Stop ("Running2");
				}
				//animation.Stop ("Running");
				Correr = false;
				PartBatida.SetActive (true);
				parallax.enabled = false;
				Controls.SetActive (false);
				TouchLigar = false;
				limit2d.enabled = false;
				Interface.SetActive (false);

				//audio.PlayOneShot (Derrota);
				face.valorFace = 3;
				StartCoroutine (MorteTempo ());

				if (AnimacaoGirl == true) {
						audio.PlayOneShot (Derrota);
				}
				if (AnimacaoBoy == true) {
						audio.PlayOneShot (Derrota2);
				}
		}

		public IEnumerator MorteTempo ()
		{
				animation.Stop ();
				if (AnimacaoGirl == true) {
						animation.CrossFade ("Die_Stamp");
				}
				if (gravity == 0) {
						foreach (AnimationState state in animation) {
								state.speed = 2.5f;
						}
				}
				if (AnimacaoBoy == true) {
						animation.CrossFade ("Death-2");
				}
				//animation.CrossFade ("Die_Stamp");
				PersonSpeed = 0;
				if (parallax.enabled == false) {
						AumentarVidas (-1);
						
			
				}
				yield return new WaitForSeconds (0);
				Portal.SetActive (false);
				ApplesGeral.SetActive (false);
				MonstersGeral.SetActive (false);
				FundoMorte.SetActive (true);
				FundoMorte2.SetActive (true);
				yield return new WaitForSeconds (3);
				FundoMorte.SetActive (false);
				FundoMorte2.SetActive (false);
				transform.position = spawnPersonagem.transform.position;
				Plat.transform.position = spawnPlat.transform.position;
				plataform.enabled = true;
				plataform.Speed = 8;
				parallax.enabled = true;
				Fumaca.SetActive (true);
				AnimacaoInicial ();

		}

		public void Jump ()
		{
				StartCoroutine (ControlsShrink ());
				Swipe.text = "ARRASTA PARA CIMA";
				if (AnimacaoGirl == true) {
						audio.PlayOneShot (Pulo);
				}
				if (AnimacaoBoy == true) {
						audio.PlayOneShot (Pulo2);
				}
				SlideTrue = true;
				PowerLigado = true;
				animation.Stop ();
				if (AnimacaoGirl == true) {
						animation.CrossFade ("Jump");
						//animation ["Jump"].speed = 1f;
				}
				if (AnimacaoBoy == true) {
						animation.CrossFade ("Jump2");
						animation ["Jump2"].speed = 0.8f;
				}
				//animation.CrossFade ("Jump");
				StartCoroutine (JumpRunning ());
				moveDirection.y = jumpSpeed;
				// Apply gravity
				moveDirection.y -= gravity * Time.deltaTime;
				// Move the controller
				CharacterController controller = (CharacterController)GetComponent (typeof(CharacterController));
				CollisionFlags flags = controller.Move (moveDirection * Time.deltaTime);
				grounded = (flags & CollisionFlags.CollidedBelow) != 0;

	
		}

		public IEnumerator JumpRunning ()
		{
				yield return new WaitForSeconds (0.7f);
				SlideTrue = false;
				PowerLigado = false;
				//				foreach (AnimationState state in animation) {
				//state.speed = 2;
				//			}
				if (Correr == true) {
						if (AnimacaoGirl == true) {
								animation.CrossFade ("Running");
						}
						if (AnimacaoBoy == true) {
								animation.CrossFade ("Running2");
						}
						//animation.CrossFade ("Running");
				}
		
		
		}
	
		public void Shrink ()
		{
				if (ShrinkLigar == true) {
			
						StartCoroutine (ControlsTime ());
						Swipe.text = "ARRASTA PARA BAIXO";

						if (testeShrink == false) {
								Fumaca.SetActive (false);
								animation.Stop ();
								if (AnimacaoGirl == true) {
										animation.CrossFade ("Slide0");
										animation ["Slide0"].speed = 1f;
								}
								if (AnimacaoBoy == true) {
										animation.CrossFade ("Slide00");
										animation ["Slide00"].speed = 1f;
								}
//						animation.CrossFade ("Slide0");
//						animation ["Slide0"].speed = 1f;
								animation.Stop ();
								JumpLigado = true;
								PowerLigado = true;
						
						}
						if (testeShrink == true) {
								Fumaca.SetActive (false);
								//LigarFumaca = false;
								animation.Stop ();
								if (AnimacaoGirl == true) {
										animation.CrossFade ("Slide1");
										animation ["Slide1"].speed = 1f;

								}
								if (AnimacaoBoy == true) {
										animation.CrossFade ("Slide01");
										animation ["Slide01"].speed = 1f;
								}
								//	animation.CrossFade ("Slide1");
								//	animation ["Slide1"].speed = 1f;
								ligarRunning = false;
								JumpLigado = true;
								PowerLigado = true;
						
						}
						if (testeShrink == false) {
								if (AnimacaoGirl == true) {
										animation.CrossFade ("Slide1");
										animation ["Slide1"].speed = 1f;
								}
								if (AnimacaoBoy == true) {
										animation.CrossFade ("Slide01");
										animation ["Slide01"].speed = 1f;
								}
								//animation.CrossFade ("Slide1");
								//animation ["Slide1"].speed = 1f;
								animation.Stop ();
								if (AnimacaoGirl == true) {
										animation.CrossFade ("Slide2");
										animation ["Slide2"].speed = 1f;
								}
								if (AnimacaoBoy == true) {
										animation.CrossFade ("Slide02");
										animation ["Slide02"].speed = 1f;
								}
								//animation.CrossFade ("Slide2");
								//animation ["Slide2"].speed = 1f;
								controle.height = 0.0f;
								gravity = 0;
								StartCoroutine (SlideRunning ());
						}
				}

		}

		public IEnumerator SlideRunning ()
		{
				audio.PlayOneShot (SlideAudio);
				animation.Stop ();
				if (AnimacaoGirl == true) {
						animation.CrossFade ("Slide2");
						animation ["Slide2"].speed = 0.5f;
				}
				if (AnimacaoBoy == true) {
						animation.CrossFade ("Slide02");
						animation ["Slide02"].speed = 0.5f;
				}

//				animation.CrossFade ("Slide2");
//				animation ["Slide2"].speed = 0.5f;
				SlideLiga = false;
					
//				}
				yield return new WaitForSeconds (0.6f);

				foreach (AnimationState state in animation) {

						PowerLigado = false;
						JumpLigado = false;
						state.speed = 1;
						controle = GetComponent<CharacterController> ();
						controle.center = new Vector3 (0, 1.61f, 0);
						controle.height = 2f;
						gravity = 50;	
//						Vector3 pos = transform.position;
//						pos.z = Mathf.Clamp(pos.z, -0, 0);
//						pos.y = Mathf.Clamp(pos.y, 0.99f, 10);
//						transform.position = pos;
						animation.Stop ();
						if (parallax.enabled == true) {

								if (ligarRunning == true && testeShrink == false) {
										Fumaca.SetActive (true);
										if (AnimacaoGirl == true) {
												animation.CrossFade ("Running");
										}
										if (AnimacaoBoy == true) {
												animation.CrossFade ("Running2");
										}
										//animation.CrossFade ("Running");
								}
						}
				}
				
		}

		public IEnumerator GameOver ()
		{
				yield return new WaitForSeconds (1.2f);
				Application.LoadLevel ("GameOver");	
		}



}