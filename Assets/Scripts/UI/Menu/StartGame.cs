using System.Collections;
using UnityEngine;
using UI.Common;
using Game;
using UnityEngine.UI;
namespace UI.MenuUI{
	public class StartGame :MenuWindow {
		[SerializeField] Button startGameButton;
		[SerializeField] private MenuCanvas menuCanvas;
		public override void Init(bool isOpen = false) {
			base.Init(isOpen);
			menuCanvas = GetComponentInParent<MenuCanvas>();
			startGameButton.onClick.AddListener(StartGameMovement);
		}

        private void StartGameMovement() {
			menuCanvas.inGameUIManager.OpenGame();
			menuCanvas.inGameUIManager.UnfreezeGame();
			menuCanvas.inGameUIManager.ContinGameSwitcher(true);
		}
	}
}