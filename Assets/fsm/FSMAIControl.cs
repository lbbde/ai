using UnityEngine;
using GAME;

namespace FSM {

	public class FSMAIControl : AIControl {
		private FSMMachine fsmMachine;

		public GameObject nearestAsteroid;
		public GameObject nearestPowerup;
		public float nearestAsteroidDist;
		public float nearestPowerupDist;
		public Vector3 collidePoint;
		public bool willCollide;
		public bool powerupNear;
		public float safetyRadius;

		FSMAIControl() {
			fsmMachine.addState(new StateIdle());
			fsmMachine.addState(new StateEvade());
			fsmMachine.addState(new StateAttack());
			fsmMachine.addState(new StateGetPowerup());

			FSMState approch = new StateApproch();
			fsmMachine.addState(approch);
			fsmMachine.setDefaultState(approch);
		}

		public void update(int t) {
			if (!ship) {
				fsmMachine.reset();
			} else {
				updatePerceptions(t);
				fsmMachine.updateMachine(t);
			}	
		}


		public void updatePerceptions(int t) {
			nearestAsteroid = GameHelper.getClosestGameObject();
			nearestPowerup = GameHelper.getClosestGameObject();

			willCollide = false;

			
		}

		public void init();
	}
}

