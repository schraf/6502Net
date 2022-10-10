namespace M6502
{
	public static class Reset
	{
		public static void ResetProcessorState(ref ProcessorState state)
		{
			state.CycleCount = 0;
			state.SP = 0x1FD;
			state.PC = state.Memory[0xFFFC] | (state.Memory[0xFFFD] << 8);
			state.Flags.Break = false;
			state.Flags.InterruptDisable = true;
			state.Flags.NMI = false;
			state.Flags.IRQ = false;
		}
	}
}
