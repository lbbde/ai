
namespace FSM {

	public class FSMState {

		public int type;
		public object parent;
	
		public virtual void enter() {

		}

		public virtual void exit() {

		}

		public virtual void update() {

		}

		public virtual void init() {

		}

		public virtual int checkTransitions() {

		}
	}

	enum AI_STATE {
		APPROACH,
		ATTACK,
		EVADE,
		GET_POWER_UP,
		IDLE
	}

}
