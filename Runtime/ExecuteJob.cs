using Unity.Burst;
using Unity.Jobs;

namespace M6502
{
	[BurstCompile]
	public struct ExecuteJob : IJob
	{
		public ProcessorState State;

		private bool interrupt;
		private bool lastInterrupt;

		public void Execute()
		{
			interrupt = false;
		}

		private byte ReadMemoryValue(int address)
		{
			byte value = State.Memory[address & 0xFFFF];
			IncrementCycleCount();
			return value;
		}

		private void IncrementCycleCount()
		{
			State.CycleCount++;
			//CycleCountIncrementedAction();

			lastInterrupt = interrupt;
			interrupt = State.Flags.NMI || (State.Flags.IRQ && !State.Flags.InterruptDisable); 
		}
	}
}
