
namespace M6502
{
	/// Used to help simulating. This class contains the disassembly properties.
	public class Disassembly
	{
		/// The low Address
		public string LowAddress { get; set; }

		/// The High Address
		public string HighAddress { get; set; }

		/// The string representation of the OpCode
		public string OpCodeString { get; set; }

		/// The disassembly of the current step
		public string DisassemblyOutput { get; set; }
	}
}
