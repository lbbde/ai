using System.Collections.Generic;

namespace FSM {

	public class FSMMachine : FSMState {

		public int type;
		private List<FSMState> states;
		private FSMState currentState;
		private FSMState defaultState;
		private FSMState goalState;
		private int goalId;

		public virtual void updateMachine(int t) {
			if (states.Count == 0) {
				return;
			}

			if (!currentState) {
				currentState = defaultState;
			}

			if (!currentState) {
				return;
			}

			int preStateId = currentState.type;
			goalId = currentState.checkTransitions();

			if (preStateId != goalId) {
				if (transitionState()) {
					currentState.exit();
					currentState = goalState;
					goalState.enter();
				}
			}

			currentState.update();
		}

		public virtual void addState(FSMState add) {
			states.Add(add);
		}

		public virtual void setDefaultState(FSMState defaultState) {
			defaultState = defaultState;
		}

		public virtual void setGoalId() {}
		public virtual bool transitionState() {}
		public virtual void reset() {}
	}
}
