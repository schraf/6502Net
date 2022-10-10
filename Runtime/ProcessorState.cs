using Unity.Collections;

namespace M6502
{
	public struct ProcessorFlags
	{
		/// Set to true if the result of an operation is negative in ADC and SBC operations. 
		/// Remember that 128-256 represent negative numbers when doing signed math.
		/// In shift operations the sign holds the carry.
		public bool Negative;

		/// This flag is set when an overflow occurs. An overflow happens if the high bit(7) changes during the operation. Remember that values from 128-256 are negative values
		/// as the high bit is set to 1.
		/// Examples:
		/// 64 + 64 = -128 
		/// -128 + -128 = 0
		public bool Overflow;

		/// This flag is set when a break occurs. A break happens when a BRK is executed by the processor.
		public bool Break;

		/// Binary Coded Decimal Mode is set/cleared via this flag.
		/// when this mode is in effect, a byte represents a number from 0-99. 
		public bool Decimal;

		/// This determines if Interrupts are currently disabled.
		/// This flag is turned on during a reset to prevent an interrupt from occuring during startup/Initialization.
		/// If this flag is true, then the IRQ pin is ignored.
		public bool InterruptDisable;

		/// Is true if one of the registers is set to zero.
		public bool Zero;

		/// This is the carry flag. when adding, if the result is greater than 255 or 99 in BCD Mode, then this bit is enabled. 
		/// In subtraction this is reversed and set to false if a borrow is required IE the result is less than 0
		public bool Carry;

		/// Set to true when an NMI should occur
		public bool NMI;

		/// Set to true when an IRQ has occurred and is being processed by the CPU
		public bool IRQ;
	}

	public struct ProcessorState
	{
		public int PC;
		public int SP;
		public int CycleCount;
		public int A;
		public int X;
		public int Y;
		public ProcessorFlags Flags;
		public NativeArray<byte> Memory;
	}
}
