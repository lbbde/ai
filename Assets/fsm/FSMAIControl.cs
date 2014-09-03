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

		public void update();
		public void updatePerceptions();
		public void init();
	}
}

